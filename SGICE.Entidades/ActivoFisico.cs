using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Unidad física individual de un activo inventariado, identificado unívocamente mediante código QR.
/// </summary>
public class ActivoFisico : EntidadBase
{
    [NotMapped]
    public int IdActivoFisico
    {
        get => Id;
        set => Id = value;
    }

    public string CodEtiquetaQR { get; set; } = string.Empty;
    public string? NumSerie { get; set; }
    public int ActivoId { get; set; }
    public int UbicacionId { get; set; }
    public int DetalleEntradaId { get; set; }
    public int UsuarioRegistroId { get; set; }

    public virtual Activo? Activo { get; set; }
    public virtual Ubicacion? Ubicacion { get; set; }
    public virtual DetalleEntrada? DetalleEntrada { get; set; }
    public virtual Usuario? UsuarioRegistro { get; set; }

    public virtual ICollection<DetalleDevolucion> DetalleDevoluciones { get; set; } = new List<DetalleDevolucion>();
    public virtual ICollection<DetalleMantenimiento> DetalleMantenimientos { get; set; } = new List<DetalleMantenimiento>();
    public virtual ICollection<DetalleTraslado> DetalleMovimientos { get; set; } = new List<DetalleTraslado>();
    public virtual ICollection<DetallePrestamo> DetallePrestamos { get; set; } = new List<DetallePrestamo>();
    public virtual ICollection<DetalleSalida> DetalleSalidas { get; set; } = new List<DetalleSalida>();
    public virtual ICollection<DetalleSolicitudMantenimiento> DetalleSolicitudMantenimientos { get; set; } = new List<DetalleSolicitudMantenimiento>();
}
