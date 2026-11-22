Imports BBL
Imports MODELOS

Public Class frmMarcas

    Private _idmarcaseleccionada As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ActualizarDGV()
        Dim servicio As New MarcaServicios()
        dgvMarcas.DataSource = servicio.ObtenerTodo()
    End Sub

    Private Sub CargarMarcas()
        dgvMarcas.AutoGenerateColumns = False
        Dim servicio As New MarcaServicios()
        dgvMarcas.DataSource = servicio.Listar()
    End Sub

    Private Sub CargarEstados()
        Dim servicio As New EstadoServicios()
        cmbEstado.DataSource = servicio.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        rtxtDescripcion.Clear()
        txtBarraBusqueda.Clear()

        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtNombre.ReadOnly = False
        rtxtDescripcion.ReadOnly = False

        cmbEstado.Enabled = True
    End Sub

    Private Sub DesactivarCampos()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        rtxtDescripcion.ReadOnly = True
        rtxtDescripcion.BackColor = Color.White
        rtxtDescripcion.ForeColor = Color.Black

        cmbEstado.Enabled = False

        btnActivarDesactivar.Enabled = False
        btnGuardarActualizar.Enabled = False
        btnActivarDesactivar.Text = ""
        btnGuardarActualizar.Text = ""

        LimpiarCampos()
    End Sub

    Private Sub frmMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMarcas()
        CargarEstados()
        DesactivarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvMarcas.ClearSelection()
        _idmarcaseleccionada = 0
        ActivarCampos()
        btnGuardarActualizar.Text = "Guardar"
        btnGuardarActualizar.Enabled = True
        btnNuevo.Enabled = False
        btnNuevo.Text = ""
        btnActivarDesactivar.Text = ""
        LimpiarCampos()
    End Sub

    Private Sub dgvMarcas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMarcas.SelectionChanged
        LimpiarCampos()
        If dgvMarcas.SelectedRows.Count = 0 Then Exit Sub
        ActivarCampos()

        Dim Fila As DataGridViewRow = dgvMarcas.SelectedRows(0)
        _idmarcaseleccionada = CInt(Fila.Cells("IdMarca").Value)

        txtNombre.Text = Fila.Cells("Nombre").Value.ToString()
        rtxtDescripcion.Text = Fila.Cells("Descripcion").Value.ToString()
        cmbEstado.SelectedValue = Fila.Cells("EstadoId").Value

        If CInt(Fila.Cells("EstadoId").Value) = CInt(EstadoGenerico.Activo) Then
            btnActivarDesactivar.Text = "Desactivar"
        Else
            btnActivarDesactivar.Text = "Activar"
        End If

        btnGuardarActualizar.Text = "Actualizar"
        btnActivarDesactivar.Enabled = True
        btnGuardarActualizar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnGuardarActualizar_Click(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            Dim marca As New Marca With {
                .Nombre = txtNombre.Text,
                .Descripcion = rtxtDescripcion.Text,
                .EstadoId = CInt(cmbEstado.SelectedValue)
                }

            Dim servicio As New MarcaServicios()
            If _idmarcaseleccionada = 0 Then
                servicio.Agregar(marca)
                MessageBox.Show("Marca registrada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                marca.IdMarca = _idmarcaseleccionada
                servicio.Actualizar(marca)
                MessageBox.Show("Marca actualizada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarMarcas()
            DesactivarCampos()
            btnNuevo.Text = "Nuevo"
            btnNuevo.Enabled = True
            _idmarcaseleccionada = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnActivarDesactivar_Click(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            If _idmarcaseleccionada = 0 Then
                MessageBox.Show("Debe seleccionar una marca.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim servicio As New MarcaServicios()
            Dim marca = servicio.ObtenerPorId(_idmarcaseleccionada)
            Dim nuevoEstado As Integer
            Dim accion As String

            If marca.EstadoId = CInt(EstadoGenerico.Activo) Then
                nuevoEstado = CInt(EstadoGenerico.Inactivo)
                accion = "desactivar"
            Else
                nuevoEstado = CInt(EstadoGenerico.Activo)
                accion = "activar"
            End If

            Dim respuesta = MessageBox.Show($"¿Desea {accion} esta marca?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.No Then Exit Sub

            servicio.CambiarEstado(marca.IdMarca, nuevoEstado)
            MessageBox.Show($"Marca {accion}da correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarMarcas()
            DesactivarCampos()

            btnGuardarActualizar.Text = "Guardar"
            btnNuevo.Enabled = True
            _idmarcaseleccionada = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim servicio As New MarcaServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarMarcas()
        Else
            dgvMarcas.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New MarcaServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarMarcas()
        Else
            dgvMarcas.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

End Class