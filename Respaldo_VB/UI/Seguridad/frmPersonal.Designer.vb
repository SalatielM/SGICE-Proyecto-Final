<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonal))
        label1 = New Label()
        GroupBox1 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        cmbEstado = New ComboBox()
        txtCorreo = New TextBox()
        Label11 = New Label()
        Label7 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        txtTelefono = New TextBox()
        cmbPuesto = New ComboBox()
        Label4 = New Label()
        Label8 = New Label()
        txtCodPersonal = New TextBox()
        Label9 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtCedula = New TextBox()
        txtApellido = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        txtNombre = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        dgvPersonal = New DataGridView()
        IdPersonal = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Apellido = New DataGridViewTextBoxColumn()
        CodPersonal = New DataGridViewTextBoxColumn()
        Cedula = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Correo = New DataGridViewTextBoxColumn()
        PuestoId = New DataGridViewTextBoxColumn()
        Puesto = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox3 = New GroupBox()
        btnAgregar = New Button()
        picFotoPersonal = New PictureBox()
        GroupBox4 = New GroupBox()
        btnGuardarActualizar = New Button()
        btnNuevo = New Button()
        btnActivarDesactivar = New Button()
        GroupBox5 = New GroupBox()
        Button1 = New Button()
        txtBarraBusqueda = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvPersonal, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(picFotoPersonal, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
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
        label1.Text = "REGISTRO DE PERSONAL"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel3)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(226, 123)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(999, 231)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos del Personal"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.9997673F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0002365F))
        TableLayoutPanel3.Controls.Add(cmbEstado, 3, 0)
        TableLayoutPanel3.Controls.Add(txtCorreo, 1, 0)
        TableLayoutPanel3.Controls.Add(Label11, 0, 0)
        TableLayoutPanel3.Controls.Add(Label7, 2, 0)
        TableLayoutPanel3.Location = New Point(29, 158)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(655, 37)
        TableLayoutPanel3.TabIndex = 27
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(436, 3)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(216, 30)
        cmbEstado.TabIndex = 26
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCorreo.Location = New Point(94, 3)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(215, 31)
        txtCorreo.TabIndex = 8
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label11.Location = New Point(3, 5)
        Label11.Margin = New Padding(3, 5, 3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 24)
        Label11.TabIndex = 7
        Label11.Text = "Correo:"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label7.Location = New Point(315, 5)
        Label7.Margin = New Padding(3, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 24)
        Label7.TabIndex = 13
        Label7.Text = "    Estado:"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 6
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(txtTelefono, 5, 0)
        TableLayoutPanel2.Controls.Add(cmbPuesto, 3, 0)
        TableLayoutPanel2.Controls.Add(Label4, 4, 0)
        TableLayoutPanel2.Controls.Add(Label8, 2, 0)
        TableLayoutPanel2.Controls.Add(txtCodPersonal, 1, 0)
        TableLayoutPanel2.Controls.Add(Label9, 0, 0)
        TableLayoutPanel2.Location = New Point(29, 107)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(959, 36)
        TableLayoutPanel2.TabIndex = 25
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefono.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtTelefono.Location = New Point(782, 3)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(174, 31)
        txtTelefono.TabIndex = 18
        ' 
        ' cmbPuesto
        ' 
        cmbPuesto.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbPuesto.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbPuesto.FormattingEnabled = True
        cmbPuesto.Location = New Point(464, 3)
        cmbPuesto.Name = "cmbPuesto"
        cmbPuesto.Size = New Size(172, 30)
        cmbPuesto.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label4.Location = New Point(642, 5)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 24)
        Label4.TabIndex = 17
        Label4.Text = "    Telefono:"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label8.Location = New Point(345, 5)
        Label8.Margin = New Padding(3, 5, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 24)
        Label8.TabIndex = 11
        Label8.Text = "    Puesto:"
        ' 
        ' txtCodPersonal
        ' 
        txtCodPersonal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCodPersonal.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCodPersonal.Location = New Point(167, 3)
        txtCodPersonal.Name = "txtCodPersonal"
        txtCodPersonal.Size = New Size(172, 31)
        txtCodPersonal.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label9.Location = New Point(3, 5)
        Label9.Margin = New Padding(3, 5, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(158, 24)
        Label9.TabIndex = 7
        Label9.Text = "Cod. Personal:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(txtCedula, 5, 0)
        TableLayoutPanel1.Controls.Add(txtApellido, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 4, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(txtNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(29, 53)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(959, 36)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' txtCedula
        ' 
        txtCedula.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCedula.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCedula.Location = New Point(761, 3)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(195, 31)
        txtCedula.TabIndex = 16
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtApellido.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtApellido.Location = New Point(439, 3)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(195, 31)
        txtApellido.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(640, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 24)
        Label3.TabIndex = 13
        Label3.Text = "    Cedula:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label5.Location = New Point(306, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 24)
        Label5.TabIndex = 11
        Label5.Text = "    Apellido:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNombre.Location = New Point(105, 3)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(195, 31)
        txtNombre.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label2.Location = New Point(3, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 24)
        Label2.TabIndex = 7
        Label2.Text = "Nombre:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(dgvPersonal)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(22, 421)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1203, 332)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Lista de Personales"
        ' 
        ' dgvPersonal
        ' 
        dgvPersonal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPersonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPersonal.BackgroundColor = SystemColors.ButtonHighlight
        dgvPersonal.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvPersonal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPersonal.ColumnHeadersHeight = 35
        dgvPersonal.Columns.AddRange(New DataGridViewColumn() {IdPersonal, Nombre, Apellido, CodPersonal, Cedula, Telefono, Correo, PuestoId, Puesto, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvPersonal.DefaultCellStyle = DataGridViewCellStyle2
        dgvPersonal.GridColor = SystemColors.InactiveCaptionText
        dgvPersonal.Location = New Point(12, 44)
        dgvPersonal.Name = "dgvPersonal"
        dgvPersonal.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvPersonal.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvPersonal.RowHeadersWidth = 62
        dgvPersonal.Size = New Size(1180, 273)
        dgvPersonal.TabIndex = 32
        ' 
        ' IdPersonal
        ' 
        IdPersonal.DataPropertyName = "IdPersonal"
        IdPersonal.HeaderText = "IdPersonal"
        IdPersonal.MinimumWidth = 8
        IdPersonal.Name = "IdPersonal"
        IdPersonal.ReadOnly = True
        IdPersonal.Visible = False
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 8
        Nombre.Name = "Nombre"
        Nombre.ReadOnly = True
        ' 
        ' Apellido
        ' 
        Apellido.DataPropertyName = "Apellido"
        Apellido.HeaderText = "Apellido"
        Apellido.MinimumWidth = 8
        Apellido.Name = "Apellido"
        Apellido.ReadOnly = True
        ' 
        ' CodPersonal
        ' 
        CodPersonal.DataPropertyName = "CodPersonal"
        CodPersonal.HeaderText = "Cod Personal"
        CodPersonal.MinimumWidth = 8
        CodPersonal.Name = "CodPersonal"
        CodPersonal.ReadOnly = True
        ' 
        ' Cedula
        ' 
        Cedula.DataPropertyName = "Cedula"
        Cedula.HeaderText = "Cedula"
        Cedula.MinimumWidth = 8
        Cedula.Name = "Cedula"
        Cedula.ReadOnly = True
        ' 
        ' Telefono
        ' 
        Telefono.DataPropertyName = "Telefono"
        Telefono.HeaderText = "Telefono"
        Telefono.MinimumWidth = 8
        Telefono.Name = "Telefono"
        Telefono.ReadOnly = True
        ' 
        ' Correo
        ' 
        Correo.DataPropertyName = "Correo"
        Correo.HeaderText = "Correo"
        Correo.MinimumWidth = 8
        Correo.Name = "Correo"
        Correo.ReadOnly = True
        ' 
        ' PuestoId
        ' 
        PuestoId.DataPropertyName = "PuestoId"
        PuestoId.HeaderText = "PuestoId"
        PuestoId.MinimumWidth = 8
        PuestoId.Name = "PuestoId"
        PuestoId.ReadOnly = True
        PuestoId.Visible = False
        ' 
        ' Puesto
        ' 
        Puesto.DataPropertyName = "Puesto"
        Puesto.HeaderText = "Puesto"
        Puesto.MinimumWidth = 8
        Puesto.Name = "Puesto"
        Puesto.ReadOnly = True
        ' 
        ' EstadoId
        ' 
        EstadoId.DataPropertyName = "EstadoId"
        EstadoId.HeaderText = "EstadoId"
        EstadoId.MinimumWidth = 8
        EstadoId.Name = "EstadoId"
        EstadoId.ReadOnly = True
        EstadoId.Visible = False
        ' 
        ' Estado
        ' 
        Estado.DataPropertyName = "Estado"
        Estado.HeaderText = "Estado"
        Estado.MinimumWidth = 8
        Estado.Name = "Estado"
        Estado.ReadOnly = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnAgregar)
        GroupBox3.Controls.Add(picFotoPersonal)
        GroupBox3.Location = New Point(22, 123)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(197, 231)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAgregar.BackColor = Color.LightCyan
        btnAgregar.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregar.Location = New Point(10, 186)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(170, 37)
        btnAgregar.TabIndex = 40
        btnAgregar.Text = "Agregar Foto"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' picFotoPersonal
        ' 
        picFotoPersonal.BorderStyle = BorderStyle.FixedSingle
        picFotoPersonal.Location = New Point(12, 25)
        picFotoPersonal.Name = "picFotoPersonal"
        picFotoPersonal.Size = New Size(170, 156)
        picFotoPersonal.SizeMode = PictureBoxSizeMode.Zoom
        picFotoPersonal.TabIndex = 39
        picFotoPersonal.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(btnGuardarActualizar)
        GroupBox4.Controls.Add(btnNuevo)
        GroupBox4.Controls.Add(btnActivarDesactivar)
        GroupBox4.Location = New Point(22, 353)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1203, 62)
        GroupBox4.TabIndex = 40
        GroupBox4.TabStop = False
        ' 
        ' btnGuardarActualizar
        ' 
        btnGuardarActualizar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardarActualizar.BackColor = Color.Honeydew
        btnGuardarActualizar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnGuardarActualizar.Location = New Point(998, 20)
        btnGuardarActualizar.Name = "btnGuardarActualizar"
        btnGuardarActualizar.Size = New Size(194, 34)
        btnGuardarActualizar.TabIndex = 39
        btnGuardarActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNuevo.BackColor = Color.LightCyan
        btnNuevo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnNuevo.Location = New Point(614, 20)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(191, 34)
        btnNuevo.TabIndex = 37
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnActivarDesactivar
        ' 
        btnActivarDesactivar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnActivarDesactivar.BackColor = Color.MistyRose
        btnActivarDesactivar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnActivarDesactivar.Location = New Point(811, 20)
        btnActivarDesactivar.Name = "btnActivarDesactivar"
        btnActivarDesactivar.Size = New Size(181, 34)
        btnActivarDesactivar.TabIndex = 38
        btnActivarDesactivar.UseVisualStyleBackColor = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox5.Controls.Add(Button1)
        GroupBox5.Controls.Add(txtBarraBusqueda)
        GroupBox5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(22, 40)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(1203, 79)
        GroupBox5.TabIndex = 41
        GroupBox5.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(1142, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(50, 49)
        Button1.TabIndex = 42
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(10, 27)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1126, 36)
        txtBarraBusqueda.TabIndex = 0
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frmPersonal
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmPersonal"
        Text = "frmGestionPersonal"
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvPersonal, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(picFotoPersonal, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbPuesto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodPersonal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvPersonal As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtBarraBusqueda As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents IdPersonal As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents CodPersonal As DataGridViewTextBoxColumn
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents PuestoId As DataGridViewTextBoxColumn
    Friend WithEvents Puesto As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As Button
    Friend WithEvents picFotoPersonal As PictureBox
    Friend WithEvents btnGuardarActualizar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnActivarDesactivar As Button
End Class
