Public Class HistorialAcceso

    Public Property IdHistorialAcceso As Integer
    Public Property UsuarioId As Integer
    Public Property FechaIngraso As DateTime
    Public Property FechaSalida As DateTime
    Public Property DireccionIp As String
    Public Property SistemaOperatico As String
    Public Property Exitoso As Boolean

    Public Overridable Property Usuario As Usuario

End Class
