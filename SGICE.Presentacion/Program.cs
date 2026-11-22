using SGICE.Negocio.Seguridad;

namespace SGICE.Presentacion;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        while (true)
        {
            using var login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                using var principal = new FrmPrincipal();
                Application.Run(principal);

                if (SesionActual.ReiniciarSesion)
                {
                    SesionActual.ReiniciarSesion = false;
                    SesionActual.CerrarSesion();
                    continue;
                }
            }
            break;
        }
    }
}

// SGICE 100% C#
