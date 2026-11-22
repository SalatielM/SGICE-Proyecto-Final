Public Class Usuario

    Public Property IdUsuario As Integer
    Public Property Foto As Byte()
    Public Property NombreUsuario As String
    Public Property ClaveHash As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Cedula As String
    Public Property Telefono As String
    Public Property Correo As String
    Public Property RolId As Integer
    Public Property EstadoId As Integer
    Public Property FechaCreacion As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Overridable Property Rol As Rol
    Public Overridable Property Estado As Estado
    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property UsuarioActualizacion As Usuario


    Public Overridable Property ActivoRegistros As ICollection(Of Activo)
    Public Overridable Property ActivoActualizacion As ICollection(Of Activo)
    Public Overridable Property ActivoFisicoRegistros As ICollection(Of ActivoFisico)
    Public Overridable Property Auditorias As ICollection(Of Auditoria)
    Public Overridable Property BackupRegistros As ICollection(Of Backup)
    Public Overridable Property CategoriaRegistros As ICollection(Of Categoria)
    Public Overridable Property CategoriaActualizacions As ICollection(Of Categoria)
    Public Overridable Property DevolucionRegistros As ICollection(Of Devolucion)
    Public Overridable Property DirectorRegistros As ICollection(Of Director)
    Public Overridable Property DirectorActualizacions As ICollection(Of Director)
    Public Overridable Property EdificioRegistros As ICollection(Of Edificio)
    Public Overridable Property EdificioActualizacions As ICollection(Of Edificio)
    Public Overridable Property EntradaRegistros As ICollection(Of Entrada)
    Public Overridable Property EscuelaRegistro As ICollection(Of CentroEducativo)
    Public Overridable Property EscuelaActualizacion As ICollection(Of CentroEducativo)
    Public Overridable Property HistorialAccesos As ICollection(Of HistorialAcceso)
    Public Overridable Property MantenimientoRegistros As ICollection(Of Mantenimiento)
    Public Overridable Property MarcaRegistros As ICollection(Of Marca)
    Public Overridable Property MarcaActualizacion As ICollection(Of Marca)
    Public Overridable Property MovimientoRegistros As ICollection(Of Traslado)
    Public Overridable Property PersonalRegistros As ICollection(Of Personal)
    Public Overridable Property PersonalActualizacion As ICollection(Of Personal)
    Public Overridable Property PrestamoRegistros As ICollection(Of Prestamo)
    Public Overridable Property ProveedorRegistros As ICollection(Of Proveedor)
    Public Overridable Property ProveedorActualizacions As ICollection(Of Proveedor)
    Public Overridable Property PuestoRegistros As ICollection(Of Puesto)
    Public Overridable Property PuestoActualizacion As ICollection(Of Puesto)
    Public Overridable Property SalidaRegistros As ICollection(Of Salida)
    Public Overridable Property SolicitudMantenimientoRegistros As ICollection(Of SolicitudMantenimiento)
    Public Overridable Property SubCategoriaRegistros As ICollection(Of SubCategoria)
    Public Overridable Property SubCategoriaActualizacions As ICollection(Of SubCategoria)
    Public Overridable Property UbicacionRegistros As ICollection(Of Ubicacion)
    Public Overridable Property UbicacionActualizacion As ICollection(Of Ubicacion)
    Public Overridable Property UsuarioRegistros As ICollection(Of Usuario)
    Public Overridable Property UsuarioActualizacions As ICollection(Of Usuario)

End Class
