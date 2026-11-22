Public Class SolicitudMantenimiento

    Public Property IdSolicitudMantenimiento As Integer
    Public Property ObservacionGeneral As String
    Public Property FechaSolicitud As DateTime
    Public Property UsuarioRegistroId As Integer
    Public Property EstadoId As Integer

    Public Overridable Property Estado As Estado
    Public Overridable Property UsuarioRegistro As Usuario

    Public Overridable Property DetalleSolicitudMantenimientos As ICollection(Of DetalleSolicitudMantenimiento)
    Public Overridable Property Mantenimientos As ICollection(Of Mantenimiento)

End Class
