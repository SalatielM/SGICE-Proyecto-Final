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
/// Provee servicios de administración para los directores de centros educativos.
/// </summary>
public class DirectorServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Director> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Director>(ctx);
        return repo.ObtenerTodos();
    }

    public Director ObtenerPorId(int idDirector)
    {
        Validador.ValidarRangoPositivo(idDirector, "IdDirector");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Director>(ctx);
        var director = repo.ObtenerPorId(idDirector);

        if (director == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Director), idDirector);
        }

        return director;
    }

    public IEnumerable<Director> ObtenerActivos()
    {
        using var ctx = new AppDbContext();
        return ctx.Director
            .AsNoTracking()
            .Include(d => d.Estado)
            .Where(d => d.Estado != null && d.Estado.Nombre == "Activo")
            .ToList();
    }

    public IEnumerable<DirectorDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Director
            .AsNoTracking()
            .Include(d => d.Estado)
            .Select(d => new DirectorDTO
            {
                IdDirector = d.Id,
                Foto = d.Foto,
                Nombre = d.Nombre,
                Apellido = d.Apellido,
                Cedula = d.Cedula,
                Telefono = d.Telefono,
                Correo = d.Correo,
                EstadoId = d.EstadoId ?? 0,
                Estado = d.Estado != null ? d.Estado.Nombre : string.Empty,
                FechaInicia = d.FechaInicia
            }).ToList();
    }

    public void Agregar(Director director)
    {
        if (director == null) throw new ArgumentNullException(nameof(director));

        Validar(director);

        using var ctx = new AppDbContext();
        string cedula = director.Cedula.Replace("-", "").Replace(" ", "").Trim();
        if (ctx.Director.Any(d => d.Cedula.Replace("-", "").Replace(" ", "").Trim() == cedula))
        {
            throw new ReglaNegocioExcepcion("Ya existe un director registrado con esa cédula.");
        }

        _estados.ValidarEstado(director.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        director.UsuarioRegistroId = SesionActual.Usuario.Id;
        director.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Director>(ctx);
        repo.Agregar(director);

        _auditoria.Registrar("Director", director.Id, TipoAccionAuditoria.Crear, string.Empty, $"Director creado: {director.Nombre} {director.Apellido}");
    }

    public void Actualizar(Director director)
    {
        if (director == null) throw new ArgumentNullException(nameof(director));

        Validar(director);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Director>(ctx);
        var existente = repo.ObtenerPorId(director.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Director), director.Id);
        }

        string cedula = director.Cedula.Replace("-", "").Replace(" ", "").Trim();
        if (ctx.Director.Any(d => d.Cedula.Replace("-", "").Replace(" ", "").Trim() == cedula && d.Id != director.Id))
        {
            throw new ReglaNegocioExcepcion("La cédula ya se encuentra registrada en otro director.");
        }

        _estados.ValidarEstado(director.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        director.UsuarioRegistroId = existente.UsuarioRegistroId;
        director.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(director);
        _auditoria.Registrar("Director", director.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, director.Nombre);
    }

    public void CambiarEstado(int idDirector, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idDirector, "IdDirector");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Director>(ctx);
        var director = repo.ObtenerPorId(idDirector);

        if (director == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Director), idDirector);
        }

        director.EstadoId = nuevoEstadoId;
        director.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(director);
        _auditoria.Registrar("Director", idDirector, TipoAccionAuditoria.Actualizar, "Estado modificado", $"Nuevo Estado: {nuevoEstadoId}");
    }

    public IEnumerable<DirectorDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(d =>
            d.Nombre.ToLower().Contains(limpio) ||
            d.Apellido.ToLower().Contains(limpio) ||
            d.Cedula.Contains(limpio));
    }

    private static void Validar(Director director)
    {
        Validador.ValidarRequerido(director.Nombre, "Nombre");
        Validador.ValidarLongitud(director.Nombre, 2, 50, "Nombre");

        Validador.ValidarRequerido(director.Apellido, "Apellido");
        Validador.ValidarLongitud(director.Apellido, 2, 50, "Apellido");

        Validador.ValidarCedula(director.Cedula, "Cédula");
        Validador.ValidarTelefono(director.Telefono, "Teléfono");
        Validador.ValidarCorreo(director.Correo, "Correo Electrónico", obligatorio: true);
    }
}
