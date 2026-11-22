using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Clasificación general de los estados manejados en el sistema.
/// </summary>
public class TipoEstado : EntidadBase
{
    [NotMapped]
    public int IdTipoEstado
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();
}
