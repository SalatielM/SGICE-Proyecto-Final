Imports BBL
Imports MODELOS

Public Class frmCambiarContrasena

    Private ReadOnly _usuarioServicios As UsuarioServicios
    Private ReadOnly _idUsuario As Integer

    Public Sub New(idUsuario As Integer)

        InitializeComponent()
        _usuarioServicios = New UsuarioServicios()
        _idUsuario = idUsuario

    End Sub
    Public Sub frmCambiarContrasena_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim usuario = _usuarioServicios.ObtenerPorId(_idUsuario)
        txtUsuario.Text = usuario.NombreUsuario
        txtUsuario.ReadOnly = True
        txtUsuario.ForeColor = Color.Black
        txtUsuario.BackColor = Color.White

    End Sub

    Private Sub LimpiarCampos()

        txtClaveActual.Clear()
        txtClaveNueva.Clear()
        txtClaveActual.Focus()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCambiarClave_Click(sender As Object, e As EventArgs) Handles btnCambiarClave.Click

        Try

            Dim respuesta = MessageBox.Show("¿Desea cambiar la contraseña de este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.No Then Exit Sub

            Dim cerrarSesion As Boolean = _usuarioServicios.CambiarClave(_idUsuario, txtClaveActual.Text, txtClaveNueva.Text)
            If cerrarSesion Then

                MessageBox.Show("La contraseña fue cambiada correctamente. La aplicacion se reiniciara.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Application.Restart()
                Environment.Exit(0)
                Return

            End If

            MessageBox.Show("La contraseña fue cambiada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

End Class