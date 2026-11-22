<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivosFisicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivosFisicos))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox1 = New GroupBox()
        btnCargarBusqueda = New Button()
        txtBarraDeBusqueda = New TextBox()
        GroupBox2 = New GroupBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        cmbCategoria = New ComboBox()
        cmbEstado = New ComboBox()
        cmbUbicacion = New ComboBox()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        dtpFechaAdquisicion = New DateTimePicker()
        cmbActivo = New ComboBox()
        cmbMarca = New ComboBox()
        Label3 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        dgvControlActivoFisico = New DataGridView()
        IdActivoFisico = New DataGridViewTextBoxColumn()
        ActivoId = New DataGridViewTextBoxColumn()
        Activo = New DataGridViewTextBoxColumn()
        CodEtiquetaQR = New DataGridViewTextBoxColumn()
        NumSerie = New DataGridViewTextBoxColumn()
        SubCategoriaId = New DataGridViewTextBoxColumn()
        SubCategoria = New DataGridViewTextBoxColumn()
        MarcaId = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        UbicacionId = New DataGridViewTextBoxColumn()
        Ubicacion = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox4 = New GroupBox()
        btnLimpiarFiltro = New Button()
        btnGenerarCod = New Button()
        btnAplicarFiltro = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvControlActivoFisico, ComponentModel.ISupportInitialize).BeginInit()
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
        label1.TabIndex = 5
        label1.Text = "CONTROL Y UBICACION DE ACTIVOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnCargarBusqueda)
        GroupBox1.Controls.Add(txtBarraDeBusqueda)
        GroupBox1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(20, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1201, 79)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' btnCargarBusqueda
        ' 
        btnCargarBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCargarBusqueda.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCargarBusqueda.Image = CType(resources.GetObject("btnCargarBusqueda.Image"), Image)
        btnCargarBusqueda.Location = New Point(1142, 21)
        btnCargarBusqueda.Name = "btnCargarBusqueda"
        btnCargarBusqueda.Size = New Size(50, 49)
        btnCargarBusqueda.TabIndex = 6
        btnCargarBusqueda.UseVisualStyleBackColor = True
        ' 
        ' txtBarraDeBusqueda
        ' 
        txtBarraDeBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraDeBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraDeBusqueda.Location = New Point(10, 27)
        txtBarraDeBusqueda.Name = "txtBarraDeBusqueda"
        txtBarraDeBusqueda.Size = New Size(1128, 36)
        txtBarraDeBusqueda.TabIndex = 5
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel2)
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(20, 125)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1201, 135)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Filtro"
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
        TableLayoutPanel2.Controls.Add(cmbCategoria, 1, 0)
        TableLayoutPanel2.Controls.Add(cmbEstado, 3, 0)
        TableLayoutPanel2.Controls.Add(cmbUbicacion, 5, 0)
        TableLayoutPanel2.Controls.Add(Label4, 4, 0)
        TableLayoutPanel2.Controls.Add(Label6, 2, 0)
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Location = New Point(14, 83)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1174, 38)
        TableLayoutPanel2.TabIndex = 24
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCategoria.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(170, 3)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(245, 30)
        cmbCategoria.TabIndex = 16
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(528, 3)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(245, 30)
        cmbEstado.TabIndex = 15
        ' 
        ' cmbUbicacion
        ' 
        cmbUbicacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbUbicacion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbUbicacion.FormattingEnabled = True
        cmbUbicacion.Location = New Point(926, 3)
        cmbUbicacion.Name = "cmbUbicacion"
        cmbUbicacion.Size = New Size(245, 30)
        cmbUbicacion.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label4.Location = New Point(779, 5)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 24)
        Label4.TabIndex = 13
        Label4.Text = "   Ubicacion:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label6.Location = New Point(421, 5)
        Label6.Margin = New Padding(3, 5, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 24)
        Label6.TabIndex = 11
        Label6.Text = "  Estado:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label7.Location = New Point(3, 5)
        Label7.Margin = New Padding(3, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(161, 24)
        Label7.TabIndex = 7
        Label7.Text = "Sub-Categoria:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
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
        TableLayoutPanel1.Controls.Add(dtpFechaAdquisicion, 5, 0)
        TableLayoutPanel1.Controls.Add(cmbActivo, 1, 0)
        TableLayoutPanel1.Controls.Add(cmbMarca, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 4, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Font = New Font("Bookman Old Style", 11F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.Location = New Point(14, 41)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1174, 36)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' dtpFechaAdquisicion
        ' 
        dtpFechaAdquisicion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaAdquisicion.CalendarFont = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaAdquisicion.Location = New Point(934, 3)
        dtpFechaAdquisicion.Name = "dtpFechaAdquisicion"
        dtpFechaAdquisicion.Size = New Size(237, 33)
        dtpFechaAdquisicion.TabIndex = 46
        ' 
        ' cmbActivo
        ' 
        cmbActivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbActivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbActivo.FormattingEnabled = True
        cmbActivo.Location = New Point(92, 3)
        cmbActivo.Name = "cmbActivo"
        cmbActivo.Size = New Size(236, 30)
        cmbActivo.TabIndex = 16
        ' 
        ' cmbMarca
        ' 
        cmbMarca.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbMarca.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbMarca.FormattingEnabled = True
        cmbMarca.Location = New Point(448, 3)
        cmbMarca.Name = "cmbMarca"
        cmbMarca.Size = New Size(236, 30)
        cmbMarca.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(690, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(238, 24)
        Label3.TabIndex = 13
        Label3.Text = "    Fecha Adquissicion"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label5.Location = New Point(334, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 24)
        Label5.TabIndex = 11
        Label5.Text = "    Marca:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label2.Location = New Point(3, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 24)
        Label2.TabIndex = 7
        Label2.Text = "Activo:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(dgvControlActivoFisico)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(20, 334)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1201, 419)
        GroupBox3.TabIndex = 8
        GroupBox3.TabStop = False
        GroupBox3.Text = "Lista de Activos"
        ' 
        ' dgvControlActivoFisico
        ' 
        dgvControlActivoFisico.AllowUserToAddRows = False
        dgvControlActivoFisico.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvControlActivoFisico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvControlActivoFisico.BackgroundColor = SystemColors.ButtonHighlight
        dgvControlActivoFisico.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvControlActivoFisico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvControlActivoFisico.ColumnHeadersHeight = 35
        dgvControlActivoFisico.Columns.AddRange(New DataGridViewColumn() {IdActivoFisico, ActivoId, Activo, CodEtiquetaQR, NumSerie, SubCategoriaId, SubCategoria, MarcaId, Marca, UbicacionId, Ubicacion, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvControlActivoFisico.DefaultCellStyle = DataGridViewCellStyle2
        dgvControlActivoFisico.GridColor = SystemColors.InactiveCaptionText
        dgvControlActivoFisico.Location = New Point(14, 45)
        dgvControlActivoFisico.Name = "dgvControlActivoFisico"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvControlActivoFisico.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvControlActivoFisico.RowHeadersWidth = 62
        dgvControlActivoFisico.Size = New Size(1174, 356)
        dgvControlActivoFisico.TabIndex = 2
        ' 
        ' IdActivoFisico
        ' 
        IdActivoFisico.DataPropertyName = "IdActivoFisico"
        IdActivoFisico.HeaderText = "IdActivoFisico"
        IdActivoFisico.MinimumWidth = 8
        IdActivoFisico.Name = "IdActivoFisico"
        IdActivoFisico.Visible = False
        ' 
        ' ActivoId
        ' 
        ActivoId.DataPropertyName = "ActivoId"
        ActivoId.HeaderText = "ActivoId"
        ActivoId.MinimumWidth = 8
        ActivoId.Name = "ActivoId"
        ActivoId.Visible = False
        ' 
        ' Activo
        ' 
        Activo.DataPropertyName = "Activo"
        Activo.HeaderText = "Activo"
        Activo.MinimumWidth = 8
        Activo.Name = "Activo"
        ' 
        ' CodEtiquetaQR
        ' 
        CodEtiquetaQR.DataPropertyName = "CodEtiquetaQR"
        CodEtiquetaQR.HeaderText = "Etiqueta"
        CodEtiquetaQR.MinimumWidth = 8
        CodEtiquetaQR.Name = "CodEtiquetaQR"
        ' 
        ' NumSerie
        ' 
        NumSerie.DataPropertyName = "NumSerie"
        NumSerie.HeaderText = "NumSerie"
        NumSerie.MinimumWidth = 8
        NumSerie.Name = "NumSerie"
        ' 
        ' SubCategoriaId
        ' 
        SubCategoriaId.DataPropertyName = "SubCategoriaId"
        SubCategoriaId.HeaderText = "SubCategoriaId"
        SubCategoriaId.MinimumWidth = 8
        SubCategoriaId.Name = "SubCategoriaId"
        SubCategoriaId.Visible = False
        ' 
        ' SubCategoria
        ' 
        SubCategoria.DataPropertyName = "SubCategoria"
        SubCategoria.HeaderText = "SubCategoria"
        SubCategoria.MinimumWidth = 8
        SubCategoria.Name = "SubCategoria"
        ' 
        ' MarcaId
        ' 
        MarcaId.DataPropertyName = "MarcaId"
        MarcaId.HeaderText = "MarcaId"
        MarcaId.MinimumWidth = 8
        MarcaId.Name = "MarcaId"
        MarcaId.Visible = False
        ' 
        ' Marca
        ' 
        Marca.DataPropertyName = "Marca"
        Marca.HeaderText = "Marca"
        Marca.MinimumWidth = 8
        Marca.Name = "Marca"
        ' 
        ' UbicacionId
        ' 
        UbicacionId.DataPropertyName = "UbicacionId"
        UbicacionId.HeaderText = "UbicacionId"
        UbicacionId.MinimumWidth = 8
        UbicacionId.Name = "UbicacionId"
        UbicacionId.Visible = False
        ' 
        ' Ubicacion
        ' 
        Ubicacion.DataPropertyName = "Ubicacion"
        Ubicacion.HeaderText = "Ubicacion"
        Ubicacion.MinimumWidth = 8
        Ubicacion.Name = "Ubicacion"
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
        GroupBox4.Controls.Add(btnLimpiarFiltro)
        GroupBox4.Controls.Add(btnGenerarCod)
        GroupBox4.Controls.Add(btnAplicarFiltro)
        GroupBox4.Controls.Add(Button2)
        GroupBox4.Controls.Add(Button3)
        GroupBox4.Controls.Add(Button4)
        GroupBox4.Location = New Point(20, 266)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1201, 62)
        GroupBox4.TabIndex = 45
        GroupBox4.TabStop = False
        ' 
        ' btnLimpiarFiltro
        ' 
        btnLimpiarFiltro.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLimpiarFiltro.BackColor = Color.LightCyan
        btnLimpiarFiltro.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnLimpiarFiltro.Location = New Point(697, 20)
        btnLimpiarFiltro.Name = "btnLimpiarFiltro"
        btnLimpiarFiltro.Size = New Size(246, 34)
        btnLimpiarFiltro.TabIndex = 46
        btnLimpiarFiltro.Text = "Limpiar Filtro"
        btnLimpiarFiltro.UseVisualStyleBackColor = False
        ' 
        ' btnGenerarCod
        ' 
        btnGenerarCod.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnGenerarCod.BackColor = Color.LightCyan
        btnGenerarCod.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnGenerarCod.Location = New Point(14, 20)
        btnGenerarCod.Name = "btnGenerarCod"
        btnGenerarCod.Size = New Size(242, 34)
        btnGenerarCod.TabIndex = 44
        btnGenerarCod.Text = "Genera Codigo"
        btnGenerarCod.UseVisualStyleBackColor = False
        ' 
        ' btnAplicarFiltro
        ' 
        btnAplicarFiltro.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAplicarFiltro.BackColor = Color.Honeydew
        btnAplicarFiltro.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnAplicarFiltro.Location = New Point(949, 20)
        btnAplicarFiltro.Name = "btnAplicarFiltro"
        btnAplicarFiltro.Size = New Size(239, 34)
        btnAplicarFiltro.TabIndex = 45
        btnAplicarFiltro.Text = "Aplicar Filtro"
        btnAplicarFiltro.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.BackColor = Color.LightCyan
        Button2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Button2.Location = New Point(3474, -135)
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
        Button3.Location = New Point(3671, -135)
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
        Button4.Location = New Point(3858, -135)
        Button4.Name = "Button4"
        Button4.Size = New Size(194, 34)
        Button4.TabIndex = 36
        Button4.UseVisualStyleBackColor = False
        ' 
        ' frmActivosFisicos
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
        Name = "frmActivosFisicos"
        Text = "frmControlActivos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(dgvControlActivoFisico, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCargarBusqueda As Button
    Friend WithEvents txtBarraDeBusqueda As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbUbicacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbActivo As ComboBox
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvControlActivoFisico As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnGenerarCod As Button
    Friend WithEvents btnAplicarFiltro As Button
    Friend WithEvents dtpFechaAdquisicion As DateTimePicker
    Friend WithEvents btnLimpiarFiltro As Button
    Friend WithEvents IdActivoFisico As DataGridViewTextBoxColumn
    Friend WithEvents ActivoId As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents CodEtiquetaQR As DataGridViewTextBoxColumn
    Friend WithEvents NumSerie As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoriaId As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents MarcaId As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionId As DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
