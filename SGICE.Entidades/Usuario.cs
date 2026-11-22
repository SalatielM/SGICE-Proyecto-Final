using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Usuario con credenciales de acceso al sistema SGICE.
/// </summary>
public class Usuario : EntidadBase
{
    [NotMapped]
    public int IdUsuario
    {
        get => Id;
        set => Id = value;
    }

    public byte[]? Foto { get; set; }
    public string NombreUsuario { get; set; } = string.Empty;
    public string ClaveHash { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string? Correo { get; set; }
    public int RolId { get; set; }

    [NotMapped]
    public DateTime FechaCreacion
    {
        get => FechaRegistro;
        set => FechaRegistro = value;
    }

    public DateTime? FechaActualizacion { get; set; }
    public int UsuarioRegistroId { get; set; }
    public int? UsuarioActualizacionId { get; set; }

    public virtual Rol? Rol { get; set; }
    public virtual Usuario? UsuarioRegistro { get; set; }
    public virtual Usuario? UsuarioActualizacion { get; set; }

    public virtual ICollection<Activo> ActivoRegistros { get; set; } = new List<Activo>();
    public virtual ICollection<Activo> ActivoActualizacion { get; set; } = new List<Activo>();
    public virtual ICollection<ActivoFisico> ActivoFisicoRegistros { get; set; } = new List<ActivoFisico>();
    public virtual ICollection<Auditoria> Auditorias { get; set; } = new List<Auditoria>();
    public virtual ICollection<Backup> BackupRegistros { get; set; } = new List<Backup>();
    public virtual ICollection<Categoria> CategoriaRegistros { get; set; } = new List<Categoria>();
    public virtual ICollection<Categoria> CategoriaActualizacions { get; set; } = new List<Categoria>();
    public virtual ICollection<Devolucion> DevolucionRegistros { get; set; } = new List<Devolucion>();
    public virtual ICollection<Director> DirectorRegistros { get; set; } = new List<Director>();
    public virtual ICollection<Director> DirectorActualizacions { get; set; } = new List<Director>();
    public virtual ICollection<Edificio> EdificioRegistros { get; set; } = new List<Edificio>();
    public virtual ICollection<Edificio> EdificioActualizacions { get; set; } = new List<Edificio>();
    public virtual ICollection<Entrada> EntradaRegistros { get; set; } = new List<Entrada>();
    public virtual ICollection<CentroEducativo> EscuelaRegistro { get; set; } = new List<CentroEducativo>();
    public virtual ICollection<CentroEducativo> EscuelaActualizacion { get; set; } = new List<CentroEducativo>();
    public virtual ICollection<HistorialAcceso> HistorialAccesos { get; set; } = new List<HistorialAcceso>();
    public virtual ICollection<Mantenimiento> MantenimientoRegistros { get; set; } = new List<Mantenimiento>();
    public virtual ICollection<Marca> MarcaRegistros { get; set; } = new List<Marca>();
    public virtual ICollection<Marca> MarcaActualizacion { get; set; } = new List<Marca>();
    public virtual ICollection<Traslado> MovimientoRegistros { get; set; } = new List<Traslado>();
    public virtual ICollection<Personal> PersonalRegistros { get; set; } = new List<Personal>();
    public virtual ICollection<Personal> PersonalActualizacion { get; set; } = new List<Personal>();
    public virtual ICollection<Prestamo> PrestamoRegistros { get; set; } = new List<Prestamo>();
    public virtual ICollection<Proveedor> ProveedorRegistros { get; set; } = new List<Proveedor>();
    public virtual ICollection<Proveedor> ProveedorActualizacions { get; set; } = new List<Proveedor>();
    public virtual ICollection<Puesto> PuestoRegistros { get; set; } = new List<Puesto>();
    public virtual ICollection<Puesto> PuestoActualizacion { get; set; } = new List<Puesto>();
    public virtual ICollection<Salida> SalidaRegistros { get; set; } = new List<Salida>();
    public virtual ICollection<SolicitudMantenimiento> SolicitudMantenimientoRegistros { get; set; } = new List<SolicitudMantenimiento>();
    public virtual ICollection<SubCategoria> SubCategoriaRegistros { get; set; } = new List<SubCategoria>();
    public virtual ICollection<SubCategoria> SubCategoriaActualizacions { get; set; } = new List<SubCategoria>();
    public virtual ICollection<Ubicacion> UbicacionRegistros { get; set; } = new List<Ubicacion>();
    public virtual ICollection<Ubicacion> UbicacionActualizacion { get; set; } = new List<Ubicacion>();
    public virtual ICollection<Usuario> UsuarioRegistros { get; set; } = new List<Usuario>();
    public virtual ICollection<Usuario> UsuarioActualizacions { get; set; } = new List<Usuario>();
}
