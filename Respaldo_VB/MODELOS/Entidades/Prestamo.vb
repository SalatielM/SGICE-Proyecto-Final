Public Class Prestamo

    Public Property IdPrestamo As Integer
    Public Property FechaPrestamo As DateTime
    Public Property FechaLimite As DateTime
    Public Property EstadoId As Integer
    Public Property PersonalSolicitanteId As Integer
    Public Property UsuarioRegistroId As Integer

    Public Overridable Property Estado As Estado
    Public Overridable Property PersonalSolicitante As Personal
    Public Overridable Property UsuarioRegistro As Usuario

    Public Overridable Property DetallePrestamos As ICollection(Of DetallePrestamo)
    Public Overridable Property Devoluciones As ICollection(Of Devolucion)

End Class
