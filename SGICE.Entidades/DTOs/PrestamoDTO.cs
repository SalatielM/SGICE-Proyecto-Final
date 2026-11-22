namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para préstamos de activos.
/// </summary>
public class PrestamoDTO
{
    public int IdPrestamo { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaLimite { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
    public int PersonalSolicitanteId { get; set; }
    public string PersonalSolicitante { get; set; } = string.Empty;
    public string CodPersonal { get; set; } = string.Empty;
    public int UsuarioRegistroId { get; set; }
}
