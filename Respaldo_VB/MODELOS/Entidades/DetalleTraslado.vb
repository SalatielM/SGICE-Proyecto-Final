Public Class DetalleTraslado

    Public Property IdDetalleMovimiento As Integer
    Public Property TrasladoId As Integer
    Public Property ActivoFisicoId As Integer
    Public Property UbicacionActualId As Integer
    Public Property UbicacionFinalId As Integer

    Public Overridable Property UbicacionActual As Ubicacion
    Public Overridable Property UbicacionFinal As Ubicacion
    Public Overridable Property ActivoFisico As ActivoFisico
    Public Overridable Property Traslado As Traslado

End Class
