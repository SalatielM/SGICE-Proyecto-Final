Public Class Rol

    Public Property IdRol As Integer
    Public Property Nombre As String
    Public Property Descripcion As String

    Public Overridable Property RolPermisos As ICollection(Of RolPermiso)
    Public Overridable Property Usuarios As ICollection(Of Usuario)

End Class
