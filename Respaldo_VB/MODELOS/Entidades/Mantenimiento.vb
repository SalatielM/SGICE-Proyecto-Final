Public Class Mantenimiento

    Public Property IdMantenimiento As Integer
    Public Property SolicitudMantenimientoId As Integer
    Public Property FechaInicioAtencion As DateTime
    Public Property FechaCierre As DateTime?
    Public Property EstadoId As Integer
    Public Property PersonalTecnicoId As Integer
    Public Property UsuarioRegistroId As Integer

    Public Overridable Property Estado As Estado
    Public Overridable Property SolicitudMantenimiento As SolicitudMantenimiento
    Public Overridable Property PersonalTecnico As Personal
    Public Overridable Property UsuarioRegistro As Usuario

    Public Overridable Property DetalleMantenimientos As ICollection(Of DetalleMantenimiento)

End Class
