<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjustes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjustes))
        TabControl1 = New TabControl()
        InfoCentroEducativo = New TabPage()
        GroupBox4 = New GroupBox()
        wvMapa = New Microsoft.Web.WebView2.WinForms.WebView2()
        GroupBox3 = New GroupBox()
        TableLayoutPanel6 = New TableLayoutPanel()
        Label13 = New Label()
        GroupBox2 = New GroupBox()
        picFotoEscuela = New PictureBox()
        btnAgregarFoto = New Button()
        GroupBox1 = New GroupBox()
        btnGuardarActualizar = New Button()
        TableLayoutPanel5 = New TableLayoutPanel()
        txtJornada = New TextBox()
        Label10 = New Label()
        txtModalidad = New TextBox()
        Label11 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        txtDistritoEducativo = New TextBox()
        txtRegionaleducativo = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        txtCorreo = New TextBox()
        txtDireccion = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        cmbDirector = New ComboBox()
        txtTelefono = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtNombreCentro = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        txtCodigoCentro = New TextBox()
        label1 = New Label()
        InfoDirector = New TabPage()
        GroupBox9 = New GroupBox()
        dgvDirector = New DataGridView()
        IdDirector = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Apellido = New DataGridViewTextBoxColumn()
        Cedula = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Correo = New DataGridViewTextBoxColumn()
        EstadoId = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GroupBox8 = New GroupBox()
        btnActualizarGuardar = New Button()
        btnNuevo = New Button()
        btnActivarDesactivar = New Button()
        GroupBox7 = New GroupBox()
        TableLayoutPanel8 = New TableLayoutPanel()
        Label16 = New Label()
        cmbEstado = New ComboBox()
        Label17 = New Label()
        txtCorreoDirector = New TextBox()
        Label18 = New Label()
        txtTelefonoDirector = New TextBox()
        TableLayoutPanel9 = New TableLayoutPanel()
        txtCedula = New TextBox()
        txtApellido = New TextBox()
        Label19 = New Label()
        Label20 = New Label()
        txtNombre = New TextBox()
        Label21 = New Label()
        GroupBox6 = New GroupBox()
        btnAnadirFoto = New Button()
        picFotoDirector = New PictureBox()
        GroupBox5 = New GroupBox()
        btnBuscar = New Button()
        txtBuscar = New TextBox()
        Label12 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        TabControl1.SuspendLayout()
        InfoCentroEducativo.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(wvMapa, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(picFotoEscuela, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        InfoDirector.SuspendLayout()
        GroupBox9.SuspendLayout()
        CType(dgvDirector, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox8.SuspendLayout()
        GroupBox7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        TableLayoutPanel9.SuspendLayout()
        GroupBox6.SuspendLayout()
        CType(picFotoDirector, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(InfoCentroEducativo)
        TabControl1.Controls.Add(InfoDirector)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1247, 765)
        TabControl1.TabIndex = 0
        ' 
        ' InfoCentroEducativo
        ' 
        InfoCentroEducativo.BackColor = SystemColors.ControlLightLight
        InfoCentroEducativo.BorderStyle = BorderStyle.Fixed3D
        InfoCentroEducativo.Controls.Add(GroupBox4)
        InfoCentroEducativo.Controls.Add(GroupBox3)
        InfoCentroEducativo.Controls.Add(GroupBox2)
        InfoCentroEducativo.Controls.Add(GroupBox1)
        InfoCentroEducativo.Controls.Add(label1)
        InfoCentroEducativo.Location = New Point(4, 34)
        InfoCentroEducativo.Name = "InfoCentroEducativo"
        InfoCentroEducativo.Padding = New Padding(3)
        InfoCentroEducativo.Size = New Size(1239, 727)
        InfoCentroEducativo.TabIndex = 0
        InfoCentroEducativo.Text = "Info. Centro Educativo"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(wvMapa)
        GroupBox4.Location = New Point(10, 491)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1214, 226)
        GroupBox4.TabIndex = 14
        GroupBox4.TabStop = False
        ' 
        ' wvMapa
        ' 
        wvMapa.AllowExternalDrop = True
        wvMapa.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        wvMapa.CreationProperties = Nothing
        wvMapa.DefaultBackgroundColor = Color.White
        wvMapa.Location = New Point(12, 23)
        wvMapa.Name = "wvMapa"
        wvMapa.Size = New Size(1189, 195)
        wvMapa.TabIndex = 0
        wvMapa.ZoomFactor = 1R
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(TableLayoutPanel6)
        GroupBox3.Location = New Point(10, 412)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1214, 73)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel6.Controls.Add(Label13, 0, 0)
        TableLayoutPanel6.Location = New Point(22, 25)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Size = New Size(1159, 36)
        TableLayoutPanel6.TabIndex = 42
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(3, 5)
        Label13.Margin = New Padding(3, 5, 3, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(1153, 25)
        Label13.TabIndex = 7
        Label13.Text = "Ubicacion"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(picFotoEscuela)
        GroupBox2.Controls.Add(btnAgregarFoto)
        GroupBox2.Location = New Point(22, 61)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(314, 345)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        ' 
        ' picFotoEscuela
        ' 
        picFotoEscuela.BorderStyle = BorderStyle.FixedSingle
        picFotoEscuela.Location = New Point(22, 32)
        picFotoEscuela.Name = "picFotoEscuela"
        picFotoEscuela.Size = New Size(269, 252)
        picFotoEscuela.SizeMode = PictureBoxSizeMode.Zoom
        picFotoEscuela.TabIndex = 36
        picFotoEscuela.TabStop = False
        ' 
        ' btnAgregarFoto
        ' 
        btnAgregarFoto.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAgregarFoto.BackColor = Color.LightCyan
        btnAgregarFoto.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregarFoto.Location = New Point(22, 290)
        btnAgregarFoto.Name = "btnAgregarFoto"
        btnAgregarFoto.Size = New Size(269, 33)
        btnAgregarFoto.TabIndex = 37
        btnAgregarFoto.Text = "Agregar Foto"
        btnAgregarFoto.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btnGuardarActualizar)
        GroupBox1.Controls.Add(TableLayoutPanel5)
        GroupBox1.Controls.Add(TableLayoutPanel4)
        GroupBox1.Controls.Add(TableLayoutPanel3)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Location = New Point(342, 61)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(882, 345)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        ' 
        ' btnGuardarActualizar
        ' 
        btnGuardarActualizar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnGuardarActualizar.BackColor = Color.Honeydew
        btnGuardarActualizar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnGuardarActualizar.Location = New Point(29, 296)
        btnGuardarActualizar.Name = "btnGuardarActualizar"
        btnGuardarActualizar.Size = New Size(820, 34)
        btnGuardarActualizar.TabIndex = 43
        btnGuardarActualizar.Text = "Guardar"
        btnGuardarActualizar.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel5.ColumnCount = 4
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(txtJornada, 3, 0)
        TableLayoutPanel5.Controls.Add(Label10, 2, 0)
        TableLayoutPanel5.Controls.Add(txtModalidad, 1, 0)
        TableLayoutPanel5.Controls.Add(Label11, 0, 0)
        TableLayoutPanel5.Location = New Point(29, 89)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(820, 36)
        TableLayoutPanel5.TabIndex = 42
        ' 
        ' txtJornada
        ' 
        txtJornada.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtJornada.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtJornada.Location = New Point(558, 3)
        txtJornada.Name = "txtJornada"
        txtJornada.Size = New Size(259, 31)
        txtJornada.TabIndex = 15
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(412, 5)
        Label10.Margin = New Padding(3, 5, 3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(140, 25)
        Label10.TabIndex = 11
        Label10.Text = "    Jornada:"
        ' 
        ' txtModalidad
        ' 
        txtModalidad.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtModalidad.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtModalidad.Location = New Point(147, 3)
        txtModalidad.Name = "txtModalidad"
        txtModalidad.Size = New Size(259, 31)
        txtModalidad.TabIndex = 8
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(3, 5)
        Label11.Margin = New Padding(3, 5, 3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(138, 25)
        Label11.TabIndex = 7
        Label11.Text = "Modalidad:"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 4
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(txtDistritoEducativo, 1, 0)
        TableLayoutPanel4.Controls.Add(txtRegionaleducativo, 3, 0)
        TableLayoutPanel4.Controls.Add(Label8, 2, 0)
        TableLayoutPanel4.Controls.Add(Label9, 0, 0)
        TableLayoutPanel4.Location = New Point(29, 243)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Size = New Size(820, 36)
        TableLayoutPanel4.TabIndex = 41
        ' 
        ' txtDistritoEducativo
        ' 
        txtDistritoEducativo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDistritoEducativo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtDistritoEducativo.Location = New Point(239, 3)
        txtDistritoEducativo.Name = "txtDistritoEducativo"
        txtDistritoEducativo.Size = New Size(148, 31)
        txtDistritoEducativo.TabIndex = 16
        ' 
        ' txtRegionaleducativo
        ' 
        txtRegionaleducativo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtRegionaleducativo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtRegionaleducativo.Location = New Point(669, 3)
        txtRegionaleducativo.Name = "txtRegionaleducativo"
        txtRegionaleducativo.Size = New Size(148, 31)
        txtRegionaleducativo.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(393, 5)
        Label8.Margin = New Padding(3, 5, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(270, 25)
        Label8.TabIndex = 11
        Label8.Text = "    Regional Educativo:"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(3, 5)
        Label9.Margin = New Padding(3, 5, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(230, 25)
        Label9.TabIndex = 7
        Label9.Text = "Distrito Educativo:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(txtCorreo, 1, 0)
        TableLayoutPanel3.Controls.Add(txtDireccion, 3, 0)
        TableLayoutPanel3.Controls.Add(Label6, 2, 0)
        TableLayoutPanel3.Controls.Add(Label7, 0, 0)
        TableLayoutPanel3.Location = New Point(29, 192)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(820, 36)
        TableLayoutPanel3.TabIndex = 40
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreo.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCorreo.Location = New Point(105, 3)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(271, 31)
        txtCorreo.TabIndex = 16
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDireccion.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtDireccion.Location = New Point(546, 3)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(271, 31)
        txtDireccion.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(382, 5)
        Label6.Margin = New Padding(3, 5, 3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(158, 25)
        Label6.TabIndex = 11
        Label6.Text = "    Direccion:"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(3, 5)
        Label7.Margin = New Padding(3, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 25)
        Label7.TabIndex = 7
        Label7.Text = "Correo:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(cmbDirector, 1, 0)
        TableLayoutPanel2.Controls.Add(txtTelefono, 3, 0)
        TableLayoutPanel2.Controls.Add(Label3, 2, 0)
        TableLayoutPanel2.Controls.Add(Label4, 0, 0)
        TableLayoutPanel2.Location = New Point(29, 140)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(820, 36)
        TableLayoutPanel2.TabIndex = 39
        ' 
        ' cmbDirector
        ' 
        cmbDirector.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbDirector.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbDirector.FormattingEnabled = True
        cmbDirector.Location = New Point(123, 3)
        cmbDirector.Name = "cmbDirector"
        cmbDirector.Size = New Size(267, 30)
        cmbDirector.TabIndex = 26
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefono.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtTelefono.Location = New Point(549, 3)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(268, 31)
        txtTelefono.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(396, 5)
        Label3.Margin = New Padding(3, 5, 3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 25)
        Label3.TabIndex = 11
        Label3.Text = "    Telefono:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 5)
        Label4.Margin = New Padding(3, 5, 3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 25)
        Label4.TabIndex = 7
        Label4.Text = "Director:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(txtNombreCentro, 1, 0)
        TableLayoutPanel1.Controls.Add(Label5, 2, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(txtCodigoCentro, 3, 0)
        TableLayoutPanel1.Location = New Point(29, 37)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(820, 36)
        TableLayoutPanel1.TabIndex = 38
        ' 
        ' txtNombreCentro
        ' 
        txtNombreCentro.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombreCentro.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNombreCentro.Location = New Point(242, 3)
        txtNombreCentro.Name = "txtNombreCentro"
        txtNombreCentro.Size = New Size(155, 31)
        txtNombreCentro.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(403, 5)
        Label5.Margin = New Padding(3, 5, 3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(252, 25)
        Label5.TabIndex = 11
        Label5.Text = "    Codigo del Centro:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(3, 5)
        Label2.Margin = New Padding(3, 5, 3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(233, 25)
        Label2.TabIndex = 7
        Label2.Text = "Nombre del Centro:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCodigoCentro
        ' 
        txtCodigoCentro.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCodigoCentro.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCodigoCentro.Location = New Point(661, 3)
        txtCodigoCentro.Name = "txtCodigoCentro"
        txtCodigoCentro.Size = New Size(156, 31)
        txtCodigoCentro.TabIndex = 8
        ' 
        ' label1
        ' 
        label1.BackColor = SystemColors.ActiveCaption
        label1.BorderStyle = BorderStyle.Fixed3D
        label1.Dock = DockStyle.Top
        label1.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(3, 3)
        label1.Margin = New Padding(4, 0, 4, 0)
        label1.Name = "label1"
        label1.Size = New Size(1229, 37)
        label1.TabIndex = 10
        label1.Text = "INFORMACION DEL CENTRO EDUCATIVO"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' InfoDirector
        ' 
        InfoDirector.BorderStyle = BorderStyle.Fixed3D
        InfoDirector.Controls.Add(GroupBox9)
        InfoDirector.Controls.Add(GroupBox8)
        InfoDirector.Controls.Add(GroupBox7)
        InfoDirector.Controls.Add(GroupBox6)
        InfoDirector.Controls.Add(GroupBox5)
        InfoDirector.Controls.Add(Label12)
        InfoDirector.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        InfoDirector.Location = New Point(4, 34)
        InfoDirector.Name = "InfoDirector"
        InfoDirector.Size = New Size(1239, 727)
        InfoDirector.TabIndex = 2
        InfoDirector.Text = "Info. Director"
        InfoDirector.UseVisualStyleBackColor = True
        ' 
        ' GroupBox9
        ' 
        GroupBox9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox9.Controls.Add(dgvDirector)
        GroupBox9.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox9.Location = New Point(12, 379)
        GroupBox9.Name = "GroupBox9"
        GroupBox9.Size = New Size(1210, 332)
        GroupBox9.TabIndex = 16
        GroupBox9.TabStop = False
        GroupBox9.Text = "Lista de Directores"
        ' 
        ' dgvDirector
        ' 
        dgvDirector.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDirector.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDirector.BackgroundColor = SystemColors.ButtonHighlight
        dgvDirector.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvDirector.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvDirector.ColumnHeadersHeight = 35
        dgvDirector.Columns.AddRange(New DataGridViewColumn() {IdDirector, Nombre, Apellido, Cedula, Telefono, Correo, EstadoId, Estado})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvDirector.DefaultCellStyle = DataGridViewCellStyle2
        dgvDirector.GridColor = SystemColors.InactiveCaptionText
        dgvDirector.Location = New Point(12, 36)
        dgvDirector.Name = "dgvDirector"
        dgvDirector.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvDirector.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvDirector.RowHeadersWidth = 62
        dgvDirector.Size = New Size(1187, 287)
        dgvDirector.TabIndex = 32
        ' 
        ' IdDirector
        ' 
        IdDirector.DataPropertyName = "IdDirector"
        IdDirector.HeaderText = "IdDirector"
        IdDirector.MinimumWidth = 8
        IdDirector.Name = "IdDirector"
        IdDirector.ReadOnly = True
        IdDirector.Visible = False
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
        ' GroupBox8
        ' 
        GroupBox8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox8.Controls.Add(btnActualizarGuardar)
        GroupBox8.Controls.Add(btnNuevo)
        GroupBox8.Controls.Add(btnActivarDesactivar)
        GroupBox8.Location = New Point(207, 306)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Size = New Size(1015, 63)
        GroupBox8.TabIndex = 15
        GroupBox8.TabStop = False
        ' 
        ' btnActualizarGuardar
        ' 
        btnActualizarGuardar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnActualizarGuardar.BackColor = Color.Honeydew
        btnActualizarGuardar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnActualizarGuardar.Location = New Point(810, 20)
        btnActualizarGuardar.Name = "btnActualizarGuardar"
        btnActualizarGuardar.Size = New Size(194, 34)
        btnActualizarGuardar.TabIndex = 42
        btnActualizarGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNuevo.BackColor = Color.LightCyan
        btnNuevo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnNuevo.Location = New Point(426, 20)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(191, 34)
        btnNuevo.TabIndex = 40
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnActivarDesactivar
        ' 
        btnActivarDesactivar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnActivarDesactivar.BackColor = Color.MistyRose
        btnActivarDesactivar.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnActivarDesactivar.Location = New Point(623, 20)
        btnActivarDesactivar.Name = "btnActivarDesactivar"
        btnActivarDesactivar.Size = New Size(181, 34)
        btnActivarDesactivar.TabIndex = 41
        btnActivarDesactivar.UseVisualStyleBackColor = False
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox7.Controls.Add(TableLayoutPanel8)
        GroupBox7.Controls.Add(TableLayoutPanel9)
        GroupBox7.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox7.Location = New Point(207, 125)
        GroupBox7.Margin = New Padding(4, 3, 4, 3)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Padding = New Padding(4, 3, 4, 3)
        GroupBox7.Size = New Size(1015, 179)
        GroupBox7.TabIndex = 14
        GroupBox7.TabStop = False
        GroupBox7.Text = "Datos del Personal"
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel8.ColumnCount = 6
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel8.Controls.Add(Label16, 4, 0)
        TableLayoutPanel8.Controls.Add(cmbEstado, 5, 0)
        TableLayoutPanel8.Controls.Add(Label17, 2, 0)
        TableLayoutPanel8.Controls.Add(txtCorreoDirector, 1, 0)
        TableLayoutPanel8.Controls.Add(Label18, 0, 0)
        TableLayoutPanel8.Controls.Add(txtTelefonoDirector, 3, 0)
        TableLayoutPanel8.Location = New Point(20, 106)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel8.Size = New Size(984, 36)
        TableLayoutPanel8.TabIndex = 25
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label16.Location = New Point(654, 5)
        Label16.Margin = New Padding(3, 5, 3, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(115, 24)
        Label16.TabIndex = 17
        Label16.Text = "    Estado:"
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(775, 3)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(206, 30)
        cmbEstado.TabIndex = 25
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label17.Location = New Point(304, 5)
        Label17.Margin = New Padding(3, 5, 3, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(134, 24)
        Label17.TabIndex = 11
        Label17.Text = "    Telefono:"
        ' 
        ' txtCorreoDirector
        ' 
        txtCorreoDirector.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreoDirector.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCorreoDirector.Location = New Point(94, 3)
        txtCorreoDirector.Name = "txtCorreoDirector"
        txtCorreoDirector.Size = New Size(204, 31)
        txtCorreoDirector.TabIndex = 8
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label18.Location = New Point(3, 5)
        Label18.Margin = New Padding(3, 5, 3, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(85, 24)
        Label18.TabIndex = 7
        Label18.Text = "Correo:"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtTelefonoDirector
        ' 
        txtTelefonoDirector.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTelefonoDirector.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtTelefonoDirector.Location = New Point(444, 3)
        txtTelefonoDirector.Name = "txtTelefonoDirector"
        txtTelefonoDirector.Size = New Size(204, 31)
        txtTelefonoDirector.TabIndex = 18
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel9.ColumnCount = 7
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel9.Controls.Add(txtCedula, 5, 0)
        TableLayoutPanel9.Controls.Add(txtApellido, 3, 0)
        TableLayoutPanel9.Controls.Add(Label19, 4, 0)
        TableLayoutPanel9.Controls.Add(Label20, 2, 0)
        TableLayoutPanel9.Controls.Add(txtNombre, 1, 0)
        TableLayoutPanel9.Controls.Add(Label21, 0, 0)
        TableLayoutPanel9.Location = New Point(20, 49)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 1
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel9.Size = New Size(984, 36)
        TableLayoutPanel9.TabIndex = 23
        ' 
        ' txtCedula
        ' 
        txtCedula.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCedula.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtCedula.Location = New Point(777, 3)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(203, 31)
        txtCedula.TabIndex = 16
        ' 
        ' txtApellido
        ' 
        txtApellido.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtApellido.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtApellido.Location = New Point(447, 3)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(203, 31)
        txtApellido.TabIndex = 15
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label19.AutoSize = True
        Label19.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label19.Location = New Point(656, 5)
        Label19.Margin = New Padding(3, 5, 3, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(115, 24)
        Label19.TabIndex = 13
        Label19.Text = "    Cedula:"
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label20.AutoSize = True
        Label20.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label20.Location = New Point(314, 5)
        Label20.Margin = New Padding(3, 5, 3, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(127, 24)
        Label20.TabIndex = 11
        Label20.Text = "    Apellido:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic)
        txtNombre.Location = New Point(105, 3)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(203, 31)
        txtNombre.TabIndex = 8
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label21.AutoSize = True
        Label21.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        Label21.Location = New Point(3, 5)
        Label21.Margin = New Padding(3, 5, 3, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(96, 24)
        Label21.TabIndex = 7
        Label21.Text = "Nombre:"
        Label21.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(btnAnadirFoto)
        GroupBox6.Controls.Add(picFotoDirector)
        GroupBox6.Location = New Point(12, 125)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(188, 244)
        GroupBox6.TabIndex = 13
        GroupBox6.TabStop = False
        ' 
        ' btnAnadirFoto
        ' 
        btnAnadirFoto.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAnadirFoto.BackColor = Color.LightCyan
        btnAnadirFoto.Font = New Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAnadirFoto.Location = New Point(10, 199)
        btnAnadirFoto.Name = "btnAnadirFoto"
        btnAnadirFoto.Size = New Size(170, 37)
        btnAnadirFoto.TabIndex = 42
        btnAnadirFoto.Text = "Agregar Foto"
        btnAnadirFoto.UseVisualStyleBackColor = False
        ' 
        ' picFotoDirector
        ' 
        picFotoDirector.BorderStyle = BorderStyle.FixedSingle
        picFotoDirector.Location = New Point(12, 25)
        picFotoDirector.Name = "picFotoDirector"
        picFotoDirector.Size = New Size(168, 170)
        picFotoDirector.SizeMode = PictureBoxSizeMode.Zoom
        picFotoDirector.TabIndex = 41
        picFotoDirector.TabStop = False
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox5.Controls.Add(btnBuscar)
        GroupBox5.Controls.Add(txtBuscar)
        GroupBox5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox5.Location = New Point(12, 40)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(1210, 79)
        GroupBox5.TabIndex = 12
        GroupBox5.TabStop = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscar.Font = New Font("Bookman Old Style", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.Location = New Point(1149, 21)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(50, 49)
        btnBuscar.TabIndex = 4
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtBuscar.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtBuscar.Location = New Point(10, 27)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(1137, 36)
        txtBuscar.TabIndex = 3
        ' 
        ' Label12
        ' 
        Label12.BackColor = SystemColors.ActiveCaption
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Dock = DockStyle.Top
        Label12.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(0, 0)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(1235, 37)
        Label12.TabIndex = 11
        Label12.Text = "GESTION DE DIRECTOR DEL CENTRO"
        Label12.TextAlign = ContentAlignment.TopCenter
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frmAjustes
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1247, 765)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAjustes"
        Text = "frmAjustes"
        TabControl1.ResumeLayout(False)
        InfoCentroEducativo.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        CType(wvMapa, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(picFotoEscuela, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        InfoDirector.ResumeLayout(False)
        GroupBox9.ResumeLayout(False)
        CType(dgvDirector, ComponentModel.ISupportInitialize).EndInit()
        GroupBox8.ResumeLayout(False)
        GroupBox7.ResumeLayout(False)
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel9.PerformLayout()
        GroupBox6.ResumeLayout(False)
        CType(picFotoDirector, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents InfoCentroEducativo As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents label1 As Label
    Friend WithEvents btnAgregarFoto As Button
    Friend WithEvents picFotoEscuela As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtNombreCentro As TextBox
    Friend WithEvents txtCodigoCentro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbDirector As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtDistritoEducativo As TextBox
    Friend WithEvents txtRegionaleducativo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txtJornada As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtModalidad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents btnGuardarActualizar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents wvMapa As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents InfoDirector As TabPage
    Private WithEvents Label12 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnAnadirFoto As Button
    Friend WithEvents picFotoDirector As PictureBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents txtTelefonoDirector As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCorreoDirector As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btnActualizarGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnActivarDesactivar As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents dgvDirector As DataGridView
    Friend WithEvents IdDirector As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Cedula As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents EstadoId As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
End Class
