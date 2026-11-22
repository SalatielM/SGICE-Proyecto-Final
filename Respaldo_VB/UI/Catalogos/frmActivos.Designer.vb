<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivos))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox1 = New GroupBox()
        btnBuscar = New Button()
        txtBarraBusqueda = New TextBox()
        GroupBox2 = New GroupBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        cmbTipoPersonal = New ComboBox()
        Label10 = New Label()
        cmbEncargado = New ComboBox()
        Label9 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        cmbSubCategoria = New ComboBox()
        cmbProveedor = New ComboBox()
        Label8 = New Label()
        cmbEstado = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        rtxtDescipcion = New RichTextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label3 = New Label()
        cmbCategoria = New ComboBox()
        cmbMarca = New ComboBox()
        Label5 = New Label()
        txtNombre = New TextBox()
        Label2 = New Label()
        dgvActivos = New DataGridView()
        IdActivo = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        MarcaId = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        CategoriaId = New DataGridViewTextBoxColumn()
        Categoria = New DataGridViewTextBoxColumn()
        SubCategoriaId = New DataGridViewTextBoxColumn()
        SubCategoria = New DataGridViewTextBoxColumn()
        ProveedorId = New DataGridViewTextBoxColumn()
        Proveedor = New DataGridViewTextBoxColumn()
        PersonalId = New DataGridViewTextBoxColumn()
        PersonalEncargado = New DataGridViewTextBoxColumn()
        Descripcion = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        Button2 = New Button()
        btnNuevo = New Button()
        Button3 = New Button()
        btnActivarDesactivar = New Button()
        Button4 = New Button()
        btnGuardarActualizar = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvActivos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
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
        label1.TabIndex = 2
        label1.Text = "REGISTRO DE ACTIVOS Y MOBILIARIOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(txtBarraBusqueda)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(22, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1202, 79)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscar.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.Location = New Point(1141, 21)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(50, 49)
        btnBuscar.TabIndex = 1
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(10, 27)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1129, 36)
        txtBarraBusqueda.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel2)
        GroupBox2.Controls.Add(TableLayoutPanel4)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(TableLayoutPanel3)
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(22, 124)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1202, 265)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos del Activo o Mobiliario"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(cmbTipoPersonal, 1, 0)
        TableLayoutPanel2.Controls.Add(Label10, 0, 0)
        TableLayoutPanel2.Controls.Add(cmbEncargado, 3, 0)
        TableLayoutPanel2.Controls.Add(Label9, 2, 0)
        TableLayoutPanel2.Location = New Point(10, 126)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(945, 36)
        TableLayoutPanel2.TabIndex = 26
        ' 
        ' cmbTipoPersonal
        ' 
        cmbTipoPersonal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbTipoPersonal.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbTipoPersonal.FormattingEnabled = True
        cmbTipoPersonal.Location = New Point(219, 3)
        cmbTipoPersonal.Name = "cmbTipoPersonal"
        cmbTipoPersonal.Size = New Size(285, 30)
        cmbTipoPersonal.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(3, 5)
        Label10.Margin = New Padding(3, 5, 3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(210, 25)
        Label10.TabIndex = 17
        Label10.Text = "Tipo de Personal:"
        ' 
        ' cmbEncargado
        ' 
        cmbEncargado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEncargado.DropDownWidth = 132
        cmbEncargado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEncargado.FormattingEnabled = True
        cmbEncargado.IntegralHeight = False
        cmbEncargado.Location = New Point(656, 3)
        cmbEncargado.Name = "cmbEncargado"
        cmbEncargado.Size = New Size(286, 30)
        cmbEncargado.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(510, 5)
        Label9.Margin = New Padding(3, 5, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(140, 25)
        Label9.TabIndex = 19
        Label9.Text = "Encargado:"
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
        TableLayoutPanel4.Controls.Add(cmbSubCategoria, 1, 0)
        TableLayoutPanel4.Controls.Add(cmbProveedor, 5, 0)
        TableLayoutPanel4.Controls.Add(Label8, 4, 0)
        TableLayoutPanel4.Controls.Add(cmbEstado, 3, 0)
        TableLayoutPanel4.Controls.Add(Label7, 0, 0)
        TableLayoutPanel4.Controls.Add(Label6, 2, 0)
        TableLayoutPanel4.Location = New Point(10, 81)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(1181, 36)
        TableLayoutPanel4.TabIndex = 25
        ' 
        ' cmbSubCategoria
        ' 
        cmbSubCategoria.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbSubCategoria.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbSubCategoria.FormattingEnabled = True
        cmbSubCategoria.Location = New Point(189, 3)
        cmbSubCategoria.Name = "cmbSubCategoria"
        cmbSubCategoria.Size = New Size(225, 30)
        cmbSubCategoria.TabIndex = 14
        ' 
        ' cmbProveedor
        ' 
        cmbProveedor.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbProveedor.DropDownWidth = 132
        cmbProveedor.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbProveedor.FormattingEnabled = True
        cmbProveedor.IntegralHeight = False
        cmbProveedor.Location = New Point(951, 3)
        cmbProveedor.Name = "cmbProveedor"
        cmbProveedor.Size = New Size(227, 30)
        cmbProveedor.TabIndex = 45
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(782, 5)
        Label8.Margin = New Padding(3, 5, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(163, 25)
        Label8.TabIndex = 44
        Label8.Text = "    Proveedor:"
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.DropDownWidth = 132
        cmbEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEstado.FormattingEnabled = True
        cmbEstado.IntegralHeight = False
        cmbEstado.Location = New Point(551, 3)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(225, 30)
        cmbEstado.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(3, 5)
        Label7.Margin = New Padding(3, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(180, 25)
        Label7.TabIndex = 17
        Label7.Text = "Sub-Categoria:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(420, 5)
        Label6.Margin = New Padding(3, 5, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 25)
        Label6.TabIndex = 11
        Label6.Text = "    Estado:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(1030, 137)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 25)
        Label4.TabIndex = 24
        Label4.Text = "Descripcion:"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.Controls.Add(rtxtDescipcion, 0, 0)
        TableLayoutPanel3.Location = New Point(10, 172)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(1181, 85)
        TableLayoutPanel3.TabIndex = 23
        ' 
        ' rtxtDescipcion
        ' 
        rtxtDescipcion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rtxtDescipcion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rtxtDescipcion.Location = New Point(3, 3)
        rtxtDescipcion.Name = "rtxtDescipcion"
        rtxtDescipcion.Size = New Size(1175, 79)
        rtxtDescipcion.TabIndex = 21
        rtxtDescipcion.Text = ""
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
        TableLayoutPanel1.Controls.Add(cmbCategoria, 5, 0)
        TableLayoutPanel1.Controls.Add(cmbMarca, 3, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(txtNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(10, 36)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1181, 36)
        TableLayoutPanel1.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(760, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 25)
        Label3.TabIndex = 13
        Label3.Text = "    Categoria:"
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCategoria.DropDownWidth = 132
        cmbCategoria.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.IntegralHeight = False
        cmbCategoria.Location = New Point(923, 3)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(255, 30)
        cmbCategoria.TabIndex = 18
        ' 
        ' cmbMarca
        ' 
        cmbMarca.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbMarca.DropDownWidth = 132
        cmbMarca.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbMarca.FormattingEnabled = True
        cmbMarca.IntegralHeight = False
        cmbMarca.Location = New Point(500, 3)
        cmbMarca.Name = "cmbMarca"
        cmbMarca.Size = New Size(254, 30)
        cmbMarca.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(376, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 25)
        Label5.TabIndex = 11
        Label5.Text = "    Marca:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNombre.Location = New Point(116, 3)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(254, 31)
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
        ' dgvActivos
        ' 
        dgvActivos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvActivos.BackgroundColor = SystemColors.ButtonHighlight
        dgvActivos.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvActivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvActivos.ColumnHeadersHeight = 35
        dgvActivos.Columns.AddRange(New DataGridViewColumn() {IdActivo, Nombre, MarcaId, Marca, CategoriaId, Categoria, SubCategoriaId, SubCategoria, ProveedorId, Proveedor, PersonalId, PersonalEncargado, Descripcion, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvActivos.DefaultCellStyle = DataGridViewCellStyle2
        dgvActivos.GridColor = SystemColors.InactiveCaptionText
        dgvActivos.Location = New Point(10, 42)
        dgvActivos.Name = "dgvActivos"
        dgvActivos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvActivos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvActivos.RowHeadersWidth = 62
        dgvActivos.Size = New Size(1181, 231)
        dgvActivos.TabIndex = 0
        ' 
        ' IdActivo
        ' 
        IdActivo.DataPropertyName = "IdActivo"
        IdActivo.HeaderText = "IdActivo"
        IdActivo.MinimumWidth = 8
        IdActivo.Name = "IdActivo"
        IdActivo.ReadOnly = True
        IdActivo.Visible = False
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 8
        Nombre.Name = "Nombre"
        Nombre.ReadOnly = True
        ' 
        ' MarcaId
        ' 
        MarcaId.DataPropertyName = "MarcaId"
        MarcaId.HeaderText = "MarcaId"
        MarcaId.MinimumWidth = 8
        MarcaId.Name = "MarcaId"
        MarcaId.ReadOnly = True
        MarcaId.Visible = False
        ' 
        ' Marca
        ' 
        Marca.DataPropertyName = "Marca"
        Marca.HeaderText = "Marca"
        Marca.MinimumWidth = 8
        Marca.Name = "Marca"
        Marca.ReadOnly = True
        ' 
        ' CategoriaId
        ' 
        CategoriaId.DataPropertyName = "CategoriaId"
        CategoriaId.HeaderText = "CategoriaId"
        CategoriaId.MinimumWidth = 8
        CategoriaId.Name = "CategoriaId"
        CategoriaId.ReadOnly = True
        CategoriaId.Visible = False
        ' 
        ' Categoria
        ' 
        Categoria.DataPropertyName = "Categoria"
        Categoria.HeaderText = "Categoria"
        Categoria.MinimumWidth = 8
        Categoria.Name = "Categoria"
        Categoria.ReadOnly = True
        ' 
        ' SubCategoriaId
        ' 
        SubCategoriaId.DataPropertyName = "SubCategoriaId"
        SubCategoriaId.HeaderText = "SubCategoriaId"
        SubCategoriaId.MinimumWidth = 8
        SubCategoriaId.Name = "SubCategoriaId"
        SubCategoriaId.ReadOnly = True
        SubCategoriaId.Visible = False
        ' 
        ' SubCategoria
        ' 
        SubCategoria.DataPropertyName = "SubCategoria"
        SubCategoria.HeaderText = "SubCategoria"
        SubCategoria.MinimumWidth = 8
        SubCategoria.Name = "SubCategoria"
        SubCategoria.ReadOnly = True
        ' 
        ' ProveedorId
        ' 
        ProveedorId.DataPropertyName = "ProveedorId"
        ProveedorId.HeaderText = "ProveedorId"
        ProveedorId.MinimumWidth = 8
        ProveedorId.Name = "ProveedorId"
        ProveedorId.ReadOnly = True
        ProveedorId.Visible = False
        ' 
        ' Proveedor
        ' 
        Proveedor.DataPropertyName = "Proveedor"
        Proveedor.HeaderText = "Proveedor"
        Proveedor.MinimumWidth = 8
        Proveedor.Name = "Proveedor"
        Proveedor.ReadOnly = True
        ' 
        ' PersonalId
        ' 
        PersonalId.DataPropertyName = "PersonalId"
        PersonalId.HeaderText = "PersonalId"
        PersonalId.MinimumWidth = 8
        PersonalId.Name = "PersonalId"
        PersonalId.ReadOnly = True
        PersonalId.Visible = False
        ' 
        ' PersonalEncargado
        ' 
        PersonalEncargado.DataPropertyName = "PersonalEncargado"
        PersonalEncargado.HeaderText = "Encargado"
        PersonalEncargado.MinimumWidth = 8
        PersonalEncargado.Name = "PersonalEncargado"
        PersonalEncargado.ReadOnly = True
        ' 
        ' Descripcion
        ' 
        Descripcion.DataPropertyName = "Descripcion"
        Descripcion.HeaderText = "Descripcion"
        Descripcion.MinimumWidth = 8
        Descripcion.Name = "Descripcion"
        Descripcion.ReadOnly = True
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
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(dgvActivos)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(22, 463)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1202, 290)
        GroupBox3.TabIndex = 15
        GroupBox3.TabStop = False
        GroupBox3.Text = "Lista de Activos y Mobiliarios"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(Button2)
        GroupBox4.Controls.Add(btnNuevo)
        GroupBox4.Controls.Add(Button3)
        GroupBox4.Controls.Add(btnActivarDesactivar)
        GroupBox4.Controls.Add(Button4)
        GroupBox4.Controls.Add(btnGuardarActualizar)
        GroupBox4.Location = New Point(22, 395)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1202, 62)
        GroupBox4.TabIndex = 44
        GroupBox4.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.BackColor = Color.LightCyan
        Button2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Button2.Location = New Point(2515, -97)
        Button2.Name = "Button2"
        Button2.Size = New Size(191, 34)
        Button2.TabIndex = 34
        Button2.Text = "Nuevo"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNuevo.BackColor = Color.LightCyan
        btnNuevo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnNuevo.Location = New Point(613, 20)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(191, 34)
        btnNuevo.TabIndex = 41
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button3.BackColor = Color.MistyRose
        Button3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Button3.Location = New Point(2712, -97)
        Button3.Name = "Button3"
        Button3.Size = New Size(181, 34)
        Button3.TabIndex = 35
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnActivarDesactivar
        ' 
        btnActivarDesactivar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnActivarDesactivar.BackColor = Color.MistyRose
        btnActivarDesactivar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnActivarDesactivar.Location = New Point(810, 20)
        btnActivarDesactivar.Name = "btnActivarDesactivar"
        btnActivarDesactivar.Size = New Size(181, 34)
        btnActivarDesactivar.TabIndex = 42
        btnActivarDesactivar.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button4.BackColor = Color.Honeydew
        Button4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Button4.Location = New Point(2899, -97)
        Button4.Name = "Button4"
        Button4.Size = New Size(194, 34)
        Button4.TabIndex = 36
        Button4.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarActualizar
        ' 
        btnGuardarActualizar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardarActualizar.BackColor = Color.Honeydew
        btnGuardarActualizar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnGuardarActualizar.Location = New Point(997, 20)
        btnGuardarActualizar.Name = "btnGuardarActualizar"
        btnGuardarActualizar.Size = New Size(194, 34)
        btnGuardarActualizar.TabIndex = 43
        btnGuardarActualizar.UseVisualStyleBackColor = False
        ' 
        ' frmActivos
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
        Name = "frmActivos"
        Text = "frmRegistroActivos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(dgvActivos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBarraBusqueda As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvActivos As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents rtxtDescipcion As RichTextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbEncargado As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmbSubCategoria As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnActivarDesactivar As Button
    Friend WithEvents btnGuardarActualizar As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents IdActivo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents MarcaId As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents CategoriaId As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoriaId As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents ProveedorId As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents PersonalId As DataGridViewTextBoxColumn
    Friend WithEvents PersonalEncargado As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents cmbTipoPersonal As ComboBox
    Friend WithEvents Label9 As Label
End Class
