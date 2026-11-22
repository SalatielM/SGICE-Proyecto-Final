namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para el detalle de activo reportado en solicitud de mantenimiento.
/// </summary>
public class DetalleSolicitudMantenimientoDTO
{
    public int ActivoFisicoId { get; set; }
    public int ActivoId { get; set; }
    public string Activo { get; set; } = string.Empty;
    public string CodEtiquetaQR { get; set; } = string.Empty;
    public string? NumSerie { get; set; }
    public int CategoriaId { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public int SubCategoriaId { get; set; }
    public string SubCategoria { get; set; } = string.Empty;
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
    public int MarcaId { get; set; }
    public string Marca { get; set; } = string.Empty;
    public int UbicacionId { get; set; }
    public string Ubicacion { get; set; } = string.Empty;
    public string? DescripcionProblema { get; set; }
}
