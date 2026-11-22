Imports BBL
Imports MODELOS

Public Class frmAreas

    Private _idareaseleccionada As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ActualizarDGV()
        Dim servicio As New UbicacionServicios()
        dgvAreas.DataSource = servicio.ObtenerTodo()
    End Sub

    Private Sub CargarAreas()
        dgvAreas.AutoGenerateColumns = False
        Dim servicio As New UbicacionServicios()
        dgvAreas.DataSource = servicio.Listar()
    End Sub

    Private Sub CargarEdificio()
        Dim servicio As New EdificioServicios()
        cmbEdificio.DataSource = servicio.ObtenerTodos()
        cmbEdificio.ValueMember = "IdEdificio"
        cmbEdificio.DisplayMember = "Nombre"
        cmbEdificio.SelectedIndex = -1
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
        txtDimencion.Clear()
        rtxtDescipcion.Clear()
        txtPisos.Clear()

        cmbEdificio.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtNombre.ReadOnly = False
        txtDimencion.ReadOnly = False
        rtxtDescipcion.ReadOnly = False
        txtPisos.ReadOnly = False

        cmbEdificio.Enabled = True
        cmbEstado.Enabled = True
        btnGuardarActualizar.Enabled = True
    End Sub

    Private Sub DesacticarCampos()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        txtDimencion.ReadOnly = True
        txtDimencion.BackColor = Color.White
        txtDimencion.ForeColor = Color.Black
        rtxtDescipcion.ReadOnly = True
        rtxtDescipcion.BackColor = Color.White
        rtxtDescipcion.ForeColor = Color.Black
        txtPisos.ReadOnly = True
        txtPisos.BackColor = Color.White
        txtPisos.ForeColor = Color.Black

        cmbEstado.Enabled = False
        cmbEdificio.Enabled = False

        btnGuardarActualizar.Enabled = False
        btnActivarDesactivar.Enabled = False
        btnActivarDesactivar.Text = ""
        btnGuardarActualizar.Text = ""

        LimpiarCampos()
    End Sub

    Private Sub frmAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAreas()
        CargarEstados()
        CargarEdificio()
        DesacticarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvAreas.ClearSelection()
        _idareaseleccionada = 0
        ActivarCampos()
        btnGuardarActualizar.Text = "Guardar"
        btnActivarDesactivar.Enabled = False
        btnNuevo.Enabled = False
        btnNuevo.Text = ""
        btnActivarDesactivar.Text = ""
        LimpiarCampos()
    End Sub

    Private Sub dgvAreas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAreas.SelectionChanged
        LimpiarCampos()
        If dgvAreas.SelectedRows.Count = 0 Then Exit Sub
        ActivarCampos()

        Dim Fila = dgvAreas.SelectedRows(0)
        _idareaseleccionada = CInt(Fila.Cells("IdUbicacion").Value)

        txtNombre.Text = Fila.Cells("Nombre").Value.ToString
        txtDimencion.Text = Fila.Cells("Dimencion").Value.ToString
        rtxtDescipcion.Text = Fila.Cells("Descripcion").Value.ToString
        txtPisos.Text = CInt(Fila.Cells("Piso").Value)
        cmbEdificio.SelectedValue = Fila.Cells("EdificioId").Value
        cmbEstado.SelectedValue = Fila.Cells("EstadoId").Value

        If CInt(Fila.Cells("EstadoId").Value) = (EstadoGenerico.Activo) Then
            btnActivarDesactivar.Text = "Desactivar"
        Else
            btnActivarDesactivar.Text = "Activar"
        End If

        btnGuardarActualizar.Text = "Actualizar"
        btnActivarDesactivar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnGuardarActualizar_Click(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            Dim area As New Ubicacion With {
                .Nombre = txtNombre.Text,
                .Dimencion = txtDimencion.Text,
                .Piso = txtPisos.Text,
                .Descripcion = rtxtDescipcion.Text,
                .EstadoId = CInt(cmbEstado.SelectedValue),
                .EdificioId = CInt(cmbEdificio.SelectedValue)
            }

            Dim servicio As New UbicacionServicios()
            If _idareaseleccionada = 0 Then
                servicio.Agregar(area)
                MessageBox.Show("Area registrada correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                area.IdUbicacion = _idareaseleccionada
                servicio.Actualizar(area)
                MessageBox.Show("Area actualizada correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarAreas()
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
                MessageBox.Show("Debe seleccionar una area.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim servicio As New UbicacionServicios()
            Dim area = servicio.ObtenerPorId(_idareaseleccionada)
            Dim nuevoEtado As Integer
            Dim accion As String

            If area.EstadoId = CInt(EstadoGenerico.Activo) Then
                nuevoEtado = CInt(EstadoGenerico.Inactivo)
                accion = "desactivar"
            Else
                nuevoEtado = CInt(EstadoGenerico.Activo)
                accion = "activar"
            End If

            Dim respuesta = MessageBox.Show($"Desea {accion} esta area?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.No Then Exit Sub

            servicio.CambiarEstado(area.IdUbicacion, nuevoEtado)
            MessageBox.Show($"Area {accion}do correctamente.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarAreas()
            DesacticarCampos()

            btnGuardarActualizar.Text = "Guardar"
            btnNuevo.Enabled = True
            _idareaseleccionada = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New UbicacionServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarAreas()
        Else
            dgvAreas.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim servicio As New UbicacionServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarAreas()
        Else
            dgvAreas.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

End Class