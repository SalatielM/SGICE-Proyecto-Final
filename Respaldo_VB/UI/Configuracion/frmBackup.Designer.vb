<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        GroupBox1 = New GroupBox()
        btnCrearCopiaSeguridad = New Button()
        btnCrearExaminar = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        txtNombreArchivo = New TextBox()
        Label9 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtRutaDestino = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        btnRestaurarCopias = New Button()
        btnRestaurarExaminar = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        txtArchivorRespaldo = New TextBox()
        Label3 = New Label()
        GroupBox3 = New GroupBox()
        dgvHistorialBackup = New DataGridView()
        IdBackup = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        RutaBackup = New DataGridViewTextBoxColumn()
        FechaCreacion = New DataGridViewTextBoxColumn()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvHistorialBackup, ComponentModel.ISupportInitialize).BeginInit()
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
        label1.TabIndex = 9
        label1.Text = "GESTION DE COPIAS DE SEGURIDAD"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnCrearCopiaSeguridad)
        GroupBox1.Controls.Add(btnCrearExaminar)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(27, 53)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1190, 208)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Copia de Seguridad"
        ' 
        ' btnCrearCopiaSeguridad
        ' 
        btnCrearCopiaSeguridad.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnCrearCopiaSeguridad.BackColor = Color.Honeydew
        btnCrearCopiaSeguridad.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnCrearCopiaSeguridad.Location = New Point(16, 157)
        btnCrearCopiaSeguridad.Name = "btnCrearCopiaSeguridad"
        btnCrearCopiaSeguridad.Size = New Size(1160, 34)
        btnCrearCopiaSeguridad.TabIndex = 38
        btnCrearCopiaSeguridad.Text = "Crear Copia de Seguridad"
        btnCrearCopiaSeguridad.UseVisualStyleBackColor = False
        ' 
        ' btnCrearExaminar
        ' 
        btnCrearExaminar.Anchor = AnchorStyles.Right
        btnCrearExaminar.BackColor = Color.Honeydew
        btnCrearExaminar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnCrearExaminar.Location = New Point(984, 52)
        btnCrearExaminar.Name = "btnCrearExaminar"
        btnCrearExaminar.Size = New Size(192, 34)
        btnCrearExaminar.TabIndex = 37
        btnCrearExaminar.Text = "Examinar"
        btnCrearExaminar.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.Controls.Add(txtNombreArchivo, 1, 0)
        TableLayoutPanel2.Controls.Add(Label9, 0, 0)
        TableLayoutPanel2.Location = New Point(16, 106)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1159, 39)
        TableLayoutPanel2.TabIndex = 25
        ' 
        ' txtNombreArchivo
        ' 
        txtNombreArchivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombreArchivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNombreArchivo.Location = New Point(229, 3)
        txtNombreArchivo.Name = "txtNombreArchivo"
        txtNombreArchivo.Size = New Size(927, 31)
        txtNombreArchivo.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label9.Location = New Point(3, 5)
        Label9.Margin = New Padding(3, 5, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(220, 24)
        Label9.TabIndex = 7
        Label9.Text = "Nombre del Archivo:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(txtRutaDestino, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(16, 53)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(962, 37)
        TableLayoutPanel1.TabIndex = 24
        ' 
        ' txtRutaDestino
        ' 
        txtRutaDestino.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtRutaDestino.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtRutaDestino.Location = New Point(192, 3)
        txtRutaDestino.Name = "txtRutaDestino"
        txtRutaDestino.Size = New Size(767, 31)
        txtRutaDestino.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label2.Location = New Point(3, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 24)
        Label2.TabIndex = 7
        Label2.Text = "Ruta de Destino:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnRestaurarCopias)
        GroupBox2.Controls.Add(btnRestaurarExaminar)
        GroupBox2.Controls.Add(TableLayoutPanel3)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(27, 279)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1190, 162)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Recuperacion"
        ' 
        ' btnRestaurarCopias
        ' 
        btnRestaurarCopias.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnRestaurarCopias.BackColor = Color.Honeydew
        btnRestaurarCopias.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnRestaurarCopias.Location = New Point(14, 107)
        btnRestaurarCopias.Name = "btnRestaurarCopias"
        btnRestaurarCopias.Size = New Size(1162, 34)
        btnRestaurarCopias.TabIndex = 42
        btnRestaurarCopias.Text = "Restaurar Copia"
        btnRestaurarCopias.UseVisualStyleBackColor = False
        ' 
        ' btnRestaurarExaminar
        ' 
        btnRestaurarExaminar.Anchor = AnchorStyles.Right
        btnRestaurarExaminar.BackColor = Color.Honeydew
        btnRestaurarExaminar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnRestaurarExaminar.Location = New Point(985, 52)
        btnRestaurarExaminar.Name = "btnRestaurarExaminar"
        btnRestaurarExaminar.Size = New Size(191, 34)
        btnRestaurarExaminar.TabIndex = 41
        btnRestaurarExaminar.Text = "Examinar"
        btnRestaurarExaminar.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.Controls.Add(txtArchivorRespaldo, 1, 0)
        TableLayoutPanel3.Controls.Add(Label3, 0, 0)
        TableLayoutPanel3.Location = New Point(14, 52)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(966, 37)
        TableLayoutPanel3.TabIndex = 38
        ' 
        ' txtArchivorRespaldo
        ' 
        txtArchivorRespaldo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtArchivorRespaldo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtArchivorRespaldo.Location = New Point(235, 3)
        txtArchivorRespaldo.Name = "txtArchivorRespaldo"
        txtArchivorRespaldo.Size = New Size(728, 31)
        txtArchivorRespaldo.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(3, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(226, 24)
        Label3.TabIndex = 7
        Label3.Text = "Archivo de Respaldo:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(dgvHistorialBackup)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(27, 453)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1190, 300)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "Historial de Copias de Seguridad"
        ' 
        ' dgvHistorialBackup
        ' 
        dgvHistorialBackup.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHistorialBackup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHistorialBackup.BackgroundColor = SystemColors.ButtonHighlight
        dgvHistorialBackup.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvHistorialBackup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvHistorialBackup.ColumnHeadersHeight = 35
        dgvHistorialBackup.Columns.AddRange(New DataGridViewColumn() {IdBackup, Nombre, RutaBackup, FechaCreacion})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvHistorialBackup.DefaultCellStyle = DataGridViewCellStyle2
        dgvHistorialBackup.GridColor = SystemColors.InactiveCaptionText
        dgvHistorialBackup.Location = New Point(14, 54)
        dgvHistorialBackup.Name = "dgvHistorialBackup"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvHistorialBackup.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvHistorialBackup.RowHeadersVisible = False
        dgvHistorialBackup.RowHeadersWidth = 62
        dgvHistorialBackup.Size = New Size(1162, 223)
        dgvHistorialBackup.TabIndex = 32
        ' 
        ' IdBackup
        ' 
        IdBackup.DataPropertyName = "IdBackup"
        IdBackup.HeaderText = "IdBackup"
        IdBackup.MinimumWidth = 8
        IdBackup.Name = "IdBackup"
        IdBackup.Visible = False
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 8
        Nombre.Name = "Nombre"
        ' 
        ' RutaBackup
        ' 
        RutaBackup.DataPropertyName = "RutaBackup"
        RutaBackup.HeaderText = "Ruta"
        RutaBackup.MinimumWidth = 8
        RutaBackup.Name = "RutaBackup"
        ' 
        ' FechaCreacion
        ' 
        FechaCreacion.DataPropertyName = "FechaCreacion"
        FechaCreacion.HeaderText = "Fecha Creacion"
        FechaCreacion.MinimumWidth = 8
        FechaCreacion.Name = "FechaCreacion"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frmBackup
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmBackup"
        Text = "frmBackup"
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(dgvHistorialBackup, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtNombreArchivo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtRutaDestino As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCrearExaminar As Button
    Friend WithEvents btnCrearCopiaSeguridad As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtArchivorRespaldo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRestaurarCopias As Button
    Friend WithEvents btnRestaurarExaminar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvHistorialBackup As DataGridView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents IdBackup As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents RutaBackup As DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacion As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
