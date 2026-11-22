<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox1 = New GroupBox()
        btnBuscar = New Button()
        txtBarraBusqueda = New TextBox()
        GroupBox2 = New GroupBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        txtTelefonoContacto = New TextBox()
        Label7 = New Label()
        txtPersonaDeContacto = New TextBox()
        Label10 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        cmbEstado = New ComboBox()
        txtCorreo = New TextBox()
        txtDireccion = New TextBox()
        Label2 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtNombre = New TextBox()
        txtTelefono = New TextBox()
        txtRNC = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        GroupBox3 = New GroupBox()
        dgvProveedor = New DataGridView()
        IdProveedor = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        RNC = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Correo = New DataGridViewTextBoxColumn()
        Direccion = New DataGridViewTextBoxColumn()
        PersonalContacto = New DataGridViewTextBoxColumn()
        TelefonoContacto = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox4 = New GroupBox()
        btnNuevo = New Button()
        btnActivarDesactivar = New Button()
        btnGuardarActualizar = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvProveedor, ComponentModel.ISupportInitialize).BeginInit()
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
        label1.TabIndex = 4
        label1.Text = "REGISTRO DE PROVEEDORES"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(txtBarraBusqueda)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(31, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1181, 78)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscar.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.Location = New Point(1114, 21)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(50, 49)
        btnBuscar.TabIndex = 3
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(19, 27)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1089, 36)
        txtBarraBusqueda.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel2)
        GroupBox2.Controls.Add(TableLayoutPanel4)
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(31, 128)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1181, 179)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos de la Proveedores"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 53.22314F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 46.77686F))
        TableLayoutPanel2.Controls.Add(txtTelefonoContacto, 3, 0)
        TableLayoutPanel2.Controls.Add(Label7, 2, 0)
        TableLayoutPanel2.Controls.Add(txtPersonaDeContacto, 1, 0)
        TableLayoutPanel2.Controls.Add(Label10, 0, 0)
        TableLayoutPanel2.Location = New Point(19, 130)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1145, 36)
        TableLayoutPanel2.TabIndex = 29
        ' 
        ' txtTelefonoContacto
        ' 
        txtTelefonoContacto.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefonoContacto.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtTelefonoContacto.Location = New Point(865, 3)
        txtTelefonoContacto.Name = "txtTelefonoContacto"
        txtTelefonoContacto.Size = New Size(277, 31)
        txtTelefonoContacto.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(594, 5)
        Label7.Margin = New Padding(3, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(265, 25)
        Label7.TabIndex = 19
        Label7.Text = "Telefono de Contacto:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtPersonaDeContacto
        ' 
        txtPersonaDeContacto.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPersonaDeContacto.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtPersonaDeContacto.Location = New Point(272, 3)
        txtPersonaDeContacto.Name = "txtPersonaDeContacto"
        txtPersonaDeContacto.Size = New Size(316, 31)
        txtPersonaDeContacto.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(3, 5)
        Label10.Margin = New Padding(3, 5, 3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(263, 25)
        Label10.TabIndex = 7
        Label10.Text = "Personal de Contacto:"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 6
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.Controls.Add(cmbEstado, 5, 0)
        TableLayoutPanel4.Controls.Add(txtCorreo, 1, 0)
        TableLayoutPanel4.Controls.Add(txtDireccion, 3, 0)
        TableLayoutPanel4.Controls.Add(Label2, 4, 0)
        TableLayoutPanel4.Controls.Add(Label5, 2, 0)
        TableLayoutPanel4.Controls.Add(Label8, 0, 0)
        TableLayoutPanel4.Location = New Point(19, 85)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(1145, 36)
        TableLayoutPanel4.TabIndex = 28
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(898, 3)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(244, 30)
        cmbEstado.TabIndex = 11
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCorreo.Location = New Point(105, 3)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(243, 31)
        txtCorreo.TabIndex = 18
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDireccion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtDireccion.Location = New Point(518, 3)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(243, 31)
        txtDireccion.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(767, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 13
        Label2.Text = "    Estado:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(354, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 25)
        Label5.TabIndex = 11
        Label5.Text = "    Direccion:"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(3, 5)
        Label8.Margin = New Padding(3, 5, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 25)
        Label8.TabIndex = 7
        Label8.Text = "Correo:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
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
        TableLayoutPanel1.Controls.Add(txtNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(txtTelefono, 5, 0)
        TableLayoutPanel1.Controls.Add(txtRNC, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 4, 0)
        TableLayoutPanel1.Controls.Add(Label4, 2, 0)
        TableLayoutPanel1.Controls.Add(Label6, 0, 0)
        TableLayoutPanel1.Location = New Point(19, 38)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1145, 36)
        TableLayoutPanel1.TabIndex = 27
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtNombre.Location = New Point(116, 3)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(252, 31)
        txtNombre.TabIndex = 18
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefono.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtTelefono.Location = New Point(887, 3)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(255, 31)
        txtTelefono.TabIndex = 17
        ' 
        ' txtRNC
        ' 
        txtRNC.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtRNC.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtRNC.Location = New Point(476, 3)
        txtRNC.Name = "txtRNC"
        txtRNC.Size = New Size(252, 31)
        txtRNC.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(734, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 25)
        Label3.TabIndex = 13
        Label3.Text = "    Telefono:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(374, 5)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 25)
        Label4.TabIndex = 11
        Label4.Text = "    RNC:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(3, 5)
        Label6.Margin = New Padding(3, 5, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 25)
        Label6.TabIndex = 7
        Label6.Text = "Nombre:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(dgvProveedor)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(31, 392)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1181, 340)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "Lista de Proveedores"
        ' 
        ' dgvProveedor
        ' 
        dgvProveedor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProveedor.BackgroundColor = SystemColors.ButtonHighlight
        dgvProveedor.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvProveedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProveedor.ColumnHeadersHeight = 35
        dgvProveedor.Columns.AddRange(New DataGridViewColumn() {IdProveedor, Nombre, RNC, Telefono, Correo, Direccion, PersonalContacto, TelefonoContacto, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvProveedor.DefaultCellStyle = DataGridViewCellStyle2
        dgvProveedor.GridColor = SystemColors.InactiveCaptionText
        dgvProveedor.Location = New Point(19, 45)
        dgvProveedor.Name = "dgvProveedor"
        dgvProveedor.RowHeadersWidth = 62
        dgvProveedor.Size = New Size(1145, 279)
        dgvProveedor.TabIndex = 1
        ' 
        ' IdProveedor
        ' 
        IdProveedor.DataPropertyName = "IdProveedor"
        IdProveedor.HeaderText = "IdProveedor"
        IdProveedor.MinimumWidth = 8
        IdProveedor.Name = "IdProveedor"
        IdProveedor.Visible = False
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 8
        Nombre.Name = "Nombre"
        ' 
        ' RNC
        ' 
        RNC.DataPropertyName = "RNC"
        RNC.HeaderText = "RNC"
        RNC.MinimumWidth = 8
        RNC.Name = "RNC"
        ' 
        ' Telefono
        ' 
        Telefono.DataPropertyName = "Telefono"
        Telefono.HeaderText = "Telefono"
        Telefono.MinimumWidth = 8
        Telefono.Name = "Telefono"
        ' 
        ' Correo
        ' 
        Correo.DataPropertyName = "Correo"
        Correo.HeaderText = "Correo"
        Correo.MinimumWidth = 8
        Correo.Name = "Correo"
        ' 
        ' Direccion
        ' 
        Direccion.DataPropertyName = "Direccion"
        Direccion.HeaderText = "Direccion"
        Direccion.MinimumWidth = 8
        Direccion.Name = "Direccion"
        ' 
        ' PersonalContacto
        ' 
        PersonalContacto.DataPropertyName = "PersonalContacto"
        PersonalContacto.HeaderText = "Persona de Contacto"
        PersonalContacto.MinimumWidth = 8
        PersonalContacto.Name = "PersonalContacto"
        ' 
        ' TelefonoContacto
        ' 
        TelefonoContacto.DataPropertyName = "TelefonoContacto"
        TelefonoContacto.HeaderText = "Telefono de Contacto"
        TelefonoContacto.MinimumWidth = 8
        TelefonoContacto.Name = "TelefonoContacto"
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
        GroupBox4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(31, 313)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1181, 59)
        GroupBox4.TabIndex = 10
        GroupBox4.TabStop = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Right
        btnNuevo.BackColor = Color.LightCyan
        btnNuevo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnNuevo.Location = New Point(621, 19)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(175, 34)
        btnNuevo.TabIndex = 48
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnActivarDesactivar
        ' 
        btnActivarDesactivar.Anchor = AnchorStyles.Right
        btnActivarDesactivar.BackColor = Color.MistyRose
        btnActivarDesactivar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnActivarDesactivar.Location = New Point(802, 19)
        btnActivarDesactivar.Name = "btnActivarDesactivar"
        btnActivarDesactivar.Size = New Size(175, 34)
        btnActivarDesactivar.TabIndex = 49
        btnActivarDesactivar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarActualizar
        ' 
        btnGuardarActualizar.Anchor = AnchorStyles.Right
        btnGuardarActualizar.BackColor = Color.Honeydew
        btnGuardarActualizar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnGuardarActualizar.Location = New Point(983, 19)
        btnGuardarActualizar.Name = "btnGuardarActualizar"
        btnGuardarActualizar.Size = New Size(175, 34)
        btnGuardarActualizar.TabIndex = 47
        btnGuardarActualizar.UseVisualStyleBackColor = False
        ' 
        ' frmProveedores
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
        Name = "frmProveedores"
        Text = "frmProveedores"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(dgvProveedor, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBarraBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtRNC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtPersonaDeContacto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvProveedor As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnActivarDesactivar As Button
    Friend WithEvents btnGuardarActualizar As Button
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtTelefonoContacto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents RNC As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents PersonalContacto As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoContacto As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
