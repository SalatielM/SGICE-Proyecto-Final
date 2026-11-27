using System.Data;
using System.Text;

namespace SGICE.Presentacion.Utilidades;

/// <summary>
/// Provee métodos utilitarios para exportar datos tabulares a archivos CSV compatibles con Excel.
/// </summary>
public static class ExportadorCsv
{
    public static void ExportarDataGridViewACsv(DataGridView dgv, string rutaArchivo)
    {
        if (dgv == null) throw new ArgumentNullException(nameof(dgv));

        var sb = new StringBuilder();
        var columnasVisibles = dgv.Columns.Cast<DataGridViewColumn>()
            .Where(c => c.Visible)
            .OrderBy(c => c.DisplayIndex)
            .ToList();

        sb.AppendLine(string.Join(";", columnasVisibles.Select(c => EscaparValorCsv(c.HeaderText))));

        foreach (DataGridViewRow row in dgv.Rows)
        {
            if (row.IsNewRow) continue;
            var valores = columnasVisibles.Select(c => EscaparValorCsv(row.Cells[c.Index].Value?.ToString() ?? string.Empty));
            sb.AppendLine(string.Join(";", valores));
        }

        File.WriteAllText(rutaArchivo, sb.ToString(), Encoding.UTF8);
    }

    public static void ExportarDataTableACsv(DataTable dt, string rutaArchivo)
    {
        if (dt == null) throw new ArgumentNullException(nameof(dt));

        var sb = new StringBuilder();
        var columnas = dt.Columns.Cast<DataColumn>().ToList();
        sb.AppendLine(string.Join(";", columnas.Select(c => EscaparValorCsv(c.ColumnName))));

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
            return $"\"{valor.Replace("\"", "\"\"")}\"";
        return valor;
    }
}
