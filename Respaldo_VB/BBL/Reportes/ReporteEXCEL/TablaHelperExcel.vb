Imports ClosedXML.Excel
Imports System.Data

Public Class TablaHelperExcel

    Public Shared Sub DibujarTabla(hoja As IXLWorksheet, datos As DataTable, filaInicio As Integer)

        Dim fila As Integer = filaInicio

        For c As Integer = 0 To datos.Columns.Count - 1

            hoja.Cell(fila, c + 1).Value = datos.Columns(c).ColumnName
            hoja.Cell(fila, c + 1).Style.Font.Bold = True
            hoja.Cell(fila, c + 1).Style.Fill.BackgroundColor = XLColor.LightBlue

        Next

        fila += 1

        For Each dr As DataRow In datos.Rows

            For c As Integer = 0 To datos.Columns.Count - 1
                hoja.Cell(fila, c + 1).Value = dr(c)?.ToString()
            Next

            fila += 1

        Next

        Dim rango = hoja.RangeUsed()
        rango.Style.Border.OutsideBorder = XLBorderStyleValues.Thin
        rango.Style.Border.InsideBorder = XLBorderStyleValues.Thin

        hoja.Columns().AdjustToContents()

    End Sub

End Class
