using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Ubicación física (aula, oficina, laboratorio) dentro de un edificio.
/// </summary>
public class Ubicacion : EntidadBase
{
    [NotMapped]
    public int IdUbicacion
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;
    public string? Dimencion { get; set; }
    public int Piso { get; set; }
    public string? Descripcion { get; set; }

    [NotMapped]
    public DateTime FechaCreacion
    {
        get => FechaRegistro;
        set => FechaRegistro = value;
    }

    public DateTime? FechaActualizacion { get; set; }
    public int EdificioId { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Edificio? Edificio { get; set; }
    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<ActivoFisico> ActivosFisicos { get; set; } = new List<ActivoFisico>();
    public virtual ICollection<DetalleTraslado> DetalleUbicacionActual { get; set; } = new List<DetalleTraslado>();
    public virtual ICollection<DetalleTraslado> DetalleUbicacionFinal { get; set; } = new List<DetalleTraslado>();
}
