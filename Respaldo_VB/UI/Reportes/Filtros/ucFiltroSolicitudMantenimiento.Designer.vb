<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFiltroSolicitudMantenimiento
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        GroupBox1 = New GroupBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        dtpFechaDesde = New DateTimePicker()
        dtpFechaHasta = New DateTimePicker()
        Label10 = New Label()
        Label11 = New Label()
        GroupBox2 = New GroupBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        cmbActivo = New ComboBox()
        Label1 = New Label()
        cmbQuienRegistra = New ComboBox()
        Label16 = New Label()
        GroupBox1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel4)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(19, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1141, 75)
        GroupBox1.TabIndex = 36
        GroupBox1.TabStop = False
        GroupBox1.Text = "Fecha"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 4
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.Controls.Add(dtpFechaDesde, 1, 0)
        TableLayoutPanel4.Controls.Add(dtpFechaHasta, 3, 0)
        TableLayoutPanel4.Controls.Add(Label10, 2, 0)
        TableLayoutPanel4.Controls.Add(Label11, 0, 0)
        TableLayoutPanel4.Location = New Point(23, 29)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.Size = New Size(1099, 36)
        TableLayoutPanel4.TabIndex = 30
        ' 
        ' dtpFechaDesde
        ' 
        dtpFechaDesde.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaDesde.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaDesde.Location = New Point(86, 3)
        dtpFechaDesde.Name = "dtpFechaDesde"
        dtpFechaDesde.Size = New Size(447, 31)
        dtpFechaDesde.TabIndex = 17
        ' 
        ' dtpFechaHasta
        ' 
        dtpFechaHasta.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaHasta.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaHasta.Location = New Point(649, 3)
        dtpFechaHasta.Name = "dtpFechaHasta"
        dtpFechaHasta.Size = New Size(447, 31)
        dtpFechaHasta.TabIndex = 7
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label10.Location = New Point(539, 5)
        Label10.Margin = New Padding(3, 5, 3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 24)
        Label10.TabIndex = 11
        Label10.Text = "    Hasta:"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label11.Location = New Point(3, 5)
        Label11.Margin = New Padding(3, 5, 3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(77, 24)
        Label11.TabIndex = 7
        Label11.Text = "Desde:"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel5)
        GroupBox2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(19, 89)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1141, 90)
        GroupBox2.TabIndex = 40
        GroupBox2.TabStop = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel5.ColumnCount = 4
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(cmbActivo, 3, 0)
        TableLayoutPanel5.Controls.Add(Label1, 2, 0)
        TableLayoutPanel5.Controls.Add(cmbQuienRegistra, 1, 0)
        TableLayoutPanel5.Controls.Add(Label16, 0, 0)
        TableLayoutPanel5.Location = New Point(23, 33)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(1099, 36)
        TableLayoutPanel5.TabIndex = 31
        ' 
        ' cmbActivo
        ' 
        cmbActivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbActivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbActivo.FormattingEnabled = True
        cmbActivo.Location = New Point(685, 3)
        cmbActivo.Name = "cmbActivo"
        cmbActivo.Size = New Size(411, 30)
        cmbActivo.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label1.Location = New Point(596, 5)
        Label1.Margin = New Padding(3, 5, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 24)
        Label1.TabIndex = 16
        Label1.Text = "Activo:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbQuienRegistra
        ' 
        cmbQuienRegistra.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbQuienRegistra.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbQuienRegistra.FormattingEnabled = True
        cmbQuienRegistra.Location = New Point(180, 3)
        cmbQuienRegistra.Name = "cmbQuienRegistra"
        cmbQuienRegistra.Size = New Size(410, 30)
        cmbQuienRegistra.TabIndex = 15
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label16.Location = New Point(3, 5)
        Label16.Margin = New Padding(3, 5, 3, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(171, 24)
        Label16.TabIndex = 7
        Label16.Text = "Quien Registro:"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ucFiltroSolicitudMantenimiento
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ucFiltroSolicitudMantenimiento"
        Size = New Size(1178, 195)
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents cmbQuienRegistra As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbActivo As ComboBox
    Friend WithEvents Label1 As Label

End Class
