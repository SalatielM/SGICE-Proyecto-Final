using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Modelo de catálogo maestro de un tipo o modelo de activo inmobiliario.
/// </summary>
public class Activo : EntidadBase
{
    [NotMapped]
    public int IdActivo
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public int SubCategoriaId { get; set; }
    public int MarcaId { get; set; }
    public int ProveedorId { get; set; }
    public DateTime? FechaActualizacion { get; set; }
    public int PersonalEncargadoId { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Categoria? Categoria { get; set; }
    public virtual SubCategoria? SubCategoria { get; set; }
    public virtual Marca? Marca { get; set; }
    public virtual Personal? PersonalEncargado { get; set; }
    public virtual Proveedor? Proveedor { get; set; }
    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<ActivoFisico> ActivosFisicos { get; set; } = new List<ActivoFisico>();
    public virtual ICollection<DetalleEntrada> DetalleEntradas { get; set; } = new List<DetalleEntrada>();
}
