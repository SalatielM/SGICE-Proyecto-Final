using SGICE.Negocio.Excepciones;
using Xunit;

namespace SGICE.Tests.Excepciones;

/// <summary>
/// Pruebas unitarias para la jerarquía de excepciones de negocio del sistema SGICE:
/// <see cref="NegocioExcepcion"/>, <see cref="ValidacionNegocioExcepcion"/>,
/// <see cref="ReglaNegocioExcepcion"/> y <see cref="EntidadNoEncontradaNegocioExcepcion"/>.
/// </summary>
public class ExcepcionesNegocioTests
{
    [Fact]
    public void ValidacionNegocioExcepcion_PreservaCampoYMensajeCorrectamente()
    {
        // Arrange
        string campo = "Cedula";
        string mensaje = "La cédula ingresada es inválida.";

        // Act
        var excepcion = new ValidacionNegocioExcepcion(campo, mensaje);

        // Assert
        Assert.Equal(campo, excepcion.Campo);
        Assert.Equal(mensaje, excepcion.Message);
        Assert.IsAssignableFrom<NegocioExcepcion>(excepcion);
        Assert.IsAssignableFrom<Exception>(excepcion);
    }

    [Fact]
    public void ReglaNegocioExcepcion_HeredaDeNegocioExcepcionYConservaInnerException()
    {
        // Arrange
        var inner = new InvalidOperationException("Falla en operación subyacente.");
        string mensaje = "El activo seleccionado se encuentra en mantenimiento y no puede ser asignado.";

        // Act
        var excepcion = new ReglaNegocioExcepcion(mensaje, inner);

        // Assert
        Assert.Equal(mensaje, excepcion.Message);
        Assert.Same(inner, excepcion.InnerException);
        Assert.IsAssignableFrom<NegocioExcepcion>(excepcion);
    }

    [Fact]
    public void EntidadNoEncontradaNegocioExcepcion_GeneraMensajeDescriptivoConEntidadEIdentificador()
    {
        // Arrange
        string entidad = "CentroEducativo";
        int idBuscado = 45;

        // Act
        var excepcion = new EntidadNoEncontradaNegocioExcepcion(entidad, idBuscado);

        // Assert
        Assert.Contains(entidad, excepcion.Message);
        Assert.Contains(idBuscado.ToString(), excepcion.Message);
        Assert.IsAssignableFrom<NegocioExcepcion>(excepcion);
    }
}
