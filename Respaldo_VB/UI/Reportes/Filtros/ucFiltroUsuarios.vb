Imports BBL
Imports MODELOS

Public Class ucFiltroUsuarios
    Implements IFiltroReportes

    Private ReadOnly _estadoServicios As New EstadoServicios
    Private ReadOnly _usuarioServicios As New UsuarioServicios
    Private ReadOnly _rolServicios As New Rolservicios

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        cmbEstado.DataSource = _estadoServicios.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1

        cmbRol.DataSource = _rolServicios.ObtenerTodos()
        cmbRol.DisplayMember = "Nombre"
        cmbRol.ValueMember = "IdRol"
        cmbRol.SelectedIndex = -1

        cmbUsuarioRegistra.DataSource = _usuarioServicios.ObtenerTodos()
        cmbUsuarioRegistra.DisplayMember = "Nombre"
        cmbUsuarioRegistra.ValueMember = "IdUsuario"
        cmbUsuarioRegistra.SelectedIndex = -1

    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbEstado.SelectedIndex = -1
        cmbRol.SelectedIndex = -1
        cmbUsuarioRegistra.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbRol.SelectedIndex <> -1 Then
            dto.RolId = CInt(cmbRol.SelectedValue)
        End If

        If cmbEstado.SelectedIndex <> -1 Then
            dto.EstadoGenerico = CInt(cmbEstado.SelectedValue)
        End If

        If cmbUsuarioRegistra.SelectedIndex <> -1 Then
            dto.UsuarioRegistraId = CInt(cmbUsuarioRegistra.SelectedValue)
            Return dto
        End If

        Return dto

    End Function

End Class
