using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Proveedor que suministra bienes o activos físicos al centro educativo.
/// </summary>
public class Proveedor : EntidadBase
{
    [NotMapped]
    public int IdProveedor
    {
        get => Id;
        set => Id = value;
    }

    public string? RNC { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string? Correo { get; set; }
    public string? Direccion { get; set; }
    public string? PersonalContacto { get; set; }
    public string? TelefonoContacto { get; set; }
    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();
}
