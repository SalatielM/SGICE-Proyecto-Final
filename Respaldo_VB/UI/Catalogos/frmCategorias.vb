Imports BBL
Imports MODELOS

Public Class frmCategorias

    Private _idcategoriaseleccionda As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ActualizarDGV()
        Dim servicio As New CategoriaServicios()
        dgvCategoria.DataSource = servicio.ObtenerTodos()
    End Sub

    Private Sub CargarCategorias()
        dgvCategoria.AutoGenerateColumns = False
        Dim servicio As New CategoriaServicios()
        dgvCategoria.DataSource = servicio.Listar()
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
        txtVidaUtil.Clear()

        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtNombre.ReadOnly = False
        rtxtDescipcion.ReadOnly = False
        txtVidaUtil.ReadOnly = False

        cmbEstado.Enabled = True

        btnGuardarActualizar.Enabled = True
    End Sub

    Private Sub DesacticarCampos()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        rtxtDescipcion.ReadOnly = True
        rtxtDescipcion.BackColor = Color.White
        rtxtDescipcion.ForeColor = Color.Black
        txtVidaUtil.ReadOnly = True
        txtVidaUtil.BackColor = Color.White
        txtVidaUtil.ForeColor = Color.Black

        cmbEstado.Enabled = False

        btnGuardarActualizar.Enabled = False
        btnActivarDesactivar.Enabled = False
        btnActivarDesactivar.Text = ""
        btnGuardarActualizar.Text = ""
    End Sub

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
        CargarEstados()
        DesacticarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvCategoria.ClearSelection()
        _idcategoriaseleccionda = 0
        ActivarCampos()
        btnGuardarActualizar.Text = "Guardar"
        btnNuevo.Enabled = False
        btnGuardarActualizar.Enabled = True
        btnNuevo.Text = ""
        btnActivarDesactivar.Text = ""
        LimpiarCampos()
    End Sub

    Private Sub dgvCategoria_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCategoria.SelectionChanged
        LimpiarCampos()
        If dgvCategoria.SelectedRows.Count = 0 Then Exit Sub
        ActivarCampos()
        Dim Fila As DataGridViewRow = dgvCategoria.SelectedRows(0)

        _idcategoriaseleccionda = CInt(Fila.Cells("IdCategoria").Value)

        txtNombre.Text = Fila.Cells("Nombre").Value.ToString()
        rtxtDescipcion.Text = Fila.Cells("Descripcion").Value.ToString()
        txtVidaUtil.Text = Fila.Cells("VidaUtil").Value.ToString()

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
            Dim categoria As New Categoria With {
                .Nombre = txtNombre.Text,
                .Descripcion = rtxtDescipcion.Text,
                .VidaUtil = txtVidaUtil.Text,
                .EstadoId = CInt(cmbEstado.SelectedValue)
            }

            Dim servicio As New CategoriaServicios()
            If _idcategoriaseleccionda = 0 Then
                servicio.Agregar(categoria)
                MessageBox.Show("Categoria registrada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                categoria.IdCategoria = _idcategoriaseleccionda
                servicio.Actualizar(categoria)
                MessageBox.Show("Categoria actualizada correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarCategorias()
            DesacticarCampos()
            btnNuevo.Enabled = True
            btnNuevo.Text = "Nuevo"
            _idcategoriaseleccionda = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnActivarDesactivar_Click(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            If _idcategoriaseleccionda = 0 Then
                MessageBox.Show("Debe seleccionar una categoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim servicio As New CategoriaServicios()
            Dim categoria = servicio.ObtenerPorId(_idcategoriaseleccionda)
            Dim nuevoEtado As Integer
            Dim accion As String

            If categoria.EstadoId = CInt(EstadoGenerico.Activo) Then
                nuevoEtado = CInt(EstadoGenerico.Inactivo)
                accion = "desactivar"
            Else
                nuevoEtado = CInt(EstadoGenerico.Activo)
                accion = "activar"
            End If

            Dim respuesta = MessageBox.Show($"¿Desea {accion} esta categoría?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuesta = DialogResult.No Then Exit Sub

            servicio.CambiarEstado(categoria.IdCategoria, nuevoEtado)
            MessageBox.Show($"Categoria {accion}do correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarCategorias()
            DesacticarCampos()

            btnGuardarActualizar.Text = "Guardar"
            btnNuevo.Enabled = True
            _idcategoriaseleccionda = 0

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click
        Dim servicio As New CategoriaServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarCategorias()
        Else
            dgvCategoria.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New CategoriaServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarCategorias()
        Else
            dgvCategoria.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

End Class