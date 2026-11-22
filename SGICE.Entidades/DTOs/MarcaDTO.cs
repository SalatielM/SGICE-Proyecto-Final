namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para marcas de activos.
/// </summary>
public class MarcaDTO
{
    public int IdMarca { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
}
