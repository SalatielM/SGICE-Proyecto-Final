<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        label1 = New Label()
        GroupBox1 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        cbmEstado = New ComboBox()
        txtContrasena = New TextBox()
        Label10 = New Label()
        Label7 = New Label()
        txtUsuario = New TextBox()
        Label11 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label4 = New Label()
        cmbRol = New ComboBox()
        txtCorreo = New TextBox()
        txtTelefono = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtCedula = New TextBox()
        txtApellido = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        txtNombre = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        dgvUsuarios = New DataGridView()
        IdUsuario = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Apellido = New DataGridViewTextBoxColumn()
        NombreUsuario = New DataGridViewTextBoxColumn()
        Cedula = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Correo = New DataGridViewTextBoxColumn()
        RolId = New DataGridViewTextBoxColumn()
        Rol = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox3 = New GroupBox()
        btnAgregarFoto = New Button()
        picFotoUsuario = New PictureBox()
        GroupBox4 = New GroupBox()
        btnCambiarClave = New Button()
        btnNuevo = New Button()
        btnActivarDesactivar = New Button()
        btnGuardarActualizar = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox5 = New GroupBox()
        Button1 = New Button()
        txtBarraBusqueda = New TextBox()
        GroupBox1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(picFotoUsuario, ComponentModel.ISupportInitialize).BeginInit()
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
        label1.TabIndex = 8
        label1.Text = "REGISTRO DE USUARIOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel3)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Location = New Point(215, 123)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(1007, 231)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos del Usuario"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 6
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33318F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33349F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel3.Controls.Add(cbmEstado, 5, 0)
        TableLayoutPanel3.Controls.Add(txtContrasena, 3, 0)
        TableLayoutPanel3.Controls.Add(Label10, 2, 0)
        TableLayoutPanel3.Controls.Add(Label7, 4, 0)
        TableLayoutPanel3.Controls.Add(txtUsuario, 1, 0)
        TableLayoutPanel3.Controls.Add(Label11, 0, 0)
        TableLayoutPanel3.Location = New Point(27, 162)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(969, 37)
        TableLayoutPanel3.TabIndex = 27
        ' 
        ' cbmEstado
        ' 
        cbmEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cbmEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cbmEstado.FormattingEnabled = True
        cbmEstado.Location = New Point(790, 3)
        cbmEstado.Name = "cbmEstado"
        cbmEstado.Size = New Size(176, 30)
        cbmEstado.TabIndex = 26
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtContrasena.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtContrasena.Location = New Point(478, 3)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(175, 31)
        txtContrasena.TabIndex = 27
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(295, 5)
        Label10.Margin = New Padding(3, 5, 3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(177, 25)
        Label10.TabIndex = 11
        Label10.Text = "    Contraseña:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(659, 5)
        Label7.Margin = New Padding(3, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 25)
        Label7.TabIndex = 13
        Label7.Text = "    Estado:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtUsuario.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtUsuario.Location = New Point(115, 3)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(174, 31)
        txtUsuario.TabIndex = 8
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(3, 5)
        Label11.Margin = New Padding(3, 5, 3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 25)
        Label11.TabIndex = 7
        Label11.Text = "Usuario:"
        Label11.TextAlign = ContentAlignment.MiddleLeft
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
        TableLayoutPanel2.Controls.Add(Label4, 2, 0)
        TableLayoutPanel2.Controls.Add(cmbRol, 5, 0)
        TableLayoutPanel2.Controls.Add(txtCorreo, 1, 0)
        TableLayoutPanel2.Controls.Add(txtTelefono, 3, 0)
        TableLayoutPanel2.Controls.Add(Label9, 0, 0)
        TableLayoutPanel2.Controls.Add(Label8, 4, 0)
        TableLayoutPanel2.Location = New Point(27, 109)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(969, 36)
        TableLayoutPanel2.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(312, 5)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 25)
        Label4.TabIndex = 17
        Label4.Text = "    Telefono:"
        ' 
        ' cmbRol
        ' 
        cmbRol.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbRol.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbRol.FormattingEnabled = True
        cmbRol.Location = New Point(763, 3)
        cmbRol.Name = "cmbRol"
        cmbRol.Size = New Size(203, 30)
        cmbRol.TabIndex = 25
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCorreo.Location = New Point(105, 3)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(201, 31)
        txtCorreo.TabIndex = 8
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefono.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtTelefono.Location = New Point(465, 3)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(201, 31)
        txtTelefono.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(3, 5)
        Label9.Margin = New Padding(3, 5, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 25)
        Label9.TabIndex = 7
        Label9.Text = "Correo:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(672, 5)
        Label8.Margin = New Padding(3, 5, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 25)
        Label8.TabIndex = 11
        Label8.Text = "    Rol:"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(txtCedula, 5, 0)
        TableLayoutPanel1.Controls.Add(txtApellido, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 4, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(txtNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(27, 52)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(969, 36)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' txtCedula
        ' 
        txtCedula.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCedula.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCedula.Location = New Point(779, 3)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(187, 31)
        txtCedula.TabIndex = 16
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtApellido.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtApellido.Location = New Point(455, 3)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(187, 31)
        txtApellido.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(648, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 25)
        Label3.TabIndex = 13
        Label3.Text = "    Cedula:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(309, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 25)
        Label5.TabIndex = 11
        Label5.Text = "    Apellido:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNombre.Location = New Point(116, 3)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(187, 31)
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
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(dgvUsuarios)
        GroupBox2.Location = New Point(19, 421)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1203, 326)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Lista de Usuarios"
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsuarios.BackgroundColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUsuarios.ColumnHeadersHeight = 35
        dgvUsuarios.Columns.AddRange(New DataGridViewColumn() {IdUsuario, Nombre, Apellido, NombreUsuario, Cedula, Telefono, Correo, RolId, Rol, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        dgvUsuarios.Location = New Point(10, 39)
        dgvUsuarios.Name = "dgvUsuarios"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvUsuarios.RowHeadersWidth = 62
        dgvUsuarios.Size = New Size(1179, 273)
        dgvUsuarios.TabIndex = 0
        ' 
        ' IdUsuario
        ' 
        IdUsuario.DataPropertyName = "IdUsuario"
        IdUsuario.HeaderText = "IdUsuario"
        IdUsuario.MinimumWidth = 8
        IdUsuario.Name = "IdUsuario"
        IdUsuario.Visible = False
        IdUsuario.Width = 150
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 8
        Nombre.Name = "Nombre"
        Nombre.Width = 150
        ' 
        ' Apellido
        ' 
        Apellido.DataPropertyName = "Apellido"
        Apellido.HeaderText = "Apellido"
        Apellido.MinimumWidth = 8
        Apellido.Name = "Apellido"
        Apellido.Width = 150
        ' 
        ' NombreUsuario
        ' 
        NombreUsuario.DataPropertyName = "NombreUsuario"
        NombreUsuario.HeaderText = "Usuario"
        NombreUsuario.MinimumWidth = 8
        NombreUsuario.Name = "NombreUsuario"
        NombreUsuario.Width = 150
        ' 
        ' Cedula
        ' 
        Cedula.DataPropertyName = "Cedula"
        Cedula.HeaderText = "Cedula"
        Cedula.MinimumWidth = 8
        Cedula.Name = "Cedula"
        Cedula.Width = 150
        ' 
        ' Telefono
        ' 
        Telefono.DataPropertyName = "Telefono"
        Telefono.HeaderText = "Telefono"
        Telefono.MinimumWidth = 8
        Telefono.Name = "Telefono"
        Telefono.Width = 150
        ' 
        ' Correo
        ' 
        Correo.DataPropertyName = "Correo"
        Correo.HeaderText = "Correo"
        Correo.MinimumWidth = 8
        Correo.Name = "Correo"
        Correo.Width = 150
        ' 
        ' RolId
        ' 
        RolId.DataPropertyName = "RolId"
        RolId.HeaderText = "RolId"
        RolId.MinimumWidth = 8
        RolId.Name = "RolId"
        RolId.Visible = False
        RolId.Width = 150
        ' 
        ' Rol
        ' 
        Rol.DataPropertyName = "Rol"
        Rol.HeaderText = "Rol"
        Rol.MinimumWidth = 8
        Rol.Name = "Rol"
        Rol.Width = 150
        ' 
        ' EstadoId
        ' 
        EstadoId.DataPropertyName = "EstadoId"
        EstadoId.HeaderText = "EstadoId"
        EstadoId.MinimumWidth = 8
        EstadoId.Name = "EstadoId"
        EstadoId.Visible = False
        EstadoId.Width = 150
        ' 
        ' Estado
        ' 
        Estado.DataPropertyName = "Estado"
        Estado.HeaderText = "Estado"
        Estado.MinimumWidth = 8
        Estado.Name = "Estado"
        Estado.Width = 150
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnAgregarFoto)
        GroupBox3.Controls.Add(picFotoUsuario)
        GroupBox3.Location = New Point(19, 123)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(189, 231)
        GroupBox3.TabIndex = 11
        GroupBox3.TabStop = False
        ' 
        ' btnAgregarFoto
        ' 
        btnAgregarFoto.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAgregarFoto.BackColor = Color.LightCyan
        btnAgregarFoto.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregarFoto.Location = New Point(10, 186)
        btnAgregarFoto.Name = "btnAgregarFoto"
        btnAgregarFoto.Size = New Size(170, 37)
        btnAgregarFoto.TabIndex = 37
        btnAgregarFoto.Text = "Agregar Foto"
        btnAgregarFoto.UseVisualStyleBackColor = False
        ' 
        ' picFotoUsuario
        ' 
        picFotoUsuario.BorderStyle = BorderStyle.FixedSingle
        picFotoUsuario.Location = New Point(10, 26)
        picFotoUsuario.Name = "picFotoUsuario"
        picFotoUsuario.Size = New Size(170, 156)
        picFotoUsuario.SizeMode = PictureBoxSizeMode.Zoom
        picFotoUsuario.TabIndex = 36
        picFotoUsuario.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(btnCambiarClave)
        GroupBox4.Controls.Add(btnNuevo)
        GroupBox4.Controls.Add(btnActivarDesactivar)
        GroupBox4.Controls.Add(btnGuardarActualizar)
        GroupBox4.Location = New Point(19, 353)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1203, 62)
        GroupBox4.TabIndex = 12
        GroupBox4.TabStop = False
        ' 
        ' btnCambiarClave
        ' 
        btnCambiarClave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCambiarClave.BackColor = Color.LightCyan
        btnCambiarClave.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnCambiarClave.Location = New Point(409, 20)
        btnCambiarClave.Name = "btnCambiarClave"
        btnCambiarClave.Size = New Size(199, 34)
        btnCambiarClave.TabIndex = 37
        btnCambiarClave.Text = "Cambiar Clave"
        btnCambiarClave.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNuevo.BackColor = Color.LightCyan
        btnNuevo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnNuevo.Location = New Point(614, 20)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(191, 34)
        btnNuevo.TabIndex = 34
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
        btnActivarDesactivar.TabIndex = 35
        btnActivarDesactivar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarActualizar
        ' 
        btnGuardarActualizar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardarActualizar.BackColor = Color.Honeydew
        btnGuardarActualizar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnGuardarActualizar.Location = New Point(998, 20)
        btnGuardarActualizar.Name = "btnGuardarActualizar"
        btnGuardarActualizar.Size = New Size(194, 34)
        btnGuardarActualizar.TabIndex = 36
        btnGuardarActualizar.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox5.Controls.Add(Button1)
        GroupBox5.Controls.Add(txtBarraBusqueda)
        GroupBox5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(29, 40)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(1193, 79)
        GroupBox5.TabIndex = 13
        GroupBox5.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(1132, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(50, 49)
        Button1.TabIndex = 37
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(10, 27)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1116, 36)
        txtBarraBusqueda.TabIndex = 0
        ' 
        ' frmUsuario
        ' 
        AutoScaleDimensions = New SizeF(15F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmUsuario"
        Text = "frmGestionUsuario"
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(picFotoUsuario, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbmEstado As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAgregarFoto As Button
    Friend WithEvents picFotoUsuario As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnActivarDesactivar As Button
    Friend WithEvents btnGuardarActualizar As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtBarraBusqueda As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents NombreUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents RolId As DataGridViewTextBoxColumn
    Friend WithEvents Rol As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents btnCambiarClave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefono As TextBox
End Class
