using SGICE.Entidades.Enums;
using SGICE.Negocio.Operaciones;
using SGICE.Negocio.Seguridad;

namespace SGICE.Presentacion;

public partial class FrmPrincipal : Form
{
    public FrmPrincipal()
    {
        InitializeComponent();
    }

    #region Navegación Acordeón y Contenedor de Formularios

    private void AlternarSubMenu(Panel subMenuObjetivo)
    {
        bool mostrar = !subMenuObjetivo.Visible;
        foreach (Control ctrl in flpMenu.Controls)
        {
            if (ctrl is Panel panelSub)
            {
                panelSub.Visible = false;
            }
        }
        subMenuObjetivo.Visible = mostrar;
    }

    private void BtnMenuToggle_Click(object? sender, EventArgs e)
    {
        pnlSidebar.Visible = !pnlSidebar.Visible;
    }

    private void BtnMenuInicio_Click(object? sender, EventArgs e)
    {
        MostrarInicio();
    }

    private void BtnMenuInventario_Click(object? sender, EventArgs e) => AlternarSubMenu(pnlSubInventario);
    private void BtnMenuMovimientos_Click(object? sender, EventArgs e) => AlternarSubMenu(pnlSubMovimientos);
    private void BtnMenuPrestamos_Click(object? sender, EventArgs e) => AlternarSubMenu(pnlSubPrestamos);
    private void BtnMenuMantenimiento_Click(object? sender, EventArgs e) => AlternarSubMenu(pnlSubMantenimiento);
    private void BtnMenuAdmin_Click(object? sender, EventArgs e) => AlternarSubMenu(pnlSubAdmin);
    private void BtnMenuReportes_Click(object? sender, EventArgs e) => AlternarSubMenu(pnlSubReportes);

    private void MostrarInicio()
    {
        foreach (Control ctrl in pnlContenedor.Controls)
        {
            if (ctrl is Form f)
            {
                f.Hide();
            }
        }
        pnlInicio.Visible = true;
        pnlInicio.BringToFront();
        CargarResumenInicio();
    }

    private void CargarResumenInicio()
    {
        try
        {
            var activosServ = new ActivoFisicoServicios();
            var prestamoServ = new PrestamoServicios();
            var solicitudServ = new SolicitudMantenimientoServicios();

            lblValActivosTotales.Text = activosServ.Contar().ToString();
            lblValDisponibles.Text = activosServ.ContarPorEstado((int)EstadoActivoFisico.Disponible).ToString();
            lblValPrestados.Text = activosServ.ContarPorEstado((int)EstadoActivoFisico.Prestado).ToString();
            lblValDanados.Text = activosServ.ContarPorEstado((int)EstadoActivoFisico.Dañado).ToString();
            lblValPerdidos.Text = activosServ.ContarPorEstado((int)EstadoActivoFisico.Extraviado).ToString();
            lblValMantenimiento.Text = activosServ.ContarPorEstado((int)EstadoActivoFisico.PendienteDeMantenimiento).ToString();

            int prestamosPendientes = prestamoServ.ContarPorEstado((int)EstadoPrestamo.Vigente)
                                    + prestamoServ.ContarPorEstado((int)EstadoPrestamo.DevueltoParcial);
            lblValPrestamosPendientes.Text = prestamosPendientes.ToString();
            lblValSolicitudesPendientes.Text = solicitudServ.ContarPorEstado((int)EstadoSolicitudMantenimiento.Pendiente).ToString();
        }
        catch
        {
            // En caso de no contar con conexión activa a BD al iniciar, mantener valores por defecto.
        }
    }

    #endregion

    #region Apertura de Instancia Única para Formularios Hijos

