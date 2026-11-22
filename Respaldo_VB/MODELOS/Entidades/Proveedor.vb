Public Class Proveedor

    Public Property IdProveedor As Integer
    Public Property RNC As String
    Public Property Nombre As String
    Public Property Telefono As String
    Public Property Correo As String
    Public Property Direccion As String
    Public Property PersonalContacto As String
    Public Property TelefonoContacto As String
    Public Property FechaRegistro As DateTime
    Public Property FechaActualizacion As DateTime?
    Public Property EstadoId As Integer
    Public Property UsuarioRegistroId As Integer
    Public Property UsuarioActualizacionId As Integer?

    Public Property Estado As Estado
    Public Property UsuarioRegistro As Usuario
    Public Property UsuarioActualizacion As Usuario

    Public Overridable Property Activos As ICollection(Of Activo)

End Class
