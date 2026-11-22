Imports BBL
Imports MODELOS

Public Class frmLogin

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Try
            Dim servicio As New UsuarioServicios()
            Dim usuario As Usuario
            usuario = servicio.IniciarSesion(txtUsuarioLogin.Text, txtContrasenaLogin.Text)

            Me.Hide()

            Using menu As New frmMenuPrincipal()
                menu.ShowDialog()
            End Using

            SesionActual.CerrarSesion()

            txtUsuarioLogin.Clear()
            txtContrasenaLogin.Clear()
            txtUsuarioLogin.Focus()

            Me.Show()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnSalirLogin_Click(sender As Object, e As EventArgs) Handles btnSalirLogin.Click
        Application.Exit()
    End Sub

End Class
