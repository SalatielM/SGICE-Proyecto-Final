Imports DAO
Imports MODELOS
Imports Microsoft.EntityFrameworkCore

Public Class CategoriaServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of Categoria)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Categoria)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(idcategoria As Integer) As Categoria
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Categoria)(ctx)
            Dim categoria = repo.ObtenerPorId(idcategoria)

            If categoria Is Nothing Then
                Throw New ExcepcionesdeNegocio("Esta categoria no se encuentra registrada")
            End If
            Return categoria
        End Using
    End Function

    Public Function ObtenerPorNombre(nombre As String) As Categoria
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ExcepcionesdeNegocio("El campo no puede estar vacio")
        End If

        nombre = nombre.Trim().ToLower()

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Categoria)(ctx)
            Dim categoria = repo.Consultar().
                FirstOrDefault(Function(a) a.Nombre.ToLower() = nombre)

            If categoria Is Nothing Then
                Throw New ExcepcionesdeNegocio("La categoria no existe o esta mal escrita")
            End If
            Return categoria
        End Using
    End Function

    Public Function Listar() As List(Of CategoriaDTO)
        Using ctx As New AppDbContext()
            Return ctx.Categoria.
                Include(Function(c) c.Estado).
                Select(Function(c) New CategoriaDTO With {
                .IdCategoria = c.IdCategoria,
                .Nombre = c.Nombre,
                .VidaUtil = c.VidaUtil,
                .Descripcion = c.Descripcion,
                .EstadoId = c.EstadoId,
                .Estado = c.Estado.Nombre
                }).ToList()
        End Using
    End Function

    Public Sub ValidarEstadoCategoria(idcategoria As Integer)
        Dim categoria = ObtenerPorId(idcategoria)

        Using ctx As New AppDbContext()
            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(categoria.EstadoId, TipoEstadoEnum.EstadoGenerico)
        End Using

        If categoria.EstadoId <> CInt(EstadoGenerico.Activo) Then
            Throw New ExcepcionesdeNegocio("Esta categoria esta inactiva")
        End If
    End Sub

    Private Function Existe(ctx As AppDbContext, nombre As String) As Boolean
        nombre = nombre.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Categoria)(ctx)
        Return repo.Consultar().
            Any(Function(categoria) categoria.Nombre.ToLower() = nombre)
    End Function

    Private Function Existe(ctx As AppDbContext, nombre As String, idcategoria As Integer) As Boolean
        nombre = nombre.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Categoria)(ctx)
        Return repo.Consultar().
            Any(Function(categoria) categoria.Nombre.ToLower() = nombre AndAlso categoria.IdCategoria <> idcategoria)
    End Function

    Private Sub Validar(categoria As Categoria)
        If String.IsNullOrWhiteSpace(categoria.Nombre) Then
            Throw New ExcepcionesdeNegocio("Es obligatorio colocar el nombre de la categoria")
        End If

        If categoria.Nombre.Length < 3 Then
            Throw New ExcepcionesdeNegocio("El nombre de la categoria es demasiado corto")
        End If

        If categoria.Nombre.Length > 50 Then
            Throw New ExcepcionesdeNegocio("El nombre de la categoria es demasiado largo")
        End If
    End Sub

    Private Sub Normalizar(categoria As Categoria)
        categoria.Nombre = If(categoria.Nombre, "").Trim()
        categoria.Descripcion = If(categoria.Descripcion, "").Trim()
    End Sub

    Public Sub CambiarEstado(idcategoria As Integer, nuevoestado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Categoria)(ctx)
            Dim categoria = repo.ObtenerPorId(idcategoria)
            If categoria Is Nothing Then
                Throw New ExcepcionesdeNegocio("Esta categoria no se encuentra registrada")
            End If

            Dim valoresAntiguos = categoria.EstadoId.ToString()

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoestado, TipoEstadoEnum.EstadoGenerico)

            If categoria.EstadoId = nuevoestado Then
                Throw New ExcepcionesdeNegocio("La categoria ya posee este estado.")
            End If

            categoria.EstadoId = nuevoestado
            categoria.FechaActualizacion = DateTime.Now

            repo.Actualizar(categoria)

            Dim valoresNuevos = categoria.EstadoId.ToString()
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Categoria", categoria.IdCategoria, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Sub Agregar(categoria As Categoria)
        If categoria Is Nothing Then
            Throw New ArgumentNullException(NameOf(categoria))
        End If

        Normalizar(categoria)
        Validar(categoria)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Categoria)(ctx)

            If Existe(ctx, categoria.Nombre) Then
                Throw New ExcepcionesdeNegocio("Ya existe una categoria con ese nombre")
            End If

            If categoria.EstadoId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un estado para la categoria")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(categoria.EstadoId, TipoEstadoEnum.EstadoGenerico)

            categoria.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            categoria.FechaRegistro = DateTime.Now

            repo.Agregar(categoria)

            Dim valoresNuevos As String = $"Nombre: {categoria.Nombre}, Descripcion: {categoria.Descripcion}, Estado: {categoria.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Categoria", categoria.IdCategoria, TipoAccionAuditoria.Crear, "", valoresNuevos)
        End Using
    End Sub

    Public Sub Actualizar(categoria As Categoria)
        If categoria Is Nothing Then
            Throw New ArgumentNullException(NameOf(categoria))
        End If

        Normalizar(categoria)
        Validar(categoria)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Categoria)(ctx)

            Dim categoriaExiste = repo.ObtenerPorId(categoria.IdCategoria)
            If categoriaExiste Is Nothing Then
                Throw New ExcepcionesdeNegocio("La categoria que desea actualizar no existe")
            End If

            If Existe(ctx, categoria.Nombre, categoria.IdCategoria) Then
                Throw New ExcepcionesdeNegocio("Ya existe una categoria con ese nombre")
            End If

            If categoria.EstadoId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un estado para la categoria")
            End If

            If categoria.VidaUtil Is Nothing Then
                Throw New ExcepcionesdeNegocio("Debe especificar la vida util de la categoria")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(categoria.EstadoId, TipoEstadoEnum.EstadoGenerico)

            categoria.UsuarioRegistroId = categoriaExiste.UsuarioRegistroId
            categoria.FechaRegistro = categoriaExiste.FechaRegistro
            categoria.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            categoria.FechaActualizacion = DateTime.Now

            Dim valoresAnteriores As String = $"Nombre: {categoriaExiste.Nombre}, Descripcion: {categoriaExiste.Descripcion}, Estado: {categoriaExiste.EstadoId}"
            Dim valoresNuevos As String = $"Nombre: {categoria.Nombre}, Descripcion: {categoria.Descripcion}, Estado: {categoria.EstadoId}"

            repo.Actualizar(categoria)

            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Categoria", categoria.IdCategoria, TipoAccionAuditoria.Actualizar, valoresAnteriores, valoresNuevos)
        End Using
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of CategoriaDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class