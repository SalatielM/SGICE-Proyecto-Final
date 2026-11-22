namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para el detalle de un activo trasladado entre ubicaciones.
/// </summary>
public class DetalleTrasladoDTO
{
    public int IdDetalleMovimiento { get; set; }
    public int TrasladoId { get; set; }
    public int ActivoFisicoId { get; set; }
    public int ActivoId { get; set; }
    public string CodigoEtiqueta { get; set; } = string.Empty;
    public string NombreActivo { get; set; } = string.Empty;
    public int CategoriaId { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public int MarcaId { get; set; }
    public string Marca { get; set; } = string.Empty;
    public string? NumSerie { get; set; }
    public int UbicacionActualId { get; set; }
    public string UbicacionActual { get; set; } = string.Empty;
    public int UbicacionFinalId { get; set; }
    public string UbicacionFinal { get; set; } = string.Empty;
}
