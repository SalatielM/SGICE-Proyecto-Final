using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Registro de auditoría de inicio y cierre de sesión de usuarios.
/// </summary>
public class HistorialAcceso : EntidadBase
{
    [NotMapped]
    public int IdHistorialAcceso
    {
        get => Id;
        set => Id = value;
    }

    public int UsuarioId { get; set; }
    public DateTime FechaIngraso { get; set; } = DateTime.Now;
    public DateTime? FechaSalida { get; set; }
    public string DireccionIp { get; set; } = string.Empty;
    public string? SistemaOperatico { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
