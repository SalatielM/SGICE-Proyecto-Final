<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        pnlBarraSuperior = New Panel()
        NightControlBox1 = New ReaLTaiizor.Controls.NightControlBox()
        btnMenuDespliegue = New PictureBox()
        Label1 = New Label()
        flpBarraLateralMenu = New FlowLayoutPanel()
        Panel7 = New Panel()
        PictureBox2 = New PictureBox()
        flpMenuInicio = New FlowLayoutPanel()
        btnInicio = New Button()
        flpMenuInventario = New FlowLayoutPanel()
        btnMenuInventario = New Button()
        btnActivos = New Button()
        btnCategoria = New Button()
        btnSubCategoria = New Button()
        btnProveedores = New Button()
        btnMarca = New Button()
        btnAreas = New Button()
        btnEdificios = New Button()
        flpMenuMovimiento = New FlowLayoutPanel()
        btnMenuMovimientos = New Button()
        btnEntradas = New Button()
        btnSalidas = New Button()
        btnControlActivos = New Button()
        btnTraslado = New Button()
        flpMenuPrestamo = New FlowLayoutPanel()
        btnMenuPrestamo = New Button()
        btnPrestamo = New Button()
        btnDevolucion = New Button()
        flpMenuMantenimiento = New FlowLayoutPanel()
        btnMenuMantenimiento = New Button()
        btnSolicitudes = New Button()
        btnReparaciones = New Button()
        flpMenuAdministracion = New FlowLayoutPanel()
        btnMenuAdministracion = New Button()
        btnUsuario = New Button()
        btnPersonal = New Button()
        Button2 = New Button()
        btnBackup = New Button()
        btnAjustes = New Button()
        flpMenuReportes = New FlowLayoutPanel()
        btnMenuReportes = New Button()
        flpMenuAcercaDe = New FlowLayoutPanel()
        btnAcercaDe = New Button()
        tmrMenu = New Timer(components)
        pnlInferiordeInformacion = New Panel()
        pnlPanelContenedor = New Panel()
        pnlBarraSuperior.SuspendLayout()
        CType(btnMenuDespliegue, ComponentModel.ISupportInitialize).BeginInit()
        flpBarraLateralMenu.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        flpMenuInicio.SuspendLayout()
        flpMenuInventario.SuspendLayout()
        flpMenuMovimiento.SuspendLayout()
        flpMenuPrestamo.SuspendLayout()
        flpMenuMantenimiento.SuspendLayout()
        flpMenuAdministracion.SuspendLayout()
        flpMenuReportes.SuspendLayout()
        flpMenuAcercaDe.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBarraSuperior
        ' 
        pnlBarraSuperior.BorderStyle = BorderStyle.Fixed3D
        pnlBarraSuperior.Controls.Add(NightControlBox1)
        pnlBarraSuperior.Controls.Add(btnMenuDespliegue)
        pnlBarraSuperior.Controls.Add(Label1)
        pnlBarraSuperior.Dock = DockStyle.Top
        pnlBarraSuperior.Location = New Point(0, 0)
        pnlBarraSuperior.Name = "pnlBarraSuperior"
        pnlBarraSuperior.Size = New Size(1650, 40)
        pnlBarraSuperior.TabIndex = 0
        ' 
        ' NightControlBox1
        ' 
        NightControlBox1.BackColor = Color.Transparent
        NightControlBox1.CloseHoverColor = Color.FromArgb(CByte(199), CByte(80), CByte(80))
        NightControlBox1.CloseHoverForeColor = Color.White
        NightControlBox1.DefaultLocation = True
        NightControlBox1.DisableMaximizeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        NightControlBox1.DisableMinimizeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        NightControlBox1.Dock = DockStyle.Right
        NightControlBox1.EnableCloseColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        NightControlBox1.EnableMaximizeButton = True
        NightControlBox1.EnableMaximizeColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        NightControlBox1.EnableMinimizeButton = True
        NightControlBox1.EnableMinimizeColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        NightControlBox1.Location = New Point(1507, 0)
        NightControlBox1.MaximizeHoverColor = Color.FromArgb(CByte(15), CByte(255), CByte(255), CByte(255))
        NightControlBox1.MaximizeHoverForeColor = Color.White
        NightControlBox1.MinimizeHoverColor = Color.FromArgb(CByte(15), CByte(255), CByte(255), CByte(255))
        NightControlBox1.MinimizeHoverForeColor = Color.White
        NightControlBox1.Name = "NightControlBox1"
        NightControlBox1.Size = New Size(139, 31)
        NightControlBox1.TabIndex = 0
        ' 
        ' btnMenuDespliegue
        ' 
        btnMenuDespliegue.Image = My.Resources.Resources.icons8_menu_24
        btnMenuDespliegue.Location = New Point(5, 3)
        btnMenuDespliegue.Name = "btnMenuDespliegue"
        btnMenuDespliegue.Size = New Size(30, 32)
        btnMenuDespliegue.SizeMode = PictureBoxSizeMode.Zoom
        btnMenuDespliegue.TabIndex = 2
        btnMenuDespliegue.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(70, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(781, 24)
        Label1.TabIndex = 0
        Label1.Text = "SISTEMA DE GESTION DE INMOVILIARIOS PARA CENTROS EDUCATIVOS"
        ' 
        ' flpBarraLateralMenu
        ' 
        flpBarraLateralMenu.BackColor = SystemColors.ActiveCaption
        flpBarraLateralMenu.BorderStyle = BorderStyle.Fixed3D
        flpBarraLateralMenu.Controls.Add(Panel7)
        flpBarraLateralMenu.Controls.Add(flpMenuInicio)
        flpBarraLateralMenu.Controls.Add(flpMenuInventario)
        flpBarraLateralMenu.Controls.Add(flpMenuMovimiento)
        flpBarraLateralMenu.Controls.Add(flpMenuPrestamo)
        flpBarraLateralMenu.Controls.Add(flpMenuMantenimiento)
        flpBarraLateralMenu.Controls.Add(flpMenuAdministracion)
        flpBarraLateralMenu.Controls.Add(flpMenuReportes)
        flpBarraLateralMenu.Controls.Add(flpMenuAcercaDe)
        flpBarraLateralMenu.Dock = DockStyle.Left
        flpBarraLateralMenu.Location = New Point(0, 40)
        flpBarraLateralMenu.Name = "flpBarraLateralMenu"
        flpBarraLateralMenu.Size = New Size(250, 960)
        flpBarraLateralMenu.TabIndex = 1
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(PictureBox2)
        Panel7.Location = New Point(3, 3)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(240, 120)
        Panel7.TabIndex = 9
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(5, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(223, 109)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' flpMenuInicio
        ' 
        flpMenuInicio.BackColor = SystemColors.ActiveCaption
        flpMenuInicio.BorderStyle = BorderStyle.Fixed3D
        flpMenuInicio.Controls.Add(btnInicio)
        flpMenuInicio.Location = New Point(3, 129)
        flpMenuInicio.Name = "flpMenuInicio"
        flpMenuInicio.Size = New Size(240, 65)
        flpMenuInicio.TabIndex = 16
        ' 
        ' btnInicio
        ' 
        btnInicio.FlatAppearance.BorderSize = 0
        btnInicio.FlatStyle = FlatStyle.Flat
        btnInicio.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), Image)
        btnInicio.ImageAlign = ContentAlignment.MiddleLeft
        btnInicio.Location = New Point(3, 3)
        btnInicio.Name = "btnInicio"
        btnInicio.Size = New Size(235, 56)
        btnInicio.TabIndex = 5
        btnInicio.Text = "        Inicio"
        btnInicio.TextAlign = ContentAlignment.MiddleLeft
        btnInicio.UseVisualStyleBackColor = True
        ' 
        ' flpMenuInventario
        ' 
        flpMenuInventario.BackColor = SystemColors.ActiveCaption
        flpMenuInventario.BorderStyle = BorderStyle.Fixed3D
        flpMenuInventario.Controls.Add(btnMenuInventario)
        flpMenuInventario.Controls.Add(btnActivos)
        flpMenuInventario.Controls.Add(btnCategoria)
        flpMenuInventario.Controls.Add(btnSubCategoria)
        flpMenuInventario.Controls.Add(btnProveedores)
        flpMenuInventario.Controls.Add(btnMarca)
        flpMenuInventario.Controls.Add(btnAreas)
        flpMenuInventario.Controls.Add(btnEdificios)
        flpMenuInventario.Location = New Point(3, 197)
        flpMenuInventario.Margin = New Padding(3, 0, 0, 0)
        flpMenuInventario.Name = "flpMenuInventario"
        flpMenuInventario.Size = New Size(240, 65)
        flpMenuInventario.TabIndex = 9
        ' 
        ' btnMenuInventario
        ' 
        btnMenuInventario.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        btnMenuInventario.FlatAppearance.BorderSize = 0
        btnMenuInventario.FlatStyle = FlatStyle.Flat
        btnMenuInventario.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMenuInventario.ForeColor = SystemColors.ActiveCaptionText
        btnMenuInventario.Image = CType(resources.GetObject("btnMenuInventario.Image"), Image)
        btnMenuInventario.ImageAlign = ContentAlignment.MiddleLeft
        btnMenuInventario.Location = New Point(3, 3)
        btnMenuInventario.Name = "btnMenuInventario"
        btnMenuInventario.Size = New Size(230, 56)
        btnMenuInventario.TabIndex = 2
        btnMenuInventario.Text = "       Inventario"
        btnMenuInventario.TextAlign = ContentAlignment.MiddleLeft
        btnMenuInventario.UseVisualStyleBackColor = True
        ' 
        ' btnActivos
        ' 
        btnActivos.BackColor = SystemColors.GradientActiveCaption
        btnActivos.FlatAppearance.BorderSize = 0
        btnActivos.FlatStyle = FlatStyle.Flat
        btnActivos.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnActivos.Image = CType(resources.GetObject("btnActivos.Image"), Image)
        btnActivos.ImageAlign = ContentAlignment.MiddleLeft
        btnActivos.Location = New Point(55, 62)
        btnActivos.Margin = New Padding(55, 0, 0, 0)
        btnActivos.Name = "btnActivos"
        btnActivos.Size = New Size(194, 48)
        btnActivos.TabIndex = 3
        btnActivos.Text = "       Activos"
        btnActivos.TextAlign = ContentAlignment.MiddleLeft
        btnActivos.UseVisualStyleBackColor = False
        ' 
        ' btnCategoria
        ' 
        btnCategoria.BackColor = SystemColors.GradientActiveCaption
        btnCategoria.FlatAppearance.BorderSize = 0
        btnCategoria.FlatStyle = FlatStyle.Flat
        btnCategoria.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnCategoria.Image = CType(resources.GetObject("btnCategoria.Image"), Image)
        btnCategoria.ImageAlign = ContentAlignment.MiddleLeft
        btnCategoria.Location = New Point(55, 110)
        btnCategoria.Margin = New Padding(55, 0, 0, 0)
        btnCategoria.Name = "btnCategoria"
        btnCategoria.Size = New Size(194, 48)
        btnCategoria.TabIndex = 4
        btnCategoria.Text = "       Categoria"
        btnCategoria.TextAlign = ContentAlignment.MiddleLeft
        btnCategoria.UseVisualStyleBackColor = False
        ' 
        ' btnSubCategoria
        ' 
        btnSubCategoria.BackColor = SystemColors.GradientActiveCaption
        btnSubCategoria.FlatAppearance.BorderSize = 0
        btnSubCategoria.FlatStyle = FlatStyle.Flat
        btnSubCategoria.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnSubCategoria.Image = CType(resources.GetObject("btnSubCategoria.Image"), Image)
        btnSubCategoria.ImageAlign = ContentAlignment.MiddleLeft
        btnSubCategoria.Location = New Point(55, 158)
        btnSubCategoria.Margin = New Padding(55, 0, 0, 0)
        btnSubCategoria.Name = "btnSubCategoria"
        btnSubCategoria.Size = New Size(194, 48)
        btnSubCategoria.TabIndex = 12
        btnSubCategoria.Text = "     SubCategoria"
        btnSubCategoria.TextAlign = ContentAlignment.MiddleLeft
        btnSubCategoria.UseVisualStyleBackColor = False
        ' 
        ' btnProveedores
        ' 
        btnProveedores.BackColor = SystemColors.GradientActiveCaption
        btnProveedores.FlatAppearance.BorderSize = 0
        btnProveedores.FlatStyle = FlatStyle.Flat
        btnProveedores.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), Image)
        btnProveedores.ImageAlign = ContentAlignment.MiddleLeft
        btnProveedores.Location = New Point(55, 206)
        btnProveedores.Margin = New Padding(55, 0, 0, 0)
        btnProveedores.Name = "btnProveedores"
        btnProveedores.Size = New Size(194, 48)
        btnProveedores.TabIndex = 10
        btnProveedores.Text = "       Proveedores"
        btnProveedores.TextAlign = ContentAlignment.MiddleLeft
        btnProveedores.UseVisualStyleBackColor = False
        ' 
        ' btnMarca
        ' 
        btnMarca.BackColor = SystemColors.GradientActiveCaption
        btnMarca.FlatAppearance.BorderSize = 0
        btnMarca.FlatStyle = FlatStyle.Flat
        btnMarca.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnMarca.Image = CType(resources.GetObject("btnMarca.Image"), Image)
        btnMarca.ImageAlign = ContentAlignment.MiddleLeft
        btnMarca.Location = New Point(55, 254)
        btnMarca.Margin = New Padding(55, 0, 0, 0)
        btnMarca.Name = "btnMarca"
        btnMarca.Size = New Size(194, 48)
        btnMarca.TabIndex = 5
        btnMarca.Text = "       Marca"
        btnMarca.TextAlign = ContentAlignment.MiddleLeft
        btnMarca.UseVisualStyleBackColor = False
        ' 
        ' btnAreas
        ' 
        btnAreas.BackColor = SystemColors.GradientActiveCaption
        btnAreas.FlatAppearance.BorderSize = 0
        btnAreas.FlatStyle = FlatStyle.Flat
        btnAreas.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnAreas.Image = CType(resources.GetObject("btnAreas.Image"), Image)
        btnAreas.ImageAlign = ContentAlignment.MiddleLeft
        btnAreas.Location = New Point(55, 302)
        btnAreas.Margin = New Padding(55, 0, 0, 0)
        btnAreas.Name = "btnAreas"
        btnAreas.Size = New Size(194, 48)
        btnAreas.TabIndex = 6
        btnAreas.Text = "       Areas"
        btnAreas.TextAlign = ContentAlignment.MiddleLeft
        btnAreas.UseVisualStyleBackColor = False
        ' 
        ' btnEdificios
        ' 
        btnEdificios.BackColor = SystemColors.GradientActiveCaption
        btnEdificios.FlatAppearance.BorderSize = 0
        btnEdificios.FlatStyle = FlatStyle.Flat
        btnEdificios.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnEdificios.Image = CType(resources.GetObject("btnEdificios.Image"), Image)
        btnEdificios.ImageAlign = ContentAlignment.MiddleLeft
        btnEdificios.Location = New Point(55, 350)
        btnEdificios.Margin = New Padding(55, 0, 0, 0)
        btnEdificios.Name = "btnEdificios"
        btnEdificios.Size = New Size(194, 48)
        btnEdificios.TabIndex = 11
        btnEdificios.Text = "       Edificios"
        btnEdificios.TextAlign = ContentAlignment.MiddleLeft
        btnEdificios.UseVisualStyleBackColor = False
        ' 
        ' flpMenuMovimiento
        ' 
        flpMenuMovimiento.BackColor = SystemColors.ActiveCaption
        flpMenuMovimiento.BorderStyle = BorderStyle.Fixed3D
        flpMenuMovimiento.Controls.Add(btnMenuMovimientos)
        flpMenuMovimiento.Controls.Add(btnEntradas)
        flpMenuMovimiento.Controls.Add(btnSalidas)
        flpMenuMovimiento.Controls.Add(btnControlActivos)
        flpMenuMovimiento.Controls.Add(btnTraslado)
        flpMenuMovimiento.Location = New Point(3, 265)
        flpMenuMovimiento.Name = "flpMenuMovimiento"
        flpMenuMovimiento.Size = New Size(240, 65)
        flpMenuMovimiento.TabIndex = 10
        ' 
        ' btnMenuMovimientos
        ' 
        btnMenuMovimientos.FlatAppearance.BorderSize = 0
        btnMenuMovimientos.FlatStyle = FlatStyle.Flat
        btnMenuMovimientos.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMenuMovimientos.Image = CType(resources.GetObject("btnMenuMovimientos.Image"), Image)
        btnMenuMovimientos.ImageAlign = ContentAlignment.MiddleLeft
        btnMenuMovimientos.Location = New Point(3, 3)
        btnMenuMovimientos.Name = "btnMenuMovimientos"
        btnMenuMovimientos.Size = New Size(230, 56)
        btnMenuMovimientos.TabIndex = 2
        btnMenuMovimientos.Text = "       Movimientos"
        btnMenuMovimientos.TextAlign = ContentAlignment.MiddleLeft
        btnMenuMovimientos.UseVisualStyleBackColor = True
        ' 
        ' btnEntradas
        ' 
        btnEntradas.BackColor = SystemColors.GradientActiveCaption
        btnEntradas.FlatAppearance.BorderSize = 0
        btnEntradas.FlatStyle = FlatStyle.Flat
        btnEntradas.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnEntradas.Image = CType(resources.GetObject("btnEntradas.Image"), Image)
        btnEntradas.ImageAlign = ContentAlignment.MiddleLeft
        btnEntradas.Location = New Point(55, 62)
        btnEntradas.Margin = New Padding(55, 0, 0, 0)
        btnEntradas.Name = "btnEntradas"
        btnEntradas.Size = New Size(194, 56)
        btnEntradas.TabIndex = 3
        btnEntradas.Text = "       Entradas"
        btnEntradas.TextAlign = ContentAlignment.MiddleLeft
        btnEntradas.UseVisualStyleBackColor = False
        ' 
        ' btnSalidas
        ' 
        btnSalidas.BackColor = SystemColors.GradientActiveCaption
        btnSalidas.FlatAppearance.BorderSize = 0
        btnSalidas.FlatStyle = FlatStyle.Flat
        btnSalidas.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnSalidas.Image = CType(resources.GetObject("btnSalidas.Image"), Image)
        btnSalidas.ImageAlign = ContentAlignment.MiddleLeft
        btnSalidas.Location = New Point(55, 118)
        btnSalidas.Margin = New Padding(55, 0, 0, 0)
        btnSalidas.Name = "btnSalidas"
        btnSalidas.Size = New Size(194, 56)
        btnSalidas.TabIndex = 4
        btnSalidas.Text = "       Salidas"
        btnSalidas.TextAlign = ContentAlignment.MiddleLeft
        btnSalidas.UseVisualStyleBackColor = False
        ' 
        ' btnControlActivos
        ' 
        btnControlActivos.BackColor = SystemColors.GradientActiveCaption
        btnControlActivos.FlatAppearance.BorderSize = 0
        btnControlActivos.FlatStyle = FlatStyle.Flat
        btnControlActivos.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnControlActivos.Image = CType(resources.GetObject("btnControlActivos.Image"), Image)
        btnControlActivos.ImageAlign = ContentAlignment.MiddleLeft
        btnControlActivos.Location = New Point(55, 174)
        btnControlActivos.Margin = New Padding(55, 0, 0, 0)
        btnControlActivos.Name = "btnControlActivos"
        btnControlActivos.Size = New Size(194, 56)
        btnControlActivos.TabIndex = 5
        btnControlActivos.Text = "       Control Act."
        btnControlActivos.TextAlign = ContentAlignment.MiddleLeft
        btnControlActivos.UseVisualStyleBackColor = False
        ' 
        ' btnTraslado
        ' 
        btnTraslado.BackColor = SystemColors.GradientActiveCaption
        btnTraslado.FlatAppearance.BorderSize = 0
        btnTraslado.FlatStyle = FlatStyle.Flat
        btnTraslado.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnTraslado.Image = CType(resources.GetObject("btnTraslado.Image"), Image)
        btnTraslado.ImageAlign = ContentAlignment.MiddleLeft
        btnTraslado.Location = New Point(55, 230)
        btnTraslado.Margin = New Padding(55, 0, 0, 0)
        btnTraslado.Name = "btnTraslado"
        btnTraslado.Size = New Size(194, 56)
        btnTraslado.TabIndex = 6
        btnTraslado.Text = "       Traslados"
        btnTraslado.TextAlign = ContentAlignment.MiddleLeft
        btnTraslado.UseVisualStyleBackColor = False
        ' 
        ' flpMenuPrestamo
        ' 
        flpMenuPrestamo.BackColor = SystemColors.ActiveCaption
        flpMenuPrestamo.BorderStyle = BorderStyle.Fixed3D
        flpMenuPrestamo.Controls.Add(btnMenuPrestamo)
        flpMenuPrestamo.Controls.Add(btnPrestamo)
        flpMenuPrestamo.Controls.Add(btnDevolucion)
        flpMenuPrestamo.Location = New Point(3, 336)
        flpMenuPrestamo.Name = "flpMenuPrestamo"
        flpMenuPrestamo.Size = New Size(240, 65)
        flpMenuPrestamo.TabIndex = 11
        ' 
        ' btnMenuPrestamo
        ' 
        btnMenuPrestamo.FlatAppearance.BorderSize = 0
        btnMenuPrestamo.FlatStyle = FlatStyle.Flat
        btnMenuPrestamo.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMenuPrestamo.Image = CType(resources.GetObject("btnMenuPrestamo.Image"), Image)
        btnMenuPrestamo.ImageAlign = ContentAlignment.MiddleLeft
        btnMenuPrestamo.Location = New Point(3, 3)
        btnMenuPrestamo.Name = "btnMenuPrestamo"
        btnMenuPrestamo.Size = New Size(230, 56)
        btnMenuPrestamo.TabIndex = 2
        btnMenuPrestamo.Text = "       Prestamos"
        btnMenuPrestamo.TextAlign = ContentAlignment.MiddleLeft
        btnMenuPrestamo.UseVisualStyleBackColor = True
        ' 
        ' btnPrestamo
        ' 
        btnPrestamo.BackColor = SystemColors.GradientActiveCaption
        btnPrestamo.FlatAppearance.BorderSize = 0
        btnPrestamo.FlatStyle = FlatStyle.Flat
        btnPrestamo.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnPrestamo.Image = CType(resources.GetObject("btnPrestamo.Image"), Image)
        btnPrestamo.ImageAlign = ContentAlignment.MiddleLeft
        btnPrestamo.Location = New Point(55, 62)
        btnPrestamo.Margin = New Padding(55, 0, 0, 0)
        btnPrestamo.Name = "btnPrestamo"
        btnPrestamo.Size = New Size(194, 56)
        btnPrestamo.TabIndex = 3
        btnPrestamo.Text = "       Prestamo"
        btnPrestamo.TextAlign = ContentAlignment.MiddleLeft
        btnPrestamo.UseVisualStyleBackColor = False
        ' 
        ' btnDevolucion
        ' 
        btnDevolucion.BackColor = SystemColors.GradientActiveCaption
        btnDevolucion.FlatAppearance.BorderSize = 0
        btnDevolucion.FlatStyle = FlatStyle.Flat
        btnDevolucion.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnDevolucion.Image = CType(resources.GetObject("btnDevolucion.Image"), Image)
        btnDevolucion.ImageAlign = ContentAlignment.MiddleLeft
        btnDevolucion.Location = New Point(55, 118)
        btnDevolucion.Margin = New Padding(55, 0, 0, 0)
        btnDevolucion.Name = "btnDevolucion"
        btnDevolucion.Size = New Size(194, 56)
        btnDevolucion.TabIndex = 4
        btnDevolucion.Text = "       Devolucion"
        btnDevolucion.TextAlign = ContentAlignment.MiddleLeft
        btnDevolucion.UseVisualStyleBackColor = False
        ' 
        ' flpMenuMantenimiento
        ' 
        flpMenuMantenimiento.BackColor = SystemColors.ActiveCaption
        flpMenuMantenimiento.BorderStyle = BorderStyle.Fixed3D
        flpMenuMantenimiento.Controls.Add(btnMenuMantenimiento)
        flpMenuMantenimiento.Controls.Add(btnSolicitudes)
        flpMenuMantenimiento.Controls.Add(btnReparaciones)
        flpMenuMantenimiento.Location = New Point(3, 404)
        flpMenuMantenimiento.Margin = New Padding(3, 0, 0, 0)
        flpMenuMantenimiento.Name = "flpMenuMantenimiento"
        flpMenuMantenimiento.Size = New Size(240, 65)
        flpMenuMantenimiento.TabIndex = 12
        ' 
        ' btnMenuMantenimiento
        ' 
        btnMenuMantenimiento.FlatAppearance.BorderSize = 0
        btnMenuMantenimiento.FlatStyle = FlatStyle.Flat
        btnMenuMantenimiento.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMenuMantenimiento.Image = CType(resources.GetObject("btnMenuMantenimiento.Image"), Image)
        btnMenuMantenimiento.ImageAlign = ContentAlignment.MiddleLeft
        btnMenuMantenimiento.Location = New Point(3, 3)
        btnMenuMantenimiento.Name = "btnMenuMantenimiento"
        btnMenuMantenimiento.Size = New Size(246, 56)
        btnMenuMantenimiento.TabIndex = 2
        btnMenuMantenimiento.Text = "      Mantenimiento"
        btnMenuMantenimiento.TextAlign = ContentAlignment.MiddleLeft
        btnMenuMantenimiento.UseVisualStyleBackColor = True
        ' 
        ' btnSolicitudes
        ' 
        btnSolicitudes.BackColor = SystemColors.GradientActiveCaption
        btnSolicitudes.FlatAppearance.BorderSize = 0
        btnSolicitudes.FlatStyle = FlatStyle.Flat
        btnSolicitudes.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnSolicitudes.Image = CType(resources.GetObject("btnSolicitudes.Image"), Image)
        btnSolicitudes.ImageAlign = ContentAlignment.MiddleLeft
        btnSolicitudes.Location = New Point(55, 62)
        btnSolicitudes.Margin = New Padding(55, 0, 0, 0)
        btnSolicitudes.Name = "btnSolicitudes"
        btnSolicitudes.Size = New Size(194, 56)
        btnSolicitudes.TabIndex = 3
        btnSolicitudes.Text = "       Solicitudes"
        btnSolicitudes.TextAlign = ContentAlignment.MiddleLeft
        btnSolicitudes.UseVisualStyleBackColor = False
        ' 
        ' btnReparaciones
        ' 
        btnReparaciones.BackColor = SystemColors.GradientActiveCaption
        btnReparaciones.FlatAppearance.BorderSize = 0
        btnReparaciones.FlatStyle = FlatStyle.Flat
        btnReparaciones.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold)
        btnReparaciones.Image = CType(resources.GetObject("btnReparaciones.Image"), Image)
        btnReparaciones.ImageAlign = ContentAlignment.MiddleLeft
        btnReparaciones.Location = New Point(55, 118)
        btnReparaciones.Margin = New Padding(55, 0, 0, 0)
        btnReparaciones.Name = "btnReparaciones"
        btnReparaciones.Size = New Size(194, 56)
        btnReparaciones.TabIndex = 4
        btnReparaciones.Text = "       Reparacion"
        btnReparaciones.TextAlign = ContentAlignment.MiddleLeft
        btnReparaciones.UseVisualStyleBackColor = False
        ' 
        ' flpMenuAdministracion
        ' 
        flpMenuAdministracion.BackColor = SystemColors.ActiveCaption
        flpMenuAdministracion.BorderStyle = BorderStyle.Fixed3D
        flpMenuAdministracion.Controls.Add(btnMenuAdministracion)
        flpMenuAdministracion.Controls.Add(btnUsuario)
        flpMenuAdministracion.Controls.Add(btnPersonal)
        flpMenuAdministracion.Controls.Add(Button2)
        flpMenuAdministracion.Controls.Add(btnBackup)
        flpMenuAdministracion.Controls.Add(btnAjustes)
        flpMenuAdministracion.Location = New Point(3, 472)
        flpMenuAdministracion.Name = "flpMenuAdministracion"
        flpMenuAdministracion.Size = New Size(240, 65)
        flpMenuAdministracion.TabIndex = 14
        ' 
        ' btnMenuAdministracion
        ' 
        btnMenuAdministracion.FlatAppearance.BorderSize = 0
        btnMenuAdministracion.FlatStyle = FlatStyle.Flat
        btnMenuAdministracion.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMenuAdministracion.Image = CType(resources.GetObject("btnMenuAdministracion.Image"), Image)
        btnMenuAdministracion.ImageAlign = ContentAlignment.MiddleLeft
        btnMenuAdministracion.Location = New Point(3, 3)
        btnMenuAdministracion.Name = "btnMenuAdministracion"
        btnMenuAdministracion.Size = New Size(225, 56)
        btnMenuAdministracion.TabIndex = 2
        btnMenuAdministracion.Text = "       Admin."
        btnMenuAdministracion.TextAlign = ContentAlignment.MiddleLeft
        btnMenuAdministracion.UseVisualStyleBackColor = True
        ' 
        ' btnUsuario
        ' 
        btnUsuario.BackColor = SystemColors.GradientActiveCaption
        btnUsuario.FlatAppearance.BorderSize = 0
        btnUsuario.FlatStyle = FlatStyle.Flat
        btnUsuario.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUsuario.Image = CType(resources.GetObject("btnUsuario.Image"), Image)
        btnUsuario.ImageAlign = ContentAlignment.MiddleLeft
        btnUsuario.Location = New Point(55, 62)
        btnUsuario.Margin = New Padding(55, 0, 0, 0)
        btnUsuario.Name = "btnUsuario"
        btnUsuario.Size = New Size(194, 56)
        btnUsuario.TabIndex = 3
        btnUsuario.Text = "       Usuario"
        btnUsuario.TextAlign = ContentAlignment.MiddleLeft
        btnUsuario.UseVisualStyleBackColor = False
        ' 
        ' btnPersonal
        ' 
        btnPersonal.BackColor = SystemColors.GradientActiveCaption
        btnPersonal.FlatAppearance.BorderSize = 0
        btnPersonal.FlatStyle = FlatStyle.Flat
        btnPersonal.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPersonal.Image = CType(resources.GetObject("btnPersonal.Image"), Image)
        btnPersonal.ImageAlign = ContentAlignment.MiddleLeft
        btnPersonal.Location = New Point(55, 118)
        btnPersonal.Margin = New Padding(55, 0, 0, 0)
        btnPersonal.Name = "btnPersonal"
        btnPersonal.Size = New Size(194, 56)
        btnPersonal.TabIndex = 4
        btnPersonal.Text = "       Personal"
        btnPersonal.TextAlign = ContentAlignment.MiddleLeft
        btnPersonal.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientActiveCaption
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(55, 174)
        Button2.Margin = New Padding(55, 0, 0, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(194, 56)
        Button2.TabIndex = 16
        Button2.Text = "       Puestos"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnBackup
        ' 
        btnBackup.BackColor = SystemColors.GradientActiveCaption
        btnBackup.FlatAppearance.BorderSize = 0
        btnBackup.FlatStyle = FlatStyle.Flat
        btnBackup.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), Image)
        btnBackup.ImageAlign = ContentAlignment.MiddleLeft
        btnBackup.Location = New Point(55, 230)
        btnBackup.Margin = New Padding(55, 0, 0, 0)
        btnBackup.Name = "btnBackup"
        btnBackup.Size = New Size(194, 56)
        btnBackup.TabIndex = 5
        btnBackup.Text = "       Backup"
        btnBackup.TextAlign = ContentAlignment.MiddleLeft
        btnBackup.UseVisualStyleBackColor = False
        ' 
        ' btnAjustes
        ' 
        btnAjustes.BackColor = SystemColors.GradientActiveCaption
        btnAjustes.FlatAppearance.BorderSize = 0
        btnAjustes.FlatStyle = FlatStyle.Flat
        btnAjustes.Font = New Font("Bookman Old Style", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAjustes.Image = CType(resources.GetObject("btnAjustes.Image"), Image)
        btnAjustes.ImageAlign = ContentAlignment.MiddleLeft
        btnAjustes.Location = New Point(55, 286)
        btnAjustes.Margin = New Padding(55, 0, 0, 0)
        btnAjustes.Name = "btnAjustes"
        btnAjustes.Size = New Size(194, 56)
        btnAjustes.TabIndex = 6
        btnAjustes.Text = "       Ajustes"
        btnAjustes.TextAlign = ContentAlignment.MiddleLeft
        btnAjustes.UseVisualStyleBackColor = False
        ' 
        ' flpMenuReportes
        ' 
        flpMenuReportes.BackColor = SystemColors.ActiveCaption
        flpMenuReportes.BorderStyle = BorderStyle.Fixed3D
        flpMenuReportes.Controls.Add(btnMenuReportes)
        flpMenuReportes.Location = New Point(3, 543)
        flpMenuReportes.Name = "flpMenuReportes"
        flpMenuReportes.Size = New Size(240, 65)
        flpMenuReportes.TabIndex = 13
        ' 
        ' btnMenuReportes
        ' 
        btnMenuReportes.FlatAppearance.BorderSize = 0
        btnMenuReportes.FlatStyle = FlatStyle.Flat
        btnMenuReportes.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMenuReportes.Image = CType(resources.GetObject("btnMenuReportes.Image"), Image)
        btnMenuReportes.ImageAlign = ContentAlignment.MiddleLeft
        btnMenuReportes.Location = New Point(3, 3)
        btnMenuReportes.Name = "btnMenuReportes"
        btnMenuReportes.Size = New Size(230, 56)
        btnMenuReportes.TabIndex = 2
        btnMenuReportes.Text = "       Reportes"
        btnMenuReportes.TextAlign = ContentAlignment.MiddleLeft
        btnMenuReportes.UseVisualStyleBackColor = True
        ' 
        ' flpMenuAcercaDe
        ' 
        flpMenuAcercaDe.BackColor = SystemColors.ActiveCaption
        flpMenuAcercaDe.BorderStyle = BorderStyle.Fixed3D
        flpMenuAcercaDe.Controls.Add(btnAcercaDe)
        flpMenuAcercaDe.Location = New Point(3, 614)
        flpMenuAcercaDe.Name = "flpMenuAcercaDe"
        flpMenuAcercaDe.Size = New Size(240, 65)
        flpMenuAcercaDe.TabIndex = 15
        ' 
        ' btnAcercaDe
        ' 
        btnAcercaDe.FlatAppearance.BorderSize = 0
        btnAcercaDe.FlatStyle = FlatStyle.Flat
        btnAcercaDe.Font = New Font("Bookman Old Style", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAcercaDe.Image = CType(resources.GetObject("btnAcercaDe.Image"), Image)
        btnAcercaDe.ImageAlign = ContentAlignment.MiddleLeft
        btnAcercaDe.Location = New Point(3, 3)
        btnAcercaDe.Name = "btnAcercaDe"
        btnAcercaDe.Size = New Size(235, 56)
        btnAcercaDe.TabIndex = 5
        btnAcercaDe.Text = "       Acerca de"
        btnAcercaDe.TextAlign = ContentAlignment.MiddleLeft
        btnAcercaDe.UseVisualStyleBackColor = True
        ' 
        ' tmrMenu
        ' 
        tmrMenu.Interval = 4
        ' 
        ' pnlInferiordeInformacion
        ' 
        pnlInferiordeInformacion.BorderStyle = BorderStyle.Fixed3D
        pnlInferiordeInformacion.Dock = DockStyle.Bottom
        pnlInferiordeInformacion.Location = New Point(250, 977)
        pnlInferiordeInformacion.Name = "pnlInferiordeInformacion"
        pnlInferiordeInformacion.Size = New Size(1400, 23)
        pnlInferiordeInformacion.TabIndex = 2
        ' 
        ' pnlPanelContenedor
        ' 
        pnlPanelContenedor.BorderStyle = BorderStyle.Fixed3D
        pnlPanelContenedor.Dock = DockStyle.Fill
        pnlPanelContenedor.Location = New Point(250, 40)
        pnlPanelContenedor.Name = "pnlPanelContenedor"
        pnlPanelContenedor.Size = New Size(1400, 937)
        pnlPanelContenedor.TabIndex = 3
        ' 
        ' frmMenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1650, 1000)
        Controls.Add(pnlPanelContenedor)
        Controls.Add(pnlInferiordeInformacion)
        Controls.Add(flpBarraLateralMenu)
        Controls.Add(pnlBarraSuperior)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMenuPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMenuPrincipal"
        pnlBarraSuperior.ResumeLayout(False)
        pnlBarraSuperior.PerformLayout()
        CType(btnMenuDespliegue, ComponentModel.ISupportInitialize).EndInit()
        flpBarraLateralMenu.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        flpMenuInicio.ResumeLayout(False)
        flpMenuInventario.ResumeLayout(False)
        flpMenuMovimiento.ResumeLayout(False)
        flpMenuPrestamo.ResumeLayout(False)
        flpMenuMantenimiento.ResumeLayout(False)
        flpMenuAdministracion.ResumeLayout(False)
        flpMenuReportes.ResumeLayout(False)
        flpMenuAcercaDe.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBarraSuperior As Panel
    Friend WithEvents btnMenuDespliegue As PictureBox
    Friend WithEvents flpBarraLateralMenu As FlowLayoutPanel
    Friend WithEvents btnMenuInventario As Button
    Friend WithEvents btnAreas As Button
    Friend WithEvents btnMarca As Button
    Friend WithEvents btnCategoria As Button
    Friend WithEvents btnActivos As Button
    Friend WithEvents btnMenuMovimientos As Button
    Friend WithEvents btnEntradas As Button
    Friend WithEvents btnSalidas As Button
    Friend WithEvents btnControlActivos As Button
    Friend WithEvents btnTraslado As Button
    Friend WithEvents btnDevolucion As Button
    Friend WithEvents btnPrestamo As Button
    Friend WithEvents btnMenuPrestamo As Button
    Friend WithEvents btnReparaciones As Button
    Friend WithEvents btnSolicitudes As Button
    Friend WithEvents btnMenuMantenimiento As Button
    Friend WithEvents btnMenuReportes As Button
    Friend WithEvents btnAjustes As Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnPersonal As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnMenuAdministracion As Button
    Friend WithEvents btnAcercaDe As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents flpMenuInventario As FlowLayoutPanel
    Friend WithEvents flpMenuMovimiento As FlowLayoutPanel
    Friend WithEvents flpMenuPrestamo As FlowLayoutPanel
    Friend WithEvents flpMenuMantenimiento As FlowLayoutPanel
    Friend WithEvents flpMenuReportes As FlowLayoutPanel
    Friend WithEvents flpMenuAdministracion As FlowLayoutPanel
    Friend WithEvents tmrMenu As Timer
    Friend WithEvents flpMenuAcercaDe As FlowLayoutPanel
    Friend WithEvents pnlInferiordeInformacion As Panel
    Friend WithEvents pnlPanelContenedor As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents NightControlBox1 As ReaLTaiizor.Controls.NightControlBox
    Friend WithEvents flpMenuInicio As FlowLayoutPanel
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnSubCategoria As Button
    Friend WithEvents btnEdificios As Button
    Friend WithEvents btnProveedores As Button
End Class
