using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Operaciones;
using SGICE.Negocio.Seguridad;

namespace SGICE.Presentacion;

public partial class FrmTraslados : Form
{
    private readonly TrasladoServicios _trasladoServicios = new();
    private readonly UbicacionServicios _ubicacionServicios = new();
    private readonly ActivoFisicoServicios _activoFisicoServicios = new();
    private readonly DirectorServicios _directorServicios = new();

    private readonly List<DetalleTrasladoDTO> _detalles = new();
    private List<ActivoFisicoDTO> _activosEnOrigen = new();

    public FrmTraslados()
    {
        InitializeComponent();
    }

    private void FrmTraslados_Load(object? sender, EventArgs e)
    {
        CargarCombos();
    }

    private void CargarCombos()
    {
        try
        {
            var ubicacionesOrigen = _ubicacionServicios.ObtenerTodos().ToList();
            cmbOrigen.DataSource = ubicacionesOrigen;
            cmbOrigen.DisplayMember = "Nombre";
            cmbOrigen.ValueMember = "Id";

            var ubicacionesDestino = _ubicacionServicios.ObtenerTodos().ToList();
            cmbDestino.DataSource = ubicacionesDestino;
            cmbDestino.DisplayMember = "Nombre";
            cmbDestino.ValueMember = "Id";

            cmbTipoDoc.DataSource = Enum.GetValues<TipoDocAutorizacion>();

            var directores = _directorServicios.ObtenerActivos().ToList();
            if (!directores.Any()) directores = _directorServicios.ObtenerTodos().ToList();
            cmbDirector.DataSource = directores;
            cmbDirector.DisplayMember = "Nombre";
            cmbDirector.ValueMember = "Id";

            ActualizarActivosPorOrigen();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar catálogos para traslados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CmbOrigen_SelectedIndexChanged(object? sender, EventArgs e)
    {
        ActualizarActivosPorOrigen();
    }

    private void ActualizarActivosPorOrigen()
    {
        if (cmbOrigen.SelectedValue is int origenId && origenId > 0)
        {
            try
            {
                var todosActivos = _activoFisicoServicios.Listar();
                _activosEnOrigen = todosActivos
                    .Where(a => a.UbicacionId == origenId && a.EstadoId == 1) // Estado Disponible
                    .ToList();

                cmbActivosDisponibles.DataSource = null;
                cmbActivosDisponibles.DataSource = _activosEnOrigen;
                cmbActivosDisponibles.DisplayMember = "CodEtiquetaQR";
                cmbActivosDisponibles.ValueMember = "IdActivoFisico";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener activos de la ubicación seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void BtnAgregar_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();

        if (cmbOrigen.SelectedValue == null)
        {
            errorProvider.SetError(cmbOrigen, "Seleccione la ubicación de origen.");
            return;
        }

        if (cmbDestino.SelectedValue == null)
        {
            errorProvider.SetError(cmbDestino, "Seleccione la ubicación de destino.");
            return;
        }

        int origenId = (int)cmbOrigen.SelectedValue;
        int destinoId = (int)cmbDestino.SelectedValue;

        if (origenId == destinoId)
        {
            errorProvider.SetError(cmbDestino, "La ubicación de destino debe ser diferente a la de origen.");
            MessageBox.Show("La ubicación de origen y destino no pueden ser iguales.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbActivosDisponibles.SelectedItem is not ActivoFisicoDTO activoSeleccionado)
        {
            MessageBox.Show("No hay un activo físico seleccionado para agregar al traslado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (_detalles.Any(d => d.ActivoFisicoId == activoSeleccionado.IdActivoFisico))
        {
            MessageBox.Show("El activo físico ya ha sido agregado al traslado actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var detalleDTO = new DetalleTrasladoDTO
        {
            ActivoFisicoId = activoSeleccionado.IdActivoFisico,
            ActivoId = activoSeleccionado.ActivoId,
            CodigoEtiqueta = activoSeleccionado.CodEtiquetaQR,
            NombreActivo = activoSeleccionado.Activo,
            CategoriaId = activoSeleccionado.CategoriaId,
            Categoria = activoSeleccionado.Categoria,
            MarcaId = activoSeleccionado.MarcaId,
            Marca = activoSeleccionado.Marca,
            NumSerie = activoSeleccionado.NumSerie,
            UbicacionActualId = origenId,
            UbicacionActual = cmbOrigen.Text,
            UbicacionFinalId = destinoId,
            UbicacionFinal = cmbDestino.Text
        };

        _detalles.Add(detalleDTO);
        RefrescarGridDetalle();
    }

    private void BtnQuitar_Click(object? sender, EventArgs e)
    {
        if (dgvDetalle.CurrentRow?.DataBoundItem is DetalleTrasladoDTO item)
        {
            _detalles.Remove(item);
            RefrescarGridDetalle();
        }
        else
        {
            MessageBox.Show("Seleccione un renglón del detalle para quitarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void RefrescarGridDetalle()
    {
        dgvDetalle.DataSource = null;
        dgvDetalle.DataSource = _detalles.ToList();

        if (dgvDetalle.Columns["CodigoEtiqueta"] != null)
            dgvDetalle.Columns["CodigoEtiqueta"].HeaderText = "Etiqueta QR";
        if (dgvDetalle.Columns["NombreActivo"] != null)
            dgvDetalle.Columns["NombreActivo"].HeaderText = "Activo";
        if (dgvDetalle.Columns["Marca"] != null)
            dgvDetalle.Columns["Marca"].HeaderText = "Marca";
        if (dgvDetalle.Columns["NumSerie"] != null)
            dgvDetalle.Columns["NumSerie"].HeaderText = "No. Serie";
        if (dgvDetalle.Columns["UbicacionActual"] != null)
            dgvDetalle.Columns["UbicacionActual"].HeaderText = "Origen";
        if (dgvDetalle.Columns["UbicacionFinal"] != null)
            dgvDetalle.Columns["UbicacionFinal"].HeaderText = "Destino";

        // Ocultar llaves
        if (dgvDetalle.Columns["IdDetalleMovimiento"] != null) dgvDetalle.Columns["IdDetalleMovimiento"].Visible = false;
        if (dgvDetalle.Columns["TrasladoId"] != null) dgvDetalle.Columns["TrasladoId"].Visible = false;
        if (dgvDetalle.Columns["ActivoFisicoId"] != null) dgvDetalle.Columns["ActivoFisicoId"].Visible = false;
        if (dgvDetalle.Columns["ActivoId"] != null) dgvDetalle.Columns["ActivoId"].Visible = false;
        if (dgvDetalle.Columns["CategoriaId"] != null) dgvDetalle.Columns["CategoriaId"].Visible = false;
        if (dgvDetalle.Columns["MarcaId"] != null) dgvDetalle.Columns["MarcaId"].Visible = false;
        if (dgvDetalle.Columns["UbicacionActualId"] != null) dgvDetalle.Columns["UbicacionActualId"].Visible = false;
        if (dgvDetalle.Columns["UbicacionFinalId"] != null) dgvDetalle.Columns["UbicacionFinalId"].Visible = false;

        lblTotalItems.Text = $"Activos seleccionados para traslado: {_detalles.Count}";
    }

    private void BtnProcesar_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();

        if (_detalles.Count == 0)
        {
            MessageBox.Show("Debe agregar al menos un activo al detalle de traslado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtNoDoc.Text))
        {
            errorProvider.SetError(txtNoDoc, "Ingrese el número de documento de autorización.");
            return;
        }

        if (string.IsNullOrWhiteSpace(txtRazon.Text))
        {
            errorProvider.SetError(txtRazon, "Ingrese la razón o motivo del traslado.");
            return;
        }

        if (cmbDirector.SelectedValue == null)
        {
            errorProvider.SetError(cmbDirector, "Seleccione la autoridad que autoriza el traslado.");
            return;
        }

        var confirmacion = MessageBox.Show(
            $"¿Está seguro de procesar el traslado de {_detalles.Count} activo(s) hacia '{cmbDestino.Text}'?\n\nEsta operación es transaccional y actualizará la ubicación de los activos.",
            "Confirmar Traslado",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmacion != DialogResult.Yes) return;

        try
        {
            Cursor = Cursors.WaitCursor;
            btnProcesar.Enabled = false;

            var traslado = new Traslado
            {
                FechaTraslado = DateTime.Now,
                RazonTraslado = txtRazon.Text.Trim(),
                NoDocAutorizacion = txtNoDoc.Text.Trim(),
                DocAutorizacion = (TipoDocAutorizacion)cmbTipoDoc.SelectedValue!,
                AutorizadoPorId = (int)cmbDirector.SelectedValue!,
                EstadoId = 1
            };

            _trasladoServicios.RegistrarTraslado(traslado, _detalles);

            MessageBox.Show(
                $"El traslado transaccional fue registrado exitosamente con {_detalles.Count} activos reubicados.",
                "Traslado Completado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarTodo();
            ActualizarActivosPorOrigen();
        }
        catch (NegocioExcepcion ex)
        {
            MessageBox.Show(ex.Message, "Validación de Regla de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al procesar el traslado transaccional: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Cursor = Cursors.Default;
            btnProcesar.Enabled = true;
        }
    }

    private void BtnLimpiar_Click(object? sender, EventArgs e)
    {
        LimpiarTodo();
    }

    private void LimpiarTodo()
    {
        _detalles.Clear();
        RefrescarGridDetalle();
        txtNoDoc.Clear();
        txtRazon.Clear();
        errorProvider.Clear();
    }

    private void pnlTop_Paint(object sender, PaintEventArgs e)
    {

    }

    private void lblTitulo_Click(object sender, EventArgs e)
    {

    }

    private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
