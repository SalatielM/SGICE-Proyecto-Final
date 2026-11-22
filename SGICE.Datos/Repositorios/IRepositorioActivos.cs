using SGICE.Entidades;

namespace SGICE.Datos.Repositorios;

/// <summary>
/// Interfaz especializada para operaciones críticas sobre activos físicos
/// que requieren transacciones explícitas (IDbContextTransaction).
/// </summary>
public interface IRepositorioActivos : IRepositorioGenerico<ActivoFisico>
{
    /// <summary>
    /// Asigna un activo físico a una ubicación y/o encargado dentro de una transacción explícita.
    /// </summary>
    bool AsignarActivoConTransaccion(int activoFisicoId, int nuevaUbicacionId, int nuevoEncargadoId, int usuarioRegistroId, string observaciones);

    /// <summary>
    /// Versión asíncrona de asignación de activo con transacción explícita.
    /// </summary>
    Task<bool> AsignarActivoConTransaccionAsync(int activoFisicoId, int nuevaUbicacionId, int nuevoEncargadoId, int usuarioRegistroId, string observaciones);

    /// <summary>
    /// Registra el traslado formal de múltiples activos físicos hacia una nueva ubicación mediante una transacción explícita.
    /// </summary>
    bool TrasladarActivosConTransaccion(Traslado traslado, IEnumerable<DetalleTraslado> detalles);

    /// <summary>
    /// Versión asíncrona de traslado de activos con transacción explícita.
    /// </summary>
    Task<bool> TrasladarActivosConTransaccionAsync(Traslado traslado, IEnumerable<DetalleTraslado> detalles);

    /// <summary>
    /// Registra la salida / descargo definitivo de activos físicos mediante una transacción explícita.
    /// </summary>
    bool DescargarActivosConTransaccion(Salida salida, IEnumerable<DetalleSalida> detalles);

    /// <summary>
    /// Versión asíncrona de descargo de activos con transacción explícita.
    /// </summary>
    Task<bool> DescargarActivosConTransaccionAsync(Salida salida, IEnumerable<DetalleSalida> detalles);
}
