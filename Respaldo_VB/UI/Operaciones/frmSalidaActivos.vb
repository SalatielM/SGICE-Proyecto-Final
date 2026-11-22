Imports System.ComponentModel
Imports BBL
Imports DAO
Imports MODELOS

Public Class frmSalidaActivos

    Private _listaDetallesTemporales As New BindingList(Of DetalleSalidaDTO)()
    Private _activoBuscado As ActivoFisicoDTO

    Private Sub frmSalidaActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDGV()
        InicializarFormulario()
        cmbMotivo.DataSource = [Enum].GetValues(GetType(MotivoSalida))
        cmbMotivo.SelectedIndex = -1
    End Sub

    Private Sub InicializarFormulario()
        Dim servicio As New SalidaServicios()
        Dim contexto As New AppDbContext()
        txtNumSalida.Text = servicio.GeneranNumeroSalida(contexto).ToString("D6")

        txtNumSalida.ReadOnly = True
        dtpFechaSalida.Value = DateTime.Now
        dtpFechaSalida.Enabled = False
        rtxtObservaciones.Clear()

        LimpiarCamposBusqueda()
        _listaDetallesTemporales.Clear()


        Dim camposReadOnly As Control() = {txtActivo, txtEtiqueda, txtNumSerie, txtNumSalida, txtUbicacion, txtEstado}
        For Each ctrl As Control In camposReadOnly
            If TypeOf ctrl Is TextBox Then
                Dim txt = CType(ctrl, TextBox)
                txt.ReadOnly = True
                txt.BackColor = Color.White
                txt.ForeColor = Color.Black
            End If
        Next
    End Sub

    Private Sub ActualizarDGV()
        dgvDetalleSalida.AutoGenerateColumns = False
        dgvDetalleSalida.DataSource = _listaDetallesTemporales
    End Sub

    Private Sub LimpiarCamposBusqueda()
        txtBarraBusqueda.Clear()
        txtActivo.Clear()
        txtEtiqueda.Clear()
        txtNumSerie.Clear()
        txtUbicacion.Clear()
        txtEstado.Clear()
        _activoBuscado = Nothing
        txtBarraBusqueda.Focus()
        cmbMotivo.SelectedIndex = -1
    End Sub

    Private Sub txtBotonCargarBusqueda_Click(sender As Object, e As EventArgs) Handles txtBotonCargarBusqueda.Click
        Try
            Dim criterioBusqueda = txtBarraBusqueda.Text.Trim()

            If String.IsNullOrWhiteSpace(criterioBusqueda) Then
                MessageBox.Show("Por favor, ingrese un código de etiqueta o número de serie.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim servicio As New ActivoFisicoServicios()
            _activoBuscado = servicio.ObtenerDtoPorEtiqueta(criterioBusqueda)

            If _activoBuscado Is Nothing Then
                MessageBox.Show("No se encontró ningún activo con esa etiqueta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCamposBusqueda()
                Return
            End If

            txtActivo.Text = _activoBuscado.Activo
            txtEtiqueda.Text = _activoBuscado.CodEtiquetaQR
            txtNumSerie.Text = _activoBuscado.NumSerie
            txtUbicacion.Text = _activoBuscado.Ubicacion
            txtEstado.Text = _activoBuscado.Estado

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        Dim respuesta = MessageBox.Show("¿Está seguro de que desea limpiar todos los datos? Se borrará la lista de activos agregados.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            InicializarFormulario()
        End If
    End Sub

    Private Sub btnAgregarAlDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarAlDetalle.Click
        Try
            If _activoBuscado Is Nothing Then
                MessageBox.Show("Debe buscar y seleccionar un activo antes de agregarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If cmbMotivo.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un motivo de salida para cada activo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim nuevoDetalle As New DetalleSalidaDTO With {
                .ActivoFisicoId = _activoBuscado.IdActivoFisico,
                .ActivoFisico = _activoBuscado.Activo,
                .CodEtiquetaQR = _activoBuscado.CodEtiquetaQR,
                .NumSerie = _activoBuscado.NumSerie,
                .UbicacionId = _activoBuscado.UbicacionId,
                .Ubicacion = _activoBuscado.Ubicacion,
                .EstadoId = _activoBuscado.EstadoId,
                .Estado = _activoBuscado.Estado,
                .MotivoSalida = DirectCast(cmbMotivo.SelectedItem, MotivoSalida)
            }

            Dim listaTemporal As List(Of DetalleSalidaDTO) = _listaDetallesTemporales.ToList()

            Dim servicio As New SalidaServicios()
            servicio.AgregarDetalle(listaTemporal, nuevoDetalle)

            _listaDetallesTemporales.Add(nuevoDetalle)
            LimpiarCamposBusqueda()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LimpiarCamposBusqueda()
        End Try
    End Sub

    Private Sub btnEliminarFila_Click(sender As Object, e As EventArgs) Handles btnEliminarFila.Click
        Try
            If dgvDetalleSalida.CurrentRow Is Nothing Then
                MessageBox.Show("Debe seleccionar la fila que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim detalleSeleccionado = CType(dgvDetalleSalida.CurrentRow.DataBoundItem, DetalleSalidaDTO)
            _listaDetallesTemporales.Remove(detalleSeleccionado)
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un problema al intentar eliminar la fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardarSalida_Click(sender As Object, e As EventArgs) Handles btnGuardarSalida.Click
        Try
            If _listaDetallesTemporales.Count = 0 Then
                MessageBox.Show("Debe agregar al menos un activo a la lista antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirmacion = MessageBox.Show("¿Está seguro que desea registrar esta salida?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmacion = DialogResult.No Then Return

            Dim nuevaSalida As New Salida With {
                .Observaciones = rtxtObservaciones.Text.Trim()
            }

            Dim servicio As New SalidaServicios()
            servicio.RegistrarSalida(nuevaSalida, _listaDetallesTemporales.ToList())

            MessageBox.Show("¡La Salida se registró correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            InicializarFormulario()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class