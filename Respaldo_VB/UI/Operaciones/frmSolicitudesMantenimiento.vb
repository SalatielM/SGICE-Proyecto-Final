Imports BBL
Imports MODELOS
Imports System.Windows

Public Class frmSolicitudesMantenimiento

    Private _detalle As New List(Of DetalleSolicitudMantenimientoDTO)
    Private _activoSeleccionado As ActivoFisicoDTO

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub frmSolicitudesMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDetalleSolicitudes.AutoGenerateColumns = False
        dgvListaSolicitudes.AutoGenerateColumns = False

        Dim servicio As New SolicitudMantenimientoServicios()
        txtNumSolicitud.Text = servicio.ObtenerProximoNumeroSolicitud().ToString()
        CargarSolicitudes()
    End Sub

    Private Sub btnCargarBusqueda_Click(sender As Object, e As EventArgs) Handles btnCargarBusqueda.Click
        Try
            Dim servicio As New ActivoFisicoServicios()
            _activoSeleccionado = servicio.ObtenerDtoPorEtiqueta(txtBarraBusqueda.Text.Trim())

            txtActivo.Text = _activoSeleccionado.Activo
            txtCodEtiquetaQR.Text = _activoSeleccionado.CodEtiquetaQR
            txtNumSerie.Text = _activoSeleccionado.NumSerie
            txtMarca.Text = _activoSeleccionado.Marca
            txtUbicacion.Text = _activoSeleccionado.Ubicacion
            txtEstado.Text = _activoSeleccionado.Estado
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If _activoSeleccionado Is Nothing Then
                Throw New ExcepcionesdeNegocio("Debe Buscar un activo")
            End If

            Dim detalloSoli As New DetalleSolicitudMantenimientoDTO With {
                .ActivoFisicoId = _activoSeleccionado.IdActivoFisico,
                .ActivoId = _activoSeleccionado.ActivoId,
                .Activo = _activoSeleccionado.Activo,
                .CodEtiquetaQR = _activoSeleccionado.CodEtiquetaQR,
                .NumSerie = _activoSeleccionado.NumSerie,
                .MarcaId = _activoSeleccionado.MarcaId,
                .Marca = _activoSeleccionado.Marca,
                .SubCategoriaId = _activoSeleccionado.SubCategoriaId,
                .SubCategoria = _activoSeleccionado.SubCategoria,
                .EstadoId = _activoSeleccionado.EstadoId,
                .Estado = _activoSeleccionado.Estado,
                .Ubicacion = _activoSeleccionado.Ubicacion,
                .DescripcionProblema = rtxtDecripcionProblema.Text.Trim()
             }

            Dim servicio As New SolicitudMantenimientoServicios()
            servicio.AgregarDetalle(_detalle, detalloSoli)

            dgvDetalleSolicitudes.DataSource = Nothing
            dgvDetalleSolicitudes.DataSource = _detalle
            LimpiarDatosActivo()
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LimpiarDatosActivo()
        _activoSeleccionado = Nothing
        txtBarraBusqueda.Clear()
        txtActivo.Clear()
        txtCodEtiquetaQR.Clear()
        txtNumSerie.Clear()
        txtMarca.Clear()
        txtUbicacion.Clear()
        txtEstado.Clear()
        rtxtDecripcionProblema.Clear()
        rtxtObservacionGeneral.Clear()
        txtBarraBusqueda.Focus()
    End Sub

    Private Sub LimpiarFormulario()
        Dim servicio As New SolicitudMantenimientoServicios()
        txtNumSolicitud.Text = servicio.ObtenerProximoNumeroSolicitud().ToString()
        txtBarraBusqueda.Clear()
        txtNumSerie.Clear()
        rtxtObservacionGeneral.Clear()
        LimpiarDatosActivo()
        _detalle.Clear()
        dgvDetalleSolicitudes.DataSource = Nothing
    End Sub

    Private Sub CargarSolicitudes()
        Dim servicio As New SolicitudMantenimientoServicios()
        dgvListaSolicitudes.DataSource = Nothing
        dgvListaSolicitudes.DataSource = servicio.Listar()
    End Sub

    Private Sub btnRegistrarSolicitud_Click(sender As Object, e As EventArgs) Handles btnRegistrarSolicitud.Click
        Try
            Dim solicitud As New SolicitudMantenimiento With {
                 .ObservacionGeneral = rtxtObservacionGeneral.Text.Trim(),
                 .FechaSolicitud = Date.Now
            }

            Dim servicio As New SolicitudMantenimientoServicios()
            servicio.RegistrarSolicitud(solicitud, _detalle)

            MessageBox.Show("Solicitud registrada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarSolicitudes()
            LimpiarFormulario()
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEliminarFila_Click(sender As Object, e As EventArgs) Handles btnEliminarFila.Click
        Try
            If dgvDetalleSolicitudes.CurrentRow Is Nothing Then
                Throw New ExcepcionesdeNegocio("Debe elegir la fila con el activo que quiere eliminar")
            End If

            Dim dto = CType(dgvDetalleSolicitudes.CurrentRow.DataBoundItem, DetalleSolicitudMantenimientoDTO)
            If dto Is Nothing Then
                Throw New ExcepcionesdeNegocio("Debe elegir la fila con el activo que quiere eliminar")
            End If

            Dim servicio As New SolicitudMantenimientoServicios()
            servicio.EliminarDetalle(_detalle, dto.ActivoFisicoId)

            dgvDetalleSolicitudes.DataSource = Nothing
            dgvDetalleSolicitudes.DataSource = _detalle
        Catch ex As ExcepcionesdeNegocio
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnLimparCampos_Click(sender As Object, e As EventArgs) Handles btnLimparCampos.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea limpiar los campos? Se perderán las informaciones previas.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.No Then Exit Sub

        rtxtObservacionGeneral.Clear()
        txtBarraBusqueda.Clear()
        txtActivo.Clear()
        txtCodEtiquetaQR.Clear()
        txtNumSerie.Clear()
        txtMarca.Clear()
        txtUbicacion.Clear()
        txtEstado.Clear()
        rtxtDecripcionProblema.Clear()

        If _detalle IsNot Nothing Then _detalle.Clear()

        dgvDetalleSolicitudes.DataSource = Nothing
        dgvDetalleSolicitudes.DataSource = _detalle
        txtNumSolicitud.Focus()
    End Sub

End Class