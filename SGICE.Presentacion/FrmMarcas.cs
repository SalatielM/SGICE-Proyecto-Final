using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;

namespace SGICE.Presentacion;

public partial class FrmMarcas : Form
{
    private readonly MarcaServicios _servicio = new();
    private int _idSeleccionado = 0;

    public FrmMarcas()
    {
        InitializeComponent();
    }

    private void FrmMarcas_Load(object? sender, EventArgs e)
    {
        CargarDatos();
    }

    private void CargarDatos(string? criterio = null)
    {
        try
        {
            IEnumerable<MarcaDTO> datos;
            if (string.IsNullOrWhiteSpace(criterio))
            {
                datos = _servicio.Listar();
            }
            else
            {
                datos = _servicio.BuscarPorNombre(criterio);
            }

            dgvMarcas.DataSource = datos.ToList();

            if (dgvMarcas.Columns["IdMarca"] != null)
                dgvMarcas.Columns["IdMarca"].HeaderText = "Código";
            if (dgvMarcas.Columns["Nombre"] != null)
                dgvMarcas.Columns["Nombre"].HeaderText = "Marca";
            if (dgvMarcas.Columns["Descripcion"] != null)
                dgvMarcas.Columns["Descripcion"].HeaderText = "Descripción";
            if (dgvMarcas.Columns["Estado"] != null)
                dgvMarcas.Columns["Estado"].HeaderText = "Estado";

            foreach (var col in new[] { "FechaCreacion", "FechaActualizacion", "UsuarioRegistroId", "UsuarioRegistro", "UsuarioActualizacionId", "UsuarioActualizacion", "EstadoId" })
            {
                if (dgvMarcas.Columns[col] != null)
                    dgvMarcas.Columns[col].Visible = false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar marcas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvMarcas_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvMarcas.CurrentRow?.DataBoundItem is MarcaDTO dto)
        {
            _idSeleccionado = dto.IdMarca;
            txtNombre.Text = dto.Nombre;
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
        txtNombre.Clear();
        txtDescripcion.Clear();
        errorProvider.Clear();
        txtNombre.Focus();
    }

    private bool ValidarCampos()
    {
        bool valido = true;
        errorProvider.Clear();

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider.SetError(txtNombre, "El nombre de la marca es obligatorio.");
            valido = false;
        }

        return valido;
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos()) return;

        try
        {
            if (_idSeleccionado == 0)
            {
                var nueva = new Marca
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    EstadoId = 1
                };
                _servicio.Agregar(nueva);
                MessageBox.Show("Marca registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existente = _servicio.ObtenerPorId(_idSeleccionado);
                existente.Nombre = txtNombre.Text.Trim();
                existente.Descripcion = txtDescripcion.Text.Trim();

                _servicio.Actualizar(existente);
                MessageBox.Show("Marca actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show($"Error al guardar marca: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
