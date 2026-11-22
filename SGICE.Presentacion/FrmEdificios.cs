using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;

namespace SGICE.Presentacion;

public partial class FrmEdificios : Form
{
    private readonly EdificioServicios _servicio = new();
    private int _idSeleccionado = 0;

    public FrmEdificios()
    {
        InitializeComponent();
        UIHelper.EstilarDataGridView(dgvEdificios);
        UIHelper.EstilarBotonPrimario(btnGuardar);
        UIHelper.EstilarBotonSecundario(btnNuevo);
        UIHelper.EstilarBotonSecundario(btnCancelar);
        UIHelper.EstilarBotonSecundario(btnBuscar);
    }

    private void FrmEdificios_Load(object? sender, EventArgs e)
    {
        CargarDatos();
    }

    private void CargarDatos(string? criterio = null)
    {
        try
        {
            IEnumerable<EdificioDTO> datos;
            if (string.IsNullOrWhiteSpace(criterio))
            {
                datos = _servicio.Listar();
            }
            else
            {
                datos = _servicio.BuscarPorNombre(criterio);
            }

            dgvEdificios.DataSource = datos.ToList();

            if (dgvEdificios.Columns["IdEdificio"] != null)
                dgvEdificios.Columns["IdEdificio"].HeaderText = "Id";
            if (dgvEdificios.Columns["CodEdificio"] != null)
                dgvEdificios.Columns["CodEdificio"].HeaderText = "Código";
            if (dgvEdificios.Columns["Nombre"] != null)
                dgvEdificios.Columns["Nombre"].HeaderText = "Edificio";
            if (dgvEdificios.Columns["CantidadPisos"] != null)
                dgvEdificios.Columns["CantidadPisos"].HeaderText = "Pisos";
            if (dgvEdificios.Columns["Descripcion"] != null)
                dgvEdificios.Columns["Descripcion"].HeaderText = "Descripción";
            if (dgvEdificios.Columns["Estado"] != null)
                dgvEdificios.Columns["Estado"].HeaderText = "Estado";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar edificios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvEdificios_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvEdificios.CurrentRow?.DataBoundItem is EdificioDTO dto)
        {
            _idSeleccionado = dto.IdEdificio;
            txtCodigo.Text = dto.CodEdificio;
            txtNombre.Text = dto.Nombre;
            txtPisos.Text = dto.CantidadPisos;
            txtDescripcion.Text = dto.Descripcion;
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
        txtCodigo.Clear();
        txtNombre.Clear();
        txtPisos.Clear();
        txtDescripcion.Clear();
        errorProvider.Clear();
        txtCodigo.Focus();
    }

    private bool ValidarCampos()
    {
        bool valido = true;
        errorProvider.Clear();

        if (string.IsNullOrWhiteSpace(txtCodigo.Text))
        {
            errorProvider.SetError(txtCodigo, "El código del edificio es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider.SetError(txtNombre, "El nombre del edificio es obligatorio.");
            valido = false;
        }

        if (!int.TryParse(txtPisos.Text.Trim(), out int pisos) || pisos <= 0)
        {
            errorProvider.SetError(txtPisos, "La cantidad de pisos debe ser un número entero mayor a cero.");
            valido = false;
        }

        return valido;
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos()) return;

        try
        {
            int pisos = int.Parse(txtPisos.Text.Trim());

            if (_idSeleccionado == 0)
            {
                var nuevo = new Edificio
                {
                    CodEdificio = txtCodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    CantidadPisos = pisos,
                    Descripcion = txtDescripcion.Text.Trim(),
                    EstadoId = 1
                };
                _servicio.Agregar(nuevo);
                MessageBox.Show("Edificio creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existente = _servicio.ObtenerPorId(_idSeleccionado);
                existente.CodEdificio = txtCodigo.Text.Trim();
                existente.Nombre = txtNombre.Text.Trim();
                existente.CantidadPisos = pisos;
                existente.Descripcion = txtDescripcion.Text.Trim();

                _servicio.Actualizar(existente);
                MessageBox.Show("Edificio actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show($"Error al guardar edificio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
