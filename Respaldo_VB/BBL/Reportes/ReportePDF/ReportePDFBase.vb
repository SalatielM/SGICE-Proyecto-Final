Imports MODELOS
Imports System.Data
Imports QuestPDF.Fluent
Imports System.Windows.Documents

Public MustInherit Class ReportePDFBase

    Implements IReportePDF

    Protected ReadOnly Datos As DataTable
    Protected ReadOnly Info As InformacionReporte

    Public Sub New(datos As DataTable, info As InformacionReporte)

        Me.Datos = datos
        Me.Info = info

    End Sub

    Public Sub Generar(rutas As String) Implements IReportePDF.Generar

        Document.Create(
            Sub(documento)
                documento.Page(
                Sub(page)

                    page.MarginVertical(25)
                    page.MarginHorizontal(35)

                    ConstruirEncabezado(page)

                    page.Content().Column(
                    Sub(col)

                        col.Item().Text(Sub(t)
                                            t.Span("Director: ").Bold()
                                            t.Span($"{Info.Centro.Director.Nombre} {Info.Centro.Director.Apellido}")
                                        End Sub)

                        col.Item().Text(Sub(t)
                                            t.Span("Reporte generado por: ").Bold()
                                            t.Span(Info.Usuario)
                                        End Sub)

                        col.Item().PaddingTop(15)

                        col.Item().
                        AlignCenter().
                        Text(Info.Titulo).
                        FontSize(18).
                        Bold()

                        col.Item().PaddingTop(15)

                        ConstruirContenido(col)

                    End Sub)

                    ConstruirPie(page)

                End Sub)

            End Sub).GeneratePdf(rutas)

    End Sub

    Protected MustOverride Sub ConstruirContenido(page As ColumnDescriptor)

    Protected Overridable Sub ConstruirEncabezado(page As PageDescriptor)

        page.Header().PaddingBottom(15).Column(
            Sub(col)

                If Info.Centro.Foto IsNot Nothing Then

                    col.Item().
                        AlignCenter().
                        Width(70).
                        Height(70).
                        Image(Info.Centro.Foto)

                End If

                col.Item().
                    AlignCenter().
                    Text(Info.Centro.Nombre).
                    Bold().
                    FontSize(15)

                col.Item().
                    AlignCenter().
                    Text($"Codigo: {Info.Centro.CodCentro}")

                col.Item().
                    AlignCenter().
                    Text($"Regional: {Info.Centro.RegionalEducativo}     Distrito: {Info.Centro.DistritoEducativo}")

                col.Item().
                    AlignCenter().
                    Text($"Direccion: {Info.Centro.Direccion}")

                col.Item().
                    AlignCenter().
                    Text($"Telefono: {Info.Centro.Telefono}")

                col.Item().
                    AlignCenter().
                    Text($"Correo: {Info.Centro.Correo}")

            End Sub)

    End Sub


    Protected Overridable Sub ConstruirPie(page As PageDescriptor)

        page.Footer().PaddingTop(10).Row(
        Sub(row)

            row.RelativeItem().
            Text($"Fecha: {Date.Now:dd/MM/yyyy}")

            row.RelativeItem().
            AlignRight().
            Text(Sub(t)

                     t.Span("Pagina ")
                     t.CurrentPageNumber()
                     t.Span(" de ")
                     t.TotalPages()

                 End Sub)

        End Sub)

    End Sub

    Protected MustOverride Function TituloReporte() As String

End Class
