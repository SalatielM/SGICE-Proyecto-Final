using Microsoft.EntityFrameworkCore;
using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Utilidades;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Seguridad;

/// <summary>
/// Gestiona las operaciones de negocio del personal escolar (docente, técnico y administrativo).
/// </summary>
public class PersonalServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Personal> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Personal>(ctx);
        return repo.ObtenerTodos();
    }

    public Personal ObtenerPorId(int idPersonal)
    {
        Validador.ValidarRangoPositivo(idPersonal, "IdPersonal");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Personal>(ctx);
        var personal = repo.ObtenerPorId(idPersonal);

        if (personal == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Personal), idPersonal);
        }

        return personal;
    }

    public Personal ObtenerPorCodigo(string codigo)
    {
        Validador.ValidarRequerido(codigo, "Código de Personal");

        string limpio = codigo.Trim().ToLower();
        using var ctx = new AppDbContext();
        var personal = ctx.Personal.FirstOrDefault(p => p.CodPersonal.ToLower() == limpio);

        if (personal == null)
        {
            throw new ReglaNegocioExcepcion($"No se encontró ningún miembro del personal con el código '{codigo}'.");
        }

        return personal;
    }

    public IEnumerable<PersonalDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Personal
            .AsNoTracking()
            .Include(p => p.Puesto)
            .Include(p => p.Estado)
            .Select(p => new PersonalDTO
            {
                IdPersonal = p.Id,
                Foto = p.Foto,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Cedula = p.Cedula,
                CodPersonal = p.CodPersonal,
                Telefono = p.Telefono,
                Correo = p.Correo,
                PuestoId = p.PuestoId,
                Puesto = p.Puesto != null ? p.Puesto.Nombre : string.Empty,
                EstadoId = p.EstadoId ?? 0,
                Estado = p.Estado != null ? p.Estado.Nombre : string.Empty
            }).ToList();
    }

    public void ValidarEstadoPersonal(int idPersonal)
    {
        var personal = ObtenerPorId(idPersonal);
        if (personal.EstadoId != (int)EstadoGenerico.Activo)
        {
            throw new ReglaNegocioExcepcion($"El personal '{personal.Nombre} {personal.Apellido}' está inactivo y no puede asignarse.");
        }
    }

    public void Agregar(Personal personal)
    {
        if (personal == null) throw new ArgumentNullException(nameof(personal));

        Validar(personal);

        using var ctx = new AppDbContext();
        string cedula = personal.Cedula.Replace("-", "").Replace(" ", "").Trim();
        if (ctx.Personal.Any(p => p.Cedula.Replace("-", "").Replace(" ", "").Trim() == cedula))
        {
            throw new ReglaNegocioExcepcion("Ya existe un miembro del personal registrado con la misma cédula.");
        }

        string codigo = personal.CodPersonal.Trim().ToLower();
        if (ctx.Personal.Any(p => p.CodPersonal.ToLower() == codigo))
        {
            throw new ReglaNegocioExcepcion("Ya existe un miembro del personal registrado con el mismo código.");
        }

        Validador.ValidarRangoPositivo(personal.PuestoId, "Puesto");
        Validador.ValidarRangoPositivo(personal.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(personal.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        personal.UsuarioRegistroId = SesionActual.Usuario.Id;
        personal.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Personal>(ctx);
        repo.Agregar(personal);

        _auditoria.Registrar("Personal", personal.Id, TipoAccionAuditoria.Crear, string.Empty, $"Personal creado: {personal.Nombre} {personal.Apellido}");
    }

    public void Actualizar(Personal personal)
    {
        if (personal == null) throw new ArgumentNullException(nameof(personal));

        Validar(personal);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Personal>(ctx);
        var existente = repo.ObtenerPorId(personal.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Personal), personal.Id);
        }

        string cedula = personal.Cedula.Replace("-", "").Replace(" ", "").Trim();
        if (ctx.Personal.Any(p => p.Cedula.Replace("-", "").Replace(" ", "").Trim() == cedula && p.Id != personal.Id))
        {
            throw new ReglaNegocioExcepcion("Ya existe otro personal registrado con esa misma cédula.");
        }

        string codigo = personal.CodPersonal.Trim().ToLower();
        if (ctx.Personal.Any(p => p.CodPersonal.ToLower() == codigo && p.Id != personal.Id))
        {
            throw new ReglaNegocioExcepcion("Ya existe otro personal registrado con ese mismo código.");
        }

        _estados.ValidarEstado(personal.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        personal.UsuarioRegistroId = existente.UsuarioRegistroId;
        personal.FechaRegistro = existente.FechaRegistro;
        personal.UsuarioActualizacionId = SesionActual.Usuario.Id;
        personal.FechaActualizacion = DateTime.Now;

        repo.Actualizar(personal);
        _auditoria.Registrar("Personal", personal.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, personal.Nombre);
    }

    public void CambiarEstado(int idPersonal, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idPersonal, "IdPersonal");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Personal>(ctx);
        var personal = repo.ObtenerPorId(idPersonal);

        if (personal == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Personal), idPersonal);
        }

        if (personal.EstadoId == nuevoEstadoId)
        {
            throw new ReglaNegocioExcepcion("El personal ya posee el estado seleccionado.");
        }

        int estadoAnterior = personal.EstadoId ?? 0;
        personal.EstadoId = nuevoEstadoId;
        personal.FechaActualizacion = DateTime.Now;
        personal.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(personal);
        _auditoria.Registrar("Personal", idPersonal, TipoAccionAuditoria.Actualizar, $"Estado:{estadoAnterior}", $"Estado:{nuevoEstadoId}");
    }

    public IEnumerable<PersonalDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(p =>
            p.Nombre.ToLower().Contains(limpio) ||
            p.Apellido.ToLower().Contains(limpio) ||
            p.Cedula.Contains(limpio) ||
            p.CodPersonal.ToLower().Contains(limpio));
    }

    private static void Validar(Personal personal)
    {
        Validador.ValidarRequerido(personal.Nombre, "Nombre");
        Validador.ValidarLongitud(personal.Nombre, 2, 50, "Nombre");

        Validador.ValidarRequerido(personal.Apellido, "Apellido");
        Validador.ValidarLongitud(personal.Apellido, 2, 50, "Apellido");

        Validador.ValidarCedula(personal.Cedula, "Cédula");

        Validador.ValidarRequerido(personal.CodPersonal, "Código de Personal");
        Validador.ValidarLongitud(personal.CodPersonal, 3, 10, "Código de Personal");

        Validador.ValidarTelefono(personal.Telefono, "Teléfono");
        Validador.ValidarCorreo(personal.Correo, "Correo Electrónico", obligatorio: false);
    }
}
