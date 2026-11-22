using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Centro educativo al que pertenecen los edificios, aulas y activos gestionados.
/// </summary>
public class CentroEducativo : EntidadBase
{
    [NotMapped]
    public int IdCentroEducativo
    {
        get => Id;
        set => Id = value;
    }

    public byte[]? Foto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string CodCentro { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string? Correo { get; set; }
    public string Direccion { get; set; } = string.Empty;
    public double Longitud { get; set; }
    public double Latitud { get; set; }
    public string? Modalidad { get; set; }
    public string? Jornada { get; set; }
    public string DistritoEducativo { get; set; } = string.Empty;
    public string RegionalEducativo { get; set; } = string.Empty;
    public int DirectorId { get; set; }

    [NotMapped]
    public DateTime FechaCreacion
    {
        get => FechaRegistro;
        set => FechaRegistro = value;
    }

    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Director? Director { get; set; }
    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }
}
