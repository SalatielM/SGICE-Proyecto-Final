<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEdificios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdificios))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox2 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        rtxtdescripcion = New RichTextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        dtpFechaConstruccion = New DateTimePicker()
        cmbEstado = New ComboBox()
        Label2 = New Label()
        Label5 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label3 = New Label()
        Label4 = New Label()
        txtCantidaDePisos = New TextBox()
        Label6 = New Label()
        txtEdificio = New TextBox()
        txtCodigo = New TextBox()
        GroupBox1 = New GroupBox()
        btnBuscar = New Button()
        txtBarraBusqueda = New TextBox()
        btnActivarDesactivar = New Button()
        btnGuardarActualizar = New Button()
        btnNuevo = New Button()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        dgvedificio = New DataGridView()
        IdEdificio = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        CodEdificio = New DataGridViewTextBoxColumn()
        CantidadPisos = New DataGridViewTextBoxColumn()
        FechaConstruccion = New DataGridViewTextBoxColumn()
        Descripcion = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvedificio, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.BackColor = SystemColors.ActiveCaption
        label1.BorderStyle = BorderStyle.Fixed3D
        label1.Dock = DockStyle.Top
        label1.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(0, 0)
        label1.Margin = New Padding(2, 0, 2, 0)
        label1.Name = "label1"
        label1.Size = New Size(1247, 30)
        label1.TabIndex = 5
        label1.Text = "REGISTRO DE EDIFICIOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel3)
        GroupBox2.Controls.Add(TableLayoutPanel2)
        GroupBox2.Controls.Add(TableLayoutPanel4)
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(31, 126)
        GroupBox2.Margin = New Padding(2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(2)
        GroupBox2.Size = New Size(1181, 209)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos del Edificio"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.Controls.Add(rtxtdescripcion, 0, 0)
        TableLayoutPanel3.Location = New Point(19, 125)
        TableLayoutPanel3.Margin = New Padding(2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 68F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 85F))
        TableLayoutPanel3.Size = New Size(1149, 69)
        TableLayoutPanel3.TabIndex = 29
        ' 
        ' rtxtdescripcion
        ' 
        rtxtdescripcion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rtxtdescripcion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rtxtdescripcion.Location = New Point(2, 2)
        rtxtdescripcion.Margin = New Padding(2)
        rtxtdescripcion.Name = "rtxtdescripcion"
        rtxtdescripcion.Size = New Size(1145, 65)
        rtxtdescripcion.TabIndex = 21
        rtxtdescripcion.Text = ""
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 16F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 16F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 16F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 16F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 16F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Location = New Point(1002, 85)
        TableLayoutPanel2.Margin = New Padding(2)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(167, 36)
        TableLayoutPanel2.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(2, 5)
        Label7.Margin = New Padding(2, 5, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(163, 25)
        Label7.TabIndex = 17
        Label7.Text = "Descripcion:"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 4
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.Controls.Add(dtpFechaConstruccion, 3, 0)
        TableLayoutPanel4.Controls.Add(cmbEstado, 1, 0)
        TableLayoutPanel4.Controls.Add(Label2, 2, 0)
        TableLayoutPanel4.Controls.Add(Label5, 0, 0)
        TableLayoutPanel4.Location = New Point(19, 82)
        TableLayoutPanel4.Margin = New Padding(2)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(903, 36)
        TableLayoutPanel4.TabIndex = 28
        ' 
        ' dtpFechaConstruccion
        ' 
        dtpFechaConstruccion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaConstruccion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaConstruccion.Location = New Point(662, 2)
        dtpFechaConstruccion.Margin = New Padding(2)
        dtpFechaConstruccion.Name = "dtpFechaConstruccion"
        dtpFechaConstruccion.Size = New Size(239, 31)
        dtpFechaConstruccion.TabIndex = 11
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(103, 2)
        cmbEstado.Margin = New Padding(2)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(239, 30)
        cmbEstado.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(346, 5)
        Label2.Margin = New Padding(2, 5, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(312, 25)
        Label2.TabIndex = 13
        Label2.Text = "    Fecha de Construccion:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(2, 5)
        Label5.Margin = New Padding(2, 5, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 25)
        Label5.TabIndex = 11
        Label5.Text = "Estado:"
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
        TableLayoutPanel1.Controls.Add(Label4, 2, 0)
        TableLayoutPanel1.Controls.Add(txtCantidaDePisos, 5, 0)
        TableLayoutPanel1.Controls.Add(Label6, 0, 0)
        TableLayoutPanel1.Controls.Add(txtEdificio, 1, 0)
        TableLayoutPanel1.Controls.Add(txtCodigo, 3, 0)
        TableLayoutPanel1.Location = New Point(19, 38)
        TableLayoutPanel1.Margin = New Padding(2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 29F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 36F))
        TableLayoutPanel1.Size = New Size(1150, 36)
        TableLayoutPanel1.TabIndex = 27
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(729, 5)
        Label3.Margin = New Padding(2, 5, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 25)
        Label3.TabIndex = 13
        Label3.Text = "    Cant. Pisos:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(356, 5)
        Label4.Margin = New Padding(2, 5, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 25)
        Label4.TabIndex = 11
        Label4.Text = "    Codigo:"
        ' 
        ' txtCantidaDePisos
        ' 
        txtCantidaDePisos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCantidaDePisos.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCantidaDePisos.Location = New Point(907, 2)
        txtCantidaDePisos.Margin = New Padding(2)
        txtCantidaDePisos.Name = "txtCantidaDePisos"
        txtCantidaDePisos.Size = New Size(241, 31)
        txtCantidaDePisos.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(2, 5)
        Label6.Margin = New Padding(2, 5, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 25)
        Label6.TabIndex = 7
        Label6.Text = "Nombre:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtEdificio
        ' 
        txtEdificio.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEdificio.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtEdificio.Location = New Point(113, 2)
        txtEdificio.Margin = New Padding(2)
        txtEdificio.Name = "txtEdificio"
        txtEdificio.Size = New Size(239, 31)
        txtEdificio.TabIndex = 15
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCodigo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCodigo.Location = New Point(486, 2)
        txtCodigo.Margin = New Padding(2)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(239, 31)
        txtCodigo.TabIndex = 17
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnBuscar)
        GroupBox1.Controls.Add(txtBarraBusqueda)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(31, 42)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(1181, 78)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscar.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.Location = New Point(1114, 21)
        btnBuscar.Margin = New Padding(2)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(50, 49)
        btnBuscar.TabIndex = 9
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(19, 28)
        txtBarraBusqueda.Margin = New Padding(2)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1089, 36)
        txtBarraBusqueda.TabIndex = 0
        ' 
        ' btnActivarDesactivar
        ' 
        btnActivarDesactivar.Anchor = AnchorStyles.Right
        btnActivarDesactivar.BackColor = Color.MistyRose
        btnActivarDesactivar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnActivarDesactivar.Location = New Point(808, 19)
        btnActivarDesactivar.Margin = New Padding(2)
        btnActivarDesactivar.Name = "btnActivarDesactivar"
        btnActivarDesactivar.Size = New Size(175, 34)
        btnActivarDesactivar.TabIndex = 52
        btnActivarDesactivar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarActualizar
        ' 
        btnGuardarActualizar.Anchor = AnchorStyles.Right
        btnGuardarActualizar.BackColor = Color.Honeydew
        btnGuardarActualizar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnGuardarActualizar.Location = New Point(989, 19)
        btnGuardarActualizar.Margin = New Padding(2)
        btnGuardarActualizar.Name = "btnGuardarActualizar"
        btnGuardarActualizar.Size = New Size(175, 34)
        btnGuardarActualizar.TabIndex = 50
        btnGuardarActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Right
        btnNuevo.BackColor = Color.LightCyan
        btnNuevo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnNuevo.Location = New Point(627, 19)
        btnNuevo.Margin = New Padding(2)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(175, 34)
        btnNuevo.TabIndex = 51
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(btnNuevo)
        GroupBox3.Controls.Add(btnGuardarActualizar)
        GroupBox3.Controls.Add(btnActivarDesactivar)
        GroupBox3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(31, 339)
        GroupBox3.Margin = New Padding(2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(2)
        GroupBox3.Size = New Size(1181, 59)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(dgvedificio)
        GroupBox4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(31, 402)
        GroupBox4.Margin = New Padding(2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(2)
        GroupBox4.Size = New Size(1181, 344)
        GroupBox4.TabIndex = 10
        GroupBox4.TabStop = False
        GroupBox4.Text = "Lista Edificios"
        ' 
        ' dgvedificio
        ' 
        dgvedificio.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvedificio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvedificio.BackgroundColor = SystemColors.ButtonHighlight
        dgvedificio.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvedificio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvedificio.ColumnHeadersHeight = 35
        dgvedificio.Columns.AddRange(New DataGridViewColumn() {IdEdificio, Nombre, CodEdificio, CantidadPisos, FechaConstruccion, Descripcion, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvedificio.DefaultCellStyle = DataGridViewCellStyle2
        dgvedificio.GridColor = SystemColors.InactiveCaptionText
        dgvedificio.Location = New Point(19, 43)
        dgvedificio.Name = "dgvedificio"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvedificio.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvedificio.RowHeadersWidth = 62
        dgvedificio.Size = New Size(1150, 284)
        dgvedificio.TabIndex = 2
        ' 
        ' IdEdificio
        ' 
        IdEdificio.DataPropertyName = "IdEdificio"
        IdEdificio.HeaderText = "IdEdificio"
        IdEdificio.MinimumWidth = 8
        IdEdificio.Name = "IdEdificio"
        IdEdificio.Visible = False
        ' 
        ' Nombre
        ' 
        Nombre.DataPropertyName = "Nombre"
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 8
        Nombre.Name = "Nombre"
        ' 
        ' CodEdificio
        ' 
        CodEdificio.DataPropertyName = "CodEdificio"
        CodEdificio.HeaderText = "Codigo"
        CodEdificio.MinimumWidth = 8
        CodEdificio.Name = "CodEdificio"
        ' 
        ' CantidadPisos
        ' 
        CantidadPisos.DataPropertyName = "CantidadPisos"
        CantidadPisos.HeaderText = "Cant. Pisos"
        CantidadPisos.MinimumWidth = 8
        CantidadPisos.Name = "CantidadPisos"
        ' 
        ' FechaConstruccion
        ' 
        FechaConstruccion.DataPropertyName = "FechaConstruccion"
        FechaConstruccion.HeaderText = "Fecha de Construccion"
        FechaConstruccion.MinimumWidth = 8
        FechaConstruccion.Name = "FechaConstruccion"
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
        ' frmEdificios
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "frmEdificios"
        Text = "frmEdificios"
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(dgvedificio, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtCantidaDePisos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtEdificio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBarraBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents rtxtdescripcion As RichTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFechaConstruccion As DateTimePicker
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents btnActivarDesactivar As Button
    Friend WithEvents btnGuardarActualizar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvedificio As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents NombreEdificio As DataGridViewTextBoxColumn
    Friend WithEvents IdEdificio As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents CodEdificio As DataGridViewTextBoxColumn
    Friend WithEvents CantidadPisos As DataGridViewTextBoxColumn
    Friend WithEvents FechaConstruccion As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
