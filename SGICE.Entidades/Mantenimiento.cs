using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Proceso de intervención técnica de mantenimiento ejecutado sobre activos.
/// </summary>
public class Mantenimiento : EntidadBase
{
    [NotMapped]
    public int IdMantenimiento
    {
        get => Id;
        set => Id = value;
    }

    public int SolicitudMantenimientoId { get; set; }
    public DateTime FechaInicioAtencion { get; set; } = DateTime.Now;
    public DateTime? FechaCierre { get; set; }
    public int PersonalTecnicoId { get; set; }
    public int UsuarioRegistroId { get; set; }

    public virtual SolicitudMantenimiento? SolicitudMantenimiento { get; set; }
    public virtual Personal? PersonalTecnico { get; set; }
    public virtual Usuario? UsuarioRegistro { get; set; }

    public virtual ICollection<DetalleMantenimiento> DetalleMantenimientos { get; set; } = new List<DetalleMantenimiento>();
}
