using Microsoft.EntityFrameworkCore;
using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;
using SGICE.Negocio.Utilidades;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Catalogos;

/// <summary>
/// Provee servicios de administración para los puestos ocupacionales del personal.
/// </summary>
public class PuestoServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Puesto> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Puesto>(ctx);
        return repo.ObtenerTodos();
    }

    public Puesto ObtenerPorId(int idPuesto)
    {
        Validador.ValidarRangoPositivo(idPuesto, "IdPuesto");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Puesto>(ctx);
        var puesto = repo.ObtenerPorId(idPuesto);

        if (puesto == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Puesto), idPuesto);
        }

        return puesto;
    }

    public IEnumerable<PuestoDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Puesto
            .AsNoTracking()
            .Include(p => p.Estado)
            .Select(p => new PuestoDTO
            {
                IdPuesto = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                EstadoId = p.EstadoId ?? 0,
                Estado = p.Estado != null ? p.Estado.Nombre : string.Empty
            }).ToList();
    }

    public void ValidarPuestoEstado(int idPuesto)
    {
        var puesto = ObtenerPorId(idPuesto);
        if (puesto.EstadoId != (int)EstadoGenerico.Activo)
        {
            throw new ReglaNegocioExcepcion($"El puesto '{puesto.Nombre}' no se encuentra activo.");
        }
    }

    public void Agregar(Puesto puesto)
    {
        if (puesto == null) throw new ArgumentNullException(nameof(puesto));

        Validador.ValidarRequerido(puesto.Nombre, "Nombre del Puesto");
        Validador.ValidarLongitud(puesto.Nombre, 2, 50, "Nombre del Puesto");
        Validador.ValidarRangoPositivo(puesto.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(puesto.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        string nombre = puesto.Nombre.Trim().ToLower();
        if (ctx.Puesto.Any(p => p.Nombre.ToLower() == nombre))
        {
            throw new ReglaNegocioExcepcion($"Ya existe un puesto registrado con el nombre '{puesto.Nombre}'.");
        }

        puesto.UsuarioRegistroId = SesionActual.Usuario.Id;
        puesto.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Puesto>(ctx);
        repo.Agregar(puesto);

        _auditoria.Registrar("Puesto", puesto.Id, TipoAccionAuditoria.Crear, string.Empty, puesto.Nombre);
    }

    public void Actualizar(Puesto puesto)
    {
        if (puesto == null) throw new ArgumentNullException(nameof(puesto));

        Validador.ValidarRequerido(puesto.Nombre, "Nombre del Puesto");
        _estados.ValidarEstado(puesto.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Puesto>(ctx);
        var existente = repo.ObtenerPorId(puesto.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Puesto), puesto.Id);
        }

        string nombre = puesto.Nombre.Trim().ToLower();
        if (ctx.Puesto.Any(p => p.Nombre.ToLower() == nombre && p.Id != puesto.Id))
        {
            throw new ReglaNegocioExcepcion($"El nombre '{puesto.Nombre}' ya pertenece a otro puesto.");
        }

        puesto.UsuarioRegistroId = existente.UsuarioRegistroId;
        puesto.UsuarioActualizacionId = SesionActual.Usuario.Id;
        puesto.FechaActualizacion = DateTime.Now;

        repo.Actualizar(puesto);
        _auditoria.Registrar("Puesto", puesto.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, puesto.Nombre);
    }

    public void CambiarEstado(int idPuesto, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idPuesto, "IdPuesto");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Puesto>(ctx);
        var puesto = repo.ObtenerPorId(idPuesto);

        if (puesto == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Puesto), idPuesto);
        }

        puesto.EstadoId = nuevoEstadoId;
        puesto.FechaActualizacion = DateTime.Now;
        puesto.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(puesto);
        _auditoria.Registrar("Puesto", idPuesto, TipoAccionAuditoria.Actualizar, "Estado modificado", $"Nuevo Estado: {nuevoEstadoId}");
    }

    public IEnumerable<PuestoDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(p => p.Nombre.ToLower().Contains(limpio));
    }
}
