using System.ComponentModel.DataAnnotations.Schema;
using SGICE.Entidades.Enums;

namespace SGICE.Entidades;

/// <summary>
/// Detalle individual de un activo físico descargado o retirado en una salida.
/// </summary>
public class DetalleSalida : EntidadBase
{
    [NotMapped]
    public int IdDetalleSalida
    {
        get => Id;
        set => Id = value;
    }

    public int SalidaId { get; set; }
    public int ActivoFisicoId { get; set; }
    public MotivoSalida MotivoSalida { get; set; }

    public virtual Salida? Salida { get; set; }
    public virtual ActivoFisico? ActivoFisico { get; set; }
}
