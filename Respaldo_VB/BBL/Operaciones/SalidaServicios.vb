Imports System.Text.Json
Imports DAO
Imports MODELOS

Public Class SalidaServicios

    Public Sub New()

    End Sub

    Private Sub ValidarDetalle(detalle As DetalleSalidaDTO)
        If detalle Is Nothing Then
            Throw New ArgumentNullException(NameOf(detalle))
        End If

        If detalle.ActivoFisicoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un activo valido para la salida.")
        End If

        If detalle.MotivoSalida <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe especificar el motivo de salida de todos los activos")
        End If
    End Sub

    Private Function ExisteActivo(listaDetalles As List(Of DetalleSalidaDTO), ActivoFisicoId As Integer) As Boolean
        Return listaDetalles.Any(Function(d) d.ActivoFisicoId = ActivoFisicoId)
    End Function

    Public Sub AgregarDetalle(listaDetalles As List(Of DetalleSalidaDTO), nuevoDetalle As DetalleSalidaDTO)
        If listaDetalles Is Nothing Then
            Throw New ExcepcionesdeNegocio("No existe una lista de detalles para procesar.")
        End If

        ValidarDetalle(nuevoDetalle)

        Using ctx As New AppDbContext()
            Dim repoActivoFisico As New RepositorioGenerico(Of ActivoFisico)(ctx)
            Dim activoFisico = repoActivoFisico.Consultar().FirstOrDefault(Function(a) a.IdActivoFisico = nuevoDetalle.ActivoFisicoId)

            If activoFisico Is Nothing Then
                Throw New ExcepcionesdeNegocio("El activo fisico seleccionado no existe.")
            End If

            If activoFisico.EstadoId <> CInt(EstadoActivoFisico.Disponible) Then
                Throw New ExcepcionesdeNegocio("No se puede procesar el activo porque no se encuentra disponible.")
            End If

            If ExisteActivo(listaDetalles, nuevoDetalle.ActivoFisicoId) Then
                Throw New ExcepcionesdeNegocio("Este activo ya fue agregado al detalle de la salida.")
            End If

            listaDetalles.Add(nuevoDetalle)
        End Using
    End Sub

    Public Sub EliminarDetalle(listaDetalles As List(Of DetalleSalidaDTO), activoFisicoId As Integer)
        If listaDetalles Is Nothing Then
            Throw New ExcepcionesdeNegocio("No existe una lista de detalles para procesar.")
        End If

        Dim activoEliminar = listaDetalles.FirstOrDefault(Function(d) d.ActivoFisicoId = activoFisicoId)

        If activoEliminar Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe en el detalle de la salida.")
        End If

        listaDetalles.Remove(activoEliminar)
    End Sub

    Private Sub ValidarSalida(salida As Salida, listaDetalles As List(Of DetalleSalidaDTO))
        If salida Is Nothing Then
            Throw New ExcepcionesdeNegocio("La información de la salida es inválida.")
        End If

        If listaDetalles Is Nothing OrElse listaDetalles.Count = 0 Then
            Throw New ExcepcionesdeNegocio("Debe agregar al menos un activo físico a la salida.")
        End If

        If Not String.IsNullOrWhiteSpace(salida.Observaciones) AndAlso salida.Observaciones.Length > 300 Then
            Throw New ExcepcionesdeNegocio("Las observaciones de salida no pueden ser mayores a 300 caracteres")
        End If
    End Sub

    Public Function GeneranNumeroSalida(ctx As AppDbContext) As Integer
        Dim repoSalida As New RepositorioGenerico(Of Salida)(ctx)
        Dim ultimoNumero = repoSalida.Consultar().
            OrderByDescending(Function(s) s.NumSalida).
            Select(Function(s) s.NumSalida).
            FirstOrDefault()

        Return ultimoNumero + 1
    End Function

    Public Sub RegistrarSalida(salida As Salida, listaDetalles As List(Of DetalleSalidaDTO))
        If listaDetalles Is Nothing OrElse listaDetalles.Count = 0 Then
            Throw New ExcepcionesdeNegocio("Debe agregar al menos un activo físico a la salida.")
        End If

        Using ctx As New AppDbContext()
            Using transaccion = ctx.Database.BeginTransaction()
                Try
                    ValidarSalida(salida, listaDetalles)

                    salida.NumSalida = GeneranNumeroSalida(ctx)
                    salida.FechaSalida = DateTime.Now
                    salida.UsuarioRegistroId = SesionActual.Usuario.IdUsuario

                    Dim repoSalida As New RepositorioGenerico(Of Salida)(ctx)
                    Dim repoDetalleSalida As New RepositorioGenerico(Of DetalleSalida)(ctx)
                    Dim repoActivoFisico As New RepositorioGenerico(Of ActivoFisico)(ctx)

                    repoSalida.Agregar(salida)
                    ctx.SaveChanges()

                    For Each activo In listaDetalles
                        Dim detalle As New DetalleSalida With {
                            .SalidaId = salida.IdSalida,
                            .ActivoFisicoId = activo.ActivoFisicoId,
                            .MotivoSalida = activo.MotivoSalida
                        }
                        repoDetalleSalida.Agregar(detalle)

                        Dim estadoDestino = ObtenerEstadoDesdeMotivo(activo.MotivoSalida)
                        Dim activoFisico = repoActivoFisico.Consultar().FirstOrDefault(Function(a) a.IdActivoFisico = activo.ActivoFisicoId)

                        If activoFisico Is Nothing Then
                            Throw New ExcepcionesdeNegocio($"No se encontro el activo fisico con Id {activo.ActivoFisicoId} para actualizar su estado.")
                        End If

                        activoFisico.EstadoId = CInt(estadoDestino)
                        repoActivoFisico.Actualizar(activoFisico)
                    Next

                    Dim valoresNuevos = $"Fecha Salida {salida.FechaSalida}, Motivo: {salida.RazonSalida}, No Salida {salida.NumSalida}, Observciones {salida.Observaciones}"

                    Dim auditoriaservicios As New AuditoriaServicios()
                    auditoriaservicios.Registrar("Salida", salida.IdSalida, TipoAccionAuditoria.Crear, "", valoresNuevos)

                    transaccion.Commit()
                Catch
                    transaccion.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Private Function ObtenerEstadoDesdeMotivo(motivo As MotivoSalida) As EstadoActivoFisico
        Select Case motivo
            Case MotivoSalida.DanioIrreparable, MotivoSalida.Venta, MotivoSalida.Donacion, MotivoSalida.Robo, MotivoSalida.Extravio, MotivoSalida.Transferencia, MotivoSalida.OtroMotivo
                Return EstadoActivoFisico.DadoDeBaja
            Case Else
                Return EstadoActivoFisico.Disponible
        End Select
    End Function

End Class
