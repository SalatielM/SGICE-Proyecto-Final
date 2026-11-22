Imports BBL
Imports MODELOS

Public Class frmUsuario

    Private _idusuarioseleccionado As Integer = 0

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub ActualizarDGV()
        Dim servicio As New UsuarioServicios()
        dgvUsuarios.DataSource = servicio.ObtenerTodos()
    End Sub

    Private Sub CargarUsuarios()
        Dim servicio As New UsuarioServicios()
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvUsuarios.AutoGenerateColumns = False
        dgvUsuarios.DataSource = servicio.Listar()
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CargarRoles()
        Dim servicio As New Rolservicios()
        cmbRol.DataSource = servicio.ObtenerTodos()
        cmbRol.DisplayMember = "Nombre"
        cmbRol.ValueMember = "IdRol"
    End Sub

    Private Sub CargarEstados()
        Dim servicio As New EstadoServicios()
        cbmEstado.DataSource = servicio.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cbmEstado.DisplayMember = "Nombre"
        cbmEstado.ValueMember = "IdEstado"
    End Sub

    Private Sub LimppiarCampos()
        txtUsuario.Clear()
        txtContrasena.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCedula.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        picFotoUsuario.Image = Nothing

        cbmEstado.SelectedIndex = -1
        cmbRol.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtUsuario.ReadOnly = False
        txtContrasena.ReadOnly = False
        txtNombre.ReadOnly = False
        txtApellido.ReadOnly = False
        txtCedula.ReadOnly = False
        txtTelefono.ReadOnly = False
        txtCorreo.ReadOnly = False

        cbmEstado.Enabled = True
        cmbRol.Enabled = True

        btnGuardarActualizar.Enabled = True

    End Sub

    Private Sub DesactivarCampos()
        txtUsuario.ReadOnly = True
        txtUsuario.BackColor = Color.White
        txtUsuario.ForeColor = Color.Black
        txtContrasena.ReadOnly = True
        txtContrasena.BackColor = Color.White
        txtContrasena.ForeColor = Color.Black
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        txtApellido.ReadOnly = True
        txtApellido.BackColor = Color.White
        txtApellido.ForeColor = Color.Black
        txtCedula.ReadOnly = True
        txtCedula.BackColor = Color.White
        txtCedula.ForeColor = Color.Black
        txtTelefono.ReadOnly = True
        txtTelefono.BackColor = Color.White
        txtTelefono.ForeColor = Color.Black
        txtCorreo.ReadOnly = True
        txtCorreo.BackColor = Color.White
        txtCorreo.ForeColor = Color.Black

        cbmEstado.Enabled = False
        cmbRol.Enabled = False

        btnGuardarActualizar.Enabled = False
        btnGuardarActualizar.Text = ""
        btnActivarDesactivar.Enabled = False
        btnActivarDesactivar.Text = ""

        LimppiarCampos()
    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRoles()
        CargarEstados()
        CargarUsuarios()
        DesactivarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvUsuarios.ClearSelection()
        _idusuarioseleccionado = 0
        ActivarCampos()
        btnGuardarActualizar.Text = "Guardar"
        btnActivarDesactivar.Enabled = False
        btnNuevo.Enabled = False
        btnActivarDesactivar.Text = ""
        btnNuevo.Text = ""
        LimppiarCampos()
    End Sub

    Private Sub btnGuardarActualizar_Click(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            Dim usuario As New Usuario With {
                .NombreUsuario = txtUsuario.Text,
                .Nombre = txtNombre.Text,
                .Apellido = txtApellido.Text,
                .Cedula = txtCedula.Text,
                .Telefono = txtTelefono.Text,
                .Correo = txtCorreo.Text,
                .RolId = CInt(cmbRol.SelectedValue),
                .EstadoId = CInt(cbmEstado.SelectedValue),
                .Foto = ManejoDeFotos.ImagenABytes(picFotoUsuario.Image)
             }

            Dim servicio As New UsuarioServicios()

            If _idusuarioseleccionado = 0 Then
                usuario.ClaveHash = txtContrasena.Text
                servicio.Agregar(usuario)
                MessageBox.Show("Usuario registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                usuario.IdUsuario = _idusuarioseleccionado
                servicio.Actualizar(usuario)
                MessageBox.Show("Usuario actualizado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarUsuarios()
            DesactivarCampos()
            btnNuevo.Enabled = True
            btnNuevo.Text = "Nuevo"
            _idusuarioseleccionado = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnActivarDesactivar_Click(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            If _idusuarioseleccionado = 0 Then
                MessageBox.Show("Debe seleccionar un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim servicio As New UsuarioServicios()
            Dim usuario = servicio.ObtenerPorId(_idusuarioseleccionado)
            Dim nuevoEstado As Integer
            Dim accion As String

            If usuario.EstadoId = CInt(EstadoGenerico.Activo) Then
                nuevoEstado = CInt(EstadoGenerico.Inactivo)
                accion = "desactivar"
            Else
                nuevoEstado = CInt(EstadoGenerico.Activo)
                accion = "activar"
            End If

            Dim respuesta = MessageBox.Show($"¿Desea {accion} este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.No Then Exit Sub

            servicio.CambiarEstado(usuario.IdUsuario, nuevoEstado)
            MessageBox.Show($"Usuario {accion}do correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarUsuarios()
            DesactivarCampos()

            btnGuardarActualizar.Text = "Guardar"
            btnNuevo.Enabled = True
            _idusuarioseleccionado = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAgregarFoto_Click(sender As Object, e As EventArgs) Handles btnAgregarFoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                picFotoUsuario.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub dgvUsuarios_SelectionChanged_1(sender As Object, e As EventArgs) Handles dgvUsuarios.SelectionChanged
        LimppiarCampos()
        If dgvUsuarios.SelectedRows.Count = 0 Then Exit Sub
        ActivarCampos()

        Dim Fila = dgvUsuarios.SelectedRows(0)
        Dim usuario = CType(Fila.DataBoundItem, UsuarioDTO)
        picFotoUsuario.Image = ManejoDeFotos.BytesAImagen(usuario.Foto)

        _idusuarioseleccionado = CInt(Fila.Cells("IdUsuario").Value)

        txtUsuario.Text = Fila.Cells("NombreUsuario").Value.ToString
        txtNombre.Text = Fila.Cells("Nombre").Value.ToString
        txtApellido.Text = Fila.Cells("Apellido").Value.ToString
        txtCedula.Text = Fila.Cells("Cedula").Value.ToString
        txtTelefono.Text = Fila.Cells("Telefono").Value.ToString
        txtCorreo.Text = Fila.Cells("Correo").Value.ToString

        cmbRol.SelectedValue = Fila.Cells("RolId").Value
        cbmEstado.SelectedValue = Fila.Cells("EstadoId").Value

        If CInt(Fila.Cells("EstadoId").Value) = EstadoGenerico.Activo Then
            btnActivarDesactivar.Text = "Desactivar"
        Else
            btnActivarDesactivar.Text = "Activar"
        End If

        txtContrasena.Clear()

        btnGuardarActualizar.Text = "Actualizar"
        btnGuardarActualizar.Enabled = True
        btnActivarDesactivar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnCambiarClave_Click(sender As Object, e As EventArgs) Handles btnCambiarClave.Click
        If _idusuarioseleccionado = 0 Then
            MessageBox.Show("Debe seleccionar un usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using frm As New frmCambiarContrasena(_idusuarioseleccionado)
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New UsuarioServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarUsuarios()
        Else
            dgvUsuarios.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub
End Class