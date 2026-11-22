using SGICE.Entidades.Enums;

namespace SGICE.Entidades.DTOs;

/// <summary>
/// DTO para transferencia de filtros de consulta de reportes.
/// </summary>
public class ReporteFiltroDTO
{
    public DateTime? FechaDesde { get; set; }
    public DateTime? FechaHasta { get; set; }
    public int? UsuarioRegistraId { get; set; }
    public int? PersonalId { get; set; }
    public int? EstadoGenerico { get; set; }

    public int? ActivoId { get; set; }
    public int? MarcaId { get; set; }
    public string? CodEtiquetaQR { get; set; }
    public int? CategoriaId { get; set; }
    public int? UbicacionId { get; set; }
    public int? EstadoActivoFisicoId { get; set; }

    public int? EstadoDevolucionId { get; set; }
    public int? EstadoMantenimientoId { get; set; }

    public bool? Nombre { get; set; }
    public bool? Apellido { get; set; }
    public bool? Codigo { get; set; }
    public int? PuestoId { get; set; }
    public bool? Usuario { get; set; }
    public int? RolId { get; set; }

    public int? EstadoPrestamoId { get; set; }

    public int? UbicacionOrigenId { get; set; }
    public int? UbicacionDestinoId { get; set; }

    public int? UsuarioAuditoriaId { get; set; }
    public TipoAccionAuditoria? AccionAuditoria { get; set; }
    public string? NombreTabla { get; set; }
    public int? RegistroId { get; set; }
}
