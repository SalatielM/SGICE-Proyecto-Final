namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para el detalle de solución de mantenimiento.
/// </summary>
public class DetalleMantenimientoDTO
{
    public int ActivoFisicoId { get; set; }
    public int ActivoId { get; set; }
    public string Activo { get; set; } = string.Empty;
    public string CodEtiquetaQR { get; set; } = string.Empty;
    public string? NumSerie { get; set; }
    public int MarcaId { get; set; }
    public string Marca { get; set; } = string.Empty;
    public int CategoriaId { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public int SubCategoriaId { get; set; }
    public string SubCategoria { get; set; } = string.Empty;
    public string? ProblemaReportado { get; set; }
    public int EstadoDetalleId { get; set; }
    public string EstadoDetalle { get; set; } = string.Empty;
    public string? Solucion { get; set; }
}
