namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para la devolución de préstamos.
/// </summary>
public class DevolucionDTO
{
    public int IdDevolucion { get; set; }
    public int PrestamoId { get; set; }
    public DateTime FechaDevolucion { get; set; }
    public int UsuarioRegistroId { get; set; }
}
