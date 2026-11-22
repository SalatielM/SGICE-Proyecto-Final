namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para puestos laborales.
/// </summary>
public class PuestoDTO
{
    public int IdPuesto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
}
