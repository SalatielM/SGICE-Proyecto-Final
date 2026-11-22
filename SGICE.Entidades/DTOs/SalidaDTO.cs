namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para cabecera de salida o descargo de activos.
/// </summary>
public class SalidaDTO
{
    public int IdSalida { get; set; }
    public int NumSalida { get; set; }
    public DateTime FechaSalida { get; set; }
    public string? RazonSalida { get; set; }
}
