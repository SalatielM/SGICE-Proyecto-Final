Imports DAO
Imports Microsoft.EntityFrameworkCore
Imports MODELOS

Public Class Rolservicios

    Public Sub New()

    End Sub

    Public Function ObtenerTodos() As List(Of Rol)
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Rol)(ctx)
            Return repo.ObtenerTodos().ToList()
        End Using
    End Function

    Public Function ObteberPorId(idrol As Integer) As Rol
        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Rol)(ctx)
            Dim rol = repo.ObtenerPorId(idrol)

            If rol Is Nothing Then
                Throw New ExcepcionesdeNegocio("El rol seleccionado no existe")
            End If
            Return rol
        End Using
    End Function

    Public Function ObtenerPorNombre(nombrerol As String) As Rol
        If String.IsNullOrEmpty(nombrerol) Then
            Throw New ArgumentNullException(NameOf(nombrerol))
        End If

        nombrerol = nombrerol.Trim().ToLower()

        Using ctx As New AppDbContext()
            Dim repo As New RepositorioGenerico(Of Rol)(ctx)
            Dim rol = repo.Consultar().
                FirstOrDefault(Function(r) r.Nombre.ToLower() = nombrerol)

            If rol Is Nothing Then
                Throw New ExcepcionesdeNegocio("No existe rol con ese nombre")
            End If
            Return rol
        End Using
    End Function

    Public Sub ValidarRol(idrol As Integer)
        ObteberPorId(idrol)
    End Sub

End Class
