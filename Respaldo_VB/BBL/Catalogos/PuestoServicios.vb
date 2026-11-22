Imports DAO
Imports MODELOS
Imports Microsoft.EntityFrameworkCore

Public Class PuestoServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of Puesto)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Puesto)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(idpuesto As Integer) As Puesto
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Puesto)(ctx)
            Dim puesto = repo.ObtenerPorId(idpuesto)
            If puesto Is Nothing Then
                Throw New ExcepcionesdeNegocio("El Puesto que busca no existe")
            End If
            Return puesto
        End Using
    End Function

    Public Function Listar() As List(Of PuestoDTO)
        Using ctx As New AppDbContext()
            Return ctx.Puesto.
                Include(Function(p) p.Estado).
                Select(Function(p) New PuestoDTO With {
                .IdPuesto = p.IdPuesto,
                .Nombre = p.Nombre,
                .Descripcion = p.Descripcion,
                .EstadoId = p.EstadoId,
                .Estado = p.Estado.Nombre
                 }).ToList()
        End Using
    End Function

    Public Sub CambiarEstado(idpuesto As Integer, nuevoestado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Puesto)(ctx)
            Dim puesto = repo.ObtenerPorId(idpuesto)
            If puesto Is Nothing Then
                Throw New ExcepcionesdeNegocio("El Puesto que busca no existe")
            End If

            Dim valoresAntiguos = puesto.EstadoId.ToString()

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoestado, TipoEstadoEnum.EstadoGenerico)

            If puesto.EstadoId = nuevoestado Then
                Throw New ExcepcionesdeNegocio("El puesto ya posee este estado.")
            End If

            puesto.EstadoId = nuevoestado
            puesto.FechaActualizacion = DateTime.Now

            repo.Actualizar(puesto)
            Dim valoresNuevos = puesto.EstadoId.ToString()

            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Puesto", puesto.IdPuesto, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Sub ValidarPuestoEstado(idpuesto As Integer)
        Dim puesto = ObtenerPorId(idpuesto)

        Using ctx As New AppDbContext()
            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(puesto.EstadoId, TipoEstadoEnum.EstadoGenerico)
        End Using

        If puesto.EstadoId <> CInt(EstadoGenerico.Activo) Then
            Throw New ExcepcionesdeNegocio("Este puesto esta inactivo")
        End If
    End Sub

    Private Function Existe(ctx As AppDbContext, nombre As String) As Boolean
        nombre = nombre.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Puesto)(ctx)
        Return repo.Consultar().
            Any(Function(puesto) puesto.Nombre.ToLower() = nombre)
    End Function

    Private Function Existe(ctx As AppDbContext, nombre As String, idpuesto As Integer) As Boolean
        nombre = nombre.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Puesto)(ctx)
        Return repo.Consultar().
            Any(Function(puesto) puesto.Nombre.ToLower() = nombre AndAlso puesto.IdPuesto <> idpuesto)
    End Function

    Private Sub Validar(puesto As Puesto)
        If String.IsNullOrWhiteSpace(puesto.Nombre) Then
            Throw New ExcepcionesdeNegocio("Es obligatorio colocar el nombre del puesto")
        End If

        If puesto.Nombre.Length < 3 Then
            Throw New ExcepcionesdeNegocio("El nombre del puesto es demasiado corto")
        End If

        If puesto.Nombre.Length > 50 Then
            Throw New ExcepcionesdeNegocio("El nombre del puesto es demasiado largo")
        End If
    End Sub

    Private Sub Normalizar(puesto As Puesto)
        puesto.Nombre = If(puesto.Nombre, "").Trim()
        puesto.Descripcion = If(puesto.Descripcion, "").Trim()
    End Sub

    Public Sub Agregar(puesto As Puesto)
        If puesto Is Nothing Then
            Throw New ArgumentNullException(NameOf(puesto))
        End If

        Normalizar(puesto)
        Validar(puesto)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Puesto)(ctx)

            If Existe(ctx, puesto.Nombre) Then
                Throw New ExcepcionesdeNegocio("Ya existe un puesto con ese nombre")
            End If

            If puesto.EstadoId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un estado")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(puesto.EstadoId, TipoEstadoEnum.EstadoGenerico)

            puesto.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            puesto.FechaCreacion = DateTime.Now

            repo.Agregar(puesto)

            Dim valoresNuevos As String = $"Nombre: {puesto.Nombre}, Descripcion: {puesto.Descripcion}, Estado: {puesto.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Puesto", puesto.IdPuesto, TipoAccionAuditoria.Crear, "", valoresNuevos)
        End Using
    End Sub

    Public Sub Actualizar(puesto As Puesto)
        If puesto Is Nothing Then
            Throw New ArgumentNullException(NameOf(puesto))
        End If

        Normalizar(puesto)
        Validar(puesto)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Puesto)(ctx)

            Dim puestoExiste = repo.ObtenerPorId(puesto.IdPuesto)
            If puestoExiste Is Nothing Then
                Throw New ExcepcionesdeNegocio("El puesto que desea actualizar no existe")
            End If

            If Existe(ctx, puesto.Nombre, puesto.IdPuesto) Then
                Throw New ExcepcionesdeNegocio("Existe otro puesto con este nombre")
            End If

            If puesto.EstadoId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un estado para el puesto")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(puesto.EstadoId, TipoEstadoEnum.EstadoGenerico)

            puesto.UsuarioRegistroId = puestoExiste.UsuarioRegistroId
            puesto.FechaCreacion = puestoExiste.FechaCreacion

            Dim valoresAnteriores As String = $"Nombre: {puestoExiste.Nombre}, Descripcion: {puestoExiste.Descripcion}, Estado: {puestoExiste.EstadoId}"
            Dim valoresNuevos As String = $"Nombre: {puesto.Nombre}, Descripcion: {puesto.Descripcion}, Estado: {puesto.EstadoId}"

            puesto.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            puesto.FechaActualizacion = DateTime.Now

            repo.Actualizar(puesto)

            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Puesto", puesto.IdPuesto, TipoAccionAuditoria.Actualizar, valoresAnteriores, valoresNuevos)
        End Using
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of PuestoDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class
