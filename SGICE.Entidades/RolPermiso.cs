using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Relación de muchos a muchos entre Rol y Permiso.
/// </summary>
public class RolPermiso : EntidadBase
{
    [NotMapped]
    public int IdRolPermiso
    {
        get => Id;
        set => Id = value;
    }

    public int RolId { get; set; }
    public int PermisoId { get; set; }

    public virtual Rol? Rol { get; set; }
    public virtual Permiso? Permiso { get; set; }
}
