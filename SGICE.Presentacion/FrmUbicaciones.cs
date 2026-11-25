using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;

namespace SGICE.Presentacion;

public partial class FrmUbicaciones : Form
{
    private readonly UbicacionServicios _servicio = new();
    private readonly EdificioServicios _edificioServicio = new();
    private int _idSeleccionado = 0;

    public FrmUbicaciones()
    {
        InitializeComponent();
        UIHelper.EstilarDataGridView(dgvUbicaciones);
        UIHelper.EstilarBotonPrimario(btnGuardar);
        UIHelper.EstilarBotonSecundario(btnNuevo);
        UIHelper.EstilarBotonSecundario(btnCancelar);
        UIHelper.EstilarBotonSecundario(btnBuscar);
    }

    private void FrmUbicaciones_Load(object? sender, EventArgs e)
    {
        CargarComboEdificios();
        CargarDatos();
    }

    private void CargarComboEdificios()
    {
        try
        {
            var edificios = _edificioServicio.ObtenerTodos().ToList();
            cmbEdificio.DataSource = edificios;
            cmbEdificio.DisplayMember = "Nombre";
            cmbEdificio.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar edificios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CargarDatos(string? criterio = null)
    {
        try
        {
            IEnumerable<UbicacionDTO> datos;
            if (string.IsNullOrWhiteSpace(criterio))
            {
                datos = _servicio.Listar();
            }
            else
            {
                datos = _servicio.BuscarPorNombre(criterio);
            }

            dgvUbicaciones.DataSource = datos.ToList();

            if (dgvUbicaciones.Columns["IdUbicacion"] != null)
                dgvUbicaciones.Columns["IdUbicacion"].HeaderText = "Código";
            if (dgvUbicaciones.Columns["Edificio"] != null)
                dgvUbicaciones.Columns["Edificio"].HeaderText = "Edificio";
            if (dgvUbicaciones.Columns["Nombre"] != null)
                dgvUbicaciones.Columns["Nombre"].HeaderText = "Ubicación";
            if (dgvUbicaciones.Columns["Piso"] != null)
                dgvUbicaciones.Columns["Piso"].HeaderText = "Piso";
            if (dgvUbicaciones.Columns["Dimencion"] != null)
                dgvUbicaciones.Columns["Dimencion"].HeaderText = "Dimensión";
            if (dgvUbicaciones.Columns["Descripcion"] != null)
                dgvUbicaciones.Columns["Descripcion"].HeaderText = "Descripción";
            if (dgvUbicaciones.Columns["Estado"] != null)
                dgvUbicaciones.Columns["Estado"].HeaderText = "Estado";
            if (dgvUbicaciones.Columns["EdificioId"] != null)
                dgvUbicaciones.Columns["EdificioId"].Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar ubicaciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvUbicaciones_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvUbicaciones.CurrentRow?.DataBoundItem is UbicacionDTO dto)
        {
            _idSeleccionado = dto.IdUbicacion;
            txtNombre.Text = dto.Nombre;
            txtPiso.Text = dto.Piso.ToString();
            txtDimension.Text = dto.Dimencion;
            txtDescripcion.Text = dto.Descripcion;
            if (dto.EdificioId > 0)
            {
                cmbEdificio.SelectedValue = dto.EdificioId;
            }
            errorProvider.Clear();
        }
    }

    private void BtnNuevo_Click(object? sender, EventArgs e)
    {
        LimpiarFormulario();
    }

    private void BtnCancelar_Click(object? sender, EventArgs e)
    {
        LimpiarFormulario();
    }

    private void LimpiarFormulario()
    {
        _idSeleccionado = 0;
        txtNombre.Clear();
        txtPiso.Clear();
        txtDimension.Clear();
        txtDescripcion.Clear();
        errorProvider.Clear();
        txtNombre.Focus();
    }

    private bool ValidarCampos()
    {
        bool valido = true;
        errorProvider.Clear();

        if (cmbEdificio.SelectedValue == null)
        {
            errorProvider.SetError(cmbEdificio, "Seleccione el edificio al que pertenece la ubicación.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider.SetError(txtNombre, "El nombre de la ubicación es obligatorio.");
            valido = false;
        }

        if (!int.TryParse(txtPiso.Text.Trim(), out int piso) || piso < 0)
        {
            errorProvider.SetError(txtPiso, "El piso debe ser un número entero (0 para planta baja).");
            valido = false;
        }

        return valido;
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos()) return;

        try
        {
            int edificioId = (int)cmbEdificio.SelectedValue!;
            int piso = int.Parse(txtPiso.Text.Trim());

            if (_idSeleccionado == 0)
            {
                var nueva = new Ubicacion
                {
                    EdificioId = edificioId,
                    Nombre = txtNombre.Text.Trim(),
                    Piso = piso,
                    Dimencion = txtDimension.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    EstadoId = 1
                };
                _servicio.Agregar(nueva);
                MessageBox.Show("Ubicación registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existente = _servicio.ObtenerPorId(_idSeleccionado);
                existente.EdificioId = edificioId;
                existente.Nombre = txtNombre.Text.Trim();
                existente.Piso = piso;
                existente.Dimencion = txtDimension.Text.Trim();
                existente.Descripcion = txtDescripcion.Text.Trim();

                _servicio.Actualizar(existente);
                MessageBox.Show("Ubicación actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CargarDatos(txtBuscar.Text);
            LimpiarFormulario();
        }
        catch (NegocioExcepcion ex)
        {
            MessageBox.Show(ex.Message, "Validación de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al guardar ubicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void TxtBuscar_TextChanged(object? sender, EventArgs e)
    {
        CargarDatos(txtBuscar.Text);
    }

    private void BtnBuscar_Click(object? sender, EventArgs e)
    {
        CargarDatos(txtBuscar.Text);
    }

    private void pnlTop_Paint(object sender, PaintEventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void txtNombre_TextChanged(object sender, EventArgs e)
    {

    }
}
