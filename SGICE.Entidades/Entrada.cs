using System.ComponentModel.DataAnnotations.Schema;
using SGICE.Entidades.Enums;

namespace SGICE.Entidades;

/// <summary>
/// Registro de recepción o ingreso de bienes al centro educativo.
/// </summary>
public class Entrada : EntidadBase
{
    [NotMapped]
    public int IdEntrada
    {
        get => Id;
        set => Id = value;
    }

    public int NumEntrada { get; set; }
    public DateTime FechaEntrada { get; set; } = DateTime.Now;
    public TipoDocReferencia DocReferencia { get; set; }
    public string NoDocReferencia { get; set; } = string.Empty;
    public int UsuarioRegistroId { get; set; }
    public string? ObservacionEntrada { get; set; }

    public virtual Usuario? UsuarioRegistro { get; set; }

    public virtual ICollection<DetalleEntrada> DetalleEntradas { get; set; } = new List<DetalleEntrada>();
}
