namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para orden de intervención técnica de mantenimiento.
/// </summary>
public class MantenimientoDTO
{
    public int MantenimientoId { get; set; }
    public int SolicitudMantenimientoId { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime? FechaCierre { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
    public int PersonalTecnicoId { get; set; }
    public string PersonalTecnico { get; set; } = string.Empty;
}
