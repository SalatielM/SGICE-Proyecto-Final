Imports DAO
Imports MODELOS
Imports System.Text.Json
Imports Microsoft.Identity.Client.Cache

Public Class EntradaServicios

    Public Sub New()

    End Sub

    Private Sub ValidarDetalle(activo As DetalleEntradaDTO)
        If activo Is Nothing Then
            Throw New ArgumentNullException(NameOf(activo))
        End If

        If activo.ActivoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un activo")
        End If

        If activo.Cantidad <= 0 Then
            Throw New ExcepcionesdeNegocio("La cantidad debe ser mayor a cero")
        End If
    End Sub

    Private Function ExisteActivo(detalle As List(Of DetalleEntradaDTO), activoId As Integer) As Boolean
        Return detalle.Any(Function(d) d.ActivoId = activoId)
    End Function

    Private Function ObtenerDetalle(detalle As List(Of DetalleEntradaDTO), activoId As Integer) As DetalleEntradaDTO
        Dim iActivo = detalle.FirstOrDefault(Function(d) d.ActivoId = activoId)

        If iActivo Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe en el detalle de la entrada.")
        End If
        Return iActivo
    End Function

    Public Sub EditarDetalle(detalle As List(Of DetalleEntradaDTO), activoId As Integer, nuevaCantidad As Integer)
        If detalle Is Nothing Then
            Throw New ExcepcionesdeNegocio("No existe un detalle para procesar")
        End If

        If nuevaCantidad <= 0 Then
            Throw New ExcepcionesdeNegocio("La cantidad debe ser mayor a cero")
        End If

        Dim iActivo = ObtenerDetalle(detalle, activoId)

        iActivo.Cantidad = nuevaCantidad
    End Sub

    Public Sub AgregarDetalle(detalle As List(Of DetalleEntradaDTO), iActivo As DetalleEntradaDTO)
        ValidarDetalle(iActivo)

        Dim activoServicios As New ActivoServicios()
        activoServicios.ObtenerPorId(iActivo.ActivoId)
        activoServicios.ValidarEstadoActivo(iActivo.ActivoId)

        If ExisteActivo(detalle, iActivo.ActivoId) Then
            Throw New ExcepcionesdeNegocio("Este activo ya fue agregado al detalle")
        End If

        detalle.Add(iActivo)
    End Sub

    Public Sub EliminarDetalle(detalle As List(Of DetalleEntradaDTO), activoId As Integer)
        If detalle Is Nothing Then
            Throw New ExcepcionesdeNegocio("No existe un detalle para procesar")
        End If
        Dim iActivo = ObtenerDetalle(detalle, activoId)

        detalle.Remove(iActivo)
    End Sub

    Private Sub ValidarEntrada(entrada As Entrada, detalle As List(Of DetalleEntradaDTO), activoFisico As List(Of ActivoFisicoDTO))
        If entrada Is Nothing Then
            Throw New ExcepcionesdeNegocio("La informacion de entrada es invalida.")
        End If

        If detalle Is Nothing OrElse detalle.Count = 0 Then
            Throw New ExcepcionesdeNegocio("Debe agregar al menos un activo a la entrada.")
        End If

        If activoFisico Is Nothing Then
            Throw New ExcepcionesdeNegocio("No existen activos para registrar.")
        End If

        If Not String.IsNullOrWhiteSpace(entrada.ObservacionEntrada) AndAlso entrada.ObservacionEntrada.Length > 300 Then
            Throw New ExcepcionesdeNegocio("La observacion no puede tener mas de 300 caracteres.")
        End If
    End Sub

    Public Function GenerarNumeroEntrada(ctx As AppDbContext) As Integer
        Dim repoEntrada As New RepositorioGenerico(Of Entrada)(ctx)
        Dim ultimoNumero = repoEntrada.Consultar().
            OrderByDescending(Function(e) e.NumEntrada).
            Select(Function(e) e.NumEntrada).
            FirstOrDefault()

        Return ultimoNumero + 1
    End Function

    Public Sub RegistrarEntrada(entrada As Entrada, detalle As List(Of DetalleEntradaDTO), activoFisico As List(Of ActivoFisicoDTO))
        If activoFisico Is Nothing OrElse activoFisico.Count = 0 Then
            Throw New ExcepcionesdeNegocio("Debe generar los activos fisicos antes de registrar la entrada")
        End If

        Using ctx As New AppDbContext()
            Using transaccion = ctx.Database.BeginTransaction()
                Try
                    ValidarEntrada(entrada, detalle, activoFisico)
                    entrada.NumEntrada = GenerarNumeroEntrada(ctx)
                    entrada.FechaEntrada = DateTime.Now
                    entrada.UsuarioRegistroId = SesionActual.Usuario.IdUsuario

                    Dim repoEntrada As New RepositorioGenerico(Of Entrada)(ctx)
                    Dim repoDetalle As New RepositorioGenerico(Of DetalleEntrada)(ctx)
                    Dim repoActivoFisico As New RepositorioGenerico(Of ActivoFisico)(ctx)

                    repoEntrada.Agregar(entrada)
                    ctx.SaveChanges()

                    For Each iActivo In detalle
                        Dim detalleRegistrado = RegistrarDetalleEntrada(repoDetalle, entrada, iActivo)
                        Dim activosDelDetalle = activoFisico.Where(Function(a) a.ActivoId = iActivo.ActivoId).ToList()
                        RegistrarActivosFisicos(repoActivoFisico, detalleRegistrado, activosDelDetalle)
                    Next

                    ctx.SaveChanges()

                    Dim valoresNuevos = $"Fecha Entrada: {entrada.FechaEntrada}, No Entrada {entrada.NumEntrada} Documento Referencia: {entrada.DocReferencia}, No. documento refernecia {entrada.NoDocReferencia}, Observacones {entrada.ObservacionEntrada}"

                    Dim auditoriaservicios As New AuditoriaServicios()
                    auditoriaservicios.Registrar("Entrada", entrada.IdEntrada, TipoAccionAuditoria.Crear, "", valoresNuevos)

                    transaccion.Commit()
                Catch
                    transaccion.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Private Sub RegistrarActivosFisicos(repoActivoFisico As RepositorioGenerico(Of ActivoFisico), detalle As DetalleEntrada, activoFisico As List(Of ActivoFisicoDTO))
        If activoFisico Is Nothing Then
            Throw New ExcepcionesdeNegocio("No existen activos fisicos para registrar")
        End If

        For Each dto In activoFisico
            Dim numSerie As String = If(String.IsNullOrWhiteSpace(dto.NumSerie), "N/A", dto.NumSerie)

            Dim activo As New ActivoFisico With {
                .CodEtiquetaQR = dto.CodEtiquetaQR,
                .NumSerie = numSerie,
                .ActivoId = dto.ActivoId,
                .UbicacionId = dto.UbicacionId,
                .EstadoId = CInt(EstadoActivoFisico.Disponible),
                .DetalleEntradaId = detalle.IdDetalleEntrada,
                .FechaRegistro = DateTime.Now,
                .UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            }

            repoActivoFisico.Agregar(activo)
        Next
    End Sub

    Private Function RegistrarDetalleEntrada(repoDetalle As RepositorioGenerico(Of DetalleEntrada), entrada As Entrada, iActivo As DetalleEntradaDTO) As DetalleEntrada
        Dim detalle As New DetalleEntrada With {
            .EntradaId = entrada.IdEntrada,
            .ActivoId = iActivo.ActivoId,
            .Cantidad = iActivo.Cantidad
        }
        repoDetalle.Agregar(detalle)
        Return detalle
    End Function

    Public Function GenerarActivosFisicosTemporales(detalle As DetalleEntradaDTO, activoEnMemoria As List(Of ActivoFisicoDTO)) As List(Of ActivoFisicoDTO)
        If detalle Is Nothing Then
            Throw New ExcepcionesdeNegocio("El detalle de entrada es invalido.")
        End If

        If detalle.Cantidad <= 0 Then
            Throw New ExcepcionesdeNegocio("La cantidad debe ser mayor que cero")
        End If

        Dim estadoservicios As New EstadoServicios()
        Dim ubicacionservicios As New UbicacionServicios()

        Dim lista As New List(Of ActivoFisicoDTO)
        Dim estadoDisponible = estadoservicios.ObtenerPorNombre("Disponible")
        estadoservicios.ValidarEstado(estadoDisponible.IdEstado, TipoEstadoEnum.ActivoFisico)
        Dim almacenPrincipal = ubicacionservicios.ObtenerPorNombreUbicacion("Almacen Principal")
        ubicacionservicios.ValidarEstadoUbicacion(almacenPrincipal.IdUbicacion)

        Dim consecutivoDB = CInt(ObtenerUltimoIdActivoFisico())
        Dim maxMemoria = 0

        If activoEnMemoria IsNot Nothing AndAlso activoEnMemoria.Any() Then
            maxMemoria = activoEnMemoria.Max(Function(a)
                                                 Dim num As Integer = 0
                                                 Integer.TryParse(a.CodEtiquetaQR.Replace("AF-", ""), num)
                                                 Return num
                                             End Function)
        End If

        Dim consecutivo = Math.Max(consecutivoDB, maxMemoria)

        For i As Integer = 1 To detalle.Cantidad
            consecutivo += 1

            lista.Add(New ActivoFisicoDTO With {
                .ActivoId = detalle.ActivoId,
                .Activo = detalle.NombreActivo,
                .CodEtiquetaQR = $"AF-{consecutivo:D7}",
                .NumSerie = String.Empty,
                .UbicacionId = almacenPrincipal.IdUbicacion,
                .Ubicacion = almacenPrincipal.Nombre,
                .EstadoId = CInt(EstadoActivoFisico.Disponible),
                .Estado = "Disponible"
            })
        Next

        Return lista
    End Function

    Private Function ObtenerUltimoIdActivoFisico() As String
        Using ctx As New AppDbContext()
            Dim repoActivoFisico As New RepositorioGenerico(Of ActivoFisico)(ctx)
            Dim query = repoActivoFisico.Consultar()
            If Not query.Any() Then
                Return "0"
            End If
            Return query.Max(Function(af) af.IdActivoFisico).ToString()
        End Using
    End Function

End Class
