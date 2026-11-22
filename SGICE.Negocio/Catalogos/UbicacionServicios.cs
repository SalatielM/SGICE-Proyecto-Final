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
/// Gestiona las aulas, laboratorios y oficinas del centro educativo.
/// </summary>
public class UbicacionServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Ubicacion> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Ubicacion>(ctx);
        return repo.ObtenerTodos();
    }

    public List<Ubicacion> ObtenerTodo()
    {
        return ObtenerTodos().ToList();
    }

    public Ubicacion ObtenerPorId(int idUbicacion)
    {
        Validador.ValidarRangoPositivo(idUbicacion, "IdUbicacion");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Ubicacion>(ctx);
        var ubicacion = repo.ObtenerPorId(idUbicacion);

        if (ubicacion == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Ubicacion), idUbicacion);
        }

        return ubicacion;
    }

    public Ubicacion ObtenerPorNombreUbicacion(string nombre)
    {
        return ObtenerPorNombre(nombre);
    }

    public Ubicacion ObtenerPorNombre(string nombre)
    {
        Validador.ValidarRequerido(nombre, "Nombre de Ubicación");

        string limpio = nombre.Trim().ToLower();
        using var ctx = new AppDbContext();
        var ubicacion = ctx.Ubicacion.FirstOrDefault(u => u.Nombre.ToLower() == limpio);

        if (ubicacion == null)
        {
            throw new ReglaNegocioExcepcion($"La ubicación '{nombre}' no existe.");
        }

        return ubicacion;
    }

   

    public int Contar()
    {
        using var ctx = new AppDbContext();
        return ctx.Ubicacion.Count();
    }

    public IEnumerable<UbicacionDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Ubicacion
            .AsNoTracking()
            .Include(u => u.Edificio)
            .Include(u => u.Estado)
            .Select(u => new UbicacionDTO
            {
                IdUbicacion = u.Id,
                Nombre = u.Nombre,
                Dimencion = u.Dimencion,
                Piso = u.Piso,
                EdificioId = u.EdificioId,
                Edificio = u.Edificio != null ? u.Edificio.Nombre : string.Empty,
                Descripcion = u.Descripcion,
                EstadoId = u.EstadoId ?? 0,
                Estado = u.Estado != null ? u.Estado.Nombre : string.Empty
            }).ToList();
    }

    public void ValidarEstadoUbicacion(int idUbicacion)
    {
        var ubicacion = ObtenerPorId(idUbicacion);
        if (ubicacion.EstadoId != (int)EstadoGenerico.Activo)
        {
            throw new ReglaNegocioExcepcion($"La ubicación '{ubicacion.Nombre}' no se encuentra activa para recibir activos.");
        }
    }

    public void Agregar(Ubicacion ubicacion)
    {
        if (ubicacion == null) throw new ArgumentNullException(nameof(ubicacion));

        Validador.ValidarRequerido(ubicacion.Nombre, "Nombre de Ubicación");
        Validador.ValidarLongitud(ubicacion.Nombre, 2, 50, "Nombre de Ubicación");
        Validador.ValidarRangoPositivo(ubicacion.Piso, "Piso", permitirCero: true);
        Validador.ValidarRangoPositivo(ubicacion.EdificioId, "Edificio");
        Validador.ValidarRangoPositivo(ubicacion.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(ubicacion.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        string nombre = ubicacion.Nombre.Trim().ToLower();
        if (ctx.Ubicacion.Any(u => u.Nombre.ToLower() == nombre && u.EdificioId == ubicacion.EdificioId))
        {
            throw new ReglaNegocioExcepcion($"Ya existe una ubicación con el nombre '{ubicacion.Nombre}' en el edificio seleccionado.");
        }

        ubicacion.UsuarioRegistroId = SesionActual.Usuario.Id;
        ubicacion.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Ubicacion>(ctx);
        repo.Agregar(ubicacion);

        _auditoria.Registrar("Ubicacion", ubicacion.Id, TipoAccionAuditoria.Crear, string.Empty, ubicacion.Nombre);
    }

    public void Actualizar(Ubicacion ubicacion)
    {
        if (ubicacion == null) throw new ArgumentNullException(nameof(ubicacion));

        Validador.ValidarRequerido(ubicacion.Nombre, "Nombre de Ubicación");
        Validador.ValidarRangoPositivo(ubicacion.Piso, "Piso", permitirCero: true);
        Validador.ValidarRangoPositivo(ubicacion.EdificioId, "Edificio");
        _estados.ValidarEstado(ubicacion.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Ubicacion>(ctx);
        var existente = repo.ObtenerPorId(ubicacion.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Ubicacion), ubicacion.Id);
        }

        string nombre = ubicacion.Nombre.Trim().ToLower();
        if (ctx.Ubicacion.Any(u => u.Nombre.ToLower() == nombre && u.EdificioId == ubicacion.EdificioId && u.Id != ubicacion.Id))
        {
            throw new ReglaNegocioExcepcion($"Ya existe otra ubicación con el nombre '{ubicacion.Nombre}' en el mismo edificio.");
        }

        ubicacion.UsuarioRegistroId = existente.UsuarioRegistroId;
        ubicacion.UsuarioActualizacionId = SesionActual.Usuario.Id;
        ubicacion.FechaActualizacion = DateTime.Now;

        repo.Actualizar(ubicacion);
        _auditoria.Registrar("Ubicacion", ubicacion.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, ubicacion.Nombre);
    }

    public void CambiarEstado(int idUbicacion, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idUbicacion, "IdUbicacion");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Ubicacion>(ctx);
        var ubicacion = repo.ObtenerPorId(idUbicacion);

        if (ubicacion == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Ubicacion), idUbicacion);
        }

        ubicacion.EstadoId = nuevoEstadoId;
        ubicacion.FechaActualizacion = DateTime.Now;
        ubicacion.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(ubicacion);
        _auditoria.Registrar("Ubicacion", idUbicacion, TipoAccionAuditoria.Actualizar, "Estado modificado", $"Nuevo Estado: {nuevoEstadoId}");
    }

    public IEnumerable<UbicacionDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(u =>
            u.Nombre.ToLower().Contains(limpio) ||
            u.Edificio.ToLower().Contains(limpio));
    }
}
