using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Rol de seguridad asignable a los usuarios para control de acceso.
/// </summary>
public class Rol : EntidadBase
{
    [NotMapped]
    public int IdRol
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }

    public virtual ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
