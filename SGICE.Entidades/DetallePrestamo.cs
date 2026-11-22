using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Activo físico individual prestado en una orden de préstamo.
/// </summary>
public class DetallePrestamo : EntidadBase
{
    [NotMapped]
    public int IdDetallePrestamo
    {
        get => Id;
        set => Id = value;
    }

    public int PrestamoId { get; set; }
    public int ActivoFisicoId { get; set; }

    public virtual Prestamo? Prestamo { get; set; }
    public virtual ActivoFisico? ActivoFisico { get; set; }
}
