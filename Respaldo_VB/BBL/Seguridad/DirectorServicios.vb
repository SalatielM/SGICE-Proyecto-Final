Imports DAO
Imports Microsoft.EntityFrameworkCore
Imports MODELOS

Public Class DirectorServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of Director)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Director)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(iddirector As Integer) As Director
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Director)(ctx)
            Dim director = repo.ObtenerPorId(iddirector)

            If director Is Nothing Then
                Throw New ExcepcionesdeNegocio("Este director no existe")
            End If
            Return director
        End Using
    End Function

    Public Function ObtenerActivos() As List(Of Director)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Director)(ctx)
            Return repo.Consultar().Where(Function(d) d.EstadoId = CInt(EstadoGenerico.Activo)).ToList()
        End Using
    End Function

    Public Function Listar() As List(Of DirectorDTO)
        Using ctx As New AppDbContext()
            Return ctx.Director.
                Include(Function(d) d.Estado).
                Select(Function(d) New DirectorDTO With {
                .IdDirector = d.IdDirector,
                .Nombre = d.Nombre,
                .Apellido = d.Apellido,
                .Telefono = d.Telefono,
                .Cedula = d.Cedula,
                .Correo = d.Correo,
                .EstadoId = d.EstadoId,
                .Estado = d.Estado.Nombre,
                .FechaInicia = d.FechaInicia,
                .FechaFin = d.FechaFin
                }).ToList()
        End Using
    End Function

    Public Sub CambiarEstado(iddirector As Integer, nuevoestado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Director)(ctx)
            Dim director = repo.ObtenerPorId(iddirector)

            If director Is Nothing Then
                Throw New ExcepcionesdeNegocio("Este director no existe")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoestado, TipoEstadoEnum.EstadoGenerico)

            If director.EstadoId = nuevoestado Then
                Throw New ExcepcionesdeNegocio("El director ya posee ese estado.")
            End If

            director.EstadoId = nuevoestado

            If nuevoestado = CInt(EstadoGenerico.Inactivo) Then
                director.FechaFin = DateTime.Now
            End If

            repo.Actualizar(director)
        End Using
    End Sub

    Private Sub Validar(director As Director)
        If String.IsNullOrWhiteSpace(director.Nombre) Then
            Throw New ExcepcionesdeNegocio("El nombre es obligatorio")
        End If
        If String.IsNullOrWhiteSpace(director.Apellido) Then
            Throw New ExcepcionesdeNegocio("El apellido es obligatorio")
        End If
        If String.IsNullOrWhiteSpace(director.Cedula) Then
            Throw New ExcepcionesdeNegocio("La cedula es obligatoria")
        End If
        If String.IsNullOrWhiteSpace(director.Telefono) Then
            Throw New ExcepcionesdeNegocio("El telefono es obligatorio")
        End If
        If String.IsNullOrWhiteSpace(director.Correo) Then
            Throw New ExcepcionesdeNegocio("El Correo es obligatorio")
        End If
        If director.EstadoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un estado")
        End If
    End Sub

    Private Sub Normalizar(director As Director)
        director.Nombre = If(director.Nombre, "").Trim()
        director.Apellido = If(director.Apellido, "").Trim()
        director.Cedula = If(director.Cedula, "").Trim()
        director.Correo = If(director.Correo, "").Trim()
        director.Telefono = If(director.Telefono, "").Trim()
    End Sub

    Public Sub Agregar(director As Director)
        If director Is Nothing Then Throw New ExcepcionesdeNegocio("Debe llenar todos los campos")

        Normalizar(director)
        Validar(director)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Director)(ctx)

            director.FechaInicia = DateTime.Now
            director.UsuarioRegistroId = SesionActual.Usuario.IdUsuario

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(director.EstadoId, TipoEstadoEnum.EstadoGenerico)

            repo.Agregar(director)

            Dim nuevosValores As String = $"Nombre: {director.Nombre}, Apellido: {director.Apellido}, Cedula: {director.Cedula}, Telefono: {director.Telefono}, Correo : {director.Correo}, Estado: {director.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Director", director.IdDirector, TipoAccionAuditoria.Crear, "", nuevosValores)
        End Using
    End Sub

    Public Sub Actualizar(director As Director)
        If director Is Nothing Then Throw New ArgumentNullException(NameOf(director))

        Normalizar(director)
        Validar(director)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Director)(ctx)

            Dim directorDB = repo.ObtenerPorId(director.IdDirector)
            If directorDB Is Nothing Then
                Throw New ExcepcionesdeNegocio("Este director no existe")
            End If

            director.UsuarioRegistroId = directorDB.UsuarioRegistroId
            director.FechaInicia = directorDB.FechaInicia

            Dim antiguosValores As String = $"Nombre: {directorDB.Nombre}, Apellido: {directorDB.Apellido}, Cedula: {directorDB.Cedula}, Telefono: {directorDB.Telefono}, Correo : {directorDB.Correo}, Estado: {directorDB.EstadoId}"
            director.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(director.EstadoId, TipoEstadoEnum.EstadoGenerico)

            repo.Actualizar(director)

            Dim nuevosValores As String = $"Nombre: {director.Nombre}, Apellido: {director.Apellido}, Cedula: {director.Cedula}, Telefono: {director.Telefono}, Correo : {director.Correo}, Estado: {director.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Director", director.IdDirector, TipoAccionAuditoria.Actualizar, antiguosValores, nuevosValores)
        End Using
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of DirectorDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class
