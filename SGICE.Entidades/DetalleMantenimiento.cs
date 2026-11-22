using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Resultado y solución aplicada a un activo intervenido en mantenimiento.
/// </summary>
public class DetalleMantenimiento : EntidadBase
{
    [NotMapped]
    public int IdDetalleMantenimiento
    {
        get => Id;
        set => Id = value;
    }

    public int MantenimientoId { get; set; }
    public int ActivoFisicoId { get; set; }
    public string? Solucion { get; set; }

    public virtual Mantenimiento? Mantenimiento { get; set; }
    public virtual ActivoFisico? ActivoFisico { get; set; }
}
