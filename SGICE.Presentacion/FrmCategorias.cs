using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;

namespace SGICE.Presentacion;

public partial class FrmCategorias : Form
{
    private readonly CategoriaServicios _servicio = new();
    private int _idSeleccionado = 0;

    public FrmCategorias()
    {
        InitializeComponent();
        UIHelper.EstilarDataGridView(dgvCategorias);
        UIHelper.EstilarBotonPrimario(btnGuardar);
        UIHelper.EstilarBotonSecundario(btnNuevo);
        UIHelper.EstilarBotonSecundario(btnCancelar);
        UIHelper.EstilarBotonSecundario(btnBuscar);
    }

    private void FrmCategorias_Load(object? sender, EventArgs e)
    {
        CargarDatos();
    }

    private void CargarDatos(string? criterio = null)
    {
        try
        {
            IEnumerable<CategoriaDTO> datos;
            if (string.IsNullOrWhiteSpace(criterio))
            {
                datos = _servicio.Listar();
            }
            else
            {
                datos = _servicio.BuscarPorNombre(criterio);
            }

            dgvCategorias.DataSource = datos.ToList();

            if (dgvCategorias.Columns["IdCategoria"] != null)
                dgvCategorias.Columns["IdCategoria"].HeaderText = "Código";
            if (dgvCategorias.Columns["Nombre"] != null)
                dgvCategorias.Columns["Nombre"].HeaderText = "Categoría";
            if (dgvCategorias.Columns["VidaUtil"] != null)
                dgvCategorias.Columns["VidaUtil"].HeaderText = "Vida Útil";
            if (dgvCategorias.Columns["Descripcion"] != null)
                dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";
            if (dgvCategorias.Columns["FechaRegistro"] != null)
                dgvCategorias.Columns["FechaRegistro"].HeaderText = "Fecha Reg.";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvCategorias_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvCategorias.CurrentRow?.DataBoundItem is CategoriaDTO dto)
        {
            _idSeleccionado = dto.IdCategoria;
            txtNombre.Text = dto.Nombre;
            txtVidaUtil.Text = dto.VidaUtil;
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
        txtVidaUtil.Clear();
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
            errorProvider.SetError(txtNombre, "El nombre de la categoría es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtVidaUtil.Text))
        {
            errorProvider.SetError(txtVidaUtil, "Especifique la vida útil estimada.");
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
                var nueva = new Categoria
                {
                    Nombre = txtNombre.Text.Trim(),
                    VidaUtil = txtVidaUtil.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    EstadoId = 1
                };
                _servicio.Agregar(nueva);
                MessageBox.Show("Categoría creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existente = _servicio.ObtenerPorId(_idSeleccionado);
                existente.Nombre = txtNombre.Text.Trim();
                existente.VidaUtil = txtVidaUtil.Text.Trim();
                existente.Descripcion = txtDescripcion.Text.Trim();

                _servicio.Actualizar(existente);
                MessageBox.Show("Categoría actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show($"Error al guardar categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
