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
/// Provee la lógica de negocio y registro transaccional para la devolución de activos físicos previamente prestados.
/// </summary>
public class DevolucionServicios
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="DevolucionServicios"/>.
    /// </summary>
    public DevolucionServicios()
    {
    }

    /// <summary>
    /// Obtiene una devolución por su identificador primario.
    /// </summary>
    public Devolucion ObtenerPorId(int idDevolucion)
    {
        Validador.ValidarIdPositivo(idDevolucion, nameof(idDevolucion));

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Devolucion>(ctx);
        var devolucion = repo.ObtenerPorId(idDevolucion);
        if (devolucion == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Devolucion), idDevolucion);
        }
        return devolucion;
    }

    /// <summary>
    /// Obtiene el listado de devoluciones procesadas con sus solicitantes y fechas.
    /// </summary>
    public List<DetalleDevolucionDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Devolucion
            .Include(d => d.Prestamo)
                .ThenInclude(p => p!.PersonalSolicitante)
            .Select(d => new DetalleDevolucionDTO
            {
                DevolucionId = d.Id,
                PrestamoId = d.Prestamo != null ? d.Prestamo.PersonalSolicitanteId : 0,
                Solicitante = d.Prestamo != null && d.Prestamo.PersonalSolicitante != null ? $"{d.Prestamo.PersonalSolicitante.Nombre} {d.Prestamo.PersonalSolicitante.Apellido}" : string.Empty,
                CodPersonal = d.Prestamo != null && d.Prestamo.PersonalSolicitante != null ? d.Prestamo.PersonalSolicitante.CodPersonal : string.Empty,
                FechaPrestamo = d.Prestamo != null ? d.Prestamo.FechaPrestamo : DateTime.MinValue,
                FechaDevolucion = d.FechaDevolucion
            }).ToList();
    }

    /// <summary>
    /// Obtiene la lista de activos de un préstamo que aún no han sido devueltos.
    /// </summary>
    public List<DetalleDevolucionDTO> ObtenerDetallePrestamo(int idPrestamo)
    {
        Validador.ValidarIdPositivo(idPrestamo, nameof(idPrestamo));

        using var ctx = new AppDbContext();
        var activosDevueltos = ctx.DetalleDevolucion
            .Include(dd => dd.Devolucion)
            .Where(dd => dd.Devolucion != null && dd.Devolucion.PrestamoId == idPrestamo)
            .Select(dd => dd.ActivoFisicoId)
            .ToList();

        return ctx.DetallePrestamo
            .Include(dp => dp.ActivoFisico)
                .ThenInclude(af => af!.Activo)
                    .ThenInclude(a => a!.SubCategoria)
            .Include(dp => dp.ActivoFisico)
                .ThenInclude(af => af!.Activo)
                    .ThenInclude(a => a!.Marca)
            .Include(dp => dp.ActivoFisico)
                .ThenInclude(af => af!.Estado)
            .Where(dp => dp.PrestamoId == idPrestamo && !activosDevueltos.Contains(dp.ActivoFisicoId))
            .Select(dp => new DetalleDevolucionDTO
            {
                ActivoFisicoId = dp.ActivoFisicoId,
                ActivoId = dp.ActivoFisico != null ? dp.ActivoFisico.ActivoId : 0,
                Activo = dp.ActivoFisico != null && dp.ActivoFisico.Activo != null ? dp.ActivoFisico.Activo.Nombre : string.Empty,
                CodEtiquetaQR = dp.ActivoFisico != null ? dp.ActivoFisico.CodEtiquetaQR : string.Empty,
                NumSerie = dp.ActivoFisico != null && dp.ActivoFisico.NumSerie != null ? dp.ActivoFisico.NumSerie : string.Empty,
                SubCategoriaId = dp.ActivoFisico != null && dp.ActivoFisico.Activo != null ? dp.ActivoFisico.Activo.SubCategoriaId : 0,
                SubCategoria = dp.ActivoFisico != null && dp.ActivoFisico.Activo != null && dp.ActivoFisico.Activo.SubCategoria != null ? dp.ActivoFisico.Activo.SubCategoria.Nombre : string.Empty,
                MarcaId = dp.ActivoFisico != null && dp.ActivoFisico.Activo != null ? dp.ActivoFisico.Activo.MarcaId : 0,
                Marca = dp.ActivoFisico != null && dp.ActivoFisico.Activo != null && dp.ActivoFisico.Activo.Marca != null ? dp.ActivoFisico.Activo.Marca.Nombre : string.Empty,
                EstadoDevolucionId = (int)EstadoDetalleDevolucion.Bueno,
                EstadoDevolucion = "Bueno",
                Obervacion = string.Empty
            }).ToList();
    }

    /// <summary>
    /// Valida los datos principales de la devolución.
    /// </summary>
    private void Validar(Devolucion devolucion, List<DetalleDevolucionDTO> detalle)
    {
        if (devolucion == null)
            throw new ArgumentNullException(nameof(devolucion));

        Validador.ValidarIdPositivo(devolucion.PrestamoId, nameof(devolucion.PrestamoId));

        if (detalle == null || detalle.Count == 0)
        {
            throw new ReglaNegocioExcepcion("Debe devolver al menos un activo en la operación.");
        }

        if (devolucion.FechaDevolucion.Date > DateTime.Today)
        {
            throw new ReglaNegocioExcepcion("La fecha de devolución no puede ser posterior a la fecha actual.");
        }
    }

    /// <summary>
    /// Actualiza el estado del activo físico devuelto en base al estado de recepción indicado.
    /// </summary>
    private void ActualizarEstadoActivo(ActivoFisicoServicios activoFisicoServicios, DetalleDevolucionDTO item)
    {
        var activo = activoFisicoServicios.ObtenerPorId(item.ActivoFisicoId);

        activo.EstadoId = item.EstadoDevolucionId switch
        {
            (int)EstadoDetalleDevolucion.Bueno => (int)EstadoActivoFisico.Disponible,
            (int)EstadoDetalleDevolucion.Regular => (int)EstadoActivoFisico.Disponible,
            (int)EstadoDetalleDevolucion.Averiado => (int)EstadoActivoFisico.NoDisponible,
            (int)EstadoDetalleDevolucion.Incompleto => (int)EstadoActivoFisico.NoDisponible,
            (int)EstadoDetalleDevolucion.NoDevuelto => (int)EstadoActivoFisico.NoDisponible,
            _ => (int)EstadoActivoFisico.Disponible
        };

        activoFisicoServicios.Actualizar(activo);
    }

    /// <summary>
    /// Actualiza el estado maestro del préstamo a Devuelto o DevueltoParcial según corresponda.
    /// </summary>
    private void ActualizarEstadoPrestamo(AppDbContext ctx, int prestamoId)
    {
        int totalPrestados = ctx.DetallePrestamo.Count(dp => dp.PrestamoId == prestamoId);
        int totalDevueltos = ctx.DetalleDevolucion.Include(dd => dd.Devolucion).Count(dd => dd.Devolucion != null && dd.Devolucion.PrestamoId == prestamoId);
        var prestamo = ctx.Prestamo.FirstOrDefault(p => p.Id == prestamoId);

        if (prestamo != null)
        {
            if (totalDevueltos >= totalPrestados)
            {
                prestamo.EstadoId = (int)EstadoPrestamo.Devuelto;
            }
            else
            {
                prestamo.EstadoId = (int)EstadoPrestamo.DevueltoParcial;
            }

            ctx.Entry(prestamo).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }

    /// <summary>
    /// Registra formalmente una devolución, actualizando el estado de los activos, el estado del préstamo y la auditoría bajo una transacción explícita.
    /// </summary>
    public void RegistrarDevolucion(Devolucion devolucion, List<DetalleDevolucionDTO> detalle)
    {
        Validar(devolucion, detalle);

        using var ctx = new AppDbContext();
        ValidarPrestamo(ctx, devolucion.PrestamoId);

        devolucion.UsuarioRegistroId = SesionActual.Usuario?.Id ?? 1;

        using var transaccion = ctx.Database.BeginTransaction();
        try
        {
            var repo = new RepositorioGenerico<Devolucion>(ctx);
            var detalleRepo = new RepositorioGenerico<DetalleDevolucion>(ctx);
            var activoFisicoServicios = new ActivoFisicoServicios();

            repo.Agregar(devolucion);
            ctx.SaveChanges();

            foreach (var item in detalle)
            {
                ValidarActivoPerteneceAlPrestamo(ctx, devolucion.PrestamoId, item.ActivoFisicoId);

                var nuevoDetalle = new DetalleDevolucion
                {
                    DevolucionId = devolucion.Id,
                    ActivoFisicoId = item.ActivoFisicoId,
                    EstadoDevolucionId = item.EstadoDevolucionId,
                    Obervacion = item.Obervacion
                };

                detalleRepo.Agregar(nuevoDetalle);
                ActualizarEstadoActivo(activoFisicoServicios, item);
            }

            ActualizarEstadoPrestamo(ctx, devolucion.PrestamoId);
            ctx.SaveChanges();

            string valoresNuevos = $"FechaDevolucion: {devolucion.FechaDevolucion}, PrestamoId: {devolucion.PrestamoId}, Obs: {devolucion.ObervacioneGeneral}";

            var auditoriaServicios = new AuditoriaServicios();
            auditoriaServicios.Registrar("Devolucion", devolucion.Id, TipoAccionAuditoria.Crear, string.Empty, valoresNuevos);

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
            throw new ReglaNegocioExcepcion("Error al registrar la devolución de activos.", ex);
        }
    }

    /// <summary>
    /// Determina si un activo físico ya fue incorporado a la lista en memoria de devolución.
    /// </summary>
    public bool ExisteActivoEnDetalle(List<DetalleDevolucionDTO> detalle, int activoFisicoId)
    {
        return detalle.Any(x => x.ActivoFisicoId == activoFisicoId);
    }

    /// <summary>
    /// Agrega un nuevo ítem a la devolución en memoria.
    /// </summary>
    public void AgregarDetalle(List<DetalleDevolucionDTO> detalle, DetalleDevolucionDTO nuevo)
    {
        if (nuevo == null)
            throw new ArgumentNullException(nameof(nuevo));

        if (ExisteActivoEnDetalle(detalle, nuevo.ActivoFisicoId))
        {
            throw new ReglaNegocioExcepcion("Este activo ya fue agregado a la devolución.");
        }

        detalle.Add(nuevo);
    }

    /// <summary>
    /// Remueve un ítem de la devolución en memoria.
    /// </summary>
    public void EliminarDetalle(List<DetalleDevolucionDTO> detalle, int activoFisicoId)
    {
        var item = detalle.FirstOrDefault(x => x.ActivoFisicoId == activoFisicoId);
        if (item == null)
        {
            throw new ReglaNegocioExcepcion("El activo no existe en el detalle de la devolución.");
        }
        detalle.Remove(item);
    }

    /// <summary>
    /// Obtiene la cantidad de activos pendientes por devolver de un préstamo.
    /// </summary>
    public int ObtenerCantidadPendiente(int prestamoId)
    {
        using var ctx = new AppDbContext();
        int totalPrestados = ctx.DetallePrestamo.Count(dp => dp.PrestamoId == prestamoId);
        int totalDevueltos = ctx.DetalleDevolucion.Include(dd => dd.Devolucion).Count(dd => dd.Devolucion != null && dd.Devolucion.PrestamoId == prestamoId);
        return totalPrestados - totalDevueltos;
    }

    /// <summary>
    /// Valida que el préstamo se encuentre en un estado que admita devoluciones.
    /// </summary>
    private void ValidarPrestamo(AppDbContext ctx, int prestamoId)
    {
        var prestamoServicios = new PrestamoServicios();
        var prestamo = prestamoServicios.ObtenerPorId(prestamoId);
        if (prestamo.EstadoId != (int)EstadoPrestamo.Vigente && prestamo.EstadoId != (int)EstadoPrestamo.DevueltoParcial)
        {
            throw new ReglaNegocioExcepcion("El préstamo seleccionado no admite devoluciones ya que no está vigente ni con devoluciones parciales.");
        }
    }

    /// <summary>
    /// Valida que el activo pertenezca efectivamente a la orden de préstamo seleccionada.
    /// </summary>
    private void ValidarActivoPerteneceAlPrestamo(AppDbContext ctx, int prestamoId, int activoFisicoId)
    {
        bool existe = ctx.DetallePrestamo.Any(dp => dp.PrestamoId == prestamoId && dp.ActivoFisicoId == activoFisicoId);
        if (!existe)
        {
            throw new ReglaNegocioExcepcion($"El activo con ID {activoFisicoId} no pertenece al préstamo seleccionado.");
        }
    }
}
