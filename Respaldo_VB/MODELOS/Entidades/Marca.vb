Public Class Marca

    Public Property IdMarca As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property FechaCreacion As DateTime
    Public Property FechaActualizacon As DateTime?
    Public Property EstadoId As Integer
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Overridable Property Estado As Estado
    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property UsuarioActualizacion As Usuario

    Public Overridable Property Activos As ICollection(Of Activo)

End Class
