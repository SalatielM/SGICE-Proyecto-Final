using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Marca o fabricante del activo inmobiliario o equipo escolar.
/// </summary>
public class Marca : EntidadBase
{
    [NotMapped]
    public int IdMarca
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

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();
}
