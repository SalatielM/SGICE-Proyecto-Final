namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para información de estados del sistema.
/// </summary>
public class EstadoDTO
{
    public int IdEstado { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public int TipoEstadoId { get; set; }
    public string TipoEstado { get; set; } = string.Empty;
}
