Public Class Auditoria

    Public Property IdAuditoria As Integer
    Public Property NombreTabla As String
    Public Property RegistroId As Integer
    Public Property Accion As TipoAccionAuditoria
    Public Property ValoresAntiguos As String
    Public Property ValoresNuevos As String
    Public Property FechaRegistro As DateTime
    Public Property UsuarioAuditoriaId As Integer
    Public Property DirectorId As Integer


    Public Overridable Property Director As Director
    Public Overridable Property UsuarioAuditoria As Usuario

End Class
