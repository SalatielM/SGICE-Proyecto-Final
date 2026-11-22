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
/// Gestiona proveedores comerciales con validación de RNC, teléfonos y correos.
/// </summary>
public class ProveedorServicios
{
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Proveedor> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Proveedor>(ctx);
        return repo.ObtenerTodos();
    }

    public Proveedor ObtenerPorId(int idProveedor)
    {
        Validador.ValidarRangoPositivo(idProveedor, "IdProveedor");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Proveedor>(ctx);
        var proveedor = repo.ObtenerPorId(idProveedor);

        if (proveedor == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Proveedor), idProveedor);
        }

        return proveedor;
    }

    public IEnumerable<ProveedorDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Proveedor
            .AsNoTracking()
            .Include(p => p.Estado)
            .Include(p => p.UsuarioRegistro)
            .Select(p => new ProveedorDTO
            {
                IdProveedor = p.Id,
                RNC = p.RNC,
                Nombre = p.Nombre,
                Telefono = p.Telefono,
                Correo = p.Correo,
                Direccion = p.Direccion,
                PersonalContacto = p.PersonalContacto,
                TelefonoContacto = p.TelefonoContacto,
                FechaRegistro = p.FechaRegistro,
                FechaActualizacion = p.FechaActualizacion,
                EstadoId = p.EstadoId ?? 0,
                Estado = p.Estado != null ? p.Estado.Nombre : string.Empty,
                UsuarioRegistroId = p.UsuarioRegistroId,
                UsuarioRegistro = p.UsuarioRegistro != null ? p.UsuarioRegistro.NombreUsuario : string.Empty
            }).ToList();
    }

    public void ValidarEstadoProveedor(int idProveedor)
    {
        var proveedor = ObtenerPorId(idProveedor);
        if (proveedor.EstadoId != (int)EstadoGenerico.Activo)
        {
            throw new ReglaNegocioExcepcion($"El proveedor '{proveedor.Nombre}' no se encuentra activo.");
        }
    }

    public void Agregar(Proveedor proveedor)
    {
        if (proveedor == null) throw new ArgumentNullException(nameof(proveedor));

        Validador.ValidarRequerido(proveedor.Nombre, "Nombre del Proveedor");
        Validador.ValidarLongitud(proveedor.Nombre, 2, 100, "Nombre del Proveedor");
        Validador.ValidarTelefono(proveedor.Telefono, "Teléfono del Proveedor");
        Validador.ValidarCorreo(proveedor.Correo, "Correo del Proveedor", obligatorio: false);
        Validador.ValidarRnc(proveedor.RNC, "RNC");
        Validador.ValidarRangoPositivo(proveedor.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(proveedor.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        string nombre = proveedor.Nombre.Trim().ToLower();
        if (ctx.Proveedor.Any(p => p.Nombre.ToLower() == nombre))
        {
            throw new ReglaNegocioExcepcion($"Ya existe un proveedor registrado con el nombre '{proveedor.Nombre}'.");
        }

        if (!string.IsNullOrWhiteSpace(proveedor.RNC))
        {
            string rnc = proveedor.RNC.Replace("-", "").Replace(" ", "").Trim();
            if (ctx.Proveedor.Any(p => p.RNC != null && p.RNC.Replace("-", "").Replace(" ", "").Trim() == rnc))
            {
                throw new ReglaNegocioExcepcion("Ya existe un proveedor con ese número de RNC.");
            }
        }

        proveedor.UsuarioRegistroId = SesionActual.Usuario.Id;
        proveedor.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Proveedor>(ctx);
        repo.Agregar(proveedor);

        _auditoria.Registrar("Proveedor", proveedor.Id, TipoAccionAuditoria.Crear, string.Empty, proveedor.Nombre);
    }

    public void Actualizar(Proveedor proveedor)
    {
        if (proveedor == null) throw new ArgumentNullException(nameof(proveedor));

        Validador.ValidarRequerido(proveedor.Nombre, "Nombre del Proveedor");
        Validador.ValidarTelefono(proveedor.Telefono, "Teléfono del Proveedor");
        Validador.ValidarCorreo(proveedor.Correo, "Correo del Proveedor", obligatorio: false);
        Validador.ValidarRnc(proveedor.RNC, "RNC");
        _estados.ValidarEstado(proveedor.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Proveedor>(ctx);
        var existente = repo.ObtenerPorId(proveedor.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Proveedor), proveedor.Id);
        }

        string nombre = proveedor.Nombre.Trim().ToLower();
        if (ctx.Proveedor.Any(p => p.Nombre.ToLower() == nombre && p.Id != proveedor.Id))
        {
            throw new ReglaNegocioExcepcion($"El nombre '{proveedor.Nombre}' ya pertenece a otro proveedor registrado.");
        }

        proveedor.UsuarioRegistroId = existente.UsuarioRegistroId;
        proveedor.UsuarioActualizacionId = SesionActual.Usuario.Id;
        proveedor.FechaActualizacion = DateTime.Now;

        repo.Actualizar(proveedor);
        _auditoria.Registrar("Proveedor", proveedor.Id, TipoAccionAuditoria.Actualizar, existente.Nombre, proveedor.Nombre);
    }

    public void CambiarEstado(int idProveedor, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idProveedor, "IdProveedor");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Proveedor>(ctx);
        var proveedor = repo.ObtenerPorId(idProveedor);

        if (proveedor == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Proveedor), idProveedor);
        }

        proveedor.EstadoId = nuevoEstadoId;
        proveedor.FechaActualizacion = DateTime.Now;
        proveedor.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(proveedor);
        _auditoria.Registrar("Proveedor", idProveedor, TipoAccionAuditoria.Actualizar, "Estado modificado", $"Nuevo Estado: {nuevoEstadoId}");
    }

    public IEnumerable<ProveedorDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(p =>
            p.Nombre.ToLower().Contains(limpio) ||
            (p.RNC != null && p.RNC.Contains(limpio)));
    }
}
