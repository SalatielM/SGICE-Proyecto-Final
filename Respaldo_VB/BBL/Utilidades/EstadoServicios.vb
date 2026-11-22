Imports DAO
Imports MODELOS

Public Class EstadoServicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of Estado)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Estado)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObtenerPorId(idestado As Integer) As Estado
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Estado)(ctx)
            Dim estado = repo.ObtenerPorId(idestado)

            If estado Is Nothing Then
                Throw New ExcepcionesdeNegocio("El estado seleccionado no existe")
            End If
            Return estado
        End Using
    End Function

    Public Function ObtenerPorNombre(nombre As String) As Estado
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ExcepcionesdeNegocio("Debe colocar el nombre del estado")
        End If

        nombre = nombre.Trim().ToLower()

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Estado)(ctx)
            Dim estado = repo.Consultar().
                FirstOrDefault(Function(est) est.Nombre.ToLower() = nombre)

            If estado Is Nothing Then
                Throw New ExcepcionesdeNegocio("No existe un estado con ese nombre")
            End If
            Return estado
        End Using
    End Function

    Public Function ObtenerPorTipo(tipoestado As TipoEstadoEnum) As List(Of Estado)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Estado)(ctx)
            Return repo.Consultar().
                Where(Function(est) est.TipoEstadoId = CInt(tipoestado)).
                OrderBy(Function(est) est.Nombre).
                ToList()
        End Using
    End Function

    Private Sub ValidarPerteneceATipoEstado(estado As Estado, tipoestado As TipoEstadoEnum)
        If estado.TipoEstadoId <> CInt(tipoestado) Then
            Throw New ExcepcionesdeNegocio($"El estado '{estado.Nombre}' no pertenece al tipo '{tipoestado}'.")
        End If
    End Sub

    Public Sub ValidarEstado(idestado As Integer, tipoestado As TipoEstadoEnum)
        Dim estado = ObtenerPorId(idestado)
        ValidarPerteneceATipoEstado(estado, tipoestado)
    End Sub

End Class
