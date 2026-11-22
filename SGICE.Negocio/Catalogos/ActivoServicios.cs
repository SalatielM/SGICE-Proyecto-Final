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
/// Gestiona el catálogo de tipos y modelos de activos del centro educativo.
/// </summary>
public class ActivoServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Activo> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Activo>(ctx);
        return repo.ObtenerTodos();
    }

    public Activo ObtenerPorId(int idActivo)
    {
        Validador.ValidarRangoPositivo(idActivo, "IdActivo");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Activo>(ctx);
        var activo = repo.ObtenerPorId(idActivo);

        if (activo == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Activo), idActivo);
        }

        return activo;
    }

    public Activo ObtenerPorNombre(string nombre)
    {
        Validador.ValidarRequerido(nombre, "Nombre del Activo");

        string limpio = nombre.Trim().ToLower();
        using var ctx = new AppDbContext();
        var activo = ctx.Activo.FirstOrDefault(a => a.Nombre.ToLower() == limpio);

        if (activo == null)
        {
            throw new ReglaNegocioExcepcion($"El activo '{nombre}' no existe.");
        }

        return activo;
    }

    public IEnumerable<ActivoDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Activo
            .AsNoTracking()
            .Include(a => a.SubCategoria).ThenInclude(sc => sc!.Categoria)
            .Include(a => a.Marca)
            .Include(a => a.Proveedor)
            .Include(a => a.Estado)
            .Include(a => a.PersonalEncargado)
            .Select(a => new ActivoDTO
            {
                IdActivo = a.Id,
                Nombre = a.Nombre,
                Descripcion = a.Descripcion,
                CategoriaId = a.SubCategoria != null ? a.SubCategoria.CategoriaId : 0,
                Categoria = a.SubCategoria != null && a.SubCategoria.Categoria != null ? a.SubCategoria.Categoria.Nombre : string.Empty,
                SubCategoriaId = a.SubCategoriaId,
                SubCategoria = a.SubCategoria != null ? a.SubCategoria.Nombre : string.Empty,
                ProveedorId = a.ProveedorId,
                Proveedor = a.Proveedor != null ? a.Proveedor.Nombre : string.Empty,
                MarcaId = a.MarcaId,
                Marca = a.Marca != null ? a.Marca.Nombre : string.Empty,
                EstadoId = a.EstadoId ?? 0,
                Estado = a.Estado != null ? a.Estado.Nombre : string.Empty,
                PersonalId = a.PersonalEncargadoId,
                PersonalEncargado = a.PersonalEncargado != null ? a.PersonalEncargado.Nombre + " " + a.PersonalEncargado.Apellido : string.Empty
            }).ToList();
    }

    public void ValidarEstadoActivo(int idActivo)
    {
        var activo = ObtenerPorId(idActivo);
        if (activo.EstadoId != (int)EstadoGenerico.Activo)
        {
            throw new ReglaNegocioExcepcion($"El activo de catálogo '{activo.Nombre}' no se encuentra activo.");
        }
    }

    public void Agregar(Activo activo)
    {
        if (activo == null) throw new ArgumentNullException(nameof(activo));

        Validador.ValidarRequerido(activo.Nombre, "Nombre del Activo");
        Validador.ValidarLongitud(activo.Nombre, 2, 50, "Nombre del Activo");
        Validador.ValidarRangoPositivo(activo.SubCategoriaId, "Subcategoría");
        Validador.ValidarRangoPositivo(activo.MarcaId, "Marca");
        Validador.ValidarRangoPositivo(activo.ProveedorId, "Proveedor");
        Validador.ValidarRangoPositivo(activo.PersonalEncargadoId, "Personal Encargado");
        Validador.ValidarRangoPositivo(activo.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(activo.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        string nombre = activo.Nombre.Trim().ToLower();
        if (ctx.Activo.Any(a => a.Nombre.ToLower() == nombre && a.MarcaId == activo.MarcaId && a.SubCategoriaId == activo.SubCategoriaId))
        {
            throw new ReglaNegocioExcepcion($"Ya existe un activo con ese nombre para la misma marca y subcategoría.");
        }

        activo.UsuarioRegistroId = SesionActual.Usuario.Id;
        activo.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Activo>(ctx);
        repo.Agregar(activo);

        _auditoria.Registrar("Activo", activo.Id, TipoAccionAuditoria.Crear, string.Empty, activo.Nombre);
    }

    public void Actualizar(Activo activo)
    {
        if (activo == null) throw new ArgumentNullException(nameof(activo));

        Validador.ValidarRequerido(activo.Nombre, "Nombre del Activo");
        Validador.ValidarRangoPositivo(activo.SubCategoriaId, "Subcategoría");
        Validador.ValidarRangoPositivo(activo.MarcaId, "Marca");
        Validador.ValidarRangoPositivo(activo.ProveedorId, "Proveedor");
        Validador.ValidarRangoPositivo(activo.PersonalEncargadoId, "Personal Encargado");
        _estados.ValidarEstado(activo.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Activo>(ctx);
        var existente = repo.ObtenerPorId(activo.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Activo), activo.Id);
        }

        string nombre = activo.Nombre.Trim().ToLower();
        if (ctx.Activo.Any(a => a.Nombre.ToLower() == nombre && a.MarcaId == activo.MarcaId && a.SubCategoriaId == activo.SubCategoriaId && a.Id != activo.Id))
        {
            throw new ReglaNegocioExcepcion("Ya existe otro activo registrado con esa misma configuración.");
        }

        activo.UsuarioRegistroId = existente.UsuarioRegistroId;
        activo.UsuarioActualizacionId = SesionActual.Usuario.Id;
        activo.FechaActualizacion = DateTime.Now;

        repo.Actualizar(activo);
        _auditoria.Registrar("Activo", activo.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, activo.Nombre);
    }

    public void CambiarEstado(int idActivo, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idActivo, "IdActivo");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Activo>(ctx);
        var activo = repo.ObtenerPorId(idActivo);

        if (activo == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Activo), idActivo);
        }

        activo.EstadoId = nuevoEstadoId;
        activo.FechaActualizacion = DateTime.Now;
        activo.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(activo);
        _auditoria.Registrar("Activo", idActivo, TipoAccionAuditoria.Actualizar, "Estado modificado", $"Nuevo Estado: {nuevoEstadoId}");
    }

    public IEnumerable<ActivoDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(a =>
            a.Nombre.ToLower().Contains(limpio) ||
            a.Categoria.ToLower().Contains(limpio) ||
            a.SubCategoria.ToLower().Contains(limpio) ||
            a.Marca.ToLower().Contains(limpio));
    }
}
