using System.Data;
using System.Text;

namespace SGICE.Presentacion;

/// <summary>
/// Provee métodos utilitarios para estilizado uniforme de controles (DataGridView, botones)
/// y exportación a archivos CSV compatibles con Microsoft Excel.
/// </summary>
public static class UIHelper
{
    public static readonly Color ColorPrimario = Color.FromArgb(37, 99, 235);     // Azul 600
    public static readonly Color ColorSecundario = Color.FromArgb(71, 85, 105);   // Slate 600
    public static readonly Color ColorPeligro = Color.FromArgb(220, 38, 38);      // Rojo 600
    public static readonly Color ColorExito = Color.FromArgb(22, 163, 74);        // Verde 600
    public static readonly Color ColorEncabezado = Color.FromArgb(30, 41, 59);    // Slate 800
    public static readonly Color ColorFondoFilaAlt = Color.FromArgb(248, 250, 252);// Slate 50
    public static readonly Color ColorBorde = Color.FromArgb(226, 232, 240);      // Slate 200

    /// <summary>
    /// Aplica una paleta de colores y formato profesional a un control DataGridView.
    /// </summary>
    public static void EstilarDataGridView(DataGridView dgv)
    {
        if (dgv == null) return;

        dgv.BackgroundColor = Color.White;
        dgv.BorderStyle = BorderStyle.None;
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.GridColor = ColorBorde;
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

        // Estilo Encabezados
        dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorEncabezado;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgv.ColumnHeadersHeight = 36;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        // Estilo Filas
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42);
        dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254); // Azul claro
        dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138); // Azul oscuro
        dgv.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);

        // Filas alternadas
        dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorFondoFilaAlt;
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42);
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
        dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

        // Opciones generales
        dgv.RowTemplate.Height = 32;
        dgv.RowHeadersVisible = false;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AllowUserToResizeRows = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    /// <summary>
    /// Aplica estilo de botón principal (azul moderno).
    /// </summary>
    public static void EstilarBotonPrimario(Button btn)
    {
        EstilarBoton(btn, ColorPrimario, Color.White);
    }

    /// <summary>
    /// Aplica estilo de botón secundario (gris pizarra suave).
    /// </summary>
    public static void EstilarBotonSecundario(Button btn)
    {
        EstilarBoton(btn, Color.FromArgb(241, 245, 249), Color.FromArgb(51, 65, 85));
    }

    /// <summary>
    /// Aplica estilo de botón de peligro o eliminación (rojo suave).
    /// </summary>
    public static void EstilarBotonPeligro(Button btn)
    {
        EstilarBoton(btn, ColorPeligro, Color.White);
    }

    /// <summary>
    /// Aplica estilo de botón de éxito (verde).
    /// </summary>
    public static void EstilarBotonExito(Button btn)
    {
        EstilarBoton(btn, ColorExito, Color.White);
    }

    private static void EstilarBoton(Button btn, Color fondo, Color texto)
    {
        if (btn == null) return;

        btn.BackColor = fondo;
        btn.ForeColor = texto;
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
        btn.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        btn.Cursor = Cursors.Hand;
        btn.Height = 34;
    }

    /// <summary>
    /// Exporta los datos de un DataGridView a formato CSV con codificación UTF-8 (con BOM)
    /// garantizando compatibilidad nativa con Microsoft Excel y caracteres con tildes.
    /// </summary>
    public static void ExportarDataGridViewACsv(DataGridView dgv, string rutaArchivo)
    {
        if (dgv == null) throw new ArgumentNullException(nameof(dgv));

        var sb = new StringBuilder();

        // Encabezados visibles
        var columnasVisibles = dgv.Columns.Cast<DataGridViewColumn>()
            .Where(c => c.Visible)
            .OrderBy(c => c.DisplayIndex)
            .ToList();

        sb.AppendLine(string.Join(";", columnasVisibles.Select(c => EscaparValorCsv(c.HeaderText))));

        // Filas
        foreach (DataGridViewRow row in dgv.Rows)
        {
            if (row.IsNewRow) continue;

            var valores = columnasVisibles.Select(c =>
            {
                var celda = row.Cells[c.Index].Value;
                return EscaparValorCsv(celda?.ToString() ?? string.Empty);
            });

            sb.AppendLine(string.Join(";", valores));
        }

        File.WriteAllText(rutaArchivo, sb.ToString(), Encoding.UTF8);
    }

    /// <summary>
    /// Exporta un DataTable a formato CSV con codificación UTF-8 para Excel.
    /// </summary>
    public static void ExportarDataTableACsv(DataTable dt, string rutaArchivo)
    {
        if (dt == null) throw new ArgumentNullException(nameof(dt));

        var sb = new StringBuilder();

        // Encabezados
        var columnas = dt.Columns.Cast<DataColumn>().ToList();
        sb.AppendLine(string.Join(";", columnas.Select(c => EscaparValorCsv(c.ColumnName))));

        // Filas
        foreach (DataRow row in dt.Rows)
        {
            var valores = columnas.Select(c => EscaparValorCsv(row[c]?.ToString() ?? string.Empty));
            sb.AppendLine(string.Join(";", valores));
        }

        File.WriteAllText(rutaArchivo, sb.ToString(), Encoding.UTF8);
    }

    private static string EscaparValorCsv(string valor)
    {
        if (string.IsNullOrEmpty(valor)) return string.Empty;

        if (valor.Contains(';') || valor.Contains('"') || valor.Contains('\n') || valor.Contains('\r'))
        {
            return $"\"{valor.Replace("\"", "\"\"")}\"";
        }

        return valor;
    }
}
