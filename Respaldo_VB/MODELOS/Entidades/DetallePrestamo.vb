Public Class DetallePrestamo
    Public Property IdDetallePrestamo As Integer
    Public Property PrestamoId As Integer
    Public Property ActivoFisicoId As Integer

    Public Overridable Property ActivoFisico As ActivoFisico
    Public Overridable Property Prestamo As Prestamo

End Class
