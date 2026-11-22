Public Class Categoria

    Public Property IdCategoria As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property FechaRegistro As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property VidaUtil As String
    Public Property EstadoId As Integer
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Overridable Property Estado As Estado
    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property UsuarioActualizacion As Usuario

    Public Overridable Property SubCategorias As ICollection(Of SubCategoria)

End Class