Public Class Entrada

    Public Property IdEntrada As Integer
    Public Property NumEntrada As Integer
    Public Property FechaEntrada As DateTime
    Public Property DocReferencia As TipoDocReferencia
    Public Property NoDocReferencia As String
    Public Property ObservacionEntrada As String
    Public Property UsuarioRegistroId As Integer

    Public Overridable Property DetalleEntradas As ICollection(Of DetalleEntrada)
    Public Overridable Property UsuarioRegistro As Usuario

End Class
