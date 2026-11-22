namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para solicitud de mantenimiento.
/// </summary>
public class SolicitudMantenimientoDTO
{
    public int IdSolicitudMantenimiento { get; set; }
    public DateTime FechaSolicitud { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
    public int UsuarioRegistroId { get; set; }
    public string? ObservacionGeneral { get; set; }
}
