<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFiltroPrestamo
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
        GroupBox2 = New GroupBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        cmbMarca = New ComboBox()
        Label1 = New Label()
        cmbEtiqueta = New ComboBox()
        cmbActivo = New ComboBox()
        Label15 = New Label()
        Label16 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        cmbEstado = New ComboBox()
        Label3 = New Label()
        cmbQuienRegistra = New ComboBox()
        cmbSolicitante = New ComboBox()
        Label12 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        dtpFechaDesde = New DateTimePicker()
        dtpFechaHasta = New DateTimePicker()
        Label10 = New Label()
        Label11 = New Label()
        GroupBox2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel5)
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(19, 76)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1141, 114)
        GroupBox2.TabIndex = 38
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
        TableLayoutPanel5.Controls.Add(cmbMarca, 5, 0)
        TableLayoutPanel5.Controls.Add(Label1, 4, 0)
        TableLayoutPanel5.Controls.Add(cmbEtiqueta, 3, 0)
        TableLayoutPanel5.Controls.Add(cmbActivo, 1, 0)
        TableLayoutPanel5.Controls.Add(Label15, 2, 0)
        TableLayoutPanel5.Controls.Add(Label16, 0, 0)
        TableLayoutPanel5.Location = New Point(21, 67)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(1101, 36)
        TableLayoutPanel5.TabIndex = 31
        ' 
        ' cmbMarca
        ' 
        cmbMarca.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbMarca.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbMarca.FormattingEnabled = True
        cmbMarca.Location = New Point(851, 3)
        cmbMarca.Name = "cmbMarca"
        cmbMarca.Size = New Size(247, 30)
        cmbMarca.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label1.Location = New Point(737, 5)
        Label1.Margin = New Padding(3, 5, 3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 24)
        Label1.TabIndex = 18
        Label1.Text = "    Marca:"
        ' 
        ' cmbEtiqueta
        ' 
        cmbEtiqueta.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEtiqueta.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEtiqueta.FormattingEnabled = True
        cmbEtiqueta.Location = New Point(484, 3)
        cmbEtiqueta.Name = "cmbEtiqueta"
        cmbEtiqueta.Size = New Size(247, 30)
        cmbEtiqueta.TabIndex = 17
        ' 
        ' cmbActivo
        ' 
        cmbActivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbActivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbActivo.FormattingEnabled = True
        cmbActivo.Location = New Point(92, 3)
        cmbActivo.Name = "cmbActivo"
        cmbActivo.Size = New Size(247, 30)
        cmbActivo.TabIndex = 15
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label15.Location = New Point(345, 5)
        Label15.Margin = New Padding(3, 5, 3, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(133, 24)
        Label15.TabIndex = 11
        Label15.Text = "    Etiqueta:"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label16.Location = New Point(3, 5)
        Label16.Margin = New Padding(3, 5, 3, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(83, 24)
        Label16.TabIndex = 7
        Label16.Text = "Activo:"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(cmbEstado, 5, 0)
        TableLayoutPanel1.Controls.Add(Label3, 4, 0)
        TableLayoutPanel1.Controls.Add(cmbQuienRegistra, 3, 0)
        TableLayoutPanel1.Controls.Add(cmbSolicitante, 1, 0)
        TableLayoutPanel1.Controls.Add(Label12, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Location = New Point(21, 25)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1101, 36)
        TableLayoutPanel1.TabIndex = 30
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(891, 3)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(207, 30)
        cmbEstado.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(770, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 24)
        Label3.TabIndex = 18
        Label3.Text = "    Estado:"
        ' 
        ' cmbQuienRegistra
        ' 
        cmbQuienRegistra.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbQuienRegistra.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbQuienRegistra.FormattingEnabled = True
        cmbQuienRegistra.Location = New Point(557, 3)
        cmbQuienRegistra.Name = "cmbQuienRegistra"
        cmbQuienRegistra.Size = New Size(207, 30)
        cmbQuienRegistra.TabIndex = 17
        ' 
        ' cmbSolicitante
        ' 
        cmbSolicitante.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbSolicitante.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbSolicitante.FormattingEnabled = True
        cmbSolicitante.Location = New Point(139, 3)
        cmbSolicitante.Name = "cmbSolicitante"
        cmbSolicitante.Size = New Size(207, 30)
        cmbSolicitante.TabIndex = 15
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label12.Location = New Point(3, 5)
        Label12.Margin = New Padding(3, 5, 3, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(130, 24)
        Label12.TabIndex = 7
        Label12.Text = "Solicitante:"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label2.Location = New Point(352, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(199, 24)
        Label2.TabIndex = 11
        Label2.Text = "    Quien Registra:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel4)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(19, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1141, 75)
        GroupBox1.TabIndex = 37
        GroupBox1.TabStop = False
        GroupBox1.Text = "Fecha de Prestamos"
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
        TableLayoutPanel4.Size = New Size(1101, 36)
        TableLayoutPanel4.TabIndex = 30
        ' 
        ' dtpFechaDesde
        ' 
        dtpFechaDesde.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaDesde.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaDesde.Location = New Point(86, 3)
        dtpFechaDesde.Name = "dtpFechaDesde"
        dtpFechaDesde.Size = New Size(448, 31)
        dtpFechaDesde.TabIndex = 17
        ' 
        ' dtpFechaHasta
        ' 
        dtpFechaHasta.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaHasta.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaHasta.Location = New Point(650, 3)
        dtpFechaHasta.Name = "dtpFechaHasta"
        dtpFechaHasta.Size = New Size(448, 31)
        dtpFechaHasta.TabIndex = 7
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label10.Location = New Point(540, 5)
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
        ' ucFiltroPrestamo
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ucFiltroPrestamo"
        Size = New Size(1178, 195)
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEtiqueta As ComboBox
    Friend WithEvents cmbActivo As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbQuienRegistra As ComboBox
    Friend WithEvents cmbSolicitante As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label

End Class
