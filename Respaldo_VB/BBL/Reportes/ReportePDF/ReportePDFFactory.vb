Imports MODELOS
Imports BBL
Imports System.Data

Public Class ReportePDFFactory

    Public Shared Function Crear(tipo As TipoReporte, datos As DataTable, info As InformacionReporte) As IReportePDF

        Select Case tipo

            Case TipoReporte.ActivosFisicos
                Return New ReporteActivoFisicoPDF(datos, info)

            Case TipoReporte.Auditoria
                Return New ReporteAuditoriaPDF(datos, info)

            Case TipoReporte.Devoluciones
                Return New ReporteAuditoriaPDF(datos, info)

            Case TipoReporte.Entradas
                Return New ReporteEntradasPDF(datos, info)

            Case TipoReporte.Mantenimientos
                Return New ReporteMantenimientoPDF(datos, info)

            Case TipoReporte.Personal
                Return New ReportePersonalPDF(datos, info)

            Case TipoReporte.Prestamos
                Return New ReportePrestamoPDF(datos, info)

            Case TipoReporte.Salidas
                Return New ReporteSalidaPDF(datos, info)

            Case TipoReporte.SolicitudMantenimiento
                Return New ReporteSolicitudMantenimientoPDF(datos, info)

            Case TipoReporte.Traslados
                Return New ReporteTrasladoPDF(datos, info)

            Case TipoReporte.Usuarios
                Return New ReporteUsuarioPDF(datos, info)

            Case Else
                Throw New NotImplementedException(
                    $"No existe un reporte PDF para el tipo {tipo}.")
        End Select

    End Function

End Class
