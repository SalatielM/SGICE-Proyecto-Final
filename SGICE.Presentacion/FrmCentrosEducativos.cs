using SGICE.Entidades;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;

namespace SGICE.Presentacion;

public partial class FrmCentrosEducativos : Form
{
    private readonly CentroEducativoServicios _servicio = new();
    private readonly DirectorServicios _directorServicio = new();

    public FrmCentrosEducativos()
    {
        InitializeComponent();
    }

    private void FrmCentrosEducativos_Load(object? sender, EventArgs e)
    {
        CargarDirectores();
        CargarDatos();
    }

    private void CargarDirectores()
    {
        try
        {
            var directores = _directorServicio.ObtenerActivos().ToList();
            if (!directores.Any())
            {
                directores = _directorServicio.ObtenerTodos().ToList();
            }

            cmbDirector.DataSource = directores;
            cmbDirector.DisplayMember = "Nombre";
            cmbDirector.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar directores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CargarDatos()
    {
        try
        {
            var centro = _servicio.ObtenerInfoCentro();
            txtNombre.Text = centro.Nombre;
            txtCodigo.Text = centro.CodCentro;
            txtTelefono.Text = centro.Telefono;
            txtCorreo.Text = centro.Correo;
            txtDireccion.Text = centro.Direccion;
            txtDistrito.Text = centro.DistritoEducativo;
            txtRegional.Text = centro.RegionalEducativo;

            errorProvider.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar datos del centro educativo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidarCampos()
    {
        bool valido = true;
        errorProvider.Clear();

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider.SetError(txtNombre, "El nombre del centro es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtCodigo.Text))
        {
            errorProvider.SetError(txtCodigo, "El código del centro es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtTelefono.Text))
        {
            errorProvider.SetError(txtTelefono, "El teléfono del centro es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtDireccion.Text))
        {
            errorProvider.SetError(txtDireccion, "La dirección del centro es obligatoria.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtDistrito.Text))
        {
            errorProvider.SetError(txtDistrito, "El distrito educativo es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtRegional.Text))
        {
            errorProvider.SetError(txtRegional, "La regional educativa es obligatoria.");
            valido = false;
        }

        if (cmbDirector.SelectedValue == null)
        {
            errorProvider.SetError(cmbDirector, "Seleccione el director institucional.");
            valido = false;
        }

        return valido;
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos()) return;

        try
        {
            int directorId = (int)cmbDirector.SelectedValue!;

            var entidad = new CentroEducativo
            {
                Nombre = txtNombre.Text.Trim(),
                CodCentro = txtCodigo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                DistritoEducativo = txtDistrito.Text.Trim(),
                RegionalEducativo = txtRegional.Text.Trim(),
                DirectorId = directorId,
                EstadoId = 1
            };

            _servicio.GuardarCentro(entidad);
            MessageBox.Show("Información institucional guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
        }
        catch (NegocioExcepcion ex)
        {
            MessageBox.Show(ex.Message, "Validación de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al guardar información institucional: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnRecargar_Click(object? sender, EventArgs e)
    {
        CargarDatos();
    }
}
