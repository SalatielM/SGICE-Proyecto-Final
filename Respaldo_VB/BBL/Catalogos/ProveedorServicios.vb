Imports DAO
Imports MODELOS
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports Microsoft.EntityFrameworkCore


Public Class ProveedorServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of Proveedor)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Proveedor)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(id As Integer) As Proveedor
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Proveedor)(ctx)
            Dim prov = repo.ObtenerPorId(id)
            If prov Is Nothing Then Throw New ExcepcionesdeNegocio("El proveedor no existe")
            Return prov
        End Using
    End Function

    Public Function Listar() As List(Of ProveedorDTO)
        Using ctx As New AppDbContext()
            Return ctx.Proveedor.
                Include(Function(p) p.Estado).
                Select(Function(p) New ProveedorDTO With {
                    .IdProveedor = p.IdProveedor,
                    .RNC = p.RNC,
                    .Nombre = p.Nombre,
                    .Telefono = p.Telefono,
                    .Correo = p.Correo,
                    .Direccion = p.Direccion,
                    .PersonalContacto = p.PersonalContacto,
                    .TelefonoContacto = p.TelefonoContacto,
                    .EstadoId = p.EstadoId,
                    .Estado = p.Estado.Nombre
                }).ToList()
        End Using
    End Function

    Public Sub ValidarEstadoProveedor(idproveedor As Integer)
        Dim proveedor = ObtenerPorId(idproveedor)

        Using ctx As New AppDbContext()
            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(proveedor.EstadoId, TipoEstadoEnum.EstadoGenerico)
        End Using

        If proveedor.EstadoId <> CInt(EstadoGenerico.Activo) Then
            Throw New ExcepcionesdeNegocio("Este proveedor esta inactivo")
        End If
    End Sub

    Private Sub Validar(p As Proveedor)
        If String.IsNullOrWhiteSpace(p.Nombre) Then
            Throw New ExcepcionesdeNegocio("Debe escribir el nombre del proveedor")
        End If

        If String.IsNullOrWhiteSpace(p.RNC) Then
            Throw New ExcepcionesdeNegocio("El RNC es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(p.Telefono) Then
            Throw New ExcepcionesdeNegocio("Debe escribir el numero de telefono")
        End If

        If String.IsNullOrWhiteSpace(p.Correo) Then
            Throw New ExcepcionesdeNegocio("Debe escribir el correo del proveedor")
        End If

        If String.IsNullOrWhiteSpace(p.Direccion) Then
            Throw New ExcepcionesdeNegocio("Debe escribir la direccion del proveedor")
        End If

        If p.EstadoId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe Seleccionar un estado")
        End If

        If String.IsNullOrWhiteSpace(p.PersonalContacto) Then
            Throw New ExcepcionesdeNegocio("Debe escribir el personal de contacto del proveedor")
        End If

        If Not ValidarTelefono(p.Telefono) Then
            Throw New ExcepcionesdeNegocio("El numero de telefono no es valido")
        End If

        If Not ValidarCorreo(p.Correo) Then
            Throw New ExcepcionesdeNegocio("El correo electronico no es valido")
        End If

        If Not ValidarRNC(p.RNC) Then
            Throw New ExcepcionesdeNegocio("El RNC no es valido")
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

    Private Function ValidarTelefono(telefono As String) As Boolean
        telefono = telefono.Replace("-", "") _
                            .Replace("(", "") _
                            .Replace(")", "") _
                            .Replace(" ", "")
        Return Regex.IsMatch(telefono, "^(809|829|849)\d{7}$")
    End Function

    Public Function ValidarRNC(rnc As String) As Boolean

        If String.IsNullOrWhiteSpace(rnc) Then Return False

        rnc = rnc.Trim().Replace("-", "").Replace(" ", "")

        If rnc.Length <> 9 OrElse Not IsNumeric(rnc) Then
            Return False
        End If

        Dim pesos() As Integer = {7, 9, 8, 6, 5, 4, 3, 2}
        Dim suma As Integer = 0

        For i As Integer = 0 To 7
            suma += CInt(rnc(i).ToString()) * pesos(i)
        Next

        Dim residuo As Integer = suma Mod 11
        Dim digito As Integer = 11 - residuo

        If digito = 10 Then digito = 1
        If digito = 11 Then digito = 0

        Dim digitoVerificador As Integer = CInt(rnc(8).ToString())

        Return digito = digitoVerificador
    End Function

    Private Sub Normalizar(p As Proveedor)
        p.RNC = If(p.RNC, "").Trim()
        p.Nombre = If(p.Nombre, "").Trim()
        p.Correo = If(p.Correo, "").Trim()
        p.Telefono = If(p.Telefono, "").Trim()
        p.Direccion = If(p.Direccion, "").Trim()
        p.PersonalContacto = If(p.PersonalContacto, "").Trim()
        p.TelefonoContacto = If(p.TelefonoContacto, "").Trim()
    End Sub

    Private Function ExisteNombreProveedor(ctx As AppDbContext, nombreProveedor As String) As Boolean
        nombreProveedor = nombreProveedor.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Proveedor)(ctx)
        Return repo.Consultar().
            Any(Function(p) p.Nombre.ToLower() = nombreProveedor)
    End Function

    Private Function ExisteNombreProveedor(ctx As AppDbContext, nombreProveedor As String, idproveedor As Integer) As Boolean
        nombreProveedor = nombreProveedor.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Proveedor)(ctx)
        Return repo.Consultar().
            Any(Function(p) p.Nombre.ToLower() = nombreProveedor AndAlso p.IdProveedor <> idproveedor)
    End Function

    Public Sub Agregar(p As Proveedor)
        If p Is Nothing Then
            Throw New ArgumentNullException(NameOf(p))
        End If

        Normalizar(p)
        Validar(p)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Proveedor)(ctx)

            If ExisteNombreProveedor(ctx, p.Nombre) Then
                Throw New ExcepcionesdeNegocio("Este proveedor ya se encuentra registrado")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(p.EstadoId, TipoEstadoEnum.EstadoGenerico)

            p.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            p.FechaRegistro = DateTime.Now

            repo.Agregar(p)

            Dim valoresNuevos = $"Nombre: {p.Nombre}, RNC: {p.RNC}, Telefono: {p.Telefono}, Correo: {p.Correo}, Direccion: {p.Direccion}, Persona de Contacto: {p.PersonalContacto}, Telefono de Contacto: {p.TelefonoContacto}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Proveedor", p.IdProveedor, TipoAccionAuditoria.Crear, "", valoresNuevos)
        End Using
    End Sub

    Public Sub Actualizar(p As Proveedor)
        If p Is Nothing Then
            Throw New ArgumentNullException(NameOf(p))
        End If

        Normalizar(p)
        Validar(p)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Proveedor)(ctx)

            If ExisteNombreProveedor(ctx, p.Nombre, p.IdProveedor) Then
                Throw New ExcepcionesdeNegocio("Este proveedor ya se encuentra registrado")
            End If

            Dim db = repo.ObtenerPorId(p.IdProveedor)
            If db Is Nothing Then
                Throw New ExcepcionesdeNegocio("El proveedor no existe")
            End If

            p.FechaRegistro = db.FechaRegistro
            p.UsuarioRegistroId = db.UsuarioRegistroId
            p.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            p.FechaActualizacion = DateTime.Now

            Dim valoresAntiguos = $"Nombre: {db.Nombre}, RNC: {db.RNC}, Telefono: {db.Telefono}, Correo: {db.Correo}, Direccion: {db.Direccion}, Persona de Contacto: {db.PersonalContacto}, Telefono de Contacto: {db.TelefonoContacto}"

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(p.EstadoId, TipoEstadoEnum.EstadoGenerico)

            repo.Actualizar(p)

            Dim valoresNuevos = $"Nombre: {p.Nombre}, RNC: {p.RNC}, Telefono: {p.Telefono}, Correo: {p.Correo}, Direccion: {p.Direccion}, Persona de Contacto: {p.PersonalContacto}, Telefono de Contacto: {p.TelefonoContacto}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Proveedor", p.IdProveedor, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Sub CambiarEstado(id As Integer, nuevoEstado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Proveedor)(ctx)
            Dim p = repo.ObtenerPorId(id)
            If p Is Nothing Then
                Throw New ExcepcionesdeNegocio("El proveedor no existe")
            End If

            Dim valoresAntiguos = p.EstadoId.ToString()

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoEstado, TipoEstadoEnum.EstadoGenerico)

            If p.EstadoId = nuevoEstado Then
                Throw New ExcepcionesdeNegocio("El proveedor ya posee ese estado.")
            End If

            p.EstadoId = nuevoEstado
            p.FechaActualizacion = DateTime.Now

            repo.Actualizar(p)

            Dim valoresNuevos = p.EstadoId.ToString()
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Proveedor", p.IdProveedor, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of ProveedorDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class
