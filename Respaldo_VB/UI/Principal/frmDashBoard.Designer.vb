<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashBoard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashBoard))
        label1 = New Label()
        GroupBox2 = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        GroupBox6 = New GroupBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblTotalActivos = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox12 = New GroupBox()
        TableLayoutPanel5 = New TableLayoutPanel()
        lblActivosPerdidos = New Label()
        Label11 = New Label()
        PictureBox8 = New PictureBox()
        GroupBox8 = New GroupBox()
        PictureBox3 = New PictureBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        lblActivosDanados = New Label()
        Label9 = New Label()
        GroupBox7 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        lblActivosDisponibles = New Label()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        GroupBox11 = New GroupBox()
        PictureBox7 = New PictureBox()
        TableLayoutPanel10 = New TableLayoutPanel()
        lblSolicitudPendiente = New Label()
        Label17 = New Label()
        PictureBox4 = New PictureBox()
        lblUsuarioLoguaado = New Label()
        GroupBox9 = New GroupBox()
        PictureBox5 = New PictureBox()
        TableLayoutPanel8 = New TableLayoutPanel()
        lblPrestamoPendiente = New Label()
        Label13 = New Label()
        GroupBox10 = New GroupBox()
        PictureBox6 = New PictureBox()
        TableLayoutPanel9 = New TableLayoutPanel()
        lblPrestamoVencido = New Label()
        Label15 = New Label()
        GroupBox14 = New GroupBox()
        TableLayoutPanel12 = New TableLayoutPanel()
        GroupBox16 = New GroupBox()
        TableLayoutPanel14 = New TableLayoutPanel()
        lblTotalUsuario = New Label()
        Label23 = New Label()
        PictureBox11 = New PictureBox()
        GroupBox17 = New GroupBox()
        TableLayoutPanel15 = New TableLayoutPanel()
        lblTotalUbicaciones = New Label()
        Label25 = New Label()
        PictureBox12 = New PictureBox()
        GroupBox15 = New GroupBox()
        TableLayoutPanel13 = New TableLayoutPanel()
        lblTotalPersonal = New Label()
        Label21 = New Label()
        PictureBox10 = New PictureBox()
        TableLayoutPanel16 = New TableLayoutPanel()
        GroupBox3 = New GroupBox()
        pnlCabecera = New Panel()
        PictureBox9 = New PictureBox()
        PictureBox14 = New PictureBox()
        lblHora = New Label()
        lblFecha = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Timer1 = New Timer(components)
        Panel4 = New Panel()
        GroupBox2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox6.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox12.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox8.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        GroupBox7.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox11.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel10.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox9.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel8.SuspendLayout()
        GroupBox10.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel9.SuspendLayout()
        GroupBox14.SuspendLayout()
        TableLayoutPanel12.SuspendLayout()
        GroupBox16.SuspendLayout()
        TableLayoutPanel14.SuspendLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox17.SuspendLayout()
        TableLayoutPanel15.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox15.SuspendLayout()
        TableLayoutPanel13.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel16.SuspendLayout()
        GroupBox3.SuspendLayout()
        pnlCabecera.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
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
        label1.Size = New Size(1400, 37)
        label1.TabIndex = 6
        label1.Text = "PANEL CENTRAL DE MONITOREO DE ACTIVOS"
        label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(TableLayoutPanel1)
        GroupBox2.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(3, 18)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1333, 253)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Activos"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(GroupBox6, 0, 0)
        TableLayoutPanel1.Controls.Add(GroupBox12, 3, 0)
        TableLayoutPanel1.Controls.Add(GroupBox8, 2, 0)
        TableLayoutPanel1.Controls.Add(GroupBox7, 1, 0)
        TableLayoutPanel1.Location = New Point(10, 26)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1314, 221)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox6.BackColor = SystemColors.ButtonHighlight
        GroupBox6.Controls.Add(TableLayoutPanel2)
        GroupBox6.Controls.Add(PictureBox1)
        GroupBox6.Location = New Point(3, 3)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(322, 215)
        GroupBox6.TabIndex = 14
        GroupBox6.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(lblTotalActivos, 0, 1)
        TableLayoutPanel2.Controls.Add(Label5, 0, 0)
        TableLayoutPanel2.Location = New Point(184, 56)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(130, 121)
        TableLayoutPanel2.TabIndex = 13
        ' 
        ' lblTotalActivos
        ' 
        lblTotalActivos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTotalActivos.AutoSize = True
        lblTotalActivos.Font = New Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalActivos.Location = New Point(3, 63)
        lblTotalActivos.Margin = New Padding(3)
        lblTotalActivos.Name = "lblTotalActivos"
        lblTotalActivos.Size = New Size(124, 42)
        lblTotalActivos.TabIndex = 2
        lblTotalActivos.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 3)
        Label5.Margin = New Padding(3)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(3)
        Label5.Size = New Size(124, 54)
        Label5.TabIndex = 1
        Label5.Text = "Activos " & vbCrLf & "Totales"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Honeydew
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(5, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(172, 189)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox12
        ' 
        GroupBox12.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox12.BackColor = Color.White
        GroupBox12.Controls.Add(TableLayoutPanel5)
        GroupBox12.Controls.Add(PictureBox8)
        GroupBox12.Location = New Point(987, 3)
        GroupBox12.Name = "GroupBox12"
        GroupBox12.Size = New Size(324, 215)
        GroupBox12.TabIndex = 17
        GroupBox12.TabStop = False
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(lblActivosPerdidos, 0, 1)
        TableLayoutPanel5.Controls.Add(Label11, 0, 0)
        TableLayoutPanel5.Location = New Point(182, 48)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(134, 121)
        TableLayoutPanel5.TabIndex = 13
        ' 
        ' lblActivosPerdidos
        ' 
        lblActivosPerdidos.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblActivosPerdidos.AutoSize = True
        lblActivosPerdidos.Font = New Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActivosPerdidos.Location = New Point(3, 63)
        lblActivosPerdidos.Margin = New Padding(3)
        lblActivosPerdidos.Name = "lblActivosPerdidos"
        lblActivosPerdidos.Size = New Size(128, 42)
        lblActivosPerdidos.TabIndex = 2
        lblActivosPerdidos.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(3, 3)
        Label11.Margin = New Padding(3)
        Label11.Name = "Label11"
        Label11.Padding = New Padding(3)
        Label11.Size = New Size(128, 54)
        Label11.TabIndex = 1
        Label11.Text = "Activos " & vbCrLf & "Perdidos"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.MistyRose
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(5, 20)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(172, 189)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 0
        PictureBox8.TabStop = False
        ' 
        ' GroupBox8
        ' 
        GroupBox8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox8.BackColor = Color.White
        GroupBox8.Controls.Add(PictureBox3)
        GroupBox8.Controls.Add(TableLayoutPanel4)
        GroupBox8.Location = New Point(659, 3)
        GroupBox8.Name = "GroupBox8"
        GroupBox8.Size = New Size(322, 215)
        GroupBox8.TabIndex = 16
        GroupBox8.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.OldLace
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(5, 20)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(172, 189)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(lblActivosDanados, 0, 1)
        TableLayoutPanel4.Controls.Add(Label9, 0, 0)
        TableLayoutPanel4.Location = New Point(183, 52)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(132, 121)
        TableLayoutPanel4.TabIndex = 12
        ' 
        ' lblActivosDanados
        ' 
        lblActivosDanados.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblActivosDanados.AutoSize = True
        lblActivosDanados.Font = New Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActivosDanados.Location = New Point(3, 63)
        lblActivosDanados.Margin = New Padding(3)
        lblActivosDanados.Name = "lblActivosDanados"
        lblActivosDanados.Size = New Size(126, 42)
        lblActivosDanados.TabIndex = 2
        lblActivosDanados.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(3, 3)
        Label9.Margin = New Padding(3)
        Label9.Name = "Label9"
        Label9.Padding = New Padding(3)
        Label9.Size = New Size(126, 54)
        Label9.TabIndex = 1
        Label9.Text = "Activos " & vbCrLf & "Dañados"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox7.BackColor = SystemColors.ButtonHighlight
        GroupBox7.Controls.Add(TableLayoutPanel3)
        GroupBox7.Controls.Add(PictureBox2)
        GroupBox7.Location = New Point(331, 3)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(322, 215)
        GroupBox7.TabIndex = 15
        GroupBox7.TabStop = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(lblActivosDisponibles, 0, 1)
        TableLayoutPanel3.Controls.Add(Label7, 0, 0)
        TableLayoutPanel3.Location = New Point(181, 53)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(137, 121)
        TableLayoutPanel3.TabIndex = 13
        ' 
        ' lblActivosDisponibles
        ' 
        lblActivosDisponibles.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblActivosDisponibles.AutoSize = True
        lblActivosDisponibles.Font = New Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActivosDisponibles.Location = New Point(3, 63)
        lblActivosDisponibles.Margin = New Padding(3)
        lblActivosDisponibles.Name = "lblActivosDisponibles"
        lblActivosDisponibles.Size = New Size(131, 42)
        lblActivosDisponibles.TabIndex = 2
        lblActivosDisponibles.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(3, 3)
        Label7.Margin = New Padding(3)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(3)
        Label7.Size = New Size(131, 54)
        Label7.TabIndex = 1
        Label7.Text = "Activos " & vbCrLf & "Disponibles"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.LightSteelBlue
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(5, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(172, 189)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' GroupBox11
        ' 
        GroupBox11.Anchor = AnchorStyles.Top
        GroupBox11.Controls.Add(PictureBox7)
        GroupBox11.Controls.Add(TableLayoutPanel10)
        GroupBox11.Location = New Point(882, 3)
        GroupBox11.Name = "GroupBox11"
        GroupBox11.Size = New Size(426, 241)
        GroupBox11.TabIndex = 16
        GroupBox11.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.LavenderBlush
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(4, 20)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(195, 215)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel10.ColumnCount = 1
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Controls.Add(lblSolicitudPendiente, 0, 1)
        TableLayoutPanel10.Controls.Add(Label17, 0, 0)
        TableLayoutPanel10.Location = New Point(209, 68)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 2
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel10.Size = New Size(205, 121)
        TableLayoutPanel10.TabIndex = 16
        ' 
        ' lblSolicitudPendiente
        ' 
        lblSolicitudPendiente.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblSolicitudPendiente.AutoSize = True
        lblSolicitudPendiente.Font = New Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSolicitudPendiente.Location = New Point(3, 63)
        lblSolicitudPendiente.Margin = New Padding(3)
        lblSolicitudPendiente.Name = "lblSolicitudPendiente"
        lblSolicitudPendiente.Size = New Size(199, 42)
        lblSolicitudPendiente.TabIndex = 2
        lblSolicitudPendiente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(3, 3)
        Label17.Margin = New Padding(3)
        Label17.Name = "Label17"
        Label17.Padding = New Padding(3)
        Label17.Size = New Size(199, 54)
        Label17.TabIndex = 1
        Label17.Text = "Activos en" & vbCrLf & "Mantenimiento" & vbCrLf
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(5, 6)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(68, 64)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' lblUsuarioLoguaado
        ' 
        lblUsuarioLoguaado.AutoSize = True
        lblUsuarioLoguaado.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUsuarioLoguaado.Location = New Point(79, 43)
        lblUsuarioLoguaado.Name = "lblUsuarioLoguaado"
        lblUsuarioLoguaado.Size = New Size(177, 27)
        lblUsuarioLoguaado.TabIndex = 10
        lblUsuarioLoguaado.Text = "Usuario12345"
        ' 
        ' GroupBox9
        ' 
        GroupBox9.Anchor = AnchorStyles.Top
        GroupBox9.Controls.Add(PictureBox5)
        GroupBox9.Controls.Add(TableLayoutPanel8)
        GroupBox9.Location = New Point(6, 3)
        GroupBox9.Name = "GroupBox9"
        GroupBox9.Size = New Size(426, 241)
        GroupBox9.TabIndex = 15
        GroupBox9.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Honeydew
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(4, 20)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(195, 215)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel8.ColumnCount = 1
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Controls.Add(lblPrestamoPendiente, 0, 1)
        TableLayoutPanel8.Controls.Add(Label13, 0, 0)
        TableLayoutPanel8.Location = New Point(204, 66)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Size = New Size(215, 121)
        TableLayoutPanel8.TabIndex = 14
        ' 
        ' lblPrestamoPendiente
        ' 
        lblPrestamoPendiente.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPrestamoPendiente.AutoSize = True
        lblPrestamoPendiente.Font = New Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrestamoPendiente.Location = New Point(3, 63)
        lblPrestamoPendiente.Margin = New Padding(3)
        lblPrestamoPendiente.Name = "lblPrestamoPendiente"
        lblPrestamoPendiente.Size = New Size(209, 42)
        lblPrestamoPendiente.TabIndex = 2
        lblPrestamoPendiente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(3, 3)
        Label13.Margin = New Padding(3)
        Label13.Name = "Label13"
        Label13.Padding = New Padding(3)
        Label13.Size = New Size(209, 54)
        Label13.TabIndex = 1
        Label13.Text = "Prestamos " & vbCrLf & "Pendientes"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox10
        ' 
        GroupBox10.Anchor = AnchorStyles.Top
        GroupBox10.Controls.Add(PictureBox6)
        GroupBox10.Controls.Add(TableLayoutPanel9)
        GroupBox10.Location = New Point(444, 3)
        GroupBox10.Name = "GroupBox10"
        GroupBox10.Size = New Size(426, 241)
        GroupBox10.TabIndex = 16
        GroupBox10.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.LightSteelBlue
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(5, 20)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(195, 215)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 0
        PictureBox6.TabStop = False
        ' 
        ' TableLayoutPanel9
        ' 
        TableLayoutPanel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel9.ColumnCount = 1
        TableLayoutPanel9.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Controls.Add(lblPrestamoVencido, 0, 1)
        TableLayoutPanel9.Controls.Add(Label15, 0, 0)
        TableLayoutPanel9.Location = New Point(208, 69)
        TableLayoutPanel9.Name = "TableLayoutPanel9"
        TableLayoutPanel9.RowCount = 2
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel9.Size = New Size(209, 121)
        TableLayoutPanel9.TabIndex = 15
        ' 
        ' lblPrestamoVencido
        ' 
        lblPrestamoVencido.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPrestamoVencido.AutoSize = True
        lblPrestamoVencido.Font = New Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrestamoVencido.Location = New Point(3, 63)
        lblPrestamoVencido.Margin = New Padding(3)
        lblPrestamoVencido.Name = "lblPrestamoVencido"
        lblPrestamoVencido.Size = New Size(203, 42)
        lblPrestamoVencido.TabIndex = 2
        lblPrestamoVencido.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(3, 3)
        Label15.Margin = New Padding(3)
        Label15.Name = "Label15"
        Label15.Padding = New Padding(3)
        Label15.Size = New Size(203, 54)
        Label15.TabIndex = 1
        Label15.Text = "Prestamos " & vbCrLf & "Vencidos"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox14
        ' 
        GroupBox14.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox14.Controls.Add(TableLayoutPanel12)
        GroupBox14.Location = New Point(3, 4)
        GroupBox14.Name = "GroupBox14"
        GroupBox14.Size = New Size(1333, 140)
        GroupBox14.TabIndex = 11
        GroupBox14.TabStop = False
        ' 
        ' TableLayoutPanel12
        ' 
        TableLayoutPanel12.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel12.ColumnCount = 3
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel12.Controls.Add(GroupBox16, 1, 0)
        TableLayoutPanel12.Controls.Add(GroupBox17, 2, 0)
        TableLayoutPanel12.Controls.Add(GroupBox15, 0, 0)
        TableLayoutPanel12.Location = New Point(10, 25)
        TableLayoutPanel12.Name = "TableLayoutPanel12"
        TableLayoutPanel12.RowCount = 1
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel12.Size = New Size(1317, 112)
        TableLayoutPanel12.TabIndex = 19
        ' 
        ' GroupBox16
        ' 
        GroupBox16.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox16.Controls.Add(TableLayoutPanel14)
        GroupBox16.Controls.Add(PictureBox11)
        GroupBox16.Location = New Point(442, 3)
        GroupBox16.Name = "GroupBox16"
        GroupBox16.Size = New Size(433, 98)
        GroupBox16.TabIndex = 18
        GroupBox16.TabStop = False
        ' 
        ' TableLayoutPanel14
        ' 
        TableLayoutPanel14.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel14.ColumnCount = 1
        TableLayoutPanel14.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel14.Controls.Add(lblTotalUsuario, 0, 1)
        TableLayoutPanel14.Controls.Add(Label23, 0, 0)
        TableLayoutPanel14.Location = New Point(110, 20)
        TableLayoutPanel14.Name = "TableLayoutPanel14"
        TableLayoutPanel14.RowCount = 2
        TableLayoutPanel14.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel14.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel14.Size = New Size(309, 70)
        TableLayoutPanel14.TabIndex = 16
        ' 
        ' lblTotalUsuario
        ' 
        lblTotalUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTotalUsuario.AutoSize = True
        lblTotalUsuario.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalUsuario.Location = New Point(3, 38)
        lblTotalUsuario.Margin = New Padding(3)
        lblTotalUsuario.Name = "lblTotalUsuario"
        lblTotalUsuario.Size = New Size(303, 29)
        lblTotalUsuario.TabIndex = 2
        lblTotalUsuario.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label23.AutoSize = True
        Label23.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(3, 3)
        Label23.Margin = New Padding(3)
        Label23.Name = "Label23"
        Label23.Padding = New Padding(3)
        Label23.Size = New Size(303, 29)
        Label23.TabIndex = 1
        Label23.Text = "Usuarios Activos"
        Label23.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.Honeydew
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(7, 19)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(93, 71)
        PictureBox11.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox11.TabIndex = 0
        PictureBox11.TabStop = False
        ' 
        ' GroupBox17
        ' 
        GroupBox17.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox17.Controls.Add(TableLayoutPanel15)
        GroupBox17.Controls.Add(PictureBox12)
        GroupBox17.Location = New Point(881, 3)
        GroupBox17.Name = "GroupBox17"
        GroupBox17.Size = New Size(433, 98)
        GroupBox17.TabIndex = 19
        GroupBox17.TabStop = False
        ' 
        ' TableLayoutPanel15
        ' 
        TableLayoutPanel15.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel15.ColumnCount = 1
        TableLayoutPanel15.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel15.Controls.Add(lblTotalUbicaciones, 0, 1)
        TableLayoutPanel15.Controls.Add(Label25, 0, 0)
        TableLayoutPanel15.Location = New Point(108, 19)
        TableLayoutPanel15.Name = "TableLayoutPanel15"
        TableLayoutPanel15.RowCount = 2
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel15.Size = New Size(317, 70)
        TableLayoutPanel15.TabIndex = 16
        ' 
        ' lblTotalUbicaciones
        ' 
        lblTotalUbicaciones.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTotalUbicaciones.AutoSize = True
        lblTotalUbicaciones.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalUbicaciones.Location = New Point(3, 38)
        lblTotalUbicaciones.Margin = New Padding(3)
        lblTotalUbicaciones.Name = "lblTotalUbicaciones"
        lblTotalUbicaciones.Size = New Size(311, 29)
        lblTotalUbicaciones.TabIndex = 2
        lblTotalUbicaciones.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label25
        ' 
        Label25.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label25.AutoSize = True
        Label25.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(3, 3)
        Label25.Margin = New Padding(3)
        Label25.Name = "Label25"
        Label25.Padding = New Padding(3)
        Label25.Size = New Size(311, 29)
        Label25.TabIndex = 1
        Label25.Text = "Total de Ubicaciones"
        Label25.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = Color.Lavender
        PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), Image)
        PictureBox12.Location = New Point(7, 19)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(93, 71)
        PictureBox12.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox12.TabIndex = 0
        PictureBox12.TabStop = False
        ' 
        ' GroupBox15
        ' 
        GroupBox15.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox15.Controls.Add(TableLayoutPanel13)
        GroupBox15.Controls.Add(PictureBox10)
        GroupBox15.Location = New Point(3, 3)
        GroupBox15.Name = "GroupBox15"
        GroupBox15.Size = New Size(433, 98)
        GroupBox15.TabIndex = 17
        GroupBox15.TabStop = False
        ' 
        ' TableLayoutPanel13
        ' 
        TableLayoutPanel13.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel13.ColumnCount = 1
        TableLayoutPanel13.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.Controls.Add(lblTotalPersonal, 0, 1)
        TableLayoutPanel13.Controls.Add(Label21, 0, 0)
        TableLayoutPanel13.Location = New Point(108, 19)
        TableLayoutPanel13.Name = "TableLayoutPanel13"
        TableLayoutPanel13.RowCount = 2
        TableLayoutPanel13.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel13.Size = New Size(309, 70)
        TableLayoutPanel13.TabIndex = 15
        ' 
        ' lblTotalPersonal
        ' 
        lblTotalPersonal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTotalPersonal.AutoSize = True
        lblTotalPersonal.Font = New Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalPersonal.Location = New Point(3, 38)
        lblTotalPersonal.Margin = New Padding(3)
        lblTotalPersonal.Name = "lblTotalPersonal"
        lblTotalPersonal.Size = New Size(303, 29)
        lblTotalPersonal.TabIndex = 2
        lblTotalPersonal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label21.AutoSize = True
        Label21.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(3, 3)
        Label21.Margin = New Padding(3)
        Label21.Name = "Label21"
        Label21.Padding = New Padding(3)
        Label21.Size = New Size(303, 29)
        Label21.TabIndex = 1
        Label21.Text = "Personales Activos"
        Label21.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.LightSteelBlue
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(6, 18)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(93, 71)
        PictureBox10.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox10.TabIndex = 0
        PictureBox10.TabStop = False
        ' 
        ' TableLayoutPanel16
        ' 
        TableLayoutPanel16.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel16.ColumnCount = 3
        TableLayoutPanel16.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel16.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel16.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel16.Controls.Add(GroupBox11, 2, 0)
        TableLayoutPanel16.Controls.Add(GroupBox10, 1, 0)
        TableLayoutPanel16.Controls.Add(GroupBox9, 0, 0)
        TableLayoutPanel16.Location = New Point(10, 32)
        TableLayoutPanel16.Name = "TableLayoutPanel16"
        TableLayoutPanel16.RowCount = 1
        TableLayoutPanel16.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel16.Size = New Size(1314, 247)
        TableLayoutPanel16.TabIndex = 12
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(TableLayoutPanel16)
        GroupBox3.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold)
        GroupBox3.Location = New Point(3, 21)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1333, 285)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        GroupBox3.Text = "Prestamos y Solicitudes"
        ' 
        ' pnlCabecera
        ' 
        pnlCabecera.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlCabecera.BackColor = SystemColors.ButtonHighlight
        pnlCabecera.BorderStyle = BorderStyle.FixedSingle
        pnlCabecera.Controls.Add(PictureBox9)
        pnlCabecera.Controls.Add(PictureBox14)
        pnlCabecera.Controls.Add(lblHora)
        pnlCabecera.Controls.Add(lblFecha)
        pnlCabecera.Controls.Add(Label3)
        pnlCabecera.Controls.Add(PictureBox4)
        pnlCabecera.Controls.Add(lblUsuarioLoguaado)
        pnlCabecera.Location = New Point(27, 51)
        pnlCabecera.Name = "pnlCabecera"
        pnlCabecera.Size = New Size(1341, 80)
        pnlCabecera.TabIndex = 12
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(1126, 40)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(33, 27)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 15
        PictureBox9.TabStop = False
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(1125, 7)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(33, 27)
        PictureBox14.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox14.TabIndex = 15
        PictureBox14.TabStop = False
        ' 
        ' lblHora
        ' 
        lblHora.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblHora.AutoSize = True
        lblHora.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblHora.Location = New Point(1166, 39)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(164, 27)
        lblHora.TabIndex = 13
        lblHora.Text = "00:00:00 p.m"
        ' 
        ' lblFecha
        ' 
        lblFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblFecha.Location = New Point(1167, 9)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(148, 27)
        lblFecha.TabIndex = 14
        lblFecha.Text = "00-00-0000"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bookman Old Style", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(84, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 30)
        Label3.TabIndex = 13
        Label3.Text = "Bienvenido"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(GroupBox2)
        Panel1.Location = New Point(27, 145)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1341, 277)
        Panel1.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(GroupBox3)
        Panel2.Location = New Point(27, 433)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1341, 314)
        Panel2.TabIndex = 14
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = SystemColors.ButtonHighlight
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(GroupBox14)
        Panel3.Location = New Point(27, 758)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1341, 150)
        Panel3.TabIndex = 15
        ' 
        ' Timer1
        ' 
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = SystemColors.ButtonHighlight
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Location = New Point(27, 917)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1341, 64)
        Panel4.TabIndex = 16
        ' 
        ' frmDashBoard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1400, 990)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(pnlCabecera)
        Controls.Add(label1)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDashBoard"
        Text = "frmDashBoard"
        GroupBox2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox12.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        GroupBox8.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        GroupBox7.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox11.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel10.ResumeLayout(False)
        TableLayoutPanel10.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        GroupBox9.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        GroupBox10.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel9.ResumeLayout(False)
        TableLayoutPanel9.PerformLayout()
        GroupBox14.ResumeLayout(False)
        TableLayoutPanel12.ResumeLayout(False)
        GroupBox16.ResumeLayout(False)
        TableLayoutPanel14.ResumeLayout(False)
        TableLayoutPanel14.PerformLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        GroupBox17.ResumeLayout(False)
        TableLayoutPanel15.ResumeLayout(False)
        TableLayoutPanel15.PerformLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        GroupBox15.ResumeLayout(False)
        TableLayoutPanel13.ResumeLayout(False)
        TableLayoutPanel13.PerformLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel16.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        pnlCabecera.ResumeLayout(False)
        pnlCabecera.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblUsuarioLoguaado As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents lblPrestamoVencido As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblActivosDanados As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblTotalActivos As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblActivosPerdidos As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblActivosDisponibles As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents lblPrestamoPendiente As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents lblSolicitudPendiente As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents lblTotalUsuario As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents lblTotalUbicaciones As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents lblTotalPersonal As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents pnlCabecera As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel4 As Panel
End Class
