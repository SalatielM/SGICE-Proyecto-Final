using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Validaciones;
using Xunit;

namespace SGICE.Tests.Validaciones;

/// <summary>
/// Pruebas unitarias para la clase estática <see cref="Validador"/>,
/// cubriendo validaciones de cédula dominicana (Luhn/Módulo 10), correo electrónico,
/// rangos numéricos positivos, identificadores y teléfonos dominicanos.
/// </summary>
public class ValidadorTests
{
    #region Validaciones de Cédula Dominicana (Módulo 10 / Luhn)

    [Theory]
    [InlineData("402-0000000-4")]
    [InlineData("001-0000001-7")]
    [InlineData("00100000017")]
    [InlineData("001-0000002-5")]
    public void ValidarCedula_ConCedulaValida_NoLanzaExcepcion(string cedulaValida)
    {
        // Act & Assert (No debe lanzar ninguna excepción)
        var exception = Record.Exception(() => Validador.ValidarCedula(cedulaValida, "Cédula"));
        Assert.Null(exception);
    }

    [Theory]
    [InlineData("402-0000000-1")] // Dígito verificador incorrecto
    [InlineData("001-0000001-9")] // Dígito verificador incorrecto
    [InlineData("123-4567890-0")] // Cédula matemáticamente inválida
    [InlineData("abc-defghij-k")] // Caracteres no numéricos
    [InlineData("001-123")]       // Longitud insuficiente
    public void ValidarCedula_ConCedulaInvalida_LanzaValidacionNegocioExcepcion(string cedulaInvalida)
    {
        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => Validador.ValidarCedula(cedulaInvalida, "Cédula"));
        Assert.Equal("Cédula", ex.Campo);
        Assert.Contains("no es una cédula dominicana válida", ex.Message);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData(null)]
    [InlineData("00000000000")]
    public void ValidarCedula_ConCadenaVaciaNulaOConSecuenciaCeros_LanzaValidacionNegocioExcepcion(string? cedula)
    {
        // Act & Assert
        Assert.Throws<ValidacionNegocioExcepcion>(() => Validador.ValidarCedula(cedula, "Cédula"));
    }

    #endregion

    #region Validaciones de Correo Electrónico

    [Theory]
    [InlineData("admin@minerd.gob.do")]
    [InlineData("juan.perez@escuela.edu.do")]
    [InlineData("soporte_tecnico@dominio.com.do")]
    [InlineData("usuario123@gmail.com")]
    public void ValidarCorreo_ConCorreoValido_NoLanzaExcepcion(string correoValido)
    {
        // Act & Assert
        var exception = Record.Exception(() => Validador.ValidarCorreo(correoValido, "Correo"));
        Assert.Null(exception);
        Assert.True(Validador.EsCorreoValido(correoValido));
    }

    [Theory]
    [InlineData("correosin_arroba.com")]
    [InlineData("@dominio.com")]
    [InlineData("usuario@")]
    [InlineData("usuario@dominio")]
    [InlineData("usuario@dominio.")]
    [InlineData("usuario space@dominio.com")]
    public void ValidarCorreo_ConFormatoInvalido_LanzaValidacionNegocioExcepcion(string correoInvalido)
    {
        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => Validador.ValidarCorreo(correoInvalido, "Correo"));
        Assert.Equal("Correo", ex.Campo);
        Assert.Contains("no es un correo electrónico válido", ex.Message);
        Assert.False(Validador.EsCorreoValido(correoInvalido));
    }

    [Fact]
    public void EsCorreoValido_ConCorreoNuloYNoObligatorio_RetornaTrue()
    {
        // Act
        bool resultado = Validador.EsCorreoValido(null, obligatorio: false);

        // Assert
        Assert.True(resultado);
    }

    #endregion

    #region Validaciones de Identificadores y Rangos Numéricos Positivos

    [Theory]
    [InlineData(1)]
    [InlineData(100)]
    [InlineData(999999)]
    public void ValidarIdPositivo_ConIdMayorACero_NoLanzaExcepcion(int idValido)
    {
        // Act & Assert
        var exception = Record.Exception(() => Validador.ValidarIdPositivo(idValido, "IdActivo"));
        Assert.Null(exception);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-500)]
    public void ValidarIdPositivo_ConIdCeroONegativo_LanzaValidacionNegocioExcepcion(int idInvalido)
    {
        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => Validador.ValidarIdPositivo(idInvalido, "IdActivo"));
        Assert.Equal("IdActivo", ex.Campo);
        Assert.Contains("debe ser un entero positivo mayor que cero", ex.Message);
    }

    [Fact]
    public void ValidarIdPositivoNullable_ConNull_LanzaValidacionNegocioExcepcion()
    {
        // Arrange
        int? idNulo = null;

        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => Validador.ValidarIdPositivo(idNulo, "IdUbicacion"));
        Assert.Equal("IdUbicacion", ex.Campo);
    }

    [Theory]
    [InlineData(5, 1, 10)]
    [InlineData(1, 1, 10)]
    [InlineData(10, 1, 10)]
    public void ValidarRangoPositivo_ConValorDentroDeRango_NoLanzaExcepcion(int valor, int min, int max)
    {
        // Act & Assert
        var exception = Record.Exception(() => Validador.ValidarRangoPositivo(valor, min, max, "Cantidad"));
        Assert.Null(exception);
    }

    [Theory]
    [InlineData(0, 1, 10)]
    [InlineData(11, 1, 10)]
    [InlineData(-5, 1, 10)]
    public void ValidarRangoPositivo_ConValorFueraDeRango_LanzaValidacionNegocioExcepcion(int valor, int min, int max)
    {
        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => Validador.ValidarRangoPositivo(valor, min, max, "Cantidad"));
        Assert.Equal("Cantidad", ex.Campo);
        Assert.Contains("debe estar comprendido entre", ex.Message);
    }

    [Fact]
    public void ValidarRangoPositivo_ConDecimalNegativo_LanzaValidacionNegocioExcepcion()
    {
        // Arrange
        decimal costoInvalido = -15.50m;

        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => Validador.ValidarRangoPositivo(costoInvalido, "CostoEstimado", permitirCero: false));
        Assert.Equal("CostoEstimado", ex.Campo);
        Assert.Contains("estrictamente mayor a cero", ex.Message);
    }

    #endregion

    #region Validaciones de Teléfono Dominicano

    [Theory]
    [InlineData("809-555-1234")]
    [InlineData("829-234-5678")]
    [InlineData("849-987-6543")]
    [InlineData("(809) 555-1234")]
    [InlineData("8095551234")]
    public void ValidarTelefono_ConPrefijoDominicanoValido_NoLanzaExcepcion(string telefonoValido)
    {
        // Act & Assert
        var exception = Record.Exception(() => Validador.ValidarTelefono(telefonoValido, "Teléfono"));
        Assert.Null(exception);
        Assert.True(Validador.EsTelefonoDominicanoValido(telefonoValido));
    }

    [Theory]
    [InlineData("787-555-1234")] // Código de área foráneo
    [InlineData("800-555-1234")] // Código 800 no corresponde
    [InlineData("123-456")]      // Longitud insuficiente
    [InlineData("abc-defg-hijk")]
    public void ValidarTelefono_ConTelefonoInvalido_LanzaValidacionNegocioExcepcion(string telefonoInvalido)
    {
        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => Validador.ValidarTelefono(telefonoInvalido, "Teléfono"));
        Assert.Equal("Teléfono", ex.Campo);
        Assert.Contains("debe ser un teléfono dominicano válido", ex.Message);
    }

    #endregion
}
