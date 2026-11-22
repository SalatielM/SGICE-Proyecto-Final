Imports BBL
Imports MODELOS

Public Class ucFiltroPersonal
    Implements IFiltroReportes

    Private ReadOnly _estadoServicios As New EstadoServicios
    Private ReadOnly _usuarioServicios As New UsuarioServicios
    Private ReadOnly _puestoServicios As New PuestoServicios

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        cmbEstado.DataSource = _estadoServicios.ObtenerPorTipo(TipoEstadoEnum.EstadoGenerico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1

        cmbPuesto.DataSource = _puestoServicios.ObtenerTodos()
        cmbPuesto.DisplayMember = "Nombre"
        cmbPuesto.ValueMember = "IdPuesto"
        cmbPuesto.SelectedIndex = -1

        cmbQuienRegistro.DataSource = _usuarioServicios.ObtenerTodos()
        cmbQuienRegistro.DisplayMember = "Nombre"
        cmbQuienRegistro.ValueMember = "IdUsuario"
        cmbQuienRegistro.SelectedIndex = -1

    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbEstado.SelectedIndex = -1
        cmbPuesto.SelectedIndex = -1
        cmbQuienRegistro.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbPuesto.SelectedIndex <> -1 Then
            dto.PuestoId = CInt(cmbPuesto.SelectedValue)
        End If

        If cmbEstado.SelectedIndex <> -1 Then
            dto.EstadoGenerico = CInt(cmbEstado.SelectedValue)
        End If

        If cmbQuienRegistro.SelectedIndex <> -1 Then
            dto.UsuarioRegistraId = CInt(cmbQuienRegistro.SelectedValue)
        End If

        Return dto

    End Function

End Class
