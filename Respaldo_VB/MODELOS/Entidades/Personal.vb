Public Class Personal

    Public Property IdPersonal As Integer
    Public Property Foto As Byte()
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Cedula As String
    Public Property CodPersonal As String
    Public Property Telefono As String
    Public Property Correo As String
    Public Property PuestoId As Integer
    Public Property EstadoId As Integer
    Public Property FechaCreacion As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Overridable Property Estado As Estado
    Public Overridable Property Puesto As Puesto
    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property UsuarioActualizacion As Usuario

    Public Overridable Property MantenimientoTecnicos As ICollection(Of Mantenimiento)
    Public Overridable Property PersonalEncargados As ICollection(Of Activo)
    Public Overloads Property Prestamos As ICollection(Of Prestamo)

End Class
