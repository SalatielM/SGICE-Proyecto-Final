Public Class Estado

    Public Property IdEstado As Integer
    Public Property Nombre As String
    Public Property TipoEstadoId As Integer

    Public Overridable Property TipoEstado As TipoEstado


    Public Overridable Property Activos As ICollection(Of Activo)
    Public Overridable Property ActivosFisicos As ICollection(Of ActivoFisico)
    Public Overridable Property Categorias As ICollection(Of Categoria)
    Public Overridable Property DetalleDevoluciones As ICollection(Of DetalleDevolucion)
    Public Overridable Property DetalleMantenimientos As ICollection(Of DetalleMantenimiento)
    Public Overridable Property Edificios As ICollection(Of Edificio)
    Public Overridable Property Directores As ICollection(Of Estado)
    Public Overridable Property Marcas As ICollection(Of Marca)
    Public Overridable Property Mantenimientos As ICollection(Of Mantenimiento)
    Public Overridable Property Personales As ICollection(Of Personal)
    Public Overridable Property Proveedores As ICollection(Of Proveedor)
    Public Overridable Property Puestos As ICollection(Of Puesto)
    Public Overridable Property Prestamos As ICollection(Of Prestamo)
    Public Overridable Property SolicitudMantenimientos As ICollection(Of SolicitudMantenimiento)
    Public Overridable Property SubCategorias As ICollection(Of SubCategoria)
    Public Overridable Property Ubicaciones As ICollection(Of Ubicacion)
    Public Overridable Property Usuarios As ICollection(Of Usuario)


End Class
