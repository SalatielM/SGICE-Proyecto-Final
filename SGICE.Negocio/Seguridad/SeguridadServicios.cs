using System.Security.Cryptography;
using System.Text;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Seguridad;

/// <summary>
/// Provee servicios de criptografía para contraseñas y credenciales de usuario.
/// </summary>
public class SeguridadServicios
{
    /// <summary>
    /// Genera un hash criptográfico SHA-256 en formato hexadecimal para una contraseña.
    /// </summary>
    /// <param name="clave">Contraseña en texto plano</param>
    /// <returns>Hash en formato hexadecimal de 64 caracteres en mayúsculas</returns>
    public string GenerarHash(string clave)
    {
        ValidarClave(clave);

        byte[] bytes = Encoding.UTF8.GetBytes(clave.Trim());
        using var sha = SHA256.Create();
        byte[] hashBytes = sha.ComputeHash(bytes);

        return Convert.ToHexString(hashBytes);
    }

    /// <summary>
    /// Comprueba si una contraseña en texto plano coincide con su hash almacenado.
    /// </summary>
    public bool VerificarHash(string clave, string hashAlmacenado)
    {
        if (string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(hashAlmacenado))
        {
            return false;
        }

        string hashGenerado = GenerarHash(clave);
        return string.Equals(hashGenerado, hashAlmacenado, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Valida que la contraseña cumpla los requisitos mínimos de longitud y obligatoriedad.
    /// </summary>
    public void ValidarClave(string clave)
    {
        Validador.ValidarRequerido(clave, "Contraseña");

        string limpio = clave.Trim();
        if (limpio.Length < 6)
        {
            throw new ValidacionNegocioExcepcion("Contraseña", "La contraseña debe tener un mínimo de 6 caracteres.");
        }
        if (limpio.Length > 20)
        {
            throw new ValidacionNegocioExcepcion("Contraseña", "La contraseña no puede exceder los 20 caracteres.");
        }
    }
}
