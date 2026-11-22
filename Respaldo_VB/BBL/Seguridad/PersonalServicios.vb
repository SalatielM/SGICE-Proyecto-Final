Imports DAO
Imports MODELOS
Imports Microsoft.EntityFrameworkCore
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class PersonalServicios

    Public Sub New()

    End Sub

    Public Function ObteneTodos() As List(Of Personal)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Personal)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(idpersonal As Integer) As Personal
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Personal)(ctx)
            Dim personal = repo.ObtenerPorId(idpersonal)

            If personal Is Nothing Then
                Throw New ExcepcionesdeNegocio("Este personal no existe")
            End If
            Return personal
        End Using
    End Function

    Public Function ObtenerPorNombre(nombre As String) As Personal
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ExcepcionesdeNegocio("El campo no puede estar vacio")
        End If

        nombre = nombre.Trim().ToLower()
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Personal)(ctx)
            Dim personal = repo.Consultar().
                FirstOrDefault(Function(a) a.Nombre.ToLower() = nombre)

            If personal Is Nothing Then
                Throw New ExcepcionesdeNegocio("El personal no existe o esta mal escrito")
            End If
            Return personal
        End Using
    End Function

    Public Function ObtenerPorCodigo(codigo As String) As Personal
        If String.IsNullOrWhiteSpace(codigo) Then
            Throw New ExcepcionesdeNegocio("El campo no puede estar vacio")
        End If

        codigo = codigo.Trim().ToLower()
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Personal)(ctx)
            Dim personal = repo.Consultar().
                FirstOrDefault(Function(a) a.CodPersonal.ToLower() = codigo)

            If personal Is Nothing Then
                Throw New ExcepcionesdeNegocio("El personal no existe o esta mal escrito")
            End If
            Return personal
        End Using
    End Function

    Public Function ContarPorEstado(idEstado As Integer) As Integer
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Personal)(ctx)
            Return repo.Consultar().Count(Function(x) x.EstadoId = idEstado)
        End Using
    End Function

    Public Function ObtenerPorPuestos(puestoId As Integer) As List(Of Personal)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Personal)(ctx)
            Return repo.Consultar().
                Where(Function(s) s.PuestoId = puestoId).ToList()
        End Using
    End Function

    Public Function Listar() As List(Of PersonalDTO)
        Using ctx As New AppDbContext()
            Return ctx.Personal.
                Include(Function(p) p.Estado).
                Select(Function(p) New PersonalDTO With {
                .IdPersonal = p.IdPersonal,
                .Foto = p.Foto,
                .Nombre = p.Nombre,
                .Apellido = p.Apellido,
                .Cedula = p.Cedula,
                .CodPersonal = p.CodPersonal,
                .Telefono = p.Telefono,
                .Correo = p.Correo,
                .PuestoId = p.PuestoId,
                .Puesto = p.Puesto.Nombre,
                .EstadoId = p.EstadoId,
                .Estado = p.Estado.Nombre
                }).ToList()
        End Using
    End Function

    Public Sub ValidarEstadoPersonal(idpersonal As Integer)
        Dim personal = ObtenerPorId(idpersonal)

        Using ctx As New AppDbContext()
            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(personal.EstadoId, TipoEstadoEnum.EstadoGenerico)
        End Using

        If personal.EstadoId <> CInt(EstadoGenerico.Activo) Then
            Throw New ExcepcionesdeNegocio("Persona inactivo")
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

    Private Function ValidarCedula(cedula As String) As Boolean
        cedula = cedula.Replace("-", "").Replace(" ", "")

        If Not Regex.IsMatch(cedula, "^\d{11}$") Then
            Return False
        End If

        Dim suma As Integer = 0
        Dim multiplicadores() As Integer = {1, 2, 1, 2, 1, 2, 1, 2, 1, 2}

        For i As Integer = 0 To 9
            Dim resultado As Integer = Integer.Parse(cedula(i).ToString()) * multiplicadores(i)

            If resultado >= 10 Then
                resultado = (resultado \ 10) + (resultado Mod 10)
            End If

            suma += resultado
        Next

        Dim digitoCalculado As Integer = (10 - (suma Mod 10)) Mod 10
        Return digitoCalculado = Integer.Parse(cedula(10).ToString())
    End Function

    Public Sub CambiarEstado(idpersonal As Integer, nuevoestado As Integer)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Personal)(ctx)
            Dim personal = repo.ObtenerPorId(idpersonal)

            If personal Is Nothing Then
                Throw New ExcepcionesdeNegocio("Este personal no existe")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(nuevoestado, TipoEstadoEnum.EstadoGenerico)

            If personal.EstadoId = nuevoestado Then
                Throw New ExcepcionesdeNegocio("El personal ya posee ese estado.")
            End If

            personal.EstadoId = nuevoestado
            personal.FechaActualizacion = DateTime.Now

            repo.Actualizar(personal)
        End Using
    End Sub

    Private Function ExisteCedula(ctx As AppDbContext, cedula As String) As Boolean
        cedula = cedula.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Personal)(ctx)
        Return repo.Consultar().Any(Function(personal) personal.Cedula.ToLower() = cedula)
    End Function

    Private Function ExisteCodPersonal(ctx As AppDbContext, codpersonal As String) As Boolean
        codpersonal = codpersonal.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Personal)(ctx)
        Return repo.Consultar().Any(Function(personal) personal.CodPersonal.ToLower() = codpersonal)
    End Function

    Private Function ExisteCedula(ctx As AppDbContext, cedula As String, idpersonal As Integer) As Boolean
        cedula = cedula.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Personal)(ctx)
        Return repo.Consultar().Any(Function(personal) personal.Cedula.ToLower() = cedula AndAlso personal.IdPersonal <> idpersonal)
    End Function

    Private Function ExisteCodPersonal(ctx As AppDbContext, codpersonal As String, idpersonal As Integer) As Boolean
        codpersonal = codpersonal.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Personal)(ctx)
        Return repo.Consultar().Any(Function(personal) personal.CodPersonal.ToLower() = codpersonal AndAlso personal.IdPersonal <> idpersonal)
    End Function

    Private Function ExisteCorreo(ctx As AppDbContext, correo As String) As Boolean
        correo = correo.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Personal)(ctx)
        Return repo.Consultar().Any(Function(personal) personal.Correo.ToLower() = correo)
    End Function

    Private Function ExisteCorreo(ctx As AppDbContext, correo As String, idpersonal As Integer) As Boolean
        correo = correo.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Personal)(ctx)
        Return repo.Consultar().Any(Function(personal) personal.Correo.ToLower() = correo AndAlso personal.IdPersonal <> idpersonal)
    End Function

    Private Function ExisteTelefono(ctx As AppDbContext, telefono As String) As Boolean
        telefono = telefono.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Personal)(ctx)
        Return repo.Consultar().Any(Function(personal) personal.Telefono.ToLower() = telefono)
    End Function

    Private Function ExisteTelefono(ctx As AppDbContext, telefono As String, idpersonal As Integer) As Boolean
        telefono = telefono.Trim().ToLower()
        Dim repo As New RepositorioGenerico(Of Personal)(ctx)
        Return repo.Consultar().Any(Function(personal) personal.Telefono.ToLower() = telefono AndAlso personal.IdPersonal <> idpersonal)
    End Function

    Private Sub Validar(personal As Personal)
        If String.IsNullOrWhiteSpace(personal.Nombre) Then
            Throw New ExcepcionesdeNegocio("El nombre es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(personal.Apellido) Then
            Throw New ExcepcionesdeNegocio("El apellido es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(personal.Cedula) Then
            Throw New ExcepcionesdeNegocio("La cedula es obligatoria")
        End If

        If String.IsNullOrWhiteSpace(personal.CodPersonal) Then
            Throw New ExcepcionesdeNegocio("El cod del personal es obligatorio")
        End If

        If personal.CodPersonal.Length < 3 OrElse personal.CodPersonal.Length > 10 Then
            Throw New ExcepcionesdeNegocio("El cod del personal no puede ser menor a 3 ni mayor a 10 caracteres")
        End If

        If Not ValidarCedula(personal.Cedula) Then
            Throw New ExcepcionesdeNegocio("La cedula no es valida")
        End If

        If String.IsNullOrWhiteSpace(personal.Telefono) Then
            Throw New ExcepcionesdeNegocio("El numero de telefono es obligatorio")
        End If

        If Not ValidarTelefono(personal.Telefono) Then
            Throw New ExcepcionesdeNegocio("El numero de telefono no es valido")
        End If

        If Not String.IsNullOrWhiteSpace(personal.Correo) Then
            If Not ValidarCorreo(personal.Correo) Then
                Throw New ExcepcionesdeNegocio("El correo electronico no es valido")
            End If
        End If
    End Sub

    Private Sub Normalizar(personal As Personal)
        personal.Nombre = If(personal.Nombre, "").Trim()
        personal.Apellido = If(personal.Apellido, "").Trim()
        personal.Cedula = If(personal.Cedula, "").Trim()
        personal.CodPersonal = If(personal.CodPersonal, "").Trim()
        personal.Telefono = If(personal.Telefono, "").Trim()
        personal.Correo = If(personal.Correo, "").Trim()
    End Sub

    Public Sub Agregar(personal As Personal)
        If personal Is Nothing Then
            Throw New ArgumentNullException(NameOf(personal))
        End If

        Normalizar(personal)
        Validar(personal)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Personal)(ctx)

            If ExisteCedula(ctx, personal.Cedula) Then
                Throw New ExcepcionesdeNegocio("Ya existe un personal con la misma cedula")
            End If

            If ExisteCodPersonal(ctx, personal.CodPersonal) Then
                Throw New ExcepcionesdeNegocio("Ya existe un personal con el mismo codigo")
            End If

            If personal.PuestoId < 1 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un puesto")
            End If

            If ExisteTelefono(ctx, personal.Telefono) Then
                Throw New ExcepcionesdeNegocio("Ya existe un personal con el mismo numero de telefono")
            End If

            If Not String.IsNullOrWhiteSpace(personal.Correo) AndAlso ExisteCorreo(ctx, personal.Correo) Then
                Throw New ExcepcionesdeNegocio("Ya existe un personal con el mismo correo")
            End If

            If personal.EstadoId < 1 Then
                Throw New ExcepcionesdeNegocio("Debe elegir un estado")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(personal.EstadoId, TipoEstadoEnum.EstadoGenerico)

            personal.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
            personal.FechaCreacion = DateTime.Now

            repo.Agregar(personal)

            Dim detalleValores As String = $"Nombre: {personal.Nombre} {personal.Apellido}, Cédula: {personal.Cedula}, Teléfono: {personal.Telefono}, Correo: {personal.Correo}, Puesto : {personal.PuestoId}, Estado: {personal.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Personal", personal.IdPersonal, TipoAccionAuditoria.Crear, "", $"Personal creado: {detalleValores}")
        End Using
    End Sub

    Public Sub Actualizar(personal As Personal)
        If personal Is Nothing Then
            Throw New ArgumentNullException(NameOf(personal))
        End If

        Normalizar(personal)
        Validar(personal)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Personal)(ctx)

            Dim personalExiste = repo.ObtenerPorId(personal.IdPersonal)
            If personalExiste Is Nothing Then
                Throw New ExcepcionesdeNegocio("El personal que desea actualizar no existe")
            End If

            If ExisteCodPersonal(ctx, personal.CodPersonal, personal.IdPersonal) Then
                Throw New ExcepcionesdeNegocio("Ya existe un personal con el mismo CodPersonal")
            End If

            If ExisteCedula(ctx, personal.Cedula, personal.IdPersonal) Then
                Throw New ExcepcionesdeNegocio("Ya existe un personal con la misma Cedula")
            End If

            If Not String.IsNullOrWhiteSpace(personal.Correo) AndAlso ExisteCorreo(ctx, personal.Correo, personal.IdPersonal) Then
                Throw New ExcepcionesdeNegocio("Ya existe un personal con el mismo correo")
            End If

            If ExisteTelefono(ctx, personal.Telefono, personal.IdPersonal) Then
                Throw New ExcepcionesdeNegocio("Ya existe un personal con el mismo numero de telefono")
            End If

            Dim estadoservicios As New EstadoServicios()
            estadoservicios.ValidarEstado(personal.EstadoId, TipoEstadoEnum.EstadoGenerico)

            personal.UsuarioRegistroId = personalExiste.UsuarioRegistroId
            personal.FechaCreacion = personalExiste.FechaCreacion
            Dim valoresAntiguos As String = $"Nombre: {personalExiste.Nombre} {personalExiste.Apellido}, Cédula: {personalExiste.Cedula}, Teléfono: {personalExiste.Telefono}, Correo: {personalExiste.Correo}, Puesto : {personalExiste.PuestoId}, Estado: {personalExiste.EstadoId}"

            personal.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
            personal.FechaActualizacion = DateTime.Now

            repo.Actualizar(personal)

            Dim valoresNuevos As String = $"Nombre: {personal.Nombre} {personal.Apellido}, Cédula: {personal.Cedula}, Teléfono: {personal.Telefono}, Correo: {personal.Correo}, Puesto : {personal.PuestoId}, Estado: {personal.EstadoId}"
            Dim auditoriaservicios As New AuditoriaServicios()
            auditoriaservicios.Registrar("Personal", personal.IdPersonal, TipoAccionAuditoria.Actualizar, valoresAntiguos, valoresNuevos)
        End Using
    End Sub

    Public Function BuscarPorNombre(filtro As String) As List(Of PersonalDTO)
        Return Listar().Where(Function(e) e.Nombre.ToLower().Contains(filtro.ToLower())).ToList()
    End Function

End Class
