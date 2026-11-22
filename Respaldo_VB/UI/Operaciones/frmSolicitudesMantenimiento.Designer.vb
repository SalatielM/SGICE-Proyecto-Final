<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicitudesMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicitudesMantenimiento))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        label1 = New Label()
        GroupBox1 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        rtxtObservacionGeneral = New RichTextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtNumSolicitud = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        rtxtDecripcionProblema = New RichTextBox()
        btnAgregar = New Button()
        TableLayoutPanel7 = New TableLayoutPanel()
        txtEstado = New TextBox()
        Label11 = New Label()
        txtUbicacion = New TextBox()
        Label12 = New Label()
        btnCargarBusqueda = New Button()
        txtBarraBusqueda = New TextBox()
        TableLayoutPanel6 = New TableLayoutPanel()
        txtMarca = New TextBox()
        Label3 = New Label()
        txtNumSerie = New TextBox()
        txtCodEtiquetaQR = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        txtActivo = New TextBox()
        Label9 = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        btnLimparCampos = New Button()
        btnEliminarFila = New Button()
        btnRegistrarSolicitud = New Button()
        dgvDetalleSolicitudes = New DataGridView()
        GroupBox4 = New GroupBox()
        dgvListaSolicitudes = New DataGridView()
        IdSolicitudMantenimiento = New DataGridViewTextBoxColumn()
        NumSolicitud = New DataGridViewTextBoxColumn()
        FechaSolicitud = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        IdDetalleSolicitudMantenimiento = New DataGridViewTextBoxColumn()
        SolicitudMantenimientoId = New DataGridViewTextBoxColumn()
        ActivoId = New DataGridViewTextBoxColumn()
        Activo = New DataGridViewTextBoxColumn()
        ActivoFisicoId = New DataGridViewTextBoxColumn()
        CodEtiquetaQR = New DataGridViewTextBoxColumn()
        NumSerie = New DataGridViewTextBoxColumn()
        MarcaId = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        SubCategoriaId = New DataGridViewTextBoxColumn()
        SubCategoria = New DataGridViewTextBoxColumn()
        EstadoIdd = New DataGridViewTextBoxColumn()
        Estadoo = New DataGridViewTextBoxColumn()
        DescripcionProblema = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvDetalleSolicitudes, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(dgvListaSolicitudes, ComponentModel.ISupportInitialize).BeginInit()
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
        label1.TabIndex = 7
        label1.Text = "SOLICITUD DE MANTENIMIENTO DE ACTIVOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(TableLayoutPanel3)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(21, 45)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1200, 136)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos Generales de la Entrada"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.Controls.Add(rtxtObservacionGeneral, 0, 0)
        TableLayoutPanel3.Location = New Point(14, 75)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(1168, 53)
        TableLayoutPanel3.TabIndex = 27
        ' 
        ' rtxtObservacionGeneral
        ' 
        rtxtObservacionGeneral.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rtxtObservacionGeneral.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rtxtObservacionGeneral.Location = New Point(3, 3)
        rtxtObservacionGeneral.Name = "rtxtObservacionGeneral"
        rtxtObservacionGeneral.Size = New Size(1162, 47)
        rtxtObservacionGeneral.TabIndex = 21
        rtxtObservacionGeneral.Text = ""
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Location = New Point(945, 31)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(237, 38)
        TableLayoutPanel2.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(3, 5)
        Label7.Margin = New Padding(3, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(231, 24)
        Label7.TabIndex = 17
        Label7.Text = "Observacion General:"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(txtNumSolicitud, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(18, 35)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(457, 36)
        TableLayoutPanel1.TabIndex = 22
        ' 
        ' txtNumSolicitud
        ' 
        txtNumSolicitud.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNumSolicitud.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtNumSolicitud.Location = New Point(159, 3)
        txtNumSolicitud.Name = "txtNumSolicitud"
        txtNumSolicitud.Size = New Size(295, 31)
        txtNumSolicitud.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 24)
        Label2.TabIndex = 7
        Label2.Text = "No. Solicitud:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel4)
        GroupBox2.Controls.Add(btnAgregar)
        GroupBox2.Controls.Add(TableLayoutPanel7)
        GroupBox2.Controls.Add(btnCargarBusqueda)
        GroupBox2.Controls.Add(txtBarraBusqueda)
        GroupBox2.Controls.Add(TableLayoutPanel6)
        GroupBox2.Controls.Add(TableLayoutPanel5)
        GroupBox2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(21, 184)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1200, 238)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Agregar Activo al Detalle"
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.Controls.Add(rtxtDecripcionProblema, 0, 0)
        TableLayoutPanel4.Location = New Point(14, 173)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel4.Size = New Size(1168, 53)
        TableLayoutPanel4.TabIndex = 31
        ' 
        ' rtxtDecripcionProblema
        ' 
        rtxtDecripcionProblema.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        rtxtDecripcionProblema.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rtxtDecripcionProblema.Location = New Point(3, 3)
        rtxtDecripcionProblema.Name = "rtxtDecripcionProblema"
        rtxtDecripcionProblema.Size = New Size(1162, 47)
        rtxtDecripcionProblema.TabIndex = 21
        rtxtDecripcionProblema.Text = ""
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Anchor = AnchorStyles.Right
        btnAgregar.BackColor = Color.Honeydew
        btnAgregar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregar.Location = New Point(1025, 138)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(157, 33)
        btnAgregar.TabIndex = 31
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel7.ColumnCount = 4
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel7.Controls.Add(txtEstado, 3, 0)
        TableLayoutPanel7.Controls.Add(Label11, 2, 0)
        TableLayoutPanel7.Controls.Add(txtUbicacion, 1, 0)
        TableLayoutPanel7.Controls.Add(Label12, 0, 0)
        TableLayoutPanel7.Location = New Point(14, 130)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Size = New Size(581, 36)
        TableLayoutPanel7.TabIndex = 30
        ' 
        ' txtEstado
        ' 
        txtEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtEstado.Location = New Point(413, 3)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(165, 31)
        txtEstado.TabIndex = 14
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label11.Location = New Point(299, 5)
        Label11.Margin = New Padding(3, 5, 3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(108, 24)
        Label11.TabIndex = 11
        Label11.Text = "   Estado:"
        ' 
        ' txtUbicacion
        ' 
        txtUbicacion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtUbicacion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtUbicacion.Location = New Point(129, 3)
        txtUbicacion.Name = "txtUbicacion"
        txtUbicacion.Size = New Size(164, 31)
        txtUbicacion.TabIndex = 8
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label12.Location = New Point(3, 5)
        Label12.Margin = New Padding(3, 5, 3, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(120, 24)
        Label12.TabIndex = 7
        Label12.Text = "Ubicacion:"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnCargarBusqueda
        ' 
        btnCargarBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCargarBusqueda.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCargarBusqueda.Image = CType(resources.GetObject("btnCargarBusqueda.Image"), Image)
        btnCargarBusqueda.Location = New Point(1132, 31)
        btnCargarBusqueda.Name = "btnCargarBusqueda"
        btnCargarBusqueda.Size = New Size(50, 49)
        btnCargarBusqueda.TabIndex = 29
        btnCargarBusqueda.UseVisualStyleBackColor = True
        ' 
        ' txtBarraBusqueda
        ' 
        txtBarraBusqueda.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarraBusqueda.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBarraBusqueda.Location = New Point(14, 36)
        txtBarraBusqueda.Name = "txtBarraBusqueda"
        txtBarraBusqueda.Size = New Size(1112, 36)
        txtBarraBusqueda.TabIndex = 28
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel6.ColumnCount = 8
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel6.Controls.Add(txtMarca, 7, 0)
        TableLayoutPanel6.Controls.Add(Label3, 6, 0)
        TableLayoutPanel6.Controls.Add(txtNumSerie, 5, 0)
        TableLayoutPanel6.Controls.Add(txtCodEtiquetaQR, 3, 0)
        TableLayoutPanel6.Controls.Add(Label6, 4, 0)
        TableLayoutPanel6.Controls.Add(Label8, 2, 0)
        TableLayoutPanel6.Controls.Add(txtActivo, 1, 0)
        TableLayoutPanel6.Controls.Add(Label9, 0, 0)
        TableLayoutPanel6.Location = New Point(14, 87)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Size = New Size(1168, 36)
        TableLayoutPanel6.TabIndex = 22
        ' 
        ' txtMarca
        ' 
        txtMarca.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtMarca.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtMarca.Location = New Point(995, 3)
        txtMarca.Name = "txtMarca"
        txtMarca.Size = New Size(170, 31)
        txtMarca.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label3.Location = New Point(888, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 24)
        Label3.TabIndex = 14
        Label3.Text = "   Marca:"
        ' 
        ' txtNumSerie
        ' 
        txtNumSerie.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNumSerie.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNumSerie.Location = New Point(712, 3)
        txtNumSerie.Name = "txtNumSerie"
        txtNumSerie.Size = New Size(170, 31)
        txtNumSerie.TabIndex = 15
        ' 
        ' txtCodEtiquetaQR
        ' 
        txtCodEtiquetaQR.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCodEtiquetaQR.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCodEtiquetaQR.Location = New Point(400, 3)
        txtCodEtiquetaQR.Name = "txtCodEtiquetaQR"
        txtCodEtiquetaQR.Size = New Size(170, 31)
        txtCodEtiquetaQR.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label6.Location = New Point(576, 5)
        Label6.Margin = New Padding(3, 5, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 24)
        Label6.TabIndex = 13
        Label6.Text = "   No. Serie:"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label8.Location = New Point(268, 5)
        Label8.Margin = New Padding(3, 5, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(126, 24)
        Label8.TabIndex = 11
        Label8.Text = "   Etiqueta:"
        ' 
        ' txtActivo
        ' 
        txtActivo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtActivo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtActivo.Location = New Point(92, 3)
        txtActivo.Name = "txtActivo"
        txtActivo.Size = New Size(170, 31)
        txtActivo.TabIndex = 8
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
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Controls.Add(Label4, 0, 0)
        TableLayoutPanel5.Location = New Point(728, 138)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(290, 38)
        TableLayoutPanel5.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label4.Location = New Point(3, 5)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(284, 24)
        Label4.TabIndex = 17
        Label4.Text = "Descripcion del Problema:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(btnLimparCampos)
        GroupBox3.Controls.Add(btnEliminarFila)
        GroupBox3.Controls.Add(btnRegistrarSolicitud)
        GroupBox3.Controls.Add(dgvDetalleSolicitudes)
        GroupBox3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(21, 424)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1200, 243)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        GroupBox3.Text = "Detalle de la Solicitud"
        ' 
        ' btnLimparCampos
        ' 
        btnLimparCampos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnLimparCampos.BackColor = Color.LightCyan
        btnLimparCampos.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLimparCampos.Location = New Point(561, 204)
        btnLimparCampos.Name = "btnLimparCampos"
        btnLimparCampos.Size = New Size(197, 33)
        btnLimparCampos.TabIndex = 34
        btnLimparCampos.Text = "Limpiar Campos"
        btnLimparCampos.UseVisualStyleBackColor = False
        ' 
        ' btnEliminarFila
        ' 
        btnEliminarFila.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnEliminarFila.BackColor = Color.MistyRose
        btnEliminarFila.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminarFila.Location = New Point(766, 204)
        btnEliminarFila.Name = "btnEliminarFila"
        btnEliminarFila.Size = New Size(171, 33)
        btnEliminarFila.TabIndex = 33
        btnEliminarFila.Text = "Eliminar Fila"
        btnEliminarFila.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrarSolicitud
        ' 
        btnRegistrarSolicitud.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRegistrarSolicitud.BackColor = Color.Honeydew
        btnRegistrarSolicitud.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrarSolicitud.Location = New Point(944, 204)
        btnRegistrarSolicitud.Name = "btnRegistrarSolicitud"
        btnRegistrarSolicitud.Size = New Size(238, 33)
        btnRegistrarSolicitud.TabIndex = 32
        btnRegistrarSolicitud.Text = "Registrar Solicitud"
        btnRegistrarSolicitud.UseVisualStyleBackColor = False
        ' 
        ' dgvDetalleSolicitudes
        ' 
        dgvDetalleSolicitudes.AllowUserToAddRows = False
        dgvDetalleSolicitudes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetalleSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetalleSolicitudes.BackgroundColor = SystemColors.ButtonHighlight
        dgvDetalleSolicitudes.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDetalleSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDetalleSolicitudes.ColumnHeadersHeight = 35
        dgvDetalleSolicitudes.Columns.AddRange(New DataGridViewColumn() {IdDetalleSolicitudMantenimiento, SolicitudMantenimientoId, ActivoId, Activo, ActivoFisicoId, CodEtiquetaQR, NumSerie, MarcaId, Marca, SubCategoriaId, SubCategoria, EstadoIdd, Estadoo, DescripcionProblema})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvDetalleSolicitudes.DefaultCellStyle = DataGridViewCellStyle2
        dgvDetalleSolicitudes.GridColor = SystemColors.InactiveCaptionText
        dgvDetalleSolicitudes.Location = New Point(14, 33)
        dgvDetalleSolicitudes.Name = "dgvDetalleSolicitudes"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvDetalleSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvDetalleSolicitudes.RowHeadersWidth = 62
        dgvDetalleSolicitudes.Size = New Size(1168, 165)
        dgvDetalleSolicitudes.TabIndex = 31
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(dgvListaSolicitudes)
        GroupBox4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(21, 673)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1200, 85)
        GroupBox4.TabIndex = 32
        GroupBox4.TabStop = False
        GroupBox4.Text = "Lista de Solicitudes"
        ' 
        ' dgvListaSolicitudes
        ' 
        dgvListaSolicitudes.AllowUserToAddRows = False
        dgvListaSolicitudes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvListaSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListaSolicitudes.BackgroundColor = SystemColors.ButtonHighlight
        dgvListaSolicitudes.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvListaSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvListaSolicitudes.ColumnHeadersHeight = 35
        dgvListaSolicitudes.Columns.AddRange(New DataGridViewColumn() {IdSolicitudMantenimiento, NumSolicitud, FechaSolicitud, EstadoId, Estado})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvListaSolicitudes.DefaultCellStyle = DataGridViewCellStyle5
        dgvListaSolicitudes.GridColor = SystemColors.InactiveCaptionText
        dgvListaSolicitudes.Location = New Point(14, 30)
        dgvListaSolicitudes.Name = "dgvListaSolicitudes"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvListaSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvListaSolicitudes.RowHeadersVisible = False
        dgvListaSolicitudes.RowHeadersWidth = 62
        dgvListaSolicitudes.Size = New Size(1168, 47)
        dgvListaSolicitudes.TabIndex = 32
        ' 
        ' IdSolicitudMantenimiento
        ' 
        IdSolicitudMantenimiento.DataPropertyName = "IdSolicitudMantenimiento"
        IdSolicitudMantenimiento.HeaderText = "IdSolicitudMantenimiento"
        IdSolicitudMantenimiento.MinimumWidth = 8
        IdSolicitudMantenimiento.Name = "IdSolicitudMantenimiento"
        IdSolicitudMantenimiento.Visible = False
        ' 
        ' NumSolicitud
        ' 
        NumSolicitud.DataPropertyName = "IdSolicitudMantenimiento"
        NumSolicitud.HeaderText = "No. Solicitud"
        NumSolicitud.MinimumWidth = 8
        NumSolicitud.Name = "NumSolicitud"
        ' 
        ' FechaSolicitud
        ' 
        FechaSolicitud.DataPropertyName = "FechaSolicitud"
        FechaSolicitud.HeaderText = "Fecha"
        FechaSolicitud.MinimumWidth = 8
        FechaSolicitud.Name = "FechaSolicitud"
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
        ' IdDetalleSolicitudMantenimiento
        ' 
        IdDetalleSolicitudMantenimiento.DataPropertyName = "IdDetalleSolicitudMantenimiento"
        IdDetalleSolicitudMantenimiento.HeaderText = "IdDetalleSolicitudMantenimiento"
        IdDetalleSolicitudMantenimiento.MinimumWidth = 8
        IdDetalleSolicitudMantenimiento.Name = "IdDetalleSolicitudMantenimiento"
        IdDetalleSolicitudMantenimiento.Visible = False
        ' 
        ' SolicitudMantenimientoId
        ' 
        SolicitudMantenimientoId.DataPropertyName = "SolicitudMantenimientoId"
        SolicitudMantenimientoId.HeaderText = "SolicitudMantenimientoId"
        SolicitudMantenimientoId.MinimumWidth = 8
        SolicitudMantenimientoId.Name = "SolicitudMantenimientoId"
        SolicitudMantenimientoId.Visible = False
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
        ' ActivoFisicoId
        ' 
        ActivoFisicoId.DataPropertyName = "ActivoFisicoId"
        ActivoFisicoId.HeaderText = "ActivoFisicoId"
        ActivoFisicoId.MinimumWidth = 8
        ActivoFisicoId.Name = "ActivoFisicoId"
        ActivoFisicoId.Visible = False
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
        ' EstadoIdd
        ' 
        EstadoIdd.DataPropertyName = "EstadoId"
        EstadoIdd.HeaderText = "Estado"
        EstadoIdd.MinimumWidth = 8
        EstadoIdd.Name = "EstadoIdd"
        EstadoIdd.Visible = False
        ' 
        ' Estadoo
        ' 
        Estadoo.DataPropertyName = "Estado"
        Estadoo.HeaderText = "Estado"
        Estadoo.MinimumWidth = 8
        Estadoo.Name = "Estadoo"
        ' 
        ' DescripcionProblema
        ' 
        DescripcionProblema.DataPropertyName = "DescripcionProblema"
        DescripcionProblema.HeaderText = "Problema Reportado"
        DescripcionProblema.MinimumWidth = 8
        DescripcionProblema.Name = "DescripcionProblema"
        ' 
        ' frmSolicitudesMantenimiento
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox1)
        Controls.Add(label1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSolicitudesMantenimiento"
        Text = "frmSolicitudesMantenimiento"
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(dgvDetalleSolicitudes, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        CType(dgvListaSolicitudes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents rtxtObservacionGeneral As RichTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtNumSolicitud As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtActivo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCargarBusqueda As Button
    Friend WithEvents txtBarraBusqueda As TextBox
    Friend WithEvents txtNumSerie As TextBox
    Friend WithEvents txtCodEtiquetaQR As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvDetalleSolicitudes As DataGridView
    Friend WithEvents btnLimparCampos As Button
    Friend WithEvents btnEliminarFila As Button
    Friend WithEvents btnRegistrarSolicitud As Button
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents rtxtDecripcionProblema As RichTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvListaSolicitudes As DataGridView
    Friend WithEvents IdSolicitudMantenimiento As DataGridViewTextBoxColumn
    Friend WithEvents NumSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents IdDetalleSolicitudMantenimiento As DataGridViewTextBoxColumn
    Friend WithEvents SolicitudMantenimientoId As DataGridViewTextBoxColumn
    Friend WithEvents ActivoId As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents ActivoFisicoId As DataGridViewTextBoxColumn
    Friend WithEvents CodEtiquetaQR As DataGridViewTextBoxColumn
    Friend WithEvents NumSerie As DataGridViewTextBoxColumn
    Friend WithEvents MarcaId As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoriaId As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents EstadoIdd As DataGridViewTextBoxColumn
    Friend WithEvents Estadoo As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProblema As DataGridViewTextBoxColumn
End Class
