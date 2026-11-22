Public Class Edificio

    Public Property IdEdificio As Integer
    Public Property Nombre As String
    Public Property CodEdificio As String
    Public Property CantidadPisos As String
    Public Property Descripcion As String
    Public Property EstadoId As Integer
    Public Property FechaConstruccion As DateTime
    Public Property FechaRegistro As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Property UsuarioRegistro As Usuario
    Public Property UsuarioActualizacion As Usuario
    Public Overridable Property Estado As Estado

    Public Overridable Property Ubicaciones As ICollection(Of Ubicacion)

End Class
