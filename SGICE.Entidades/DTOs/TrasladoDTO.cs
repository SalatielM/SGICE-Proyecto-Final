namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para la cabecera de un traslado de activos.
/// </summary>
public class TrasladoDTO
{
    public int IdTraslado { get; set; }
    public DateTime FechaTraslado { get; set; }
    public string RazonTraslado { get; set; } = string.Empty;
    public int UsuarioRegistroId { get; set; }
    public string Usuario { get; set; } = string.Empty;
}
