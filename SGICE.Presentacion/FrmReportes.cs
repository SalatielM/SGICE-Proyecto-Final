using System.Data;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Reportes;
using SGICE.Presentacion.Utilidades;

namespace SGICE.Presentacion;

public partial class FrmReportes : Form
{
    private readonly ReporteServicios _servicio = new();
    private DataTable? _dtActual;

    public FrmReportes()
    {
        InitializeComponent();
    }




    private void FrmReportes_Load(object? sender, EventArgs e)
    {
        if (cmbTipoReporte.DataSource == null)
        {
            CargarTiposReporte();
            EjecutarConsultaReporte();
        }
    }

    public void SeleccionarTipoReporte(TipoReporte tipo)
    {
        if (cmbTipoReporte.DataSource == null)
        {
            CargarTiposReporte();
        }

        cmbTipoReporte.SelectedItem = tipo;
        EjecutarConsultaReporte();
    }
    private void CargarTiposReporte()
    {
        cmbTipoReporte.DataSource = Enum.GetValues<TipoReporte>();
    }


   

    private void BtnGenerar_Click(object? sender, EventArgs e)
    {
        EjecutarConsultaReporte();
    }

    private void EjecutarConsultaReporte()
    {
        if (cmbTipoReporte.SelectedItem is not TipoReporte tipo) return;

        try
        {
            Cursor = Cursors.WaitCursor;
            btnGenerar.Enabled = false;

            var filtros = new ReporteFiltroDTO
            {
                FechaDesde = dtpFechaDesde.Checked ? dtpFechaDesde.Value.Date : null,
                FechaHasta = dtpFechaHasta.Checked ? dtpFechaHasta.Value.Date.AddDays(1).AddTicks(-1) : null
            };

            _dtActual = _servicio.ObtenerReporte(tipo, filtros);
            dgvReporte.DataSource = _dtActual;

            lblTotalRegistros.Text = $"Registros encontrados: {_dtActual.Rows.Count}";
        }
        catch (NegocioExcepcion ex)
        {
            MessageBox.Show(ex.Message, "Validación de Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al generar el reporte '{tipo}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Cursor = Cursors.Default;
            btnGenerar.Enabled = true;
        }
    }

    private void BtnExportar_Click(object? sender, EventArgs e)
    {
        if (_dtActual == null || _dtActual.Rows.Count == 0)
        {
            MessageBox.Show("No hay datos en el reporte actual para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var sfd = new SaveFileDialog
        {
            Filter = "Archivo CSV compatible con Excel (*.csv)|*.csv|Todos los archivos (*.*)|*.*",
            FileName = $"Reporte_{cmbTipoReporte.Text}_{DateTime.Now:yyyyMMdd_HHmmss}.csv",
            Title = "Guardar Reporte"
        };

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            try
            {
                ExportadorCsv.ExportarDataTableACsv(_dtActual, sfd.FileName);
                MessageBox.Show(
                    $"Reporte exportado exitosamente a:\n{sfd.FileName}\n\nPuede abrirlo directamente en Microsoft Excel.",
                    "Exportación Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