    /// <summary>
    /// Abre un formulario hijo incrustado en el panel contenedor central garantizando una única instancia.
    /// Si el formulario ya está abierto, lo muestra y lo enfoca.
    /// </summary>
    /// <typeparam name="T">Tipo del formulario derivado de Form.</typeparam>
    /// <returns>La instancia única del formulario.</returns>
    public T AbrirFormulario<T>() where T : Form, new()
    {
        T? formulario = pnlContenedor.Controls.OfType<T>().FirstOrDefault();

        if (formulario == null)
        {
            formulario = new T
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlContenedor.Controls.Add(formulario);
        }

        MostrarFormularioIncrustado(formulario);
        return formulario;
    }

    /// <summary>
    /// Abre un formulario hijo incrustado en el panel contenedor central a partir de su tipo garantizando una única instancia.
    /// </summary>
    /// <param name="tipoFormulario">Tipo del formulario a instanciar.</param>
    /// <returns>La instancia del formulario.</returns>
    public Form AbrirFormulario(Type tipoFormulario)
    {
        if (!typeof(Form).IsAssignableFrom(tipoFormulario))
        {
            throw new ArgumentException("El tipo proporcionado debe heredar de Form.", nameof(tipoFormulario));
        }

        Form? formulario = pnlContenedor.Controls.OfType<Form>().FirstOrDefault(f => f.GetType() == tipoFormulario);

        if (formulario == null)
        {
            formulario = (Form)Activator.CreateInstance(tipoFormulario)!;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formulario);
        }

