using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;

namespace SGICE.Presentacion;

public partial class FrmLogin : Form
{
    private readonly UsuarioServicios _usuarioServicios = new();

    public FrmLogin()
    {
        InitializeComponent();
    }

    private void BtnIngresar_Click(object? sender, EventArgs e)
    {
        string usuario = txtUsuario.Text.Trim();
        string clave = txtClave.Text;

        lblMensaje.Visible = false;

        if (string.IsNullOrWhiteSpace(usuario))
        {
            MostrarError("Por favor, ingrese su nombre de usuario.");
            txtUsuario.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(clave))
        {
            MostrarError("Por favor, ingrese su contraseña.");
            txtClave.Focus();
            return;
        }

        try
        {
            Cursor = Cursors.WaitCursor;
            btnIngresar.Enabled = false;

            var usuarioAutenticado = _usuarioServicios.Autenticar(usuario, clave);
            SesionActual.IniciarSesion(usuarioAutenticado);

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (NegocioExcepcion ex)
        {
            MostrarError(ex.Message);
            txtClave.Clear();
            txtClave.Focus();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Ocurrió un error al intentar iniciar sesión:\n\n{ex.Message}",
                "Error de Autenticación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            Cursor = Cursors.Default;
            btnIngresar.Enabled = true;
        }
    }

    private void BtnCancelar_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void MostrarError(string mensaje)
    {
        lblMensaje.Text = mensaje;
        lblMensaje.Visible = true;
    }

    private void pnlContenedor_Paint(object sender, PaintEventArgs e)
    {

    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }
}
