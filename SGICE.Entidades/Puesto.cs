using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Cargo o puesto ocupacional del personal educativo o administrativo.
/// </summary>
public class Puesto : EntidadBase
{
    [NotMapped]
    public int IdPuesto
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }

    [NotMapped]
    public DateTime FechaCreacion
    {
        get => FechaRegistro;
        set => FechaRegistro = value;
    }

    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<Personal> Personales { get; set; } = new List<Personal>();
}
