Imports System.Data
Imports ClosedXML.Excel
Imports MODELOS

Public Class ReporteEntradasEXCEL
    Inherits ReporteExcelBase

    Public Sub New(datos As DataTable, info As InformacionReporte)
        MyBase.New(datos, info)
    End Sub

    Protected Overrides Function TituloReporte() As String
        Return "REPORTE DE ENTRADA DE ACTIVOS"
    End Function

    Protected Overrides Sub ConstruirReporte(hoja As IXLWorksheet)
        TablaHelperExcel.DibujarTabla(hoja, Datos, 13)
    End Sub
End Class
