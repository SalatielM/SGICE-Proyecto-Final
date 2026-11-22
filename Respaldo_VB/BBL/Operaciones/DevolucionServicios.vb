Imports DAO
Imports MODELOS
Imports System.Text.Json
Imports Microsoft.EntityFrameworkCore

Public Class DevolucionServicios

    Public Sub New()

    End Sub

    Public Function ObtenerPorId(idDevolucion As Integer) As Devolucion
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Devolucion)(ctx)
            Dim devolucion = repo.ObtenerPorId(idDevolucion)
            If devolucion Is Nothing Then
                Throw New ExcepcionesdeNegocio("La devolucion no existe")
            End If
            Return devolucion
        End Using
    End Function

    Public Function Listar() As List(Of DetalleDevolucionDTO)
        Using ctx As New AppDbContext()
            Return ctx.Devolucion.
                Include(Function(d) d.Prestamo).
                ThenInclude(Function(p) p.PersonalSolicitante).
                Select(Function(d) New DetalleDevolucionDTO With {
                    .DevolucionId = d.IdDevolucion,
                    .PrestamoId = d.Prestamo.PersonalSolicitanteId,
                    .Solicitante = d.Prestamo.PersonalSolicitante.Nombre & " " & d.Prestamo.PersonalSolicitante.Apellido,
                    .CodPersonal = d.Prestamo.PersonalSolicitante.CodPersonal,
                    .FechaPrestamo = d.Prestamo.FechaPrestamo,
                    .FechaDevolucion = d.FechaDevolucion
                }).ToList()
        End Using
    End Function

    Public Function ObtenerDetallePrestamo(idPrestamo As Integer) As List(Of DetalleDevolucionDTO)
        Using ctx As New AppDbContext()
            Dim activosDevueltos = ctx.DetalleDevolucion.
                Include(Function(dd) dd.Devolucion).
                Where(Function(dd) dd.Devolucion.PrestamoId = idPrestamo).
                Select(Function(dd) dd.ActivoFisicoId).
                ToList()

            Return ctx.DetallePrestamo.
                Include(Function(dp) dp.ActivoFisico).
                    ThenInclude(Function(af) af.Activo).
                        ThenInclude(Function(a) a.SubCategoria).
                Include(Function(dp) dp.ActivoFisico).
                    ThenInclude(Function(af) af.Activo).
                        ThenInclude(Function(a) a.Marca).
                Include(Function(dp) dp.ActivoFisico).
                    ThenInclude(Function(af) af.Estado).
                Where(Function(dp) dp.PrestamoId = idPrestamo AndAlso
                                   Not activosDevueltos.Contains(dp.ActivoFisicoId)).
                Select(Function(dp) New DetalleDevolucionDTO With {
                    .ActivoFisicoId = dp.ActivoFisicoId,
                    .ActivoId = dp.ActivoFisico.ActivoId,
                    .Activo = dp.ActivoFisico.Activo.Nombre,
                    .CodEtiquetaQR = dp.ActivoFisico.CodEtiquetaQR,
                    .NumSerie = dp.ActivoFisico.NumSerie,
                    .SubCategoriaId = dp.ActivoFisico.Activo.SubCategoriaId,
                    .SubCategoria = dp.ActivoFisico.Activo.SubCategoria.Nombre,
                    .MarcaId = dp.ActivoFisico.Activo.MarcaId,
                    .Marca = dp.ActivoFisico.Activo.Marca.Nombre,
                    .EstadoDevolucionId = CInt(EstadoDetalleDevolucion.Bueno),
                    .EstadoDevolucion = "Bueno",
                    .Obervacion = ""
                }).ToList()
        End Using
    End Function

    Private Sub Validar(devolucion As Devolucion, detalle As List(Of DetalleDevolucionDTO))
        If devolucion Is Nothing Then
            Throw New ArgumentNullException(NameOf(devolucion))
        End If

        If devolucion.PrestamoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un préstamo.")
        End If

        If detalle Is Nothing OrElse detalle.Count = 0 Then
            Throw New ExcepcionesdeNegocio("Debe devolver al menos un activo.")
        End If

        If devolucion.FechaDevolucion.Date > Date.Today Then
            Throw New ExcepcionesdeNegocio("La fecha de devolución no puede ser mayor a la fecha actual.")
        End If
    End Sub

    Private Sub ActualizarEstadoActivo(activoFisicoServicios As ActivoFisicoServicios, item As DetalleDevolucionDTO)
        Dim activo = activoFisicoServicios.ObtenerPorId(item.ActivoFisicoId)
        If activo Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo físico no existe.")
        End If

        Select Case item.EstadoDevolucionId
            Case CInt(EstadoDetalleDevolucion.Bueno)
                activo.EstadoId = CInt(EstadoActivoFisico.Disponible)
            Case CInt(EstadoDetalleDevolucion.Regular)
                activo.EstadoId = CInt(EstadoActivoFisico.Disponible)
            Case CInt(EstadoDetalleDevolucion.Averiado)
                activo.EstadoId = CInt(EstadoActivoFisico.NoDisponible)
            Case CInt(EstadoDetalleDevolucion.Incompleto)
                activo.EstadoId = CInt(EstadoActivoFisico.NoDisponible)
            Case CInt(EstadoDetalleDevolucion.NoDevuelto)
                activo.EstadoId = CInt(EstadoActivoFisico.NoDisponible)
        End Select

        activoFisicoServicios.Actualizar(activo)
    End Sub

    Private Sub ActualizarEstadoPrestamo(ctx As AppDbContext, prestamoId As Integer)
        Dim totalPrestados = ctx.DetallePrestamo.Where(Function(dp) dp.PrestamoId = prestamoId).Count()
        Dim totalDevueltos = ctx.DetalleDevolucion.Include(Function(dd) dd.Devolucion).Where(Function(dd) dd.Devolucion.PrestamoId = prestamoId).Count()
        Dim prestamo = ctx.Prestamo.FirstOrDefault(Function(p) p.IdPrestamo = prestamoId)

        If prestamo IsNot Nothing Then
            If totalDevueltos >= totalPrestados Then
                prestamo.EstadoId = CInt(EstadoPrestamo.Devuelto)
            Else
                prestamo.EstadoId = CInt(EstadoPrestamo.DevueltoParcial)
            End If

            ctx.Entry(prestamo).State = Microsoft.EntityFrameworkCore.EntityState.Modified
            ctx.SaveChanges()
        End If
    End Sub

    Public Sub RegistrarDevolucion(devolucion As Devolucion, detalle As List(Of DetalleDevolucionDTO))
        Validar(devolucion, detalle)

        Using ctx As New AppDbContext()
            Dim prestamoServicios As New PrestamoServicios()
            ValidarPrestamo(ctx, devolucion.PrestamoId)

            devolucion.UsuarioRegistroId = SesionActual.Usuario.IdUsuario

            Using transaccion = ctx.Database.BeginTransaction()
                Try
                    Dim repo As New RepositorioGenerico(Of Devolucion)(ctx)
                    Dim detalleRepo As New RepositorioGenerico(Of DetalleDevolucion)(ctx)
                    Dim activoFisicoServicios As New ActivoFisicoServicios()

                    repo.Agregar(devolucion)
                    ctx.SaveChanges()

                    For Each item In detalle
                        ValidarActivoPerteneceAlPrestamo(ctx, devolucion.PrestamoId, item.ActivoFisicoId)
                        Dim nuevoDetalle As New DetalleDevolucion With {
                            .DevolucionId = devolucion.IdDevolucion,
                            .ActivoFisicoId = item.ActivoFisicoId,
                            .EstadoDevolucionId = item.EstadoDevolucionId,
                            .Obervacion = item.Obervacion
                        }

                        detalleRepo.Agregar(nuevoDetalle)
                        ActualizarEstadoActivo(activoFisicoServicios, item)
                    Next

                    ActualizarEstadoPrestamo(ctx, devolucion.PrestamoId)
                    ctx.SaveChanges()

                    Dim valoresNuevos = $"Fecha devolucion {devolucion.FechaDevolucion}, Observacione General {devolucion.ObervacioneGeneral}, Prestamo{devolucion.PrestamoId}, Usuario Registro{devolucion.UsuarioRegistroId}"

                    Dim auditoriaServicios As New AuditoriaServicios()
                    auditoriaServicios.Registrar("Devolucion", devolucion.IdDevolucion, TipoAccionAuditoria.Crear, "", valoresNuevos)

                    transaccion.Commit()
                Catch
                    transaccion.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Public Function ExisteActivoEnDetalle(detalle As List(Of DetalleDevolucionDTO), activoFisicoId As Integer) As Boolean
        Return detalle.Any(Function(x) x.ActivoFisicoId = activoFisicoId)
    End Function

    Public Sub AgregarDetalle(detalle As List(Of DetalleDevolucionDTO), nuevo As DetalleDevolucionDTO)
        If nuevo Is Nothing Then
            Throw New ArgumentNullException(NameOf(nuevo))
        End If
        If ExisteActivoEnDetalle(detalle, nuevo.ActivoFisicoId) Then
            Throw New ExcepcionesdeNegocio("Este activo ya fue agregado a la devolución.")
        End If

        detalle.Add(nuevo)
    End Sub

    Public Sub EliminarDetalle(detalle As List(Of DetalleDevolucionDTO), activoFisicoId As Integer)
        Dim item = detalle.FirstOrDefault(Function(x) x.ActivoFisicoId = activoFisicoId)

        If item Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe en la devolución.")
        End If

        detalle.Remove(item)
    End Sub

    Public Function ObtenerCantidadPendiente(prestamoId As Integer) As Integer
        Using ctx As New AppDbContext()
            Dim totalPrestados = ctx.DetallePrestamo.Count(Function(dp) dp.PrestamoId = prestamoId)
            Dim totalDevueltos = ctx.DetalleDevolucion.Include(Function(dd) dd.Devolucion).Count(Function(dd) dd.Devolucion.PrestamoId = prestamoId)
            Return totalPrestados - totalDevueltos
        End Using
    End Function

    Private Sub ValidarPrestamo(ctx As AppDbContext, prestamoId As Integer)
        Dim prestamoServicios As New PrestamoServicios()
        Dim prestamo = prestamoServicios.ObtenerPorId(prestamoId)
        If prestamo.EstadoId <> CInt(EstadoPrestamo.Vigente) AndAlso prestamo.EstadoId <> CInt(EstadoPrestamo.DevueltoParcial) Then
            Throw New ExcepcionesdeNegocio("El préstamo no admite devoluciones.")
        End If
    End Sub

    Private Sub ValidarActivoPerteneceAlPrestamo(ctx As AppDbContext, prestamoId As Integer, activoFisicoId As Integer)
        Dim existe = ctx.DetallePrestamo.Any(Function(dp) dp.PrestamoId = prestamoId AndAlso dp.ActivoFisicoId = activoFisicoId)

        If Not existe Then
            Throw New ExcepcionesdeNegocio("El activo no pertenece al préstamo seleccionado.")
        End If
    End Sub

End Class
