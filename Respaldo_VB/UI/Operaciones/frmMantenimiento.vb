Imports BBL
Imports MODELOS

Public Class frmMantenimiento

    Private _detalle As List(Of DetalleMantenimientoDTO)
    Private _idSolicitudSeleccionada As Integer = 0

    Public Sub New()
        InitializeComponent()
        _detalle = New List(Of DetalleMantenimientoDTO)
    End Sub

    Private Sub CargarSolicitudes()
        Dim servicio As New MantenimientoServicios()
        dgvSolicitudesPendientes.AutoGenerateColumns = False
        dgvSolicitudesPendientes.DataSource = servicio.ListarSolicitudesPendientes()
    End Sub

    Private Sub CargarTecnicos()
        Dim servicio As New PersonalServicios()

        Dim listaa = servicio.ObteneTodos().
            Where(Function(p) p.EstadoId = CInt(EstadoGenerico.Activo)).
                Select(Function(p) New With {
                .IdPersonal = p.IdPersonal,
                .NombreCompleto = $"{p.Nombre} {p.Apellido}"
            }).ToList()

        cmbPersonalTecnico.DataSource = listaa
        cmbPersonalTecnico.DisplayMember = "NombreCompleto"
        cmbPersonalTecnico.ValueMember = "IdPersonal"
        cmbPersonalTecnico.SelectedIndex = -1
    End Sub

    Private Sub CargarEstadosDetalle()
        EstadoDetalleId.Items.Clear()
        EstadoDetalleId.Items.Add(New With {.Id = CInt(EstadoDetalleMantenimiento.EnProceso), .Nombre = "EnProceso"})
        EstadoDetalleId.Items.Add(New With {.Id = CInt(EstadoDetalleMantenimiento.Reparado), .Nombre = "Reparado"})
        EstadoDetalleId.Items.Add(New With {.Id = CInt(EstadoDetalleMantenimiento.NoReparado), .Nombre = "No Reparado"})

        EstadoDetalleId.DisplayMember = "Nombre"
        EstadoDetalleId.ValueMember = "Id"
        EstadoDetalleId.DataPropertyName = "EstadoDetalleId"
    End Sub

    Private Sub ActualizarDetalle()
        Dim servicio As New MantenimientoServicios()
        dgvMantenimiento.AutoGenerateColumns = False
        dgvMantenimiento.DataSource = Nothing
        _detalle = servicio.ObtenerDetalleSolicitud(_idSolicitudSeleccionada)
        dgvMantenimiento.DataSource = _detalle
    End Sub

    Private Sub LimpiarCampos()
        _idSolicitudSeleccionada = 0
        _detalle.Clear()
        dgvMantenimiento.DataSource = Nothing
        cmbPersonalTecnico.SelectedIndex = -1
        dgvSolicitudesPendientes.ClearSelection()
    End Sub

    Private Sub frmMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSolicitudesPendientes.AutoGenerateColumns = False
        dgvMantenimiento.AutoGenerateColumns = False
        CargarSolicitudes()
        CargarTecnicos()
        CargarEstadosDetalle()
    End Sub

    Private Sub dgvSolicitudesPendientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSolicitudesPendientes.SelectionChanged
        If dgvSolicitudesPendientes.SelectedRows.Count = 0 Then Exit Sub
        Dim fila = dgvSolicitudesPendientes.SelectedRows(0)
        _idSolicitudSeleccionada = CInt(fila.Cells("IdSolicitudMantenimiento").Value)
    End Sub

    Private Sub btnAplicarDetalle_Click(sender As Object, e As EventArgs) Handles btnAplicarDetalle.Click
        Try
            If _idSolicitudSeleccionada = 0 Then
                Throw New ExcepcionesdeNegocio("Debe seleccionar una solicitud.")
            End If
            ActualizarDetalle()
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click
        Try
            If _idSolicitudSeleccionada = 0 Then
                Throw New ExcepcionesdeNegocio("Debe seleccionar una solicitud.")
            End If

            Dim respuesta = MessageBox.Show("¿Desea rechazar esta solicitud?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.No Then Exit Sub

            Dim servicio As New MantenimientoServicios()
            servicio.RechazarSolicitud(_idSolicitudSeleccionada)
            MessageBox.Show("Solicitud rechazada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarSolicitudes()
            LimpiarCampos()
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnRegistrarMatenimiento_Click(sender As Object, e As EventArgs) Handles btnRegistrarMatenimiento.Click
        Try
            Dim mantenimiento As New Mantenimiento With {
                .SolicitudMantenimientoId = _idSolicitudSeleccionada,
                .PersonalTecnicoId = CInt(cmbPersonalTecnico.SelectedValue)
            }

            Dim servicio As New MantenimientoServicios()
            servicio.RegistrarMantenimiento(mantenimiento, _detalle)

            MessageBox.Show("Mantenimiento registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarSolicitudes()
            LimpiarCampos()
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea limpiar los campos? Se perderán las informaciones previas.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            LimpiarCampos()
        End If
    End Sub

End Class