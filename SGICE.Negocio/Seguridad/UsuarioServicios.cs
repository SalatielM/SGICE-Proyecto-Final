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
/// Gestiona la administración de usuarios, autenticación, cambio de contraseñas y permisos.
/// </summary>
public class UsuarioServicios
{
    private readonly SeguridadServicios _seguridad = new();
    private readonly AuditoriaServicios _auditoria = new();
    private readonly EstadoServicios _estados = new();

    public IEnumerable<Usuario> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Usuario>(ctx);
        return repo.ObtenerTodos();
    }

    public Usuario ObtenerPorId(int idUsuario)
    {
        Validador.ValidarRangoPositivo(idUsuario, "IdUsuario");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Usuario>(ctx);
        var usuario = repo.ObtenerPorId(idUsuario);

        if (usuario == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Usuario), idUsuario);
        }

        return usuario;
    }

    public Usuario ObtenerPorNombreUsuario(string nombreUsuario)
    {
        Validador.ValidarRequerido(nombreUsuario, "Nombre de Usuario");

        string limpio = nombreUsuario.Trim().ToLower();
        using var ctx = new AppDbContext();
        var usuario = ctx.Usuario
            .Include(u => u.Rol)
            .Include(u => u.Estado)
            .FirstOrDefault(u => u.NombreUsuario.ToLower() == limpio);

        if (usuario == null)
        {
            throw new ReglaNegocioExcepcion($"El usuario '{nombreUsuario}' no existe.");
        }

        return usuario;
    }

    public Usuario Autenticar(string nombreUsuario, string clave)
    {
        Validador.ValidarRequerido(nombreUsuario, "Nombre de Usuario");
        Validador.ValidarRequerido(clave, "Contraseña");

        string limpio = nombreUsuario.Trim().ToLower();
        using var ctx = new AppDbContext();
        var usuario = ctx.Usuario
            .Include(u => u.Rol)
            .Include(u => u.Estado)
            .FirstOrDefault(u => u.NombreUsuario.ToLower() == limpio);

        if (usuario == null)
        {
            throw new ReglaNegocioExcepcion("Nombre de usuario o contraseña incorrectos.");
        }

        if (usuario.EstadoId != (int)EstadoGenerico.Activo)
        {
            throw new ReglaNegocioExcepcion("La cuenta de usuario se encuentra inactiva o deshabilitada. Contacte al administrador.");
        }

        if (!_seguridad.VerificarHash(clave, usuario.ClaveHash))
        {
            throw new ReglaNegocioExcepcion("Nombre de usuario o contraseña incorrectos.");
        }

        return usuario;
    }

    public void CambiarContrasena(int idUsuario, string claveActual, string claveNueva, string confirmacion)
    {
        Validador.ValidarRangoPositivo(idUsuario, "IdUsuario");
        Validador.ValidarRequerido(claveActual, "Contraseña Actual");
        Validador.ValidarRequerido(claveNueva, "Nueva Contraseña");
        Validador.ValidarRequerido(confirmacion, "Confirmación de Contraseña");

        if (claveNueva != confirmacion)
        {
            throw new ValidacionNegocioExcepcion("Confirmación de Contraseña", "La nueva contraseña y su confirmación no coinciden.");
        }

        _seguridad.ValidarClave(claveNueva);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Usuario>(ctx);
        var usuario = repo.ObtenerPorId(idUsuario);

        if (usuario == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Usuario), idUsuario);
        }

        if (!_seguridad.VerificarHash(claveActual, usuario.ClaveHash))
        {
            throw new ReglaNegocioExcepcion("La contraseña actual ingresada es incorrecta.");
        }

        usuario.ClaveHash = _seguridad.GenerarHash(claveNueva);
        usuario.FechaActualizacion = DateTime.Now;
        usuario.UsuarioActualizacionId = idUsuario;

        repo.Actualizar(usuario);
        _auditoria.Registrar("Usuario", idUsuario, TipoAccionAuditoria.Actualizar, "Contraseña cambiada", "Nueva contraseña registrada");
    }

    public IEnumerable<UsuarioDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Usuario
            .AsNoTracking()
            .Include(u => u.Rol)
            .Include(u => u.Estado)
            .Select(u => new UsuarioDTO
            {
                IdUsuario = u.Id,
                NombreUsuario = u.NombreUsuario,
                Foto = u.Foto,
                Nombre = u.Nombre,
                Apellido = u.Apellido,
                Cedula = u.Cedula,
                Telefono = u.Telefono,
                Correo = u.Correo,
                RolId = u.RolId,
                Rol = u.Rol != null ? u.Rol.Nombre : string.Empty,
                EstadoId = u.EstadoId ?? 0,
                Estado = u.Estado != null ? u.Estado.Nombre : string.Empty
            }).ToList();
    }

    public void Agregar(Usuario usuario, string claveEnTextoPlano)
    {
        if (usuario == null) throw new ArgumentNullException(nameof(usuario));

        Validar(usuario);
        _seguridad.ValidarClave(claveEnTextoPlano);

        using var ctx = new AppDbContext();
        string username = usuario.NombreUsuario.Trim().ToLower();

        if (ctx.Usuario.Any(u => u.NombreUsuario.ToLower() == username))
        {
            throw new ReglaNegocioExcepcion($"Ya existe una cuenta registrada con el nombre de usuario '{usuario.NombreUsuario}'.");
        }

        string cedula = usuario.Cedula.Replace("-", "").Replace(" ", "").Trim();
        if (ctx.Usuario.Any(u => u.Cedula.Replace("-", "").Replace(" ", "").Trim() == cedula))
        {
            throw new ReglaNegocioExcepcion("Ya existe un usuario registrado con esa cédula.");
        }

        if (!string.IsNullOrWhiteSpace(usuario.Correo))
        {
            string correo = usuario.Correo.Trim().ToLower();
            if (ctx.Usuario.Any(u => u.Correo != null && u.Correo.ToLower() == correo))
            {
                throw new ReglaNegocioExcepcion("Ya existe un usuario registrado con ese correo electrónico.");
            }
        }

        Validador.ValidarRangoPositivo(usuario.RolId, "Rol");
        Validador.ValidarRangoPositivo(usuario.EstadoId ?? 0, "Estado");
        _estados.ValidarEstado(usuario.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        usuario.ClaveHash = _seguridad.GenerarHash(claveEnTextoPlano);
        usuario.UsuarioRegistroId = SesionActual.Usuario.Id;
        usuario.FechaRegistro = DateTime.Now;

        var repo = new RepositorioGenerico<Usuario>(ctx);
        repo.Agregar(usuario);

        _auditoria.Registrar("Usuario", usuario.Id, TipoAccionAuditoria.Crear, string.Empty, $"Usuario creado: {usuario.NombreUsuario}");
    }

    public void Actualizar(Usuario usuario)
    {
        if (usuario == null) throw new ArgumentNullException(nameof(usuario));

        Validar(usuario);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Usuario>(ctx);
        var existente = repo.ObtenerPorId(usuario.Id);

        if (existente == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Usuario), usuario.Id);
        }

        string username = usuario.NombreUsuario.Trim().ToLower();
        if (ctx.Usuario.Any(u => u.NombreUsuario.ToLower() == username && u.Id != usuario.Id))
        {
            throw new ReglaNegocioExcepcion($"El nombre de usuario '{usuario.NombreUsuario}' ya está en uso por otro usuario.");
        }

        string cedula = usuario.Cedula.Replace("-", "").Replace(" ", "").Trim();
        if (ctx.Usuario.Any(u => u.Cedula.Replace("-", "").Replace(" ", "").Trim() == cedula && u.Id != usuario.Id))
        {
            throw new ReglaNegocioExcepcion("La cédula ingresada ya está registrada para otro usuario.");
        }

        if (!string.IsNullOrWhiteSpace(usuario.Correo))
        {
            string correo = usuario.Correo.Trim().ToLower();
            if (ctx.Usuario.Any(u => u.Correo != null && u.Correo.ToLower() == correo && u.Id != usuario.Id))
            {
                throw new ReglaNegocioExcepcion("El correo ingresado ya pertenece a otro usuario.");
            }
        }

        _estados.ValidarEstado(usuario.EstadoId ?? 0, TipoEstadoEnum.EstadoGenerico);

        usuario.ClaveHash = existente.ClaveHash; // Preservar hash existente
        usuario.UsuarioRegistroId = existente.UsuarioRegistroId;
        usuario.FechaRegistro = existente.FechaRegistro;
        usuario.UsuarioActualizacionId = SesionActual.Usuario.Id;
        usuario.FechaActualizacion = DateTime.Now;

        repo.Actualizar(usuario);
        _auditoria.Registrar("Usuario", usuario.Id, TipoAccionAuditoria.Actualizar, existente.NombreUsuario, usuario.NombreUsuario);
    }

    public void CambiarEstado(int idUsuario, int nuevoEstadoId)
    {
        Validador.ValidarRangoPositivo(idUsuario, "IdUsuario");
        Validador.ValidarRangoPositivo(nuevoEstadoId, "NuevoEstadoId");
        _estados.ValidarEstado(nuevoEstadoId, TipoEstadoEnum.EstadoGenerico);

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Usuario>(ctx);
        var usuario = repo.ObtenerPorId(idUsuario);

        if (usuario == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Usuario), idUsuario);
        }

        if (usuario.EstadoId == nuevoEstadoId)
        {
            throw new ReglaNegocioExcepcion("El usuario ya se encuentra en el estado indicado.");
        }

        int estadoAnterior = usuario.EstadoId ?? 0;
        usuario.EstadoId = nuevoEstadoId;
        usuario.FechaActualizacion = DateTime.Now;
        usuario.UsuarioActualizacionId = SesionActual.Usuario.Id;

        repo.Actualizar(usuario);
        _auditoria.Registrar("Usuario", idUsuario, TipoAccionAuditoria.Actualizar, $"Estado:{estadoAnterior}", $"Estado:{nuevoEstadoId}");
    }

    public IEnumerable<UsuarioDTO> BuscarPorNombre(string criterio)
    {
        if (string.IsNullOrWhiteSpace(criterio)) return Listar();

        string limpio = criterio.Trim().ToLower();
        return Listar().Where(u =>
            u.Nombre.ToLower().Contains(limpio) ||
            u.Apellido.ToLower().Contains(limpio) ||
            u.NombreUsuario.ToLower().Contains(limpio) ||
            u.Cedula.Contains(limpio));
    }

    private static void Validar(Usuario usuario)
    {
        Validador.ValidarRequerido(usuario.Nombre, "Nombre");
        Validador.ValidarLongitud(usuario.Nombre, 2, 50, "Nombre");

        Validador.ValidarRequerido(usuario.Apellido, "Apellido");
        Validador.ValidarLongitud(usuario.Apellido, 2, 50, "Apellido");

        Validador.ValidarRequerido(usuario.NombreUsuario, "Nombre de Usuario");
        Validador.ValidarLongitud(usuario.NombreUsuario, 3, 20, "Nombre de Usuario");

        Validador.ValidarCedula(usuario.Cedula, "Cédula");
        Validador.ValidarTelefono(usuario.Telefono, "Teléfono");
        Validador.ValidarCorreo(usuario.Correo, "Correo Electrónico", obligatorio: false);
    }
}
