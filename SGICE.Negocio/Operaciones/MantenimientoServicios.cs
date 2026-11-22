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
/// Gestiona la atención técnica, cierre o rechazo de solicitudes y ejecución de intervenciones de mantenimiento en los bienes del centro.
/// </summary>
public class MantenimientoServicios
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="MantenimientoServicios"/>.
    /// </summary>
    public MantenimientoServicios()
    {
    }

    /// <summary>
    /// Obtiene un mantenimiento por su identificador primario.
    /// </summary>
    public Mantenimiento ObtenerPorId(int idMantenimiento)
    {
        Validador.ValidarIdPositivo(idMantenimiento, nameof(idMantenimiento));

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Mantenimiento>(ctx);
        var mantenimiento = repo.ObtenerPorId(idMantenimiento);

        if (mantenimiento == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Mantenimiento), idMantenimiento);
        }

        return mantenimiento;
    }

    /// <summary>
    /// Lista las solicitudes de mantenimiento que están pendientes de atención técnica.
    /// </summary>
    public List<SolicitudMantenimientoDTO> ListarSolicitudesPendientes()
    {
        using var ctx = new AppDbContext();
        return ctx.SolicitudMantenimiento
            .Include(s => s.Estado)
            .Where(s => s.EstadoId == (int)EstadoSolicitudMantenimiento.Pendiente)
            .Select(s => new SolicitudMantenimientoDTO
            {
                IdSolicitudMantenimiento = s.Id,
                FechaSolicitud = s.FechaSolicitud,
                EstadoId = s.EstadoId.GetValueOrDefault(),
                Estado = s.Estado != null ? s.Estado.Nombre : string.Empty
            })
            .OrderBy(s => s.IdSolicitudMantenimiento)
            .ToList();
    }

    /// <summary>
    /// Obtiene los ítems de detalle de una solicitud de mantenimiento listos para ser procesados como intervención.
    /// </summary>
    public List<DetalleMantenimientoDTO> ObtenerDetalleSolicitud(int idSolicitud)
    {
        Validador.ValidarIdPositivo(idSolicitud, nameof(idSolicitud));

        using var ctx = new AppDbContext();
        return ctx.DetalleSolicitudMantenimiento
            .Include(d => d.ActivoFisico)
                .ThenInclude(a => a!.Activo)
                    .ThenInclude(a => a!.SubCategoria)
                        .ThenInclude(s => s!.Categoria)
            .Include(d => d.ActivoFisico)
                .ThenInclude(a => a!.Activo)
                    .ThenInclude(a => a!.Marca)
            .Where(d => d.SolicitudMantenimientoId == idSolicitud)
            .Select(d => new DetalleMantenimientoDTO
            {
                ActivoFisicoId = d.ActivoFisicoId,
                ActivoId = d.ActivoFisico != null ? d.ActivoFisico.ActivoId : 0,
                Activo = d.ActivoFisico != null && d.ActivoFisico.Activo != null ? d.ActivoFisico.Activo.Nombre : string.Empty,
                CodEtiquetaQR = d.ActivoFisico != null ? d.ActivoFisico.CodEtiquetaQR : string.Empty,
                NumSerie = d.ActivoFisico != null && d.ActivoFisico.NumSerie != null ? d.ActivoFisico.NumSerie : string.Empty,
                MarcaId = d.ActivoFisico != null && d.ActivoFisico.Activo != null ? d.ActivoFisico.Activo.MarcaId : 0,
                Marca = d.ActivoFisico != null && d.ActivoFisico.Activo != null && d.ActivoFisico.Activo.Marca != null ? d.ActivoFisico.Activo.Marca.Nombre : string.Empty,
                CategoriaId = d.ActivoFisico != null && d.ActivoFisico.Activo != null && d.ActivoFisico.Activo.SubCategoria != null ? d.ActivoFisico.Activo.SubCategoria.CategoriaId : 0,
                Categoria = d.ActivoFisico != null && d.ActivoFisico.Activo != null && d.ActivoFisico.Activo.SubCategoria != null && d.ActivoFisico.Activo.SubCategoria.Categoria != null ? d.ActivoFisico.Activo.SubCategoria.Categoria.Nombre : string.Empty,
                SubCategoriaId = d.ActivoFisico != null && d.ActivoFisico.Activo != null ? d.ActivoFisico.Activo.SubCategoriaId : 0,
                SubCategoria = d.ActivoFisico != null && d.ActivoFisico.Activo != null && d.ActivoFisico.Activo.SubCategoria != null ? d.ActivoFisico.Activo.SubCategoria.Nombre : string.Empty,
                ProblemaReportado = d.DescripcionProblema ?? string.Empty,
                EstadoDetalleId = (int)EstadoDetalleMantenimiento.EnProceso,
                EstadoDetalle = "En Proceso",
                Solucion = string.Empty
            }).ToList();
    }

    /// <summary>
    /// Actualiza el estado del activo intervenido según el resultado reportado (Reparado -> Disponible; NoReparado -> Dañado).
    /// </summary>
    private void ActualizarEstadoActivo(ActivoFisicoServicios activoFisicoServicios, DetalleMantenimientoDTO item)
    {
        var activo = activoFisicoServicios.ObtenerPorId(item.ActivoFisicoId);

        switch (item.EstadoDetalleId)
        {
            case (int)EstadoDetalleMantenimiento.Reparado:
                activo.EstadoId = (int)EstadoActivoFisico.Disponible;
                break;
            case (int)EstadoDetalleMantenimiento.NoReparado:
                activo.EstadoId = (int)EstadoActivoFisico.Dañado;
                break;
        }

        activoFisicoServicios.Actualizar(activo);
    }

    /// <summary>
    /// Rechaza formalmente una solicitud de mantenimiento pendiente, marcando sus activos como 'Dañado' y auditando la acción.
    /// </summary>
    public void RechazarSolicitud(int idSolicitud)
    {
        Validador.ValidarIdPositivo(idSolicitud, nameof(idSolicitud));

        using var ctx = new AppDbContext();
        using var transaccion = ctx.Database.BeginTransaction();
        try
        {
            var solicitudServicios = new SolicitudMantenimientoServicios();
            var solicitud = solicitudServicios.ObtenerPorId(idSolicitud);

            if (solicitud.EstadoId != (int)EstadoSolicitudMantenimiento.Pendiente)
            {
                throw new ReglaNegocioExcepcion("La solicitud ya fue procesada previamente.");
            }

            solicitud.EstadoId = (int)EstadoSolicitudMantenimiento.Rechazada;
            solicitudServicios.Actualizar(solicitud);

            var activos = ctx.DetalleSolicitudMantenimiento
                .Where(d => d.SolicitudMantenimientoId == idSolicitud)
                .Select(d => d.ActivoFisicoId)
                .ToList();

            var activoFisicoServicios = new ActivoFisicoServicios();
            foreach (var id in activos)
            {
                var activo = activoFisicoServicios.ObtenerPorId(id);
                if (activo != null)
                {
                    activo.EstadoId = (int)EstadoActivoFisico.Dañado;
                    activoFisicoServicios.Actualizar(activo);
                }
            }

            ctx.SaveChanges();

            string valoresNuevos = $"SolicitudId: {solicitud.Id}, Estado: {solicitud.EstadoId} (Rechazada)";

            var auditoriaServicios = new AuditoriaServicios();
            auditoriaServicios.Registrar("Mantenimiento", solicitud.Id, TipoAccionAuditoria.Actualizar, string.Empty, valoresNuevos);

            transaccion.Commit();
        }
        catch (NegocioExcepcion)
        {
            transaccion.Rollback();
            throw;
        }
        catch (Exception ex)
        {
            transaccion.Rollback();
            throw new ReglaNegocioExcepcion("Error al rechazar la solicitud de mantenimiento.", ex);
        }
    }

    /// <summary>
    /// Valida los datos esenciales del mantenimiento y su detalle técnico.
    /// </summary>
    private void Validar(Mantenimiento mantenimiento, List<DetalleMantenimientoDTO> detalle)
    {
        if (mantenimiento == null)
            throw new ArgumentNullException(nameof(mantenimiento));

        Validador.ValidarIdPositivo(mantenimiento.SolicitudMantenimientoId, nameof(mantenimiento.SolicitudMantenimientoId));
        Validador.ValidarIdPositivo(mantenimiento.PersonalTecnicoId, nameof(mantenimiento.PersonalTecnicoId));

        if (detalle == null || detalle.Count == 0)
        {
            throw new ReglaNegocioExcepcion("No existen activos para registrar en el mantenimiento.");
        }

        foreach (var item in detalle)
        {
            Validador.ValidarIdPositivo(item.EstadoDetalleId, nameof(item.EstadoDetalleId));
            Validador.ValidarRequerido(item.Solucion, "Solución aplicada");
        }
    }

    /// <summary>
    /// Actualiza el estado de la solicitud de mantenimiento a 'Atendida'.
    /// </summary>
    private void ActualizarEstadoSolicitud(SolicitudMantenimientoServicios solicitudServicios, int idSolicitud)
    {
        var solicitud = solicitudServicios.ObtenerPorId(idSolicitud);
        solicitud.EstadoId = (int)EstadoSolicitudMantenimiento.Atendida;
        solicitudServicios.Actualizar(solicitud);
    }

    /// <summary>
    /// Registra el proceso de mantenimiento finalizado, actualizando el estado de cada activo intervenido y la solicitud asociada.
    /// </summary>
    public void RegistrarMantenimiento(Mantenimiento mantenimiento, List<DetalleMantenimientoDTO> detalle)
    {
        Validar(mantenimiento, detalle);

        mantenimiento.UsuarioRegistroId = SesionActual.Usuario?.Id ?? 1;
        mantenimiento.EstadoId = (int)EstadoMantenimiento.Finalizado;
        mantenimiento.FechaInicioAtencion = DateTime.Now;
        mantenimiento.FechaCierre = DateTime.Now;

        using var ctx = new AppDbContext();
        using var transaccion = ctx.Database.BeginTransaction();
        try
        {
            var repo = new RepositorioGenerico<Mantenimiento>(ctx);
            var detalleRepo = new RepositorioGenerico<DetalleMantenimiento>(ctx);
            var activoFisicoServicios = new ActivoFisicoServicios();
            var solicitudServicios = new SolicitudMantenimientoServicios();

            repo.Agregar(mantenimiento);
            ctx.SaveChanges();

            foreach (var activo in detalle)
            {
                var nuevoDetalle = new DetalleMantenimiento
                {
                    MantenimientoId = mantenimiento.Id,
                    ActivoFisicoId = activo.ActivoFisicoId,
                    Solucion = activo.Solucion
                };

                detalleRepo.Agregar(nuevoDetalle);
                ActualizarEstadoActivo(activoFisicoServicios, activo);
            }

            ActualizarEstadoSolicitud(solicitudServicios, mantenimiento.SolicitudMantenimientoId);
            ctx.SaveChanges();

            string valoresNuevos = $"MantenimientoId: {mantenimiento.Id}, SolicitudId: {mantenimiento.SolicitudMantenimientoId}, Técnico: {mantenimiento.PersonalTecnicoId}";

            var auditoriaServicios = new AuditoriaServicios();
            auditoriaServicios.Registrar("Mantenimiento", mantenimiento.Id, TipoAccionAuditoria.Crear, string.Empty, valoresNuevos);

            transaccion.Commit();
        }
        catch (NegocioExcepcion)
        {
            transaccion.Rollback();
            throw;
        }
        catch (Exception ex)
        {
            transaccion.Rollback();
            throw new ReglaNegocioExcepcion("Error al registrar la ejecución del mantenimiento.", ex);
        }
    }
}
