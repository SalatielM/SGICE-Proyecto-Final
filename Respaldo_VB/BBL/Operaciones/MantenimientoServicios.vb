Imports DAO
Imports MODELOS
Imports System.Text.Json
Imports Microsoft.EntityFrameworkCore

Public Class MantenimientoServicios

    Public Sub New()

    End Sub

    Public Function ObtenerPorId(idMantenimiento As Integer) As Mantenimiento
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Mantenimiento)(ctx)
            Dim mantenimiento = repo.ObtenerPorId(idMantenimiento)
            If mantenimiento Is Nothing Then
                Throw New ExcepcionesdeNegocio("El mantenimiento no existe.")
            End If
            Return mantenimiento
        End Using
    End Function

    Public Function ListarSolicitudesPendientes() As List(Of SolicitudMantenimientoDTO)
        Using ctx As New AppDbContext()
            Return ctx.SolicitudMantenimiento.
                Include(Function(s) s.Estado).
                Where(Function(s) s.EstadoId = CInt(EstadoSolicitudMantenimiento.Pendiente)).
                Select(Function(s) New SolicitudMantenimientoDTO With {
                    .IdSolicitudMantenimiento = s.IdSolicitudMantenimiento,
                    .FechaSolicitud = s.FechaSolicitud,
                    .EstadoId = s.EstadoId,
                    .Estado = s.Estado.Nombre
                }).OrderBy(Function(s) s.IdSolicitudMantenimiento).ToList()
        End Using
    End Function

    Public Function ObtenerDetalleSolicitud(idSolicitud As Integer) As List(Of DetalleMantenimientoDTO)
        Using ctx As New AppDbContext()
            Return ctx.DetalleSolicitudMantenimiento.
                Include(Function(d) d.ActivoFisico).
                    ThenInclude(Function(a) a.Activo).
                        ThenInclude(Function(a) a.SubCategoria).
                            ThenInclude(Function(s) s.Categoria).
                Include(Function(d) d.ActivoFisico).
                    ThenInclude(Function(a) a.Activo).
                    ThenInclude(Function(a) a.Marca).
                Where(Function(d) d.SolicitudMantenimientoId = idSolicitud).
                Select(Function(d) New DetalleMantenimientoDTO With {
                    .ActivoFisicoId = d.ActivoFisicoId,
                    .ActivoId = d.ActivoFisico.ActivoId,
                    .Activo = d.ActivoFisico.Activo.Nombre,
                    .CodEtiquetaQR = d.ActivoFisico.CodEtiquetaQR,
                    .NumSerie = d.ActivoFisico.NumSerie,
                    .MarcaId = d.ActivoFisico.Activo.MarcaId,
                    .Marca = d.ActivoFisico.Activo.Marca.Nombre,
                    .CategoriaId = d.ActivoFisico.Activo.SubCategoria.CategoriaId,
                    .Categoria = d.ActivoFisico.Activo.SubCategoria.Categoria.Nombre,
                    .SubCategoriaId = d.ActivoFisico.Activo.SubCategoriaId,
                    .SubCategoria = d.ActivoFisico.Activo.SubCategoria.Nombre,
                    .ProblemaReportado = d.DescripcionProblema,
                    .EstadoDetalleId = CInt(EstadoDetalleMantenimiento.EnProceso),
                    .EstadoDetalle = "En Proceso",
                    .Solucion = ""
                }).ToList()
        End Using
    End Function

    Private Sub ActualizarEstadoActivo(activoFisicoServicios As ActivoFisicoServicios, item As DetalleMantenimientoDTO)
        Dim activo = activoFisicoServicios.ObtenerPorId(item.ActivoFisicoId)
        If activo Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo físico no existe.")
        End If

        Select Case item.EstadoDetalleId
            Case CInt(EstadoDetalleMantenimiento.Reparado)
                activo.EstadoId = CInt(EstadoActivoFisico.Disponible)
            Case CInt(EstadoDetalleMantenimiento.NoReparado)
                activo.EstadoId = CInt(EstadoActivoFisico.Dañado)
        End Select
        activoFisicoServicios.Actualizar(activo)
    End Sub

    Public Sub RechazarSolicitud(idSolicitud As Integer)
        Using ctx As New AppDbContext()
            Using transaccion = ctx.Database.BeginTransaction()
                Try
                    Dim solicitudServicios As New SolicitudMantenimientoServicios()
                    Dim solicitud = solicitudServicios.ObtenerPorId(idSolicitud)

                    If solicitud.EstadoId <> CInt(EstadoSolicitudMantenimiento.Pendiente) Then
                        Throw New ExcepcionesdeNegocio("La solicitud ya fue procesada.")
                    End If

                    solicitud.EstadoId = CInt(EstadoSolicitudMantenimiento.Rechazada)
                    solicitudServicios.Actualizar(solicitud)

                    Dim activos = ctx.DetalleSolicitudMantenimiento.
                        Where(Function(d) d.SolicitudMantenimientoId = idSolicitud).
                        Select(Function(d) d.ActivoFisicoId).
                        ToList()

                    Dim activoFisicoServicios As New ActivoFisicoServicios()
                    For Each id In activos
                        Dim activo = activoFisicoServicios.ObtenerPorId(id)
                        If activo IsNot Nothing Then
                            activo.EstadoId = CInt(EstadoActivoFisico.Dañado)
                            activoFisicoServicios.Actualizar(activo)
                        End If
                    Next

                    ctx.SaveChanges()

                    Dim valoresNuevos = $"FechaSolicitud {solicitud.FechaSolicitud}, Observacion General: {solicitud.ObservacionGeneral}, Usuario registro{solicitud.UsuarioRegistroId}, Estado de la Solicitud {solicitud.EstadoId}"

                    Dim auditoriaServicios As New AuditoriaServicios()
                    auditoriaServicios.Registrar("Mantenimiento", solicitud.IdSolicitudMantenimiento, TipoAccionAuditoria.Actualizar, "", valoresNuevos)

                    transaccion.Commit()
                Catch
                    transaccion.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Private Sub Validar(mantenimiento As Mantenimiento, detalle As List(Of DetalleMantenimientoDTO))
        If mantenimiento Is Nothing Then
            Throw New ArgumentNullException(NameOf(mantenimiento))
        End If

        If mantenimiento.SolicitudMantenimientoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar una solicitud.")
        End If

        If mantenimiento.PersonalTecnicoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un técnico.")
        End If

        If detalle Is Nothing OrElse detalle.Count = 0 Then
            Throw New ExcepcionesdeNegocio("No existen activos para registrar.")
        End If

        For Each item In detalle
            If item.EstadoDetalleId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe indicar el estado del mantenimiento de todos los activos.")
            End If

            If String.IsNullOrWhiteSpace(item.Solucion) Then
                Throw New ExcepcionesdeNegocio("Debe indicar la solución aplicada a todos los activos.")
            End If
        Next
    End Sub

    Private Sub ActualizarEstadoSolicitud(solicitudServicios As SolicitudMantenimientoServicios, idSolicitud As Integer)
        Dim solicitud = solicitudServicios.ObtenerPorId(idSolicitud)
        solicitud.EstadoId = CInt(EstadoSolicitudMantenimiento.Atendida)
        solicitudServicios.Actualizar(solicitud)
    End Sub

    Public Sub RegistrarMantenimiento(mantenimiento As Mantenimiento, detalle As List(Of DetalleMantenimientoDTO))
        Validar(mantenimiento, detalle)

        mantenimiento.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
        mantenimiento.EstadoId = CInt(EstadoMantenimiento.Finalizado)
        mantenimiento.FechaInicioAtencion = Date.Now
        mantenimiento.FechaCierre = Date.Now

        Using ctx As New AppDbContext()
            Using transaccion = ctx.Database.BeginTransaction()
                Try
                    Dim repo As New RepositorioGenerico(Of Mantenimiento)(ctx)
                    Dim detalleRepo As New RepositorioGenerico(Of DetalleMantenimiento)(ctx)
                    Dim activoFisicoServicios As New ActivoFisicoServicios()
                    Dim solicitudServicios As New SolicitudMantenimientoServicios()

                    repo.Agregar(mantenimiento)
                    ctx.SaveChanges()

                    For Each activo In detalle
                        Dim nuevoDetalle As New DetalleMantenimiento With {
                            .MantenimientoId = mantenimiento.IdMantenimiento,
                            .ActivoFisicoId = activo.ActivoFisicoId,
                            .EstadoId = activo.EstadoDetalleId,
                            .Solucion = activo.Solucion
                        }

                        detalleRepo.Agregar(nuevoDetalle)
                        ActualizarEstadoActivo(activoFisicoServicios, activo)
                    Next

                    ActualizarEstadoSolicitud(solicitudServicios, mantenimiento.SolicitudMantenimientoId)
                    ctx.SaveChanges()

                    transaccion.Commit()
                Catch
                    transaccion.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

End Class
