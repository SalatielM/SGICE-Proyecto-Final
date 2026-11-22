namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para entradas de activos al inventario.
/// </summary>
public class EntradaDTO
{
    public int IdEntrada { get; set; }
    public int NumEntrada { get; set; }
    public string DocReferencia { get; set; } = string.Empty;
    public string? ObservacionEntrada { get; set; }
}
