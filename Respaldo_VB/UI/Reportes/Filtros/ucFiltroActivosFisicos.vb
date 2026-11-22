Imports BBL
Imports MODELOS

Public Class ucFiltroActivosFisicos
    Implements IFiltroReportes

    Private ReadOnly _activoServicios As New ActivoServicios
    Private ReadOnly _marcaServicios As New MarcaServicios
    Private ReadOnly _categoriaServicios As New CategoriaServicios
    Private ReadOnly _ubicacionServicios As New UbicacionServicios
    Private ReadOnly _estadoServicios As New EstadoServicios
    Private ReadOnly _personalServicios As New PersonalServicios

    Public Sub CargarCombos() Implements IFiltroReportes.CargarCombos

        cmbActivo.DataSource = _activoServicios.ObtenerTodos()
        cmbActivo.DisplayMember = "Nombre"
        cmbActivo.ValueMember = "IdActivo"
        cmbActivo.SelectedIndex = -1

        cmbMarca.DataSource = _marcaServicios.ObtenerTodo()
        cmbMarca.DisplayMember = "Nombre"
        cmbMarca.ValueMember = "IdMarca"
        cmbMarca.SelectedIndex = -1

        cmbCategoria.DataSource = _categoriaServicios.ObtenerTodos()
        cmbCategoria.DisplayMember = "Nombre"
        cmbCategoria.ValueMember = "IdCategoria"
        cmbCategoria.SelectedIndex = -1

        cmbUbicacion.DataSource = _ubicacionServicios.ObtenerTodo()
        cmbUbicacion.DisplayMember = "Nombre"
        cmbUbicacion.ValueMember = "IdUbicacion"
        cmbUbicacion.SelectedIndex = -1

        cmbEstado.DataSource = _estadoServicios.ObtenerPorTipo(TipoEstadoEnum.ActivoFisico)
        cmbEstado.DisplayMember = "Nombre"
        cmbEstado.ValueMember = "IdEstado"
        cmbEstado.SelectedIndex = -1

        cmbEncargado.DataSource = _personalServicios.ObteneTodos()
        cmbEncargado.DisplayMember = "Nombre"
        cmbEncargado.ValueMember = "IdPersonal"
        cmbEncargado.SelectedIndex = -1

    End Sub

    Public Sub Limpiar() Implements IFiltroReportes.Limpiar

        cmbActivo.SelectedIndex = -1
        cmbMarca.SelectedIndex = -1
        cmbCategoria.SelectedIndex = -1
        cmbUbicacion.SelectedIndex = -1
        cmbEstado.SelectedIndex = -1
        cmbEncargado.SelectedIndex = -1

    End Sub

    Public Function ObtenerFiltros() As ReporteFiltroDTO Implements IFiltroReportes.ObtenerFiltros

        Dim dto As New ReporteFiltroDTO()

        dto.FechaDesde = dtpFechaDesde.Value.Date
        dto.FechaHasta = dtpFechaHasta.Value.Date

        If cmbActivo.SelectedIndex <> -1 Then
            dto.ActivoId = CInt(cmbActivo.SelectedValue)
        End If

        If cmbMarca.SelectedIndex <> -1 Then
            dto.MarcaId = CInt(cmbMarca.SelectedValue)
        End If

        If cmbCategoria.SelectedIndex <> -1 Then
            dto.CategoriaId = CInt(cmbCategoria.SelectedValue)
        End If

        If cmbUbicacion.SelectedIndex <> -1 Then
            dto.UbicacionId = CInt(cmbUbicacion.SelectedValue)
        End If

        If cmbEstado.SelectedIndex <> -1 Then
            dto.EstadoActivoFisicoId = CInt(cmbEstado.SelectedValue)
        End If

        If cmbEncargado.SelectedIndex <> -1 Then
            dto.PersonalId = CInt(cmbEncargado.SelectedValue)
        End If

        Return dto

    End Function

End Class
