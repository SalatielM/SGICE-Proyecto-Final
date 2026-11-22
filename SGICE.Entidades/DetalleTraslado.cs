using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Detalle individual de un activo físico movilizado con su ubicación de origen y destino.
/// </summary>
public class DetalleTraslado : EntidadBase
{
    [NotMapped]
    public int IdDetalleMovimiento
    {
        get => Id;
        set => Id = value;
    }

    public int TrasladoId { get; set; }
    public int ActivoFisicoId { get; set; }
    public int UbicacionActualId { get; set; }
    public int UbicacionFinalId { get; set; }

    public virtual Ubicacion? UbicacionActual { get; set; }
    public virtual Ubicacion? UbicacionFinal { get; set; }
    public virtual ActivoFisico? ActivoFisico { get; set; }
    public virtual Traslado? Traslado { get; set; }
}
