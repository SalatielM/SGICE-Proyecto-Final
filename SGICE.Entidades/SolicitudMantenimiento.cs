using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Solicitud formal de mantenimiento correctivo o preventivo para activos del centro.
/// </summary>
public class SolicitudMantenimiento : EntidadBase
{
    [NotMapped]
    public int IdSolicitudMantenimiento
    {
        get => Id;
        set => Id = value;
    }

    public string? ObservacionGeneral { get; set; }
    public DateTime FechaSolicitud { get; set; } = DateTime.Now;
    public int UsuarioRegistroId { get; set; }

    public virtual Usuario? UsuarioRegistro { get; set; }

    public virtual ICollection<DetalleSolicitudMantenimiento> DetalleSolicitudMantenimientos { get; set; } = new List<DetalleSolicitudMantenimiento>();
    public virtual ICollection<Mantenimiento> Mantenimientos { get; set; } = new List<Mantenimiento>();
}
