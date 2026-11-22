using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Director de centro educativo con facultad de autorización en el sistema.
/// </summary>
public class Director : EntidadBase
{
    [NotMapped]
    public int IdDirector
    {
        get => Id;
        set => Id = value;
    }

    public byte[]? Foto { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public DateTime FechaInicia { get; set; } = DateTime.Now;
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<CentroEducativo> CentrosEducativos { get; set; } = new List<CentroEducativo>();
    public virtual ICollection<Auditoria> Auditorias { get; set; } = new List<Auditoria>();
    public virtual ICollection<Traslado> Traslaados { get; set; } = new List<Traslado>();
}
