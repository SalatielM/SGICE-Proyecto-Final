Imports DAO
Imports MODELOS

Public Class BackupServicios

    Private ReadOnly repo As New RepositorioBackup()

    Public Sub CrearBackup(backup As Backup)
        repo.CrearBackup(backup.RutaBackup)
        repo.Registrar(backup)
    End Sub

    Public Sub RestaurarBackup(ruta As String)
        repo.RestaurarBackup(ruta)
    End Sub

    Public Function ObtenerTodos() As List(Of Backup)
        Return repo.ObtenerTodos()
    End Function

    Public Function ObtenerPorRuta(ruta As String) As Backup
        Return repo.ObtenerPorRuta(ruta)
    End Function

    Public Function ObtenerPorId(id As Integer) As Backup
        Return repo.ObtenerPorId(id)
    End Function

End Class
