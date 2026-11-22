Imports DAO
Imports MODELOS
Imports Microsoft.EntityFrameworkCore

Public Class EdificioServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of Edificio)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Edificio)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(id As Integer) As Edificio
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Edificio)(ctx)
            Dim edificio = repo.ObtenerPorId(id)
            If edificio Is Nothing Then
                Throw New ExcepcionesdeNegocio("El edificio no existe.")
            End If
            Return edificio
        End Using
    End Function

    Public Function Listar() As List(Of EdificioDTO)
        Using ctx As New AppDbContext()
            Return ctx.Edificio.
                Include(Function(e) e.Estado).
                Select(Function(e) New EdificioDTO With {
                    .IdEdificio = e.IdEdificio,
                    .Nombre = e.Nombre,
                    .CodEdificio = e.CodEdificio,
                    .CantidadPisos = e.CantidadPisos,
                    .FechaConstruccion = e.FechaConstruccion,
                    .Descripcion = e.Descripcion,
                    .EstadoId = e.EstadoId,
                    .Estado = e.Estado.Nombre
                }).ToList()
        End Using
    End Function

    Private Sub Validar(edificio As Edificio)
        If String.IsNullOrWhiteSpace(edificio.Nombre) Then
            Throw New ExcepcionesdeNegocio("Debe escribir el nombre del edificio.")
        End If

        If String.IsNullOrWhiteSpace(edificio.CodEdificio) Then
            Throw New ExcepcionesdeNegocio("El código del edificio es obligatorio.")
        End If

        If edificio.CodEdificio.Length > 15 Then
            Throw New ExcepcionesdeNegocio("El código no puede exceder los 15 caracteres.")
        End If

        If edificio.CantidadPisos <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe especificar la cantidad de pisos y este debe ser mayor a 0")
        End If

        If edificio.EstadoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un estado para el edificio")
        End If

        If edificio.Descripcion IsNot Nothing AndAlso edificio.Descripcion.Length > 300 Then
            Throw New ExcepcionesdeNegocio("La descripción no puede exceder los 300 caracteres.")
        End If
    End Sub

    Private Sub Normalizar(edificio As Edificio)
        edificio.Nombre = If(edificio.Nombre, "").Trim()
        edificio.CodEdificio = If(edificio.CodEdificio, "").Trim()
        ' Nota: CantidadPisos es un tipo numérico (ej. Integer), no requiere .Trim()
        edificio.Descripcion = If(edificio.Descripcion, "").Trim()
    End Sub

    Private Function ExisteCodigo(ctx As AppDbContext, codigo As String, id As Integer) As Boolean
        codigo = codigo.Trim().ToUpper()
        Dim repo As New RepositorioGenerico(Of Edificio)(ctx)
        Return repo.Consultar().Any(Function(e) e.CodEdificio.ToUpper() = codigo AndAlso e.IdEdificio <> id)
    End Function

    Public Sub Agregar(edificio As Edificio)
        If edificio Is Nothing Then
            Throw New ArgumentNullException(NameOf(edificio))
        End If

        Normalizar(edificio)
        Validar(edificio)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Edificio)(ctx)

            If ExisteCodigo(ctx, edificio.CodEdificio, 0) Then
                Throw New ExcepcionesdeNegocio("Ya existe un edificio con este código.")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(edificio.EstadoId, TipoEstadoEnum.EstadoGenerico)

            edificio.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            edificio.FechaRegistro = DateTime.Now

            repo.Agregar(edificio)

            Dim valoresNuevos = $"Nombre:{edificio.Nombre}, CodEdificio:{edificio.CodEdificio}, Cantidad de Pisos:{edificio.CantidadPisos}, Descripcion:{edificio.Descripcion}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Edificio", edificio.IdEdificio, TipoAccionAuditoria.Crear, "", valoresNuevos)
        End Using
    End Sub

    Public Sub Actualizar(edificio As Edificio)
        If edificio Is Nothing Then
            Throw New ArgumentNullException(NameOf(edificio))
        End If

        Normalizar(edificio)
        Validar(edificio)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Edificio)(ctx)

            If ExisteCodigo(ctx, edificio.CodEdificio, edificio.IdEdificio) Then
                Throw New ExcepcionesdeNegocio("Ya existe otro edificio con este código.")
            End If

            Dim edificioDB = repo.ObtenerPorId(edificio.IdEdificio)
            If edificioDB Is Nothing Then
                Throw New ExcepcionesdeNegocio("El edificio no existe.")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(edificio.EstadoId, TipoEstadoEnum.EstadoGenerico)

            Dim valoresAntiguos = $"Nombre:{edificioDB.Nombre}, CodEdificio:{edificioDB.CodEdificio}, Cantidad de Pisos:{edificioDB.CantidadPisos}, Descripcion:{edificioDB.Descripcion}"

            edificio.FechaRegistro = edificioDB.FechaRegistro
            edificio.UsuarioRegistroId = edificioDB.UsuarioRegistroId
            edificio.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            edificio.FechaActualizacion = DateTime.Now

            repo.Actualizar(edificio)

            Dim valoresNuevos = $"Nombre:{edificio.Nombre}, CodEdificio:{edificio.CodEdificio}, Cantidad de Pisos:{edificio.CantidadPisos}, Descripcion:{edificio.Descripcion}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Edificio", edificio.IdEdificio, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Sub CambiarEstado(id As Integer, nuevoEstado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Edificio)(ctx)
            Dim edificio = repo.ObtenerPorId(id)
            If edificio Is Nothing Then
                Throw New ExcepcionesdeNegocio("El edificio no existe.")
            End If

            Dim valoresAntiguos = edificio.EstadoId.ToString()

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoEstado, TipoEstadoEnum.EstadoGenerico)

            If edificio.EstadoId = nuevoEstado Then
                Throw New ExcepcionesdeNegocio("El edificio ya posee ese estado.")
            End If

            edificio.EstadoId = nuevoEstado
            edificio.FechaActualizacion = DateTime.Now

            repo.Actualizar(edificio)

            Dim valoresNuevos = edificio.EstadoId.ToString()
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Edificio", edificio.IdEdificio, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of EdificioDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower()) OrElse e.CodEdificio.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class
