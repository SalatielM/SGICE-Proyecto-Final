Public Class DetalleDevolucion

    Public Property IdDetalleDevolucion As Integer
    Public Property DevolucionId As Integer
    Public Property ActivoFisicoId As Integer
    Public Property EstadoDevolucionId As Integer
    Public Property Obervacion As String

    Public Overridable Property Devolucion As Devolucion
    Public Overridable Property ActivoFisico As ActivoFisico
    Public Overridable Property EstadoDevolucion As Estado

End Class
