Public Class Devolucion

    Public Property IdDevolucion As Integer
    Public Property PrestamoId As Integer
    Public Property ObervacioneGeneral As String
    Public Property FechaDevolucion As DateTime
    Public Property UsuarioRegistroId As Integer

    Public Overridable Property Prestamo As Prestamo
    Public Overridable Property UsuarioResgistro As Usuario

    Public Overridable Property Detalledevoluciones As ICollection(Of DetalleDevolucion)

End Class
