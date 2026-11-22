namespace SGICE.Negocio.Excepciones;

/// <summary>
/// Excepción base para la capa de lógica de negocio (BLL).
/// Provee la jerarquía principal de excepciones para el dominio de SGICE.
/// </summary>
public class NegocioExcepcion : Exception
{
    public NegocioExcepcion(string mensaje) : base(mensaje)
    {
    }

    public NegocioExcepcion(string mensaje, Exception innerException) : base(mensaje, innerException)
    {
    }
}

/// <summary>
/// Excepción lanzada cuando una validación de formato, campo obligatorio o rango no es superada.
/// </summary>
public class ValidacionNegocioExcepcion : NegocioExcepcion
{
    public string Campo { get; }

    public ValidacionNegocioExcepcion(string mensaje) : base(mensaje)
    {
        Campo = string.Empty;
    }

    public ValidacionNegocioExcepcion(string campo, string mensaje) : base(mensaje)
    {
        Campo = campo;
    }
}

/// <summary>
/// Excepción lanzada cuando se infringe una regla o invariante de negocio (ej. activo no disponible, usuario inactivo).
/// </summary>
public class ReglaNegocioExcepcion : NegocioExcepcion
{
    public ReglaNegocioExcepcion(string mensaje) : base(mensaje)
    {
    }

    public ReglaNegocioExcepcion(string mensaje, Exception innerException) : base(mensaje, innerException)
    {
    }
}

/// <summary>
/// Excepción lanzada cuando un registro solicitado no existe en la base de datos para una operación de negocio.
/// </summary>
public class EntidadNoEncontradaNegocioExcepcion : NegocioExcepcion
{
    public EntidadNoEncontradaNegocioExcepcion(string mensaje) : base(mensaje)
    {
    }

    public EntidadNoEncontradaNegocioExcepcion(string entidad, object id) 
        : base($"No se encontró la entidad '{entidad}' con el identificador '{id}'.")
    {
    }
}
