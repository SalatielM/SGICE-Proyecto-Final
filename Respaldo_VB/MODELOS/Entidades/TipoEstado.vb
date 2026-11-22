Public Class TipoEstado

    Public Property IdTipoEstado As Integer
    Public Property Nombre As String

    Public Overridable Property Estados As ICollection(Of Estado)

End Class
