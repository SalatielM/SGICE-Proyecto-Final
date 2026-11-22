Imports BBL
Imports MODELOS

Public Class frmPersonal

    Private _idpersonalseleccionado As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ActualizarDGV()
        Dim servicio As New PersonalServicios()
        dgvPersonal.DataSource = servicio.ObteneTodos()
    End Sub

    Private Sub CargarPersonal()
        Dim servicio As New PersonalServicios()
        dgvPersonal.AutoGenerateColumns = False
        dgvPersonal.DataSource = servicio.Listar()
    End Sub

    Private Sub CargarEstados()
        Dim servicio As New EstadoServicios()
        cmbEstado.DataSource = servicio.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
    End Sub

    Private Sub CargarPuestos()
        Dim servicio As New PuestoServicios()
        cmbPuesto.DataSource = servicio.ObtenerTodos()
        cmbPuesto.DisplayMember = "Nombre"
        cmbPuesto.ValueMember = "IdPuesto"
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCodPersonal.Clear()
        txtCedula.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()

        picFotoPersonal.Image = Nothing

        cmbEstado.SelectedIndex = -1
        cmbPuesto.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtNombre.ReadOnly = False
        txtApellido.ReadOnly = False
        txtCodPersonal.ReadOnly = False
        txtCedula.ReadOnly = False
        txtTelefono.ReadOnly = False
        txtCorreo.ReadOnly = False

        cmbEstado.Enabled = True
        cmbPuesto.Enabled = True

        btnGuardarActualizar.Enabled = True
    End Sub

    Public Sub DesactivarCampos()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        txtApellido.ReadOnly = True
        txtApellido.BackColor = Color.White
        txtApellido.ForeColor = Color.Black
        txtCodPersonal.ReadOnly = True
        txtCodPersonal.BackColor = Color.White
        txtCodPersonal.ForeColor = Color.Black
        txtCedula.ReadOnly = True
        txtCedula.BackColor = Color.White
        txtCedula.ForeColor = Color.Black
        txtTelefono.ReadOnly = True
        txtTelefono.BackColor = Color.White
        txtTelefono.ForeColor = Color.Black
        txtCorreo.ReadOnly = True
        txtCorreo.BackColor = Color.White
        txtCorreo.ForeColor = Color.Black

        cmbEstado.Enabled = True
        cmbPuesto.Enabled = True

        btnGuardarActualizar.Enabled = False
        btnActivarDesactivar.Enabled = False
        btnActivarDesactivar.Text = ""
        btnGuardarActualizar.Text = ""

        LimpiarCampos()
    End Sub

    Private Sub frmPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPersonal()
        CargarPuestos()
        CargarEstados()
        DesactivarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvPersonal.ClearSelection()
        _idpersonalseleccionado = 0
        ActivarCampos()
        btnActivarDesactivar.Enabled = True
        btnGuardarActualizar.Text = "Guardar"
        btnNuevo.Enabled = False
        btnGuardarActualizar.Enabled = True
        btnNuevo.Text = ""
        btnActivarDesactivar.Text = ""

        LimpiarCampos()
    End Sub

    Private Sub dgvPersonal_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPersonal.SelectionChanged
        LimpiarCampos()
        If dgvPersonal.SelectedRows.Count = 0 Then Exit Sub
        ActivarCampos()

        Dim Fila As DataGridViewRow = dgvPersonal.SelectedRows(0)
        Dim personal As PersonalDTO = CType(Fila.DataBoundItem, PersonalDTO)
        picFotoPersonal.Image = ManejoDeFotos.BytesAImagen(personal.Foto)

        _idpersonalseleccionado = CInt(Fila.Cells("IdPersonal").Value)

        txtNombre.Text = Fila.Cells("Nombre").Value.ToString()
        txtApellido.Text = Fila.Cells("Apellido").Value.ToString()
        txtCodPersonal.Text = Fila.Cells("CodPersonal").Value.ToString()
        txtCedula.Text = Fila.Cells("Cedula").Value.ToString()
        txtTelefono.Text = Fila.Cells("Telefono").Value.ToString()
        txtCorreo.Text = Fila.Cells("Correo").Value.ToString()

        cmbEstado.SelectedValue = Fila.Cells("EstadoId").Value
        cmbPuesto.SelectedValue = Fila.Cells("PuestoId").Value

        If CInt(Fila.Cells("EstadoId").Value) = CInt(EstadoGenerico.Activo) Then
            btnActivarDesactivar.Text = "Desactivar"
        Else
            btnActivarDesactivar.Text = "Activar"
        End If

        btnGuardarActualizar.Text = "Actualizar"
        btnGuardarActualizar.Enabled = True
        btnActivarDesactivar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                picFotoPersonal.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub btnGuardarActualizar_Click_1(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            Dim personal As New Personal With {
                .Nombre = txtNombre.Text,
                .Apellido = txtApellido.Text,
                .CodPersonal = txtCodPersonal.Text,
                .Cedula = txtCedula.Text,
                .Telefono = txtTelefono.Text,
                .Correo = txtCorreo.Text,
                .PuestoId = cmbPuesto.SelectedValue,
                .EstadoId = cmbEstado.SelectedValue,
                .Foto = ManejoDeFotos.ImagenABytes(picFotoPersonal.Image)
             }

            Dim servicio As New PersonalServicios()

            If _idpersonalseleccionado = 0 Then
                servicio.Agregar(personal)
                MessageBox.Show("Personal registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                personal.IdPersonal = _idpersonalseleccionado
                servicio.Actualizar(personal)
                MessageBox.Show("Personal actualizado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarPersonal()
            DesactivarCampos()
            btnNuevo.Enabled = True
            btnNuevo.Text = "Nuevo"
            _idpersonalseleccionado = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnActivarDesactivar_Click_1(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            If _idpersonalseleccionado = 0 Then
                MessageBox.Show("Debe seleccionar un personal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim servicio As New PersonalServicios()
            Dim personal = servicio.ObtenerPorId(_idpersonalseleccionado)
            Dim nuevoEstado As Integer
            Dim accion As String

            If personal.EstadoId = EstadoGenerico.Activo Then
                nuevoEstado = EstadoGenerico.Inactivo
                accion = "desactivar"
            Else
                nuevoEstado = EstadoGenerico.Activo
                accion = "activar"
            End If

            Dim respuesta = MessageBox.Show($"¿Desea {accion} este personal?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.No Then Exit Sub

            servicio.CambiarEstado(personal.IdPersonal, nuevoEstado)
            MessageBox.Show($"Personal {accion}do correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarPersonal()
            DesactivarCampos()

            btnNuevo.Enabled = True
            _idpersonalseleccionado = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New PersonalServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarPersonal()
        Else
            dgvPersonal.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

End Class