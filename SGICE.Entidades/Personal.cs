using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Miembro del personal del centro educativo (docente, técnico o administrativo).
/// </summary>
public class Personal : EntidadBase
{
    [NotMapped]
    public int IdPersonal
    {
        get => Id;
        set => Id = value;
    }

    public byte[]? Foto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string CodPersonal { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string? Correo { get; set; }
    public int PuestoId { get; set; }

    [NotMapped]
    public DateTime FechaCreacion
    {
        get => FechaRegistro;
        set => FechaRegistro = value;
    }

    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Puesto? Puesto { get; set; }
    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<Activo> PersonalEncargados { get; set; } = new List<Activo>();
    public virtual ICollection<Mantenimiento> MantenimientoTecnicos { get; set; } = new List<Mantenimiento>();
    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
