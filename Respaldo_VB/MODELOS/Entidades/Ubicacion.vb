Public Class Ubicacion

    Public Property IdUbicacion As Integer
    Public Property Nombre As String
    Public Property Dimencion As String
    Public Property Piso As Integer
    Public Property Descripcion As String
    Public Property FechaCreacion As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property EdificioId As Integer
    Public Property EstadoId As Integer
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Overridable Property Estado As Estado
    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property UsuarioActualizacion As Usuario
    Public Overridable Property Edificio As Edificio

    Public Overridable Property ActivosFisicos As ICollection(Of ActivoFisico)
    Public Overridable Property DetalleUbicacionActual As ICollection(Of DetalleTraslado)
    Public Overridable Property DetalleUbicacionFinal As ICollection(Of DetalleTraslado)
End Class
