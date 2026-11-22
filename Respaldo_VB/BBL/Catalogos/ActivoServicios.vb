Imports DAO
Imports MODELOS
Imports Microsoft.EntityFrameworkCore

Public Class ActivoServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of Activo)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Activo)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(idactivo As Integer) As Activo
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Activo)(ctx)
            Dim activo = repo.ObtenerPorId(idactivo)
            If activo Is Nothing Then
                Throw New ExcepcionesdeNegocio("Esta categoria no se encuentra registrada")
            End If
            Return activo
        End Using
    End Function

    Public Function ObtenerPorNombre(nombre As String) As Activo
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ExcepcionesdeNegocio("El campo no puede estar vacio")
        End If

        nombre = nombre.Trim().ToLower()
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Activo)(ctx)
            Dim activo = repo.Consultar().
                FirstOrDefault(Function(a) a.Nombre.ToLower() = nombre)

            If activo Is Nothing Then
                Throw New ExcepcionesdeNegocio("El activo no existe o esta mal escrito")
            End If
            Return activo
        End Using
    End Function

    Public Function Listar() As List(Of ActivoDTO)
        Using ctx As New AppDbContext()
            Return ctx.Activo.
                Include(Function(a) a.SubCategoria).
                Include(Function(a) a.SubCategoria).
                    ThenInclude(Function(sc) sc.Categoria).
                Include(Function(a) a.Proveedor).
                Include(Function(a) a.Marca).
                Include(Function(a) a.Estado).
                Include(Function(a) a.PersonalEncargado).
                Select(Function(a) New ActivoDTO With {
                    .IdActivo = a.IdActivo,
                    .Nombre = a.Nombre,
                    .CategoriaId = a.SubCategoria.CategoriaId,
                    .Categoria = a.SubCategoria.Categoria.Nombre,
                    .SubCategoriaId = a.SubCategoriaId,
                    .SubCategoria = a.SubCategoria.Nombre,
                    .MarcaId = a.MarcaId,
                    .Marca = a.Marca.Nombre,
                    .ProveedorId = a.ProveedorId,
                    .Proveedor = a.Proveedor.Nombre,
                    .EstadoId = a.EstadoId,
                    .Estado = a.Estado.Nombre,
                    .PersonalId = a.PersonalEncargadoId,
                    .PersonalEncargado = a.PersonalEncargado.Nombre,
                    .Descripcion = a.Descripcion
                }).ToList()
        End Using
    End Function

    Public Sub ValidarEstadoActivo(idactivo As Integer)

        Dim activo = ObtenerPorId(idactivo)

        Using ctx As New AppDbContext()
            Dim estadoServicios As New EstadoServicios()
            estadoServicios.ValidarEstado(activo.EstadoId, TipoEstadoEnum.EstadoGenerico)
        End Using

        If activo.EstadoId <> CInt(EstadoGenerico.Activo) Then
            Throw New ExcepcionesdeNegocio("Este activo esta inactivo")
        End If

    End Sub

    Private Sub Normalizar(activo As Activo)
        activo.Nombre = If(activo.Nombre, "").Trim()
    End Sub

    Private Sub Validar(nombre As String)

        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ExcepcionesdeNegocio("El nombre es un campo Obligatorio")
        End If

        If nombre.Length < 3 AndAlso nombre.Length > 50 Then
            Throw New ExcepcionesdeNegocio("El nombre no puede tener un tamaño entre 3 y 50 carateres")
        End If


    End Sub

    Private Function ExisteNombreActivo(ctx As AppDbContext, nombreActivo As String) As Boolean
        nombreActivo = nombreActivo.Trim().ToLower()
        Dim _repo As New RepositorioGenerico(Of Activo)(ctx)
        Return _repo.Consultar.Any(Function(activo) activo.Nombre.ToLower() = nombreActivo)
    End Function

    Private Function ExisteNombreActivo(ctx As AppDbContext, nombreActivo As String, idactivo As Integer) As Boolean
        nombreActivo = nombreActivo.Trim().ToLower()
        Dim _repo As New RepositorioGenerico(Of Activo)(ctx)
        Return _repo.Consultar.Any(Function(activo) activo.Nombre.ToLower() = nombreActivo AndAlso activo.IdActivo <> idactivo)
    End Function


    Public Sub Agregar(activo As Activo)

        If activo Is Nothing Then
            Throw New ArgumentNullException(NameOf(activo))
        End If

        Normalizar(activo)
        Validar(activo.Nombre)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Activo)(ctx)

            If ExisteNombreActivo(ctx, activo.Nombre) Then
                Throw New ExcepcionesdeNegocio("Ya existe un activo con ese nombre")
            End If

            Dim estadoServicios As New EstadoServicios()
            Dim subCatServicios As New SubCategoriaServicios()
            Dim personalServicios As New PersonalServicios()
            Dim marcaServicios As New MarcaServicios()
            Dim catServicios As New CategoriaServicios()

            estadoServicios.ValidarEstado(activo.EstadoId, TipoEstadoEnum.EstadoGenerico)
            subCatServicios.ValidarEstadoSubCategoria(activo.SubCategoriaId)
            personalServicios.ValidarEstadoPersonal(activo.PersonalEncargadoId)
            marcaServicios.ValidarEstadoMarca(activo.MarcaId)

            If activo.EstadoId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un estado para el activo")
            End If

            Dim subcategoria = subCatServicios.ObtenerPorId(activo.SubCategoriaId)
            Dim categoria = catServicios.ObtenerPorId(subcategoria.CategoriaId)

            If categoria.IdCategoria <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir una categoria para el activo")
            End If

            If activo.SubCategoriaId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir una Sub-categoria para el activo")
            End If

            If activo.ProveedorId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un proveedor para el activo")
            End If

            If activo.MarcaId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir una marca para el activo")
            End If

            activo.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            activo.FechaRegistro = DateTime.Now

            repo.Agregar(activo)

            Dim valoresNuevos As String = $"Nombre: {activo.Nombre}, Descripcion: {activo.Descripcion}, Categoria: {activo.SubCategoriaId}, Marca: {activo.MarcaId}, Estado: {activo.EstadoId}"
            Dim auditoriaServicios As New AuditoriaServicios()
            auditoriaServicios.Registrar("Activo", activo.IdActivo, TipoAccionAuditoria.Crear, "", valoresNuevos)
        End Using

    End Sub

    Public Sub Actualizar(activo As Activo)

        If activo Is Nothing Then
            Throw New ArgumentNullException(NameOf(activo))
        End If

        Normalizar(activo)
        Validar(activo.Nombre)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Activo)(ctx)

            If ExisteNombreActivo(ctx, activo.Nombre, activo.IdActivo) Then
                Throw New ExcepcionesdeNegocio("Ya existe un activo con ese nombre")
            End If

            Dim estadoServicios As New EstadoServicios()
            Dim subCatServicios As New SubCategoriaServicios()
            Dim personalServicios As New PersonalServicios()
            Dim marcaServicios As New MarcaServicios()

            estadoServicios.ValidarEstado(activo.EstadoId, TipoEstadoEnum.EstadoGenerico)
            subCatServicios.ValidarEstadoSubCategoria(activo.SubCategoriaId)
            personalServicios.ValidarEstadoPersonal(activo.PersonalEncargadoId)
            marcaServicios.ValidarEstadoMarca(activo.MarcaId)

            Dim activoDB = repo.ObtenerPorId(activo.IdActivo)
            If activoDB Is Nothing Then
                Throw New ExcepcionesdeNegocio("El activo no se encuentra registrado")
            End If

            activo.UsuarioRegistroId = activoDB.UsuarioRegistroId
            activo.FechaRegistro = activoDB.FechaRegistro
            Dim valoresAnteriores As String = $"Nombre: {activoDB.Nombre}, Descripcion: {activoDB.Descripcion}, Categoria: {activoDB.SubCategoriaId}, Marca: {activoDB.MarcaId}, Estado: {activoDB.EstadoId}"

            activo.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            activo.FechaActualizacion = DateTime.Now

            repo.Actualizar(activo)

            Dim valoresNuevos As String = $"Nombre: {activo.Nombre}, Descripcion: {activo.Descripcion}, Categoria: {activo.SubCategoriaId}, Marca: {activo.MarcaId}, Estado: {activo.EstadoId}"
            Dim auditoriaServicios As New AuditoriaServicios()
            auditoriaServicios.Registrar("Activo", activo.IdActivo, TipoAccionAuditoria.Actualizar, valoresAnteriores, valoresNuevos)
        End Using

    End Sub

    Public Sub CambiarEstado(idactivo As Integer, nuevoestado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Activo)(ctx)
            Dim activo = repo.ObtenerPorId(idactivo)

            If activo Is Nothing Then
                Throw New ExcepcionesdeNegocio("El activo no se encuentra registrado")
            End If

            Dim valoresAntiguos = activo.EstadoId.ToString()
            Dim estadoServicios As New EstadoServicios()
            estadoServicios.ValidarEstado(nuevoestado, TipoEstadoEnum.EstadoGenerico)

            If activo.EstadoId = nuevoestado Then
                Throw New ExcepcionesdeNegocio("El activo ya posee este estado.")
            End If

            activo.EstadoId = nuevoestado
            activo.FechaActualizacion = DateTime.Now

            repo.Actualizar(activo)
            Dim valoresNuevos = nuevoestado.ToString()

            Dim auditoriaServicios As New AuditoriaServicios()
            auditoriaServicios.Registrar("Activo", activo.IdActivo, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of ActivoDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function
End Class
