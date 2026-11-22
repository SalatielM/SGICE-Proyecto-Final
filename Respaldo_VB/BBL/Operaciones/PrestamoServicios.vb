Imports DAO
Imports MODELOS
Imports System.Text.Json
Imports Microsoft.EntityFrameworkCore

Public Class PrestamoServicios

    Public Sub New()

    End Sub

    Public Function ObtenerPorId(idPrestamo As Integer) As Prestamo
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Prestamo)(ctx)
            Dim prestamo = repo.ObtenerPorId(idPrestamo)

            If prestamo Is Nothing Then
                Throw New ExcepcionesdeNegocio("El préstamo no existe.")
            End If

            Return prestamo
        End Using
    End Function

    Public Function ObtenerPrestamosPendientes(personalId As Integer) As List(Of PrestamoDTO)
        Using ctx As New AppDbContext()
            Dim prestamos = ctx.Prestamo.
                Include(Function(p) p.PersonalSolicitante).
                Include(Function(p) p.Estado).
                Where(Function(p) p.PersonalSolicitanteId = personalId AndAlso (p.EstadoId = CInt(EstadoPrestamo.Vigente) OrElse p.EstadoId = CInt(EstadoPrestamo.DevueltoParcial))).
                Select(Function(p) New PrestamoDTO With {
                    .IdPrestamo = p.IdPrestamo,
                    .FechaPrestamo = p.FechaPrestamo,
                    .FechaLimite = p.FechaLimite,
                    .EstadoId = p.EstadoId,
                    .Estado = p.Estado.Nombre,
                    .PersonalSolicitanteId = p.PersonalSolicitanteId,
                    .PersonalSolicitante = p.PersonalSolicitante.Nombre & " " & p.PersonalSolicitante.Apellido,
                    .CodPersonal = p.PersonalSolicitante.CodPersonal,
                    .UsuarioRegistroId = p.UsuarioRegistroId
                }).
                ToList()

            If prestamos.Count <= 0 Then
                Throw New ExcepcionesdeNegocio("El personal seleccionado tiene préstamos pendientes.")
            End If

            Return prestamos
        End Using
    End Function

    Public Function Contar() As Integer
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Prestamo)(ctx)
            Return repo.Consultar.Count()
        End Using
    End Function

    Public Function ContarPorEstado(idEstado As Integer) As Integer
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Prestamo)(ctx)
            Return repo.Consultar().Count(Function(x) x.EstadoId = idEstado)
        End Using
    End Function

    Public Function Listar() As List(Of PrestamoDTO)
        Using ctx As New AppDbContext()
            Return ctx.Prestamo.
                Include(Function(p) p.PersonalSolicitante).
                Include(Function(p) p.Estado).
                Select(Function(p) New PrestamoDTO With {
                    .IdPrestamo = p.IdPrestamo,
                    .FechaPrestamo = p.FechaPrestamo,
                    .FechaLimite = p.FechaLimite,
                    .EstadoId = p.EstadoId,
                    .Estado = p.Estado.Nombre,
                    .PersonalSolicitanteId = p.PersonalSolicitanteId,
                    .PersonalSolicitante = p.PersonalSolicitante.CodPersonal,
                    .UsuarioRegistroId = p.UsuarioRegistroId
                }).ToList()
        End Using
    End Function

    Public Function ListarDetalle() As List(Of PrestamoListaDTO)
        Using ctx As New AppDbContext()
            Return ctx.DetallePrestamo.
                Include(Function(dp) dp.Prestamo).
                    ThenInclude(Function(p) p.PersonalSolicitante).
                Include(Function(dp) dp.Prestamo).
                    ThenInclude(Function(p) p.Estado).
                Include(Function(dp) dp.ActivoFisico).
                    ThenInclude(Function(af) af.Activo).
                Select(Function(dp) New PrestamoListaDTO With {
                    .IdPrestamo = dp.PrestamoId,
                    .Solicitante = dp.Prestamo.PersonalSolicitante.Nombre & " " & dp.Prestamo.PersonalSolicitante.Apellido,
                    .CodPersonal = dp.Prestamo.PersonalSolicitante.CodPersonal,
                    .Activo = dp.ActivoFisico.Activo.Nombre,
                    .FechaPrestamo = dp.Prestamo.FechaPrestamo,
                    .FechaFinalizacion = dp.Prestamo.FechaLimite,
                    .Estado = dp.Prestamo.Estado.Nombre
                }).ToList()
        End Using
    End Function

    Public Function CrearDetalleDesdeActivo(idActivoFisico As Integer) As DetallePrestamoDTO
        Dim activoServicios As New ActivoFisicoServicios()
        Dim activo = activoServicios.ObtenerPorId(idActivoFisico)

        If activo Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe.")
        End If

        If activo.EstadoId <> CInt(EstadoActivoFisico.Disponible) Then
            Throw New ExcepcionesdeNegocio("El activo no se encuentra disponible para préstamo.")
        End If

        Return New DetallePrestamoDTO With {
            .ActivoFisicoId = activo.IdActivoFisico,
            .ActivoId = activo.ActivoId,
            .Activo = activo.Activo.Nombre,
            .CodEtiquetaQR = activo.CodEtiquetaQR,
            .NumSerie = activo.NumSerie,
            .SubCategoriaId = activo.Activo.SubCategoriaId,
            .SubCategoria = activo.Activo.SubCategoria.Nombre,
            .MarcaId = activo.Activo.MarcaId,
            .Marca = activo.Activo.Marca.Nombre,
            .EstadoId = activo.EstadoId,
            .Estado = activo.Estado.Nombre
        }
    End Function

    Public Sub RegistrarPrestamo(prestamo As Prestamo, detalle As List(Of DetallePrestamo))
        If prestamo Is Nothing Then
            Throw New ArgumentNullException(NameOf(prestamo))
        End If

        If detalle Is Nothing OrElse detalle.Count = 0 Then
            Throw New ExcepcionesdeNegocio("Debe agregar al menos un activo al préstamo.")
        End If

        Validar(prestamo)

        Dim estadoServicios As New EstadoServicios()
        estadoServicios.ValidarEstado(prestamo.EstadoId, TipoEstadoEnum.Prestamo)
        prestamo.UsuarioRegistroId = SesionActual.Usuario.IdUsuario

        Using ctx As New AppDbContext()
            Using transaccion = ctx.Database.BeginTransaction()
                Try
                    Dim repo As New RepositorioGenerico(Of Prestamo)(ctx)
                    Dim detalleRepo As New RepositorioGenerico(Of DetallePrestamo)(ctx)
                    Dim activoFisicoServicios As New ActivoFisicoServicios()

                    repo.Agregar(prestamo)
                    ctx.SaveChanges()

                    For Each item In detalle
                        item.PrestamoId = prestamo.IdPrestamo
                        detalleRepo.Agregar(item)

                        Dim activo = activoFisicoServicios.ObtenerPorId(item.ActivoFisicoId)
                        If activo Is Nothing Then
                            Throw New ExcepcionesdeNegocio("El activo físico no existe.")
                        End If

                        activo.EstadoId = CInt(EstadoActivoFisico.Prestado)
                        activoFisicoServicios.Actualizar(activo)
                    Next

                    ctx.SaveChanges()

                    Dim valoresNuevos = $"FechaPrestamo: {prestamo.FechaPrestamo}, FechaLimite: {prestamo.FechaLimite}, Estado del Prestamos {prestamo.EstadoId}"

                    Dim auditoriaServicios As New AuditoriaServicios()
                    auditoriaServicios.Registrar("Prestamo", prestamo.IdPrestamo, TipoAccionAuditoria.Crear, "", valoresNuevos)

                    transaccion.Commit()
                Catch
                    transaccion.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Private Sub Validar(prestamo As Prestamo)
        If prestamo.PersonalSolicitanteId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un solicitante.")
        End If

        ValidarFechas(prestamo.FechaPrestamo, prestamo.FechaLimite)
    End Sub

    Private Sub ValidarFechas(fechaPrestamo As DateTime, fechaLimite As DateTime)
        If fechaPrestamo.Date < Date.Today Then
            Throw New ExcepcionesdeNegocio("La fecha del préstamo no puede ser anterior a la fecha actual.")
        End If
        If fechaLimite.Date < fechaPrestamo.Date Then
            Throw New ExcepcionesdeNegocio("La fecha límite debe ser mayor o igual a la fecha del préstamo.")
        End If
    End Sub

    Public Function ExisteActivoEnDetalle(lista As List(Of DetallePrestamoDTO), idActivoFisico As Integer) As Boolean
        Return lista.Any(Function(x) x.ActivoFisicoId = idActivoFisico)
    End Function

    Public Sub EliminarDetalle(detalle As List(Of DetallePrestamoDTO), activoFisicoId As Integer)
        Dim item = detalle.FirstOrDefault(Function(a) a.ActivoFisicoId = activoFisicoId)

        If item Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe en el detalle.")
        End If

        detalle.Remove(item)
    End Sub

    Public Sub AgregarDetalle(detalle As List(Of DetallePrestamoDTO), nuevo As DetallePrestamoDTO)
        If nuevo Is Nothing Then
            Throw New ArgumentNullException(NameOf(nuevo))
        End If

        If ExisteActivo(detalle, nuevo.ActivoFisicoId) Then
            Throw New ExcepcionesdeNegocio("Este activo ya fue agregado al préstamo.")
        End If

        detalle.Add(nuevo)
    End Sub

    Private Function ExisteActivo(detalle As List(Of DetallePrestamoDTO), activoFisicoId As Integer) As Boolean
        Return detalle.Any(Function(a) a.ActivoFisicoId = activoFisicoId)
    End Function

    Public Sub Actualizar(prestamo As Prestamo)
        If prestamo Is Nothing Then
            Throw New ArgumentNullException(NameOf(prestamo))
        End If

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Prestamo)(ctx)
            repo.Actualizar(prestamo)
        End Using
    End Sub

End Class
