using SGICE.Entidades.Enums;

namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para renglón individual de salida o descargo.
/// </summary>
public class DetalleSalidaDTO
{
    public int IdDetalleSalida { get; set; }
    public int SalidaId { get; set; }
    public int ActivoFisicoId { get; set; }
    public string ActivoFisico { get; set; } = string.Empty;
    public string CodEtiquetaQR { get; set; } = string.Empty;
    public string? NumSerie { get; set; }
    public int UbicacionId { get; set; }
    public string Ubicacion { get; set; } = string.Empty;
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
    public EstadoActivoFisico EstadoDestilo { get; set; }
    public MotivoSalida MotivoSalida { get; set; }
}
