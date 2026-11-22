using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Proceso de retorno o devolución de activos previamente prestados.
/// </summary>
public class Devolucion : EntidadBase
{
    [NotMapped]
    public int IdDevolucion
    {
        get => Id;
        set => Id = value;
    }

    public int PrestamoId { get; set; }
    public string? ObervacioneGeneral { get; set; }
    public DateTime FechaDevolucion { get; set; } = DateTime.Now;
    public int UsuarioRegistroId { get; set; }

    public virtual Prestamo? Prestamo { get; set; }
    public virtual Usuario? UsuarioResgistro { get; set; }

    public virtual ICollection<DetalleDevolucion> Detalledevoluciones { get; set; } = new List<DetalleDevolucion>();
}
