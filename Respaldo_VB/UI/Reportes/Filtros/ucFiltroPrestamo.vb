Imports MODELOS
Imports BBL

Public Class ucFiltroPrestamo
    Implements IFiltroReportes

    Private ReadOnly _personalservicios As New PersonalServicios
    Private ReadOnly _activoservicios As New ActivoServicios
    Private ReadOnly _activofisicoservicios As New ActivoFisicoServicios
    Private ReadOnly _usuarioservicios As New UsuarioServicios
    Private ReadOnly _personalserivicios As New PersonalServicios
    Private ReadOnly _marcaservicios As New MarcaServicios
    Private ReadOnly _estadoservicios As New EstadoServicios

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        cmbActivo.DataSource = _activoservicios.ObtenerTodos()
        cmbActivo.DisplayMember = "Nombre"
        cmbActivo.ValueMember = "IdActivo"
        cmbActivo.SelectedIndex = -1

        cmbEstado.DataSource = _estadoservicios.ObtenerPorTipo(TipoEstadoEnum.Prestamo)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1

        cmbQuienRegistra.DataSource = _usuarioservicios.ObtenerTodos()
        cmbQuienRegistra.DisplayMember = "NombreUsuario"
        cmbQuienRegistra.ValueMember = "IdUsuario"
        cmbQuienRegistra.SelectedIndex = -1

        cmbSolicitante.DataSource = _personalserivicios.ObteneTodos()
        cmbSolicitante.DisplayMember = "CodPersonal"
        cmbSolicitante.ValueMember = "IdPersonal"
        cmbSolicitante.SelectedIndex = -1

        cmbEtiqueta.DataSource = _activofisicoservicios.ObtenerTodo()
        cmbEtiqueta.DisplayMember = "CodEtiquetaQR"
        cmbEtiqueta.ValueMember = "IdActivoFisico"
        cmbEtiqueta.SelectedIndex = -1

        cmbMarca.DataSource = _marcaservicios.ObtenerTodo()
        cmbMarca.DisplayMember = "Nombre"
        cmbMarca.ValueMember = "IdMarca"
        cmbMarca.SelectedIndex = -1

    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbActivo.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
        cmbEtiqueta.SelectedIndex = -1
        cmbMarca.SelectedIndex = -1
        cmbQuienRegistra.SelectedIndex = -1
        cmbSolicitante.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbSolicitante.SelectedIndex <> -1 Then
            dto.PersonalId = CInt(cmbSolicitante.SelectedValue)
        End If

        If cmbQuienRegistra.SelectedIndex <> -1 Then
            dto.UsuarioRegistraId = CInt(cmbQuienRegistra.SelectedValue)
        End If

        If cmbEstado.SelectedIndex <> -1 Then
            dto.EstadoPrestamoId = CInt(cmbEstado.SelectedValue)
        End If

        If cmbEtiqueta.SelectedIndex <> -1 Then
            dto.CodEtiquetaQR = cmbEtiqueta.SelectedValue.ToString()
        End If

        If cmbMarca.SelectedIndex <> -1 Then
            dto.MarcaId = CInt(cmbMarca.SelectedValue)
        End If

        If cmbActivo.SelectedIndex <> -1 Then
            dto.ActivoId = CInt(cmbActivo.SelectedValue)
        End If

        Return dto

    End Function
End Class
