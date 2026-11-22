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
/// Provee servicios de administración para marcas de activos escolares.
/// </summary>
public class MarcaServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Marca> ObtenerTodo()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Marca>(ctx);
        return repo.ObtenerTodos();
    }

    public Marca ObtenerPorId(int idMarca)
    {
        Validador.ValidarRangoPositivo(idMarca, "IdMarca");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Marca>(ctx);
        var marca = repo.ObtenerPorId(idMarca);

        if (marca == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Marca), idMarca);
        }

        return marca;
    }

    public IEnumerable<MarcaDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Marca
            .AsNoTracking()
            .Include(m => m.Estado)
            .Select(m => new MarcaDTO
            {
                IdMarca = m.Id,
                Nombre = m.Nombre,
                Descripcion = m.Descripcion,
                EstadoId = m.EstadoId ?? 0,
                Estado = m.Estado != null ? m.Estado.Nombre : string.Empty
            }).ToList();
    }

    public void ValidarEstadoMarca(int idMarca)
    {
        var marca = ObtenerPorId(idMarca);
        if (marca.EstadoId != (int)EstadoGenerico.Activo)
        {
            throw new ReglaNegocioExcepcion($"La marca '{marca.Nombre}' no se encuentra activa.");
        }
    }

    public void Agregar(Marca marca)
    {
        if (marca == null) throw new ArgumentNullException(nameof(marca));

        Validador.ValidarRequerido(marca.Nombre, "Nombre de Marca");
        Validador.ValidarLongitud(marca.Nombre, 2, 50, "Nombre de Marca");
        Validador.ValidarRangoPositivo(marca.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(marca.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        string nombre = marca.Nombre.Trim().ToLower();
        if (ctx.Marca.Any(m => m.Nombre.ToLower() == nombre))
        {
            throw new ReglaNegocioExcepcion($"Ya existe una marca registrada con el nombre '{marca.Nombre}'.");
        }

        marca.UsuarioRegistroId = SesionActual.Usuario.Id;
        marca.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Marca>(ctx);
        repo.Agregar(marca);

        _auditoria.Registrar("Marca", marca.Id, TipoAccionAuditoria.Crear, string.Empty, marca.Nombre);
    }

    public void Actualizar(Marca marca)
    {
        if (marca == null) throw new ArgumentNullException(nameof(marca));

        Validador.ValidarRequerido(marca.Nombre, "Nombre de Marca");
        _estados.ValidarEstado(marca.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Marca>(ctx);
        var existente = repo.ObtenerPorId(marca.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Marca), marca.Id);
        }

        string nombre = marca.Nombre.Trim().ToLower();
        if (ctx.Marca.Any(m => m.Nombre.ToLower() == nombre && m.Id != marca.Id))
        {
            throw new ReglaNegocioExcepcion($"El nombre de marca '{marca.Nombre}' ya pertenece a otra marca.");
        }

        marca.UsuarioRegistroId = existente.UsuarioRegistroId;
        marca.UsuarioActualizacionId = SesionActual.Usuario.Id;
        marca.FechaActualizacion = DateTime.Now;

        repo.Actualizar(marca);
        _auditoria.Registrar("Marca", marca.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, marca.Nombre);
    }

    public void CambiarEstado(int idMarca, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idMarca, "IdMarca");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Marca>(ctx);
        var marca = repo.ObtenerPorId(idMarca);

        if (marca == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Marca), idMarca);
        }

        marca.EstadoId = nuevoEstadoId;
        marca.FechaActualizacion = DateTime.Now;
        marca.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(marca);
        _auditoria.Registrar("Marca", idMarca, TipoAccionAuditoria.Actualizar, "Estado modificado", $"Nuevo Estado: {nuevoEstadoId}");
    }

    public IEnumerable<MarcaDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(m => m.Nombre.ToLower().Contains(limpio));
    }
}
