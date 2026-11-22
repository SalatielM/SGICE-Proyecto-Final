namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para representación y listado de activos de catálogo.
/// </summary>
public class ActivoDTO
{
    public int IdActivo { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int CategoriaId { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public int SubCategoriaId { get; set; }
    public string SubCategoria { get; set; } = string.Empty;
    public int ProveedorId { get; set; }
    public string Proveedor { get; set; } = string.Empty;
    public int MarcaId { get; set; }
    public string Marca { get; set; } = string.Empty;
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
    public int PersonalId { get; set; }
    public string PersonalEncargado { get; set; } = string.Empty;
    public int DetalleId { get; set; }
}
