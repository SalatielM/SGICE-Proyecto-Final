using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Categoría principal de clasificación de bienes y activos.
/// </summary>
public class Categoria : EntidadBase
{
    [NotMapped]
    public int IdCategoria
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public string VidaUtil { get; set; } = string.Empty;
    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<SubCategoria> SubCategorias { get; set; } = new List<SubCategoria>();
}
