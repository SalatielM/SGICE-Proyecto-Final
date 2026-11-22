Public Class DetalleEntrada

    Public Property IdDetalleEntrada As Integer
    Public Property EntradaId As Integer
    Public Property ActivoId As Integer
    Public Property Cantidad As Integer

    Public Overridable Property Activo As Activo
    Public Overridable Property Entrada As Entrada

    Public Overridable Property ActivosFisicos As ICollection(Of ActivoFisico)

End Class
