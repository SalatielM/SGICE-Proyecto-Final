namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para el detalle cuantitativo de activos en una entrada.
/// </summary>
public class DetalleEntradaDTO
{
    public int ActivoId { get; set; }
    public string NombreActivo { get; set; } = string.Empty;
    public int Cantidad { get; set; }
}
