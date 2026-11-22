Imports BBL
Imports MODELOS

Public Class ucFiltroTraslados
    Implements IFiltroReportes

    Private ReadOnly _ubicacionServicios As New UbicacionServicios
    Private ReadOnly _usuarioServicios As New UsuarioServicios
    Private ReadOnly _estadoServicios As New EstadoServicios

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        cmbUbicacionOrigen.SelectedValue = _ubicacionServicios.ObtenerTodo()
        cmbUbicacionOrigen.DisplayMember = "Nombre"
        cmbUbicacionOrigen.ValueMember = "IdUbicacion"

        cmbUbicacionDestino.SelectedValue = _ubicacionServicios.ObtenerTodo()
        cmbUbicacionDestino.DisplayMember = "Nombre"
        cmbUbicacionDestino.ValueMember = "IdUbicacion"

        cmbQuienRegistro.SelectedValue = _ubicacionServicios.ObtenerTodo()
        cmbQuienRegistro.DisplayMember = "Nombre"
        cmbQuienRegistro.ValueMember = "IdUsuario"

    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbUbicacionOrigen.SelectedIndex = -1
        cmbUbicacionDestino.SelectedIndex = -1
        cmbQuienRegistro.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbQuienRegistro.SelectedIndex <> -1 Then
            dto.UbicacionOrigenId = CInt(cmbQuienRegistro.SelectedValue)
        End If

        If cmbUbicacionOrigen.SelectedIndex <> -1 Then
            dto.UbicacionDestinoId = CInt(cmbUbicacionOrigen.SelectedValue)
        End If

        If cmbQuienRegistro.SelectedIndex <> -1 Then
            dto.UsuarioRegistraId = CInt(cmbQuienRegistro.SelectedValue)
        End If

        Return dto

    End Function
End Class
