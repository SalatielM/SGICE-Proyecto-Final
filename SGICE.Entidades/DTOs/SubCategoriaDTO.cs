namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para subcategorías de activos.
/// </summary>
public class SubCategoriaDTO
{
    public int IdSubCategoria { get; set; }
    public int CategoriaId { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public string VidaUtil { get; set; } = string.Empty;
    public DateTime FechaCreacion { get; set; }
    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public string UsuarioRegistro { get; set; } = string.Empty;
    public int? UsuarioActualizacionId { get; set; }
    public string? UsuarioActualizacion { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
}
