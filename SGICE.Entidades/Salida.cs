using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Registro maestro de descargo o salida formal de bienes de la institución.
/// </summary>
public class Salida : EntidadBase
{
    [NotMapped]
    public int IdSalida
    {
        get => Id;
        set => Id = value;
    }

    public int NumSalida { get; set; }
    public DateTime FechaSalida { get; set; } = DateTime.Now;
    public string? RazonSalida { get; set; }
    public int UsuarioRegistroId { get; set; }
    public string? Observaciones { get; set; }

    public virtual Usuario? UsuarioRegistro { get; set; }

    public virtual ICollection<DetalleSalida> DetalleSalidas { get; set; } = new List<DetalleSalida>();
}
