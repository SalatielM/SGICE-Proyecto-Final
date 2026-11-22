Public Class SubCategoria

    Public Property IdSubCategoria As Integer
    Public Property CategoriaId As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property VidaUtil As Integer
    Public Property FechaCreacion As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?
    Public Property EstadoId As Integer


    Public Property UsuarioRegistro As Usuario
    Public Property UsuarioActualizacion As Usuario
    Public Overridable Property Estado As Estado
    Public Overridable Property Categoria As Categoria

    Public Overridable Property Activos As ICollection(Of Activo)

End Class
