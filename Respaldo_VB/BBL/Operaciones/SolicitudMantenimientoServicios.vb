Imports DAO
Imports MODELOS
Imports System.Text.Json
Imports Microsoft.EntityFrameworkCore

Public Class SolicitudMantenimientoServicios

    Public Sub New()

    End Sub

    Public Function ObtenerPorId(idSolicitud As Integer) As SolicitudMantenimiento
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of SolicitudMantenimiento)(ctx)
            Dim solicitud = repo.ObtenerPorId(idSolicitud)
            If solicitud Is Nothing Then
                Throw New ExcepcionesdeNegocio("La solicitud de mantenimiento no existe")
            End If
            Return solicitud
        End Using
    End Function

    Public Function ObtenerActivoParaSolicitud(activoFisicoId As Integer) As DetalleSolicitudMantenimientoDTO
        Using ctx As New AppDbContext()
            Return ctx.ActivoFisico.
                Include(Function(a) a.Activo).
                    ThenInclude(Function(a) a.SubCategoria).
                Include(Function(a) a.Activo).
                    ThenInclude(Function(a) a.Marca).
                Where(Function(a) a.IdActivoFisico = activoFisicoId).
                Select(Function(a) New DetalleSolicitudMantenimientoDTO With {
                    .ActivoFisicoId = a.IdActivoFisico,
                    .ActivoId = a.ActivoId,
                    .Activo = a.Activo.Nombre,
                    .CodEtiquetaQR = a.CodEtiquetaQR,
                    .NumSerie = a.NumSerie,
                    .SubCategoriaId = a.Activo.SubCategoriaId,
                    .SubCategoria = a.Activo.SubCategoria.Nombre,
                    .MarcaId = a.Activo.MarcaId,
                    .Marca = a.Activo.Marca.Nombre,
                    .DescripcionProblema = ""
                }).FirstOrDefault()
        End Using
    End Function

    Public Function Contar() As Integer
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of SolicitudMantenimiento)(ctx)
            Return repo.Consultar.Count()
        End Using
    End Function

    Public Function ContarPorEstado(idEstado As Integer) As Integer
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of SolicitudMantenimiento)(ctx)
            Return repo.Consultar().Count(Function(x) x.EstadoId = idEstado)
        End Using
    End Function

    Public Function Listar() As List(Of SolicitudMantenimientoDTO)
        Using ctx As New AppDbContext()
            Return ctx.SolicitudMantenimiento.
                Include(Function(s) s.Estado).
                Select(Function(s) New SolicitudMantenimientoDTO With {
                    .IdSolicitudMantenimiento = s.IdSolicitudMantenimiento,
                    .FechaSolicitud = s.FechaSolicitud,
                    .EstadoId = s.EstadoId,
                    .Estado = s.Estado.Nombre
                }).OrderByDescending(Function(s) s.IdSolicitudMantenimiento).ToList()
        End Using
    End Function

    Public Sub ValidarActivoDisponible(ctx As AppDbContext, activoFisicoId As Integer)
        Dim existe = ctx.DetalleSolicitudMantenimiento.
            Include(Function(d) d.SolicitudMantenimiento).
            Any(Function(d) d.ActivoFisicoId = activoFisicoId AndAlso d.SolicitudMantenimiento.EstadoId = CInt(EstadoSolicitudMantenimiento.Pendiente))

        If existe Then
            Throw New ExcepcionesdeNegocio("El activo ya posee una solicitud de mantenimiento pendiente")
        End If
    End Sub

    Private Sub ValidarActivo(activo As ActivoFisico)
        If activo Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe.")
        End If

        If activo.EstadoId = CInt(EstadoActivoFisico.Prestado) Then
            Throw New ExcepcionesdeNegocio("El activo se encuentra prestado.")
        End If

        If activo.EstadoId = CInt(EstadoActivoFisico.PendienteDeMantenimiento) Then
            Throw New ExcepcionesdeNegocio("El activo ya tiene una solicitud de mantenimiento pendiente.")
        End If
    End Sub

    Private Sub Validar(solicitud As SolicitudMantenimiento, detalle As List(Of DetalleSolicitudMantenimientoDTO))
        If solicitud Is Nothing Then
            Throw New ArgumentNullException(NameOf(solicitud))
        End If

        If detalle Is Nothing OrElse detalle.Count = 0 Then
            Throw New ExcepcionesdeNegocio("Debe agregar al menos un activo")
        End If

        If solicitud.FechaSolicitud.Date > Date.Now.Date Then
            Throw New ExcepcionesdeNegocio("La fecha de solicitud no puede ser mayor a la de hoy")
        End If

        For Each activo In detalle
            If String.IsNullOrWhiteSpace(activo.DescripcionProblema) Then
                Throw New ExcepcionesdeNegocio("Debe indicar el problema de todos los activos")
            End If
        Next
    End Sub

    Public Function RegistrarSolicitud(solicitud As SolicitudMantenimiento, detalle As List(Of DetalleSolicitudMantenimientoDTO)) As Integer
        Validar(solicitud, detalle)
        solicitud.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
        solicitud.EstadoId = CInt(EstadoSolicitudMantenimiento.Pendiente)

        Using ctx As New AppDbContext()
            Using transaccion = ctx.Database.BeginTransaction()
                Try
                    Dim repo As New RepositorioGenerico(Of SolicitudMantenimiento)(ctx)
                    Dim detalleRepo As New RepositorioGenerico(Of DetalleSolicitudMantenimiento)(ctx)
                    Dim activoFisicoServicios As New ActivoFisicoServicios()

                    repo.Agregar(solicitud)
                    ctx.SaveChanges()

                    For Each activos In detalle
                        Dim activo = activoFisicoServicios.ObtenerPorId(activos.ActivoFisicoId)
                        ValidarActivo(activo)
                        ValidarActivoDisponible(ctx, activos.ActivoFisicoId)

                        Dim nuevoDetalle As New DetalleSolicitudMantenimiento With {
                            .SolicitudMantenimientoId = solicitud.IdSolicitudMantenimiento,
                            .ActivoFisicoId = activos.ActivoFisicoId,
                            .DescripcionProblema = activos.DescripcionProblema
                        }
                        detalleRepo.Agregar(nuevoDetalle)

                        activo.EstadoId = CInt(EstadoActivoFisico.PendienteDeMantenimiento)
                        activoFisicoServicios.Actualizar(activo)
                    Next

                    ctx.SaveChanges()

                    Dim valoresNuevos = $"FechaSolicitud {solicitud.FechaSolicitud}, Observacion General: {solicitud.ObservacionGeneral}, Usuario registro{solicitud.UsuarioRegistroId}, Estado de la Solicitud {solicitud.EstadoId}"

                    Dim auditoriaServicios As New AuditoriaServicios()
                    auditoriaServicios.Registrar("Solicitud Mantenimiento", solicitud.IdSolicitudMantenimiento, TipoAccionAuditoria.Crear, "", valoresNuevos)

                    transaccion.Commit()
                    Return solicitud.IdSolicitudMantenimiento
                Catch
                    transaccion.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Function

    Public Function ExisteActivoEnDetalle(detalle As List(Of DetalleSolicitudMantenimientoDTO), activoFisicoId As Integer) As Boolean
        Return detalle.Any(Function(x) x.ActivoFisicoId = activoFisicoId)
    End Function

    Public Sub AgregarDetalle(detalle As List(Of DetalleSolicitudMantenimientoDTO), nuevo As DetalleSolicitudMantenimientoDTO)
        If nuevo Is Nothing Then
            Throw New ArgumentNullException(NameOf(nuevo))
        End If

        If ExisteActivoEnDetalle(detalle, nuevo.ActivoFisicoId) Then
            Throw New ExcepcionesdeNegocio("Este activo ya fue agregado a la solicitud.")
        End If

        detalle.Add(nuevo)
    End Sub

    Public Sub EliminarDetalle(detalle As List(Of DetalleSolicitudMantenimientoDTO), activoFisicoId As Integer)
        Dim item = detalle.FirstOrDefault(Function(x) x.ActivoFisicoId = activoFisicoId)
        If item Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe en la solicitud")
        End If
        detalle.Remove(item)
    End Sub

    Public Function ObtenerProximoNumeroSolicitud() As Integer
        Using ctx As New AppDbContext()
            If Not ctx.SolicitudMantenimiento.Any() Then
                Return 1
            End If
            Return ctx.SolicitudMantenimiento.Max(Function(s) s.IdSolicitudMantenimiento) + 1
        End Using
    End Function

    Public Sub Actualizar(solicitud As SolicitudMantenimiento)
        If solicitud Is Nothing Then
            Throw New ArgumentNullException(NameOf(solicitud))
        End If
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of SolicitudMantenimiento)(ctx)
            repo.Actualizar(solicitud)
        End Using
    End Sub

End Class
