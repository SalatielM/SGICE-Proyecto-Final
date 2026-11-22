<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarcas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarcas))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox1 = New GroupBox()
        btnBuscar = New Button()
        txtBarraBusqueda = New TextBox()
        GroupBox2 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        rtxtDescripcion = New RichTextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        cmbEstado = New ComboBox()
        lbletado = New Label()
        txtNombre = New TextBox()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        dgvMarcas = New DataGridView()
        IdMarca = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Descripcion = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox4 = New GroupBox()
        btnNuevo = New Button()
        btnActivarDesactivar = New Button()
        btnGuardarActualizar = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvMarcas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.BackColor = SystemColors.ActiveCaption
        label1.BorderStyle = BorderStyle.Fixed3D
        label1.Dock = DockStyle.Top
        label1.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(0, 0)
        label1.Name = "label1"
        label1.Size = New Size(1247, 37)
        label1.TabIndex = 3
        label1.Text = "REGISTRO DE MARCAS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(txtBarraBusqueda)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(30, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1190, 79)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscar.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.Location = New Point(1129, 21)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(50, 49)
        btnBuscar.TabIndex = 2
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(10, 27)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1117, 36)
        txtBarraBusqueda.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel3)
        GroupBox2.Controls.Add(TableLayoutPanel2)
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(30, 123)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1190, 220)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos de la Marca"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.Controls.Add(rtxtDescripcion, 0, 0)
        TableLayoutPanel3.Location = New Point(10, 121)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(1169, 85)
        TableLayoutPanel3.TabIndex = 23
        ' 
        ' rtxtDescripcion
        ' 
        rtxtDescripcion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rtxtDescripcion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rtxtDescripcion.Location = New Point(3, 3)
        rtxtDescripcion.Name = "rtxtDescripcion"
        rtxtDescripcion.Size = New Size(1163, 79)
        rtxtDescripcion.TabIndex = 21
        rtxtDescripcion.Text = ""
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Location = New Point(10, 84)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1169, 38)
        TableLayoutPanel2.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(3, 5)
        Label7.Margin = New Padding(3, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(1163, 25)
        Label7.TabIndex = 17
        Label7.Text = "Descripcion:"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0000076F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(cmbEstado, 3, 0)
        TableLayoutPanel1.Controls.Add(lbletado, 2, 0)
        TableLayoutPanel1.Controls.Add(txtNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(10, 40)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1169, 36)
        TableLayoutPanel1.TabIndex = 21
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.DropDownWidth = 132
        cmbEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEstado.FormattingEnabled = True
        cmbEstado.IntegralHeight = False
        cmbEstado.Location = New Point(709, 3)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(457, 30)
        cmbEstado.TabIndex = 12
        ' 
        ' lbletado
        ' 
        lbletado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lbletado.AutoSize = True
        lbletado.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbletado.Location = New Point(578, 5)
        lbletado.Margin = New Padding(3, 5, 3, 0)
        lbletado.Name = "lbletado"
        lbletado.Size = New Size(125, 25)
        lbletado.TabIndex = 11
        lbletado.Text = "    Estado:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNombre.Location = New Point(116, 3)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(456, 31)
        txtNombre.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 7
        Label2.Text = "Nombre:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(dgvMarcas)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(30, 414)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1190, 339)
        GroupBox3.TabIndex = 8
        GroupBox3.TabStop = False
        GroupBox3.Text = "Lista de Marcas"
        ' 
        ' dgvMarcas
        ' 
        dgvMarcas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMarcas.BackgroundColor = SystemColors.ButtonHighlight
        dgvMarcas.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvMarcas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvMarcas.ColumnHeadersHeight = 35
        dgvMarcas.Columns.AddRange(New DataGridViewColumn() {IdMarca, Nombre, Descripcion, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvMarcas.DefaultCellStyle = DataGridViewCellStyle2
        dgvMarcas.GridColor = SystemColors.InactiveCaptionText
        dgvMarcas.Location = New Point(10, 45)
        dgvMarcas.Name = "dgvMarcas"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvMarcas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvMarcas.RowHeadersWidth = 62
        dgvMarcas.Size = New Size(1169, 276)
        dgvMarcas.TabIndex = 1
        ' 
        ' IdMarca
        ' 
        IdMarca.DataPropertyName = "IdMarca"
        IdMarca.HeaderText = "IdMarca"
        IdMarca.MinimumWidth = 8
        IdMarca.Name = "IdMarca"
        IdMarca.Visible = False
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 8
        Nombre.Name = "Nombre"
        ' 
        ' Descripcion
        ' 
        Descripcion.DataPropertyName = "Descripcion"
        Descripcion.HeaderText = "Descripcion"
        Descripcion.MinimumWidth = 8
        Descripcion.Name = "Descripcion"
        ' 
        ' EstadoId
        ' 
        EstadoId.DataPropertyName = "EstadoId"
        EstadoId.HeaderText = "EstadoId"
        EstadoId.MinimumWidth = 8
        EstadoId.Name = "EstadoId"
        EstadoId.Visible = False
        ' 
        ' Estado
        ' 
        Estado.DataPropertyName = "Estado"
        Estado.HeaderText = "Estado"
        Estado.MinimumWidth = 8
        Estado.Name = "Estado"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(btnNuevo)
        GroupBox4.Controls.Add(btnActivarDesactivar)
        GroupBox4.Controls.Add(btnGuardarActualizar)
        GroupBox4.Controls.Add(Button2)
        GroupBox4.Controls.Add(Button3)
        GroupBox4.Controls.Add(Button4)
        GroupBox4.Location = New Point(30, 346)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1190, 62)
        GroupBox4.TabIndex = 43
        GroupBox4.TabStop = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNuevo.BackColor = Color.LightCyan
        btnNuevo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnNuevo.Location = New Point(587, 20)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(191, 34)
        btnNuevo.TabIndex = 43
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnActivarDesactivar
        ' 
        btnActivarDesactivar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnActivarDesactivar.BackColor = Color.MistyRose
        btnActivarDesactivar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnActivarDesactivar.Location = New Point(785, 20)
        btnActivarDesactivar.Name = "btnActivarDesactivar"
        btnActivarDesactivar.Size = New Size(181, 34)
        btnActivarDesactivar.TabIndex = 44
        btnActivarDesactivar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarActualizar
        ' 
        btnGuardarActualizar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardarActualizar.BackColor = Color.Honeydew
        btnGuardarActualizar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnGuardarActualizar.Location = New Point(972, 20)
        btnGuardarActualizar.Name = "btnGuardarActualizar"
        btnGuardarActualizar.Size = New Size(194, 34)
        btnGuardarActualizar.TabIndex = 45
        btnGuardarActualizar.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.BackColor = Color.LightCyan
        Button2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Button2.Location = New Point(2503, -97)
        Button2.Name = "Button2"
        Button2.Size = New Size(191, 34)
        Button2.TabIndex = 34
        Button2.Text = "Nuevo"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button3.BackColor = Color.MistyRose
        Button3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Button3.Location = New Point(2700, -97)
        Button3.Name = "Button3"
        Button3.Size = New Size(181, 34)
        Button3.TabIndex = 35
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button4.BackColor = Color.Honeydew
        Button4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Button4.Location = New Point(2887, -97)
        Button4.Name = "Button4"
        Button4.Size = New Size(194, 34)
        Button4.TabIndex = 36
        Button4.UseVisualStyleBackColor = False
        ' 
        ' frmMarcas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMarcas"
        Text = "frmRegistroMarca"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(dgvMarcas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents rtxtDescripcion As RichTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents lbletado As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvMarcas As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnActivarDesactivar As Button
    Friend WithEvents btnGuardarActualizar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents IdMarca As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBarraBusqueda As TextBox
End Class
