namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para proveedores de bienes.
/// </summary>
public class ProveedorDTO
{
    public int IdProveedor { get; set; }
    public string? RNC { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string? Correo { get; set; }
    public string? Direccion { get; set; }
    public string? PersonalContacto { get; set; }
    public string? TelefonoContacto { get; set; }
    public DateTime FechaRegistro { get; set; }
    public DateTime? FechaActualizacion { get; set; }
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
    public int UsuarioRegistroId { get; set; }
    public string UsuarioRegistro { get; set; } = string.Empty;
    public int? UsuarioActualizacionId { get; set; }
    public string? UsuarioActualizacion { get; set; }
}
