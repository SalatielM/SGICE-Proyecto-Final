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
        menuStripPrincipal = new MenuStrip();
        menuMantenimientos = new ToolStripMenuItem();
        itemCentrosEducativos = new ToolStripMenuItem();
        itemEdificios = new ToolStripMenuItem();
        itemUbicaciones = new ToolStripMenuItem();
        sepMantenimientos1 = new ToolStripSeparator();
        itemCategorias = new ToolStripMenuItem();
        itemSubCategorias = new ToolStripMenuItem();
        itemMarcas = new ToolStripMenuItem();
        itemCatalogoActivos = new ToolStripMenuItem();
        sepMantenimientos2 = new ToolStripSeparator();
        itemProveedores = new ToolStripMenuItem();
        itemPersonal = new ToolStripMenuItem();
        sepMantenimientos3 = new ToolStripSeparator();
        itemUsuarios = new ToolStripMenuItem();
        itemRoles = new ToolStripMenuItem();
        menuProcesos = new ToolStripMenuItem();
        itemEntradaActivos = new ToolStripMenuItem();
        itemActivosFisicos = new ToolStripMenuItem();
        sepProcesos1 = new ToolStripSeparator();
        itemPrestamos = new ToolStripMenuItem();
        itemDevoluciones = new ToolStripMenuItem();
        sepProcesos2 = new ToolStripSeparator();
        itemTraslados = new ToolStripMenuItem();
        itemSolicitudesMantenimiento = new ToolStripMenuItem();
        itemMantenimientos = new ToolStripMenuItem();
        sepProcesos3 = new ToolStripSeparator();
        itemSalidasBajas = new ToolStripMenuItem();
        menuReportes = new ToolStripMenuItem();
        itemRepInventarioGeneral = new ToolStripMenuItem();
        itemRepActivosPorCentro = new ToolStripMenuItem();
        itemRepActivosPorUbicacion = new ToolStripMenuItem();
        sepReportes1 = new ToolStripSeparator();
        itemRepHistorialMantenimiento = new ToolStripMenuItem();
        itemRepPrestamosDevoluciones = new ToolStripMenuItem();
        itemRepBajasActivos = new ToolStripMenuItem();
        sepReportes2 = new ToolStripSeparator();
        itemRepAuditoria = new ToolStripMenuItem();
        menuSistema = new ToolStripMenuItem();
        itemCerrarSesion = new ToolStripMenuItem();
        sepSistema1 = new ToolStripSeparator();
        itemSalir = new ToolStripMenuItem();
        menuAyuda = new ToolStripMenuItem();
        itemAcercaDe = new ToolStripMenuItem();
        statusStripPrincipal = new StatusStrip();
        lblStatusUsuario = new ToolStripStatusLabel();
        lblStatusSeparador1 = new ToolStripStatusLabel();
        lblStatusEstado = new ToolStripStatusLabel();
        statusSpring = new ToolStripStatusLabel();
        statusProgressBar = new ToolStripProgressBar();
        lblStatusSeparador2 = new ToolStripStatusLabel();
        lblStatusFecha = new ToolStripStatusLabel();
        timerFecha = new System.Windows.Forms.Timer(components);
        menuStripPrincipal.SuspendLayout();
        statusStripPrincipal.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripPrincipal
        // 
        menuStripPrincipal.BackColor = Color.FromArgb(30, 41, 59);
        menuStripPrincipal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        menuStripPrincipal.Items.AddRange(new ToolStripItem[] {
            menuMantenimientos,
            menuProcesos,
            menuReportes,
            menuSistema,
            menuAyuda
        });
        menuStripPrincipal.Location = new Point(0, 0);
        menuStripPrincipal.Name = "menuStripPrincipal";
        menuStripPrincipal.Padding = new Padding(6, 4, 0, 4);
        menuStripPrincipal.RenderMode = ToolStripRenderMode.Professional;
        menuStripPrincipal.Size = new Size(1184, 29);
        menuStripPrincipal.TabIndex = 0;
        menuStripPrincipal.Text = "menuStripPrincipal";
        // 
        // menuMantenimientos
        // 
        menuMantenimientos.DropDownItems.AddRange(new ToolStripItem[] {
            itemCentrosEducativos,
            itemEdificios,
            itemUbicaciones,
            sepMantenimientos1,
            itemCategorias,
            itemSubCategorias,
            itemMarcas,
            itemCatalogoActivos,
            sepMantenimientos2,
            itemProveedores,
            itemPersonal,
            sepMantenimientos3,
            itemUsuarios,
            itemRoles
        });
        menuMantenimientos.ForeColor = Color.White;
        menuMantenimientos.Name = "menuMantenimientos";
        menuMantenimientos.Size = new Size(114, 21);
        menuMantenimientos.Text = "&Mantenimientos";
        // 
        // itemCentrosEducativos
        // 
        itemCentrosEducativos.Name = "itemCentrosEducativos";
        itemCentrosEducativos.Size = new Size(244, 22);
        itemCentrosEducativos.Text = "Centros Educativos";
        itemCentrosEducativos.Click += ItemCentrosEducativos_Click;
        // 
        // itemEdificios
        // 
        itemEdificios.Name = "itemEdificios";
        itemEdificios.Size = new Size(244, 22);
        itemEdificios.Text = "Edificios";
        itemEdificios.Click += ItemEdificios_Click;
        // 
        // itemUbicaciones
        // 
        itemUbicaciones.Name = "itemUbicaciones";
        itemUbicaciones.Size = new Size(244, 22);
        itemUbicaciones.Text = "Ubicaciones";
        itemUbicaciones.Click += ItemUbicaciones_Click;
        // 
        // sepMantenimientos1
        // 
        sepMantenimientos1.Name = "sepMantenimientos1";
        sepMantenimientos1.Size = new Size(241, 6);
        // 
        // itemCategorias
        // 
        itemCategorias.Name = "itemCategorias";
        itemCategorias.Size = new Size(244, 22);
        itemCategorias.Text = "Categorías";
        itemCategorias.Click += ItemCategorias_Click;
        // 
        // itemSubCategorias
        // 
        itemSubCategorias.Name = "itemSubCategorias";
        itemSubCategorias.Size = new Size(244, 22);
        itemSubCategorias.Text = "Subcategorías";
        itemSubCategorias.Click += ItemSubCategorias_Click;
        // 
        // itemMarcas
        // 
        itemMarcas.Name = "itemMarcas";
        itemMarcas.Size = new Size(244, 22);
        itemMarcas.Text = "Marcas";
        itemMarcas.Click += ItemMarcas_Click;
        // 
        // itemCatalogoActivos
        // 
        itemCatalogoActivos.Name = "itemCatalogoActivos";
        itemCatalogoActivos.Size = new Size(244, 22);
        itemCatalogoActivos.Text = "Catálogo de Activos";
        itemCatalogoActivos.Click += ItemCatalogoActivos_Click;
        // 
        // sepMantenimientos2
        // 
        sepMantenimientos2.Name = "sepMantenimientos2";
        sepMantenimientos2.Size = new Size(241, 6);
        // 
        // itemProveedores
        // 
        itemProveedores.Name = "itemProveedores";
        itemProveedores.Size = new Size(244, 22);
        itemProveedores.Text = "Proveedores";
        itemProveedores.Click += ItemProveedores_Click;
        // 
        // itemPersonal
        // 
        itemPersonal.Name = "itemPersonal";
        itemPersonal.Size = new Size(244, 22);
        itemPersonal.Text = "Personal Escolar";
        itemPersonal.Click += ItemPersonal_Click;
        // 
        // sepMantenimientos3
        // 
        sepMantenimientos3.Name = "sepMantenimientos3";
        sepMantenimientos3.Size = new Size(241, 6);
        // 
        // itemUsuarios
        // 
        itemUsuarios.Name = "itemUsuarios";
        itemUsuarios.Size = new Size(244, 22);
        itemUsuarios.Text = "Usuarios del Sistema";
        itemUsuarios.Click += ItemUsuarios_Click;
        // 
        // itemRoles
        // 
        itemRoles.Name = "itemRoles";
        itemRoles.Size = new Size(244, 22);
        itemRoles.Text = "Roles y Permisos";
        itemRoles.Click += ItemRoles_Click;
        // 
        // menuProcesos
        // 
        menuProcesos.DropDownItems.AddRange(new ToolStripItem[] {
            itemEntradaActivos,
            itemActivosFisicos,
            sepProcesos1,
            itemPrestamos,
            itemDevoluciones,
            sepProcesos2,
            itemTraslados,
            itemSolicitudesMantenimiento,
            itemMantenimientos,
            sepProcesos3,
            itemSalidasBajas
        });
        menuProcesos.ForeColor = Color.White;
        menuProcesos.Name = "menuProcesos";
        menuProcesos.Size = new Size(73, 21);
        menuProcesos.Text = "&Procesos";
        // 
        // itemEntradaActivos
        // 
        itemEntradaActivos.Name = "itemEntradaActivos";
        itemEntradaActivos.Size = new Size(248, 22);
        itemEntradaActivos.Text = "Entrada de Activos";
        itemEntradaActivos.Click += ItemEntradaActivos_Click;
        // 
        // itemActivosFisicos
        // 
        itemActivosFisicos.Name = "itemActivosFisicos";
        itemActivosFisicos.Size = new Size(248, 22);
        itemActivosFisicos.Text = "Activos Físicos y QR";
        itemActivosFisicos.Click += ItemActivosFisicos_Click;
        // 
        // sepProcesos1
        // 
        sepProcesos1.Name = "sepProcesos1";
        sepProcesos1.Size = new Size(245, 6);
        // 
        // itemPrestamos
        // 
        itemPrestamos.Name = "itemPrestamos";
        itemPrestamos.Size = new Size(248, 22);
        itemPrestamos.Text = "Préstamos de Activos";
        itemPrestamos.Click += ItemPrestamos_Click;
        // 
        // itemDevoluciones
        // 
        itemDevoluciones.Name = "itemDevoluciones";
        itemDevoluciones.Size = new Size(248, 22);
        itemDevoluciones.Text = "Devoluciones de Préstamos";
        itemDevoluciones.Click += ItemDevoluciones_Click;
        // 
        // sepProcesos2
        // 
        sepProcesos2.Name = "sepProcesos2";
        sepProcesos2.Size = new Size(245, 6);
        // 
        // itemTraslados
        // 
        itemTraslados.Name = "itemTraslados";
        itemTraslados.Size = new Size(248, 22);
        itemTraslados.Text = "Traslado entre Ubicaciones";
        itemTraslados.Click += ItemTraslados_Click;
        // 
        // itemSolicitudesMantenimiento
        // 
        itemSolicitudesMantenimiento.Name = "itemSolicitudesMantenimiento";
        itemSolicitudesMantenimiento.Size = new Size(248, 22);
        itemSolicitudesMantenimiento.Text = "Solicitudes de Mantenimiento";
        itemSolicitudesMantenimiento.Click += ItemSolicitudesMantenimiento_Click;
        // 
        // itemMantenimientos
        // 
        itemMantenimientos.Name = "itemMantenimientos";
        itemMantenimientos.Size = new Size(248, 22);
        itemMantenimientos.Text = "Órdenes de Mantenimiento";
        itemMantenimientos.Click += ItemMantenimientos_Click;
        // 
        // sepProcesos3
        // 
        sepProcesos3.Name = "sepProcesos3";
        sepProcesos3.Size = new Size(245, 6);
        // 
        // itemSalidasBajas
        // 
        itemSalidasBajas.Name = "itemSalidasBajas";
        itemSalidasBajas.Size = new Size(248, 22);
        itemSalidasBajas.Text = "Salidas y Bajas de Activos";
        itemSalidasBajas.Click += ItemSalidasBajas_Click;
        // 
        // menuReportes
        // 
        menuReportes.DropDownItems.AddRange(new ToolStripItem[] {
            itemRepInventarioGeneral,
            itemRepActivosPorCentro,
            itemRepActivosPorUbicacion,
            sepReportes1,
            itemRepHistorialMantenimiento,
            itemRepPrestamosDevoluciones,
            itemRepBajasActivos,
            sepReportes2,
            itemRepAuditoria
        });
        menuReportes.ForeColor = Color.White;
        menuReportes.Name = "menuReportes";
        menuReportes.Size = new Size(73, 21);
        menuReportes.Text = "&Reportes";
        // 
        // itemRepInventarioGeneral
        // 
        itemRepInventarioGeneral.Name = "itemRepInventarioGeneral";
        itemRepInventarioGeneral.Size = new Size(251, 22);
        itemRepInventarioGeneral.Text = "Inventario General de Activos";
        itemRepInventarioGeneral.Click += ItemRepInventarioGeneral_Click;
        // 
        // itemRepActivosPorCentro
        // 
        itemRepActivosPorCentro.Name = "itemRepActivosPorCentro";
        itemRepActivosPorCentro.Size = new Size(251, 22);
        itemRepActivosPorCentro.Text = "Activos por Centro Educativo";
        itemRepActivosPorCentro.Click += ItemRepActivosPorCentro_Click;
        // 
        // itemRepActivosPorUbicacion
        // 
        itemRepActivosPorUbicacion.Name = "itemRepActivosPorUbicacion";
        itemRepActivosPorUbicacion.Size = new Size(251, 22);
        itemRepActivosPorUbicacion.Text = "Activos por Ubicación";
        itemRepActivosPorUbicacion.Click += ItemRepActivosPorUbicacion_Click;
        // 
        // sepReportes1
        // 
        sepReportes1.Name = "sepReportes1";
        sepReportes1.Size = new Size(248, 6);
        // 
        // itemRepHistorialMantenimiento
        // 
        itemRepHistorialMantenimiento.Name = "itemRepHistorialMantenimiento";
        itemRepHistorialMantenimiento.Size = new Size(251, 22);
        itemRepHistorialMantenimiento.Text = "Historial de Mantenimientos";
        itemRepHistorialMantenimiento.Click += ItemRepHistorialMantenimiento_Click;
        // 
        // itemRepPrestamosDevoluciones
        // 
        itemRepPrestamosDevoluciones.Name = "itemRepPrestamosDevoluciones";
        itemRepPrestamosDevoluciones.Size = new Size(251, 22);
        itemRepPrestamosDevoluciones.Text = "Préstamos y Devoluciones";
        itemRepPrestamosDevoluciones.Click += ItemRepPrestamosDevoluciones_Click;
        // 
        // itemRepBajasActivos
        // 
        itemRepBajasActivos.Name = "itemRepBajasActivos";
        itemRepBajasActivos.Size = new Size(251, 22);
        itemRepBajasActivos.Text = "Bajas de Activos";
        itemRepBajasActivos.Click += ItemRepBajasActivos_Click;
        // 
        // sepReportes2
        // 
        sepReportes2.Name = "sepReportes2";
        sepReportes2.Size = new Size(248, 6);
        // 
        // itemRepAuditoria
        // 
        itemRepAuditoria.Name = "itemRepAuditoria";
        itemRepAuditoria.Size = new Size(251, 22);
        itemRepAuditoria.Text = "Bitácora de Auditoría";
        itemRepAuditoria.Click += ItemRepAuditoria_Click;
        // 
        // menuSistema
        // 
        menuSistema.DropDownItems.AddRange(new ToolStripItem[] {
            itemCerrarSesion,
            sepSistema1,
            itemSalir
        });
        menuSistema.ForeColor = Color.White;
        menuSistema.Name = "menuSistema";
        menuSistema.Size = new Size(65, 21);
        menuSistema.Text = "&Sistema";
        // 
        // itemCerrarSesion
        // 
        itemCerrarSesion.Name = "itemCerrarSesion";
        itemCerrarSesion.Size = new Size(153, 22);
        itemCerrarSesion.Text = "Cerrar Sesión";
        itemCerrarSesion.Click += ItemCerrarSesion_Click;
        // 
        // sepSistema1
        // 
        sepSistema1.Name = "sepSistema1";
        sepSistema1.Size = new Size(150, 6);
        // 
        // itemSalir
        // 
        itemSalir.Name = "itemSalir";
        itemSalir.Size = new Size(153, 22);
        itemSalir.Text = "Salir";
        itemSalir.Click += ItemSalir_Click;
        // 
        // menuAyuda
        // 
        menuAyuda.DropDownItems.AddRange(new ToolStripItem[] {
            itemAcercaDe
        });
        menuAyuda.ForeColor = Color.White;
        menuAyuda.Name = "menuAyuda";
        menuAyuda.Size = new Size(56, 21);
        menuAyuda.Text = "A&yuda";
        // 
        // itemAcercaDe
        // 
        itemAcercaDe.Name = "itemAcercaDe";
        itemAcercaDe.Size = new Size(174, 22);
        itemAcercaDe.Text = "Acerca de SGICE";
        itemAcercaDe.Click += ItemAcercaDe_Click;
        // 
        // statusStripPrincipal
        // 
        statusStripPrincipal.BackColor = Color.FromArgb(241, 245, 249);
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
        statusStripPrincipal.TabIndex = 1;
        statusStripPrincipal.Text = "statusStripPrincipal";
        // 
        // lblStatusUsuario
        // 
        lblStatusUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblStatusUsuario.ForeColor = Color.FromArgb(30, 41, 59);
        lblStatusUsuario.Name = "lblStatusUsuario";
        lblStatusUsuario.Size = new Size(111, 17);
        lblStatusUsuario.Text = "Usuario: [Iniciando]";
        // 
        // lblStatusSeparador1
        // 
        lblStatusSeparador1.ForeColor = Color.FromArgb(203, 213, 225);
        lblStatusSeparador1.Name = "lblStatusSeparador1";
        lblStatusSeparador1.Size = new Size(10, 17);
        lblStatusSeparador1.Text = "|";
        // 
        // lblStatusEstado
        // 
        lblStatusEstado.ForeColor = Color.FromArgb(71, 85, 105);
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
        lblStatusSeparador2.ForeColor = Color.FromArgb(203, 213, 225);
        lblStatusSeparador2.Name = "lblStatusSeparador2";
        lblStatusSeparador2.Size = new Size(10, 17);
        lblStatusSeparador2.Text = "|";
        // 
        // lblStatusFecha
        // 
        lblStatusFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblStatusFecha.ForeColor = Color.FromArgb(71, 85, 105);
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
        BackColor = Color.FromArgb(248, 250, 252);
        ClientSize = new Size(1184, 761);
        Controls.Add(statusStripPrincipal);
        Controls.Add(menuStripPrincipal);
        IsMdiContainer = true;
        MainMenuStrip = menuStripPrincipal;
        MinimumSize = new Size(900, 600);
        Name = "FrmPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SGICE - Sistema de Gestión de Activos Inmuebles para Escuelas";
        WindowState = FormWindowState.Maximized;
        FormClosing += FrmPrincipal_FormClosing;
        Load += FrmPrincipal_Load;
        menuStripPrincipal.ResumeLayout(false);
        menuStripPrincipal.PerformLayout();
        statusStripPrincipal.ResumeLayout(false);
        statusStripPrincipal.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStripPrincipal;
    private ToolStripMenuItem menuMantenimientos;
    private ToolStripMenuItem itemCentrosEducativos;
    private ToolStripMenuItem itemEdificios;
    private ToolStripMenuItem itemUbicaciones;
    private ToolStripSeparator sepMantenimientos1;
    private ToolStripMenuItem itemCategorias;
    private ToolStripMenuItem itemSubCategorias;
    private ToolStripMenuItem itemMarcas;
    private ToolStripMenuItem itemCatalogoActivos;
    private ToolStripSeparator sepMantenimientos2;
    private ToolStripMenuItem itemProveedores;
    private ToolStripMenuItem itemPersonal;
    private ToolStripSeparator sepMantenimientos3;
    private ToolStripMenuItem itemUsuarios;
    private ToolStripMenuItem itemRoles;
    private ToolStripMenuItem menuProcesos;
    private ToolStripMenuItem itemEntradaActivos;
    private ToolStripMenuItem itemActivosFisicos;
    private ToolStripSeparator sepProcesos1;
    private ToolStripMenuItem itemPrestamos;
    private ToolStripMenuItem itemDevoluciones;
    private ToolStripSeparator sepProcesos2;
    private ToolStripMenuItem itemTraslados;
    private ToolStripMenuItem itemSolicitudesMantenimiento;
    private ToolStripMenuItem itemMantenimientos;
    private ToolStripSeparator sepProcesos3;
    private ToolStripMenuItem itemSalidasBajas;
    private ToolStripMenuItem menuReportes;
    private ToolStripMenuItem itemRepInventarioGeneral;
    private ToolStripMenuItem itemRepActivosPorCentro;
    private ToolStripMenuItem itemRepActivosPorUbicacion;
    private ToolStripSeparator sepReportes1;
    private ToolStripMenuItem itemRepHistorialMantenimiento;
    private ToolStripMenuItem itemRepPrestamosDevoluciones;
    private ToolStripMenuItem itemRepBajasActivos;
    private ToolStripSeparator sepReportes2;
    private ToolStripMenuItem itemRepAuditoria;
    private ToolStripMenuItem menuSistema;
    private ToolStripMenuItem itemCerrarSesion;
    private ToolStripSeparator sepSistema1;
    private ToolStripMenuItem itemSalir;
    private ToolStripMenuItem menuAyuda;
    private ToolStripMenuItem itemAcercaDe;
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
