Imports DAO
Imports MODELOS
Imports System.IO
Imports Microsoft.EntityFrameworkCore


Public Class MarcaServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodo() As List(Of Marca)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Marca)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(idmarca As Integer) As Marca
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Marca)(ctx)
            Dim marca = repo.ObtenerPorId(idmarca)
            If marca Is Nothing Then
                Throw New ExcepcionesdeNegocio("La marca que busca no existe")
            End If
            Return marca
        End Using
    End Function

    Public Function Listar() As List(Of MarcaDTO)
        Using ctx As New AppDbContext()
            Return ctx.Marca.
                Include(Function(m) m.Estado).
                Select(Function(m) New MarcaDTO With {
                .IdMarca = m.IdMarca,
                .Nombre = m.Nombre,
                .Descripcion = m.Descripcion,
                .EstadoId = m.EstadoId,
                .Estado = m.Estado.Nombre
                }).ToList()
        End Using
    End Function

    Public Sub ValidarEstadoMarca(idmarca As Integer)
        Dim marca = ObtenerPorId(idmarca)

        Using ctx As New AppDbContext()
            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(marca.EstadoId, TipoEstadoEnum.EstadoGenerico)
        End Using

        If marca.EstadoId <> CInt(EstadoGenerico.Activo) Then
            Throw New ExcepcionesdeNegocio("Marca inactiva")
        End If
    End Sub

    Public Sub Agregar(marca As Marca)
        If marca Is Nothing Then
            Throw New ExcepcionesdeNegocio("Debe completar todos los campos")
        End If

        Normalizar(marca)
        Validar(marca)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Marca)(ctx)

            If Existe(ctx, marca.Nombre) Then
                Throw New ExcepcionesdeNegocio("Ya existe una marca con ese nombre")
            End If

            If marca.EstadoId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un estado")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(marca.EstadoId, TipoEstadoEnum.EstadoGenerico)

            marca.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            marca.FechaCreacion = DateTime.Now

            repo.Agregar(marca)

            Dim regitroNuevos As String = $"Nombre: {marca.Nombre}, Descripcion: {marca.Descripcion}, Estado: {marca.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Marca", marca.IdMarca, TipoAccionAuditoria.Crear, "", regitroNuevos)
        End Using
    End Sub

    Public Sub Actualizar(marca As Marca)
        If marca Is Nothing Then
            Throw New ArgumentNullException(NameOf(marca))
        End If

        Normalizar(marca)
        Validar(marca)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Marca)(ctx)

            Dim marcaExiste = repo.ObtenerPorId(marca.IdMarca)
            If marcaExiste Is Nothing Then
                Throw New ExcepcionesdeNegocio("La marca que intenta actualizar no existe")
            End If

            If Existe(ctx, marca.Nombre, marca.IdMarca) Then
                Throw New ExcepcionesdeNegocio("Ya existe otra marca con ese nombre")
            End If

            If marca.EstadoId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un estado para esta marca")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(marca.EstadoId, TipoEstadoEnum.EstadoGenerico)

            marca.FechaCreacion = marcaExiste.FechaCreacion
            marca.UsuarioRegistroId = marcaExiste.UsuarioRegistroId

            Dim regitroAnteriores As String = $"Nombre: {marcaExiste.Nombre}, Descripcion: {marcaExiste.Descripcion}, Estado: {marcaExiste.EstadoId}"

            marca.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            marca.FechaActualizacon = DateTime.Now

            repo.Actualizar(marca)

            Dim regitroNuevos As String = $"Nombre: {marca.Nombre}, Descripcion: {marca.Descripcion}, Estado: {marca.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Marca", marca.IdMarca, TipoAccionAuditoria.Actualizar, regitroAnteriores, regitroNuevos)
        End Using
    End Sub

    Public Sub CambiarEstado(idmarca As Integer, nuevoestado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Marca)(ctx)
            Dim marca = repo.ObtenerPorId(idmarca)
            If marca Is Nothing Then
                Throw New ExcepcionesdeNegocio("La marca que busca no existe")
            End If

            Dim valoresAntiguos = marca.EstadoId.ToString()

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoestado, TipoEstadoEnum.EstadoGenerico)

            If marca.EstadoId = nuevoestado Then
                Throw New ExcepcionesdeNegocio("La marca ya posee ese estado")
            End If

            marca.EstadoId = nuevoestado
            marca.FechaActualizacon = DateTime.Now

            repo.Actualizar(marca)

            Dim valoresNuevos = marca.EstadoId.ToString()
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Marca", marca.IdMarca, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Private Function Existe(ctx As AppDbContext, nombre As String) As Boolean
        nombre = nombre.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Marca)(ctx)
        Return repo.Consultar().
            Any(Function(marca) marca.Nombre.ToLower() = nombre)
    End Function

    Private Function Existe(ctx As AppDbContext, nombre As String, idmarca As Integer) As Boolean
        nombre = nombre.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Marca)(ctx)
        Return repo.Consultar().
            Any(Function(marca) marca.Nombre.ToLower() = nombre AndAlso marca.IdMarca <> idmarca)
    End Function

    Private Sub Validar(marca As Marca)
        If String.IsNullOrWhiteSpace(marca.Nombre) Then
            Throw New ExcepcionesdeNegocio("Es obligatorio colocar el nombre de la marca")
        End If
    End Sub

    Private Sub Normalizar(marca As Marca)
        marca.Nombre = If(marca.Nombre, "").Trim()
        marca.Descripcion = If(marca.Descripcion, "").Trim()
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of MarcaDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class
