namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para la visualización de categorías de activos.
/// </summary>
public class CategoriaDTO
{
    public int IdCategoria { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public string VidaUtil { get; set; } = string.Empty;
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
}
