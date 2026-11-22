using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;

namespace SGICE.Presentacion;

public partial class FrmSubCategorias : Form
{
    private readonly SubCategoriaServicios _servicio = new();
    private readonly CategoriaServicios _categoriaServicio = new();
    private int _idSeleccionado = 0;

    public FrmSubCategorias()
    {
        InitializeComponent();
        UIHelper.EstilarDataGridView(dgvSubCategorias);
        UIHelper.EstilarBotonPrimario(btnGuardar);
        UIHelper.EstilarBotonSecundario(btnNuevo);
        UIHelper.EstilarBotonSecundario(btnCancelar);
        UIHelper.EstilarBotonSecundario(btnBuscar);
    }

    private void FrmSubCategorias_Load(object? sender, EventArgs e)
    {
        CargarComboCategorias();
        CargarDatos();
    }

    private void CargarComboCategorias()
    {
        try
        {
            var categorias = _categoriaServicio.ObtenerTodos().ToList();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CargarDatos(string? criterio = null)
    {
        try
        {
            IEnumerable<SubCategoriaDTO> datos;
            if (string.IsNullOrWhiteSpace(criterio))
            {
                datos = _servicio.Listar();
            }
            else
            {
                datos = _servicio.BuscarPorNombre(criterio);
            }

            dgvSubCategorias.DataSource = datos.ToList();

            if (dgvSubCategorias.Columns["IdSubCategoria"] != null)
                dgvSubCategorias.Columns["IdSubCategoria"].HeaderText = "Código";
            if (dgvSubCategorias.Columns["Categoria"] != null)
                dgvSubCategorias.Columns["Categoria"].HeaderText = "Categoría Principal";
            if (dgvSubCategorias.Columns["Nombre"] != null)
                dgvSubCategorias.Columns["Nombre"].HeaderText = "Subcategoría";
            if (dgvSubCategorias.Columns["VidaUtil"] != null)
                dgvSubCategorias.Columns["VidaUtil"].HeaderText = "Vida Útil (Años)";
            if (dgvSubCategorias.Columns["Descripcion"] != null)
                dgvSubCategorias.Columns["Descripcion"].HeaderText = "Descripción";
            if (dgvSubCategorias.Columns["CategoriaId"] != null)
                dgvSubCategorias.Columns["CategoriaId"].Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar subcategorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvSubCategorias_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvSubCategorias.CurrentRow?.DataBoundItem is SubCategoriaDTO dto)
        {
            _idSeleccionado = dto.IdSubCategoria;
            txtNombre.Text = dto.Nombre;
            txtVidaUtil.Text = dto.VidaUtil.ToString();
            txtDescripcion.Text = dto.Descripcion;
            if (dto.CategoriaId > 0)
            {
                cmbCategoria.SelectedValue = dto.CategoriaId;
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
        txtVidaUtil.Clear();
        txtDescripcion.Clear();
        errorProvider.Clear();
        txtNombre.Focus();
    }

    private bool ValidarCampos()
    {
        bool valido = true;
        errorProvider.Clear();

        if (cmbCategoria.SelectedValue == null)
        {
            errorProvider.SetError(cmbCategoria, "Seleccione la categoría principal.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider.SetError(txtNombre, "El nombre de la subcategoría es obligatorio.");
            valido = false;
        }

        if (!int.TryParse(txtVidaUtil.Text.Trim(), out int vidaUtil) || vidaUtil <= 0)
        {
            errorProvider.SetError(txtVidaUtil, "La vida útil debe ser un número entero mayor a cero.");
            valido = false;
        }

        return valido;
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos()) return;

        try
        {
            int categoriaId = (int)cmbCategoria.SelectedValue!;
            int vidaUtil = int.Parse(txtVidaUtil.Text.Trim());

            if (_idSeleccionado == 0)
            {
                var nueva = new SubCategoria
                {
                    CategoriaId = categoriaId,
                    Nombre = txtNombre.Text.Trim(),
                    VidaUtil = vidaUtil,
                    Descripcion = txtDescripcion.Text.Trim(),
                    EstadoId = 1
                };
                _servicio.Agregar(nueva);
                MessageBox.Show("Subcategoría creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existente = _servicio.ObtenerPorId(_idSeleccionado);
                existente.CategoriaId = categoriaId;
                existente.Nombre = txtNombre.Text.Trim();
                existente.VidaUtil = vidaUtil;
                existente.Descripcion = txtDescripcion.Text.Trim();

                _servicio.Actualizar(existente);
                MessageBox.Show("Subcategoría actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show($"Error al guardar subcategoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
