Imports BBL
Imports MODELOS

Public Class frmSubCategorias

    Private _idsubcategoriaSeleccionado As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub CargarSubCategorias()
        dgvSubCategorias.AutoGenerateColumns = False
        Dim servicio As New SubCategoriaServicios()
        dgvSubCategorias.DataSource = servicio.Listar()
    End Sub

    Public Sub CargarCategorias()
        Dim servicio As New CategoriaServicios()
        cmbCategoria.DataSource = servicio.ObtenerTodos()
        cmbCategoria.DisplayMember = "Nombre"
        cmbCategoria.ValueMember = "IdCategoria"
    End Sub

    Public Sub CargarEstados()
        Dim servicio As New EstadoServicios()
        cmbEstado.DataSource = servicio.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        rtxtDescipcion.Clear()
        txtVidaUtil.Clear()
        cmbCategoria.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub ActivarCampos()
        txtNombre.ReadOnly = False
        rtxtDescipcion.ReadOnly = False
        txtVidaUtil.ReadOnly = False
        cmbCategoria.Enabled = True
        cmbEstado.Enabled = True
        btnGuardarActualizar.Enabled = True
    End Sub

    Private Sub DesactivarCampos()
        txtNombre.ReadOnly = True
        txtNombre.BackColor = Color.White
        txtNombre.ForeColor = Color.Black
        rtxtDescipcion.ReadOnly = True
        rtxtDescipcion.BackColor = Color.White
        rtxtDescipcion.ForeColor = Color.Black
        txtVidaUtil.ReadOnly = True
        txtVidaUtil.BackColor = Color.White
        txtVidaUtil.ForeColor = Color.Black
        cmbCategoria.Enabled = False
        cmbEstado.Enabled = False
        btnGuardarActualizar.Enabled = False
        btnActivarDesactivar.Enabled = False
        btnActivarDesactivar.Text = ""
        btnGuardarActualizar.Text = ""
        LimpiarCampos()
    End Sub

    Private Sub frmSubCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSubCategorias()
        CargarCategorias()
        CargarEstados()
        DesactivarCampos()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgvSubCategorias.ClearSelection()
        _idsubcategoriaSeleccionado = 0
        ActivarCampos()
        btnGuardarActualizar.Text = "Guardar"
        btnActivarDesactivar.Enabled = False
        btnNuevo.Enabled = False
        btnNuevo.Text = ""
        LimpiarCampos()
    End Sub

    Private Sub btnGuardarActualizar_Click(sender As Object, e As EventArgs) Handles btnGuardarActualizar.Click
        Try
            If String.IsNullOrWhiteSpace(txtVidaUtil.Text) OrElse Not IsNumeric(txtVidaUtil.Text) Then
                Throw New ExcepcionesdeNegocio("Debe especificar un valor numérico válido para la vida útil.")
            End If

            Dim subCat As New SubCategoria With {
                .Nombre = txtNombre.Text,
                .Descripcion = rtxtDescipcion.Text,
                .VidaUtil = CInt(txtVidaUtil.Text),
                .CategoriaId = CInt(cmbCategoria.SelectedValue),
                .EstadoId = CInt(cmbEstado.SelectedValue)
             }

            Dim servicio As New SubCategoriaServicios()
            If _idsubcategoriaSeleccionado = 0 Then
                servicio.Agregar(subCat)
                MessageBox.Show("Subcategoría registrada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                subCat.IdSubCategoria = _idsubcategoriaSeleccionado
                servicio.Actualizar(subCat)
                MessageBox.Show("Subcategoría actualizada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarSubCategorias()
            DesactivarCampos()
            btnNuevo.Enabled = True
            btnNuevo.Text = "Nuevo"
            _idsubcategoriaSeleccionado = 0
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub dgvSubCategorias_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSubCategorias.SelectionChanged
        LimpiarCampos()
        If dgvSubCategorias.SelectedRows.Count = 0 Then Exit Sub
        ActivarCampos()

        Dim Fila = dgvSubCategorias.SelectedRows(0)
        _idsubcategoriaSeleccionado = CInt(Fila.Cells("IdSubCategoria").Value)

        txtNombre.Text = If(Fila.Cells("Nombre").Value, "").ToString
        rtxtDescipcion.Text = If(Fila.Cells("Descripcion").Value, "").ToString
        txtVidaUtil.Text = If(Fila.Cells("VidaUtil").Value?.ToString(), "")

        If Fila.Cells("CategoriaId").Value IsNot Nothing Then
            cmbCategoria.SelectedValue = Fila.Cells("CategoriaId").Value
        Else
            cmbCategoria.SelectedIndex = -1
        End If

        If Fila.Cells("EstadoId").Value IsNot Nothing Then
            cmbEstado.SelectedValue = Fila.Cells("EstadoId").Value
        Else
            cmbEstado.SelectedIndex = -1
        End If

        btnActivarDesactivar.Text = If(CInt(Fila.Cells("EstadoId").Value) = EstadoGenerico.Activo, "Desactivar", "Activar")
        btnGuardarActualizar.Text = "Actualizar"
        btnActivarDesactivar.Enabled = True
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnActivarDesactivar_Click(sender As Object, e As EventArgs) Handles btnActivarDesactivar.Click
        Try
            Dim servicio As New SubCategoriaServicios()
            Dim subCategoria = servicio.ObtenerPorId(_idsubcategoriaSeleccionado)
            Dim nuevoEstado = If(subCategoria.EstadoId = CInt(EstadoGenerico.Activo), CInt(EstadoGenerico.Inactivo), CInt(EstadoGenerico.Activo))
            Dim accion = If(nuevoEstado = CInt(EstadoGenerico.Activo), "activar", "desactivar")

            If MessageBox.Show($"¿Desea {accion} esta subcategoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                servicio.CambiarEstado(subCategoria.IdSubCategoria, nuevoEstado)
                CargarSubCategorias()
                DesactivarCampos()
            End If
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim servicio As New SubCategoriaServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarSubCategorias()
        Else
            dgvSubCategorias.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim servicio As New SubCategoriaServicios()
        If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
            CargarSubCategorias()
        Else
            dgvSubCategorias.DataSource = servicio.BuscarPorNombre(txtBarraBusqueda.Text)
        End If
    End Sub

End Class