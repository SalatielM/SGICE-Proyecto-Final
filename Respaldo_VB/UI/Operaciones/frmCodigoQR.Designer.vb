<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodigoQR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodigoQR))
        lblActivo = New Label()
        btnImprimir = New Button()
        picCodigoQR = New PictureBox()
        lblCodEtiquetaQR = New Label()
        pnlInferiordeInformacion = New Panel()
        btnCerrar = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        CType(picCodigoQR, ComponentModel.ISupportInitialize).BeginInit()
        pnlInferiordeInformacion.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblActivo
        ' 
        lblActivo.AutoSize = True
        lblActivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActivo.Location = New Point(81, 21)
        lblActivo.Name = "lblActivo"
        lblActivo.Size = New Size(192, 24)
        lblActivo.TabIndex = 0
        lblActivo.Text = "Dell Latitud 1215"
        ' 
        ' btnImprimir
        ' 
        btnImprimir.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImprimir.Location = New Point(13, 23)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New Size(329, 34)
        btnImprimir.TabIndex = 1
        btnImprimir.Text = "Imprimir"
        btnImprimir.UseVisualStyleBackColor = True
        ' 
        ' picCodigoQR
        ' 
        picCodigoQR.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        picCodigoQR.Location = New Point(27, 136)
        picCodigoQR.Name = "picCodigoQR"
        picCodigoQR.Size = New Size(355, 274)
        picCodigoQR.SizeMode = PictureBoxSizeMode.Zoom
        picCodigoQR.TabIndex = 2
        picCodigoQR.TabStop = False
        ' 
        ' lblCodEtiquetaQR
        ' 
        lblCodEtiquetaQR.AutoSize = True
        lblCodEtiquetaQR.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCodEtiquetaQR.Location = New Point(105, 50)
        lblCodEtiquetaQR.Name = "lblCodEtiquetaQR"
        lblCodEtiquetaQR.Size = New Size(136, 24)
        lblCodEtiquetaQR.TabIndex = 3
        lblCodEtiquetaQR.Text = "AF-0000001"
        ' 
        ' pnlInferiordeInformacion
        ' 
        pnlInferiordeInformacion.BackColor = SystemColors.ActiveCaption
        pnlInferiordeInformacion.BorderStyle = BorderStyle.Fixed3D
        pnlInferiordeInformacion.Controls.Add(btnCerrar)
        pnlInferiordeInformacion.Dock = DockStyle.Top
        pnlInferiordeInformacion.Location = New Point(0, 0)
        pnlInferiordeInformacion.Name = "pnlInferiordeInformacion"
        pnlInferiordeInformacion.Size = New Size(416, 39)
        pnlInferiordeInformacion.TabIndex = 4
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), Image)
        btnCerrar.Location = New Point(376, 3)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(32, 30)
        btnCerrar.TabIndex = 5
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(lblActivo)
        GroupBox1.Controls.Add(lblCodEtiquetaQR)
        GroupBox1.Location = New Point(27, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(355, 80)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnImprimir)
        GroupBox2.Location = New Point(27, 412)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(355, 67)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' frmCodigoQR
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(416, 491)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(pnlInferiordeInformacion)
        Controls.Add(picCodigoQR)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmCodigoQR"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmCodigoQR"
        CType(picCodigoQR, ComponentModel.ISupportInitialize).EndInit()
        pnlInferiordeInformacion.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblActivo As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents picCodigoQR As PictureBox
    Friend WithEvents lblCodEtiquetaQR As Label
    Friend WithEvents pnlInferiordeInformacion As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
End Class
