Imports System.Drawing.Printing
Imports MODELOS
Imports QRCoder

Public Class frmCodigoQR

    Private ReadOnly _activo As ActivoFisicoDTO
    Private WithEvents documento As New PrintDocument

    Public Sub New(activo As ActivoFisicoDTO)

        InitializeComponent()
        _activo = activo
    End Sub

    Private Sub frmCodigoQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblActivo.Text = _activo.Activo
        lblCodEtiquetaQR.Text = _activo.CodEtiquetaQR

        Dim informacionQR As String = $"Activo: {_activo.Activo}" & vbCrLf & $"Codigo: {_activo.CodEtiquetaQR}" & vbCrLf & $"No. Serie: {_activo.NumSerie}"
        Dim generador As New QRCodeGenerator()
        Dim datos = generador.CreateQrCode(informacionQR, QRCodeGenerator.ECCLevel.Q)
        Dim codigoQR As New QRCode(datos)

        picCodigoQR.Image = codigoQR.GetGraphic(5)

    End Sub

    Private Sub documento_PrintPage(sender As Object, e As PrintPageEventArgs) Handles documento.PrintPage

        e.Graphics.DrawString(_activo.Activo, New Font("Arial", 14), Brushes.Black, 20, 20)
        e.Graphics.DrawString(_activo.CodEtiquetaQR, New Font("Arial", 12), Brushes.Black, 20, 50)
        e.Graphics.DrawImage(picCodigoQR.Image, 20, 80, 150, 150)

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fuenteTitulo As New Font("Arial", 14, FontStyle.Bold)
        Dim fuente As New Font("Arial", 10)

        Dim y As Integer = 20
        e.Graphics.DrawString("Etiqueta del Activo", fuenteTitulo, Brushes.Black, 20, y)
        y += 40
        e.Graphics.DrawString("Activo: " & _activo.Activo, fuente, Brushes.Black, 20, y)
        y += 25
        e.Graphics.DrawString("Código: " & _activo.CodEtiquetaQR, fuente, Brushes.Black, 20, y)
        y += 25
        e.Graphics.DrawString("Serie: " & _activo.NumSerie, fuente, Brushes.Black, 20, y)
        y += 35

        If picCodigoQR.Image IsNot Nothing Then
            e.Graphics.DrawImage(picCodigoQR.Image, 20, y, 180, 180)
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class