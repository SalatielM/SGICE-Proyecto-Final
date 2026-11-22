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
/// Gestiona las subcategorías de activos y su vida útil estimada.
/// </summary>
public class SubCategoriaServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<SubCategoria> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<SubCategoria>(ctx);
        return repo.ObtenerTodos();
    }

    public SubCategoria ObtenerPorId(int idSubCategoria)
    {
        Validador.ValidarRangoPositivo(idSubCategoria, "IdSubCategoria");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<SubCategoria>(ctx);
        var subCategoria = repo.ObtenerPorId(idSubCategoria);

        if (subCategoria == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(SubCategoria), idSubCategoria);
        }

        return subCategoria;
    }

    public IEnumerable<SubCategoria> ObtenerPorCategorias(int categoriaId)
    {
        Validador.ValidarRangoPositivo(categoriaId, "CategoriaId");

        using var ctx = new AppDbContext();
        return ctx.SubCategoria
            .AsNoTracking()
            .Where(s => s.CategoriaId == categoriaId && s.EstadoId == (int)EstadoGenerico.Activo)
            .ToList();
    }

    public IEnumerable<SubCategoriaDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.SubCategoria
            .AsNoTracking()
            .Include(s => s.Categoria)
            .Include(s => s.Estado)
            .Include(s => s.UsuarioRegistro)
            .Select(s => new SubCategoriaDTO
            {
                IdSubCategoria = s.Id,
                CategoriaId = s.CategoriaId,
                Categoria = s.Categoria != null ? s.Categoria.Nombre : string.Empty,
                Nombre = s.Nombre,
                Descripcion = s.Descripcion,
                VidaUtil = s.VidaUtil.ToString(),
                EstadoId = s.EstadoId ?? 0,
                Estado = s.Estado != null ? s.Estado.Nombre : string.Empty,
                FechaCreacion = s.FechaRegistro,
                FechaActualizacion = s.FechaActualizacion ?? DateTime.MinValue,
                UsuarioRegistroId = s.UsuarioRegistroId,
                UsuarioRegistro = s.UsuarioRegistro != null ? s.UsuarioRegistro.NombreUsuario : string.Empty
            }).ToList();
    }

    public void ValidarEstadoSubCategoria(int idSubCategoria)
    {
        var subCat = ObtenerPorId(idSubCategoria);
        if (subCat.EstadoId != (int)EstadoGenerico.Activo)
        {
            throw new ReglaNegocioExcepcion($"La subcategoría '{subCat.Nombre}' no se encuentra activa.");
        }
    }

    public void Agregar(SubCategoria subCategoria)
    {
        if (subCategoria == null) throw new ArgumentNullException(nameof(subCategoria));

        Validador.ValidarRequerido(subCategoria.Nombre, "Nombre de Subcategoría");
        Validador.ValidarLongitud(subCategoria.Nombre, 2, 80, "Nombre de Subcategoría");
        Validador.ValidarRangoPositivo(subCategoria.CategoriaId, "Categoría");
        Validador.ValidarRangoPositivo(subCategoria.VidaUtil, "Vida Útil (Años)");
        Validador.ValidarRangoPositivo(subCategoria.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(subCategoria.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        string nombre = subCategoria.Nombre.Trim().ToLower();
        if (ctx.SubCategoria.Any(s => s.Nombre.ToLower() == nombre && s.CategoriaId == subCategoria.CategoriaId))
        {
            throw new ReglaNegocioExcepcion($"Ya existe una subcategoría con el nombre '{subCategoria.Nombre}' en la categoría seleccionada.");
        }

        subCategoria.UsuarioRegistroId = SesionActual.Usuario.Id;
        subCategoria.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<SubCategoria>(ctx);
        repo.Agregar(subCategoria);

        _auditoria.Registrar("SubCategoria", subCategoria.Id, TipoAccionAuditoria.Crear, string.Empty, subCategoria.Nombre);
    }

    public void Actualizar(SubCategoria subCategoria)
    {
        if (subCategoria == null) throw new ArgumentNullException(nameof(subCategoria));

        Validador.ValidarRequerido(subCategoria.Nombre, "Nombre de Subcategoría");
        Validador.ValidarRangoPositivo(subCategoria.CategoriaId, "Categoría");
        Validador.ValidarRangoPositivo(subCategoria.VidaUtil, "Vida Útil (Años)");
        _estados.ValidarEstado(subCategoria.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<SubCategoria>(ctx);
        var existente = repo.ObtenerPorId(subCategoria.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(SubCategoria), subCategoria.Id);
        }

        string nombre = subCategoria.Nombre.Trim().ToLower();
        if (ctx.SubCategoria.Any(s => s.Nombre.ToLower() == nombre && s.CategoriaId == subCategoria.CategoriaId && s.Id != subCategoria.Id))
        {
            throw new ReglaNegocioExcepcion($"Ya existe otra subcategoría con el nombre '{subCategoria.Nombre}' en esa categoría.");
        }

        subCategoria.UsuarioRegistroId = existente.UsuarioRegistroId;
        subCategoria.UsuarioActualizacionId = SesionActual.Usuario.Id;
        subCategoria.FechaActualizacion = DateTime.Now;

        repo.Actualizar(subCategoria);
        _auditoria.Registrar("SubCategoria", subCategoria.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, subCategoria.Nombre);
    }

    public void CambiarEstado(int idSubCategoria, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idSubCategoria, "IdSubCategoria");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<SubCategoria>(ctx);
        var subCat = repo.ObtenerPorId(idSubCategoria);

        if (subCat == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(SubCategoria), idSubCategoria);
        }

        subCat.EstadoId = nuevoEstadoId;
        subCat.FechaActualizacion = DateTime.Now;
        subCat.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(subCat);
        _auditoria.Registrar("SubCategoria", idSubCategoria, TipoAccionAuditoria.Actualizar, "Estado modificado", $"Nuevo Estado: {nuevoEstadoId}");
    }

    public IEnumerable<SubCategoriaDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(s =>
            s.Nombre.ToLower().Contains(limpio) ||
            s.Categoria.ToLower().Contains(limpio));
    }
}
