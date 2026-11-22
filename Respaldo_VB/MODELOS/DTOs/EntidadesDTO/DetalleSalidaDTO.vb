Public Class DetalleSalidaDTO

    Public Property IdDetalleSalida As Integer
    Public Property SalidaId As Integer
    Public Property ActivoFisicoId As Integer

    Public Property ActivoFisico As String
    Public Property CodEtiquetaQR As String
    Public Property NumSerie As String
    Public Property UbicacionId As Integer
    Public Property Ubicacion As String
    Public Property EstadoId As Integer
    Public Property Estado As String
    Public Property EstadoDestilo As EstadoActivoFisico
    Public Property MotivoSalida As MotivoSalida

End Class
