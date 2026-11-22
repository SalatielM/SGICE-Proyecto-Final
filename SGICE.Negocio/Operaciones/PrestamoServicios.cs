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
/// Gestiona la lógica de negocio, validaciones y préstamos temporales de bienes institucionales.
/// </summary>
public class PrestamoServicios
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="PrestamoServicios"/>.
    /// </summary>
    public PrestamoServicios()
    {
    }

    /// <summary>
    /// Obtiene un préstamo por su identificador primario.
    /// </summary>
    /// <param name="idPrestamo">Identificador del préstamo.</param>
    /// <returns>Entidad <see cref="Prestamo"/>.</returns>
    public Prestamo ObtenerPorId(int idPrestamo)
    {
        Validador.ValidarIdPositivo(idPrestamo, nameof(idPrestamo));

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Prestamo>(ctx);
        var prestamo = repo.ObtenerPorId(idPrestamo);

        if (prestamo == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Prestamo), idPrestamo);
        }

        return prestamo;
    }

    /// <summary>
    /// Obtiene los préstamos activos o pendientes de devolución de un miembro del personal.
    /// </summary>
    /// <param name="personalId">Identificador del solicitante.</param>
    /// <returns>Lista de <see cref="PrestamoDTO"/>.</returns>
    public List<PrestamoDTO> ObtenerPrestamosPendientes(int personalId)
    {
        Validador.ValidarIdPositivo(personalId, nameof(personalId));

        using var ctx = new AppDbContext();
        var prestamos = ctx.Prestamo
            .Include(p => p.PersonalSolicitante)
            .Include(p => p.Estado)
            .Where(p => p.PersonalSolicitanteId == personalId &&
                       (p.EstadoId == (int)EstadoPrestamo.Vigente || p.EstadoId == (int)EstadoPrestamo.DevueltoParcial))
            .Select(p => new PrestamoDTO
            {
                IdPrestamo = p.Id,
                FechaPrestamo = p.FechaPrestamo,
                FechaLimite = p.FechaLimite,
                EstadoId = p.EstadoId.GetValueOrDefault(),
                Estado = p.Estado != null ? p.Estado.Nombre : string.Empty,
                PersonalSolicitanteId = p.PersonalSolicitanteId,
                PersonalSolicitante = p.PersonalSolicitante != null ? $"{p.PersonalSolicitante.Nombre} {p.PersonalSolicitante.Apellido}" : string.Empty,
                CodPersonal = p.PersonalSolicitante != null ? p.PersonalSolicitante.CodPersonal : string.Empty,
                UsuarioRegistroId = p.UsuarioRegistroId
            })
            .ToList();

        if (prestamos.Count == 0)
        {
            throw new ReglaNegocioExcepcion("El personal seleccionado no tiene préstamos pendientes de devolución.");
        }

        return prestamos;
    }

    /// <summary>
    /// Cuenta la cantidad total de préstamos registrados.
    /// </summary>
    public int Contar()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Prestamo>(ctx);
        return repo.Consultar().Count();
    }

    /// <summary>
    /// Cuenta los préstamos en un estado específico.
    /// </summary>
    public int ContarPorEstado(int idEstado)
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Prestamo>(ctx);
        return repo.Consultar().Count(x => x.EstadoId == idEstado);
    }

    /// <summary>
    /// Lista todos los préstamos registrados en el sistema.
    /// </summary>
    public List<PrestamoDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Prestamo
            .Include(p => p.PersonalSolicitante)
            .Include(p => p.Estado)
            .Select(p => new PrestamoDTO
            {
                IdPrestamo = p.Id,
                FechaPrestamo = p.FechaPrestamo,
                FechaLimite = p.FechaLimite,
                EstadoId = p.EstadoId.GetValueOrDefault(),
                Estado = p.Estado != null ? p.Estado.Nombre : string.Empty,
                PersonalSolicitanteId = p.PersonalSolicitanteId,
                PersonalSolicitante = p.PersonalSolicitante != null ? $"{p.PersonalSolicitante.Nombre} {p.PersonalSolicitante.Apellido}" : string.Empty,
                CodPersonal = p.PersonalSolicitante != null ? p.PersonalSolicitante.CodPersonal : string.Empty,
                UsuarioRegistroId = p.UsuarioRegistroId
            }).ToList();
    }

    /// <summary>
    /// Lista el detalle pormenorizado de préstamos con nombre de activo y solicitante.
    /// </summary>
    public List<PrestamoListaDTO> ListarDetalle()
    {
        using var ctx = new AppDbContext();
        return ctx.DetallePrestamo
            .Include(dp => dp.Prestamo)
                .ThenInclude(p => p!.PersonalSolicitante)
            .Include(dp => dp.Prestamo)
                .ThenInclude(p => p!.Estado)
            .Include(dp => dp.ActivoFisico)
                .ThenInclude(af => af!.Activo)
            .Select(dp => new PrestamoListaDTO
            {
                IdPrestamo = dp.PrestamoId,
                Solicitante = dp.Prestamo != null && dp.Prestamo.PersonalSolicitante != null ? $"{dp.Prestamo.PersonalSolicitante.Nombre} {dp.Prestamo.PersonalSolicitante.Apellido}" : string.Empty,
                CodPersonal = dp.Prestamo != null && dp.Prestamo.PersonalSolicitante != null ? dp.Prestamo.PersonalSolicitante.CodPersonal : string.Empty,
                Activo = dp.ActivoFisico != null && dp.ActivoFisico.Activo != null ? dp.ActivoFisico.Activo.Nombre : string.Empty,
                FechaPrestamo = dp.Prestamo != null ? dp.Prestamo.FechaPrestamo : DateTime.MinValue,
                FechaFinalizacion = dp.Prestamo != null ? dp.Prestamo.FechaLimite : DateTime.MinValue,
                Estado = dp.Prestamo != null && dp.Prestamo.Estado != null ? dp.Prestamo.Estado.Nombre : string.Empty
            }).ToList();
    }

    /// <summary>
    /// Construye un objeto detalle a partir de un activo físico disponible.
    /// </summary>
    public DetallePrestamoDTO CrearDetalleDesdeActivo(int idActivoFisico)
    {
        var activoServicios = new ActivoFisicoServicios();
        var activo = activoServicios.ObtenerPorId(idActivoFisico);

        if (activo.EstadoId != (int)EstadoActivoFisico.Disponible)
        {
            throw new ReglaNegocioExcepcion("El activo no se encuentra disponible para préstamo.");
        }

        return new DetallePrestamoDTO
        {
            ActivoFisicoId = activo.Id,
            ActivoId = activo.ActivoId,
            Activo = activo.Activo?.Nombre ?? string.Empty,
            CodEtiquetaQR = activo.CodEtiquetaQR,
            NumSerie = activo.NumSerie ?? string.Empty,
            SubCategoriaId = activo.Activo?.SubCategoriaId ?? 0,
            SubCategoria = activo.Activo?.SubCategoria?.Nombre ?? string.Empty,
            MarcaId = activo.Activo?.MarcaId ?? 0,
            Marca = activo.Activo?.Marca?.Nombre ?? string.Empty,
            EstadoId = activo.EstadoId.GetValueOrDefault(),
            Estado = activo.Estado?.Nombre ?? string.Empty
        };
    }

    /// <summary>
    /// Registra un nuevo préstamo y sus renglones correspondientes actualizando el estado de los activos a 'Prestado' de forma transaccional.
    /// </summary>
    public void RegistrarPrestamo(Prestamo prestamo, List<DetallePrestamo> detalle)
    {
        if (prestamo == null)
            throw new ArgumentNullException(nameof(prestamo));

        if (detalle == null || detalle.Count == 0)
            throw new ReglaNegocioExcepcion("Debe agregar al menos un activo al préstamo.");

        Validar(prestamo);

        var estadoServicios = new EstadoServicios();
        estadoServicios.ValidarEstado(prestamo.EstadoId.GetValueOrDefault(), TipoEstadoEnum.Prestamo);
        prestamo.UsuarioRegistroId = SesionActual.Usuario?.Id ?? 1;

        using var ctx = new AppDbContext();
        using var transaccion = ctx.Database.BeginTransaction();
        try
        {
            var repo = new RepositorioGenerico<Prestamo>(ctx);
            var detalleRepo = new RepositorioGenerico<DetallePrestamo>(ctx);
            var repoActivoFisico = new RepositorioGenerico<ActivoFisico>(ctx);

            repo.Agregar(prestamo);
            ctx.SaveChanges();

            foreach (var item in detalle)
            {
                item.PrestamoId = prestamo.Id;
                detalleRepo.Agregar(item);

                var activo = repoActivoFisico.ObtenerPorId(item.ActivoFisicoId);
                if (activo == null)
                {
                    throw new EntidadNoEncontradaNegocioExcepcion(nameof(ActivoFisico), item.ActivoFisicoId);
                }

                if (activo.EstadoId != (int)EstadoActivoFisico.Disponible)
                {
                    throw new ReglaNegocioExcepcion($"El activo '{activo.CodEtiquetaQR}' ya no se encuentra disponible.");
                }

                activo.EstadoId = (int)EstadoActivoFisico.Prestado;
                repoActivoFisico.Actualizar(activo);
            }

            ctx.SaveChanges();

            string valoresNuevos = $"FechaPrestamo: {prestamo.FechaPrestamo}, FechaLimite: {prestamo.FechaLimite}, Solicitante: {prestamo.PersonalSolicitanteId}";

            var auditoriaServicios = new AuditoriaServicios();
            auditoriaServicios.Registrar("Prestamo", prestamo.Id, TipoAccionAuditoria.Crear, string.Empty, valoresNuevos);

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
            throw new ReglaNegocioExcepcion("Error al registrar la transacción del préstamo.", ex);
        }
    }

    /// <summary>
    /// Valida los datos esenciales del préstamo.
    /// </summary>
    private void Validar(Prestamo prestamo)
    {
        Validador.ValidarIdPositivo(prestamo.PersonalSolicitanteId, nameof(prestamo.PersonalSolicitanteId));
        ValidarFechas(prestamo.FechaPrestamo, prestamo.FechaLimite);
    }

    /// <summary>
    /// Valida el rango cronológico entre la fecha del préstamo y la fecha límite acordada.
    /// </summary>
    private void ValidarFechas(DateTime fechaPrestamo, DateTime fechaLimite)
    {
        if (fechaLimite.Date < fechaPrestamo.Date)
        {
            throw new ReglaNegocioExcepcion("La fecha límite de devolución debe ser mayor o igual a la fecha de inicio del préstamo.");
        }
    }

    /// <summary>
    /// Verifica si un activo físico ya fue agregado a la lista de detalles de préstamo.
    /// </summary>
    public bool ExisteActivoEnDetalle(List<DetallePrestamoDTO> lista, int idActivoFisico)
    {
        return lista.Any(x => x.ActivoFisicoId == idActivoFisico);
    }

    /// <summary>
    /// Remueve un activo del detalle de préstamo.
    /// </summary>
    public void EliminarDetalle(List<DetallePrestamoDTO> detalle, int activoFisicoId)
    {
        var item = detalle.FirstOrDefault(a => a.ActivoFisicoId == activoFisicoId);
        if (item == null)
        {
            throw new ReglaNegocioExcepcion("El activo no existe en el detalle del préstamo.");
        }
        detalle.Remove(item);
    }

    /// <summary>
    /// Incorpora un nuevo activo al detalle de préstamo.
    /// </summary>
    public void AgregarDetalle(List<DetallePrestamoDTO> detalle, DetallePrestamoDTO nuevo)
    {
        if (nuevo == null)
            throw new ArgumentNullException(nameof(nuevo));

        if (ExisteActivoEnDetalle(detalle, nuevo.ActivoFisicoId))
        {
            throw new ReglaNegocioExcepcion("Este activo ya fue agregado al préstamo.");
        }

        detalle.Add(nuevo);
    }

    /// <summary>
    /// Actualiza la información de un préstamo existente.
    /// </summary>
    public void Actualizar(Prestamo prestamo)
    {
        if (prestamo == null)
            throw new ArgumentNullException(nameof(prestamo));

        Validador.ValidarIdPositivo(prestamo.Id, nameof(prestamo.Id));

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Prestamo>(ctx);
        repo.Actualizar(prestamo);
        ctx.SaveChanges();
    }
}
