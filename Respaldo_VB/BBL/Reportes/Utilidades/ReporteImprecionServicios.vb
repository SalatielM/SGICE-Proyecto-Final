Imports System.Diagnostics
Imports System.IO

Public Class ReporteImprecionServicios

    Public Sub Imprimir(reporte As IReportePDF)

        Dim rutaTemporal = Path.Combine(Path.GetTempPath(), $"Reporte_{Guid.NewGuid()}.pdf")

        reporte.Generar(rutaTemporal)
        Dim proceso As New Process()

        proceso.StartInfo.FileName = rutaTemporal
        proceso.StartInfo.Verb = "Print"
        proceso.StartInfo.UseShellExecute = True
        proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proceso.Start()

    End Sub

End Class
