Imports MODELOS
Imports QuestPDF.Fluent
Imports System.Data

Public Class ReporteDevolucionPDF
    Inherits ReportePDFBase

    Public Sub New(datos As DataTable, info As InformacionReporte)

        MyBase.New(datos, info)

    End Sub

    Protected Overrides Function TituloReporte() As String

        Return "Reporte de Devolucones"

    End Function

    Protected Overrides Sub ConstruirContenido(page As ColumnDescriptor)

        page.Item.Table(
            Sub(tabla)
                TablaPDFHelper.DibujarTabla(tabla, Datos)
            End Sub)

    End Sub

End Class
