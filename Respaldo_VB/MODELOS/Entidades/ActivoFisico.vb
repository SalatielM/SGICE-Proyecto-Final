Public Class ActivoFisico

    Public Property IdActivoFisico As Integer
    Public Property CodEtiquetaQR As String
    Public Property NumSerie As String
    Public Property ActivoId As Integer
    Public Property UbicacionId As Integer
    Public Property EstadoId As Integer
    Public Property DetalleEntradaId As Integer
    Public Property FechaRegistro As DateTime
    Public Property UsuarioRegistroId As Integer

    Public Overridable Property Activo As Activo
    Public Overridable Property Estado As Estado
    Public Overridable Property DetalleEntrada As DetalleEntrada
    Public Overridable Property Ubicacion As Ubicacion
    Public Overridable Property UsuarioRegistro As Usuario

    Public Overridable Property DetalleDevoluciones As ICollection(Of DetalleDevolucion)
    Public Overridable Property DetalleMantenimientos As ICollection(Of DetalleMantenimiento)
    Public Overridable Property DetalleMovimientos As ICollection(Of DetalleTraslado)
    Public Overridable Property DetallePrestamos As ICollection(Of DetallePrestamo)
    Public Overridable Property DetalleSalidas As ICollection(Of DetalleSalida)
    Public Overridable Property DetalleSolicitudMantenimientos As ICollection(Of DetalleSolicitudMantenimiento)

End Class
