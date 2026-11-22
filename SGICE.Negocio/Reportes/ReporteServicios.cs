using System.Data;
using SGICE.Datos.Repositorios;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Excepciones;

namespace SGICE.Negocio.Reportes;

/// <summary>
/// Provee los servicios de consulta y extracción de datos consolidados para la generación de reportes del sistema.
/// </summary>
public class ReporteServicios
{
    private readonly RepositorioReportes _repo;

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="ReporteServicios"/>.
    /// </summary>
    public ReporteServicios()
    {
        _repo = new RepositorioReportes();
    }

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="ReporteServicios"/> con un repositorio inyectado.
    /// </summary>
    /// <param name="repo">Instancia de <see cref="RepositorioReportes"/>.</param>
    public ReporteServicios(RepositorioReportes repo)
    {
        _repo = repo ?? throw new ArgumentNullException(nameof(repo));
    }

    /// <summary>
    /// Obtiene un conjunto de datos tabular (DataTable) para la emisión de reportes según los criterios y filtros indicados.
    /// </summary>
    /// <param name="tipo">Tipo de reporte a generar.</param>
    /// <param name="filtros">Objeto <see cref="ReporteFiltroDTO"/> con los filtros parametrizados.</param>
    /// <returns>Objeto <see cref="DataTable"/> con los registros consolidados.</returns>
    public DataTable ObtenerReporte(TipoReporte tipo, ReporteFiltroDTO filtros)
    {
        if (filtros == null)
            throw new ArgumentNullException(nameof(filtros));

        try
        {
            return _repo.ObtenerReporte(tipo, filtros);
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion($"Error al obtener el reporte de tipo '{tipo}'.", ex);
        }
    }
}
