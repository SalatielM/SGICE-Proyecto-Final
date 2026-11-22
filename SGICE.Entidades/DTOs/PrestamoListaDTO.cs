namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para vista resumida en listas de préstamos.
/// </summary>
public class PrestamoListaDTO
{
    public int IdPrestamo { get; set; }
    public int PersonalSolicitanteId { get; set; }
    public string Solicitante { get; set; } = string.Empty;
    public string CodPersonal { get; set; } = string.Empty;
    public int ActivoId { get; set; }
    public string Activo { get; set; } = string.Empty;
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaFinalizacion { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
}
