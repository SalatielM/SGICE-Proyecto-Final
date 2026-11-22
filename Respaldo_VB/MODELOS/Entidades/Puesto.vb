Public Class Puesto

    Public Property IdPuesto As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property FechaCreacion As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property EstadoId As Integer
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property UsuarioActualizacion As Usuario

    Public Overridable Property Estado As Estado

    Public Overridable Property Personales As ICollection(Of Personal)

End Class
