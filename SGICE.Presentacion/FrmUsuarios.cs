using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;

namespace SGICE.Presentacion;

public partial class FrmUsuarios : Form
{
    private readonly UsuarioServicios _servicio = new();
    private readonly RolServicios _rolServicio = new();
    private int _idSeleccionado = 0;

    public FrmUsuarios()
    {
        InitializeComponent();
        UIHelper.EstilarDataGridView(dgvUsuarios);
        UIHelper.EstilarBotonPrimario(btnGuardar);
        UIHelper.EstilarBotonSecundario(btnNuevo);
        UIHelper.EstilarBotonSecundario(btnCancelar);
        UIHelper.EstilarBotonSecundario(btnBuscar);
    }

    private void FrmUsuarios_Load(object? sender, EventArgs e)
    {
        CargarComboRoles();
        CargarDatos();
    }

    private void CargarComboRoles()
    {
        try
        {
            var roles = _rolServicio.ObtenerTodos().ToList();
            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CargarDatos(string? criterio = null)
    {
        try
        {
            IEnumerable<UsuarioDTO> datos;
            if (string.IsNullOrWhiteSpace(criterio))
            {
                datos = _servicio.Listar();
            }
            else
            {
                datos = _servicio.BuscarPorNombre(criterio);
            }

            dgvUsuarios.DataSource = datos.ToList();

            if (dgvUsuarios.Columns["IdUsuario"] != null)
                dgvUsuarios.Columns["IdUsuario"].HeaderText = "Id";
            if (dgvUsuarios.Columns["NombreUsuario"] != null)
                dgvUsuarios.Columns["NombreUsuario"].HeaderText = "Usuario";
            if (dgvUsuarios.Columns["Nombre"] != null)
                dgvUsuarios.Columns["Nombre"].HeaderText = "Nombre";
            if (dgvUsuarios.Columns["Apellido"] != null)
                dgvUsuarios.Columns["Apellido"].HeaderText = "Apellido";
            if (dgvUsuarios.Columns["Cedula"] != null)
                dgvUsuarios.Columns["Cedula"].HeaderText = "Cédula";
            if (dgvUsuarios.Columns["Telefono"] != null)
                dgvUsuarios.Columns["Telefono"].HeaderText = "Teléfono";
            if (dgvUsuarios.Columns["Correo"] != null)
                dgvUsuarios.Columns["Correo"].HeaderText = "Correo";
            if (dgvUsuarios.Columns["Rol"] != null)
                dgvUsuarios.Columns["Rol"].HeaderText = "Rol";
            if (dgvUsuarios.Columns["Estado"] != null)
                dgvUsuarios.Columns["Estado"].HeaderText = "Estado";
            if (dgvUsuarios.Columns["Foto"] != null)
                dgvUsuarios.Columns["Foto"].Visible = false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvUsuarios_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvUsuarios.CurrentRow?.DataBoundItem is UsuarioDTO dto)
        {
            _idSeleccionado = dto.IdUsuario;
            txtNombreUsuario.Text = dto.NombreUsuario;
            txtNombreUsuario.Enabled = false; // no cambiar nombre de usuario al editar
            txtClave.Clear();
            txtNombre.Text = dto.Nombre;
            txtApellido.Text = dto.Apellido;
            txtCedula.Text = dto.Cedula;
            txtTelefono.Text = dto.Telefono;
            txtCorreo.Text = dto.Correo;

            if (dto.RolId > 0)
            {
                cmbRol.SelectedValue = dto.RolId;
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
        txtNombreUsuario.Enabled = true;
        txtNombreUsuario.Clear();
        txtClave.Clear();
        txtNombre.Clear();
        txtApellido.Clear();
        txtCedula.Clear();
        txtTelefono.Clear();
        txtCorreo.Clear();
        errorProvider.Clear();
        txtNombreUsuario.Focus();
    }

    private bool ValidarCampos()
    {
        bool valido = true;
        errorProvider.Clear();

        if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
        {
            errorProvider.SetError(txtNombreUsuario, "El nombre de usuario es obligatorio.");
            valido = false;
        }

        if (_idSeleccionado == 0 && string.IsNullOrWhiteSpace(txtClave.Text))
        {
            errorProvider.SetError(txtClave, "La contraseña es requerida para un nuevo usuario.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtApellido.Text))
        {
            errorProvider.SetError(txtApellido, "El apellido es obligatorio.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtCedula.Text))
        {
            errorProvider.SetError(txtCedula, "La cédula es obligatoria.");
            valido = false;
        }

        if (string.IsNullOrWhiteSpace(txtTelefono.Text))
        {
            errorProvider.SetError(txtTelefono, "El teléfono es obligatorio.");
            valido = false;
        }

        if (cmbRol.SelectedValue == null)
        {
            errorProvider.SetError(cmbRol, "Seleccione el rol del usuario.");
            valido = false;
        }

        return valido;
    }

    private void BtnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidarCampos()) return;

        try
        {
            int rolId = (int)cmbRol.SelectedValue!;

            if (_idSeleccionado == 0)
            {
                var nuevo = new Usuario
                {
                    NombreUsuario = txtNombreUsuario.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Cedula = txtCedula.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    RolId = rolId,
                    EstadoId = 1
                };
                _servicio.Agregar(nuevo, txtClave.Text);
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var existente = _servicio.ObtenerPorId(_idSeleccionado);
                existente.Nombre = txtNombre.Text.Trim();
                existente.Apellido = txtApellido.Text.Trim();
                existente.Cedula = txtCedula.Text.Trim();
                existente.Telefono = txtTelefono.Text.Trim();
                existente.Correo = txtCorreo.Text.Trim();
                existente.RolId = rolId;

                _servicio.Actualizar(existente);

                // Si ingresó una nueva contraseña opcional
                if (!string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    var seg = new SeguridadServicios();
                    existente.ClaveHash = seg.GenerarHash(txtClave.Text);
                    _servicio.Actualizar(existente);
                }

                MessageBox.Show("Usuario actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show($"Error al guardar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
}
