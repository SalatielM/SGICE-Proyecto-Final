Imports BBL
Imports MODELOS

Public Class frmReportes

    Private servicio As New ReporteServicios
    Private reporteActual As DataTable
    Private filtroActual As IFiltroReportes
    Private tipoReporte As TipoReporte
    Private cargando As Boolean = True

    Private ReadOnly impresioServicio As New ReporteImprecionServicios()

    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarTiposReportes()
        cargando = False

    End Sub

    Private Sub CargarTiposReportes()

        cmbTipoReporte.DataSource = [Enum].GetValues(GetType(TipoReporte))
        cmbTipoReporte.SelectedIndex = -1

    End Sub

    Private Sub cmbTipoReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoReporte.SelectedIndexChanged

        If cargando Then Exit Sub
        If cmbTipoReporte.SelectedIndex = -1 Then Exit Sub
        tipoReporte = CType(cmbTipoReporte.SelectedItem, TipoReporte)
        CargarFiltros(tipoReporte)

    End Sub

    Private Sub CargarFiltros(tipo As TipoReporte)

        pnlFiltros.Controls.Clear()

        Select Case tipo

            Case TipoReporte.ActivosFisicos
                filtroActual = New ucFiltroActivosFisicos()

            Case TipoReporte.Auditoria
                filtroActual = New ucFiltroAuditoria()

            Case TipoReporte.Devoluciones
                filtroActual = New ucFiltroDevoluciones()

            Case TipoReporte.Entradas
                filtroActual = New ucFiltroEntradas()

            Case TipoReporte.Mantenimientos
                filtroActual = New ucFiltroMantenimiento()

            Case TipoReporte.Personal
                filtroActual = New ucFiltroPersonal()

            Case TipoReporte.Prestamos
                filtroActual = New ucFiltroPrestamo()

            Case TipoReporte.Salidas
                filtroActual = New ucFiltroSalidas()

            Case TipoReporte.SolicitudMantenimiento
                filtroActual = New ucFiltroSolicitudMantenimiento()

            Case TipoReporte.Traslados
                filtroActual = New ucFiltroTraslados()

            Case TipoReporte.Usuarios
                filtroActual = New ucFiltroUsuarios()

        End Select

        If filtroActual Is Nothing Then
            MessageBox.Show("filtroActual es Nothing")
            Exit Sub
        End If

        Dim uc As UserControl = DirectCast(filtroActual, UserControl)
        uc.Dock = DockStyle.Fill

        pnlFiltros.Controls.Add(uc)
        filtroActual.CargarCombos()

    End Sub

    Private Function CrearInformacionReporte() As InformacionReporte

        Dim centroServicio As New CentroEducativoServicios()

        Return New InformacionReporte With {
             .Centro = centroServicio.ObtenerInfoCentro(),
             .Usuario = $"{SesionActual.Usuario.Nombre} {SesionActual.Usuario.Apellido}",
             .Titulo = ObtenerTituloReporte()
         }

    End Function

    Private Function CrearReportePDF() As IReportePDF

        Dim centroServicio As New CentroEducativoServicios()
        Dim info As New InformacionReporte()

        info.Centro = centroServicio.ObtenerInfoCentro()
        info.Usuario = $"{SesionActual.Usuario.Nombre} {SesionActual.Usuario.Apellido}"
        info.Titulo = ObtenerTituloReporte()

        Return ReportePDFFactory.Crear(tipoReporte, reporteActual, info)

    End Function

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click

        If filtroActual Is Nothing Then
            MessageBox.Show("Debe seleccionar un tipo de reporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim filtros = filtroActual.ObtenerFiltros()

        reporteActual = servicio.ObtenerReporte(tipoReporte, filtros)

        dgvReportesGenerados.DataSource = reporteActual
        filtroActual.Limpiar()

    End Sub

    Private Sub btnExportarPDF_Click(sender As Object, e As EventArgs) Handles btnExportarPDF.Click

        If reporteActual Is Nothing OrElse reporteActual.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using sfd As New SaveFileDialog()

            sfd.Filter = "Archivo PDF (*.pdf)|*.pdf"
            sfd.FileName = $"Reporte_{tipoReporte}_{Date.Now:yyyyMMdd_HHmmss}.pdf"

            If sfd.ShowDialog() = DialogResult.OK Then

                Dim centroServicio As New CentroEducativoServicios()
                Dim info As New InformacionReporte()
                info.Centro = centroServicio.ObtenerInfoCentro()
                info.Usuario = $"{SesionActual.Usuario.Nombre} {SesionActual.Usuario.Apellido}"
                info.Titulo = ObtenerTituloReporte()

                Dim reporte = ReportePDFFactory.Crear(tipoReporte, reporteActual, info)

                reporte.Generar(sfd.FileName)

                MessageBox.Show("PDF generado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End Using

    End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click

        If reporteActual Is Nothing OrElse reporteActual.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using sfd As New SaveFileDialog()

            sfd.Filter = "Libro de Excel (*.xlsx)|*.xlsx"
            sfd.FileName = $"Reporte_{tipoReporte}_{Date.Now:ddMMyyy}.xlsx"

            If sfd.ShowDialog() = DialogResult.OK Then

                Dim reporte = ReporteExcelFactory.Crear(tipoReporte, reporteActual, CrearInformacionReporte)
                reporte.Generar(sfd.FileName)
                MessageBox.Show("Excel generado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End Using

    End Sub

    Private Function ObtenerTituloReporte() As String

        Select Case tipoReporte

            Case TipoReporte.ActivosFisicos
                Return "Reporte de Activos Físicos"

            Case TipoReporte.Auditoria
                Return "Reporte de Auditoría"

            Case TipoReporte.Entradas
                Return "Reporte de Entradas"

            Case TipoReporte.Mantenimientos
                Return "Reporte de Mantenimientos"

            Case TipoReporte.Personal
                Return "Reporte de Personal"

            Case TipoReporte.Prestamos
                Return "Reporte de Préstamos"

            Case TipoReporte.Salidas
                Return "Reporte de Salidas"

            Case TipoReporte.SolicitudMantenimiento
                Return "Reporte de Solicitudes de Mantenimiento"

            Case TipoReporte.Traslados
                Return "Reporte de Traslados"

            Case TipoReporte.Usuarios
                Return "Reporte de Usuarios"

            Case TipoReporte.Devoluciones
                Return "Reporte de Devoluciones"

            Case Else
                Return "Reporte"

        End Select

    End Function

End Class