Public Class Backup

    Public Property IdBackup As Integer
    Public Property Nombre As String
    Public Property RutaBackup As String
    Public Property FechaCreacion As DateTime
    Public Property UsuarioRegistroId As Integer

    Public Overridable Property UsuarioRegistro As Usuario

End Class
