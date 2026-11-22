namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para el detalle de activos en un préstamo.
/// </summary>
public class DetallePrestamoDTO
{
    public int IdDetallePrestamo { get; set; }
    public int PrestamoId { get; set; }
    public int ActivoFisicoId { get; set; }
    public int ActivoId { get; set; }
    public string Activo { get; set; } = string.Empty;
    public string CodEtiquetaQR { get; set; } = string.Empty;
    public string? NumSerie { get; set; }
    public int SubCategoriaId { get; set; }
    public string SubCategoria { get; set; } = string.Empty;
    public int MarcaId { get; set; }
    public string Marca { get; set; } = string.Empty;
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
}
