using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;

namespace SGICE.Presentacion;

public partial class FrmProveedores : Form
{
    private readonly ProveedorServicios _servicio = new();
    private int _idSeleccionado = 0;

    public FrmProveedores()
    {
        InitializeComponent();
        UIHelper.EstilarDataGridView(dgvProveedores);
        UIHelper.EstilarBotonPrimario(btnGuardar);
        UIHelper.EstilarBotonSecundario(btnNuevo);
        UIHelper.EstilarBotonSecundario(btnCancelar);
        UIHelper.EstilarBotonSecundario(btnBuscar);
    }

    private void FrmProveedores_Load(object? sender, EventArgs e)
    {
        CargarDatos();
    }

    private void CargarDatos(string? criterio = null)
    {
        try
        {
            IEnumerable<ProveedorDTO> datos;
            if (string.IsNullOrWhiteSpace(criterio))
            {
                datos = _servicio.Listar();
            }
            else
            {
                datos = _servicio.BuscarPorNombre(criterio);
            }

            dgvProveedores.DataSource = datos.ToList();

            if (dgvProveedores.Columns["IdProveedor"] != null)
                dgvProveedores.Columns["IdProveedor"].HeaderText = "Código";
            if (dgvProveedores.Columns["RNC"] != null)
                dgvProveedores.Columns["RNC"].HeaderText = "RNC";
            if (dgvProveedores.Columns["Nombre"] != null)
                dgvProveedores.Columns["Nombre"].HeaderText = "Proveedor";
            if (dgvProveedores.Columns["Telefono"] != null)
                dgvProveedores.Columns["Telefono"].HeaderText = "Teléfono";
            if (dgvProveedores.Columns["Correo"] != null)
                dgvProveedores.Columns["Correo"].HeaderText = "Correo";
            if (dgvProveedores.Columns["PersonalContacto"] != null)
                dgvProveedores.Columns["PersonalContacto"].HeaderText = "Contacto";
            if (dgvProveedores.Columns["Direccion"] != null)
                dgvProveedores.Columns["Direccion"].HeaderText = "Dirección";
            if (dgvProveedores.Columns["Estado"] != null)
                dgvProveedores.Columns["Estado"].HeaderText = "Estado";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvProveedores_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvProveedores.CurrentRow?.DataBoundItem is ProveedorDTO dto)
        {
            _idSeleccionado = dto.IdProveedor;
            txtRNC.Text = dto.RNC;
            txtNombre.Text = dto.Nombre;
            txtTelefono.Text = dto.Telefono;
            txtCorreo.Text = dto.Correo;
            txtContacto.Text = dto.PersonalContacto;
            txtDireccion.Text = dto.Direccion;
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
        txtRNC.Clear();
        txtNombre.Clear();
        txtTelefono.Clear();
        txtCorreo.Clear();
        txtContacto.Clear();
        txtDireccion.Clear();
        errorProvider.Clear();
        txtRNC.Focus();
    }

    private bool ValidarCampos()
    {
        bool valido = true;
        errorProvider.Clear();

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider.SetError(txtNombre, "El nombre o razón social es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtTelefono.Text))
        {
            errorProvider.SetError(txtTelefono, "El teléfono es obligatorio.");
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
                var nuevo = new Proveedor
                {
                    RNC = txtRNC.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    PersonalContacto = txtContacto.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    EstadoId = 1
                };
                _servicio.Agregar(nuevo);
                MessageBox.Show("Proveedor registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existente = _servicio.ObtenerPorId(_idSeleccionado);
                existente.RNC = txtRNC.Text.Trim();
                existente.Nombre = txtNombre.Text.Trim();
                existente.Telefono = txtTelefono.Text.Trim();
                existente.Correo = txtCorreo.Text.Trim();
                existente.PersonalContacto = txtContacto.Text.Trim();
                existente.Direccion = txtDireccion.Text.Trim();

                _servicio.Actualizar(existente);
                MessageBox.Show("Proveedor actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show($"Error al guardar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void lblNombre_Click(object sender, EventArgs e)
    {

    }
}
