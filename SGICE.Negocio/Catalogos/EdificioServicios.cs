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
/// Gestiona los edificios del centro educativo y sus pisos.
/// </summary>
public class EdificioServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Edificio> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Edificio>(ctx);
        return repo.ObtenerTodos();
    }

    public Edificio ObtenerPorId(int idEdificio)
    {
        Validador.ValidarRangoPositivo(idEdificio, "IdEdificio");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Edificio>(ctx);
        var edificio = repo.ObtenerPorId(idEdificio);

        if (edificio == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Edificio), idEdificio);
        }

        return edificio;
    }

    public IEnumerable<EdificioDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Edificio
            .AsNoTracking()
            .Include(e => e.Estado)
            .Include(e => e.UsuarioRegistro)
            .Select(e => new EdificioDTO
            {
                IdEdificio = e.Id,
                Nombre = e.Nombre,
                CodEdificio = e.CodEdificio,
                CantidadPisos = e.CantidadPisos.ToString(),
                Descripcion = e.Descripcion,
                EstadoId = e.EstadoId ?? 0,
                Estado = e.Estado != null ? e.Estado.Nombre : string.Empty,
                FechaConstruccion = e.FechaConstruccion,
                FechaRegistro = e.FechaRegistro,
                FechaActualizacion = e.FechaActualizacion ?? DateTime.MinValue,
                UsuarioRegistroId = e.UsuarioRegistroId,
                UsuarioRegistro = e.UsuarioRegistro != null ? e.UsuarioRegistro.NombreUsuario : string.Empty
            }).ToList();
    }

    public void Agregar(Edificio edificio)
    {
        if (edificio == null) throw new ArgumentNullException(nameof(edificio));

        Validador.ValidarRequerido(edificio.Nombre, "Nombre del Edificio");
        Validador.ValidarLongitud(edificio.Nombre, 2, 100, "Nombre del Edificio");

        Validador.ValidarRequerido(edificio.CodEdificio, "Código del Edificio");
        Validador.ValidarLongitud(edificio.CodEdificio, 2, 15, "Código del Edificio");

        Validador.ValidarRangoPositivo(edificio.CantidadPisos, "Cantidad de Pisos");
        Validador.ValidarRangoPositivo(edificio.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(edificio.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        string codigo = edificio.CodEdificio.Trim().ToLower();
        if (ctx.Edificio.Any(e => e.CodEdificio.ToLower() == codigo))
        {
            throw new ReglaNegocioExcepcion($"Ya existe un edificio registrado con el código '{edificio.CodEdificio}'.");
        }

        edificio.UsuarioRegistroId = SesionActual.Usuario.Id;
        edificio.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Edificio>(ctx);
        repo.Agregar(edificio);

        _auditoria.Registrar("Edificio", edificio.Id, TipoAccionAuditoria.Crear, string.Empty, edificio.Nombre);
    }

    public void Actualizar(Edificio edificio)
    {
        if (edificio == null) throw new ArgumentNullException(nameof(edificio));

        Validador.ValidarRequerido(edificio.Nombre, "Nombre del Edificio");
        Validador.ValidarRequerido(edificio.CodEdificio, "Código del Edificio");
        Validador.ValidarRangoPositivo(edificio.CantidadPisos, "Cantidad de Pisos");
        _estados.ValidarEstado(edificio.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Edificio>(ctx);
        var existente = repo.ObtenerPorId(edificio.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Edificio), edificio.Id);
        }

        string codigo = edificio.CodEdificio.Trim().ToLower();
        if (ctx.Edificio.Any(e => e.CodEdificio.ToLower() == codigo && e.Id != edificio.Id))
        {
            throw new ReglaNegocioExcepcion($"El código '{edificio.CodEdificio}' ya está en uso por otro edificio.");
        }

        edificio.UsuarioRegistroId = existente.UsuarioRegistroId;
        edificio.UsuarioActualizacionId = SesionActual.Usuario.Id;
        edificio.FechaActualizacion = DateTime.Now;

        repo.Actualizar(edificio);
        _auditoria.Registrar("Edificio", edificio.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, edificio.Nombre);
    }

    public void CambiarEstado(int idEdificio, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idEdificio, "IdEdificio");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Edificio>(ctx);
        var edificio = repo.ObtenerPorId(idEdificio);

        if (edificio == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Edificio), idEdificio);
        }

        edificio.EstadoId = nuevoEstadoId;
        edificio.FechaActualizacion = DateTime.Now;
        edificio.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(edificio);
        _auditoria.Registrar("Edificio", idEdificio, TipoAccionAuditoria.Actualizar, "Estado modificado", $"Nuevo Estado: {nuevoEstadoId}");
    }

    public IEnumerable<EdificioDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(e =>
            e.Nombre.ToLower().Contains(limpio) ||
            e.CodEdificio.ToLower().Contains(limpio));
    }
}
