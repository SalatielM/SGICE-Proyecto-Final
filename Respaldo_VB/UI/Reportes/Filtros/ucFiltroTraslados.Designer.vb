<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFiltroTraslados
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
        TableLayoutPanel3 = New TableLayoutPanel()
        dtpFechaDesde = New DateTimePicker()
        dtpFechaHasta = New DateTimePicker()
        Label8 = New Label()
        Label9 = New Label()
        GroupBox2 = New GroupBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        cmbUbicacionDestino = New ComboBox()
        Label1 = New Label()
        cmbUbicacionOrigen = New ComboBox()
        cmbQuienRegistro = New ComboBox()
        Label15 = New Label()
        Label16 = New Label()
        GroupBox1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel3)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(19, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1141, 75)
        GroupBox1.TabIndex = 32
        GroupBox1.TabStop = False
        GroupBox1.Text = "Fecha de Traslados"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.Controls.Add(dtpFechaDesde, 1, 0)
        TableLayoutPanel3.Controls.Add(dtpFechaHasta, 3, 0)
        TableLayoutPanel3.Controls.Add(Label8, 2, 0)
        TableLayoutPanel3.Controls.Add(Label9, 0, 0)
        TableLayoutPanel3.Location = New Point(23, 29)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(1099, 36)
        TableLayoutPanel3.TabIndex = 30
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
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label8.Location = New Point(539, 5)
        Label8.Margin = New Padding(3, 5, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(104, 24)
        Label8.TabIndex = 11
        Label8.Text = "    Hasta:"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label9.Location = New Point(3, 5)
        Label9.Margin = New Padding(3, 5, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 24)
        Label9.TabIndex = 7
        Label9.Text = "Desde:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel5)
        GroupBox2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(19, 89)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1141, 90)
        GroupBox2.TabIndex = 33
        GroupBox2.TabStop = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel5.ColumnCount = 6
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel5.Controls.Add(cmbUbicacionDestino, 5, 0)
        TableLayoutPanel5.Controls.Add(Label1, 4, 0)
        TableLayoutPanel5.Controls.Add(cmbUbicacionOrigen, 3, 0)
        TableLayoutPanel5.Controls.Add(cmbQuienRegistro, 1, 0)
        TableLayoutPanel5.Controls.Add(Label15, 2, 0)
        TableLayoutPanel5.Controls.Add(Label16, 0, 0)
        TableLayoutPanel5.Location = New Point(21, 33)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(1099, 36)
        TableLayoutPanel5.TabIndex = 31
        ' 
        ' cmbUbicacionDestino
        ' 
        cmbUbicacionDestino.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbUbicacionDestino.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbUbicacionDestino.FormattingEnabled = True
        cmbUbicacionDestino.Location = New Point(970, 3)
        cmbUbicacionDestino.Name = "cmbUbicacionDestino"
        cmbUbicacionDestino.Size = New Size(126, 30)
        cmbUbicacionDestino.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label1.Location = New Point(702, 5)
        Label1.Margin = New Padding(3, 5, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 24)
        Label1.TabIndex = 18
        Label1.Text = "    Ubicacion de Destivo:"
        ' 
        ' cmbUbicacionOrigen
        ' 
        cmbUbicacionOrigen.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbUbicacionOrigen.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbUbicacionOrigen.FormattingEnabled = True
        cmbUbicacionOrigen.Location = New Point(571, 3)
        cmbUbicacionOrigen.Name = "cmbUbicacionOrigen"
        cmbUbicacionOrigen.Size = New Size(125, 30)
        cmbUbicacionOrigen.TabIndex = 17
        ' 
        ' cmbQuienRegistro
        ' 
        cmbQuienRegistro.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbQuienRegistro.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbQuienRegistro.FormattingEnabled = True
        cmbQuienRegistro.Location = New Point(180, 3)
        cmbQuienRegistro.Name = "cmbQuienRegistro"
        cmbQuienRegistro.Size = New Size(125, 30)
        cmbQuienRegistro.TabIndex = 15
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label15.Location = New Point(311, 5)
        Label15.Margin = New Padding(3, 5, 3, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(254, 24)
        Label15.TabIndex = 11
        Label15.Text = "    Ubicacion de Origen:"
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
        ' ucFiltroTraslados
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ucFiltroTraslados"
        Size = New Size(1178, 195)
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents cmbUbicacionOrigen As ComboBox
    Friend WithEvents cmbQuienRegistro As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbUbicacionDestino As ComboBox
    Friend WithEvents Label1 As Label

End Class
