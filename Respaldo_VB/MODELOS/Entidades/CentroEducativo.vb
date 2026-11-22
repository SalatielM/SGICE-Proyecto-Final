Public Class CentroEducativo
    Public Property IdCentroEducativo As Integer
    Public Property Foto As Byte()
    Public Property Nombre As String
    Public Property CodCentro As String
    Public Property Telefono As String
    Public Property Correo As String
    Public Property Direccion As String
    Public Property Longitud As Double
    Public Property Latitud As Double
    Public Property Modalidad As String
    Public Property Jornada As String
    Public Property DistritoEducativo As String
    Public Property RegionalEducativo As String
    Public Property DirectorId As Integer
    Public Property FechaCreacion As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Overloads Property Director As Director
    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property UsuarioActualizacion As Usuario

End Class
