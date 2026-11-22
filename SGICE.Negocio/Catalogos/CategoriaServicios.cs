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
/// Gestiona las categorías principales de activos.
/// </summary>
public class CategoriaServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Categoria> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Categoria>(ctx);
        return repo.ObtenerTodos();
    }

    public Categoria ObtenerPorId(int idCategoria)
    {
        Validador.ValidarRangoPositivo(idCategoria, "IdCategoria");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Categoria>(ctx);
        var categoria = repo.ObtenerPorId(idCategoria);

        if (categoria == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Categoria), idCategoria);
        }

        return categoria;
    }

    public Categoria ObtenerPorNombre(string nombre)
    {
        Validador.ValidarRequerido(nombre, "Nombre de Categoría");

        string limpio = nombre.Trim().ToLower();
        using var ctx = new AppDbContext();
        var categoria = ctx.Categoria.FirstOrDefault(c => c.Nombre.ToLower() == limpio);

        if (categoria == null)
        {
            throw new ReglaNegocioExcepcion($"La categoría '{nombre}' no existe.");
        }

        return categoria;
    }

    public IEnumerable<CategoriaDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Categoria
            .AsNoTracking()
            .Include(c => c.Estado)
            .Select(c => new CategoriaDTO
            {
                IdCategoria = c.Id,
                Nombre = c.Nombre,
                Descripcion = c.Descripcion,
                VidaUtil = c.VidaUtil,
                EstadoId = c.EstadoId ?? 0,
                Estado = c.Estado != null ? c.Estado.Nombre : string.Empty
            }).ToList();
    }

    public void ValidarEstadoCategoria(int idCategoria)
    {
        var categoria = ObtenerPorId(idCategoria);
        if (categoria.EstadoId != (int)EstadoGenerico.Activo)
        {
            throw new ReglaNegocioExcepcion($"La categoría '{categoria.Nombre}' no se encuentra activa.");
        }
    }

    public void Agregar(Categoria categoria)
    {
        if (categoria == null) throw new ArgumentNullException(nameof(categoria));

        Validador.ValidarRequerido(categoria.Nombre, "Nombre de Categoría");
        Validador.ValidarLongitud(categoria.Nombre, 2, 50, "Nombre de Categoría");
        Validador.ValidarRequerido(categoria.VidaUtil, "Vida Útil");
        Validador.ValidarRangoPositivo(categoria.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(categoria.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        string nombre = categoria.Nombre.Trim().ToLower();
        if (ctx.Categoria.Any(c => c.Nombre.ToLower() == nombre))
        {
            throw new ReglaNegocioExcepcion($"Ya existe una categoría registrada con el nombre '{categoria.Nombre}'.");
        }

        categoria.UsuarioRegistroId = SesionActual.Usuario.Id;
        categoria.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Categoria>(ctx);
        repo.Agregar(categoria);

        _auditoria.Registrar("Categoria", categoria.Id, TipoAccionAuditoria.Crear, string.Empty, categoria.Nombre);
    }

    public void Actualizar(Categoria categoria)
    {
        if (categoria == null) throw new ArgumentNullException(nameof(categoria));

        Validador.ValidarRequerido(categoria.Nombre, "Nombre de Categoría");
        Validador.ValidarRequerido(categoria.VidaUtil, "Vida Útil");
        _estados.ValidarEstado(categoria.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Categoria>(ctx);
        var existente = repo.ObtenerPorId(categoria.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Categoria), categoria.Id);
        }

        string nombre = categoria.Nombre.Trim().ToLower();
        if (ctx.Categoria.Any(c => c.Nombre.ToLower() == nombre && c.Id != categoria.Id))
        {
            throw new ReglaNegocioExcepcion($"Ya existe otra categoría registrada con el nombre '{categoria.Nombre}'.");
        }

        categoria.UsuarioRegistroId = existente.UsuarioRegistroId;
        categoria.UsuarioActualizacionId = SesionActual.Usuario.Id;
        categoria.FechaActualizacion = DateTime.Now;

        repo.Actualizar(categoria);
        _auditoria.Registrar("Categoria", categoria.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, categoria.Nombre);
    }

    public void CambiarEstado(int idCategoria, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idCategoria, "IdCategoria");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Categoria>(ctx);
        var categoria = repo.ObtenerPorId(idCategoria);

        if (categoria == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Categoria), idCategoria);
        }

        categoria.EstadoId = nuevoEstadoId;
        categoria.FechaActualizacion = DateTime.Now;
        categoria.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(categoria);
        _auditoria.Registrar("Categoria", idCategoria, TipoAccionAuditoria.Actualizar, "Estado modificado", $"Nuevo Estado: {nuevoEstadoId}");
    }

    public IEnumerable<CategoriaDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(c => c.Nombre.ToLower().Contains(limpio));
    }
}
