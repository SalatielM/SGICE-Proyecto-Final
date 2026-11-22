using Microsoft.EntityFrameworkCore;
using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;
using SGICE.Negocio.Utilidades;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Operaciones;

/// <summary>
/// Provee la lógica de negocio, validaciones y consultas para la gestión integral de activos físicos individuales.
/// </summary>
public class ActivoFisicoServicios
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="ActivoFisicoServicios"/>.
    /// </summary>
    public ActivoFisicoServicios()
    {
    }

    /// <summary>
    /// Obtiene la lista completa de activos físicos registrados en el sistema.
    /// </summary>
    /// <returns>Lista de entidades <see cref="ActivoFisico"/>.</returns>
    public List<ActivoFisico> ObtenerTodo()
    {
        try
        {
            using var ctx = new AppDbContext();
            var repo = new RepositorioGenerico<ActivoFisico>(ctx);
            return repo.ObtenerTodos().ToList();
        }
        catch (NegocioExcepcion)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion("Error al obtener el listado de activos físicos.", ex);
        }
    }

    /// <summary>
    /// Obtiene un activo físico por su identificador primario.
    /// </summary>
    /// <param name="id">Identificador único del activo físico.</param>
    /// <returns>Entidad <see cref="ActivoFisico"/> encontrada.</returns>
    /// <exception cref="ValidacionNegocioExcepcion">Si el identificador no es positivo.</exception>
    /// <exception cref="EntidadNoEncontradaNegocioExcepcion">Si el activo físico no existe.</exception>
    public ActivoFisico ObtenerPorId(int id)
    {
        Validador.ValidarIdPositivo(id, nameof(id));

        try
        {
            using var ctx = new AppDbContext();
            var repo = new RepositorioGenerico<ActivoFisico>(ctx);
            var activo = repo.ObtenerPorId(id);
            if (activo == null)
            {
                throw new EntidadNoEncontradaNegocioExcepcion(nameof(ActivoFisico), id);
            }
            return activo;
        }
        catch (NegocioExcepcion)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion($"Error al obtener el activo físico con ID {id}.", ex);
        }
    }

    /// <summary>
    /// Obtiene el DTO de un activo físico a partir de su código de etiqueta QR o su número de serie.
    /// </summary>
    /// <param name="activoFisico">Código QR o número de serie a buscar.</param>
    /// <returns>Objeto <see cref="ActivoFisicoDTO"/> con información detallada.</returns>
    /// <exception cref="ValidacionNegocioExcepcion">Si el criterio de búsqueda está vacío.</exception>
    /// <exception cref="EntidadNoEncontradaNegocioExcepcion">Si no se localiza ningún activo.</exception>
    public ActivoFisicoDTO ObtenerDtoPorEtiqueta(string activoFisico)
    {
        Validador.ValidarRequerido(activoFisico, nameof(activoFisico));

        string criterio = activoFisico.Trim();

        try
        {
            using var ctx = new AppDbContext();
            var activo = ctx.ActivoFisico
                .Include(a => a.Activo)
                    .ThenInclude(a => a!.Marca)
                .Include(a => a.Activo)
                    .ThenInclude(a => a!.SubCategoria)
                .Include(a => a.Ubicacion)
                .Include(a => a.Estado)
                .FirstOrDefault(a => a.CodEtiquetaQR == criterio || a.NumSerie == criterio);

            if (activo == null)
            {
                throw new EntidadNoEncontradaNegocioExcepcion($"El activo con código o serie '{criterio}' no existe o es incorrecto.");
            }

            return new ActivoFisicoDTO
            {
                IdActivoFisico = activo.Id,
                ActivoId = activo.ActivoId,
                Activo = activo.Activo?.Nombre ?? string.Empty,
                CodEtiquetaQR = activo.CodEtiquetaQR,
                NumSerie = activo.NumSerie ?? string.Empty,
                MarcaId = activo.Activo?.MarcaId ?? 0,
                Marca = activo.Activo?.Marca?.Nombre ?? string.Empty,
                SubCategoriaId = activo.Activo?.SubCategoriaId ?? 0,
                SubCategoria = activo.Activo?.SubCategoria?.Nombre ?? string.Empty,
                UbicacionId = activo.UbicacionId,
                Ubicacion = activo.Ubicacion?.Nombre ?? "Sin Ubicación",
                EstadoId = activo.EstadoId.GetValueOrDefault(),
                Estado = activo.Estado?.Nombre ?? string.Empty,
                FechaRegistro = activo.FechaRegistro
            };
        }
        catch (NegocioExcepcion)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion($"Error al buscar activo físico por etiqueta '{criterio}'.", ex);
        }
    }

    /// <summary>
    /// Valida que el activo físico exista, tenga estado válido y se encuentre disponible para operaciones.
    /// </summary>
    /// <param name="id">Identificador del activo físico.</param>
    /// <exception cref="ReglaNegocioExcepcion">Si el activo no se encuentra disponible.</exception>
    public void ValidarEstadoActivoFisico(int id)
    {
        var activo = ObtenerPorId(id);
        var estadoServicios = new EstadoServicios();
        estadoServicios.ValidarEstado(activo.EstadoId.GetValueOrDefault(), TipoEstadoEnum.ActivoFisico);

        if (activo.EstadoId != (int)EstadoActivoFisico.Disponible)
        {
            throw new ReglaNegocioExcepcion($"El activo físico '{activo.CodEtiquetaQR}' no se encuentra disponible para ser utilizado o trasladado.");
        }
    }

    /// <summary>
    /// Obtiene la cantidad total de activos físicos registrados.
    /// </summary>
    /// <returns>Total de activos físicos.</returns>
    public int Contar()
    {
        try
        {
            using var ctx = new AppDbContext();
            var repo = new RepositorioGenerico<ActivoFisico>(ctx);
            return repo.Consultar().Count();
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion("Error al contar activos físicos.", ex);
        }
    }

    /// <summary>
    /// Obtiene la cantidad de activos físicos asociados a un estado particular.
    /// </summary>
    /// <param name="idEstado">Identificador del estado.</param>
    /// <returns>Cantidad de activos físicos en el estado indicado.</returns>
    public int ContarPorEstado(int idEstado)
    {
        try
        {
            using var ctx = new AppDbContext();
            var repo = new RepositorioGenerico<ActivoFisico>(ctx);
            return repo.Consultar().Count(x => x.EstadoId == idEstado);
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion($"Error al contar activos físicos con estado {idEstado}.", ex);
        }
    }

    /// <summary>
    /// Obtiene la lista proyectada en DTO de todos los activos físicos que no se encuentren dados de baja.
    /// </summary>
    /// <returns>Lista de <see cref="ActivoFisicoDTO"/>.</returns>
    public List<ActivoFisicoDTO> Listar()
    {
        try
        {
            using var ctx = new AppDbContext();
            return ctx.ActivoFisico
                .Include(af => af.Activo)
                    .ThenInclude(a => a!.SubCategoria)
                        .ThenInclude(s => s!.Categoria)
                .Include(af => af.Activo)
                    .ThenInclude(a => a!.Marca)
                .Include(af => af.Estado)
                .Include(af => af.Ubicacion)
                .Where(af => af.EstadoId != (int)EstadoActivoFisico.DadoDeBaja)
                .Select(af => new ActivoFisicoDTO
                {
                    IdActivoFisico = af.Id,
                    ActivoId = af.ActivoId,
                    Activo = af.Activo != null ? af.Activo.Nombre : string.Empty,
                    CodEtiquetaQR = af.CodEtiquetaQR,
                    NumSerie = af.NumSerie ?? string.Empty,
                    CategoriaId = af.Activo != null && af.Activo.SubCategoria != null ? af.Activo.SubCategoria.CategoriaId : 0,
                    Categoria = af.Activo != null && af.Activo.SubCategoria != null && af.Activo.SubCategoria.Categoria != null ? af.Activo.SubCategoria.Categoria.Nombre : string.Empty,
                    SubCategoriaId = af.Activo != null ? af.Activo.SubCategoriaId : 0,
                    SubCategoria = af.Activo != null && af.Activo.SubCategoria != null ? af.Activo.SubCategoria.Nombre : string.Empty,
                    MarcaId = af.Activo != null ? af.Activo.MarcaId : 0,
                    Marca = af.Activo != null && af.Activo.Marca != null ? af.Activo.Marca.Nombre : string.Empty,
                    EstadoId = af.EstadoId.GetValueOrDefault(),
                    Estado = af.Estado != null ? af.Estado.Nombre : string.Empty,
                    UbicacionId = af.UbicacionId,
                    Ubicacion = af.Ubicacion != null ? af.Ubicacion.Nombre : "Sin Ubicación",
                    FechaRegistro = af.FechaRegistro
                }).ToList();
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion("Error al listar los activos físicos.", ex);
        }
    }

    /// <summary>
    /// Lista los activos físicos disponibles correspondientes a una subcategoría específica.
    /// </summary>
    /// <param name="idSubCategoria">Identificador de la subcategoría.</param>
    /// <returns>Lista de <see cref="ActivoFisicoDTO"/> disponibles.</returns>
    public List<ActivoFisicoDTO> ListarDisponiblesPorSubCategoria(int idSubCategoria)
    {
        Validador.ValidarIdPositivo(idSubCategoria, nameof(idSubCategoria));

        try
        {
            using var ctx = new AppDbContext();
            return ctx.ActivoFisico
                .Include(a => a.Activo)
                    .ThenInclude(a => a!.SubCategoria)
                .Include(a => a.Activo)
                    .ThenInclude(a => a!.Marca)
                .Include(a => a.Estado)
                .Where(a => a.Activo != null && a.Activo.SubCategoriaId == idSubCategoria && a.EstadoId == (int)EstadoActivoFisico.Disponible)
                .Select(a => new ActivoFisicoDTO
                {
                    IdActivoFisico = a.Id,
                    ActivoId = a.ActivoId,
                    Activo = a.Activo != null ? a.Activo.Nombre : string.Empty,
                    CodEtiquetaQR = a.CodEtiquetaQR,
                    NumSerie = a.NumSerie ?? string.Empty,
                    SubCategoriaId = a.Activo != null ? a.Activo.SubCategoriaId : 0,
                    SubCategoria = a.Activo != null && a.Activo.SubCategoria != null ? a.Activo.SubCategoria.Nombre : string.Empty,
                    MarcaId = a.Activo != null ? a.Activo.MarcaId : 0,
                    Marca = a.Activo != null && a.Activo.Marca != null ? a.Activo.Marca.Nombre : string.Empty,
                    EstadoId = a.EstadoId.GetValueOrDefault(),
                    Estado = a.Estado != null ? a.Estado.Nombre : string.Empty,
                    FechaRegistro = a.FechaRegistro
                })
                .OrderBy(a => a.Activo)
                .ToList();
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion($"Error al listar activos físicos disponibles para la subcategoría {idSubCategoria}.", ex);
        }
    }

    /// <summary>
    /// Filtra los activos físicos según múltiples criterios opcionales (búsqueda dinámica).
    /// </summary>
    public List<ActivoFisicoDTO> FiltrarActivosFisicos(
        int? activoId = null,
        int? marcaId = null,
        DateTime? fechaRegistro = null,
        int? subCategoriaId = null,
        int? estadoId = null,
        int? ubicacionId = null,
        string etiquetaBusqueda = "")
    {
        try
        {
            using var ctx = new AppDbContext();
            var query = ctx.ActivoFisico
                .Include(af => af.Activo)
                    .ThenInclude(a => a!.SubCategoria)
                .Include(af => af.Activo)
                    .ThenInclude(a => a!.Marca)
                .Include(af => af.Estado)
                .Include(af => af.Ubicacion)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(etiquetaBusqueda))
            {
                string termino = etiquetaBusqueda.Trim().ToLower();
                query = query.Where(af => af.CodEtiquetaQR.ToLower().Contains(termino) || (af.NumSerie != null && af.NumSerie.ToLower().Contains(termino)));
            }

            if (activoId.HasValue && activoId.Value > 0)
            {
                query = query.Where(a => a.ActivoId == activoId.Value);
            }

            if (marcaId.HasValue && marcaId.Value > 0)
            {
                query = query.Where(a => a.Activo != null && a.Activo.MarcaId == marcaId.Value);
            }

            if (fechaRegistro.HasValue)
            {
                var fecha = fechaRegistro.Value.Date;
                query = query.Where(af => af.FechaRegistro.Date == fecha);
            }

            if (subCategoriaId.HasValue && subCategoriaId.Value > 0)
            {
                query = query.Where(af => af.Activo != null && af.Activo.SubCategoriaId == subCategoriaId.Value);
            }

            if (estadoId.HasValue && estadoId.Value > 0)
            {
                query = query.Where(af => af.EstadoId == estadoId.Value);
            }

            if (ubicacionId.HasValue && ubicacionId.Value > 0)
            {
                query = query.Where(af => af.UbicacionId == ubicacionId.Value);
            }

            return query.Select(af => new ActivoFisicoDTO
            {
                IdActivoFisico = af.Id,
                ActivoId = af.ActivoId,
                Activo = af.Activo != null ? af.Activo.Nombre : string.Empty,
                CodEtiquetaQR = af.CodEtiquetaQR,
                NumSerie = af.NumSerie ?? string.Empty,
                SubCategoriaId = af.Activo != null ? af.Activo.SubCategoriaId : 0,
                SubCategoria = af.Activo != null && af.Activo.SubCategoria != null ? af.Activo.SubCategoria.Nombre : string.Empty,
                MarcaId = af.Activo != null ? af.Activo.MarcaId : 0,
                Marca = af.Activo != null && af.Activo.Marca != null ? af.Activo.Marca.Nombre : string.Empty,
                EstadoId = af.EstadoId.GetValueOrDefault(),
                Estado = af.Estado != null ? af.Estado.Nombre : string.Empty,
                UbicacionId = af.UbicacionId,
                Ubicacion = af.Ubicacion != null ? af.Ubicacion.Nombre : "Sin Ubicación",
                FechaRegistro = af.FechaRegistro
            }).ToList();
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion("Error al filtrar activos físicos.", ex);
        }
    }

    /// <summary>
    /// Actualiza un activo físico en la base de datos.
    /// </summary>
    /// <param name="activo">Entidad <see cref="ActivoFisico"/> con los datos modificados.</param>
    public void Actualizar(ActivoFisico activo)
    {
        if (activo == null)
            throw new ArgumentNullException(nameof(activo));

        Validador.ValidarIdPositivo(activo.Id, nameof(activo.Id));

        try
        {
            using var ctx = new AppDbContext();
            var repo = new RepositorioGenerico<ActivoFisico>(ctx);
            repo.Actualizar(activo);
            ctx.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion($"Error al actualizar el activo físico con ID {activo.Id}.", ex);
        }
    }

    /// <summary>
    /// Asigna un activo físico a una nueva ubicación y/o encargado ejecutando una transacción explícita en base de datos.
    /// </summary>
    /// <param name="activoFisicoId">Identificador del activo físico.</param>
    /// <param name="nuevaUbicacionId">Identificador de la ubicación de destino.</param>
    /// <param name="nuevoEncargadoId">Identificador del personal encargado (opcional o 0).</param>
    /// <param name="observaciones">Observaciones adicionales sobre la asignación.</param>
    /// <returns>True si la asignación y transacción concluyeron con éxito.</returns>
    public bool AsignarActivo(int activoFisicoId, int nuevaUbicacionId, int nuevoEncargadoId, string observaciones)
    {
        Validador.ValidarIdPositivo(activoFisicoId, nameof(activoFisicoId));
        Validador.ValidarIdPositivo(nuevaUbicacionId, nameof(nuevaUbicacionId));

        int usuarioId = SesionActual.Usuario?.Id ?? 1;

        try
        {
            using var ctx = new AppDbContext();
            var repoActivos = new RepositorioActivos(ctx);
            return repoActivos.AsignarActivoConTransaccion(activoFisicoId, nuevaUbicacionId, nuevoEncargadoId, usuarioId, observaciones ?? string.Empty);
        }
        catch (NegocioExcepcion)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new ReglaNegocioExcepcion($"Error al asignar el activo físico {activoFisicoId} con transacción.", ex);
        }
    }
}
