using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Préstamo temporal de activos físicos a personal docente o administrativo.
/// </summary>
public class Prestamo : EntidadBase
{
    [NotMapped]
    public int IdPrestamo
    {
        get => Id;
        set => Id = value;
    }

    public DateTime FechaPrestamo { get; set; } = DateTime.Now;
    public DateTime FechaLimite { get; set; } = DateTime.Now.AddDays(7);
    public int PersonalSolicitanteId { get; set; }
    public int UsuarioRegistroId { get; set; }

    public virtual Personal? PersonalSolicitante { get; set; }
    public virtual Usuario? UsuarioRegistro { get; set; }

    public virtual ICollection<DetallePrestamo> DetallePrestamos { get; set; } = new List<DetallePrestamo>();
    public virtual ICollection<Devolucion> Devoluciones { get; set; } = new List<Devolucion>();
}
