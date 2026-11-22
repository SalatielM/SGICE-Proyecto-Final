using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;

namespace SGICE.Presentacion;

public partial class FrmActivos : Form
{
    private readonly ActivoServicios _servicio = new();
    private readonly SubCategoriaServicios _subCatServicio = new();
    private readonly MarcaServicios _marcaServicio = new();
    private readonly ProveedorServicios _proveedorServicio = new();
    private readonly PersonalServicios _personalServicio = new();
    private int _idSeleccionado = 0;

    public FrmActivos()
    {
        InitializeComponent();
        UIHelper.EstilarDataGridView(dgvActivos);
        UIHelper.EstilarBotonPrimario(btnGuardar);
        UIHelper.EstilarBotonSecundario(btnNuevo);
        UIHelper.EstilarBotonSecundario(btnCancelar);
        UIHelper.EstilarBotonSecundario(btnBuscar);
    }

    private void FrmActivos_Load(object? sender, EventArgs e)
    {
        CargarCombos();
        CargarDatos();
    }

    private void CargarCombos()
    {
        try
        {
            var subCats = _subCatServicio.ObtenerTodos().ToList();
            cmbSubCategoria.DataSource = subCats;
            cmbSubCategoria.DisplayMember = "Nombre";
            cmbSubCategoria.ValueMember = "Id";

            var marcas = _marcaServicio.ObtenerTodo().ToList();
            cmbMarca.DataSource = marcas;
            cmbMarca.DisplayMember = "Nombre";
            cmbMarca.ValueMember = "Id";

            var proveedores = _proveedorServicio.ObtenerTodos().ToList();
            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id";

            var personal = _personalServicio.ObtenerTodos().ToList();
            cmbPersonal.DataSource = personal;
            cmbPersonal.DisplayMember = "Nombre";
            cmbPersonal.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar catálogos auxiliares: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CargarDatos(string? criterio = null)
    {
        try
        {
            IEnumerable<ActivoDTO> datos;
            if (string.IsNullOrWhiteSpace(criterio))
            {
                datos = _servicio.Listar();
            }
            else
            {
                datos = _servicio.BuscarPorNombre(criterio);
            }

            dgvActivos.DataSource = datos.ToList();

            if (dgvActivos.Columns["IdActivo"] != null)
                dgvActivos.Columns["IdActivo"].HeaderText = "Código";
            if (dgvActivos.Columns["Nombre"] != null)
                dgvActivos.Columns["Nombre"].HeaderText = "Activo";
            if (dgvActivos.Columns["SubCategoria"] != null)
                dgvActivos.Columns["SubCategoria"].HeaderText = "Subcategoría";
            if (dgvActivos.Columns["Marca"] != null)
                dgvActivos.Columns["Marca"].HeaderText = "Marca";
            if (dgvActivos.Columns["Proveedor"] != null)
                dgvActivos.Columns["Proveedor"].HeaderText = "Proveedor";
            if (dgvActivos.Columns["PersonalEncargado"] != null)
                dgvActivos.Columns["PersonalEncargado"].HeaderText = "Encargado";
            if (dgvActivos.Columns["Estado"] != null)
                dgvActivos.Columns["Estado"].HeaderText = "Estado";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar activos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvActivos_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvActivos.CurrentRow?.DataBoundItem is ActivoDTO dto)
        {
            _idSeleccionado = dto.IdActivo;
            txtNombre.Text = dto.Nombre;
            txtDescripcion.Text = dto.Descripcion;

            if (dto.SubCategoriaId > 0) cmbSubCategoria.SelectedValue = dto.SubCategoriaId;
            if (dto.MarcaId > 0) cmbMarca.SelectedValue = dto.MarcaId;
            if (dto.ProveedorId > 0) cmbProveedor.SelectedValue = dto.ProveedorId;
            if (dto.PersonalId > 0) cmbPersonal.SelectedValue = dto.PersonalId;

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
            errorProvider.SetError(txtNombre, "El nombre del activo es obligatorio.");
            valido = false;
        }

        if (cmbSubCategoria.SelectedValue == null)
        {
            errorProvider.SetError(cmbSubCategoria, "Seleccione la subcategoría.");
            valido = false;
        }

        if (cmbMarca.SelectedValue == null)
        {
            errorProvider.SetError(cmbMarca, "Seleccione la marca.");
            valido = false;
        }

        if (cmbProveedor.SelectedValue == null)
        {
            errorProvider.SetError(cmbProveedor, "Seleccione el proveedor.");
            valido = false;
        }

        if (cmbPersonal.SelectedValue == null)
        {
            errorProvider.SetError(cmbPersonal, "Seleccione el personal encargado.");
            valido = false;
        }

        return valido;
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos()) return;

        try
        {
            int subCatId = (int)cmbSubCategoria.SelectedValue!;
            int marcaId = (int)cmbMarca.SelectedValue!;
            int proveedorId = (int)cmbProveedor.SelectedValue!;
            int personalId = (int)cmbPersonal.SelectedValue!;

            if (_idSeleccionado == 0)
            {
                var nuevo = new Activo
                {
                    Nombre = txtNombre.Text.Trim(),
                    SubCategoriaId = subCatId,
                    MarcaId = marcaId,
                    ProveedorId = proveedorId,
                    PersonalEncargadoId = personalId,
                    Descripcion = txtDescripcion.Text.Trim(),
                    EstadoId = 1
                };
                _servicio.Agregar(nuevo);
                MessageBox.Show("Activo registrado con éxito en el catálogo maestro.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existente = _servicio.ObtenerPorId(_idSeleccionado);
                existente.Nombre = txtNombre.Text.Trim();
                existente.SubCategoriaId = subCatId;
                existente.MarcaId = marcaId;
                existente.ProveedorId = proveedorId;
                existente.PersonalEncargadoId = personalId;
                existente.Descripcion = txtDescripcion.Text.Trim();

                _servicio.Actualizar(existente);
                MessageBox.Show("Activo actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show($"Error al guardar activo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
