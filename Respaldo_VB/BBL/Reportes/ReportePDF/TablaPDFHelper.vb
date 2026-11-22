Imports QuestPDF.Fluent
Imports QuestPDF.Helpers
Imports System.Data

Public Class TablaPDFHelper

    Public Shared Sub DibujarTabla(tabla As TableDescriptor, datos As DataTable)

        tabla.ColumnsDefinition(
            Sub(columns)

                For Each columna As DataColumn In datos.Columns

                    Select Case columna.ColumnName.ToLower()

                        Case "fecha"
                            columns.ConstantColumn(70)
                        Case "cantidad"
                            columns.ConstantColumn(50)
                        Case "estado"
                            columns.ConstantColumn(70)
                        Case "codigo"
                            columns.ConstantColumn(80)

                        Case Else
                            columns.RelativeColumn(80)

                    End Select

                Next

            End Sub)

        tabla.Header(
            Sub(header)

                For Each columna As DataColumn In datos.Columns

                    header.Cell().
                    Background("#cde0ff").
                    Border(0.5F).
                    Padding(5).
                    AlignCenter().
                    AlignMiddle().
                    Text(columna.ColumnName).
                    FontColor(Colors.Black).
                    FontSize(10).
                    Bold

                Next

            End Sub)

        Dim indice As Integer = 0

        For Each fila As DataRow In datos.Rows

            Dim color = If(indice Mod 2 = 0, Colors.White, Colors.Grey.Lighten4)

            For Each valor In fila.ItemArray

                tabla.Cell().
                    Background(color).
                    Border(0.5F).
                    PaddingVertical(2).
                    PaddingHorizontal(3).
                    AlignMiddle().
                    Text(If(IsDBNull(valor), "", valor.ToString())).
                    FontSize(8).
                    LineHeight(1)
            Next
            indice += 1
        Next

    End Sub

End Class
