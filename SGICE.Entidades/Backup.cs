using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Registro de copias de seguridad de la base de datos realizadas en el sistema.
/// </summary>
public class Backup : EntidadBase
{
    [NotMapped]
    public int IdBackup
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;
    public string RutaBackup { get; set; } = string.Empty;

    [NotMapped]
    public DateTime FechaCreacion
    {
        get => FechaRegistro;
        set => FechaRegistro = value;
    }

    public int UsuarioRegistroId { get; set; }

    public virtual Usuario? UsuarioRegistro { get; set; }
}
