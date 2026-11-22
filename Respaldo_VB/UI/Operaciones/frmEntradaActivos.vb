Imports System.Windows
Imports BBL
Imports DAO
Imports MODELOS

Public Class frmEntradaActivos

    Private _listaDetalle As List(Of DetalleEntradaDTO)
    Private _listaActivoFisico As List(Of ActivoFisicoDTO)
    Private _bsDetalle As New BindingSource()
    Private _bsActicoFisico As New BindingSource()

    Public Sub New()
        InitializeComponent()

        _listaDetalle = New List(Of DetalleEntradaDTO)
        _listaActivoFisico = New List(Of ActivoFisicoDTO)
    End Sub

    Private Sub frmEntradaActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConfigurarDGV()
        LimpiarCampos()

        Try
            Dim servicioEntrada As New EntradaServicios()
            Dim contexto As New AppDbContext()
            Dim proximoNumero = servicioEntrada.GenerarNumeroEntrada(contexto)
            txtNoEntrada.Text = proximoNumero.ToString("D5")
        Catch ex As Exception
            txtNoEntrada.Text = "Error"
        End Try
    End Sub

    Private Sub CargarCombos()
        Dim servicioActivo As New ActivoServicios()
        cmbActivo.DataSource = servicioActivo.ObtenerTodos()
        cmbActivo.DisplayMember = "Nombre"
        cmbActivo.ValueMember = "IdActivo"
        cmbActivo.SelectedIndex = -1

        Dim servicioUbicacion As New UbicacionServicios()
        Dim UbicacionId As DataGridViewComboBoxColumn = CType(dgvEditarActivoFisico.Columns("UbicacionId"), DataGridViewComboBoxColumn)
        UbicacionId.DataSource = servicioUbicacion.ObtenerTodo()
        UbicacionId.DisplayMember = "Nombre"
        UbicacionId.ValueMember = "IdUbicacion"
        UbicacionId.DataPropertyName = "UbicacionId"

        cmbDocReferencia.DataSource = [Enum].GetValues(GetType(TipoDocReferencia))
        cmbDocReferencia.SelectedIndex = -1
    End Sub

    Private Sub ConfigurarDGV()
        dgvDetalleEntrada.AutoGenerateColumns = False
        dgvEditarActivoFisico.AutoGenerateColumns = False

        _bsDetalle.DataSource = _listaDetalle
        _bsActicoFisico.DataSource = _listaActivoFisico

        dgvDetalleEntrada.DataSource = _bsDetalle
        dgvEditarActivoFisico.DataSource = _bsActicoFisico
    End Sub

    Private Sub ActualizarDGVDetalle()
        _bsDetalle.ResetBindings(False)
    End Sub

    Private Sub ActualizarDGVActivoFisico()
        _bsActicoFisico.ResetBindings(False)
    End Sub

    Private Sub LimpiarCampos()
        Try
            Dim servicioEntrada As New EntradaServicios()
            Dim contexto As New AppDbContext()
            Dim proximoNumero = servicioEntrada.GenerarNumeroEntrada(contexto)
            txtNoEntrada.Text = proximoNumero.ToString("D5")
        Catch ex As Exception
            txtNoEntrada.Text = "Error"
        End Try

        txtDocReferencia.Clear()
        rtxtObservaciones.Clear()
        dtpFecha.Value = DateTime.Now

        cmbActivo.SelectedIndex = -1
        txtCantidad.Clear()

        cmbDocReferencia.SelectedIndex = -1
        txtDocReferencia.Clear()

        _listaDetalle.Clear()
        _listaActivoFisico.Clear()

        ActualizarDGVDetalle()
        ActualizarDGVActivoFisico()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If cmbActivo.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un activo.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning)
                Exit Sub
            End If

            Dim cantidad As Integer

            If Not Integer.TryParse(txtCantidad.Text, cantidad) OrElse cantidad <= 0 Then
                MessageBox.Show("Debe ingresar una cantidad mayor a cero.", "Advertencia", MessageBoxButton.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim nuevoActivo As New DetalleEntradaDTO With {
                .ActivoId = CInt(cmbActivo.SelectedValue),
                .NombreActivo = cmbActivo.Text,
                .Cantidad = cantidad
                }

            Dim servicioEntrada As New EntradaServicios()
            servicioEntrada.AgregarDetalle(_listaDetalle, nuevoActivo)

            ActualizarDGVDetalle()
            cmbActivo.SelectedValue = -1
            txtCantidad.Clear()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEliminarFila_Click(sender As Object, e As EventArgs) Handles btnEliminarFila.Click
        If _listaDetalle Is Nothing OrElse _listaDetalle.Count = 0 Then
            MessageBox.Show("No hay activos en el detalle para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dgvDetalleEntrada.CurrentRow Is Nothing OrElse dgvDetalleEntrada.CurrentRow.IsNewRow Then
            MessageBox.Show("Selecciona un activo del detalle para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim detalleSeleccionado = CType(dgvDetalleEntrada.CurrentRow.DataBoundItem, DetalleEntradaDTO)
            If detalleSeleccionado Is Nothing Then Exit Sub

            Dim activoDetalle = _listaDetalle.FirstOrDefault(Function(d) d.ActivoId = detalleSeleccionado.ActivoId)
            If activoDetalle IsNot Nothing Then
                _listaDetalle.Remove(activoDetalle)
            End If

            _listaActivoFisico.RemoveAll(Function(af) af.ActivoId = detalleSeleccionado.ActivoId)

            ActualizarDGVDetalle()
            ActualizarDGVActivoFisico()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEditarFisicos_Click(sender As Object, e As EventArgs) Handles btnEditarFisicos.Click
        Try
            If dgvDetalleEntrada.CurrentRow Is Nothing OrElse dgvDetalleEntrada.CurrentRow.IsNewRow Then
                MessageBox.Show("Debe seleccionar un activo válido del detalle para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim detalleSel = CType(dgvDetalleEntrada.CurrentRow.DataBoundItem, DetalleEntradaDTO)

            If _listaActivoFisico.Any(Function(af) af.ActivoId = detalleSel.ActivoId) Then
                MessageBox.Show("Los activos físicos para este detalle ya fueron generados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim servicioEntrada As New EntradaServicios()
            Dim nuevosFisicos = servicioEntrada.GenerarActivosFisicosTemporales(detalleSel, _listaActivoFisico)
            _listaActivoFisico.AddRange(nuevosFisicos)

            ActualizarDGVActivoFisico()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardarEntrada_Click(sender As Object, e As EventArgs) Handles btnGuardarEntrada.Click
        Try
            Dim nuevaEntrada As New Entrada With {
                .ObservacionEntrada = rtxtObservaciones.Text,
                .FechaEntrada = dtpFecha.Value,
                .DocReferencia = CType(cmbDocReferencia.SelectedValue, TipoDocReferencia),
                .NoDocReferencia = txtDocReferencia.Text.Trim()
                }

            If cmbDocReferencia.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar el tipo de documento de referencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(txtDocReferencia.Text) Then
                MessageBox.Show("Debe ingresar el número del documento de referencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim servicioEntrada As New EntradaServicios()
            servicioEntrada.RegistrarEntrada(nuevaEntrada, _listaDetalle, _listaActivoFisico)

            MessageBox.Show("Entrada registrada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnLimparCampos_Click(sender As Object, e As EventArgs) Handles btnLimparCampos.Click
        Dim respuesta = MessageBox.Show("¿Estás seguro que desea limpiar todos los campos? Se perderán los detalles no guardados.", "Confirmación", MessageBoxButton.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            LimpiarCampos()
        End If
    End Sub

End Class