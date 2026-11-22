<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox4 = New GroupBox()
        btnExportarExcel = New Button()
        btnExportarPDF = New Button()
        btnGenerarReporte = New Button()
        GroupBox3 = New GroupBox()
        dgvReportesGenerados = New DataGridView()
        GroupBox1 = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        cmbTipoReporte = New ComboBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        pnlFiltros = New Panel()
        SaveFileDialog1 = New SaveFileDialog()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvReportesGenerados, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.BackColor = SystemColors.ActiveCaption
        label1.BorderStyle = BorderStyle.Fixed3D
        label1.Dock = DockStyle.Top
        label1.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(0, 0)
        label1.Margin = New Padding(4, 0, 4, 0)
        label1.Name = "label1"
        label1.Size = New Size(1247, 37)
        label1.TabIndex = 10
        label1.Text = "GESTION DE REPORTES"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(btnExportarExcel)
        GroupBox4.Controls.Add(btnExportarPDF)
        GroupBox4.Controls.Add(btnGenerarReporte)
        GroupBox4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(18, 357)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1208, 60)
        GroupBox4.TabIndex = 18
        GroupBox4.TabStop = False
        ' 
        ' btnExportarExcel
        ' 
        btnExportarExcel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        btnExportarExcel.BackColor = Color.Honeydew
        btnExportarExcel.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportarExcel.Location = New Point(196, 20)
        btnExportarExcel.Name = "btnExportarExcel"
        btnExportarExcel.Size = New Size(195, 32)
        btnExportarExcel.TabIndex = 31
        btnExportarExcel.Text = "Exportar EXCEL"
        btnExportarExcel.TextAlign = ContentAlignment.TopCenter
        btnExportarExcel.UseVisualStyleBackColor = False
        ' 
        ' btnExportarPDF
        ' 
        btnExportarPDF.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        btnExportarPDF.BackColor = Color.MistyRose
        btnExportarPDF.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportarPDF.Location = New Point(15, 20)
        btnExportarPDF.Name = "btnExportarPDF"
        btnExportarPDF.Size = New Size(175, 32)
        btnExportarPDF.TabIndex = 30
        btnExportarPDF.Text = "Exportar PDF"
        btnExportarPDF.TextAlign = ContentAlignment.TopCenter
        btnExportarPDF.UseVisualStyleBackColor = False
        ' 
        ' btnGenerarReporte
        ' 
        btnGenerarReporte.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGenerarReporte.BackColor = Color.LightCyan
        btnGenerarReporte.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerarReporte.Location = New Point(994, 20)
        btnGenerarReporte.Name = "btnGenerarReporte"
        btnGenerarReporte.Size = New Size(199, 32)
        btnGenerarReporte.TabIndex = 29
        btnGenerarReporte.Text = "Generar Reporte"
        btnGenerarReporte.TextAlign = ContentAlignment.TopCenter
        btnGenerarReporte.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(dgvReportesGenerados)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(18, 418)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1208, 335)
        GroupBox3.TabIndex = 17
        GroupBox3.TabStop = False
        ' 
        ' dgvReportesGenerados
        ' 
        dgvReportesGenerados.AllowUserToAddRows = False
        dgvReportesGenerados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvReportesGenerados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReportesGenerados.BackgroundColor = SystemColors.ButtonHighlight
        dgvReportesGenerados.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvReportesGenerados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvReportesGenerados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvReportesGenerados.DefaultCellStyle = DataGridViewCellStyle2
        dgvReportesGenerados.GridColor = SystemColors.InactiveCaptionText
        dgvReportesGenerados.Location = New Point(15, 32)
        dgvReportesGenerados.Name = "dgvReportesGenerados"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvReportesGenerados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvReportesGenerados.RowHeadersVisible = False
        dgvReportesGenerados.RowHeadersWidth = 62
        dgvReportesGenerados.Size = New Size(1175, 291)
        dgvReportesGenerados.TabIndex = 27
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Location = New Point(18, 37)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1208, 76)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(cmbTipoReporte, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(15, 22)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1178, 44)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' cmbTipoReporte
        ' 
        cmbTipoReporte.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbTipoReporte.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cmbTipoReporte.FormattingEnabled = True
        cmbTipoReporte.Location = New Point(212, 3)
        cmbTipoReporte.Name = "cmbTipoReporte"
        cmbTipoReporte.Size = New Size(963, 35)
        cmbTipoReporte.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 9)
        Label2.Margin = New Padding(3, 9, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 25)
        Label2.TabIndex = 7
        Label2.Text = "Tipo de Reporte:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(pnlFiltros)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(18, 119)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1208, 236)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Filtro"
        ' 
        ' pnlFiltros
        ' 
        pnlFiltros.BorderStyle = BorderStyle.FixedSingle
        pnlFiltros.Dock = DockStyle.Fill
        pnlFiltros.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pnlFiltros.Location = New Point(3, 29)
        pnlFiltros.Name = "pnlFiltros"
        pnlFiltros.Size = New Size(1202, 204)
        pnlFiltros.TabIndex = 0
        ' 
        ' frmReportes
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmReportes"
        Text = "frmReportePrestamo"
        GroupBox4.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        CType(dgvReportesGenerados, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmbTipoReporte As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents btnExportarExcel As Button
    Friend WithEvents btnExportarPDF As Button
    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents dgvReportesGenerados As DataGridView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class