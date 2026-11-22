namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para ubicaciones físicas (aulas, laboratorios, oficinas).
/// </summary>
public class UbicacionDTO
{
    public int IdUbicacion { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Dimencion { get; set; }
    public int Piso { get; set; }
    public int EdificioId { get; set; }
    public string Edificio { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
}
