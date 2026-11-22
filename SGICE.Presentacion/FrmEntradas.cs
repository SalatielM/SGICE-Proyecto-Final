using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Operaciones;

namespace SGICE.Presentacion;

public partial class FrmEntradas : Form
{
    private readonly EntradaServicios _entradaServicios = new();
    private readonly ActivoServicios _activoServicios = new();

    private readonly List<DetalleEntradaDTO> _detalles = new();
    private readonly List<ActivoFisicoDTO> _activosFisicos = new();

    public FrmEntradas()
    {
        InitializeComponent();
        UIHelper.EstilarDataGridView(dgvActivosFisicos);
        UIHelper.EstilarBotonPrimario(btnProcesar);
        UIHelper.EstilarBotonSecundario(btnLimpiar);
        UIHelper.EstilarBotonSecundario(btnGenerar);
        UIHelper.EstilarBotonPeligro(btnQuitar);
    }

    private void FrmEntradas_Load(object? sender, EventArgs e)
    {
        CargarCombos();
    }

    private void CargarCombos()
    {
        try
        {
            cmbTipoDoc.DataSource = Enum.GetValues<TipoDocReferencia>();

            var activos = _activoServicios.ObtenerTodos().ToList();
            cmbActivo.DataSource = activos;
            cmbActivo.DisplayMember = "Nombre";
            cmbActivo.ValueMember = "Id";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al cargar catálogos para entradas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnGenerar_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();

        if (cmbActivo.SelectedValue == null)
        {
            errorProvider.SetError(cmbActivo, "Seleccione el modelo o tipo de activo.");
            return;
        }

        if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
        {
            errorProvider.SetError(txtCantidad, "Ingrese una cantidad válida mayor a cero.");
            return;
        }

        int activoId = (int)cmbActivo.SelectedValue;

        try
        {
            var detalle = new DetalleEntradaDTO
            {
                ActivoId = activoId,
                NombreActivo = cmbActivo.Text,
                Cantidad = cantidad
            };

            var nuevosGenerados = _entradaServicios.GenerarActivosFisicosTemporales(detalle, _activosFisicos);

            _detalles.Add(detalle);
            _activosFisicos.AddRange(nuevosGenerados);

            RefrescarGrid();
            txtCantidad.Clear();
        }
        catch (NegocioExcepcion ex)
        {
            MessageBox.Show(ex.Message, "Validación de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al generar activos físicos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnQuitar_Click(object? sender, EventArgs e)
    {
        if (dgvActivosFisicos.CurrentRow?.DataBoundItem is ActivoFisicoDTO seleccionado)
        {
            _activosFisicos.Remove(seleccionado);

            // Reajustar detalle cuantitativo
            var detalle = _detalles.FirstOrDefault(d => d.ActivoId == seleccionado.ActivoId);
            if (detalle != null)
            {
                detalle.Cantidad--;
                if (detalle.Cantidad <= 0) _detalles.Remove(detalle);
            }

            RefrescarGrid();
        }
        else
        {
            MessageBox.Show("Seleccione una fila para quitar el activo físico generado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void RefrescarGrid()
    {
        dgvActivosFisicos.DataSource = null;
        dgvActivosFisicos.DataSource = _activosFisicos.ToList();

        if (dgvActivosFisicos.Columns["CodEtiquetaQR"] != null)
            dgvActivosFisicos.Columns["CodEtiquetaQR"].HeaderText = "Código Etiqueta QR";
        if (dgvActivosFisicos.Columns["Activo"] != null)
            dgvActivosFisicos.Columns["Activo"].HeaderText = "Activo";
        if (dgvActivosFisicos.Columns["SubCategoria"] != null)
            dgvActivosFisicos.Columns["SubCategoria"].HeaderText = "Subcategoría";
        if (dgvActivosFisicos.Columns["Marca"] != null)
            dgvActivosFisicos.Columns["Marca"].HeaderText = "Marca";
        if (dgvActivosFisicos.Columns["Ubicacion"] != null)
            dgvActivosFisicos.Columns["Ubicacion"].HeaderText = "Ubicación Asignada";
        if (dgvActivosFisicos.Columns["Estado"] != null)
            dgvActivosFisicos.Columns["Estado"].HeaderText = "Estado";
        if (dgvActivosFisicos.Columns["FechaRegistro"] != null)
            dgvActivosFisicos.Columns["FechaRegistro"].HeaderText = "Fecha";

        // Ocultar IDs
        if (dgvActivosFisicos.Columns["IdActivoFisico"] != null) dgvActivosFisicos.Columns["IdActivoFisico"].Visible = false;
        if (dgvActivosFisicos.Columns["ActivoId"] != null) dgvActivosFisicos.Columns["ActivoId"].Visible = false;
        if (dgvActivosFisicos.Columns["SubCategoriaId"] != null) dgvActivosFisicos.Columns["SubCategoriaId"].Visible = false;
        if (dgvActivosFisicos.Columns["MarcaId"] != null) dgvActivosFisicos.Columns["MarcaId"].Visible = false;
        if (dgvActivosFisicos.Columns["UbicacionId"] != null) dgvActivosFisicos.Columns["UbicacionId"].Visible = false;
        if (dgvActivosFisicos.Columns["EstadoId"] != null) dgvActivosFisicos.Columns["EstadoId"].Visible = false;

        lblTotalActivos.Text = $"Total de activos físicos generados (AF): {_activosFisicos.Count}";
    }

    private void BtnProcesar_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();

        if (_activosFisicos.Count == 0)
        {
            MessageBox.Show("Debe generar al menos un activo físico con etiqueta QR para registrar la entrada.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(txtNoDoc.Text))
        {
            errorProvider.SetError(txtNoDoc, "Ingrese el número de documento de referencia.");
            return;
        }

        var confirmacion = MessageBox.Show(
            $"¿Desea registrar transaccionalmente la entrada de {_activosFisicos.Count} activo(s) físico(s)?\n\nSe insertarán los registros de Entrada, Detalle de Entrada y Activos Físicos correspondientes.",
            "Confirmar Entrada",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmacion != DialogResult.Yes) return;

        try
        {
            Cursor = Cursors.WaitCursor;
            btnProcesar.Enabled = false;

            var entrada = new Entrada
            {
                NumEntrada = new Random().Next(100000, 999999),
                FechaEntrada = DateTime.Now,
                DocReferencia = (TipoDocReferencia)cmbTipoDoc.SelectedValue!,
                NoDocReferencia = txtNoDoc.Text.Trim(),
                ObservacionEntrada = txtObservacion.Text.Trim(),
                EstadoId = 1
            };

            _entradaServicios.RegistrarEntrada(entrada, _detalles, _activosFisicos);

            MessageBox.Show(
                $"Entrada transaccional completada con éxito. Se crearon {_activosFisicos.Count} activos físicos con etiquetas QR en Almacén Principal.",
                "Entrada Registrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarTodo();
        }
        catch (NegocioExcepcion ex)
        {
            MessageBox.Show(ex.Message, "Validación de Regla de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al registrar la entrada transaccional: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        _activosFisicos.Clear();
        RefrescarGrid();
        txtNoDoc.Clear();
        txtObservacion.Clear();
        txtCantidad.Clear();
        errorProvider.Clear();
    }
}
