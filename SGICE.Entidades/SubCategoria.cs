using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Subcategoría que refina la clasificación de una categoría principal de activos.
/// </summary>
public class SubCategoria : EntidadBase
{
    [NotMapped]
    public int IdSubCategoria
    {
        get => Id;
        set => Id = value;
    }

    public int CategoriaId { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int VidaUtil { get; set; }

    [NotMapped]
    public DateTime FechaCreacion
    {
        get => FechaRegistro;
        set => FechaRegistro = value;
    }

    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Categoria? Categoria { get; set; }
    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();
}
