Public Class Director

    Public Property IdDirector As Integer
    Public Property Foto As Byte()
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Cedula As String
    Public Property Telefono As String
    Public Property Correo As String
    Public Property EstadoId As Integer
    Public Property FechaInicia As DateTime
    Public Property FechaFin As DateTime?
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?


    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property UsuarioActualizacion As Usuario
    Public Overridable Property Estado As Estado

    Public Overridable Property Auditorias As ICollection(Of Auditoria)
    Public Property CentrosEducativos As ICollection(Of CentroEducativo)
    Public Property Traslaados As ICollection(Of Traslado)

End Class
