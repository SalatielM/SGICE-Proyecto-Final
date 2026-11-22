Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports DAO
Imports Microsoft.EntityFrameworkCore
Imports MODELOS

Public Class UsuarioServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of Usuario)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(idusuario As Integer) As Usuario
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
            Dim usuario = repo.ObtenerPorId(idusuario)

            If usuario Is Nothing Then
                Throw New ExcepcionesdeNegocio("Este usuario no se encuentra registrado")
            End If
            Return usuario
        End Using
    End Function

    Public Function ObtenerPorNombreUsuario(nombre As String) As Usuario
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ExcepcionesdeNegocio("Debe escribir el nombre del usuario")
        End If

        nombre = nombre.Trim().ToLower()
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
            Dim usuario = repo.Consultar().
                FirstOrDefault(Function(us) us.NombreUsuario.ToLower() = nombre)

            If usuario Is Nothing Then
                Throw New ExcepcionesdeNegocio("Nombre usuario incorrecto")
            End If
            Return usuario
        End Using
    End Function

    Public Function ContarPorEstado(idEstado As Integer) As Integer
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
            Return repo.Consultar().Count(Function(x) x.EstadoId = idEstado)
        End Using
    End Function

    Public Function Listar() As List(Of UsuarioDTO)
        Using ctx As New AppDbContext()
            Return ctx.Usuario.
                Include(Function(u) u.Rol).
                Include(Function(u) u.Estado).
                Select(Function(u) New UsuarioDTO With {
                    .IdUsuario = u.IdUsuario,
                    .Foto = u.Foto,
                    .Nombre = u.Nombre,
                    .Apellido = u.Apellido,
                    .NombreUsuario = u.NombreUsuario,
                    .Cedula = u.Cedula,
                    .Telefono = u.Telefono,
                    .Correo = u.Correo,
                    .RolId = u.RolId,
                    .Rol = u.Rol.Nombre,
                    .EstadoId = u.EstadoId,
                    .Estado = u.Estado.Nombre
                }).ToList()
        End Using
    End Function

    Public Sub ValidarUsuarioActivo(idusuario As Integer)
        Dim usuario = ObtenerPorId(idusuario)

        Using ctx As New AppDbContext()
            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(usuario.EstadoId, TipoEstadoEnum.EstadoGenerico)
        End Using

        If usuario.EstadoId <> CInt(EstadoGenerico.Activo) Then
            Throw New ExcepcionesdeNegocio("Este usuario se encuentra inactivo")
        End If
    End Sub

    Private Sub Normalizar(usuario As Usuario)
        usuario.NombreUsuario = If(usuario.NombreUsuario, "").Trim()
        usuario.Nombre = If(usuario.Nombre, "").Trim()
        usuario.Apellido = If(usuario.Apellido, "").Trim()
        usuario.Cedula = If(usuario.Cedula, "").Trim()
        usuario.Telefono = If(usuario.Telefono, "").Trim()
        usuario.Correo = If(usuario.Correo, "").Trim().ToLower()
    End Sub

    Private Sub Validar(usuario As Usuario)
        If usuario Is Nothing Then
            Throw New ArgumentNullException(NameOf(usuario))
        End If

        If String.IsNullOrWhiteSpace(usuario.NombreUsuario) Then
            Throw New ExcepcionesdeNegocio("El nombre de usuario es obligatorio")
        End If

        If usuario.NombreUsuario.Length < 5 Then
            Throw New ExcepcionesdeNegocio("El nombre de usuario debe tener mínimo 5 caracteres")
        End If

        If usuario.NombreUsuario.Length > 10 Then
            Throw New ExcepcionesdeNegocio("El nombre de usuario no puede superar los 10 caracteres")
        End If

        If String.IsNullOrWhiteSpace(usuario.Nombre) Then
            Throw New ExcepcionesdeNegocio("El nombre es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(usuario.Apellido) Then
            Throw New ExcepcionesdeNegocio("El apellido es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(usuario.Cedula) Then
            Throw New ExcepcionesdeNegocio("La cedula es obligatoria")
        End If

        If Not ValidarCedula(usuario.Cedula) Then
            Throw New ExcepcionesdeNegocio("La cedula no es valida")
        End If

        If String.IsNullOrWhiteSpace(usuario.Telefono) Then
            Throw New ExcepcionesdeNegocio("El numero de telefono es obligatorio")
        End If

        If Not ValidarTelefono(usuario.Telefono) Then
            Throw New ExcepcionesdeNegocio("El numero de telefono no es valido")
        End If

        If String.IsNullOrWhiteSpace(usuario.Correo) Then
            Throw New ExcepcionesdeNegocio("El correo es obligatorio")
        End If

        If Not ValidarCorreo(usuario.Correo) Then
            Throw New ExcepcionesdeNegocio("El correo electronico no es valido")
        End If
    End Sub

    Private Function ValidarCorreo(correo As String) As Boolean
        If String.IsNullOrWhiteSpace(correo) Then
            Return False
        End If

        correo = correo.Trim().ToLower()

        Try
            Dim email As New MailAddress(correo)

            If email.Address <> correo Then
                Return False
            End If

            Dim partes() As String = correo.Split("@"c)
            If partes.Length <> 2 Then
                Return False
            End If

            Dim dominio As String = partes(1)
            If Not dominio.Contains(".") Then
                Return False
            End If

            Dim extension As String = dominio.Substring(dominio.LastIndexOf(".") + 1)
            Dim extensionesValidas As String() = {"com", "net", "org", "edu", "do", "com.do", "gov.do"}

            If Not extensionesValidas.Any(Function(x) dominio.EndsWith("." & x)) Then
                Return False
            End If

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function ValidarCedula(cedula As String) As Boolean
        If String.IsNullOrWhiteSpace(cedula) Then
            Return False
        End If

        cedula = cedula.Replace("-", "").Replace(" ", "")

        If Not Regex.IsMatch(cedula, "^\d{11}$") Then
            Return False
        End If

        Dim suma As Integer = 0
        Dim multiplicadores() As Integer = {1, 2, 1, 2, 1, 2, 1, 2, 1, 2}

        For i As Integer = 0 To 9
            Dim digito As Integer = Integer.Parse(cedula(i).ToString())
            Dim resultado As Integer = digito * multiplicadores(i)

            If resultado >= 10 Then
                resultado = (resultado \ 10) + (resultado Mod 10)
            End If

            suma += resultado
        Next

        Dim digitoCalculado As Integer = (10 - (suma Mod 10)) Mod 10
        Dim digitoVerificador As Integer = Integer.Parse(cedula(10).ToString())

        Return digitoCalculado = digitoVerificador
    End Function

    Private Function ValidarTelefono(telefono As String) As Boolean
        telefono = telefono.Replace("-", "") _
                            .Replace("(", "") _
                            .Replace(")", "") _
                            .Replace(" ", "")
        Return Regex.IsMatch(telefono, "^(809|829|849)\d{7}$")
    End Function

    Private Function ExisteNombreUsuario(ctx As AppDbContext, nombreUsuario As String) As Boolean
        nombreUsuario = nombreUsuario.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
        Return repo.Consultar().Any(Function(usuario) usuario.NombreUsuario.ToLower() = nombreUsuario)
    End Function

    Private Function ExisteNombreUsuario(ctx As AppDbContext, nombreUsuario As String, idusuario As Integer) As Boolean
        nombreUsuario = nombreUsuario.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
        Return repo.Consultar().Any(Function(usuario) usuario.NombreUsuario.ToLower() = nombreUsuario AndAlso usuario.IdUsuario <> idusuario)
    End Function

    Private Function ExisteCedula(ctx As AppDbContext, cedula As String) As Boolean
        cedula = cedula.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
        Return repo.Consultar().Any(Function(usuario) usuario.Cedula.ToLower() = cedula)
    End Function

    Private Function ExisteCedula(ctx As AppDbContext, cedula As String, idusuario As Integer) As Boolean
        cedula = cedula.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
        Return repo.Consultar().Any(Function(usuario) usuario.Cedula.ToLower() = cedula AndAlso usuario.IdUsuario <> idusuario)
    End Function

    Private Function ExisteTelefono(ctx As AppDbContext, telefono As String) As Boolean
        telefono = telefono.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
        Return repo.Consultar().Any(Function(usuario) usuario.Telefono.ToLower() = telefono)
    End Function

    Private Function ExisteTelefono(ctx As AppDbContext, telefono As String, idusuario As Integer) As Boolean
        telefono = telefono.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
        Return repo.Consultar().Any(Function(usuario) usuario.Telefono.ToLower() = telefono AndAlso usuario.IdUsuario <> idusuario)
    End Function

    Private Function ExisteCorreo(ctx As AppDbContext, correo As String) As Boolean
        correo = correo.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
        Return repo.Consultar().Any(Function(usuario) usuario.Correo.ToLower() = correo)
    End Function

    Private Function ExisteCorreo(ctx As AppDbContext, correo As String, idusuario As Integer) As Boolean
        correo = correo.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
        Return repo.Consultar().Any(Function(usuario) usuario.Correo.ToLower() = correo AndAlso usuario.IdUsuario <> idusuario)
    End Function

    Public Sub CambiarEstado(idusuario As Integer, nuevoestado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
            Dim usuario = repo.ObtenerPorId(idusuario)

            If usuario Is Nothing Then
                Throw New ExcepcionesdeNegocio("Este usuario no se encuentra registrado")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoestado, TipoEstadoEnum.EstadoGenerico)

            If usuario.EstadoId = nuevoestado Then
                Throw New ExcepcionesdeNegocio("El usuario ya posee ese estado.")
            End If

            usuario.EstadoId = nuevoestado
            usuario.FechaActualizacion = DateTime.Now

            repo.Actualizar(usuario)
        End Using
    End Sub

    Public Sub Agregar(usuario As Usuario)
        If usuario Is Nothing Then
            Throw New ArgumentNullException(NameOf(usuario))
        End If

        Normalizar(usuario)
        Validar(usuario)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Usuario)(ctx)

            If ExisteNombreUsuario(ctx, usuario.NombreUsuario) Then
                Throw New ExcepcionesdeNegocio("Ya existe un usuario con ese nombre")
            End If

            If ExisteCedula(ctx, usuario.Cedula) Then
                Throw New ExcepcionesdeNegocio("Ya existe un usuario con esta cedula")
            End If

            If ExisteTelefono(ctx, usuario.Telefono) Then
                Throw New ExcepcionesdeNegocio("Ya existe un usuario con este numero de telefono")
            End If

            If ExisteCorreo(ctx, usuario.Correo) Then
                Throw New ExcepcionesdeNegocio("Ya existe un usuario con este correo")
            End If

            If usuario.RolId < 1 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un rol")
            End If

            If usuario.EstadoId < 1 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un estado")
            End If

            Dim rolservicios As New Rolservicios()
            Dim estadoservicios As New EstadoServicios()
            Dim seguridadservicios As New SeguridadServicios()

            rolservicios.ValidarRol(usuario.RolId)
            estadoservicios.ValidarEstado(usuario.EstadoId, TipoEstadoEnum.EstadoGenerico)

            usuario.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            usuario.FechaCreacion = DateTime.Now
            usuario.ClaveHash = seguridadservicios.GenerarHash(usuario.ClaveHash)

            repo.Agregar(usuario)

            Dim valoresNuevos As String = $"Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, Usuario: {usuario.NombreUsuario}, Cedula: {usuario.Cedula}, Telefono: {usuario.Telefono}, Correo: {usuario.Correo}, Rol: {usuario.RolId}, Estado: {usuario.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Usuario", usuario.IdUsuario, TipoAccionAuditoria.Crear, "", valoresNuevos)
        End Using
    End Sub

    Public Sub Actualizar(usuario As Usuario)
        If usuario Is Nothing Then
            Throw New ArgumentNullException(NameOf(usuario))
        End If

        Normalizar(usuario)
        Validar(usuario)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Usuario)(ctx)

            Dim usuarioExiste = repo.ObtenerPorId(usuario.IdUsuario)
            If usuarioExiste Is Nothing Then
                Throw New ExcepcionesdeNegocio("El usuario no existe")
            End If

            If ExisteNombreUsuario(ctx, usuario.NombreUsuario, usuario.IdUsuario) Then
                Throw New ExcepcionesdeNegocio("Ya existe un usuario con ese nombre")
            End If

            If ExisteCedula(ctx, usuario.Cedula, usuario.IdUsuario) Then
                Throw New ExcepcionesdeNegocio("Ya existe un usuario con esa cedula")
            End If

            If ExisteTelefono(ctx, usuario.Telefono, usuario.IdUsuario) Then
                Throw New ExcepcionesdeNegocio("Ya existe un usuario con ese telefono")
            End If

            If ExisteCorreo(ctx, usuario.Correo, usuario.IdUsuario) Then
                Throw New ExcepcionesdeNegocio("Ya existe un usuario con ese correo")
            End If

            Dim rolservicios As New Rolservicios()
            Dim estadoservicios As New EstadoServicios()

            rolservicios.ValidarRol(usuario.RolId)
            estadoservicios.ValidarEstado(usuario.EstadoId, TipoEstadoEnum.EstadoGenerico)

            usuario.ClaveHash = usuarioExiste.ClaveHash
            usuario.FechaCreacion = usuarioExiste.FechaCreacion
            usuario.UsuarioRegistroId = usuarioExiste.UsuarioRegistroId
            Dim valoresAnteriores As String = $"Nombre: {usuarioExiste.Nombre}, Apellido: {usuarioExiste.Apellido}, Usuario: {usuarioExiste.NombreUsuario}, Cedula: {usuarioExiste.Cedula}, Telefono: {usuarioExiste.Telefono}, Correo: {usuarioExiste.Correo}, Rol: {usuarioExiste.RolId}, Estado: {usuarioExiste.EstadoId}"

            usuario.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            usuario.FechaActualizacion = DateTime.UtcNow

            repo.Actualizar(usuario)

            Dim valoresNuevos As String = $"Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, Usuario: {usuario.NombreUsuario}, Cedula: {usuario.Cedula}, Telefono: {usuario.Telefono}, Correo: {usuario.Correo}, Rol: {usuario.RolId}, Estado: {usuario.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Usuario", usuario.IdUsuario, TipoAccionAuditoria.Actualizar, valoresAnteriores, valoresNuevos)
        End Using
    End Sub

    Public Function CambiarClave(idusuario As Integer, claveactual As String, clavenueva As String) As Boolean
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
            Dim usuario = repo.ObtenerPorId(idusuario)

            If usuario Is Nothing Then
                Throw New ExcepcionesdeNegocio("El usuario no existe.")
            End If

            If String.IsNullOrWhiteSpace(claveactual) Then
                Throw New ExcepcionesdeNegocio("Debe ingresar la contraseña actual")
            End If

            Dim seguridadservicios As New SeguridadServicios()

            If seguridadservicios.VerificarHas(claveactual, usuario.ClaveHash) = False Then
                Throw New ExcepcionesdeNegocio("La contraseña actual es incorrecta")
            End If

            If String.IsNullOrWhiteSpace(clavenueva) Then
                Throw New ExcepcionesdeNegocio("Debe ingresar la nueva contraseña")
            End If

            If seguridadservicios.VerificarHas(clavenueva, usuario.ClaveHash) Then
                Throw New ExcepcionesdeNegocio("La nueva contraseña debe ser diferente a la actual.")
            End If

            usuario.ClaveHash = seguridadservicios.GenerarHash(clavenueva)
            usuario.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            usuario.FechaActualizacion = DateTime.Now

            repo.Actualizar(usuario)

            Return idusuario = SesionActual.Usuario.IdUsuario
        End Using
    End Function

    Public Function IniciarSesion(nombreusuario As String, clave As String) As Usuario
        If String.IsNullOrWhiteSpace(nombreusuario) Then
            Throw New ExcepcionesdeNegocio("Debe ingresar el nombre de usuario")
        End If

        If String.IsNullOrWhiteSpace(clave) Then
            Throw New ExcepcionesdeNegocio("Debe ingresar la contraseña")
        End If

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Usuario)(ctx)
            Dim usuario = repo.Consultar().
                FirstOrDefault(Function(u) u.NombreUsuario = nombreusuario)

            If usuario Is Nothing Then
                Throw New ExcepcionesdeNegocio("Este usuario no existe")
            End If

            If usuario.EstadoId <> CInt(EstadoGenerico.Activo) Then
                Throw New ExcepcionesdeNegocio("Este usuario esta inactivo")
            End If

            Dim seguridadservicios As New SeguridadServicios()

            If Not seguridadservicios.VerificarHas(clave, usuario.ClaveHash) Then
                Throw New ExcepcionesdeNegocio("Usuario o contraseña incorrecta")
            End If

            SesionActual.IniciarSesion(usuario)

            Return usuario
        End Using
    End Function

    Public Function BuscarPorNombre(filtro As String) As List(Of UsuarioDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class