        MostrarFormularioIncrustado(formulario);
        return formulario;
    }

    private void MostrarFormularioIncrustado(Form formulario)
    {
        pnlInicio.Visible = false;
        foreach (Control ctrl in pnlContenedor.Controls)
        {
            if (ctrl is Form f && f != formulario)
            {
                f.Hide();
            }
        }
        formulario.Show();
        formulario.BringToFront();
        formulario.Focus();
    }

    private void AbrirReporte(TipoReporte tipo)
    {
        var frm = AbrirFormulario<FrmReportes>();
        frm.SeleccionarTipoReporte(tipo);
    }

    #endregion

    #region Métodos para Barra de Progreso y Estado

    /// <summary>
    /// Activa e inicializa la barra de progreso en el StatusStrip.
    /// </summary>
    public void IniciarProgreso(string? mensaje = "Procesando...")
    {
        statusProgressBar.Value = 0;
        statusProgressBar.Visible = true;
        lblStatusEstado.Text = mensaje;
    }

    /// <summary>
    /// Actualiza el valor de la barra de progreso y el mensaje del StatusStrip.
    /// </summary>
    public void ActualizarProgreso(int valor, string? mensaje = null)
    {
        if (valor < statusProgressBar.Minimum) valor = statusProgressBar.Minimum;
        if (valor > statusProgressBar.Maximum) valor = statusProgressBar.Maximum;

        statusProgressBar.Value = valor;
        statusProgressBar.Visible = true;

        if (!string.IsNullOrEmpty(mensaje))
        {
            lblStatusEstado.Text = mensaje;
        }
    }

    /// <summary>
    /// Finaliza y oculta la barra de progreso.
    /// </summary>
    public void FinalizarProgreso(string? mensaje = "Sistema Listo")
    {
        statusProgressBar.Value = 0;
        statusProgressBar.Visible = false;
        lblStatusEstado.Text = mensaje;
    }

    #endregion

    #region Eventos del Formulario y Navegación

    private void FrmPrincipal_Load(object? sender, EventArgs e)
    {
        ActualizarUsuarioActivo();
        ActualizarFechaHora();
        MostrarInicio();
    }

    private void TimerFecha_Tick(object? sender, EventArgs e)
    {
        ActualizarFechaHora();
    }

    private void ActualizarUsuarioActivo()
    {
        if (SesionActual.ExisteSesion)
        {
            var usuario = SesionActual.Usuario;
            string rol = usuario.Rol?.Nombre ?? "Administrador";
            lblStatusUsuario.Text = $"Usuario: {usuario.NombreUsuario} ({rol})";
        }
        else
        {
            lblStatusUsuario.Text = "Usuario: AdminDEV (Desarrollo)";
        }
    }

    private void ActualizarFechaHora()
    {
        lblStatusFecha.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy - hh:mm:ss tt");
    }

    // --- Mantenimientos ---
    private void ItemCentrosEducativos_Click(object? sender, EventArgs e) => AbrirFormulario<FrmCentrosEducativos>();
    private void ItemEdificios_Click(object? sender, EventArgs e) => AbrirFormulario<FrmEdificios>();
    private void ItemUbicaciones_Click(object? sender, EventArgs e) => AbrirFormulario<FrmUbicaciones>();
    private void ItemCategorias_Click(object? sender, EventArgs e) => AbrirFormulario<FrmCategorias>();
    private void ItemSubCategorias_Click(object? sender, EventArgs e) => AbrirFormulario<FrmSubCategorias>();
    private void ItemMarcas_Click(object? sender, EventArgs e) => AbrirFormulario<FrmMarcas>();
    private void ItemCatalogoActivos_Click(object? sender, EventArgs e) => AbrirFormulario<FrmActivos>();
    private void ItemProveedores_Click(object? sender, EventArgs e) => AbrirFormulario<FrmProveedores>();
    private void ItemPersonal_Click(object? sender, EventArgs e) => AbrirFormulario<FrmPersonal>();
    private void ItemUsuarios_Click(object? sender, EventArgs e) => AbrirFormulario<FrmUsuarios>();
    private void ItemRoles_Click(object? sender, EventArgs e) => AbrirFormulario<FrmUsuarios>();

    // --- Procesos ---
    private void ItemEntradaActivos_Click(object? sender, EventArgs e) => AbrirFormulario<FrmEntradas>();
    private void ItemActivosFisicos_Click(object? sender, EventArgs e) => AbrirFormulario<FrmEntradas>();
    private void ItemTraslados_Click(object? sender, EventArgs e) => AbrirFormulario<FrmTraslados>();
    private void ItemPrestamos_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.Prestamos);
    private void ItemDevoluciones_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.Devoluciones);
    private void ItemSolicitudesMantenimiento_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.SolicitudMantenimiento);
    private void ItemMantenimientos_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.Mantenimientos);
    private void ItemSalidasBajas_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.Salidas);

    // --- Reportes ---
    private void ItemRepInventarioGeneral_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.ActivosFisicos);
    private void ItemRepActivosPorCentro_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.ActivosFisicos);
    private void ItemRepActivosPorUbicacion_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.ActivosFisicos);
    private void ItemRepHistorialMantenimiento_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.Mantenimientos);
    private void ItemRepPrestamosDevoluciones_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.Prestamos);
    private void ItemRepBajasActivos_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.Salidas);
    private void ItemRepAuditoria_Click(object? sender, EventArgs e) => AbrirReporte(TipoReporte.Auditoria);
    private void ItemAbrirReportes_Click(object? sender, EventArgs e) => AbrirFormulario<FrmReportes>();

    // --- Sistema y Ayuda ---
    private void ItemCerrarSesion_Click(object? sender, EventArgs e)
    {
        var confirmacion = MessageBox.Show(
            "¿Está seguro de que desea cerrar la sesión actual?",
            "Confirmar Cierre de Sesión",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmacion == DialogResult.Yes)
        {
            SesionActual.ReiniciarSesion = true;
            Close();
        }
    }

    private void ItemSalir_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void FrmPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (!SesionActual.ReiniciarSesion)
        {
            var confirmacion = MessageBox.Show(
                "¿Está seguro de que desea salir del sistema SGICE?",
                "Salir del Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

    private void ItemAcercaDe_Click(object? sender, EventArgs e)
    {
        MessageBox.Show(
            "SGICE - Sistema de Gestión de Activos Inmuebles para Escuelas\n" +
            "Versión 1.0 (.NET 10)\n\n" +
            "Desarrollado para el control integral de activos, entradas, préstamos, " +
            "devoluciones, traslados y mantenimiento escolar.",
            "Acerca de SGICE",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    #endregion
}
