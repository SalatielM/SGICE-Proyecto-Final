namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para directores de centro educativo.
/// </summary>
public class DirectorDTO
{
    public int IdDirector { get; set; }
    public byte[]? Foto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
    public DateTime FechaInicia { get; set; }
    public DateTime? FechaFin { get; set; }
}
