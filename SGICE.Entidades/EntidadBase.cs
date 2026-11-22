namespace SGICE.Entidades;

/// <summary>
/// Clase base abstracta que encapsula las propiedades y comportamientos comunes de todas las entidades
/// del dominio de SGICE (identificador único, fecha de registro y estado).
/// Aplica los pilares de Programación Orientada a Objetos: Abstracción, Herencia y Encapsulamiento.
/// </summary>
public abstract class EntidadBase
{
    private int _id;
    private DateTime _fechaRegistro = DateTime.Now;

    /// <summary>
    /// Identificador único (Clave Primaria) de la entidad.
    /// </summary>
    public virtual int Id
    {
        get => _id;
        set => _id = value;
    }

    /// <summary>
    /// Fecha y hora de creación o registro de la entidad en el sistema.
    /// </summary>
    public virtual DateTime FechaRegistro
    {
        get => _fechaRegistro;
        set => _fechaRegistro = value;
    }

    /// <summary>
    /// Identificador foráneo del estado de la entidad (si aplica).
    /// </summary>
    public virtual int? EstadoId { get; set; }

    /// <summary>
    /// Entidad de navegación asociada al estado del registro.
    /// </summary>
    public virtual Estado? Estado { get; set; }
}
