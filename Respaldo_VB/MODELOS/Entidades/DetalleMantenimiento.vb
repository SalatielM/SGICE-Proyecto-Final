Public Class DetalleMantenimiento

    Public Property IdDetalleMantenimiento As Integer
    Public Property MantenimientoId As Integer
    Public Property ActivoFisicoId As Integer
    Public Property Solucion As String
    Public Property EstadoId As Integer

    Public Overridable Property ActivoFisico As ActivoFisico
    Public Overridable Property Estado As Estado
    Public Overridable Property Mantenimiento As Mantenimiento

End Class
