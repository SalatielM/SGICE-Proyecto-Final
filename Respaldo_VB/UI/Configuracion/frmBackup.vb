Imports BBL
Imports MODELOS
Imports System.IO

Public Class frmBackup

    Private ReadOnly _backupservicios As New BackupServicios
    Private _backupSeleccionado As Backup

    Private Sub btnCrearExaminar_Click(sender As Object, e As EventArgs) Handles btnCrearExaminar.Click

        SaveFileDialog1.Filter = "Archivo de respaldo (*.bak)|*.bak"
        SaveFileDialog1.FileName = $"Copia de Seguridad {Date.Now:yyyy-MM-dd HH-mm}.bak"

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            txtRutaDestino.Text = SaveFileDialog1.FileName
            txtNombreArchivo.Text = Path.GetFileNameWithoutExtension(SaveFileDialog1.FileName)
        End If

    End Sub

    Private Sub btnCrearCopiaSeguridad_Click(sender As Object, e As EventArgs) Handles btnCrearCopiaSeguridad.Click

        Dim backup As New Backup()

        backup.Nombre = txtNombreArchivo.Text.Trim()
        backup.RutaBackup = txtRutaDestino.Text
        backup.FechaCreacion = Date.Now
        backup.UsuarioRegistroId = SesionActual.Usuario.IdUsuario

        _backupservicios.CrearBackup(backup)
        MessageBox.Show("Copia creada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        CargarBackups()

    End Sub

    Private Sub CargarBackups()

        dgvHistorialBackup.AutoGenerateColumns = False
        dgvHistorialBackup.DataSource = _backupservicios.ObtenerTodos()

    End Sub

    Private Sub btnRestaurarExaminar_Click(sender As Object, e As EventArgs) Handles btnRestaurarExaminar.Click

        OpenFileDialog1.Filter = "Backup (*.bak)|*.bak"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtArchivorRespaldo.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub btnRestaurarCopias_Click(sender As Object, e As EventArgs) Handles btnRestaurarCopias.Click

        _backupservicios.RestaurarBackup(txtArchivorRespaldo.Text)
        MessageBox.Show("Base de datos restaurada correctamente." & vbCrLf & "La aplicacion se reiniciara.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Application.Restart()
    End Sub

    Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarBackups()
    End Sub

End Class