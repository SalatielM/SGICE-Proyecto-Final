Imports BBL
Imports MODELOS

Public Class ucFiltroDevoluciones
    Implements IFiltroReportes

    Private ReadOnly _personalservicios As New PersonalServicios
    Private ReadOnly _usuarioservicios As New UsuarioServicios
    Private ReadOnly _estadoservicios As New EstadoServicios

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        cmbQuienRegistra.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1

    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbQuienRegistra.DataSource = _usuarioservicios.ObtenerTodos()
        cmbQuienRegistra.DisplayMember = "NombreUsuario"
        cmbQuienRegistra.ValueMember = "IdUsuario"
        cmbQuienRegistra.SelectedIndex = -1

        cmbEstado.DataSource = _estadoservicios.ObtenerPorTipo(TipoEstadoEnum.DetalleDevolucion)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbQuienRegistra.SelectedIndex <> -1 Then
            dto.UsuarioRegistraId = CInt(cmbQuienRegistra.SelectedValue)
        End If

        If cmbEstado.SelectedIndex <> -1 Then
            dto.EstadoPrestamoId = CInt(cmbEstado.SelectedValue)
        End If

        Return dto
    End Function
End Class
