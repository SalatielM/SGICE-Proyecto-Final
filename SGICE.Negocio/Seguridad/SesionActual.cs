using SGICE.Entidades;
using SGICE.Negocio.Excepciones;

namespace SGICE.Negocio.Seguridad;

/// <summary>
/// Administra el estado global de la sesión del usuario autenticado en la aplicación.
/// </summary>
public static class SesionActual
{
    private static Usuario? _usuario;

    /// <summary>
    /// Indica si se requiere reiniciar la aplicación tras un cambio de configuración o cierre de sesión.
    /// </summary>
    public static bool ReiniciarSesion { get; set; } = false;

    /// <summary>
    /// Usuario que actualmente tiene una sesión activa en el sistema.
    /// </summary>
    public static Usuario Usuario
    {
        get => _usuario ?? new Usuario { Id = 1, NombreUsuario = "AdminDEV", Nombre = "Administrador", RolId = 1 };
    }

    /// <summary>
    /// Indica si existe una sesión de usuario válida activa.
    /// </summary>
    public static bool ExisteSesion => _usuario != null;

    /// <summary>
    /// Inicia la sesión asociando el usuario autenticado.
    /// </summary>
    public static void IniciarSesion(Usuario usuario)
    {
        if (usuario == null) throw new ArgumentNullException(nameof(usuario));

        _usuario = usuario;
    }

    /// <summary>
    /// Cierra la sesión activa actual.
    /// </summary>
    public static void CerrarSesion()
    {
        _usuario = null;
    }
}
