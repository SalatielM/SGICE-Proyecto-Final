Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.EMMA
Imports DocumentFormat.OpenXml.Spreadsheet
Imports MODELOS
Imports System.Data

Public MustInherit Class ReporteExcelBase
    Implements IReporteExcel

    Protected ReadOnly Datos As DataTable
    Protected ReadOnly Info As InformacionReporte

    Public Sub New(datos As DataTable, INFO As InformacionReporte)

        Me.Datos = datos
        Me.Info = INFO

    End Sub

    Public Sub Generar(ruta As String) Implements IReporteExcel.Generar

        Using libro As New XLWorkbook()

            Dim hoja = libro.Worksheets.Add(TituloReporte())
            ConstruirEncabezado(hoja)
            ConstruirReporte(hoja)

            hoja.PageSetup.Footer.Left.AddText(Date.Now.ToString("dd/MM/yyyy"))
            hoja.PageSetup.Footer.Right.AddText("Página ")
            hoja.PageSetup.Footer.Right.AddText("Página &P de &N")

            libro.SaveAs(ruta)

        End Using

    End Sub

    Protected MustOverride Function TituloReporte() As String

    Protected MustOverride Sub ConstruirReporte(hoja As IXLWorksheet)

    Protected Overridable Sub ConstruirEncabezado(hoja As IXLWorksheet)

        hoja.Cell("A1").Value = Info.Centro.Nombre
        hoja.Range("A1:H1").Merge()

        hoja.Cell("A1").Style.Font.Bold = True
        hoja.Cell("A1").Style.Font.FontSize = 18
        hoja.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

        hoja.Cell("A2").Value = $"Código: {Info.Centro.CodCentro}"
        hoja.Cell("A3").Value = $"Regional: {Info.Centro.RegionalEducativo}"
        hoja.Cell("D3").Value = $"Distrito: {Info.Centro.DistritoEducativo}"

        hoja.Cell("A4").Value = $"Dirección: {Info.Centro.Direccion}"
        hoja.Cell("A5").Value = $"Teléfono: {Info.Centro.Telefono}"
        hoja.Cell("A6").Value = $"Correo: {Info.Centro.Correo}"

        hoja.Cell("A8").Value = "Director:"
        hoja.Cell("B8").Value = $"{Info.Centro.Director.Nombre} {Info.Centro.Director.Apellido}"

        hoja.Cell("A9").Value = "Reporte generado por:"
        hoja.Cell("B9").Value = Info.Usuario

        hoja.Cell("A11").Value = Info.Titulo
        hoja.Range("A11:H11").Merge()

        hoja.Cell("A11").Style.Font.Bold = True
        hoja.Cell("A11").Style.Font.FontSize = 16
        hoja.Cell("A11").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center

    End Sub

End Class
