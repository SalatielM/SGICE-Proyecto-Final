Imports DAO
Imports MODELOS
Imports Microsoft.EntityFrameworkCore

Public Class CentroEducativoServicios

    Public Sub New()

    End Sub

    Public Function ObtenerInfoCentro() As CentroEducativo
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of CentroEducativo)(ctx)
            Dim centro = repo.Consultar().Include(Function(c) c.Director).FirstOrDefault()

            If centro Is Nothing Then
                Return New CentroEducativo()
            End If

            Return centro
        End Using
    End Function

    Public Sub Guardarcentro(centro As CentroEducativo)
        If centro Is Nothing Then
            Throw New ExcepcionesdeNegocio("Debe completar todos los campos")
        End If

        Normalizar(centro)
        Validar(centro)

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of CentroEducativo)(ctx)
            Dim existenteCentro = repo.Consultar().FirstOrDefault()

            Dim directorservicios As New DirectorServicios()
            Dim directorSeleccionado = directorservicios.ObtenerPorId(centro.DirectorId)

            If directorSeleccionado.EstadoId <> CInt(EstadoGenerico.Activo) Then
                Throw New ExcepcionesdeNegocio("El director seleccionado debe estar en estado activo.")
            End If

            If centro.DirectorId <= 0 Then
                Throw New ExcepcionesdeNegocio("Debe seleccionar un director")
            End If

            Dim auditoriaservicios As New AuditoriaServicios()

            If existenteCentro Is Nothing Then
                centro.UsuarioRegistroId = SesionActual.Usuario.IdUsuario
                centro.FechaCreacion = DateTime.Now
                repo.Agregar(centro)

                Dim valoresNuevos As String = $"Nombre: {centro.Nombre}, Codigo: {centro.CodCentro}, Telefono: {centro.Telefono}, Correo: {centro.Correo}, Direccion: {centro.Direccion}, Modalidad: {centro.Modalidad}, Jornada: {centro.Jornada}, Distrito: {centro.DistritoEducativo}, Regional: {centro.RegionalEducativo}, Director: {centro.DirectorId}"
                auditoriaservicios.Registrar("CentroEducativo", centro.IdCentroEducativo, TipoAccionAuditoria.Crear, "", valoresNuevos)

            Else
                Dim valoresAnteriores As String = $"Nombre: {existenteCentro.Nombre}, Codigo: {existenteCentro.CodCentro}, Telefono: {existenteCentro.Telefono}, Correo: {existenteCentro.Correo}, Direccion: {existenteCentro.Direccion}, Modalidad: {existenteCentro.Modalidad}, Jornada: {existenteCentro.Jornada}, Distrito: {existenteCentro.DistritoEducativo}, Regional: {existenteCentro.RegionalEducativo}, Director: {existenteCentro.DirectorId}"
                Dim valoresNuevos As String = $"Nombre: {centro.Nombre}, Codigo: {centro.CodCentro}, Telefono: {centro.Telefono}, Correo: {centro.Correo}, Direccion: {centro.Direccion}, Modalidad: {centro.Modalidad}, Jornada: {centro.Jornada}, Distrito: {centro.DistritoEducativo}, Regional: {centro.RegionalEducativo}, Director: {centro.DirectorId}"

                centro.IdCentroEducativo = existenteCentro.IdCentroEducativo
                centro.UsuarioRegistroId = existenteCentro.UsuarioRegistroId
                centro.FechaCreacion = existenteCentro.FechaCreacion

                centro.UsuarioActualizacionId = SesionActual.Usuario.IdUsuario
                centro.FechaActualizacion = DateTime.Now

                repo.Actualizar(centro)
                auditoriaservicios.Registrar("CentroEducativo", centro.IdCentroEducativo, TipoAccionAuditoria.Actualizar, valoresAnteriores, valoresNuevos)
            End If
        End Using
    End Sub

    Private Sub Normalizar(centro As CentroEducativo)
        centro.Nombre = If(centro.Nombre, "").Trim()
        centro.CodCentro = If(centro.CodCentro, "").Trim()
        centro.Modalidad = If(centro.Modalidad, "").Trim()
        centro.Jornada = If(centro.Jornada, "").Trim()
        centro.Telefono = If(centro.Telefono, "").Trim()
        centro.Correo = If(centro.Correo, "").Trim()
        centro.Direccion = If(centro.Direccion, "").Trim()
        centro.DistritoEducativo = If(centro.DistritoEducativo, "").Trim()
        centro.RegionalEducativo = If(centro.RegionalEducativo, "").Trim()
    End Sub

    Private Sub Validar(centro As CentroEducativo)
        If String.IsNullOrWhiteSpace(centro.Nombre) Then
            Throw New ExcepcionesdeNegocio("El Nombre del centro es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(centro.CodCentro) Then
            Throw New ExcepcionesdeNegocio("El codigo del centro es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(centro.Telefono) Then
            Throw New ExcepcionesdeNegocio("El numero de telefono del centro es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(centro.Correo) Then
            Throw New ExcepcionesdeNegocio("El correo del centro es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(centro.Direccion) Then
            Throw New ExcepcionesdeNegocio("La Direccion del centro es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(centro.DistritoEducativo) Then
            Throw New ExcepcionesdeNegocio("El campo distrito educativo es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(centro.RegionalEducativo) Then
            Throw New ExcepcionesdeNegocio("El campo Regional educativa es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(centro.Modalidad) Then
            Throw New ExcepcionesdeNegocio("El Campo Modalidad el centro es obligatorio")
        End If

        If String.IsNullOrWhiteSpace(centro.Jornada) Then
            Throw New ExcepcionesdeNegocio("El campo jornada es obligatorio")
        End If

        If centro.DirectorId <= 0 Then
            Throw New ExcepcionesdeNegocio("Debe seleccionar un director")
        End If
    End Sub

End Class
