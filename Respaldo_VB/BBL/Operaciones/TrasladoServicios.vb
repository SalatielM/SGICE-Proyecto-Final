Imports System.Text.Json
Imports DAO
Imports MODELOS

Public Class TrasladoServicios

    Public Sub New()

    End Sub

    Private Sub ValidarDetalle(detalle As DetalleTrasladoDTO)
        If detalle Is Nothing Then
            Throw New ArgumentNullException(NameOf(detalle))
        End If
        If detalle.ActivoFisicoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un activo físico.")
        End If
        If detalle.UbicacionActualId <= 0 Then
            Throw New ExcepcionesdeNegocio("El activo no posee una ubicación de origen.")
        End If
        If detalle.UbicacionActualId = detalle.UbicacionFinalId Then
            Throw New ExcepcionesdeNegocio("La ubicación origen y destino no pueden ser iguales.")
        End If
    End Sub

    Private Function ExisteActivo(detalle As List(Of DetalleTrasladoDTO), activoFisicoId As Integer) As Boolean
        Return detalle.Any(Function(d) d.ActivoFisicoId = activoFisicoId)
    End Function

    Private Function ObtenerDetalle(detalle As List(Of DetalleTrasladoDTO), activoFisicoId As Integer) As DetalleTrasladoDTO
        Dim activo = detalle.FirstOrDefault(Function(d) d.ActivoFisicoId = activoFisicoId)
        If activo Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe dentro del traslado.")
        End If
        Return activo
    End Function

    Public Sub AgregarDetalle(detalle As List(Of DetalleTrasladoDTO), activo As DetalleTrasladoDTO)
        If detalle Is Nothing Then
            Throw New ExcepcionesdeNegocio("No existe un detalle para procesar.")
        End If

        ValidarDetalle(activo)

        Using ctx As New AppDbContext()
            Dim repoActivoFisico As New RepositorioGenerico(Of ActivoFisico)(ctx)
            Dim activoDB = repoActivoFisico.ObtenerPorId(activo.ActivoFisicoId)

            If activoDB Is Nothing Then
                Throw New ExcepcionesdeNegocio("El activo físico no existe.")
            End If

            Dim estadoServicios As New EstadoServicios()
            estadoServicios.ValidarEstado(activoDB.EstadoId, TipoEstadoEnum.ActivoFisico)

            If activoDB.EstadoId <> CInt(EstadoActivoFisico.Disponible) Then
                Throw New ExcepcionesdeNegocio("El activo no se encuentra disponible para ser trasladado.")
            End If

            If ExisteActivo(detalle, activo.ActivoFisicoId) Then
                Throw New ExcepcionesdeNegocio("Este activo ya fue agregado al traslado.")
            End If

            detalle.Add(activo)
        End Using
    End Sub

    Public Sub EditarDestino(detalle As List(Of DetalleTrasladoDTO), activoFisicoId As Integer, nuevaUbicacion As Integer)
        If detalle Is Nothing Then
            Throw New ExcepcionesdeNegocio("No existe un detalle para procesar.")
        End If

        Dim activo = ObtenerDetalle(detalle, activoFisicoId)
        Dim ubicacionServicios As New UbicacionServicios()
        ubicacionServicios.ValidarEstadoUbicacion(nuevaUbicacion)

        If activo.UbicacionActualId = nuevaUbicacion Then
            Throw New ExcepcionesdeNegocio("La ubicación destino debe ser distinta a la ubicación actual.")
        End If

        activo.UbicacionFinalId = nuevaUbicacion
    End Sub

    Private Sub ValidarTraslado(traslado As Traslado, detalle As List(Of DetalleTrasladoDTO))
        If traslado Is Nothing Then
            Throw New ExcepcionesdeNegocio("La información del traslado es inválida.")
        End If

        If detalle Is Nothing OrElse detalle.Count = 0 Then
            Throw New ExcepcionesdeNegocio("Debe agregar al menos un activo al traslado.")
        End If

        If String.IsNullOrWhiteSpace(traslado.RazonTraslado) Then
            Throw New ExcepcionesdeNegocio("Debe indicar el motivo del traslado.")
        End If

        traslado.RazonTraslado = traslado.RazonTraslado.Trim()

        If traslado.RazonTraslado.Length > 300 Then
            Throw New ExcepcionesdeNegocio("El motivo del traslado no puede exceder los 300 caracteres.")
        End If

        If traslado.AutorizadoPorId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar quién autoriza el traslado.")
        End If

        If Not [Enum].IsDefined(GetType(TipoDocAutorizacion), traslado.DocAutorizacion) Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un documento de autorización.")
        End If

        If String.IsNullOrWhiteSpace(traslado.NoDocAutorizacion) Then
            Throw New ExcepcionesdeNegocio("Debe indicar el número del documento de autorización.")
        End If

        traslado.NoDocAutorizacion = traslado.NoDocAutorizacion.Trim()
    End Sub

    Public Sub RegistrarTraslado(traslado As Traslado, detalle As List(Of DetalleTrasladoDTO))
        If detalle Is Nothing OrElse detalle.Count = 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar al menos un activo")
        End If

        Using ctx As New AppDbContext()
            Using transaccion = ctx.Database.BeginTransaction()
                Try
                    ValidarTraslado(traslado, detalle)
                    traslado.FechaTraslado = DateTime.Now
                    traslado.UsuarioRegistroId = SesionActual.Usuario.IdUsuario

                    Dim repoTraslado As New RepositorioGenerico(Of Traslado)(ctx)
                    Dim repoDetalle As New RepositorioGenerico(Of DetalleTraslado)(ctx)
                    Dim repoActivoFisico As New RepositorioGenerico(Of ActivoFisico)(ctx)
                    Dim ubicacionServicios As New UbicacionServicios()

                    repoTraslado.Agregar(traslado)

                    For Each item In detalle
                        ubicacionServicios.ValidarEstadoUbicacion(item.UbicacionFinalId)

                        If item.UbicacionActualId = item.UbicacionFinalId Then
                            Throw New ExcepcionesdeNegocio($"El activo '{item.CodigoEtiqueta}' ya se encuentra en esa ubicación.")
                        End If

                        Dim activo = repoActivoFisico.ObtenerPorId(item.ActivoFisicoId)
                        If activo Is Nothing Then
                            Throw New ExcepcionesdeNegocio("El activo físico no existe.")
                        End If

                        If activo.EstadoId <> CInt(EstadoActivoFisico.Disponible) Then
                            Throw New ExcepcionesdeNegocio($"El activo '{activo.CodEtiquetaQR}' ya no está disponible para traslado.")
                        End If

                        Dim detObj As New DetalleTraslado With {
                            .TrasladoId = traslado.IdTraslado,
                            .ActivoFisicoId = item.ActivoFisicoId,
                            .UbicacionActualId = item.UbicacionActualId,
                            .UbicacionFinalId = item.UbicacionFinalId
                        }
                        repoDetalle.Agregar(detObj)

                        activo.UbicacionId = item.UbicacionFinalId
                        repoActivoFisico.Actualizar(activo)
                    Next

                    Dim valoresNuevos = $"FechaTraslado: {traslado.FechaTraslado}, Autorizado Por: {traslado.AutorizadoPor}, Documento de Autorizacion{traslado.DocAutorizacion}"

                    Dim auditoriaServicios As New AuditoriaServicios()
                    auditoriaServicios.Registrar("Traslado", traslado.IdTraslado, TipoAccionAuditoria.Crear, "", valoresNuevos)

                    transaccion.Commit()
                Catch ex As Exception
                    transaccion.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Public Function CrearDetalleDesdeActivo(codigo As String) As DetalleTrasladoDTO
        Dim activoServicios As New ActivoFisicoServicios()
        Dim activo = activoServicios.ObtenerDtoPorEtiqueta(codigo)

        If activo Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe.")
        End If

        If activo.EstadoId <> CInt(EstadoActivoFisico.Disponible) Then
            Throw New ExcepcionesdeNegocio("El activo no se encuentra disponible para traslado.")
        End If

        Return New DetalleTrasladoDTO With {
            .ActivoFisicoId = activo.IdActivoFisico,
            .CodigoEtiqueta = activo.CodEtiquetaQR,
            .NombreActivo = activo.Activo,
            .CategoriaId = activo.SubCategoriaId,
            .Categoria = activo.SubCategoria,
            .MarcaId = activo.MarcaId,
            .Marca = activo.Marca,
            .NumSerie = activo.NumSerie,
            .UbicacionActualId = activo.UbicacionId,
            .UbicacionActual = activo.Ubicacion
        }
    End Function

    Public Function ObtenerUbicacionesDestino() As List(Of Ubicacion)
        Dim ubicacionServicios As New UbicacionServicios()
        Return ubicacionServicios.ObtenerTodo().
                Where(Function(u) u.EstadoId = CInt(EstadoGenerico.Activo)).
                OrderBy(Function(u) u.Nombre).
                ToList()
    End Function

    Public Sub EliminarDetalle(detalle As List(Of DetalleTrasladoDTO), activoFisicoId As Integer)
        If detalle Is Nothing Then
            Throw New ExcepcionesdeNegocio("No existen activos para eliminar.")
        End If

        Dim activo = detalle.FirstOrDefault(Function(a) a.ActivoFisicoId = activoFisicoId)
        If activo Is Nothing Then
            Throw New ExcepcionesdeNegocio("El activo no existe en el detalle.")
        End If
        detalle.Remove(activo)
    End Sub

End Class
