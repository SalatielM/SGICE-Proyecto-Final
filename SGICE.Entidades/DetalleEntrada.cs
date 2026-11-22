using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Detalle cuantitativo de renglones de activos recibidos en una entrada.
/// </summary>
public class DetalleEntrada : EntidadBase
{
    [NotMapped]
    public int IdDetalleEntrada
    {
        get => Id;
        set => Id = value;
    }

    public int EntradaId { get; set; }
    public int ActivoId { get; set; }
    public int Cantidad { get; set; }

    public virtual Entrada? Entrada { get; set; }
    public virtual Activo? Activo { get; set; }

    public virtual ICollection<ActivoFisico> ActivosFisicos { get; set; } = new List<ActivoFisico>();
}
