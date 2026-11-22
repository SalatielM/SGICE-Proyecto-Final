using System.ComponentModel.DataAnnotations.Schema;
using SGICE.Entidades.Enums;

namespace SGICE.Entidades;

/// <summary>
/// Registro histórico de auditoría de transacciones y cambios sobre la información.
/// </summary>
public class Auditoria : EntidadBase
{
    [NotMapped]
    public int IdAuditoria
    {
        get => Id;
        set => Id = value;
    }

    public string NombreTabla { get; set; } = string.Empty;
    public int RegistroId { get; set; }
    public TipoAccionAuditoria Accion { get; set; }
    public string? ValoresAntiguos { get; set; }
    public string? ValoresNuevos { get; set; }
    public int UsuarioAuditoriaId { get; set; }
    public int DirectorId { get; set; }

    public virtual Director? Director { get; set; }
    public virtual Usuario? UsuarioAuditoria { get; set; }
}
