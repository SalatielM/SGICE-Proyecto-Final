<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFiltroActivosFisicos
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
        TableLayoutPanel1 = New TableLayoutPanel()
        cmbEstado = New ComboBox()
        cmbEncargado = New ComboBox()
        cmbUbicacion = New ComboBox()
        Label3 = New Label()
        Label5 = New Label()
        Label16 = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        cmbCategoria = New ComboBox()
        cmbMarca = New ComboBox()
        cmbActivo = New ComboBox()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        GroupBox1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel4)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(19, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1141, 75)
        GroupBox1.TabIndex = 34
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
        TableLayoutPanel4.Location = New Point(21, 29)
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
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.Controls.Add(TableLayoutPanel5)
        GroupBox2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(19, 76)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1141, 114)
        GroupBox2.TabIndex = 35
        GroupBox2.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(cmbEstado, 3, 0)
        TableLayoutPanel1.Controls.Add(cmbEncargado, 5, 0)
        TableLayoutPanel1.Controls.Add(cmbUbicacion, 1, 0)
        TableLayoutPanel1.Controls.Add(Label3, 4, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(Label16, 0, 0)
        TableLayoutPanel1.Location = New Point(21, 67)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1099, 36)
        TableLayoutPanel1.TabIndex = 30
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(480, 3)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(224, 30)
        cmbEstado.TabIndex = 19
        ' 
        ' cmbEncargado
        ' 
        cmbEncargado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEncargado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEncargado.FormattingEnabled = True
        cmbEncargado.Location = New Point(871, 3)
        cmbEncargado.Name = "cmbEncargado"
        cmbEncargado.Size = New Size(225, 30)
        cmbEncargado.TabIndex = 18
        ' 
        ' cmbUbicacion
        ' 
        cmbUbicacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbUbicacion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbUbicacion.FormattingEnabled = True
        cmbUbicacion.Location = New Point(129, 3)
        cmbUbicacion.Name = "cmbUbicacion"
        cmbUbicacion.Size = New Size(224, 30)
        cmbUbicacion.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(710, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 24)
        Label3.TabIndex = 13
        Label3.Text = "    Encargado:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(359, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 24)
        Label5.TabIndex = 11
        Label5.Text = "    Estado:"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(3, 5)
        Label16.Margin = New Padding(3, 5, 3, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(120, 24)
        Label16.TabIndex = 7
        Label16.Text = "Ubicacion:"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel5.ColumnCount = 6
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel5.Controls.Add(cmbCategoria, 5, 0)
        TableLayoutPanel5.Controls.Add(cmbMarca, 3, 0)
        TableLayoutPanel5.Controls.Add(cmbActivo, 1, 0)
        TableLayoutPanel5.Controls.Add(Label13, 4, 0)
        TableLayoutPanel5.Controls.Add(Label14, 2, 0)
        TableLayoutPanel5.Controls.Add(Label15, 0, 0)
        TableLayoutPanel5.Location = New Point(21, 25)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(1099, 36)
        TableLayoutPanel5.TabIndex = 29
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCategoria.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(852, 3)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(244, 30)
        cmbCategoria.TabIndex = 18
        ' 
        ' cmbMarca
        ' 
        cmbMarca.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbMarca.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbMarca.FormattingEnabled = True
        cmbMarca.Location = New Point(454, 3)
        cmbMarca.Name = "cmbMarca"
        cmbMarca.Size = New Size(242, 30)
        cmbMarca.TabIndex = 17
        ' 
        ' cmbActivo
        ' 
        cmbActivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbActivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbActivo.FormattingEnabled = True
        cmbActivo.Location = New Point(92, 3)
        cmbActivo.Name = "cmbActivo"
        cmbActivo.Size = New Size(242, 30)
        cmbActivo.TabIndex = 15
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(702, 5)
        Label13.Margin = New Padding(3, 5, 3, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(144, 24)
        Label13.TabIndex = 13
        Label13.Text = "    Categoria:"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(340, 5)
        Label14.Margin = New Padding(3, 5, 3, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(108, 24)
        Label14.TabIndex = 11
        Label14.Text = "    Marca:"
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(3, 5)
        Label15.Margin = New Padding(3, 5, 3, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(83, 24)
        Label15.TabIndex = 7
        Label15.Text = "Activo:"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ucFiltroActivosFisicos
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ucFiltroActivosFisicos"
        Size = New Size(1178, 195)
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents cmbActivo As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmbEncargado As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents cmbUbicacion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbEstado As ComboBox

End Class
