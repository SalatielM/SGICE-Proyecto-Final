using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Detalle del activo físico devuelto y el estado en el que fue recibido.
/// </summary>
public class DetalleDevolucion : EntidadBase
{
    [NotMapped]
    public int IdDetalleDevolucion
    {
        get => Id;
        set => Id = value;
    }

    public int DevolucionId { get; set; }
    public int ActivoFisicoId { get; set; }
    public int EstadoDevolucionId { get; set; }
    public string? Obervacion { get; set; }

    public virtual Devolucion? Devolucion { get; set; }
    public virtual ActivoFisico? ActivoFisico { get; set; }
    public virtual Estado? EstadoDevolucion { get; set; }
}
