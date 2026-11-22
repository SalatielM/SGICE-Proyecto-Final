Public Class ReporteFiltroDTO

    Public Property FechaDesde As Date?
    Public Property FechaHasta As Date?
    Public Property UsuarioRegistraId As Integer?
    Public Property PersonalId As Integer?
    Public Property EstadoGenerico As Integer?

    Public Property ActivoId As Integer?
    Public Property MarcaId As Integer?
    Public Property CodEtiquetaQR As String
    Public Property CategoriaId As Integer?
    Public Property UbicacionId As Integer?
    Public Property EstadoActivoFisicoId As Integer?

    Public Property EstadoDevolucionId As Integer?

    Public Property EstadoMantenimientoId As Integer?

    Public Property Nombre As Boolean?
    Public Property Apellido As Boolean?
    Public Property Codigo As Boolean?
    Public Property PuestoId As Integer?
    Public Property Usuario As Boolean?
    Public Property RolId As Integer?

    Public Property EstadoPrestamoId As Integer?

    Public Property UbicacionOrigenId As Integer?
    Public Property UbicacionDestinoId As Integer?


    Public Property UsuarioAuditoriaId As Integer?
    Public Property AccionAuditoria As TipoAccionAuditoria?
    Public Property NombreTabla As String
    Public Property RegistroId As Integer?

End Class
