Public Class Activo

    Public Property IdActivo As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property SubCategoriaId As Integer
    Public Property MarcaId As Integer
    Public Property ProveedorId As Integer
    Public Property EstadoId As Integer
    Public Property FechaRegistro As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property PersonalEncargadoId As Integer
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Overridable Property Estado As Estado
    Public Property Categoria As Categoria
    Public Overridable Property SubCategoria As SubCategoria
    Public Overridable Property Marca As Marca
    Public Overridable Property PersonalEncargado As Personal
    Public Overridable Property Proveedor As Proveedor
    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property UsuarioActualizacion As Usuario

    Public Overridable Property ActivosFisicos As ICollection(Of ActivoFisico)
    Public Overridable Property DetalleEntradas As ICollection(Of DetalleEntrada)

End Class
