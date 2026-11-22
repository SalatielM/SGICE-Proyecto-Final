Public Class Traslado

    Public Property IdTraslado As Integer
    Public Property FechaTraslado As DateTime
    Public Property RazonTraslado As String
    Public Property UsuarioRegistroId As Integer
    Public Property AutorizadoPorId As Integer
    Public Property DocAutorizacion As TipoDocAutorizacion
    Public Property NoDocAutorizacion As String

    Public Overridable Property UsuarioRegistro As Usuario
    Public Overridable Property AutorizadoPor As Director

    Public Overridable Property DetalleTraslados As ICollection(Of DetalleTraslado)

End Class
