Imports DAO
Imports MODELOS
Imports Microsoft.EntityFrameworkCore

Public Class SubCategoriaServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of SubCategoria)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of SubCategoria)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(id As Integer) As SubCategoria
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of SubCategoria)(ctx)
            Dim subcategoria = repo.ObtenerPorId(id)
            If subcategoria Is Nothing Then
                Throw New ExcepcionesdeNegocio("La subcategoría no existe.")
            End If
            Return subcategoria
        End Using
    End Function

    Public Function ObtenerPorCategorias(categoriaId As Integer) As List(Of SubCategoria)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of SubCategoria)(ctx)
            Return repo.Consultar().
                Where(Function(s) s.CategoriaId = categoriaId).ToList()
        End Using
    End Function

    Public Function Listar() As List(Of SubCategoriaDTO)
        Using ctx As New AppDbContext()
            Return ctx.SubCategoria.
                Include(Function(s) s.Estado).
                Include(Function(s) s.Categoria).
                Select(Function(s) New SubCategoriaDTO With {
                    .IdSubCategoria = s.IdSubCategoria,
                    .CategoriaId = s.CategoriaId,
                    .Categoria = s.Categoria.Nombre,
                    .Nombre = s.Nombre,
                    .Descripcion = s.Descripcion,
                    .VidaUtil = s.VidaUtil,
                    .FechaCreacion = s.FechaCreacion,
                    .EstadoId = s.EstadoId,
                    .Estado = s.Estado.Nombre
                }).ToList()
        End Using
    End Function

    Public Sub ValidarEstadoSubCategoria(idsubcategoria As Integer)
        Dim subcategoria = ObtenerPorId(idsubcategoria)

        Using ctx As New AppDbContext()
            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(subcategoria.EstadoId, TipoEstadoEnum.EstadoGenerico)
        End Using

        If subcategoria.EstadoId <> CInt(EstadoGenerico.Activo) Then
            Throw New ExcepcionesdeNegocio("Esta sub-categoria esta inactiva")
        End If
    End Sub

    Private Sub Validar(ctx As AppDbContext, subcategoria As SubCategoria)
        If subcategoria.CategoriaId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar una categoria para la sub-categoria")
        End If

        If String.IsNullOrWhiteSpace(subcategoria.Nombre) Then
            Throw New ExcepcionesdeNegocio("Debe escribir el nombre de la subcategoría.")
        End If

        If subcategoria.Nombre.Length < 3 OrElse subcategoria.Nombre.Length > 50 Then
            Throw New ExcepcionesdeNegocio("El nombre debe tener entre 3 y 50 caracteres.")
        End If

        If subcategoria.EstadoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar una estado para la sub categoria")
        End If

        If subcategoria.Descripcion IsNot Nothing AndAlso subcategoria.Descripcion.Length > 300 Then
            Throw New ExcepcionesdeNegocio("La descripción no puede exceder los 300 caracteres.")
        End If

        If subcategoria.VidaUtil <= 0 Then
            Throw New ExcepcionesdeNegocio("El tiempo de vida util debe ser mayor a 0.")
        End If

        Dim categoriservicios As New CategoriaServicios()
        Dim categoria = categoriservicios.ObtenerPorId(subcategoria.CategoriaId)

        If subcategoria.VidaUtil > categoria.VidaUtil Then
            Throw New ExcepcionesdeNegocio("La vida util de la subcategoria no puede ser mayor a la de la categoria")
        End If
    End Sub

    Private Sub Normalizar(subcategoria As SubCategoria)
        subcategoria.Nombre = If(subcategoria.Nombre, "").Trim()
        subcategoria.Descripcion = If(subcategoria.Descripcion, "").Trim()
    End Sub

    Private Function ExisteNombre(ctx As AppDbContext, nombre As String, id As Integer) As Boolean
        nombre = nombre.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of SubCategoria)(ctx)
        Return repo.Consultar().Any(Function(s) s.Nombre.ToLower() = nombre AndAlso s.IdSubCategoria <> id)
    End Function

    Public Sub Agregar(subcategoria As SubCategoria)
        If subcategoria Is Nothing Then
            Throw New ArgumentNullException(NameOf(subcategoria))
        End If

        Normalizar(subcategoria)

        Using ctx As New AppDbContext()
            Validar(ctx, subcategoria)

            If ExisteNombre(ctx, subcategoria.Nombre, 0) Then
                Throw New ExcepcionesdeNegocio("Ya existe una subcategoría con este nombre.")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(subcategoria.EstadoId, TipoEstadoEnum.EstadoGenerico)

            subcategoria.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            subcategoria.FechaCreacion = DateTime.Now

            Dim repo As New RepositorioGenerico(Of SubCategoria)(ctx)
            repo.Agregar(subcategoria)

            Dim valoresNuevos = $"Nombre: {subcategoria.Nombre}, Descripcion: {subcategoria.Descripcion}, Vida Util: {subcategoria.VidaUtil}, Categoria: {subcategoria.CategoriaId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("SubCategoria", subcategoria.IdSubCategoria, TipoAccionAuditoria.Crear, "", valoresNuevos)
        End Using
    End Sub

    Public Sub Actualizar(subcategoria As SubCategoria)
        If subcategoria Is Nothing Then
            Throw New ArgumentNullException(NameOf(subcategoria))
        End If

        Normalizar(subcategoria)

        Using ctx As New AppDbContext()
            Validar(ctx, subcategoria)

            If ExisteNombre(ctx, subcategoria.Nombre, subcategoria.IdSubCategoria) Then
                Throw New ExcepcionesdeNegocio("Ya existe otra subcategoría con este nombre.")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(subcategoria.EstadoId, TipoEstadoEnum.EstadoGenerico)

            Dim repo As New RepositorioGenerico(Of SubCategoria)(ctx)
            Dim subcategoriaDB = repo.ObtenerPorId(subcategoria.IdSubCategoria)
            If subcategoriaDB Is Nothing Then
                Throw New ExcepcionesdeNegocio("La subcategoría no existe.")
            End If

            Dim valoresAntiguos = $"Nombre: {subcategoriaDB.Nombre}, Descripcion: {subcategoriaDB.Descripcion}, Vida Util: {subcategoriaDB.VidaUtil}, Categoria: {subcategoriaDB.CategoriaId}"

            subcategoria.FechaCreacion = subcategoriaDB.FechaCreacion
            subcategoria.UsuarioRegistroId = subcategoriaDB.UsuarioRegistroId
            subcategoria.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            subcategoria.FechaActualizacion = DateTime.Now

            repo.Actualizar(subcategoria)

            Dim valoresNuevos = $"Nombre: {subcategoria.Nombre}, Descripcion: {subcategoria.Descripcion}, Vida Util: {subcategoria.VidaUtil}, Categoria: {subcategoria.CategoriaId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("SubCategoria", subcategoria.IdSubCategoria, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Sub CambiarEstado(id As Integer, nuevoEstado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of SubCategoria)(ctx)
            Dim subcategoria = repo.ObtenerPorId(id)
            If subcategoria Is Nothing Then
                Throw New ExcepcionesdeNegocio("La subcategoría no existe.")
            End If

            Dim valoresAntiguos = subcategoria.EstadoId.ToString()

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoEstado, TipoEstadoEnum.EstadoGenerico)

            If subcategoria.EstadoId = nuevoEstado Then
                Throw New ExcepcionesdeNegocio("La subcategoría ya posee ese estado.")
            End If

            subcategoria.EstadoId = nuevoEstado
            subcategoria.FechaActualizacion = DateTime.Now

            repo.Actualizar(subcategoria)

            Dim valoresNuevos = subcategoria.EstadoId.ToString()
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("SubCategoria", subcategoria.IdSubCategoria, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of SubCategoriaDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class
