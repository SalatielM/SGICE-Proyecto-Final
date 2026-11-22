Public Class Salida

    Public Property IdSalida As Integer
    Public Property NumSalida As Integer
    Public Property FechaSalida As DateTime
    Public Property RazonSalida As String
    Public Property UsuarioRegistroId As Integer
    Public Property Observaciones As String

    Public Overridable Property UsuarioRegistro As Usuario

    Public Overridable Property DetalleSalidas As ICollection(Of DetalleSalida)

End Class
