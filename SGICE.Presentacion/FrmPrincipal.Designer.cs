namespace SGICE.Presentacion;

partial class FrmPrincipal
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        pnlBarraSuperior = new Panel();
        lblTituloSistema = new Label();
        btnMenuToggle = new Button();
        pnlSidebar = new Panel();
        flpMenu = new FlowLayoutPanel();
        btnMenuInicio = new Button();
        btnMenuInventario = new Button();
        pnlSubInventario = new Panel();
        btnSubActivos = new Button();
        btnSubCategorias = new Button();
        btnSubSubCategorias = new Button();
        btnSubMarcas = new Button();
        btnSubProveedores = new Button();
        btnSubEdificios = new Button();
        btnSubUbicaciones = new Button();
        btnMenuMovimientos = new Button();
        pnlSubMovimientos = new Panel();
        btnSubEntradas = new Button();
        btnSubActivosFisicos = new Button();
        btnSubTraslados = new Button();
        btnSubSalidasBajas = new Button();
        btnMenuPrestamos = new Button();
        pnlSubPrestamos = new Panel();
        btnSubPrestamos = new Button();
        btnSubDevoluciones = new Button();
        btnMenuMantenimiento = new Button();
        pnlSubMantenimiento = new Panel();
        btnSubSolicitudesMant = new Button();
        btnSubOrdenesMant = new Button();
        btnMenuAdmin = new Button();
        pnlSubAdmin = new Panel();
        btnSubCentros = new Button();
        btnSubPersonal = new Button();
        btnSubUsuarios = new Button();
        btnMenuReportes = new Button();
        pnlSubReportes = new Panel();
        btnSubRepGeneral = new Button();
        btnSubRepInventario = new Button();
        btnSubRepAuditoria = new Button();
        btnMenuAcercaDe = new Button();
        btnMenuCerrarSesion = new Button();
        btnMenuSalir = new Button();
        picLogoSidebar = new PictureBox();
        pnlContenedor = new Panel();
        pnlInicio = new Panel();
        flpTarjetas = new FlowLayoutPanel();
        cardActivosTotales = new Panel();
        pnlAccentTotales = new Panel();
        lblValActivosTotales = new Label();
        lblTitActivosTotales = new Label();
        cardDisponibles = new Panel();
        pnlAccentDisponibles = new Panel();
        lblValDisponibles = new Label();
        lblTitDisponibles = new Label();
        cardPrestados = new Panel();
        pnlAccentPrestados = new Panel();
        lblValPrestados = new Label();
        lblTitPrestados = new Label();
        cardDanados = new Panel();
        pnlAccentDanados = new Panel();
        lblValDanados = new Label();
        lblTitDanados = new Label();
        cardPerdidos = new Panel();
        pnlAccentPerdidos = new Panel();
        lblValPerdidos = new Label();
        lblTitPerdidos = new Label();
        cardMantenimiento = new Panel();
        pnlAccentMantenimiento = new Panel();
        lblValMantenimiento = new Label();
        lblTitMantenimiento = new Label();
        cardPrestamosPendientes = new Panel();
        pnlAccentPrestPend = new Panel();
        lblValPrestamosPendientes = new Label();
        lblTitPrestamosPendientes = new Label();
        cardSolicitudesPendientes = new Panel();
        pnlAccentSolPend = new Panel();
        lblValSolicitudesPendientes = new Label();
        lblTitSolicitudesPendientes = new Label();
        pnlInicioTop = new Panel();
        lblInicioTitulo = new Label();
        statusStripPrincipal = new StatusStrip();
        lblStatusUsuario = new ToolStripStatusLabel();
        lblStatusSeparador1 = new ToolStripStatusLabel();
        lblStatusEstado = new ToolStripStatusLabel();
        statusSpring = new ToolStripStatusLabel();
        statusProgressBar = new ToolStripProgressBar();
        lblStatusSeparador2 = new ToolStripStatusLabel();
        lblStatusFecha = new ToolStripStatusLabel();
        timerFecha = new System.Windows.Forms.Timer(components);
        pnlBarraSuperior.SuspendLayout();
        pnlSidebar.SuspendLayout();
        flpMenu.SuspendLayout();
        pnlSubInventario.SuspendLayout();
        pnlSubMovimientos.SuspendLayout();
        pnlSubPrestamos.SuspendLayout();
        pnlSubMantenimiento.SuspendLayout();
        pnlSubAdmin.SuspendLayout();
        pnlSubReportes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogoSidebar).BeginInit();
        pnlContenedor.SuspendLayout();
        pnlInicio.SuspendLayout();
        flpTarjetas.SuspendLayout();
        cardActivosTotales.SuspendLayout();
        cardDisponibles.SuspendLayout();
        cardPrestados.SuspendLayout();
        cardDanados.SuspendLayout();
        cardPerdidos.SuspendLayout();
        cardMantenimiento.SuspendLayout();
        cardPrestamosPendientes.SuspendLayout();
        cardSolicitudesPendientes.SuspendLayout();
        pnlInicioTop.SuspendLayout();
        statusStripPrincipal.SuspendLayout();
        SuspendLayout();
        // 
        // pnlBarraSuperior
        // 
        pnlBarraSuperior.BackColor = Color.FromArgb(239, 239, 239);
        pnlBarraSuperior.Controls.Add(lblTituloSistema);
        pnlBarraSuperior.Controls.Add(btnMenuToggle);
        pnlBarraSuperior.Dock = DockStyle.Top;
        pnlBarraSuperior.Location = new Point(0, 0);
        pnlBarraSuperior.Name = "pnlBarraSuperior";
        pnlBarraSuperior.Size = new Size(1184, 28);
        pnlBarraSuperior.TabIndex = 0;
        // 
        // lblTituloSistema
        // 
        lblTituloSistema.Dock = DockStyle.Fill;
        lblTituloSistema.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblTituloSistema.ForeColor = Color.Black;
        lblTituloSistema.Location = new Point(36, 0);
        lblTituloSistema.Name = "lblTituloSistema";
        lblTituloSistema.Padding = new Padding(6, 0, 0, 0);
        lblTituloSistema.Size = new Size(1148, 28);
        lblTituloSistema.TabIndex = 1;
        lblTituloSistema.Text = "SISTEMA DE GESTION DE INMOBILIARIOS PARA CENTROS EDUCATIVOS";
        lblTituloSistema.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // btnMenuToggle
        // 
        btnMenuToggle.BackColor = Color.FromArgb(239, 239, 239);
        btnMenuToggle.Dock = DockStyle.Left;
        btnMenuToggle.FlatAppearance.BorderSize = 0;
        btnMenuToggle.FlatStyle = FlatStyle.Flat;
        btnMenuToggle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnMenuToggle.ForeColor = Color.Black;
        btnMenuToggle.Location = new Point(0, 0);
        btnMenuToggle.Name = "btnMenuToggle";
        btnMenuToggle.Size = new Size(36, 28);
        btnMenuToggle.TabIndex = 0;
        btnMenuToggle.Text = "≡";
        btnMenuToggle.UseVisualStyleBackColor = false;
        btnMenuToggle.Click += BtnMenuToggle_Click;
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.FromArgb(142, 177, 209);
        pnlSidebar.Controls.Add(flpMenu);
        pnlSidebar.Controls.Add(picLogoSidebar);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 28);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(175, 711);
        pnlSidebar.TabIndex = 1;
        // 
        // flpMenu
        // 
        flpMenu.AutoScroll = true;
        flpMenu.BackColor = Color.FromArgb(142, 177, 209);
        flpMenu.Controls.Add(btnMenuInicio);
        flpMenu.Controls.Add(btnMenuInventario);
        flpMenu.Controls.Add(pnlSubInventario);
        flpMenu.Controls.Add(btnMenuMovimientos);
        flpMenu.Controls.Add(pnlSubMovimientos);
        flpMenu.Controls.Add(btnMenuPrestamos);
        flpMenu.Controls.Add(pnlSubPrestamos);
        flpMenu.Controls.Add(btnMenuMantenimiento);
        flpMenu.Controls.Add(pnlSubMantenimiento);
        flpMenu.Controls.Add(btnMenuAdmin);
        flpMenu.Controls.Add(pnlSubAdmin);
        flpMenu.Controls.Add(btnMenuReportes);
        flpMenu.Controls.Add(pnlSubReportes);
        flpMenu.Controls.Add(btnMenuAcercaDe);
        flpMenu.Controls.Add(btnMenuCerrarSesion);
        flpMenu.Controls.Add(btnMenuSalir);
        flpMenu.Dock = DockStyle.Fill;
        flpMenu.FlowDirection = FlowDirection.TopDown;
        flpMenu.Location = new Point(0, 96);
        flpMenu.Name = "flpMenu";
        flpMenu.Size = new Size(175, 615);
        flpMenu.TabIndex = 1;
        flpMenu.WrapContents = false;
        // 
        // btnMenuInicio
        // 
        btnMenuInicio.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuInicio.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuInicio.FlatAppearance.BorderSize = 1;
        btnMenuInicio.FlatStyle = FlatStyle.Flat;
        btnMenuInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuInicio.ForeColor = Color.Black;
        btnMenuInicio.Location = new Point(0, 0);
        btnMenuInicio.Margin = new Padding(0);
        btnMenuInicio.Name = "btnMenuInicio";
        btnMenuInicio.Padding = new Padding(8, 0, 0, 0);
        btnMenuInicio.Size = new Size(175, 32);
        btnMenuInicio.TabIndex = 0;
        btnMenuInicio.Text = "Inicio";
        btnMenuInicio.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuInicio.UseVisualStyleBackColor = false;
        btnMenuInicio.Click += BtnMenuInicio_Click;
        // 
        // btnMenuInventario
        // 
        btnMenuInventario.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuInventario.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuInventario.FlatAppearance.BorderSize = 1;
        btnMenuInventario.FlatStyle = FlatStyle.Flat;
        btnMenuInventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuInventario.ForeColor = Color.Black;
        btnMenuInventario.Location = new Point(0, 32);
        btnMenuInventario.Margin = new Padding(0);
        btnMenuInventario.Name = "btnMenuInventario";
        btnMenuInventario.Padding = new Padding(8, 0, 0, 0);
        btnMenuInventario.Size = new Size(175, 32);
        btnMenuInventario.TabIndex = 1;
        btnMenuInventario.Text = "Inventario ▾";
        btnMenuInventario.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuInventario.UseVisualStyleBackColor = false;
        btnMenuInventario.Click += BtnMenuInventario_Click;
        // 
        // pnlSubInventario
        // 
        pnlSubInventario.BackColor = Color.FromArgb(169, 197, 222);
        pnlSubInventario.Controls.Add(btnSubUbicaciones);
        pnlSubInventario.Controls.Add(btnSubEdificios);
        pnlSubInventario.Controls.Add(btnSubProveedores);
        pnlSubInventario.Controls.Add(btnSubMarcas);
        pnlSubInventario.Controls.Add(btnSubSubCategorias);
        pnlSubInventario.Controls.Add(btnSubCategorias);
        pnlSubInventario.Controls.Add(btnSubActivos);
        pnlSubInventario.Location = new Point(0, 64);
        pnlSubInventario.Margin = new Padding(0);
        pnlSubInventario.Name = "pnlSubInventario";
        pnlSubInventario.Size = new Size(175, 182);
        pnlSubInventario.TabIndex = 2;
        pnlSubInventario.Visible = false;
        // 
        // btnSubActivos
        // 
        btnSubActivos.Dock = DockStyle.Top;
        btnSubActivos.FlatAppearance.BorderSize = 0;
        btnSubActivos.FlatStyle = FlatStyle.Flat;
        btnSubActivos.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubActivos.ForeColor = Color.Black;
        btnSubActivos.Location = new Point(0, 0);
        btnSubActivos.Name = "btnSubActivos";
        btnSubActivos.Padding = new Padding(18, 0, 0, 0);
        btnSubActivos.Size = new Size(175, 26);
        btnSubActivos.TabIndex = 0;
        btnSubActivos.Text = "Catálogo de Activos";
        btnSubActivos.TextAlign = ContentAlignment.MiddleLeft;
        btnSubActivos.UseVisualStyleBackColor = true;
        btnSubActivos.Click += ItemCatalogoActivos_Click;
        // 
        // btnSubCategorias
        // 
        btnSubCategorias.Dock = DockStyle.Top;
        btnSubCategorias.FlatAppearance.BorderSize = 0;
        btnSubCategorias.FlatStyle = FlatStyle.Flat;
        btnSubCategorias.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubCategorias.ForeColor = Color.Black;
        btnSubCategorias.Location = new Point(0, 26);
        btnSubCategorias.Name = "btnSubCategorias";
        btnSubCategorias.Padding = new Padding(18, 0, 0, 0);
        btnSubCategorias.Size = new Size(175, 26);
        btnSubCategorias.TabIndex = 1;
        btnSubCategorias.Text = "Categorías";
        btnSubCategorias.TextAlign = ContentAlignment.MiddleLeft;
        btnSubCategorias.UseVisualStyleBackColor = true;
        btnSubCategorias.Click += ItemCategorias_Click;
        // 
        // btnSubSubCategorias
        // 
        btnSubSubCategorias.Dock = DockStyle.Top;
        btnSubSubCategorias.FlatAppearance.BorderSize = 0;
        btnSubSubCategorias.FlatStyle = FlatStyle.Flat;
        btnSubSubCategorias.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubSubCategorias.ForeColor = Color.Black;
        btnSubSubCategorias.Location = new Point(0, 52);
        btnSubSubCategorias.Name = "btnSubSubCategorias";
        btnSubSubCategorias.Padding = new Padding(18, 0, 0, 0);
        btnSubSubCategorias.Size = new Size(175, 26);
        btnSubSubCategorias.TabIndex = 2;
        btnSubSubCategorias.Text = "Subcategorías";
        btnSubSubCategorias.TextAlign = ContentAlignment.MiddleLeft;
        btnSubSubCategorias.UseVisualStyleBackColor = true;
        btnSubSubCategorias.Click += ItemSubCategorias_Click;
        // 
        // btnSubMarcas
        // 
        btnSubMarcas.Dock = DockStyle.Top;
        btnSubMarcas.FlatAppearance.BorderSize = 0;
        btnSubMarcas.FlatStyle = FlatStyle.Flat;
        btnSubMarcas.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubMarcas.ForeColor = Color.Black;
        btnSubMarcas.Location = new Point(0, 78);
        btnSubMarcas.Name = "btnSubMarcas";
        btnSubMarcas.Padding = new Padding(18, 0, 0, 0);
        btnSubMarcas.Size = new Size(175, 26);
        btnSubMarcas.TabIndex = 3;
        btnSubMarcas.Text = "Marcas";
        btnSubMarcas.TextAlign = ContentAlignment.MiddleLeft;
        btnSubMarcas.UseVisualStyleBackColor = true;
        btnSubMarcas.Click += ItemMarcas_Click;
        // 
        // btnSubProveedores
        // 
        btnSubProveedores.Dock = DockStyle.Top;
        btnSubProveedores.FlatAppearance.BorderSize = 0;
        btnSubProveedores.FlatStyle = FlatStyle.Flat;
        btnSubProveedores.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubProveedores.ForeColor = Color.Black;
        btnSubProveedores.Location = new Point(0, 104);
        btnSubProveedores.Name = "btnSubProveedores";
        btnSubProveedores.Padding = new Padding(18, 0, 0, 0);
        btnSubProveedores.Size = new Size(175, 26);
        btnSubProveedores.TabIndex = 4;
        btnSubProveedores.Text = "Proveedores";
        btnSubProveedores.TextAlign = ContentAlignment.MiddleLeft;
        btnSubProveedores.UseVisualStyleBackColor = true;
        btnSubProveedores.Click += ItemProveedores_Click;
        // 
        // btnSubEdificios
        // 
        btnSubEdificios.Dock = DockStyle.Top;
        btnSubEdificios.FlatAppearance.BorderSize = 0;
        btnSubEdificios.FlatStyle = FlatStyle.Flat;
        btnSubEdificios.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubEdificios.ForeColor = Color.Black;
        btnSubEdificios.Location = new Point(0, 130);
        btnSubEdificios.Name = "btnSubEdificios";
        btnSubEdificios.Padding = new Padding(18, 0, 0, 0);
        btnSubEdificios.Size = new Size(175, 26);
        btnSubEdificios.TabIndex = 5;
        btnSubEdificios.Text = "Edificios";
        btnSubEdificios.TextAlign = ContentAlignment.MiddleLeft;
        btnSubEdificios.UseVisualStyleBackColor = true;
        btnSubEdificios.Click += ItemEdificios_Click;
        // 
        // btnSubUbicaciones
        // 
        btnSubUbicaciones.Dock = DockStyle.Top;
        btnSubUbicaciones.FlatAppearance.BorderSize = 0;
        btnSubUbicaciones.FlatStyle = FlatStyle.Flat;
        btnSubUbicaciones.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubUbicaciones.ForeColor = Color.Black;
        btnSubUbicaciones.Location = new Point(0, 156);
        btnSubUbicaciones.Name = "btnSubUbicaciones";
        btnSubUbicaciones.Padding = new Padding(18, 0, 0, 0);
        btnSubUbicaciones.Size = new Size(175, 26);
        btnSubUbicaciones.TabIndex = 6;
        btnSubUbicaciones.Text = "Ubicaciones";
        btnSubUbicaciones.TextAlign = ContentAlignment.MiddleLeft;
        btnSubUbicaciones.UseVisualStyleBackColor = true;
        btnSubUbicaciones.Click += ItemUbicaciones_Click;
        // 
        // btnMenuMovimientos
        // 
        btnMenuMovimientos.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuMovimientos.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuMovimientos.FlatAppearance.BorderSize = 1;
        btnMenuMovimientos.FlatStyle = FlatStyle.Flat;
        btnMenuMovimientos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuMovimientos.ForeColor = Color.Black;
        btnMenuMovimientos.Location = new Point(0, 246);
        btnMenuMovimientos.Margin = new Padding(0);
        btnMenuMovimientos.Name = "btnMenuMovimientos";
        btnMenuMovimientos.Padding = new Padding(8, 0, 0, 0);
        btnMenuMovimientos.Size = new Size(175, 32);
        btnMenuMovimientos.TabIndex = 3;
        btnMenuMovimientos.Text = "Movimientos ▾";
        btnMenuMovimientos.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuMovimientos.UseVisualStyleBackColor = false;
        btnMenuMovimientos.Click += BtnMenuMovimientos_Click;
        // 
        // pnlSubMovimientos
        // 
        pnlSubMovimientos.BackColor = Color.FromArgb(169, 197, 222);
        pnlSubMovimientos.Controls.Add(btnSubSalidasBajas);
        pnlSubMovimientos.Controls.Add(btnSubTraslados);
        pnlSubMovimientos.Controls.Add(btnSubActivosFisicos);
        pnlSubMovimientos.Controls.Add(btnSubEntradas);
        pnlSubMovimientos.Location = new Point(0, 278);
        pnlSubMovimientos.Margin = new Padding(0);
        pnlSubMovimientos.Name = "pnlSubMovimientos";
        pnlSubMovimientos.Size = new Size(175, 104);
        pnlSubMovimientos.TabIndex = 4;
        pnlSubMovimientos.Visible = false;
        // 
        // btnSubEntradas
        // 
        btnSubEntradas.Dock = DockStyle.Top;
        btnSubEntradas.FlatAppearance.BorderSize = 0;
        btnSubEntradas.FlatStyle = FlatStyle.Flat;
        btnSubEntradas.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubEntradas.ForeColor = Color.Black;
        btnSubEntradas.Location = new Point(0, 0);
        btnSubEntradas.Name = "btnSubEntradas";
        btnSubEntradas.Padding = new Padding(18, 0, 0, 0);
        btnSubEntradas.Size = new Size(175, 26);
        btnSubEntradas.TabIndex = 0;
        btnSubEntradas.Text = "Entrada de Activos";
        btnSubEntradas.TextAlign = ContentAlignment.MiddleLeft;
        btnSubEntradas.UseVisualStyleBackColor = true;
        btnSubEntradas.Click += ItemEntradaActivos_Click;
        // 
        // btnSubActivosFisicos
        // 
        btnSubActivosFisicos.Dock = DockStyle.Top;
        btnSubActivosFisicos.FlatAppearance.BorderSize = 0;
        btnSubActivosFisicos.FlatStyle = FlatStyle.Flat;
        btnSubActivosFisicos.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubActivosFisicos.ForeColor = Color.Black;
        btnSubActivosFisicos.Location = new Point(0, 26);
        btnSubActivosFisicos.Name = "btnSubActivosFisicos";
        btnSubActivosFisicos.Padding = new Padding(18, 0, 0, 0);
        btnSubActivosFisicos.Size = new Size(175, 26);
        btnSubActivosFisicos.TabIndex = 1;
        btnSubActivosFisicos.Text = "Activos Físicos y QR";
        btnSubActivosFisicos.TextAlign = ContentAlignment.MiddleLeft;
        btnSubActivosFisicos.UseVisualStyleBackColor = true;
        btnSubActivosFisicos.Click += ItemActivosFisicos_Click;
        // 
        // btnSubTraslados
        // 
        btnSubTraslados.Dock = DockStyle.Top;
        btnSubTraslados.FlatAppearance.BorderSize = 0;
        btnSubTraslados.FlatStyle = FlatStyle.Flat;
        btnSubTraslados.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubTraslados.ForeColor = Color.Black;
        btnSubTraslados.Location = new Point(0, 52);
        btnSubTraslados.Name = "btnSubTraslados";
        btnSubTraslados.Padding = new Padding(18, 0, 0, 0);
        btnSubTraslados.Size = new Size(175, 26);
        btnSubTraslados.TabIndex = 2;
        btnSubTraslados.Text = "Traslados";
        btnSubTraslados.TextAlign = ContentAlignment.MiddleLeft;
        btnSubTraslados.UseVisualStyleBackColor = true;
        btnSubTraslados.Click += ItemTraslados_Click;
        // 
        // btnSubSalidasBajas
        // 
        btnSubSalidasBajas.Dock = DockStyle.Top;
        btnSubSalidasBajas.FlatAppearance.BorderSize = 0;
        btnSubSalidasBajas.FlatStyle = FlatStyle.Flat;
        btnSubSalidasBajas.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubSalidasBajas.ForeColor = Color.Black;
        btnSubSalidasBajas.Location = new Point(0, 78);
        btnSubSalidasBajas.Name = "btnSubSalidasBajas";
        btnSubSalidasBajas.Padding = new Padding(18, 0, 0, 0);
        btnSubSalidasBajas.Size = new Size(175, 26);
        btnSubSalidasBajas.TabIndex = 3;
        btnSubSalidasBajas.Text = "Salidas y Bajas";
        btnSubSalidasBajas.TextAlign = ContentAlignment.MiddleLeft;
        btnSubSalidasBajas.UseVisualStyleBackColor = true;
        btnSubSalidasBajas.Click += ItemSalidasBajas_Click;
        // 
        // btnMenuPrestamos
        // 
        btnMenuPrestamos.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuPrestamos.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuPrestamos.FlatAppearance.BorderSize = 1;
        btnMenuPrestamos.FlatStyle = FlatStyle.Flat;
        btnMenuPrestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuPrestamos.ForeColor = Color.Black;
        btnMenuPrestamos.Location = new Point(0, 382);
        btnMenuPrestamos.Margin = new Padding(0);
        btnMenuPrestamos.Name = "btnMenuPrestamos";
        btnMenuPrestamos.Padding = new Padding(8, 0, 0, 0);
        btnMenuPrestamos.Size = new Size(175, 32);
        btnMenuPrestamos.TabIndex = 5;
        btnMenuPrestamos.Text = "Préstamos ▾";
        btnMenuPrestamos.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuPrestamos.UseVisualStyleBackColor = false;
        btnMenuPrestamos.Click += BtnMenuPrestamos_Click;
        // 
        // pnlSubPrestamos
        // 
        pnlSubPrestamos.BackColor = Color.FromArgb(169, 197, 222);
        pnlSubPrestamos.Controls.Add(btnSubDevoluciones);
        pnlSubPrestamos.Controls.Add(btnSubPrestamos);
        pnlSubPrestamos.Location = new Point(0, 414);
        pnlSubPrestamos.Margin = new Padding(0);
        pnlSubPrestamos.Name = "pnlSubPrestamos";
        pnlSubPrestamos.Size = new Size(175, 52);
        pnlSubPrestamos.TabIndex = 6;
        pnlSubPrestamos.Visible = false;
        // 
        // btnSubPrestamos
        // 
        btnSubPrestamos.Dock = DockStyle.Top;
        btnSubPrestamos.FlatAppearance.BorderSize = 0;
        btnSubPrestamos.FlatStyle = FlatStyle.Flat;
        btnSubPrestamos.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubPrestamos.ForeColor = Color.Black;
        btnSubPrestamos.Location = new Point(0, 0);
        btnSubPrestamos.Name = "btnSubPrestamos";
        btnSubPrestamos.Padding = new Padding(18, 0, 0, 0);
        btnSubPrestamos.Size = new Size(175, 26);
        btnSubPrestamos.TabIndex = 0;
        btnSubPrestamos.Text = "Préstamos de Activos";
        btnSubPrestamos.TextAlign = ContentAlignment.MiddleLeft;
        btnSubPrestamos.UseVisualStyleBackColor = true;
        btnSubPrestamos.Click += ItemPrestamos_Click;
        // 
        // btnSubDevoluciones
        // 
        btnSubDevoluciones.Dock = DockStyle.Top;
        btnSubDevoluciones.FlatAppearance.BorderSize = 0;
        btnSubDevoluciones.FlatStyle = FlatStyle.Flat;
        btnSubDevoluciones.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubDevoluciones.ForeColor = Color.Black;
        btnSubDevoluciones.Location = new Point(0, 26);
        btnSubDevoluciones.Name = "btnSubDevoluciones";
        btnSubDevoluciones.Padding = new Padding(18, 0, 0, 0);
        btnSubDevoluciones.Size = new Size(175, 26);
        btnSubDevoluciones.TabIndex = 1;
        btnSubDevoluciones.Text = "Devoluciones";
        btnSubDevoluciones.TextAlign = ContentAlignment.MiddleLeft;
        btnSubDevoluciones.UseVisualStyleBackColor = true;
        btnSubDevoluciones.Click += ItemDevoluciones_Click;
        // 
        // btnMenuMantenimiento
        // 
        btnMenuMantenimiento.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuMantenimiento.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuMantenimiento.FlatAppearance.BorderSize = 1;
        btnMenuMantenimiento.FlatStyle = FlatStyle.Flat;
        btnMenuMantenimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuMantenimiento.ForeColor = Color.Black;
        btnMenuMantenimiento.Location = new Point(0, 466);
        btnMenuMantenimiento.Margin = new Padding(0);
        btnMenuMantenimiento.Name = "btnMenuMantenimiento";
        btnMenuMantenimiento.Padding = new Padding(8, 0, 0, 0);
        btnMenuMantenimiento.Size = new Size(175, 32);
        btnMenuMantenimiento.TabIndex = 7;
        btnMenuMantenimiento.Text = "Mantenimiento ▾";
        btnMenuMantenimiento.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuMantenimiento.UseVisualStyleBackColor = false;
        btnMenuMantenimiento.Click += BtnMenuMantenimiento_Click;
        // 
        // pnlSubMantenimiento
        // 
        pnlSubMantenimiento.BackColor = Color.FromArgb(169, 197, 222);
        pnlSubMantenimiento.Controls.Add(btnSubOrdenesMant);
        pnlSubMantenimiento.Controls.Add(btnSubSolicitudesMant);
        pnlSubMantenimiento.Location = new Point(0, 498);
        pnlSubMantenimiento.Margin = new Padding(0);
        pnlSubMantenimiento.Name = "pnlSubMantenimiento";
        pnlSubMantenimiento.Size = new Size(175, 52);
        pnlSubMantenimiento.TabIndex = 8;
        pnlSubMantenimiento.Visible = false;
        // 
        // btnSubSolicitudesMant
        // 
        btnSubSolicitudesMant.Dock = DockStyle.Top;
        btnSubSolicitudesMant.FlatAppearance.BorderSize = 0;
        btnSubSolicitudesMant.FlatStyle = FlatStyle.Flat;
        btnSubSolicitudesMant.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubSolicitudesMant.ForeColor = Color.Black;
        btnSubSolicitudesMant.Location = new Point(0, 0);
        btnSubSolicitudesMant.Name = "btnSubSolicitudesMant";
        btnSubSolicitudesMant.Padding = new Padding(18, 0, 0, 0);
        btnSubSolicitudesMant.Size = new Size(175, 26);
        btnSubSolicitudesMant.TabIndex = 0;
        btnSubSolicitudesMant.Text = "Solicitudes Mantenim.";
        btnSubSolicitudesMant.TextAlign = ContentAlignment.MiddleLeft;
        btnSubSolicitudesMant.UseVisualStyleBackColor = true;
        btnSubSolicitudesMant.Click += ItemSolicitudesMantenimiento_Click;
        // 
        // btnSubOrdenesMant
        // 
        btnSubOrdenesMant.Dock = DockStyle.Top;
        btnSubOrdenesMant.FlatAppearance.BorderSize = 0;
        btnSubOrdenesMant.FlatStyle = FlatStyle.Flat;
        btnSubOrdenesMant.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubOrdenesMant.ForeColor = Color.Black;
        btnSubOrdenesMant.Location = new Point(0, 26);
        btnSubOrdenesMant.Name = "btnSubOrdenesMant";
        btnSubOrdenesMant.Padding = new Padding(18, 0, 0, 0);
        btnSubOrdenesMant.Size = new Size(175, 26);
        btnSubOrdenesMant.TabIndex = 1;
        btnSubOrdenesMant.Text = "Órdenes Mantenim.";
        btnSubOrdenesMant.TextAlign = ContentAlignment.MiddleLeft;
        btnSubOrdenesMant.UseVisualStyleBackColor = true;
        btnSubOrdenesMant.Click += ItemMantenimientos_Click;
        // 
        // btnMenuAdmin
        // 
        btnMenuAdmin.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuAdmin.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuAdmin.FlatAppearance.BorderSize = 1;
        btnMenuAdmin.FlatStyle = FlatStyle.Flat;
        btnMenuAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuAdmin.ForeColor = Color.Black;
        btnMenuAdmin.Location = new Point(0, 550);
        btnMenuAdmin.Margin = new Padding(0);
        btnMenuAdmin.Name = "btnMenuAdmin";
        btnMenuAdmin.Padding = new Padding(8, 0, 0, 0);
        btnMenuAdmin.Size = new Size(175, 32);
        btnMenuAdmin.TabIndex = 9;
        btnMenuAdmin.Text = "Admin. ▾";
        btnMenuAdmin.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuAdmin.UseVisualStyleBackColor = false;
        btnMenuAdmin.Click += BtnMenuAdmin_Click;
        // 
        // pnlSubAdmin
        // 
        pnlSubAdmin.BackColor = Color.FromArgb(169, 197, 222);
        pnlSubAdmin.Controls.Add(btnSubUsuarios);
        pnlSubAdmin.Controls.Add(btnSubPersonal);
        pnlSubAdmin.Controls.Add(btnSubCentros);
        pnlSubAdmin.Location = new Point(0, 582);
        pnlSubAdmin.Margin = new Padding(0);
        pnlSubAdmin.Name = "pnlSubAdmin";
        pnlSubAdmin.Size = new Size(175, 78);
        pnlSubAdmin.TabIndex = 10;
        pnlSubAdmin.Visible = false;
        // 
        // btnSubCentros
        // 
        btnSubCentros.Dock = DockStyle.Top;
        btnSubCentros.FlatAppearance.BorderSize = 0;
        btnSubCentros.FlatStyle = FlatStyle.Flat;
        btnSubCentros.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubCentros.ForeColor = Color.Black;
        btnSubCentros.Location = new Point(0, 0);
        btnSubCentros.Name = "btnSubCentros";
        btnSubCentros.Padding = new Padding(18, 0, 0, 0);
        btnSubCentros.Size = new Size(175, 26);
        btnSubCentros.TabIndex = 0;
        btnSubCentros.Text = "Centros Educativos";
        btnSubCentros.TextAlign = ContentAlignment.MiddleLeft;
        btnSubCentros.UseVisualStyleBackColor = true;
        btnSubCentros.Click += ItemCentrosEducativos_Click;
        // 
        // btnSubPersonal
        // 
        btnSubPersonal.Dock = DockStyle.Top;
        btnSubPersonal.FlatAppearance.BorderSize = 0;
        btnSubPersonal.FlatStyle = FlatStyle.Flat;
        btnSubPersonal.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubPersonal.ForeColor = Color.Black;
        btnSubPersonal.Location = new Point(0, 26);
        btnSubPersonal.Name = "btnSubPersonal";
        btnSubPersonal.Padding = new Padding(18, 0, 0, 0);
        btnSubPersonal.Size = new Size(175, 26);
        btnSubPersonal.TabIndex = 1;
        btnSubPersonal.Text = "Personal Escolar";
        btnSubPersonal.TextAlign = ContentAlignment.MiddleLeft;
        btnSubPersonal.UseVisualStyleBackColor = true;
        btnSubPersonal.Click += ItemPersonal_Click;
        // 
        // btnSubUsuarios
        // 
        btnSubUsuarios.Dock = DockStyle.Top;
        btnSubUsuarios.FlatAppearance.BorderSize = 0;
        btnSubUsuarios.FlatStyle = FlatStyle.Flat;
        btnSubUsuarios.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubUsuarios.ForeColor = Color.Black;
        btnSubUsuarios.Location = new Point(0, 52);
        btnSubUsuarios.Name = "btnSubUsuarios";
        btnSubUsuarios.Padding = new Padding(18, 0, 0, 0);
        btnSubUsuarios.Size = new Size(175, 26);
        btnSubUsuarios.TabIndex = 2;
        btnSubUsuarios.Text = "Usuarios y Roles";
        btnSubUsuarios.TextAlign = ContentAlignment.MiddleLeft;
        btnSubUsuarios.UseVisualStyleBackColor = true;
        btnSubUsuarios.Click += ItemUsuarios_Click;
        // 
        // btnMenuReportes
        // 
        btnMenuReportes.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuReportes.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuReportes.FlatAppearance.BorderSize = 1;
        btnMenuReportes.FlatStyle = FlatStyle.Flat;
        btnMenuReportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuReportes.ForeColor = Color.Black;
        btnMenuReportes.Location = new Point(0, 660);
        btnMenuReportes.Margin = new Padding(0);
        btnMenuReportes.Name = "btnMenuReportes";
        btnMenuReportes.Padding = new Padding(8, 0, 0, 0);
        btnMenuReportes.Size = new Size(175, 32);
        btnMenuReportes.TabIndex = 11;
        btnMenuReportes.Text = "Reportes ▾";
        btnMenuReportes.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuReportes.UseVisualStyleBackColor = false;
        btnMenuReportes.Click += BtnMenuReportes_Click;
        // 
        // pnlSubReportes
        // 
        pnlSubReportes.BackColor = Color.FromArgb(169, 197, 222);
        pnlSubReportes.Controls.Add(btnSubRepAuditoria);
        pnlSubReportes.Controls.Add(btnSubRepInventario);
        pnlSubReportes.Controls.Add(btnSubRepGeneral);
        pnlSubReportes.Location = new Point(0, 692);
        pnlSubReportes.Margin = new Padding(0);
        pnlSubReportes.Name = "pnlSubReportes";
        pnlSubReportes.Size = new Size(175, 78);
        pnlSubReportes.TabIndex = 12;
        pnlSubReportes.Visible = false;
        // 
        // btnSubRepGeneral
        // 
        btnSubRepGeneral.Dock = DockStyle.Top;
        btnSubRepGeneral.FlatAppearance.BorderSize = 0;
        btnSubRepGeneral.FlatStyle = FlatStyle.Flat;
        btnSubRepGeneral.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubRepGeneral.ForeColor = Color.Black;
        btnSubRepGeneral.Location = new Point(0, 0);
        btnSubRepGeneral.Name = "btnSubRepGeneral";
        btnSubRepGeneral.Padding = new Padding(18, 0, 0, 0);
        btnSubRepGeneral.Size = new Size(175, 26);
        btnSubRepGeneral.TabIndex = 0;
        btnSubRepGeneral.Text = "Módulo de Reportes";
        btnSubRepGeneral.TextAlign = ContentAlignment.MiddleLeft;
        btnSubRepGeneral.UseVisualStyleBackColor = true;
        btnSubRepGeneral.Click += ItemAbrirReportes_Click;
        // 
        // btnSubRepInventario
        // 
        btnSubRepInventario.Dock = DockStyle.Top;
        btnSubRepInventario.FlatAppearance.BorderSize = 0;
        btnSubRepInventario.FlatStyle = FlatStyle.Flat;
        btnSubRepInventario.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubRepInventario.ForeColor = Color.Black;
        btnSubRepInventario.Location = new Point(0, 26);
        btnSubRepInventario.Name = "btnSubRepInventario";
        btnSubRepInventario.Padding = new Padding(18, 0, 0, 0);
        btnSubRepInventario.Size = new Size(175, 26);
        btnSubRepInventario.TabIndex = 1;
        btnSubRepInventario.Text = "Inventario General";
        btnSubRepInventario.TextAlign = ContentAlignment.MiddleLeft;
        btnSubRepInventario.UseVisualStyleBackColor = true;
        btnSubRepInventario.Click += ItemRepInventarioGeneral_Click;
        // 
        // btnSubRepAuditoria
        // 
        btnSubRepAuditoria.Dock = DockStyle.Top;
        btnSubRepAuditoria.FlatAppearance.BorderSize = 0;
        btnSubRepAuditoria.FlatStyle = FlatStyle.Flat;
        btnSubRepAuditoria.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular);
        btnSubRepAuditoria.ForeColor = Color.Black;
        btnSubRepAuditoria.Location = new Point(0, 52);
        btnSubRepAuditoria.Name = "btnSubRepAuditoria";
        btnSubRepAuditoria.Padding = new Padding(18, 0, 0, 0);
        btnSubRepAuditoria.Size = new Size(175, 26);
        btnSubRepAuditoria.TabIndex = 2;
        btnSubRepAuditoria.Text = "Bitácora Auditoría";
        btnSubRepAuditoria.TextAlign = ContentAlignment.MiddleLeft;
        btnSubRepAuditoria.UseVisualStyleBackColor = true;
        btnSubRepAuditoria.Click += ItemRepAuditoria_Click;
        // 
        // btnMenuAcercaDe
        // 
        btnMenuAcercaDe.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuAcercaDe.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuAcercaDe.FlatAppearance.BorderSize = 1;
        btnMenuAcercaDe.FlatStyle = FlatStyle.Flat;
        btnMenuAcercaDe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuAcercaDe.ForeColor = Color.Black;
        btnMenuAcercaDe.Location = new Point(0, 770);
        btnMenuAcercaDe.Margin = new Padding(0);
        btnMenuAcercaDe.Name = "btnMenuAcercaDe";
        btnMenuAcercaDe.Padding = new Padding(8, 0, 0, 0);
        btnMenuAcercaDe.Size = new Size(175, 32);
        btnMenuAcercaDe.TabIndex = 13;
        btnMenuAcercaDe.Text = "Acerca de";
        btnMenuAcercaDe.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuAcercaDe.UseVisualStyleBackColor = false;
        btnMenuAcercaDe.Click += ItemAcercaDe_Click;
        // 
        // btnMenuCerrarSesion
        // 
        btnMenuCerrarSesion.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuCerrarSesion.FlatAppearance.BorderSize = 1;
        btnMenuCerrarSesion.FlatStyle = FlatStyle.Flat;
        btnMenuCerrarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuCerrarSesion.ForeColor = Color.Black;
        btnMenuCerrarSesion.Location = new Point(0, 802);
        btnMenuCerrarSesion.Margin = new Padding(0);
        btnMenuCerrarSesion.Name = "btnMenuCerrarSesion";
        btnMenuCerrarSesion.Padding = new Padding(8, 0, 0, 0);
        btnMenuCerrarSesion.Size = new Size(175, 32);
        btnMenuCerrarSesion.TabIndex = 14;
        btnMenuCerrarSesion.Text = "Cerrar Sesión";
        btnMenuCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuCerrarSesion.UseVisualStyleBackColor = false;
        btnMenuCerrarSesion.Click += ItemCerrarSesion_Click;
        // 
        // btnMenuSalir
        // 
        btnMenuSalir.BackColor = Color.FromArgb(142, 177, 209);
        btnMenuSalir.FlatAppearance.BorderColor = Color.FromArgb(120, 155, 190);
        btnMenuSalir.FlatAppearance.BorderSize = 1;
        btnMenuSalir.FlatStyle = FlatStyle.Flat;
        btnMenuSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMenuSalir.ForeColor = Color.Black;
        btnMenuSalir.Location = new Point(0, 834);
        btnMenuSalir.Margin = new Padding(0);
        btnMenuSalir.Name = "btnMenuSalir";
        btnMenuSalir.Padding = new Padding(8, 0, 0, 0);
        btnMenuSalir.Size = new Size(175, 32);
        btnMenuSalir.TabIndex = 15;
        btnMenuSalir.Text = "Salir";
        btnMenuSalir.TextAlign = ContentAlignment.MiddleLeft;
        btnMenuSalir.UseVisualStyleBackColor = false;
        btnMenuSalir.Click += ItemSalir_Click;
        // 
        // picLogoSidebar
        // 
        picLogoSidebar.BackColor = Color.White;
        picLogoSidebar.Dock = DockStyle.Top;
        picLogoSidebar.Image = Properties.Resources.WhatsApp_Image_2026_11_25_at_10_22_28;
        picLogoSidebar.Location = new Point(0, 0);
        picLogoSidebar.Name = "picLogoSidebar";
        picLogoSidebar.Padding = new Padding(6);
        picLogoSidebar.Size = new Size(175, 96);
        picLogoSidebar.SizeMode = PictureBoxSizeMode.Zoom;
        picLogoSidebar.TabIndex = 0;
        picLogoSidebar.TabStop = false;
        // 
        // pnlContenedor
        // 
        pnlContenedor.BackColor = SystemColors.Control;
        pnlContenedor.Controls.Add(pnlInicio);
        pnlContenedor.Dock = DockStyle.Fill;
        pnlContenedor.Location = new Point(175, 28);
        pnlContenedor.Name = "pnlContenedor";
        pnlContenedor.Size = new Size(1009, 711);
        pnlContenedor.TabIndex = 2;
        // 
        // pnlInicio
        // 
        pnlInicio.BackColor = SystemColors.Control;
        pnlInicio.Controls.Add(flpTarjetas);
        pnlInicio.Controls.Add(pnlInicioTop);
        pnlInicio.Dock = DockStyle.Fill;
        pnlInicio.Location = new Point(0, 0);
        pnlInicio.Name = "pnlInicio";
        pnlInicio.Size = new Size(1009, 711);
        pnlInicio.TabIndex = 0;
        // 
        // flpTarjetas
        // 
        flpTarjetas.AutoScroll = true;
        flpTarjetas.BackColor = SystemColors.Control;
        flpTarjetas.Controls.Add(cardActivosTotales);
        flpTarjetas.Controls.Add(cardDisponibles);
        flpTarjetas.Controls.Add(cardPrestados);
        flpTarjetas.Controls.Add(cardDanados);
        flpTarjetas.Controls.Add(cardPerdidos);
        flpTarjetas.Controls.Add(cardMantenimiento);
        flpTarjetas.Controls.Add(cardPrestamosPendientes);
        flpTarjetas.Controls.Add(cardSolicitudesPendientes);
        flpTarjetas.Dock = DockStyle.Fill;
        flpTarjetas.Location = new Point(0, 32);
        flpTarjetas.Name = "flpTarjetas";
        flpTarjetas.Padding = new Padding(16);
        flpTarjetas.Size = new Size(1009, 679);
        flpTarjetas.TabIndex = 1;
        // 
        // cardActivosTotales
        // 
        cardActivosTotales.BackColor = Color.White;
        cardActivosTotales.BorderStyle = BorderStyle.FixedSingle;
        cardActivosTotales.Controls.Add(lblValActivosTotales);
        cardActivosTotales.Controls.Add(lblTitActivosTotales);
        cardActivosTotales.Controls.Add(pnlAccentTotales);
        cardActivosTotales.Location = new Point(26, 26);
        cardActivosTotales.Margin = new Padding(10);
        cardActivosTotales.Name = "cardActivosTotales";
        cardActivosTotales.Size = new Size(215, 110);
        cardActivosTotales.TabIndex = 0;
        // 
        // pnlAccentTotales
        // 
        pnlAccentTotales.BackColor = Color.FromArgb(142, 177, 209);
        pnlAccentTotales.Dock = DockStyle.Top;
        pnlAccentTotales.Location = new Point(0, 0);
        pnlAccentTotales.Name = "pnlAccentTotales";
        pnlAccentTotales.Size = new Size(213, 6);
        pnlAccentTotales.TabIndex = 0;
        // 
        // lblValActivosTotales
        // 
        lblValActivosTotales.Dock = DockStyle.Fill;
        lblValActivosTotales.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblValActivosTotales.ForeColor = Color.Black;
        lblValActivosTotales.Location = new Point(0, 34);
        lblValActivosTotales.Name = "lblValActivosTotales";
        lblValActivosTotales.Size = new Size(213, 74);
        lblValActivosTotales.TabIndex = 2;
        lblValActivosTotales.Text = "0";
        lblValActivosTotales.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTitActivosTotales
        // 
        lblTitActivosTotales.Dock = DockStyle.Top;
        lblTitActivosTotales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTitActivosTotales.ForeColor = Color.Black;
        lblTitActivosTotales.Location = new Point(0, 6);
        lblTitActivosTotales.Name = "lblTitActivosTotales";
        lblTitActivosTotales.Size = new Size(213, 28);
        lblTitActivosTotales.TabIndex = 1;
        lblTitActivosTotales.Text = "Activos Totales";
        lblTitActivosTotales.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cardDisponibles
        // 
        cardDisponibles.BackColor = Color.White;
        cardDisponibles.BorderStyle = BorderStyle.FixedSingle;
        cardDisponibles.Controls.Add(lblValDisponibles);
        cardDisponibles.Controls.Add(lblTitDisponibles);
        cardDisponibles.Controls.Add(pnlAccentDisponibles);
        cardDisponibles.Location = new Point(261, 26);
        cardDisponibles.Margin = new Padding(10);
        cardDisponibles.Name = "cardDisponibles";
        cardDisponibles.Size = new Size(215, 110);
        cardDisponibles.TabIndex = 1;
        // 
        // pnlAccentDisponibles
        // 
        pnlAccentDisponibles.BackColor = Color.FromArgb(129, 199, 132);
        pnlAccentDisponibles.Dock = DockStyle.Top;
        pnlAccentDisponibles.Location = new Point(0, 0);
        pnlAccentDisponibles.Name = "pnlAccentDisponibles";
        pnlAccentDisponibles.Size = new Size(213, 6);
        pnlAccentDisponibles.TabIndex = 0;
        // 
        // lblValDisponibles
        // 
        lblValDisponibles.Dock = DockStyle.Fill;
        lblValDisponibles.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblValDisponibles.ForeColor = Color.Black;
        lblValDisponibles.Location = new Point(0, 34);
        lblValDisponibles.Name = "lblValDisponibles";
        lblValDisponibles.Size = new Size(213, 74);
        lblValDisponibles.TabIndex = 2;
        lblValDisponibles.Text = "0";
        lblValDisponibles.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTitDisponibles
        // 
        lblTitDisponibles.Dock = DockStyle.Top;
        lblTitDisponibles.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTitDisponibles.ForeColor = Color.Black;
        lblTitDisponibles.Location = new Point(0, 6);
        lblTitDisponibles.Name = "lblTitDisponibles";
        lblTitDisponibles.Size = new Size(213, 28);
        lblTitDisponibles.TabIndex = 1;
        lblTitDisponibles.Text = "Disponibles";
        lblTitDisponibles.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cardPrestados
        // 
        cardPrestados.BackColor = Color.White;
        cardPrestados.BorderStyle = BorderStyle.FixedSingle;
        cardPrestados.Controls.Add(lblValPrestados);
        cardPrestados.Controls.Add(lblTitPrestados);
        cardPrestados.Controls.Add(pnlAccentPrestados);
        cardPrestados.Location = new Point(496, 26);
        cardPrestados.Margin = new Padding(10);
        cardPrestados.Name = "cardPrestados";
        cardPrestados.Size = new Size(215, 110);
        cardPrestados.TabIndex = 2;
        // 
        // pnlAccentPrestados
        // 
        pnlAccentPrestados.BackColor = Color.FromArgb(100, 181, 246);
        pnlAccentPrestados.Dock = DockStyle.Top;
        pnlAccentPrestados.Location = new Point(0, 0);
        pnlAccentPrestados.Name = "pnlAccentPrestados";
        pnlAccentPrestados.Size = new Size(213, 6);
        pnlAccentPrestados.TabIndex = 0;
        // 
        // lblValPrestados
        // 
        lblValPrestados.Dock = DockStyle.Fill;
        lblValPrestados.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblValPrestados.ForeColor = Color.Black;
        lblValPrestados.Location = new Point(0, 34);
        lblValPrestados.Name = "lblValPrestados";
        lblValPrestados.Size = new Size(213, 74);
        lblValPrestados.TabIndex = 2;
        lblValPrestados.Text = "0";
        lblValPrestados.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTitPrestados
        // 
        lblTitPrestados.Dock = DockStyle.Top;
        lblTitPrestados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTitPrestados.ForeColor = Color.Black;
        lblTitPrestados.Location = new Point(0, 6);
        lblTitPrestados.Name = "lblTitPrestados";
        lblTitPrestados.Size = new Size(213, 28);
        lblTitPrestados.TabIndex = 1;
        lblTitPrestados.Text = "Prestados";
        lblTitPrestados.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cardDanados
        // 
        cardDanados.BackColor = Color.White;
        cardDanados.BorderStyle = BorderStyle.FixedSingle;
        cardDanados.Controls.Add(lblValDanados);
        cardDanados.Controls.Add(lblTitDanados);
        cardDanados.Controls.Add(pnlAccentDanados);
        cardDanados.Location = new Point(731, 26);
        cardDanados.Margin = new Padding(10);
        cardDanados.Name = "cardDanados";
        cardDanados.Size = new Size(215, 110);
        cardDanados.TabIndex = 3;
        // 
        // pnlAccentDanados
        // 
        pnlAccentDanados.BackColor = Color.FromArgb(255, 183, 77);
        pnlAccentDanados.Dock = DockStyle.Top;
        pnlAccentDanados.Location = new Point(0, 0);
        pnlAccentDanados.Name = "pnlAccentDanados";
        pnlAccentDanados.Size = new Size(213, 6);
        pnlAccentDanados.TabIndex = 0;
        // 
        // lblValDanados
        // 
        lblValDanados.Dock = DockStyle.Fill;
        lblValDanados.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblValDanados.ForeColor = Color.Black;
        lblValDanados.Location = new Point(0, 34);
        lblValDanados.Name = "lblValDanados";
        lblValDanados.Size = new Size(213, 74);
        lblValDanados.TabIndex = 2;
        lblValDanados.Text = "0";
        lblValDanados.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTitDanados
        // 
        lblTitDanados.Dock = DockStyle.Top;
        lblTitDanados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTitDanados.ForeColor = Color.Black;
        lblTitDanados.Location = new Point(0, 6);
        lblTitDanados.Name = "lblTitDanados";
        lblTitDanados.Size = new Size(213, 28);
        lblTitDanados.TabIndex = 1;
        lblTitDanados.Text = "Dañados";
        lblTitDanados.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cardPerdidos
        // 
        cardPerdidos.BackColor = Color.White;
        cardPerdidos.BorderStyle = BorderStyle.FixedSingle;
        cardPerdidos.Controls.Add(lblValPerdidos);
        cardPerdidos.Controls.Add(lblTitPerdidos);
        cardPerdidos.Controls.Add(pnlAccentPerdidos);
        cardPerdidos.Location = new Point(26, 156);
        cardPerdidos.Margin = new Padding(10);
        cardPerdidos.Name = "cardPerdidos";
        cardPerdidos.Size = new Size(215, 110);
        cardPerdidos.TabIndex = 4;
        // 
        // pnlAccentPerdidos
        // 
        pnlAccentPerdidos.BackColor = Color.FromArgb(229, 115, 115);
        pnlAccentPerdidos.Dock = DockStyle.Top;
        pnlAccentPerdidos.Location = new Point(0, 0);
        pnlAccentPerdidos.Name = "pnlAccentPerdidos";
        pnlAccentPerdidos.Size = new Size(213, 6);
        pnlAccentPerdidos.TabIndex = 0;
        // 
        // lblValPerdidos
        // 
        lblValPerdidos.Dock = DockStyle.Fill;
        lblValPerdidos.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblValPerdidos.ForeColor = Color.Black;
        lblValPerdidos.Location = new Point(0, 34);
        lblValPerdidos.Name = "lblValPerdidos";
        lblValPerdidos.Size = new Size(213, 74);
        lblValPerdidos.TabIndex = 2;
        lblValPerdidos.Text = "0";
        lblValPerdidos.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTitPerdidos
        // 
        lblTitPerdidos.Dock = DockStyle.Top;
        lblTitPerdidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTitPerdidos.ForeColor = Color.Black;
        lblTitPerdidos.Location = new Point(0, 6);
        lblTitPerdidos.Name = "lblTitPerdidos";
        lblTitPerdidos.Size = new Size(213, 28);
        lblTitPerdidos.TabIndex = 1;
        lblTitPerdidos.Text = "Perdidos";
        lblTitPerdidos.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cardMantenimiento
        // 
        cardMantenimiento.BackColor = Color.White;
        cardMantenimiento.BorderStyle = BorderStyle.FixedSingle;
        cardMantenimiento.Controls.Add(lblValMantenimiento);
        cardMantenimiento.Controls.Add(lblTitMantenimiento);
        cardMantenimiento.Controls.Add(pnlAccentMantenimiento);
        cardMantenimiento.Location = new Point(261, 156);
        cardMantenimiento.Margin = new Padding(10);
        cardMantenimiento.Name = "cardMantenimiento";
        cardMantenimiento.Size = new Size(215, 110);
        cardMantenimiento.TabIndex = 5;
        // 
        // pnlAccentMantenimiento
        // 
        pnlAccentMantenimiento.BackColor = Color.FromArgb(149, 117, 205);
        pnlAccentMantenimiento.Dock = DockStyle.Top;
        pnlAccentMantenimiento.Location = new Point(0, 0);
        pnlAccentMantenimiento.Name = "pnlAccentMantenimiento";
        pnlAccentMantenimiento.Size = new Size(213, 6);
        pnlAccentMantenimiento.TabIndex = 0;
        // 
        // lblValMantenimiento
        // 
        lblValMantenimiento.Dock = DockStyle.Fill;
        lblValMantenimiento.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblValMantenimiento.ForeColor = Color.Black;
        lblValMantenimiento.Location = new Point(0, 34);
        lblValMantenimiento.Name = "lblValMantenimiento";
        lblValMantenimiento.Size = new Size(213, 74);
        lblValMantenimiento.TabIndex = 2;
        lblValMantenimiento.Text = "0";
        lblValMantenimiento.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTitMantenimiento
        // 
        lblTitMantenimiento.Dock = DockStyle.Top;
        lblTitMantenimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTitMantenimiento.ForeColor = Color.Black;
        lblTitMantenimiento.Location = new Point(0, 6);
        lblTitMantenimiento.Name = "lblTitMantenimiento";
        lblTitMantenimiento.Size = new Size(213, 28);
        lblTitMantenimiento.TabIndex = 1;
        lblTitMantenimiento.Text = "En Mantenimiento";
        lblTitMantenimiento.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cardPrestamosPendientes
        // 
        cardPrestamosPendientes.BackColor = Color.White;
        cardPrestamosPendientes.BorderStyle = BorderStyle.FixedSingle;
        cardPrestamosPendientes.Controls.Add(lblValPrestamosPendientes);
        cardPrestamosPendientes.Controls.Add(lblTitPrestamosPendientes);
        cardPrestamosPendientes.Controls.Add(pnlAccentPrestPend);
        cardPrestamosPendientes.Location = new Point(496, 156);
        cardPrestamosPendientes.Margin = new Padding(10);
        cardPrestamosPendientes.Name = "cardPrestamosPendientes";
        cardPrestamosPendientes.Size = new Size(215, 110);
        cardPrestamosPendientes.TabIndex = 6;
        // 
        // pnlAccentPrestPend
        // 
        pnlAccentPrestPend.BackColor = Color.FromArgb(77, 182, 172);
        pnlAccentPrestPend.Dock = DockStyle.Top;
        pnlAccentPrestPend.Location = new Point(0, 0);
        pnlAccentPrestPend.Name = "pnlAccentPrestPend";
        pnlAccentPrestPend.Size = new Size(213, 6);
        pnlAccentPrestPend.TabIndex = 0;
        // 
        // lblValPrestamosPendientes
        // 
        lblValPrestamosPendientes.Dock = DockStyle.Fill;
        lblValPrestamosPendientes.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblValPrestamosPendientes.ForeColor = Color.Black;
        lblValPrestamosPendientes.Location = new Point(0, 34);
        lblValPrestamosPendientes.Name = "lblValPrestamosPendientes";
        lblValPrestamosPendientes.Size = new Size(213, 74);
        lblValPrestamosPendientes.TabIndex = 2;
        lblValPrestamosPendientes.Text = "0";
        lblValPrestamosPendientes.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTitPrestamosPendientes
        // 
        lblTitPrestamosPendientes.Dock = DockStyle.Top;
        lblTitPrestamosPendientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTitPrestamosPendientes.ForeColor = Color.Black;
        lblTitPrestamosPendientes.Location = new Point(0, 6);
        lblTitPrestamosPendientes.Name = "lblTitPrestamosPendientes";
        lblTitPrestamosPendientes.Size = new Size(213, 28);
        lblTitPrestamosPendientes.TabIndex = 1;
        lblTitPrestamosPendientes.Text = "Préstamos Pendientes";
        lblTitPrestamosPendientes.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cardSolicitudesPendientes
        // 
        cardSolicitudesPendientes.BackColor = Color.White;
        cardSolicitudesPendientes.BorderStyle = BorderStyle.FixedSingle;
        cardSolicitudesPendientes.Controls.Add(lblValSolicitudesPendientes);
        cardSolicitudesPendientes.Controls.Add(lblTitSolicitudesPendientes);
        cardSolicitudesPendientes.Controls.Add(pnlAccentSolPend);
        cardSolicitudesPendientes.Location = new Point(731, 156);
        cardSolicitudesPendientes.Margin = new Padding(10);
        cardSolicitudesPendientes.Name = "cardSolicitudesPendientes";
        cardSolicitudesPendientes.Size = new Size(215, 110);
        cardSolicitudesPendientes.TabIndex = 7;
        // 
        // pnlAccentSolPend
        // 
        pnlAccentSolPend.BackColor = Color.FromArgb(240, 98, 146);
        pnlAccentSolPend.Dock = DockStyle.Top;
        pnlAccentSolPend.Location = new Point(0, 0);
        pnlAccentSolPend.Name = "pnlAccentSolPend";
        pnlAccentSolPend.Size = new Size(213, 6);
        pnlAccentSolPend.TabIndex = 0;
        // 
        // lblValSolicitudesPendientes
        // 
        lblValSolicitudesPendientes.Dock = DockStyle.Fill;
        lblValSolicitudesPendientes.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblValSolicitudesPendientes.ForeColor = Color.Black;
        lblValSolicitudesPendientes.Location = new Point(0, 34);
        lblValSolicitudesPendientes.Name = "lblValSolicitudesPendientes";
        lblValSolicitudesPendientes.Size = new Size(213, 74);
        lblValSolicitudesPendientes.TabIndex = 2;
        lblValSolicitudesPendientes.Text = "0";
        lblValSolicitudesPendientes.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTitSolicitudesPendientes
        // 
        lblTitSolicitudesPendientes.Dock = DockStyle.Top;
        lblTitSolicitudesPendientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblTitSolicitudesPendientes.ForeColor = Color.Black;
        lblTitSolicitudesPendientes.Location = new Point(0, 6);
        lblTitSolicitudesPendientes.Name = "lblTitSolicitudesPendientes";
        lblTitSolicitudesPendientes.Size = new Size(213, 28);
        lblTitSolicitudesPendientes.TabIndex = 1;
        lblTitSolicitudesPendientes.Text = "Solicitudes Pendientes";
        lblTitSolicitudesPendientes.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlInicioTop
        // 
        pnlInicioTop.BackColor = Color.FromArgb(142, 177, 209);
        pnlInicioTop.Controls.Add(lblInicioTitulo);
        pnlInicioTop.Dock = DockStyle.Top;
        pnlInicioTop.Location = new Point(0, 0);
        pnlInicioTop.Name = "pnlInicioTop";
        pnlInicioTop.Size = new Size(1009, 32);
        pnlInicioTop.TabIndex = 0;
        // 
        // lblInicioTitulo
        // 
        lblInicioTitulo.Dock = DockStyle.Fill;
        lblInicioTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblInicioTitulo.ForeColor = Color.Black;
        lblInicioTitulo.Location = new Point(0, 0);
        lblInicioTitulo.Name = "lblInicioTitulo";
        lblInicioTitulo.Size = new Size(1009, 32);
        lblInicioTitulo.TabIndex = 0;
        lblInicioTitulo.Text = "PANEL DE INICIO - RESUMEN DE INVENTARIO";
        lblInicioTitulo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // statusStripPrincipal
        // 
        statusStripPrincipal.BackColor = Color.FromArgb(239, 239, 239);
        statusStripPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        statusStripPrincipal.Items.AddRange(new ToolStripItem[] {
            lblStatusUsuario,
            lblStatusSeparador1,
            lblStatusEstado,
            statusSpring,
            statusProgressBar,
            lblStatusSeparador2,
            lblStatusFecha
        });
        statusStripPrincipal.Location = new Point(0, 739);
        statusStripPrincipal.Name = "statusStripPrincipal";
        statusStripPrincipal.Padding = new Padding(1, 0, 14, 0);
        statusStripPrincipal.Size = new Size(1184, 22);
        statusStripPrincipal.TabIndex = 3;
        statusStripPrincipal.Text = "statusStripPrincipal";
        // 
        // lblStatusUsuario
        // 
        lblStatusUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblStatusUsuario.ForeColor = Color.Black;
        lblStatusUsuario.Name = "lblStatusUsuario";
        lblStatusUsuario.Size = new Size(111, 17);
        lblStatusUsuario.Text = "Usuario: [Iniciando]";
        // 
        // lblStatusSeparador1
        // 
        lblStatusSeparador1.ForeColor = SystemColors.ControlDark;
        lblStatusSeparador1.Name = "lblStatusSeparador1";
        lblStatusSeparador1.Size = new Size(10, 17);
        lblStatusSeparador1.Text = "|";
        // 
        // lblStatusEstado
        // 
        lblStatusEstado.ForeColor = Color.Black;
        lblStatusEstado.Name = "lblStatusEstado";
        lblStatusEstado.Size = new Size(79, 17);
        lblStatusEstado.Text = "Sistema Listo";
        // 
        // statusSpring
        // 
        statusSpring.Name = "statusSpring";
        statusSpring.Size = new Size(719, 17);
        statusSpring.Spring = true;
        // 
        // statusProgressBar
        // 
        statusProgressBar.Name = "statusProgressBar";
        statusProgressBar.Size = new Size(120, 16);
        statusProgressBar.Style = ProgressBarStyle.Continuous;
        statusProgressBar.Visible = false;
        // 
        // lblStatusSeparador2
        // 
        lblStatusSeparador2.ForeColor = SystemColors.ControlDark;
        lblStatusSeparador2.Name = "lblStatusSeparador2";
        lblStatusSeparador2.Size = new Size(10, 17);
        lblStatusSeparador2.Text = "|";
        // 
        // lblStatusFecha
        // 
        lblStatusFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblStatusFecha.ForeColor = Color.Black;
        lblStatusFecha.Name = "lblStatusFecha";
        lblStatusFecha.Size = new Size(102, 17);
        lblStatusFecha.Text = "Fecha: 01/01/2026";
        // 
        // timerFecha
        // 
        timerFecha.Enabled = true;
        timerFecha.Interval = 1000;
        timerFecha.Tick += TimerFecha_Tick;
        // 
        // FrmPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(1184, 761);
        Controls.Add(pnlContenedor);
        Controls.Add(pnlSidebar);
        Controls.Add(pnlBarraSuperior);
        Controls.Add(statusStripPrincipal);
        MinimumSize = new Size(900, 600);
        Name = "FrmPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SGICE - Sistema de Gestión de Activos Inmuebles para Escuelas";
        WindowState = FormWindowState.Maximized;
        FormClosing += FrmPrincipal_FormClosing;
        Load += FrmPrincipal_Load;
        pnlBarraSuperior.ResumeLayout(false);
        pnlSidebar.ResumeLayout(false);
        flpMenu.ResumeLayout(false);
        pnlSubInventario.ResumeLayout(false);
        pnlSubMovimientos.ResumeLayout(false);
        pnlSubPrestamos.ResumeLayout(false);
        pnlSubMantenimiento.ResumeLayout(false);
        pnlSubAdmin.ResumeLayout(false);
        pnlSubReportes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picLogoSidebar).EndInit();
        pnlContenedor.ResumeLayout(false);
        pnlInicio.ResumeLayout(false);
        flpTarjetas.ResumeLayout(false);
        cardActivosTotales.ResumeLayout(false);
        cardDisponibles.ResumeLayout(false);
        cardPrestados.ResumeLayout(false);
        cardDanados.ResumeLayout(false);
        cardPerdidos.ResumeLayout(false);
        cardMantenimiento.ResumeLayout(false);
        cardPrestamosPendientes.ResumeLayout(false);
        cardSolicitudesPendientes.ResumeLayout(false);
        pnlInicioTop.ResumeLayout(false);
        statusStripPrincipal.ResumeLayout(false);
        statusStripPrincipal.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel pnlBarraSuperior;
    private Button btnMenuToggle;
    private Label lblTituloSistema;
    private Panel pnlSidebar;
    private PictureBox picLogoSidebar;
    private FlowLayoutPanel flpMenu;
    private Button btnMenuInicio;
    private Button btnMenuInventario;
    private Panel pnlSubInventario;
    private Button btnSubActivos;
    private Button btnSubCategorias;
    private Button btnSubSubCategorias;
    private Button btnSubMarcas;
    private Button btnSubProveedores;
    private Button btnSubEdificios;
    private Button btnSubUbicaciones;
    private Button btnMenuMovimientos;
    private Panel pnlSubMovimientos;
    private Button btnSubEntradas;
    private Button btnSubActivosFisicos;
    private Button btnSubTraslados;
    private Button btnSubSalidasBajas;
    private Button btnMenuPrestamos;
    private Panel pnlSubPrestamos;
    private Button btnSubPrestamos;
    private Button btnSubDevoluciones;
    private Button btnMenuMantenimiento;
    private Panel pnlSubMantenimiento;
    private Button btnSubSolicitudesMant;
    private Button btnSubOrdenesMant;
    private Button btnMenuAdmin;
    private Panel pnlSubAdmin;
    private Button btnSubCentros;
    private Button btnSubPersonal;
    private Button btnSubUsuarios;
    private Button btnMenuReportes;
    private Panel pnlSubReportes;
    private Button btnSubRepGeneral;
    private Button btnSubRepInventario;
    private Button btnSubRepAuditoria;
    private Button btnMenuAcercaDe;
    private Button btnMenuCerrarSesion;
    private Button btnMenuSalir;
    private Panel pnlContenedor;
    private Panel pnlInicio;
    private Panel pnlInicioTop;
    private Label lblInicioTitulo;
    private FlowLayoutPanel flpTarjetas;
    private Panel cardActivosTotales;
    private Panel pnlAccentTotales;
    private Label lblTitActivosTotales;
    private Label lblValActivosTotales;
    private Panel cardDisponibles;
    private Panel pnlAccentDisponibles;
    private Label lblTitDisponibles;
    private Label lblValDisponibles;
    private Panel cardPrestados;
    private Panel pnlAccentPrestados;
    private Label lblTitPrestados;
    private Label lblValPrestados;
    private Panel cardDanados;
    private Panel pnlAccentDanados;
    private Label lblTitDanados;
    private Label lblValDanados;
    private Panel cardPerdidos;
    private Panel pnlAccentPerdidos;
    private Label lblTitPerdidos;
    private Label lblValPerdidos;
    private Panel cardMantenimiento;
    private Panel pnlAccentMantenimiento;
    private Label lblTitMantenimiento;
    private Label lblValMantenimiento;
    private Panel cardPrestamosPendientes;
    private Panel pnlAccentPrestPend;
    private Label lblTitPrestamosPendientes;
    private Label lblValPrestamosPendientes;
    private Panel cardSolicitudesPendientes;
    private Panel pnlAccentSolPend;
    private Label lblTitSolicitudesPendientes;
    private Label lblValSolicitudesPendientes;
    private StatusStrip statusStripPrincipal;
    private ToolStripStatusLabel lblStatusUsuario;
    private ToolStripStatusLabel lblStatusSeparador1;
    private ToolStripStatusLabel lblStatusEstado;
    private ToolStripStatusLabel statusSpring;
    private ToolStripProgressBar statusProgressBar;
    private ToolStripStatusLabel lblStatusSeparador2;
    private ToolStripStatusLabel lblStatusFecha;
    private System.Windows.Forms.Timer timerFecha;
}
