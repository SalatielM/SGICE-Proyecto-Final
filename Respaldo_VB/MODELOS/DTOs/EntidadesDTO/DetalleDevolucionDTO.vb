Public Class DetalleDevolucionDTO

    Public Property IdDetalleDevolucion As Integer
    Public Property DevolucionId As Integer
    Public Property ActivoFisicoId As Integer
    Public Property ActivoId As Integer
    Public Property Activo As String
    Public Property CodEtiquetaQR As String
    Public Property NumSerie As String
    Public Property MarcaId As Integer
    Public Property Marca As String
    Public Property SubCategoriaId As Integer
    Public Property SubCategoria As String
    Public Property EstadoDevolucionId As Integer
    Public Property EstadoDevolucion As String
    Public Property Obervacion As String

    Public Property IdDevolucion As Integer
    Public Property PrestamoId As Integer

    Public Property PersonalId As Integer
    Public Property Solicitante As String
    Public Property CodPersonal As String

    Public Property FechaPrestamo As DateTime
    Public Property FechaDevolucion As DateTime

End Class
