namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para registros de auditoría.
/// </summary>
public class AuditoriaDTO
{
    public int IdAuditoria { get; set; }
    public string NombreTabla { get; set; } = string.Empty;
    public string Accion { get; set; } = string.Empty;
    public DateTime FechaRegistro { get; set; }
    public string Usuario { get; set; } = string.Empty;
}
