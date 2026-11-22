using SGICE.Negocio.Seguridad;

namespace SGICE.Presentacion;

public partial class FrmPrincipal : Form
{
    public FrmPrincipal()
    {
        InitializeComponent();
        ConfigurarEstiloVisual();
    }

    #region Configuración Visual y Paleta de Colores

    private void ConfigurarEstiloVisual()
    {
        menuStripPrincipal.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());

        // Personalizar el fondo del contenedor MdiClient para un aspecto moderno
        foreach (Control control in Controls)
        {
            if (control is MdiClient mdiClient)
            {
                mdiClient.BackColor = Color.FromArgb(241, 245, 249); // Slate-100
                break;
            }
        }
    }

    private class MenuColorTable : ProfessionalColorTable
    {
        public override Color MenuStripGradientBegin => Color.FromArgb(30, 41, 59);
        public override Color MenuStripGradientEnd => Color.FromArgb(30, 41, 59);
        public override Color MenuItemSelected => Color.FromArgb(51, 65, 85);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(51, 65, 85);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(51, 65, 85);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(15, 23, 42);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(15, 23, 42);
        public override Color ToolStripDropDownBackground => Color.FromArgb(255, 255, 255);
        public override Color ImageMarginGradientBegin => Color.FromArgb(248, 250, 252);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(248, 250, 252);
        public override Color ImageMarginGradientEnd => Color.FromArgb(248, 250, 252);
        public override Color MenuBorder => Color.FromArgb(203, 213, 225);
        public override Color MenuItemBorder => Color.Transparent;
    }

    #endregion

    #region Validación y Apertura de Instancia Única para Formularios Hijos

    /// <summary>
    /// Abre un formulario hijo MDI garantizando una única instancia en memoria.
    /// Si el formulario ya está abierto, lo restaura y lo enfoca.
    /// </summary>
    /// <typeparam name="T">Tipo del formulario derivado de Form.</typeparam>
    /// <returns>La instancia única del formulario.</returns>
    public T AbrirFormulario<T>() where T : Form, new()
    {
        T? formulario = MdiChildren.OfType<T>().FirstOrDefault();

        if (formulario == null)
        {
            formulario = new T
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            formulario.Show();
        }
        else
        {
            if (formulario.WindowState == FormWindowState.Minimized)
            {
                formulario.WindowState = FormWindowState.Normal;
            }
            formulario.BringToFront();
            formulario.Activate();
        }

        return formulario;
    }

    /// <summary>
    /// Abre un formulario hijo MDI a partir de su tipo garantizando una única instancia.
    /// </summary>
    /// <param name="tipoFormulario">Tipo del formulario a instanciar.</param>
    /// <returns>La instancia del formulario.</returns>
    public Form AbrirFormulario(Type tipoFormulario)
    {
        if (!typeof(Form).IsAssignableFrom(tipoFormulario))
        {
            throw new ArgumentException("El tipo proporcionado debe heredar de Form.", nameof(tipoFormulario));
        }

        Form? formulario = MdiChildren.FirstOrDefault(f => f.GetType() == tipoFormulario);

        if (formulario == null)
        {
            formulario = (Form)Activator.CreateInstance(tipoFormulario)!;
            formulario.MdiParent = this;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Show();
        }
        else
        {
            if (formulario.WindowState == FormWindowState.Minimized)
            {
                formulario.WindowState = FormWindowState.Normal;
            }
            formulario.BringToFront();
            formulario.Activate();
        }

        return formulario;
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

    #region Eventos del Formulario y MenuStrip

    private void FrmPrincipal_Load(object? sender, EventArgs e)
    {
        ActualizarUsuarioActivo();
        ActualizarFechaHora();
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

    private void MenuItem_Click(object? sender, EventArgs e)
    {
        if (sender is ToolStripMenuItem item)
        {
            lblStatusEstado.Text = $"Accediendo a: {item.Text}";
            MessageBox.Show(
                $"El módulo '{item.Text}' está en proceso de integración.",
                "Módulo en Desarrollo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

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
