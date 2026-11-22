Imports System.Data
Imports MODELOS

Public Class ReporteExcelFactory

    Public Shared Function Crear(tipo As TipoReporte, datos As DataTable, info As InformacionReporte) As IReporteExcel

        Select Case tipo

            Case TipoReporte.ActivosFisicos
                Return New ReporteActivoFisicoEXCEL(datos, info)

            Case TipoReporte.Auditoria
                Return New ReporteAuditoriaEXCEL(datos, info)

            Case TipoReporte.Devoluciones
                Return New ReporteDevolucionesEXCEL(datos, info)

            Case TipoReporte.Entradas
                Return New ReporteEntradasEXCEL(datos, info)

            Case TipoReporte.Mantenimientos
                Return New ReporteMantenimientosEXCEL(datos, info)

            Case TipoReporte.Personal
                Return New ReportePersonalEXCEL(datos, info)

            Case TipoReporte.Prestamos
                Return New ReportePrestamoExcel(datos, info)

            Case TipoReporte.Salidas
                Return New ReporteSalidaEXCEL(datos, info)

            Case TipoReporte.SolicitudMantenimiento
                Return New ReporteSolicitudMantenimientoEXCEL(datos, info)

            Case TipoReporte.Traslados
                Return New ReporteTrasladoEXCEL(datos, info)

            Case TipoReporte.Usuarios
                Return New ReporteTrasladoEXCEL(datos, info)

            Case Else
                Throw New NotImplementedException

        End Select

    End Function

End Class
