namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para edificios del centro.
/// </summary>
public class EdificioDTO
{
    public int IdEdificio { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string CodEdificio { get; set; } = string.Empty;
    public string CantidadPisos { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
    public DateTime FechaConstruccion { get; set; }
    public DateTime FechaRegistro { get; set; }
    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public string UsuarioRegistro { get; set; } = string.Empty;
    public int? UsuarioActualizacionId { get; set; }
    public string? UsuarioActualizacion { get; set; }
}
