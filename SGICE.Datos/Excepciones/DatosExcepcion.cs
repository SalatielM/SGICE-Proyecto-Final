namespace SGICE.Datos.Excepciones;

/// <summary>
/// Excepción base para errores ocurridos en la capa de acceso a datos (DAL).
/// Provee manejo jerárquico de excepciones técnicas y de base de datos.
/// </summary>
public class DatosExcepcion : Exception
{
    public DatosExcepcion(string mensaje) : base(mensaje)
    {
    }

    public DatosExcepcion(string mensaje, Exception innerException) : base(mensaje, innerException)
    {
    }
}

/// <summary>
/// Excepción lanzada cuando ocurre un conflicto de concurrencia al actualizar registros.
/// </summary>
public class ConcurrenciaDatosExcepcion : DatosExcepcion
{
    public ConcurrenciaDatosExcepcion(string mensaje, Exception innerException) 
        : base(mensaje, innerException)
    {
    }
}

/// <summary>
/// Excepción lanzada cuando un registro solicitado no existe en la base de datos.
/// </summary>
public class RegistroNoEncontradoExcepcion : DatosExcepcion
{
    public RegistroNoEncontradoExcepcion(string entidad, object id) 
        : base($"No se encontró ningún registro de tipo '{entidad}' con el identificador '{id}'.")
    {
    }
}

/// <summary>
/// Excepción lanzada cuando falla una transacción explícita de base de datos.
/// </summary>
public class TransaccionDatosExcepcion : DatosExcepcion
{
    public TransaccionDatosExcepcion(string operacion, Exception innerException) 
        : base($"Error al ejecutar la transacción para la operación '{operacion}'. Los cambios fueron revertidos.", innerException)
    {
    }
}
