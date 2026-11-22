using Microsoft.EntityFrameworkCore;
using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Operaciones;

/// <summary>
/// Provee los servicios para la emisión, validación y control de solicitudes de mantenimiento preventivo y correctivo de activos.
/// </summary>
public class SolicitudMantenimientoServicios
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="SolicitudMantenimientoServicios"/>.
    /// </summary>
    public SolicitudMantenimientoServicios()
    {
    }

    /// <summary>
    /// Obtiene una solicitud de mantenimiento por su identificador primario.
    /// </summary>
    public SolicitudMantenimiento ObtenerPorId(int idSolicitud)
    {
        Validador.ValidarIdPositivo(idSolicitud, nameof(idSolicitud));

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<SolicitudMantenimiento>(ctx);
        var solicitud = repo.ObtenerPorId(idSolicitud);

        if (solicitud == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(SolicitudMantenimiento), idSolicitud);
        }

        return solicitud;
    }

    /// <summary>
    /// Obtiene la información técnica de un activo físico para agregarlo a una solicitud de mantenimiento.
    /// </summary>
    public DetalleSolicitudMantenimientoDTO? ObtenerActivoParaSolicitud(int activoFisicoId)
    {
        Validador.ValidarIdPositivo(activoFisicoId, nameof(activoFisicoId));

        using var ctx = new AppDbContext();
        return ctx.ActivoFisico
            .Include(a => a.Activo)
                .ThenInclude(a => a!.SubCategoria)
            .Include(a => a.Activo)
                .ThenInclude(a => a!.Marca)
            .Where(a => a.Id == activoFisicoId)
            .Select(a => new DetalleSolicitudMantenimientoDTO
            {
                ActivoFisicoId = a.Id,
                ActivoId = a.ActivoId,
                Activo = a.Activo != null ? a.Activo.Nombre : string.Empty,
                CodEtiquetaQR = a.CodEtiquetaQR,
                NumSerie = a.NumSerie ?? string.Empty,
                SubCategoriaId = a.Activo != null ? a.Activo.SubCategoriaId : 0,
                SubCategoria = a.Activo != null && a.Activo.SubCategoria != null ? a.Activo.SubCategoria.Nombre : string.Empty,
                MarcaId = a.Activo != null ? a.Activo.MarcaId : 0,
                Marca = a.Activo != null && a.Activo.Marca != null ? a.Activo.Marca.Nombre : string.Empty,
                DescripcionProblema = string.Empty
            }).FirstOrDefault();
    }

    /// <summary>
    /// Obtiene el total de solicitudes de mantenimiento registradas.
    /// </summary>
    public int Contar()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<SolicitudMantenimiento>(ctx);
        return repo.Consultar().Count();
    }

    /// <summary>
    /// Obtiene el total de solicitudes en un estado determinado.
    /// </summary>
    public int ContarPorEstado(int idEstado)
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<SolicitudMantenimiento>(ctx);
        return repo.Consultar().Count(x => x.EstadoId == idEstado);
    }

    /// <summary>
    /// Lista las solicitudes de mantenimiento registradas con su estado.
    /// </summary>
    public List<SolicitudMantenimientoDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.SolicitudMantenimiento
            .Include(s => s.Estado)
            .Select(s => new SolicitudMantenimientoDTO
            {
                IdSolicitudMantenimiento = s.Id,
                FechaSolicitud = s.FechaSolicitud,
                EstadoId = s.EstadoId.GetValueOrDefault(),
                Estado = s.Estado != null ? s.Estado.Nombre : string.Empty
            })
            .OrderByDescending(s => s.IdSolicitudMantenimiento)
            .ToList();
    }

    /// <summary>
    /// Valida que el activo no posea solicitudes de mantenimiento pendientes activas.
    /// </summary>
    public void ValidarActivoDisponible(AppDbContext ctx, int activoFisicoId)
    {
        bool existe = ctx.DetalleSolicitudMantenimiento
            .Include(d => d.SolicitudMantenimiento)
            .Any(d => d.ActivoFisicoId == activoFisicoId &&
                      d.SolicitudMantenimiento != null &&
                      d.SolicitudMantenimiento.EstadoId == (int)EstadoSolicitudMantenimiento.Pendiente);

        if (existe)
        {
            throw new ReglaNegocioExcepcion("El activo ya posee una solicitud de mantenimiento pendiente.");
        }
    }

    /// <summary>
    /// Valida que el activo no se encuentre prestado ni ya pendiente de mantenimiento.
    /// </summary>
    private void ValidarActivo(ActivoFisico activo)
    {
        if (activo == null)
            throw new ReglaNegocioExcepcion("El activo no existe.");

        if (activo.EstadoId == (int)EstadoActivoFisico.Prestado)
        {
            throw new ReglaNegocioExcepcion("El activo se encuentra prestado actualmente.");
        }

        if (activo.EstadoId == (int)EstadoActivoFisico.PendienteDeMantenimiento)
        {
            throw new ReglaNegocioExcepcion("El activo ya se encuentra en estado 'Pendiente de Mantenimiento'.");
        }
    }

    /// <summary>
    /// Valida los datos requeridos de la solicitud y sus renglones.
    /// </summary>
    private void Validar(SolicitudMantenimiento solicitud, List<DetalleSolicitudMantenimientoDTO> detalle)
    {
        if (solicitud == null)
            throw new ArgumentNullException(nameof(solicitud));

        if (detalle == null || detalle.Count == 0)
        {
            throw new ReglaNegocioExcepcion("Debe agregar al menos un activo a la solicitud.");
        }

        if (solicitud.FechaSolicitud.Date > DateTime.Today)
        {
            throw new ReglaNegocioExcepcion("La fecha de solicitud no puede ser posterior al día de hoy.");
        }

        foreach (var activo in detalle)
        {
            Validador.ValidarRequerido(activo.DescripcionProblema, "Descripción del Problema");
        }
    }

    /// <summary>
    /// Registra la solicitud de mantenimiento y sus renglones, cambiando el estado de los activos a 'PendienteDeMantenimiento' de forma transaccional.
    /// </summary>
    public int RegistrarSolicitud(SolicitudMantenimiento solicitud, List<DetalleSolicitudMantenimientoDTO> detalle)
    {
        Validar(solicitud, detalle);

        solicitud.UsuarioRegistroId = SesionActual.Usuario?.Id ?? 1;
        solicitud.EstadoId = (int)EstadoSolicitudMantenimiento.Pendiente;

        using var ctx = new AppDbContext();
        using var transaccion = ctx.Database.BeginTransaction();
        try
        {
            var repo = new RepositorioGenerico<SolicitudMantenimiento>(ctx);
            var detalleRepo = new RepositorioGenerico<DetalleSolicitudMantenimiento>(ctx);
            var activoFisicoServicios = new ActivoFisicoServicios();

            repo.Agregar(solicitud);
            ctx.SaveChanges();

            foreach (var activos in detalle)
            {
                var activo = activoFisicoServicios.ObtenerPorId(activos.ActivoFisicoId);
                ValidarActivo(activo);
                ValidarActivoDisponible(ctx, activos.ActivoFisicoId);

                var nuevoDetalle = new DetalleSolicitudMantenimiento
                {
                    SolicitudMantenimientoId = solicitud.Id,
                    ActivoFisicoId = activos.ActivoFisicoId,
                    DescripcionProblema = activos.DescripcionProblema
                };
                detalleRepo.Agregar(nuevoDetalle);

                activo.EstadoId = (int)EstadoActivoFisico.PendienteDeMantenimiento;
                activoFisicoServicios.Actualizar(activo);
            }

            ctx.SaveChanges();

            string valoresNuevos = $"FechaSolicitud: {solicitud.FechaSolicitud}, Obs: {solicitud.ObservacionGeneral}, Estado: {solicitud.EstadoId}";

            var auditoriaServicios = new AuditoriaServicios();
            auditoriaServicios.Registrar("Solicitud Mantenimiento", solicitud.Id, TipoAccionAuditoria.Crear, string.Empty, valoresNuevos);

            transaccion.Commit();
            return solicitud.Id;
        }
        catch (NegocioExcepcion)
        {
            transaccion.Rollback();
            throw;
        }
        catch (Exception ex)
        {
            transaccion.Rollback();
            throw new ReglaNegocioExcepcion("Error al registrar la solicitud de mantenimiento.", ex);
        }
    }

    /// <summary>
    /// Verifica si un activo físico ya fue agregado a la lista de detalles de la solicitud.
    /// </summary>
    public bool ExisteActivoEnDetalle(List<DetalleSolicitudMantenimientoDTO> detalle, int activoFisicoId)
    {
        return detalle.Any(x => x.ActivoFisicoId == activoFisicoId);
    }

    /// <summary>
    /// Agrega un nuevo ítem a la lista de solicitud en memoria.
    /// </summary>
    public void AgregarDetalle(List<DetalleSolicitudMantenimientoDTO> detalle, DetalleSolicitudMantenimientoDTO nuevo)
    {
        if (nuevo == null)
            throw new ArgumentNullException(nameof(nuevo));

        if (ExisteActivoEnDetalle(detalle, nuevo.ActivoFisicoId))
        {
            throw new ReglaNegocioExcepcion("Este activo ya fue agregado a la solicitud.");
        }

        detalle.Add(nuevo);
    }

    /// <summary>
    /// Remueve un activo de la solicitud en memoria.
    /// </summary>
    public void EliminarDetalle(List<DetalleSolicitudMantenimientoDTO> detalle, int activoFisicoId)
    {
        var item = detalle.FirstOrDefault(x => x.ActivoFisicoId == activoFisicoId);
        if (item == null)
        {
            throw new ReglaNegocioExcepcion("El activo no existe en la solicitud.");
        }
        detalle.Remove(item);
    }

    /// <summary>
    /// Obtiene el próximo número identificador proyectado para la solicitud.
    /// </summary>
    public int ObtenerProximoNumeroSolicitud()
    {
        using var ctx = new AppDbContext();
        if (!ctx.SolicitudMantenimiento.Any())
        {
            return 1;
        }
        return ctx.SolicitudMantenimiento.Max(s => s.Id) + 1;
    }

    /// <summary>
    /// Actualiza una solicitud de mantenimiento existente.
    /// </summary>
    public void Actualizar(SolicitudMantenimiento solicitud)
    {
        if (solicitud == null)
            throw new ArgumentNullException(nameof(solicitud));

        Validador.ValidarIdPositivo(solicitud.Id, nameof(solicitud.Id));

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<SolicitudMantenimiento>(ctx);
        repo.Actualizar(solicitud);
        ctx.SaveChanges();
    }
}
