Imports BBL
Imports MODELOS

Public Class ucFiltroMantenimiento
    Implements IFiltroReportes

    Private ReadOnly _activoServicios As New ActivoServicios
    Private ReadOnly _estadoServicioas As New EstadoServicios
    Private ReadOnly _activoFisicoServicios As New ActivoFisicoServicios
    Private ReadOnly _marcaServicios As New MarcaServicios
    Private ReadOnly _personalServicios As New PersonalServicios
    Private ReadOnly _usuarioServicios As New UsuarioServicios

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        cmbActivo.DataSource = _activoServicios.ObtenerTodos()
        cmbActivo.DisplayMember = "Nombre"
        cmbActivo.ValueMember = "IdActivo"
        cmbActivo.SelectedIndex = -1

        cmbEstado.DataSource = _estadoServicioas.ObtenerPorTipo(TipoEstadoEnum.Mantenimiento)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1

        cmbEtiqueta.DataSource = _activoFisicoServicios.ObtenerTodo()
        cmbEtiqueta.DisplayMember = "CodEtiquetaQR"
        cmbEtiqueta.ValueMember = "IdActivoFisico"
        cmbEtiqueta.SelectedIndex = -1

        cmbMarca.DataSource = _marcaServicios.ObtenerTodo()
        cmbMarca.DisplayMember = "Nombre"
        cmbMarca.ValueMember = "IdMarca"
        cmbMarca.SelectedIndex = -1

        cmbPersonalResponsable.DataSource = _personalServicios.ObteneTodos()
        cmbPersonalResponsable.DisplayMember = "Nombre"
        cmbPersonalResponsable.ValueMember = "IdPersonal"
        cmbPersonalResponsable.SelectedIndex = -1

        cmbQuienRegistra.DataSource = _usuarioServicios.ObtenerTodos()
        cmbQuienRegistra.DisplayMember = "Nombre"
        cmbQuienRegistra.ValueMember = "IdUsuario"
        cmbQuienRegistra.SelectedIndex = -1


    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbActivo.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
        cmbEtiqueta.SelectedIndex = -1
        cmbMarca.SelectedIndex = -1
        cmbPersonalResponsable.SelectedIndex = -1
        cmbQuienRegistra.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbPersonalResponsable.SelectedIndex <> -1 Then
            dto.PersonalId = CInt(cmbPersonalResponsable.SelectedValue)
        End If

        If cmbQuienRegistra.SelectedIndex <> -1 Then
            dto.UsuarioRegistraId = CInt(cmbQuienRegistra.SelectedValue)
        End If

        If cmbEstado.SelectedIndex <> -1 Then
            dto.EstadoMantenimientoId = CInt(cmbEstado.SelectedValue)
        End If

        If cmbActivo.SelectedIndex <> -1 Then
            dto.ActivoId = CInt(cmbActivo.SelectedValue)
        End If

        If cmbEtiqueta.SelectedIndex <> -1 Then
            dto.CodEtiquetaQR = CInt(cmbEtiqueta.SelectedValue)
        End If

        If cmbMarca.SelectedIndex <> -1 Then
            dto.MarcaId = CInt(cmbMarca.SelectedValue)
        End If

        Return dto

    End Function
End Class
