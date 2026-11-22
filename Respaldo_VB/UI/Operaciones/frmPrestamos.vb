Imports BBL
Imports MODELOS

Public Class frmPrestamos

    Private Sub frmPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSolicitantes()
        CargarSubCategorias()
        CargarPrestamos()
        dgvDetallePrestamos.AutoGenerateColumns = False
        dgvListaPrestamos.AutoGenerateColumns = False
    End Sub

    Private Sub CargarSolicitantes()
        Dim servicio As New PersonalServicios()

        Dim listaa = servicio.ObteneTodos().
            Where(Function(d) d.EstadoId = CInt(EstadoGenerico.Activo)).
                Select(Function(d) New With {
                .IdPersonal = d.IdPersonal,
                .NombreCompleto = $"{d.Nombre} {d.Apellido}"
            }).ToList()

        cmbPersonalSolicitante.DataSource = listaa
        cmbPersonalSolicitante.DisplayMember = "NombreCompleto"
        cmbPersonalSolicitante.ValueMember = "IdPersonal"
        cmbPersonalSolicitante.SelectedIndex = -1
    End Sub

    Private Sub CargarSubCategorias()
        Dim servicio As New SubCategoriaServicios()
        cmbTipoActivo.DataSource = servicio.ObtenerTodos()
        cmbTipoActivo.DisplayMember = "Nombre"
        cmbTipoActivo.ValueMember = "IdSubCategoria"
        cmbTipoActivo.SelectedIndex = -1
    End Sub

    Private Sub AgregarActivoGrid(activo As ActivoFisicoDTO)
        For Each fila As DataGridViewRow In dgvDetallePrestamos.Rows
            If Not fila.IsNewRow AndAlso CInt(fila.Cells("IdActivoFisico").Value) = activo.IdActivoFisico Then
                MessageBox.Show("Este activo ya fue agregado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        dgvDetallePrestamos.Rows.Add(
        activo.IdActivoFisico,
        activo.ActivoId,
        activo.Activo,
        activo.CodEtiquetaQR,
        activo.NumSerie,
        activo.SubCategoriaId,
        activo.SubCategoria,
        activo.MarcaId,
        activo.Marca,
        activo.EstadoId,
        activo.Estado)

        cmbActivosDisponibles.SelectedIndex = -1
    End Sub

    Private Sub btnEliminarFila_Click(sender As Object, e As EventArgs) Handles btnEliminarFila.Click
        If dgvDetallePrestamos.SelectedRows.Count = 0 Then Return
        dgvDetallePrestamos.Rows.Remove(dgvDetallePrestamos.SelectedRows(0))
    End Sub

    Private Sub CargarPrestamos()
        Dim servicio As New PrestamoServicios()
        dgvListaPrestamos.AutoGenerateColumns = False
        dgvListaPrestamos.DataSource = Nothing
        dgvListaPrestamos.DataSource = servicio.ListarDetalle()
    End Sub

    Private Sub btnRegistrarPrestamo_Click(sender As Object, e As EventArgs) Handles btnRegistrarPrestamo.Click
        Try
            Dim prestamo As New Prestamo With {
                .FechaPrestamo = dtpFechaPrestamo.Value.Date,
                .FechaLimite = dtpFechaFinalizacion.Value.Date,
                .EstadoId = CInt(EstadoPrestamo.Vigente),
                .PersonalSolicitanteId = CInt(cmbPersonalSolicitante.SelectedValue)
             }

            Dim detalle As New List(Of DetallePrestamo)

            For Each fila As DataGridViewRow In dgvDetallePrestamos.Rows
                If fila.IsNewRow Then Continue For
                detalle.Add(New DetallePrestamo With {
                    .ActivoFisicoId = CInt(fila.Cells("IdActivoFisico").Value)
                })
            Next

            Dim servicio As New PrestamoServicios()
            servicio.RegistrarPrestamo(prestamo, detalle)

            MessageBox.Show("Préstamo registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarFormulario()
            CargarPrestamos()

        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LimpiarFormulario()
        cmbPersonalSolicitante.SelectedIndex = -1
        cmbTipoActivo.SelectedIndex = -1
        cmbActivosDisponibles.DataSource = Nothing
        dgvDetallePrestamos.Rows.Clear()
        dtpFechaPrestamo.Value = Date.Today
        dtpFechaFinalizacion.Value = Date.Today
    End Sub

    Private Sub cmbTipoActivo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTipoActivo.SelectionChangeCommitted
        If cmbTipoActivo.SelectedIndex = -1 Then Exit Sub

        Dim idSubCategoria As Integer = CInt(cmbTipoActivo.SelectedValue)
        Dim servicio As New ActivoFisicoServicios()
        Dim activos = servicio.ListarDisponiblesPorSubCategoria(idSubCategoria)

        cmbActivosDisponibles.DataSource = activos
        cmbActivosDisponibles.DisplayMember = "Activo"
        cmbActivosDisponibles.ValueMember = "IdActivoFisico"
        cmbActivosDisponibles.SelectedIndex = -1
    End Sub

    Private Sub cmbActivosDisponibles_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbActivosDisponibles.SelectionChangeCommitted
        If cmbActivosDisponibles.SelectedIndex = -1 Then Exit Sub

        Dim activo As ActivoFisicoDTO = CType(cmbActivosDisponibles.SelectedItem, ActivoFisicoDTO)
        If activo Is Nothing Then Exit Sub

        AgregarActivoGrid(activo)
    End Sub

End Class