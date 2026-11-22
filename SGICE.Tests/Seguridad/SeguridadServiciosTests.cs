using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;
using Xunit;

namespace SGICE.Tests.Seguridad;

/// <summary>
/// Pruebas unitarias para <see cref="SeguridadServicios"/>, evaluando la generación de hash SHA-256,
/// verificación de claves en texto plano, y validaciones de seguridad de contraseña.
/// </summary>
public class SeguridadServiciosTests
{
    private readonly SeguridadServicios _seguridad = new();

    #region Generación y Verificación de Hash SHA-256

    [Theory]
    [InlineData("admin123")]
    [InlineData("MiClaveSegura2026")]
    [InlineData("Password@123")]
    public void GenerarHash_ConClaveValida_RetornaCadenaHexadecimalDe64Caracteres(string clave)
    {
        // Act
        string hash = _seguridad.GenerarHash(clave);

        // Assert
        Assert.NotNull(hash);
        Assert.Equal(64, hash.Length);
        Assert.True(hash.All(c => "0123456789ABCDEF".Contains(c)), "El hash debe estar en formato hexadecimal en mayúsculas.");
    }

    [Fact]
    public void GenerarHash_ConMismaClave_ProduceMismoHashDeterminista()
    {
        // Arrange
        string clave = "ClaveSecreta1";

        // Act
        string hash1 = _seguridad.GenerarHash(clave);
        string hash2 = _seguridad.GenerarHash(clave);

        // Assert
        Assert.Equal(hash1, hash2);
    }

    [Fact]
    public void VerificarHash_ConClaveCorrecta_RetornaTrue()
    {
        // Arrange
        string clave = "AdminPass123";
        string hash = _seguridad.GenerarHash(clave);

        // Act
        bool coincide = _seguridad.VerificarHash(clave, hash);

        // Assert
        Assert.True(coincide);
    }

    [Fact]
    public void VerificarHash_ConClaveIncorrecta_RetornaFalse()
    {
        // Arrange
        string claveCorrecta = "AdminPass123";
        string claveErronea = "AdminPass999";
        string hash = _seguridad.GenerarHash(claveCorrecta);

        // Act
        bool coincide = _seguridad.VerificarHash(claveErronea, hash);

        // Assert
        Assert.False(coincide);
    }

    [Theory]
    [InlineData("", "HASH_EJEMPLO")]
    [InlineData("clave123", "")]
    [InlineData(null, "HASH_EJEMPLO")]
    [InlineData("clave123", null)]
    public void VerificarHash_ConParametrosNulosOVacios_RetornaFalse(string? clave, string? hash)
    {
        // Act
        bool coincide = _seguridad.VerificarHash(clave!, hash!);

        // Assert
        Assert.False(coincide);
    }

    #endregion

    #region Validación de Reglas de Contraseña

    [Theory]
    [InlineData("123")]
    [InlineData("abc")]
    [InlineData("12345")]
    public void ValidarClave_ConLongitudMenorA6_LanzaValidacionNegocioExcepcion(string claveCorta)
    {
        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => _seguridad.ValidarClave(claveCorta));
        Assert.Equal("Contraseña", ex.Campo);
        Assert.Contains("mínimo de 6 caracteres", ex.Message);
    }

    [Fact]
    public void ValidarClave_ConLongitudMayorA20_LanzaValidacionNegocioExcepcion()
    {
        // Arrange
        string claveLarga = new string('A', 21);

        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => _seguridad.ValidarClave(claveLarga));
        Assert.Equal("Contraseña", ex.Campo);
        Assert.Contains("no puede exceder los 20 caracteres", ex.Message);
    }

    [Theory]
    [InlineData("")]
    [InlineData("    ")]
    [InlineData(null)]
    public void ValidarClave_ConClaveVaciaONula_LanzaValidacionNegocioExcepcion(string? claveVacia)
    {
        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => _seguridad.ValidarClave(claveVacia!));
        Assert.Equal("Contraseña", ex.Campo);
    }

    #endregion
}
