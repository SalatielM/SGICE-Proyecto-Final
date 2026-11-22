namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para miembros del personal.
/// </summary>
public class PersonalDTO
{
    public int IdPersonal { get; set; }
    public byte[]? Foto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string CodPersonal { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string? Correo { get; set; }
    public int PuestoId { get; set; }
    public string Puesto { get; set; } = string.Empty;
    public int EstadoId { get; set; }
    public string Estado { get; set; } = string.Empty;
}
