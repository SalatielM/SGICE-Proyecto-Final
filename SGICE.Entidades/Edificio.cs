using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Edificio físico perteneciente a un centro educativo.
/// </summary>
public class Edificio : EntidadBase
{
    [NotMapped]
    public int IdEdificio
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;
    public string CodEdificio { get; set; } = string.Empty;
    public int CantidadPisos { get; set; }
    public string? Descripcion { get; set; }
    public DateTime FechaConstruccion { get; set; } = DateTime.Now;
    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<Ubicacion> Ubicaciones { get; set; } = new List<Ubicacion>();
}
