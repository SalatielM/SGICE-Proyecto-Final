Imports BBL
Imports MODELOS

Public Class ucFiltroSalidas
    Implements IFiltroReportes

    Private ReadOnly _usuarioServicios As New UsuarioServicios

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        cmbUsuarioRegistra.DataSource = _usuarioServicios.ObtenerTodos()
        cmbUsuarioRegistra.DisplayMember = "Nombre"
        cmbUsuarioRegistra.ValueMember = "IdUsuario"
        cmbUsuarioRegistra.SelectedIndex = -1

        cmbMotivoSalida.DataSource = [Enum].GetValues(GetType(MotivoSalida))
        cmbMotivoSalida.SelectedIndex = -1

    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbUsuarioRegistra.SelectedIndex = -1
        cmbMotivoSalida.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbUsuarioRegistra.SelectedIndex <> -1 Then
            dto.UsuarioRegistraId = CInt(cmbUsuarioRegistra.SelectedValue)
        End If

        Return dto

    End Function
End Class
