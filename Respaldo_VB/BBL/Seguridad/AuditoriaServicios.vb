Imports DAO
Imports MODELOS
Imports System.Text.Json

Public Class AuditoriaServicios

    Public Sub New()

    End Sub

    Public Sub Registrar(tabla As String, id As Integer, accion As TipoAccionAuditoria, valAnterior As String, valNuevo As String)
        Using ctx As New AppDbContext()
            Dim directorId As Integer = ObtenerDirectorVigenteId(ctx)
            If directorId <= 0 Then
                Throw New ExcepcionesdeNegocio("No puede realizar esta accion porque no existe un Director activo registrado en el sistema.")
            End If

            Dim repo As New RepositorioGenerico(Of Auditoria)(ctx)
            Dim auditoria As New Auditoria With {
                .NombreTabla = tabla,
                .RegistroId = id,
                .Accion = accion,
                .ValoresAntiguos = valAnterior,
                .ValoresNuevos = valNuevo,
                .FechaRegistro = DateTime.Now,
                .UsuarioAuditoriaId = SesionActual.Usuario.IdUsuario,
                .DirectorId = directorId
            }
            repo.Agregar(auditoria)
        End Using
    End Sub

    Public Function ObtenerDirectorVigenteId() As Integer
        Using ctx As New AppDbContext()
            Return ObtenerDirectorVigenteId(ctx)
        End Using
    End Function

    Private Function ObtenerDirectorVigenteId(ctx As AppDbContext) As Integer
        Dim director = ctx.Director.FirstOrDefault(Function(d) d.Estado.Nombre = "Activo")
        Return If(director IsNot Nothing, director.IdDirector, 0)
    End Function

    Public Function ConsultarHistorial(tabla As String, registroId As Integer) As List(Of Auditoria)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Auditoria)(ctx)
            Return repo.Consultar().
                Where(Function(a) a.NombreTabla = tabla AndAlso a.RegistroId = registroId).
                OrderByDescending(Function(a) a.FechaRegistro).
                ToList()
        End Using
    End Function

End Class
