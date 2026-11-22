Imports BBL
Imports MODELOS

Public Class frmTrasladoActivos

    Private _detalle As New List(Of DetalleTrasladoDTO)

    Public Sub New()
        InitializeComponent()
        CargarCombos()
    End Sub

    Private Sub CargarCombos()
        Dim servicioTraslado As New TrasladoServicios()
        Dim servicioDirector As New DirectorServicios()

        Dim lista = servicioTraslado.ObtenerUbicacionesDestino()

        UbicacionDestino.DisplayMember = "Nombre"
        UbicacionDestino.ValueMember = "IdUbicacion"
        UbicacionDestino.DataSource = lista

        Dim listaa = servicioDirector.ObtenerTodos().
            Where(Function(d) d.EstadoId = CInt(EstadoGenerico.Activo)).
                Select(Function(d) New With {
                .IdDirector = d.IdDirector,
                .NombreCompleto = $"{d.Nombre} {d.Apellido}"
            }).ToList()

        cmbQuienAutoriza.DataSource = listaa
        cmbQuienAutoriza.DisplayMember = "NombreCompleto"
        cmbQuienAutoriza.ValueMember = "IdDirector"
        cmbQuienAutoriza.SelectedIndex = -1

        cmbDocAutorizacion.DataSource = [Enum].GetValues(GetType(TipoDocAutorizacion))
        cmbDocAutorizacion.SelectedIndex = -1
    End Sub

    Private Sub btnCargarBusqueda_Click(sender As Object, e As EventArgs) Handles btnCargarBusqueda.Click
        Try
            If String.IsNullOrWhiteSpace(txtBarraBusqueda.Text) Then
                Throw New ExcepcionesdeNegocio("Debe escribir la etiqueta del activo para buscar.")
            End If

            Dim servicio As New TrasladoServicios()
            Dim dto = servicio.CrearDetalleDesdeActivo(txtBarraBusqueda.Text.Trim())

            servicio.AgregarDetalle(_detalle, dto)

            CargarGrid()

            txtBarraBusqueda.Clear()
            txtBarraBusqueda.Focus()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CargarGrid()
        dgvTrasladoActivo.Rows.Clear()

        For Each item In _detalle
            dgvTrasladoActivo.Rows.Add(
                item.ActivoFisicoId,
                item.ActivoId,
                item.NombreActivo,
                item.CodigoEtiqueta,
                item.CategoriaId,
                item.Categoria,
                item.MarcaId,
                item.Marca,
                item.NumSerie,
                item.UbicacionActualId,
                item.UbicacionActual,
                Nothing)
        Next
    End Sub

    Private Sub btnEliminarFila_Click(sender As Object, e As EventArgs) Handles btnEliminarFila.Click
        Try
            If dgvTrasladoActivo.CurrentRow Is Nothing Then
                Throw New ExcepcionesdeNegocio("Debe seleccionar una fila de la tabla.")
            End If

            Dim id As Integer = CInt(dgvTrasladoActivo.CurrentRow.Cells("IdActivoFisico").Value)

            Dim servicio As New TrasladoServicios()
            servicio.EliminarDetalle(_detalle, id)
            CargarGrid()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ActualizarDestinos()
        Dim servicio As New TrasladoServicios()
        Dim ubicaciones = servicio.ObtenerUbicacionesDestino()

        For i As Integer = 0 To dgvTrasladoActivo.Rows.Count - 1
            If dgvTrasladoActivo.Rows(i).Cells("UbicacionDestino").Value Is Nothing Then
                Throw New ExcepcionesdeNegocio($"Debe seleccionar un destino para el activo de la fila {i + 1}.")
            End If

            Dim idDestino = CInt(dgvTrasladoActivo.Rows(i).Cells("UbicacionDestino").Value)
            _detalle(i).UbicacionFinalId = idDestino

            Dim ubicacion = ubicaciones.First(Function(u) u.IdUbicacion = idDestino)
            _detalle(i).UbicacionFinal = ubicacion.Nombre
        Next
    End Sub

    Private Sub btnRegistrarTraslado_Click(sender As Object, e As EventArgs) Handles btnRegistrarTraslado.Click
        Try
            ActualizarDestinos()

            Dim traslado As New Traslado With {
            .RazonTraslado = rtxtMotivoTraslado.Text.Trim(),
            .AutorizadoPorId = CInt(cmbQuienAutoriza.SelectedValue),
            .DocAutorizacion = CType(CInt(cmbDocAutorizacion.SelectedValue), TipoDocAutorizacion),
            .NoDocAutorizacion = txtNoDocAutorizacion.Text.Trim()
            }

            Dim servicio As New TrasladoServicios()
            servicio.RegistrarTraslado(traslado, _detalle)

            MessageBox.Show("Traslado registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarFormulario()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LimpiarFormulario()
        txtBarraBusqueda.Clear()
        rtxtMotivoTraslado.Clear()
        _detalle.Clear()
        dgvTrasladoActivo.Rows.Clear()
        txtBarraBusqueda.Focus()
        cmbQuienAutoriza.SelectedIndex = -1
        cmbDocAutorizacion.SelectedIndex = -1
        txtNoDocAutorizacion.Clear()
    End Sub

End Class