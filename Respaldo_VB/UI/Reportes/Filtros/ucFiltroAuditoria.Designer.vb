<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFiltroAuditoria
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
        Label3 = New Label()
        cmbAccion = New ComboBox()
        cmbUsuario = New ComboBox()
        Label12 = New Label()
        Label2 = New Label()
        cmbTablaAfectada = New ComboBox()
        GroupBox1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel4)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(19, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1141, 75)
        GroupBox1.TabIndex = 37
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
        TableLayoutPanel4.Size = New Size(1097, 36)
        TableLayoutPanel4.TabIndex = 30
        ' 
        ' dtpFechaDesde
        ' 
        dtpFechaDesde.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaDesde.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaDesde.Location = New Point(86, 3)
        dtpFechaDesde.Name = "dtpFechaDesde"
        dtpFechaDesde.Size = New Size(446, 31)
        dtpFechaDesde.TabIndex = 17
        ' 
        ' dtpFechaHasta
        ' 
        dtpFechaHasta.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaHasta.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaHasta.Location = New Point(648, 3)
        dtpFechaHasta.Name = "dtpFechaHasta"
        dtpFechaHasta.Size = New Size(446, 31)
        dtpFechaHasta.TabIndex = 7
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label10.Location = New Point(538, 5)
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
        GroupBox2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(19, 84)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1141, 92)
        GroupBox2.TabIndex = 41
        GroupBox2.TabStop = False
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
        TableLayoutPanel1.Controls.Add(Label3, 4, 0)
        TableLayoutPanel1.Controls.Add(cmbAccion, 3, 0)
        TableLayoutPanel1.Controls.Add(cmbUsuario, 1, 0)
        TableLayoutPanel1.Controls.Add(Label12, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(cmbTablaAfectada, 5, 0)
        TableLayoutPanel1.Location = New Point(21, 35)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1097, 36)
        TableLayoutPanel1.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(672, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 24)
        Label3.TabIndex = 18
        Label3.Text = "    Tabla Afectada:"
        ' 
        ' cmbAccion
        ' 
        cmbAccion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbAccion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbAccion.FormattingEnabled = True
        cmbAccion.Location = New Point(449, 3)
        cmbAccion.Name = "cmbAccion"
        cmbAccion.Size = New Size(217, 30)
        cmbAccion.TabIndex = 17
        ' 
        ' cmbUsuario
        ' 
        cmbUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbUsuario.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbUsuario.FormattingEnabled = True
        cmbUsuario.Location = New Point(104, 3)
        cmbUsuario.Name = "cmbUsuario"
        cmbUsuario.Size = New Size(217, 30)
        cmbUsuario.TabIndex = 15
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label12.Location = New Point(3, 5)
        Label12.Margin = New Padding(3, 5, 3, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(95, 24)
        Label12.TabIndex = 7
        Label12.Text = "Usuario:"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label2.Location = New Point(327, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 24)
        Label2.TabIndex = 11
        Label2.Text = "    Accion:"
        ' 
        ' cmbTablaAfectada
        ' 
        cmbTablaAfectada.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbTablaAfectada.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbTablaAfectada.FormattingEnabled = True
        cmbTablaAfectada.Location = New Point(877, 3)
        cmbTablaAfectada.Name = "cmbTablaAfectada"
        cmbTablaAfectada.Size = New Size(217, 30)
        cmbTablaAfectada.TabIndex = 19
        ' 
        ' ucFiltroAuditoria
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "ucFiltroAuditoria"
        Size = New Size(1178, 195)
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEtiqueta As ComboBox
    Friend WithEvents cmbActivo As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmbTablaAfectada As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbAccion As ComboBox
    Friend WithEvents cmbUsuario As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label

End Class
