using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Renglón específico de un activo reportado en una solicitud de mantenimiento.
/// </summary>
public class DetalleSolicitudMantenimiento : EntidadBase
{
    [NotMapped]
    public int IdDetalleSolicitudMantenimiento
    {
        get => Id;
        set => Id = value;
    }

    public int SolicitudMantenimientoId { get; set; }
    public int ActivoFisicoId { get; set; }
    public string? DescripcionProblema { get; set; }

    public virtual SolicitudMantenimiento? SolicitudMantenimiento { get; set; }
    public virtual ActivoFisico? ActivoFisico { get; set; }
}
