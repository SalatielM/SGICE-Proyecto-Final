<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradaActivos
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox1 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        rtxtObservaciones = New RichTextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        cmbDocReferencia = New ComboBox()
        Label4 = New Label()
        dtpFecha = New DateTimePicker()
        Label3 = New Label()
        Label5 = New Label()
        txtNoEntrada = New TextBox()
        Label2 = New Label()
        txtDocReferencia = New TextBox()
        GroupBox2 = New GroupBox()
        btnAgregar = New Button()
        TableLayoutPanel6 = New TableLayoutPanel()
        txtCantidad = New TextBox()
        cmbActivo = New ComboBox()
        Label8 = New Label()
        Label9 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        GroupBox4 = New GroupBox()
        btnLimparCampos = New Button()
        btnGuardarEntrada = New Button()
        dgvEditarActivoFisico = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        UbicacionId = New DataGridViewComboBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox3 = New GroupBox()
        btnEliminarFila = New Button()
        btnEditarFisicos = New Button()
        dgvDetalleEntrada = New DataGridView()
        ActivoId = New DataGridViewTextBoxColumn()
        NombreActivo = New DataGridViewTextBoxColumn()
        Cantidad = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvEditarActivoFisico, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(dgvDetalleEntrada, ComponentModel.ISupportInitialize).BeginInit()
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
        label1.Text = "ENTRADA DE ACTIVOS A INVENTARIO"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel3)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(22, 50)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1202, 188)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos Generales de la Entrada"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.Controls.Add(rtxtObservaciones, 0, 0)
        TableLayoutPanel3.Location = New Point(19, 118)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(1166, 61)
        TableLayoutPanel3.TabIndex = 27
        ' 
        ' rtxtObservaciones
        ' 
        rtxtObservaciones.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rtxtObservaciones.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rtxtObservaciones.Location = New Point(3, 3)
        rtxtObservaciones.Name = "rtxtObservaciones"
        rtxtObservaciones.Size = New Size(1160, 55)
        rtxtObservaciones.TabIndex = 21
        rtxtObservaciones.Text = ""
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
        TableLayoutPanel2.Location = New Point(19, 85)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1166, 38)
        TableLayoutPanel2.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label7.Location = New Point(3, 5)
        Label7.Margin = New Padding(3, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(1160, 24)
        Label7.TabIndex = 17
        Label7.Text = "Observacion:"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 8
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(cmbDocReferencia, 5, 0)
        TableLayoutPanel1.Controls.Add(Label4, 6, 0)
        TableLayoutPanel1.Controls.Add(dtpFecha, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 4, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(txtNoEntrada, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(txtDocReferencia, 7, 0)
        TableLayoutPanel1.Location = New Point(19, 44)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1166, 36)
        TableLayoutPanel1.TabIndex = 22
        ' 
        ' cmbDocReferencia
        ' 
        cmbDocReferencia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbDocReferencia.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbDocReferencia.FormattingEnabled = True
        cmbDocReferencia.Location = New Point(784, 3)
        cmbDocReferencia.Name = "cmbDocReferencia"
        cmbDocReferencia.Size = New Size(146, 30)
        cmbDocReferencia.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label4.Location = New Point(936, 5)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 24)
        Label4.TabIndex = 25
        Label4.Text = "    No:"
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFecha.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFecha.Location = New Point(416, 3)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(146, 31)
        dtpFecha.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(568, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 24)
        Label3.TabIndex = 13
        Label3.Text = "    Doc. Referencia:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label5.Location = New Point(302, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 24)
        Label5.TabIndex = 11
        Label5.Text = "    Fecha:"
        ' 
        ' txtNoEntrada
        ' 
        txtNoEntrada.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNoEntrada.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNoEntrada.Location = New Point(150, 3)
        txtNoEntrada.Name = "txtNoEntrada"
        txtNoEntrada.Size = New Size(146, 31)
        txtNoEntrada.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label2.Location = New Point(3, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 24)
        Label2.TabIndex = 7
        Label2.Text = "No. Entrada:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtDocReferencia
        ' 
        txtDocReferencia.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDocReferencia.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtDocReferencia.Location = New Point(1014, 3)
        txtDocReferencia.Name = "txtDocReferencia"
        txtDocReferencia.Size = New Size(149, 31)
        txtDocReferencia.TabIndex = 24
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnAgregar)
        GroupBox2.Controls.Add(TableLayoutPanel6)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(22, 244)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1202, 87)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Agregar Activos al Detalle"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAgregar.BackColor = Color.Honeydew
        btnAgregar.Location = New Point(1054, 34)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(131, 38)
        btnAgregar.TabIndex = 23
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel6.ColumnCount = 5
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel6.Controls.Add(txtCantidad, 3, 0)
        TableLayoutPanel6.Controls.Add(cmbActivo, 1, 0)
        TableLayoutPanel6.Controls.Add(Label8, 2, 0)
        TableLayoutPanel6.Controls.Add(Label9, 0, 0)
        TableLayoutPanel6.Location = New Point(19, 36)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel6.Size = New Size(1014, 36)
        TableLayoutPanel6.TabIndex = 22
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCantidad.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCantidad.Location = New Point(626, 3)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(384, 31)
        txtCantidad.TabIndex = 16
        ' 
        ' cmbActivo
        ' 
        cmbActivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbActivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbActivo.FormattingEnabled = True
        cmbActivo.Location = New Point(92, 3)
        cmbActivo.Name = "cmbActivo"
        cmbActivo.Size = New Size(384, 30)
        cmbActivo.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label8.Location = New Point(482, 5)
        Label8.Margin = New Padding(3, 5, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(138, 24)
        Label8.TabIndex = 11
        Label8.Text = "    Cantidad:"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label9.Location = New Point(3, 5)
        Label9.Margin = New Padding(3, 5, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 24)
        Label9.TabIndex = 7
        Label9.Text = "Activo:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Controls.Add(GroupBox4, 0, 1)
        TableLayoutPanel4.Controls.Add(GroupBox3, 0, 0)
        TableLayoutPanel4.Location = New Point(22, 338)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(1202, 410)
        TableLayoutPanel4.TabIndex = 10
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(btnLimparCampos)
        GroupBox4.Controls.Add(btnGuardarEntrada)
        GroupBox4.Controls.Add(dgvEditarActivoFisico)
        GroupBox4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(3, 208)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1196, 199)
        GroupBox4.TabIndex = 1
        GroupBox4.TabStop = False
        GroupBox4.Text = "Edicion del Activo Fisico"
        ' 
        ' btnLimparCampos
        ' 
        btnLimparCampos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLimparCampos.BackColor = Color.LightCyan
        btnLimparCampos.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnLimparCampos.Location = New Point(783, 164)
        btnLimparCampos.Name = "btnLimparCampos"
        btnLimparCampos.Size = New Size(195, 31)
        btnLimparCampos.TabIndex = 27
        btnLimparCampos.Text = "Limpiar Campos"
        btnLimparCampos.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarEntrada
        ' 
        btnGuardarEntrada.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardarEntrada.BackColor = Color.Honeydew
        btnGuardarEntrada.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnGuardarEntrada.Location = New Point(987, 163)
        btnGuardarEntrada.Name = "btnGuardarEntrada"
        btnGuardarEntrada.Size = New Size(195, 31)
        btnGuardarEntrada.TabIndex = 25
        btnGuardarEntrada.Text = "Guardar Entrada"
        btnGuardarEntrada.UseVisualStyleBackColor = False
        ' 
        ' dgvEditarActivoFisico
        ' 
        dgvEditarActivoFisico.AllowUserToAddRows = False
        dgvEditarActivoFisico.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvEditarActivoFisico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEditarActivoFisico.BackgroundColor = SystemColors.ButtonHighlight
        dgvEditarActivoFisico.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvEditarActivoFisico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvEditarActivoFisico.ColumnHeadersHeight = 35
        dgvEditarActivoFisico.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, UbicacionId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvEditarActivoFisico.DefaultCellStyle = DataGridViewCellStyle2
        dgvEditarActivoFisico.GridColor = SystemColors.InactiveCaptionText
        dgvEditarActivoFisico.Location = New Point(16, 33)
        dgvEditarActivoFisico.Name = "dgvEditarActivoFisico"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvEditarActivoFisico.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvEditarActivoFisico.RowHeadersVisible = False
        dgvEditarActivoFisico.RowHeadersWidth = 62
        dgvEditarActivoFisico.Size = New Size(1166, 124)
        dgvEditarActivoFisico.TabIndex = 2
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.DataPropertyName = "Activo"
        DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        DataGridViewTextBoxColumn1.MinimumWidth = 8
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.DataPropertyName = "CodEtiquetaQR"
        DataGridViewTextBoxColumn2.HeaderText = "Etiqueta"
        DataGridViewTextBoxColumn2.MinimumWidth = 8
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.DataPropertyName = "NumSerie"
        DataGridViewTextBoxColumn3.HeaderText = "No. Serie"
        DataGridViewTextBoxColumn3.MinimumWidth = 8
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' UbicacionId
        ' 
        UbicacionId.DataPropertyName = "UbicacionId"
        UbicacionId.HeaderText = "Ubicacion"
        UbicacionId.MinimumWidth = 8
        UbicacionId.Name = "UbicacionId"
        UbicacionId.Resizable = DataGridViewTriState.True
        UbicacionId.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Estado
        ' 
        Estado.DataPropertyName = "Estado"
        Estado.HeaderText = "Estado"
        Estado.MinimumWidth = 8
        Estado.Name = "Estado"
        Estado.ReadOnly = True
        Estado.Resizable = DataGridViewTriState.True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(btnEliminarFila)
        GroupBox3.Controls.Add(btnEditarFisicos)
        GroupBox3.Controls.Add(dgvDetalleEntrada)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(3, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1196, 199)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "Detalle de la Entrada"
        ' 
        ' btnEliminarFila
        ' 
        btnEliminarFila.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEliminarFila.BackColor = Color.MistyRose
        btnEliminarFila.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnEliminarFila.Location = New Point(777, 164)
        btnEliminarFila.Name = "btnEliminarFila"
        btnEliminarFila.Size = New Size(204, 31)
        btnEliminarFila.TabIndex = 25
        btnEliminarFila.Text = "Eliminar Fila"
        btnEliminarFila.UseVisualStyleBackColor = False
        ' 
        ' btnEditarFisicos
        ' 
        btnEditarFisicos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEditarFisicos.BackColor = Color.Honeydew
        btnEditarFisicos.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnEditarFisicos.Location = New Point(987, 163)
        btnEditarFisicos.Name = "btnEditarFisicos"
        btnEditarFisicos.Size = New Size(195, 31)
        btnEditarFisicos.TabIndex = 24
        btnEditarFisicos.Text = "Editar Fisicos"
        btnEditarFisicos.UseVisualStyleBackColor = False
        ' 
        ' dgvDetalleEntrada
        ' 
        dgvDetalleEntrada.AllowUserToAddRows = False
        dgvDetalleEntrada.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetalleEntrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetalleEntrada.BackgroundColor = SystemColors.ButtonHighlight
        dgvDetalleEntrada.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvDetalleEntrada.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvDetalleEntrada.ColumnHeadersHeight = 35
        dgvDetalleEntrada.Columns.AddRange(New DataGridViewColumn() {ActivoId, NombreActivo, Cantidad})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvDetalleEntrada.DefaultCellStyle = DataGridViewCellStyle5
        dgvDetalleEntrada.GridColor = SystemColors.InactiveCaptionText
        dgvDetalleEntrada.Location = New Point(16, 36)
        dgvDetalleEntrada.MultiSelect = False
        dgvDetalleEntrada.Name = "dgvDetalleEntrada"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvDetalleEntrada.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvDetalleEntrada.RowHeadersWidth = 62
        dgvDetalleEntrada.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetalleEntrada.Size = New Size(1166, 122)
        dgvDetalleEntrada.TabIndex = 2
        ' 
        ' ActivoId
        ' 
        ActivoId.HeaderText = "ActivoId"
        ActivoId.MinimumWidth = 8
        ActivoId.Name = "ActivoId"
        ActivoId.Visible = False
        ' 
        ' NombreActivo
        ' 
        NombreActivo.DataPropertyName = "NombreActivo"
        NombreActivo.HeaderText = "Activo"
        NombreActivo.MinimumWidth = 8
        NombreActivo.Name = "NombreActivo"
        ' 
        ' Cantidad
        ' 
        Cantidad.DataPropertyName = "Cantidad"
        Cantidad.HeaderText = "Cantidad"
        Cantidad.MinimumWidth = 8
        Cantidad.Name = "Cantidad"
        ' 
        ' frmEntradaActivos
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEntradaActivos"
        Text = "frmEntradaActivos"
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(dgvEditarActivoFisico, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(dgvDetalleEntrada, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNoEntrada As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents rtxtObservaciones As RichTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents cmbActivo As ComboBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvEditarActivoFisico As DataGridView
    Friend WithEvents dgvDetalleEntrada As DataGridView
    Friend WithEvents btnEliminarFila As Button
    Friend WithEvents btnEditarFisicos As Button
    Friend WithEvents btnLimparCampos As Button
    Friend WithEvents btnGuardarEntrada As Button
    Friend WithEvents ActivoId As DataGridViewTextBoxColumn
    Friend WithEvents NombreActivo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents txtDocReferencia As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionId As DataGridViewComboBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents cmbDocReferencia As ComboBox
    Friend WithEvents Label4 As Label
End Class
