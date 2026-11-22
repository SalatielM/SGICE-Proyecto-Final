namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para el detalle individual de un activo devuelto.
/// </summary>
public class DetalleDevolucionDTO
{
    public int IdDetalleDevolucion { get; set; }
    public int DevolucionId { get; set; }
    public int ActivoFisicoId { get; set; }
    public int ActivoId { get; set; }
    public string Activo { get; set; } = string.Empty;
    public string CodEtiquetaQR { get; set; } = string.Empty;
    public string? NumSerie { get; set; }
    public int MarcaId { get; set; }
    public string Marca { get; set; } = string.Empty;
    public int SubCategoriaId { get; set; }
    public string SubCategoria { get; set; } = string.Empty;
    public int EstadoDevolucionId { get; set; }
    public string EstadoDevolucion { get; set; } = string.Empty;
    public string? Obervacion { get; set; }
    public int IdDevolucion { get; set; }
    public int PrestamoId { get; set; }
    public int PersonalId { get; set; }
    public string Solicitante { get; set; } = string.Empty;
    public string CodPersonal { get; set; } = string.Empty;
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDevolucion { get; set; }
}
