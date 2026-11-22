Public Class Permiso

    Public Property IdPermiso As Integer
    Public Property Nombre As String
    Public Property Descripcion As String

    Public Overridable Property RolPermisos As ICollection(Of RolPermiso)

End Class
