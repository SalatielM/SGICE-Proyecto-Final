Imports BBL
Imports MODELOS

Public Class frmPuestos

    Private _idareaseleccionada As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ActualizarDGV()
        Dim servicio As New PuestoServicios()
        dgvPuestos.DataSource = servicio.ObtenerTodos()
    End Sub

    Private Sub CargarPuestos()
        dgvPuestos.AutoGenerateColumns = False
        Dim servicio As New PuestoServicios()
        dgvPuestos.DataSource = servicio.Listar()
    End Sub

    Private Sub CargarEstados()
        Dim servicio As New EstadoServicios()
        cmbEstado.DataSource = servicio.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        rtxtDescipcion.Clear()
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtNombre.ReadOnly = False
        rtxtDescipcion.ReadOnly = False
        cmbEstado.Enabled = True
    End Sub

    Private Sub DesacticarCampos()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        rtxtDescipcion.ReadOnly = True
        rtxtDescipcion.BackColor = Color.White
        rtxtDescipcion.ForeColor = Color.Black

        cmbEstado.Enabled = False

        btnGuardarActualizar.Enabled = False
        btnActivarDesactivar.Enabled = False
        btnActivarDesactivar.Text = ""
        btnGuardarActualizar.Text = ""
    End Sub

    Private Sub frmAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPuestos()
        CargarEstados()
        DesacticarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvPuestos.ClearSelection()
        _idareaseleccionada = 0
        ActivarCampos()
        btnGuardarActualizar.Text = "Guardar"
        btnActivarDesactivar.Enabled = False
        btnNuevo.Enabled = False
        btnGuardarActualizar.Enabled = True
        btnNuevo.Text = ""
        btnActivarDesactivar.Text = ""
        LimpiarCampos()
    End Sub

    Private Sub dgvAreas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPuestos.SelectionChanged
        LimpiarCampos()
        If dgvPuestos.SelectedRows.Count = 0 Then Exit Sub
        ActivarCampos()
        Dim Fila As DataGridViewRow = dgvPuestos.SelectedRows(0)

        _idareaseleccionada = CInt(Fila.Cells("IdPuesto").Value)

        txtNombre.Text = Fila.Cells("Nombre").Value.ToString()
        rtxtDescipcion.Text = Fila.Cells("Descripcion").Value.ToString()

        cmbEstado.SelectedValue = Fila.Cells("EstadoId").Value
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

    Private Sub btnGuardarActualizar_Click(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            Dim puesto As New Puesto With {
                .Nombre = txtNombre.Text,
                .Descripcion = rtxtDescipcion.Text,
                .EstadoId = CInt(cmbEstado.SelectedValue)
            }

            Dim servicio As New PuestoServicios()
            If _idareaseleccionada = 0 Then
                servicio.Agregar(puesto)
                MessageBox.Show("Puesto registrado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                puesto.IdPuesto = _idareaseleccionada
                servicio.Actualizar(puesto)
                MessageBox.Show("Puesto actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarPuestos()
            DesacticarCampos()
            btnNuevo.Text = "Nuevo"
            btnNuevo.Enabled = True
            _idareaseleccionada = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnActivarDesactivar_Click(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            If _idareaseleccionada = 0 Then
                MessageBox.Show("Debe seleccionar un puesto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim servicio As New PuestoServicios()
            Dim puesto = servicio.ObtenerPorId(_idareaseleccionada)
            Dim nuevoEtado As Integer
            Dim accion As String

            If puesto.EstadoId = CInt(EstadoGenerico.Activo) Then
                nuevoEtado = CInt(EstadoGenerico.Inactivo)
                accion = "desactivar"
            Else
                nuevoEtado = CInt(EstadoGenerico.Activo)
                accion = "activar"
            End If

            Dim respuesta = MessageBox.Show($"¿Desea {accion} este puesto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.No Then Exit Sub

            servicio.CambiarEstado(puesto.IdPuesto, nuevoEtado)
            MessageBox.Show($"Puesto {accion}do correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarPuestos()
            DesacticarCampos()

            btnGuardarActualizar.Text = "Guardar"
            btnNuevo.Enabled = True
            _idareaseleccionada = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim servicio As New PuestoServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarPuestos()
        Else
            dgvPuestos.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New PuestoServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarPuestos()
        Else
            dgvPuestos.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

End Class