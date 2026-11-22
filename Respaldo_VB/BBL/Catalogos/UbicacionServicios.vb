Imports DAO
Imports Microsoft.EntityFrameworkCore
Imports MODELOS

Public Class UbicacionServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodo() As List(Of Ubicacion)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Ubicacion)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(idubicacion As Integer) As Ubicacion
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Ubicacion)(ctx)
            Dim ubicacion = repo.ObtenerPorId(idubicacion)
            If ubicacion Is Nothing Then
                Throw New ExcepcionesdeNegocio("Esta ubicacion no se encuentra registrada")
            End If
            Return ubicacion
        End Using
    End Function

    Public Function ObtenerPorNombreUbicacion(nombre As String) As Ubicacion
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ExcepcionesdeNegocio("Debe escribir el nombre de la ubicacion")
        End If

        nombre = nombre.Trim().ToLower()
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Ubicacion)(ctx)
            Dim ubicacion = repo.Consultar().
                FirstOrDefault(Function(u) u.Nombre.ToLower() = nombre)

            If ubicacion Is Nothing Then
                Throw New ExcepcionesdeNegocio("Esta ubicacion no existe")
            End If

            Return ubicacion
        End Using
    End Function

    Public Function Contar() As Integer
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Ubicacion)(ctx)
            Return repo.Consultar().Count()
        End Using
    End Function

    Public Function Listar() As List(Of UbicacionDTO)
        Using ctx As New AppDbContext()
            Return ctx.Ubicacion.
            Include(Function(u) u.Estado).
            Include(Function(u) u.Edificio).
            Select(Function(u) New UbicacionDTO With {
                    .IdUbicacion = u.IdUbicacion,
                    .Nombre = u.Nombre,
                    .Dimencion = u.Dimencion,
                    .Piso = u.Piso,
                    .EdificioId = u.EdificioId,
                    .Edificio = u.Edificio.Nombre,
                    .Descripcion = u.Descripcion,
                    .EstadoId = u.EstadoId,
                    .Estado = u.Estado.Nombre
            }).ToList()
        End Using
    End Function

    Public Sub ValidarEstadoUbicacion(idubicacion As Integer)
        Dim ubicacion = ObtenerPorId(idubicacion)

        Using ctx As New AppDbContext()
            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(ubicacion.EstadoId, TipoEstadoEnum.EstadoGenerico)
        End Using

        If ubicacion.EstadoId <> CInt(EstadoGenerico.Activo) Then
            Throw New ExcepcionesdeNegocio("Esta ubicacion se encuentra inactiva")
        End If
    End Sub

    Private Sub Normalizar(ubicacion As Ubicacion)
        ubicacion.Nombre = If(ubicacion.Nombre, "").Trim()
        ubicacion.Descripcion = If(ubicacion.Descripcion, "").Trim()
    End Sub

    Private Sub Validar(ubicacion As Ubicacion)
        If ubicacion Is Nothing Then
            Throw New ArgumentException(NameOf(ubicacion))
        End If

        ValidarNombre(ubicacion.Nombre)

        If String.IsNullOrWhiteSpace(ubicacion.Dimencion) Then
            Throw New ExcepcionesdeNegocio("Debe indicar las dimenciones de la ubicacion")
        End If

        If ubicacion.EdificioId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe indicar el edificio en el que se encuentra la ubicacion")
        End If

        If String.IsNullOrWhiteSpace(ubicacion.Piso) Then
            Throw New ExcepcionesdeNegocio("Debe indicar el piso en que se encuentra la ubicacion")
        End If

        Dim edificioservicios As New EdificioServicios
        Dim edificio = edificioservicios.ObtenerPorId(ubicacion.EdificioId)

        If ubicacion.Piso > edificio.CantidadPisos Then
            Throw New ExcepcionesdeNegocio($"El dificio seleccionado para esta ubicacion solo tiene {edificio.CantidadPisos} pisos")
        End If

        If ubicacion.EstadoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe elegir un estado para la ubicacion")
        End If


        ValidarDescripcion(ubicacion.Descripcion)
    End Sub

    Private Sub ValidarNombre(nombreubicacion As String)
        If String.IsNullOrWhiteSpace(nombreubicacion) Then
            Throw New ExcepcionesdeNegocio("Debe indicar el nombre de la ubicacion")
        End If

        If nombreubicacion.Length < 3 Then
            Throw New ExcepcionesdeNegocio("El nombre de la ubicacion es demasiado corto")
        End If

        If nombreubicacion.Length > 50 Then
            Throw New ExcepcionesdeNegocio("El nombre de la ubicacion es demasiado largo")
        End If
    End Sub

    Private Sub ValidarDescripcion(descripcion As String)
        If descripcion.Length < 5 Then
            Throw New ExcepcionesdeNegocio("La descripcion es demasiado corta")
        End If

        If descripcion.Length > 300 Then
            Throw New ExcepcionesdeNegocio("La descripcion es demasiado larga")
        End If
    End Sub

    Private Function Existe(ctx As AppDbContext, nombre As String) As Boolean
        nombre = nombre.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Ubicacion)(ctx)
        Return repo.Consultar().
            Any(Function(ubicacion) ubicacion.Nombre.ToLower() = nombre)
    End Function

    Private Function Existe(ctx As AppDbContext, nombre As String, idubicacion As Integer) As Boolean
        nombre = nombre.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Ubicacion)(ctx)
        Return repo.Consultar().
            Any(Function(ubicacion) ubicacion.Nombre.ToLower() = nombre AndAlso ubicacion.IdUbicacion <> idubicacion)
    End Function

    Public Sub CambiarEstado(idubicacion As Integer, nuevoestado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Ubicacion)(ctx)
            Dim ubicacion = repo.ObtenerPorId(idubicacion)
            If ubicacion Is Nothing Then
                Throw New ExcepcionesdeNegocio("Esta ubicacion no se encuentra registrada")
            End If

            Dim valoresAntiguos = ubicacion.EstadoId.ToString()

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoestado, TipoEstadoEnum.EstadoGenerico)

            If ubicacion.EstadoId = nuevoestado Then
                Throw New ExcepcionesdeNegocio("La ubicacion ya posee este mismo estado")
            End If

            ubicacion.EstadoId = nuevoestado
            ubicacion.FechaActualizacion = DateTime.Now

            repo.Actualizar(ubicacion)
            Dim valoresNuevos = ubicacion.EstadoId.ToString()

            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Ubicacion", ubicacion.IdUbicacion, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Sub Agregar(ubicacion As Ubicacion)
        If ubicacion Is Nothing Then
            Throw New ArgumentNullException(NameOf(ubicacion))
        End If

        Normalizar(ubicacion)
        Validar(ubicacion)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Ubicacion)(ctx)

            If Existe(ctx, ubicacion.Nombre) Then
                Throw New ExcepcionesdeNegocio("Ya existe una ubicacion con ese nombre")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(ubicacion.EstadoId, TipoEstadoEnum.EstadoGenerico)

            ubicacion.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            ubicacion.FechaCreacion = DateTime.Now

            repo.Agregar(ubicacion)

            Dim valoresNuevos As String = $"Nombre: {ubicacion.Nombre}, Capacidad: {ubicacion.Dimencion}, Descripcion: {ubicacion.Descripcion}, Estado: {ubicacion.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Ubicacion", ubicacion.IdUbicacion, TipoAccionAuditoria.Crear, "", valoresNuevos)
        End Using
    End Sub

    Public Sub Actualizar(ubicacion As Ubicacion)
        If ubicacion Is Nothing Then
            Throw New ArgumentNullException(NameOf(ubicacion))
        End If

        Normalizar(ubicacion)
        Validar(ubicacion)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Ubicacion)(ctx)

            Dim ubicacionExiste = repo.ObtenerPorId(ubicacion.IdUbicacion)
            If ubicacionExiste Is Nothing Then
                Throw New ExcepcionesdeNegocio("La ubicacion que desea actualizar no existe")
            End If

            If Existe(ctx, ubicacion.Nombre, ubicacion.IdUbicacion) Then
                Throw New ExcepcionesdeNegocio("Ya existe una ubicacion con ese nombre")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(ubicacion.EstadoId, TipoEstadoEnum.EstadoGenerico)

            ubicacion.FechaCreacion = ubicacionExiste.FechaCreacion
            ubicacion.UsuarioRegistroId = ubicacionExiste.UsuarioRegistroId
            Dim valoresAnteriores As String = $"Nombre: {ubicacionExiste.Nombre}, Capacidad: {ubicacionExiste.Dimencion}, Descripcion: {ubicacionExiste.Descripcion}, Estado: {ubicacionExiste.EstadoId}"

            ubicacion.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            ubicacion.FechaActualizacion = DateTime.Now
            Dim valoresNuevos As String = $"Nombre: {ubicacion.Nombre}, Capacidad: {ubicacion.Dimencion}, Descripcion: {ubicacion.Descripcion}, Estado: {ubicacion.EstadoId}"

            repo.Actualizar(ubicacion)

            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Ubicacion", ubicacion.IdUbicacion, TipoAccionAuditoria.Actualizar, valoresAnteriores, valoresNuevos)
        End Using
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of UbicacionDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class