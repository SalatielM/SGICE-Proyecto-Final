<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalidaActivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalidaActivos))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox1 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        rtxtObservaciones = New RichTextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        dtpFechaSalida = New DateTimePicker()
        Label5 = New Label()
        txtNumSalida = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        txtEstado = New TextBox()
        Label9 = New Label()
        txtUbicacion = New TextBox()
        btnAgregarAlDetalle = New Button()
        Label10 = New Label()
        Label8 = New Label()
        cmbMotivo = New ComboBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        txtNumSerie = New TextBox()
        txtEtiqueda = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtActivo = New TextBox()
        Label6 = New Label()
        txtBotonCargarBusqueda = New Button()
        txtBarraBusqueda = New TextBox()
        GroupBox3 = New GroupBox()
        btnLimpiarCampos = New Button()
        btnEliminarFila = New Button()
        btnGuardarSalida = New Button()
        dgvDetalleSalida = New DataGridView()
        IdActivoFisico = New DataGridViewTextBoxColumn()
        ActivoFisico = New DataGridViewTextBoxColumn()
        CodEtiquetaQR = New DataGridViewTextBoxColumn()
        NumSerie = New DataGridViewTextBoxColumn()
        UbicacionId = New DataGridViewTextBoxColumn()
        Ubicacion = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvDetalleSalida, ComponentModel.ISupportInitialize).BeginInit()
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
        label1.Text = "SALIDA DE ACTIVOS DE INVENTARIO"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel3)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(25, 52)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1197, 188)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informacion de Salida"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.Controls.Add(rtxtObservaciones, 0, 0)
        TableLayoutPanel3.Location = New Point(16, 118)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(1168, 61)
        TableLayoutPanel3.TabIndex = 27
        ' 
        ' rtxtObservaciones
        ' 
        rtxtObservaciones.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rtxtObservaciones.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rtxtObservaciones.Location = New Point(3, 3)
        rtxtObservaciones.Name = "rtxtObservaciones"
        rtxtObservaciones.Size = New Size(1162, 55)
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
        TableLayoutPanel2.Location = New Point(16, 85)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(1168, 38)
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
        Label7.Size = New Size(1162, 24)
        Label7.TabIndex = 17
        Label7.Text = "Observacion:"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(dtpFechaSalida, 3, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(txtNumSalida, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(16, 44)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1168, 36)
        TableLayoutPanel1.TabIndex = 22
        ' 
        ' dtpFechaSalida
        ' 
        dtpFechaSalida.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dtpFechaSalida.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        dtpFechaSalida.Location = New Point(707, 3)
        dtpFechaSalida.Name = "dtpFechaSalida"
        dtpFechaSalida.Size = New Size(457, 31)
        dtpFechaSalida.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label5.Location = New Point(593, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 24)
        Label5.TabIndex = 11
        Label5.Text = "    Fecha:"
        ' 
        ' txtNumSalida
        ' 
        txtNumSalida.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNumSalida.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNumSalida.Location = New Point(130, 3)
        txtNumSalida.Name = "txtNumSalida"
        txtNumSalida.Size = New Size(457, 31)
        txtNumSalida.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label2.Location = New Point(3, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 24)
        Label2.TabIndex = 7
        Label2.Text = "No. Salida:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel5)
        GroupBox2.Controls.Add(TableLayoutPanel4)
        GroupBox2.Controls.Add(txtBotonCargarBusqueda)
        GroupBox2.Controls.Add(txtBarraBusqueda)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(25, 252)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1197, 197)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Agregar Activos Fisico "
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel5.ColumnCount = 8
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 26.6369057F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.6785717F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.3690472F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.166666F))
        TableLayoutPanel5.Controls.Add(txtEstado, 3, 0)
        TableLayoutPanel5.Controls.Add(Label9, 2, 0)
        TableLayoutPanel5.Controls.Add(txtUbicacion, 1, 0)
        TableLayoutPanel5.Controls.Add(btnAgregarAlDetalle, 7, 0)
        TableLayoutPanel5.Controls.Add(Label10, 0, 0)
        TableLayoutPanel5.Controls.Add(Label8, 5, 0)
        TableLayoutPanel5.Controls.Add(cmbMotivo, 6, 0)
        TableLayoutPanel5.Location = New Point(16, 146)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(1168, 38)
        TableLayoutPanel5.TabIndex = 23
        ' 
        ' txtEstado
        ' 
        txtEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtEstado.Location = New Point(445, 3)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(197, 31)
        txtEstado.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label9.Location = New Point(324, 5)
        Label9.Margin = New Padding(3, 5, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 24)
        Label9.TabIndex = 11
        Label9.Text = "    Estado:"
        ' 
        ' txtUbicacion
        ' 
        txtUbicacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtUbicacion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtUbicacion.Location = New Point(129, 3)
        txtUbicacion.Name = "txtUbicacion"
        txtUbicacion.Size = New Size(189, 31)
        txtUbicacion.TabIndex = 8
        ' 
        ' btnAgregarAlDetalle
        ' 
        btnAgregarAlDetalle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAgregarAlDetalle.BackColor = Color.Honeydew
        btnAgregarAlDetalle.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregarAlDetalle.Location = New Point(979, 3)
        btnAgregarAlDetalle.Name = "btnAgregarAlDetalle"
        btnAgregarAlDetalle.Size = New Size(186, 32)
        btnAgregarAlDetalle.TabIndex = 13
        btnAgregarAlDetalle.Text = "Agregar"
        btnAgregarAlDetalle.TextAlign = ContentAlignment.TopCenter
        btnAgregarAlDetalle.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label10.Location = New Point(3, 5)
        Label10.Margin = New Padding(3, 5, 3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 24)
        Label10.TabIndex = 7
        Label10.Text = "Ubicacion:"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label8.Location = New Point(648, 5)
        Label8.Margin = New Padding(3, 5, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 24)
        Label8.TabIndex = 11
        Label8.Text = "   Razon:"
        ' 
        ' cmbMotivo
        ' 
        cmbMotivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbMotivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cmbMotivo.FormattingEnabled = True
        cmbMotivo.Location = New Point(768, 3)
        cmbMotivo.Name = "cmbMotivo"
        cmbMotivo.Size = New Size(182, 30)
        cmbMotivo.TabIndex = 13
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 6
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.Controls.Add(txtNumSerie, 5, 0)
        TableLayoutPanel4.Controls.Add(txtEtiqueda, 3, 0)
        TableLayoutPanel4.Controls.Add(Label3, 4, 0)
        TableLayoutPanel4.Controls.Add(Label4, 2, 0)
        TableLayoutPanel4.Controls.Add(txtActivo, 1, 0)
        TableLayoutPanel4.Controls.Add(Label6, 0, 0)
        TableLayoutPanel4.Location = New Point(16, 102)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.Size = New Size(1168, 36)
        TableLayoutPanel4.TabIndex = 22
        ' 
        ' txtNumSerie
        ' 
        txtNumSerie.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNumSerie.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNumSerie.Location = New Point(904, 3)
        txtNumSerie.Name = "txtNumSerie"
        txtNumSerie.Size = New Size(261, 31)
        txtNumSerie.TabIndex = 15
        ' 
        ' txtEtiqueda
        ' 
        txtEtiqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEtiqueda.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtEtiqueda.Location = New Point(496, 3)
        txtEtiqueda.Name = "txtEtiqueda"
        txtEtiqueda.Size = New Size(259, 31)
        txtEtiqueda.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(761, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 24)
        Label3.TabIndex = 13
        Label3.Text = "    No. Serie:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label4.Location = New Point(357, 5)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 24)
        Label4.TabIndex = 11
        Label4.Text = "    Etiqueta:"
        ' 
        ' txtActivo
        ' 
        txtActivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtActivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtActivo.Location = New Point(92, 3)
        txtActivo.Name = "txtActivo"
        txtActivo.Size = New Size(259, 31)
        txtActivo.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label6.Location = New Point(3, 5)
        Label6.Margin = New Padding(3, 5, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 24)
        Label6.TabIndex = 7
        Label6.Text = "Activo:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBotonCargarBusqueda
        ' 
        txtBotonCargarBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBotonCargarBusqueda.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBotonCargarBusqueda.Image = CType(resources.GetObject("txtBotonCargarBusqueda.Image"), Image)
        txtBotonCargarBusqueda.Location = New Point(1134, 35)
        txtBotonCargarBusqueda.Name = "txtBotonCargarBusqueda"
        txtBotonCargarBusqueda.Size = New Size(50, 49)
        txtBotonCargarBusqueda.TabIndex = 3
        txtBotonCargarBusqueda.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(16, 41)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1112, 36)
        txtBarraBusqueda.TabIndex = 2
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(btnLimpiarCampos)
        GroupBox3.Controls.Add(btnEliminarFila)
        GroupBox3.Controls.Add(btnGuardarSalida)
        GroupBox3.Controls.Add(dgvDetalleSalida)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(25, 465)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1197, 288)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "Detalles de la Salida"
        ' 
        ' btnLimpiarCampos
        ' 
        btnLimpiarCampos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLimpiarCampos.BackColor = Color.LightCyan
        btnLimpiarCampos.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLimpiarCampos.Location = New Point(618, 247)
        btnLimpiarCampos.Name = "btnLimpiarCampos"
        btnLimpiarCampos.Size = New Size(195, 32)
        btnLimpiarCampos.TabIndex = 16
        btnLimpiarCampos.Text = "Limpiar Campos"
        btnLimpiarCampos.TextAlign = ContentAlignment.TopCenter
        btnLimpiarCampos.UseVisualStyleBackColor = False
        ' 
        ' btnEliminarFila
        ' 
        btnEliminarFila.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEliminarFila.BackColor = Color.MistyRose
        btnEliminarFila.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminarFila.Location = New Point(819, 247)
        btnEliminarFila.Name = "btnEliminarFila"
        btnEliminarFila.Size = New Size(173, 32)
        btnEliminarFila.TabIndex = 15
        btnEliminarFila.Text = "Eliminar Fila"
        btnEliminarFila.TextAlign = ContentAlignment.TopCenter
        btnEliminarFila.UseVisualStyleBackColor = False
        ' 
        ' btnGuardarSalida
        ' 
        btnGuardarSalida.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnGuardarSalida.BackColor = Color.Honeydew
        btnGuardarSalida.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardarSalida.Location = New Point(998, 247)
        btnGuardarSalida.Name = "btnGuardarSalida"
        btnGuardarSalida.Size = New Size(173, 32)
        btnGuardarSalida.TabIndex = 14
        btnGuardarSalida.Text = "Guardar Salida"
        btnGuardarSalida.TextAlign = ContentAlignment.TopCenter
        btnGuardarSalida.UseVisualStyleBackColor = False
        ' 
        ' dgvDetalleSalida
        ' 
        dgvDetalleSalida.AllowUserToAddRows = False
        dgvDetalleSalida.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetalleSalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetalleSalida.BackgroundColor = SystemColors.ButtonHighlight
        dgvDetalleSalida.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDetalleSalida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDetalleSalida.ColumnHeadersHeight = 35
        dgvDetalleSalida.Columns.AddRange(New DataGridViewColumn() {IdActivoFisico, ActivoFisico, CodEtiquetaQR, NumSerie, UbicacionId, Ubicacion, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvDetalleSalida.DefaultCellStyle = DataGridViewCellStyle2
        dgvDetalleSalida.GridColor = SystemColors.InactiveCaptionText
        dgvDetalleSalida.Location = New Point(16, 43)
        dgvDetalleSalida.Name = "dgvDetalleSalida"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvDetalleSalida.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvDetalleSalida.RowHeadersVisible = False
        dgvDetalleSalida.RowHeadersWidth = 62
        dgvDetalleSalida.Size = New Size(1168, 198)
        dgvDetalleSalida.TabIndex = 3
        ' 
        ' IdActivoFisico
        ' 
        IdActivoFisico.DataPropertyName = "ActivoFisicoId"
        IdActivoFisico.HeaderText = "IdActivoFisico"
        IdActivoFisico.MinimumWidth = 8
        IdActivoFisico.Name = "IdActivoFisico"
        IdActivoFisico.Visible = False
        ' 
        ' ActivoFisico
        ' 
        ActivoFisico.DataPropertyName = "ActivoFisico"
        ActivoFisico.HeaderText = "Activo"
        ActivoFisico.MinimumWidth = 8
        ActivoFisico.Name = "ActivoFisico"
        ActivoFisico.Visible = False
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
        NumSerie.HeaderText = "No. Serie"
        NumSerie.MinimumWidth = 8
        NumSerie.Name = "NumSerie"
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
        ' frmSalidaActivos
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSalidaActivos"
        Text = "frmSalidaActivos"
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(dgvDetalleSalida, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents rtxtObservaciones As RichTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dtpFechaSalida As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumSalida As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBotonCargarBusqueda As Button
    Friend WithEvents txtBarraBusqueda As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtActivo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtNumSerie As TextBox
    Friend WithEvents txtEtiqueda As TextBox
    Friend WithEvents btnAgregarAlDetalle As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvDetalleSalida As DataGridView
    Friend WithEvents btnGuardarSalida As Button
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnEliminarFila As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbMotivo As ComboBox
    Friend WithEvents IdActivoFisico As DataGridViewTextBoxColumn
    Friend WithEvents ActivoFisico As DataGridViewTextBoxColumn
    Friend WithEvents CodEtiquetaQR As DataGridViewTextBoxColumn
    Friend WithEvents NumSerie As DataGridViewTextBoxColumn
    Friend WithEvents UbicacionId As DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
