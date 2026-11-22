Imports BBL
Imports MODELOS

Public Class frmActivosFisicos

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub frmActivosFisicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            CargarDGV()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDGV()
        dgvControlActivoFisico.AutoGenerateColumns = False
        Dim servicio As New ActivoFisicoServicios()
        dgvControlActivoFisico.DataSource = servicio.Listar()
    End Sub

    Private Sub btnCargarBusqueda_Click(sender As Object, e As EventArgs) Handles btnCargarBusqueda.Click
        Try
            Dim textoBusqueda = txtBarraDeBusqueda.Text.Trim()
            Dim servicio As New ActivoFisicoServicios()
            Dim resultados = servicio.FiltrarActivosFisicos(etiquetaBusqueda:=textoBusqueda)
            dgvControlActivoFisico.DataSource = resultados
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBarraDeBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarraDeBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCargarBusqueda.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
        Try
            Dim activoId As Integer? = If(cmbActivo.SelectedValue IsNot Nothing AndAlso CInt(cmbActivo.SelectedValue) > 0, CInt(cmbActivo.SelectedValue), CType(Nothing, Integer?))
            Dim marcaId As Integer? = If(cmbMarca.SelectedValue IsNot Nothing AndAlso CInt(cmbMarca.SelectedValue) > 0, CInt(cmbMarca.SelectedValue), CType(Nothing, Integer?))
            Dim subCategoriaId As Integer? = If(cmbCategoria.SelectedValue IsNot Nothing AndAlso CInt(cmbCategoria.SelectedValue) > 0, CInt(cmbCategoria.SelectedValue), CType(Nothing, Integer?))
            Dim estadoId As Integer? = If(cmbEstado.SelectedValue IsNot Nothing AndAlso CInt(cmbEstado.SelectedValue) > 0, CInt(cmbEstado.SelectedValue), CType(Nothing, Integer?))
            Dim ubicacionId As Integer? = If(cmbUbicacion.SelectedValue IsNot Nothing AndAlso CInt(cmbUbicacion.SelectedValue) > 0, CInt(cmbUbicacion.SelectedValue), CType(Nothing, Integer?))

            Dim fechaRegistro As DateTime? = Nothing
            If dtpFechaAdquisicion.Checked Then
                fechaRegistro = dtpFechaAdquisicion.Value.Date
            End If

            Dim servicio As New ActivoFisicoServicios()
            Dim resultados = servicio.FiltrarActivosFisicos(
                activoId:=activoId,
                marcaId:=marcaId,
                fechaRegistro:=fechaRegistro,
                subCategoriaId:=subCategoriaId,
                estadoId:=estadoId,
                ubicacionId:=ubicacionId,
                etiquetaBusqueda:=txtBarraDeBusqueda.Text.Trim()
            )

            dgvControlActivoFisico.DataSource = resultados
        Catch ex As Exception
            MessageBox.Show("Error al aplicar filtros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarCombos()
        Dim servicioActivo As New ActivoServicios()
        cmbActivo.DataSource = servicioActivo.ObtenerTodos()
        cmbActivo.DisplayMember = "Nombre"
        cmbActivo.ValueMember = "IdActivo"
        cmbActivo.SelectedIndex = -1

        Dim servicioMarca As New MarcaServicios()
        cmbMarca.DataSource = servicioMarca.ObtenerTodo()
        cmbMarca.DisplayMember = "Nombre"
        cmbMarca.ValueMember = "IdMarca"
        cmbMarca.SelectedIndex = -1

        Dim servicioSubCategoria As New SubCategoriaServicios()
        cmbCategoria.DataSource = servicioSubCategoria.ObtenerTodos()
        cmbCategoria.DisplayMember = "Nombre"
        cmbCategoria.ValueMember = "IdSubCategoria"
        cmbCategoria.SelectedIndex = -1

        Dim servicioUbicacion As New UbicacionServicios()
        cmbUbicacion.DataSource = servicioUbicacion.ObtenerTodo()
        cmbUbicacion.DisplayMember = "Nombre"
        cmbUbicacion.ValueMember = "IdUbicacion"
        cmbUbicacion.SelectedIndex = -1

        Dim servicioEstado As New EstadoServicios()
        cmbEstado.DataSource = servicioEstado.ObtenerPorTipo(TipoEstadoEnum.ActivoFisico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1
    End Sub

    Private Sub btnLimpiarFiltro_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltro.Click
        Try
            cmbActivo.SelectedIndex = -1
            cmbMarca.SelectedIndex = -1
            cmbCategoria.SelectedIndex = -1
            cmbUbicacion.SelectedIndex = -1
            cmbEstado.SelectedIndex = -1

            txtBarraDeBusqueda.Clear()

            CargarDGV()
        Catch ex As Exception
            MessageBox.Show("Error al limpiar los filtros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerarCod_Click(sender As Object, e As EventArgs) Handles btnGenerarCod.Click
        If dgvControlActivoFisico.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un activo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim activo As ActivoFisicoDTO = CType(dgvControlActivoFisico.CurrentRow.DataBoundItem, ActivoFisicoDTO)

        Using frm As New frmCodigoQR(activo)
            frm.ShowDialog()
        End Using
    End Sub

End Class