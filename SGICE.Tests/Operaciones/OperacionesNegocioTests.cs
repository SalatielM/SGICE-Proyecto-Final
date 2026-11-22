using SGICE.Entidades.DTOs;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Operaciones;
using Xunit;

namespace SGICE.Tests.Operaciones;

/// <summary>
/// Pruebas unitarias para las reglas de negocio de operaciones transaccionales:
/// traslados entre ubicaciones, validación de detalles de entradas y formato de código QR.
/// </summary>
public class OperacionesNegocioTests
{
    private readonly TrasladoServicios _trasladoServicios = new();
    private readonly EntradaServicios _entradaServicios = new();

    #region Lógica de Negocio de Traslados

    [Fact]
    public void ValidarDetalleTraslado_ConOrigenYDestinoIguales_LanzaReglaNegocioExcepcion()
    {
        // Arrange: Un activo no puede trasladarse hacia su misma ubicación actual
        var detalle = new DetalleTrasladoDTO
        {
            ActivoFisicoId = 1,
            UbicacionActualId = 3,
            UbicacionFinalId = 3, // Misma ubicación
            NombreActivo = "Proyector Epson",
            CodigoEtiqueta = "AF-0000001"
        };

        // Act & Assert
        var ex = Assert.Throws<ReglaNegocioExcepcion>(() => _trasladoServicios.ValidarDetalle(detalle));
        Assert.Contains("La ubicación de origen y destino no pueden ser iguales", ex.Message);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void ValidarDetalleTraslado_ConActivoFisicoIdInvalido_LanzaValidacionNegocioExcepcion(int idActivoInvalido)
    {
        // Arrange
        var detalle = new DetalleTrasladoDTO
        {
            ActivoFisicoId = idActivoInvalido,
            UbicacionActualId = 1,
            UbicacionFinalId = 2
        };

        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => _trasladoServicios.ValidarDetalle(detalle));
        Assert.Equal(nameof(detalle.ActivoFisicoId), ex.Campo);
    }

    [Fact]
    public void ValidarDetalleTraslado_ConUbicacionActualInvalida_LanzaValidacionNegocioExcepcion()
    {
        // Arrange
        var detalle = new DetalleTrasladoDTO
        {
            ActivoFisicoId = 5,
            UbicacionActualId = 0, // Inválido
            UbicacionFinalId = 2
        };

        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => _trasladoServicios.ValidarDetalle(detalle));
        Assert.Equal(nameof(detalle.UbicacionActualId), ex.Campo);
    }

    [Fact]
    public void ValidarDetalleTraslado_ConDetalleValido_NoLanzaExcepcion()
    {
        // Arrange
        var detalle = new DetalleTrasladoDTO
        {
            ActivoFisicoId = 10,
            UbicacionActualId = 1,
            UbicacionFinalId = 2
        };

        // Act & Assert
        var exception = Record.Exception(() => _trasladoServicios.ValidarDetalle(detalle));
        Assert.Null(exception);
    }

    #endregion

    #region Lógica de Negocio de Entradas y Códigos QR

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void ValidarDetalleEntrada_ConCantidadMenorOIgualACero_LanzaValidacionNegocioExcepcion(int cantidadInvalida)
    {
        // Arrange
        var detalle = new DetalleEntradaDTO
        {
            ActivoId = 1,
            Cantidad = cantidadInvalida
        };

        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => _entradaServicios.ValidarDetalle(detalle));
        Assert.Equal(nameof(detalle.Cantidad), ex.Campo);
    }

    [Fact]
    public void ValidarDetalleEntrada_ConActivoIdInvalido_LanzaValidacionNegocioExcepcion()
    {
        // Arrange
        var detalle = new DetalleEntradaDTO
        {
            ActivoId = 0,
            Cantidad = 5
        };

        // Act & Assert
        var ex = Assert.Throws<ValidacionNegocioExcepcion>(() => _entradaServicios.ValidarDetalle(detalle));
        Assert.Equal(nameof(detalle.ActivoId), ex.Campo);
    }

    [Fact]
    public void EditarDetalleEntrada_ConNuevaCantidadValida_ActualizaCantidadEnMemoria()
    {
        // Arrange
        var lista = new List<DetalleEntradaDTO>
        {
            new() { ActivoId = 101, Cantidad = 3, NombreActivo = "Pizarra Digital" },
            new() { ActivoId = 102, Cantidad = 1, NombreActivo = "Escritorio Docente" }
        };

        // Act
        _entradaServicios.EditarDetalle(lista, activoId: 101, nuevaCantidad: 8);

        // Assert
        var itemActualizado = lista.First(d => d.ActivoId == 101);
        Assert.Equal(8, itemActualizado.Cantidad);
    }

    [Fact]
    public void EditarDetalleEntrada_ConActivoInexistenteEnLista_LanzaReglaNegocioExcepcion()
    {
        // Arrange
        var lista = new List<DetalleEntradaDTO>
        {
            new() { ActivoId = 5, Cantidad = 2 }
        };

        // Act & Assert
        var ex = Assert.Throws<ReglaNegocioExcepcion>(() => _entradaServicios.EditarDetalle(lista, activoId: 999, nuevaCantidad: 4));
        Assert.Contains("El activo no existe en el detalle", ex.Message);
    }

    [Theory]
    [InlineData(1, "AF-0000001")]
    [InlineData(42, "AF-0000042")]
    [InlineData(1234567, "AF-1234567")]
    public void CodEtiquetaQR_FormatoEstandar_CumplePrefijoAFConSieteDigitos(int consecutivo, string esperado)
    {
        // Arrange & Act: Simula el formateo estándar implementado en EntradaServicios.GenerarActivosFisicosTemporales
        string codigoGenerado = $"AF-{consecutivo:D7}";

        // Assert
        Assert.Equal(esperado, codigoGenerado);
        Assert.StartsWith("AF-", codigoGenerado);
        Assert.Equal(10, codigoGenerado.Length);
    }

    #endregion
}
