using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Permiso granular que autoriza funciones o accesos en el sistema.
/// </summary>
public class Permiso : EntidadBase
{
    [NotMapped]
    public int IdPermiso
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }

    public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();
}
