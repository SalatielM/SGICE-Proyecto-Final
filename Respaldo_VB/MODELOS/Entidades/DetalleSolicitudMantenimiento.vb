Public Class DetalleSolicitudMantenimiento

    Public Property IdDetalleSolicitudMantenimiento As Integer
    Public Property SolicitudMantenimientoId As Integer
    Public Property ActivoFisicoId As Integer
    Public Property DescripcionProblema As String

    Public Overridable Property ActivoFisico As ActivoFisico
    Public Overridable Property SolicitudMantenimiento As SolicitudMantenimiento

End Class
