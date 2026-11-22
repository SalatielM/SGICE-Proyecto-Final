using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;

namespace SGICE.Presentacion;

public partial class FrmPersonal : Form
{
    private readonly PersonalServicios _servicio = new();
    private readonly PuestoServicios _puestoServicio = new();
    private int _idSeleccionado = 0;

    public FrmPersonal()
    {
        InitializeComponent();
        UIHelper.EstilarDataGridView(dgvPersonal);
        UIHelper.EstilarBotonPrimario(btnGuardar);
        UIHelper.EstilarBotonSecundario(btnNuevo);
        UIHelper.EstilarBotonSecundario(btnCancelar);
        UIHelper.EstilarBotonSecundario(btnBuscar);
    }

    private void FrmPersonal_Load(object? sender, EventArgs e)
    {
        CargarComboPuestos();
        CargarDatos();
    }

    private void CargarComboPuestos()
    {
        try
        {
            var puestos = _puestoServicio.ObtenerTodos().ToList();
            cmbPuesto.DataSource = puestos;
            cmbPuesto.DisplayMember = "Nombre";
            cmbPuesto.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar puestos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CargarDatos(string? criterio = null)
    {
        try
        {
            IEnumerable<PersonalDTO> datos;
            if (string.IsNullOrWhiteSpace(criterio))
            {
                datos = _servicio.Listar();
            }
            else
            {
                datos = _servicio.BuscarPorNombre(criterio);
            }

            dgvPersonal.DataSource = datos.ToList();

            if (dgvPersonal.Columns["IdPersonal"] != null)
                dgvPersonal.Columns["IdPersonal"].HeaderText = "Código";
            if (dgvPersonal.Columns["CodPersonal"] != null)
                dgvPersonal.Columns["CodPersonal"].HeaderText = "No. Empleado";
            if (dgvPersonal.Columns["Nombre"] != null)
                dgvPersonal.Columns["Nombre"].HeaderText = "Nombre";
            if (dgvPersonal.Columns["Apellido"] != null)
                dgvPersonal.Columns["Apellido"].HeaderText = "Apellido";
            if (dgvPersonal.Columns["Cedula"] != null)
                dgvPersonal.Columns["Cedula"].HeaderText = "Cédula";
            if (dgvPersonal.Columns["Telefono"] != null)
                dgvPersonal.Columns["Telefono"].HeaderText = "Teléfono";
            if (dgvPersonal.Columns["Correo"] != null)
                dgvPersonal.Columns["Correo"].HeaderText = "Correo";
            if (dgvPersonal.Columns["Puesto"] != null)
                dgvPersonal.Columns["Puesto"].HeaderText = "Puesto";
            if (dgvPersonal.Columns["Estado"] != null)
                dgvPersonal.Columns["Estado"].HeaderText = "Estado";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar personal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvPersonal_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvPersonal.CurrentRow?.DataBoundItem is PersonalDTO dto)
        {
            _idSeleccionado = dto.IdPersonal;
            txtCodigo.Text = dto.CodPersonal;
            txtNombre.Text = dto.Nombre;
            txtApellido.Text = dto.Apellido;
            txtCedula.Text = dto.Cedula;
            txtTelefono.Text = dto.Telefono;
            txtCorreo.Text = dto.Correo;

            if (dto.PuestoId > 0)
            {
                cmbPuesto.SelectedValue = dto.PuestoId;
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
        txtCodigo.Clear();
        txtNombre.Clear();
        txtApellido.Clear();
        txtCedula.Clear();
        txtTelefono.Clear();
        txtCorreo.Clear();
        errorProvider.Clear();
        txtCodigo.Focus();
    }

    private bool ValidarCampos()
    {
        bool valido = true;
        errorProvider.Clear();

        if (string.IsNullOrWhiteSpace(txtCodigo.Text))
        {
            errorProvider.SetError(txtCodigo, "El código del personal es requerido.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider.SetError(txtNombre, "El nombre es requerido.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtApellido.Text))
        {
            errorProvider.SetError(txtApellido, "El apellido es requerido.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtCedula.Text))
        {
            errorProvider.SetError(txtCedula, "La cédula es requerida.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtTelefono.Text))
        {
            errorProvider.SetError(txtTelefono, "El teléfono es requerido.");
            valido = false;
        }

        if (cmbPuesto.SelectedValue == null)
        {
            errorProvider.SetError(cmbPuesto, "Seleccione el puesto de trabajo.");
            valido = false;
        }

        return valido;
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos()) return;

        try
        {
            int puestoId = (int)cmbPuesto.SelectedValue!;

            if (_idSeleccionado == 0)
            {
                var nuevo = new Personal
                {
                    CodPersonal = txtCodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Cedula = txtCedula.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    PuestoId = puestoId,
                    EstadoId = 1
                };
                _servicio.Agregar(nuevo);
                MessageBox.Show("Personal escolar registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existente = _servicio.ObtenerPorId(_idSeleccionado);
                existente.CodPersonal = txtCodigo.Text.Trim();
                existente.Nombre = txtNombre.Text.Trim();
                existente.Apellido = txtApellido.Text.Trim();
                existente.Cedula = txtCedula.Text.Trim();
                existente.Telefono = txtTelefono.Text.Trim();
                existente.Correo = txtCorreo.Text.Trim();
                existente.PuestoId = puestoId;

                _servicio.Actualizar(existente);
                MessageBox.Show("Personal actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show($"Error al guardar personal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
