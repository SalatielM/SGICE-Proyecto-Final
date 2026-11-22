using System.ComponentModel.DataAnnotations.Schema;
using SGICE.Entidades.Enums;

namespace SGICE.Entidades;

/// <summary>
/// Proceso de traslado y reubicación formal de activos entre aulas, edificios o ubicaciones.
/// </summary>
public class Traslado : EntidadBase
{
    [NotMapped]
    public int IdTraslado
    {
        get => Id;
        set => Id = value;
    }

    public DateTime FechaTraslado { get; set; } = DateTime.Now;
    public string RazonTraslado { get; set; } = string.Empty;
    public int UsuarioRegistroId { get; set; }
    public int AutorizadoPorId { get; set; }
    public TipoDocAutorizacion DocAutorizacion { get; set; }
    public string NoDocAutorizacion { get; set; } = string.Empty;

    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Director? AutorizadoPor { get; set; }

    public virtual ICollection<DetalleTraslado> DetalleTraslados { get; set; } = new List<DetalleTraslado>();
}
