using System.ComponentModel.DataAnnotations.Schema;

namespace SGICE.Entidades;

/// <summary>
/// Representa un estado dentro del sistema para diversos módulos (activos, mantenimientos, usuarios, etc.).
/// </summary>
public class Estado : EntidadBase
{
    [NotMapped]
    public int IdEstado
    {
        get => Id;
        set => Id = value;
    }

    public string Nombre { get; set; } = string.Empty;
    public int TipoEstadoId { get; set; }
    public int? EstadoIdEstado { get; set; }

    public virtual TipoEstado? TipoEstado { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();
    public virtual ICollection<ActivoFisico> ActivosFisicos { get; set; } = new List<ActivoFisico>();
    public virtual ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
    public virtual ICollection<SubCategoria> SubCategorias { get; set; } = new List<SubCategoria>();
    public virtual ICollection<Marca> Marcas { get; set; } = new List<Marca>();
    public virtual ICollection<Proveedor> Proveedores { get; set; } = new List<Proveedor>();
    public virtual ICollection<Puesto> Puestos { get; set; } = new List<Puesto>();
    public virtual ICollection<Personal> Personales { get; set; } = new List<Personal>();
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    public virtual ICollection<Director> Directores { get; set; } = new List<Director>();
    public virtual ICollection<Edificio> Edificios { get; set; } = new List<Edificio>();
    public virtual ICollection<Ubicacion> Ubicaciones { get; set; } = new List<Ubicacion>();
    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
    public virtual ICollection<SolicitudMantenimiento> SolicitudMantenimientos { get; set; } = new List<SolicitudMantenimiento>();
    public virtual ICollection<Mantenimiento> Mantenimientos { get; set; } = new List<Mantenimiento>();
    public virtual ICollection<DetalleDevolucion> DetalleDevoluciones { get; set; } = new List<DetalleDevolucion>();
    public virtual ICollection<DetalleMantenimiento> DetalleMantenimientos { get; set; } = new List<DetalleMantenimiento>();
}
