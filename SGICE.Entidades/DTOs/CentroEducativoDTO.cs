namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para datos de centros educativos.
/// </summary>
public class CentroEducativoDTO
{
    public int IdCentroEducativo { get; set; }
    public byte[]? Foto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string CodCentro { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string? Correo { get; set; }
    public string Direccion { get; set; } = string.Empty;
    public double Longitud { get; set; }
    public double Latitud { get; set; }
    public string DistritoEducativo { get; set; } = string.Empty;
    public string RegionalEducativo { get; set; } = string.Empty;
}
