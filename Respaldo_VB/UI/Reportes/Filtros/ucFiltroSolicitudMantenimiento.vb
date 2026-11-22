Imports BBL
Imports MODELOS

Public Class ucFiltroSolicitudMantenimiento
    Implements IFiltroReportes

    Private ReadOnly _activoServicios As New ActivoServicios()
    Private ReadOnly _usuarioServicios As New UsuarioServicios()

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        cmbActivo.DataSource = _activoServicios.ObtenerTodos()
        cmbActivo.DisplayMember = "Nombre"
        cmbActivo.ValueMember = "IdActivo"
        cmbActivo.SelectedIndex = -1

        cmbQuienRegistra.DataSource = _usuarioServicios.ObtenerTodos()
        cmbQuienRegistra.DisplayMember = "Nombre"
        cmbQuienRegistra.ValueMember = "IdUsuario"
        cmbQuienRegistra.SelectedIndex = -1

    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbActivo.SelectedIndex = -1
        cmbQuienRegistra.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbQuienRegistra.SelectedIndex <> -1 Then
            dto.UsuarioRegistraId = CInt(cmbQuienRegistra.SelectedValue)
        End If

        If cmbActivo.SelectedIndex <> -1 Then
            dto.ActivoId = CInt(cmbActivo.SelectedValue)
        End If
        Return dto

    End Function
End Class
