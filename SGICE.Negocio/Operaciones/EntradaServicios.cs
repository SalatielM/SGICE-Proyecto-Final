using Microsoft.EntityFrameworkCore;
using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Catalogos;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;
using SGICE.Negocio.Utilidades;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Operaciones;

/// <summary>
/// Gestiona la lógica de negocio, validaciones y registro transaccional de ingresos o entradas de activos al centro educativo.
/// </summary>
public class EntradaServicios
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="EntradaServicios"/>.
    /// </summary>
    public EntradaServicios()
    {
    }

    /// <summary>
    /// Valida un elemento individual del detalle de entrada.
    /// </summary>
    private void ValidarDetalle(DetalleEntradaDTO activo)
    {
        if (activo == null)
            throw new ArgumentNullException(nameof(activo));

        Validador.ValidarIdPositivo(activo.ActivoId, nameof(activo.ActivoId));
        Validador.ValidarRangoPositivo(activo.Cantidad, 1, int.MaxValue, nameof(activo.Cantidad));
    }

    /// <summary>
    /// Determina si un catálogo de activo ya se encuentra registrado en el detalle temporal de entrada.
    /// </summary>
    private bool ExisteActivo(List<DetalleEntradaDTO> detalle, int activoId)
    {
        return detalle.Any(d => d.ActivoId == activoId);
    }

    /// <summary>
    /// Obtiene un ítem del detalle según su identificador de activo.
    /// </summary>
    private DetalleEntradaDTO ObtenerDetalle(List<DetalleEntradaDTO> detalle, int activoId)
    {
        var iActivo = detalle.FirstOrDefault(d => d.ActivoId == activoId);
        if (iActivo == null)
        {
            throw new ReglaNegocioExcepcion("El activo no existe en el detalle de la entrada.");
        }
        return iActivo;
    }

    /// <summary>
    /// Edita la cantidad de un activo en la lista de detalles de entrada.
    /// </summary>
    /// <param name="detalle">Lista de detalles de entrada.</param>
    /// <param name="activoId">Identificador del activo.</param>
    /// <param name="nuevaCantidad">Nueva cantidad a asignar.</param>
    public void EditarDetalle(List<DetalleEntradaDTO> detalle, int activoId, int nuevaCantidad)
    {
        if (detalle == null)
            throw new ValidacionNegocioExcepcion("No existe un detalle para procesar.");

        Validador.ValidarRangoPositivo(nuevaCantidad, 1, int.MaxValue, nameof(nuevaCantidad));

        var iActivo = ObtenerDetalle(detalle, activoId);
        iActivo.Cantidad = nuevaCantidad;
    }

    /// <summary>
    /// Agrega un nuevo ítem a la lista de detalles de entrada validando previamente su existencia y disponibilidad.
    /// </summary>
    /// <param name="detalle">Lista de detalles existente.</param>
    /// <param name="iActivo">Detalle del activo a incorporar.</param>
    public void AgregarDetalle(List<DetalleEntradaDTO> detalle, DetalleEntradaDTO iActivo)
    {
        if (detalle == null)
            throw new ValidacionNegocioExcepcion("No existe una lista de detalles inicializada.");

        ValidarDetalle(iActivo);

        var activoServicios = new ActivoServicios();
        activoServicios.ObtenerPorId(iActivo.ActivoId);
        activoServicios.ValidarEstadoActivo(iActivo.ActivoId);

        if (ExisteActivo(detalle, iActivo.ActivoId))
        {
            throw new ReglaNegocioExcepcion("Este activo ya fue agregado al detalle de la entrada.");
        }

        detalle.Add(iActivo);
    }

    /// <summary>
    /// Remueve un activo del detalle de entrada.
    /// </summary>
    /// <param name="detalle">Lista de detalles.</param>
    /// <param name="activoId">Identificador del activo a eliminar.</param>
    public void EliminarDetalle(List<DetalleEntradaDTO> detalle, int activoId)
    {
        if (detalle == null)
            throw new ValidacionNegocioExcepcion("No existe un detalle para procesar.");

        var iActivo = ObtenerDetalle(detalle, activoId);
        detalle.Remove(iActivo);
    }

    /// <summary>
    /// Valida las reglas de negocio de la cabecera y el conjunto de ítems de la entrada.
    /// </summary>
    private void ValidarEntrada(Entrada entrada, List<DetalleEntradaDTO> detalle, List<ActivoFisicoDTO> activoFisico)
    {
        if (entrada == null)
            throw new ValidacionNegocioExcepcion("La información de entrada es inválida.");

        if (detalle == null || detalle.Count == 0)
            throw new ReglaNegocioExcepcion("Debe agregar al menos un activo a la entrada.");

        if (activoFisico == null || activoFisico.Count == 0)
            throw new ReglaNegocioExcepcion("No existen activos físicos generados para registrar.");

        Validador.ValidarLongitudMaxima(entrada.ObservacionEntrada, 300, nameof(entrada.ObservacionEntrada));
    }

    /// <summary>
    /// Genera el siguiente número consecutivo correlativo de entrada.
    /// </summary>
    /// <param name="ctx">Contexto de base de datos actual.</param>
    /// <returns>Número consecutivo siguiente.</returns>
    public int GenerarNumeroEntrada(AppDbContext ctx)
    {
        var repoEntrada = new RepositorioGenerico<Entrada>(ctx);
        var ultimoNumero = repoEntrada.Consultar()
            .OrderByDescending(e => e.NumEntrada)
            .Select(e => e.NumEntrada)
            .FirstOrDefault();

        return ultimoNumero + 1;
    }

    /// <summary>
    /// Genera el siguiente número consecutivo correlativo de entrada abriendo una nueva sesión de contexto.
    /// </summary>
    /// <returns>Número consecutivo siguiente.</returns>
    public int GenerarNumeroEntrada()
    {
        using var ctx = new AppDbContext();
        return GenerarNumeroEntrada(ctx);
    }

    /// <summary>
    /// Registra formalmente una entrada en base de datos de manera atómica transaccional,
    /// persistiendo cabecera, renglones de detalle, generación de activos físicos y auditoría.
    /// </summary>
    /// <param name="entrada">Cabecera de entrada.</param>
    /// <param name="detalle">Lista de detalles cuantitativos.</param>
    /// <param name="activoFisico">Lista de activos físicos con números de serie y etiquetas QR.</param>
    public void RegistrarEntrada(Entrada entrada, List<DetalleEntradaDTO> detalle, List<ActivoFisicoDTO> activoFisico)
    {
        if (activoFisico == null || activoFisico.Count == 0)
        {
            throw new ReglaNegocioExcepcion("Debe generar los activos físicos antes de registrar la entrada.");
        }

        using var ctx = new AppDbContext();
        using var transaccion = ctx.Database.BeginTransaction();
        try
        {
            ValidarEntrada(entrada, detalle, activoFisico);

            entrada.NumEntrada = GenerarNumeroEntrada(ctx);
            entrada.FechaEntrada = DateTime.Now;
            entrada.UsuarioRegistroId = SesionActual.Usuario?.Id ?? 1;

            var repoEntrada = new RepositorioGenerico<Entrada>(ctx);
            var repoDetalle = new RepositorioGenerico<DetalleEntrada>(ctx);
            var repoActivoFisico = new RepositorioGenerico<ActivoFisico>(ctx);

            repoEntrada.Agregar(entrada);
            ctx.SaveChanges();

            foreach (var iActivo in detalle)
            {
                var detalleRegistrado = RegistrarDetalleEntrada(repoDetalle, entrada, iActivo);
                ctx.SaveChanges();

                var activosDelDetalle = activoFisico.Where(a => a.ActivoId == iActivo.ActivoId).ToList();
                RegistrarActivosFisicos(repoActivoFisico, detalleRegistrado, activosDelDetalle);
            }

            ctx.SaveChanges();

            string valoresNuevos = $"Fecha Entrada: {entrada.FechaEntrada}, No Entrada {entrada.NumEntrada}, Doc Referencia: {entrada.DocReferencia}, No Doc: {entrada.NoDocReferencia}, Obs: {entrada.ObservacionEntrada}";

            var auditoriaServicios = new AuditoriaServicios();
            auditoriaServicios.Registrar("Entrada", entrada.Id, TipoAccionAuditoria.Crear, string.Empty, valoresNuevos);

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
            throw new ReglaNegocioExcepcion("Error al registrar la transacción de entrada de activos.", ex);
        }
    }

    /// <summary>
    /// Registra en el repositorio los activos físicos correspondientes a un detalle de entrada.
    /// </summary>
    private void RegistrarActivosFisicos(RepositorioGenerico<ActivoFisico> repoActivoFisico, DetalleEntrada detalle, List<ActivoFisicoDTO> activoFisico)
    {
        if (activoFisico == null)
            throw new ReglaNegocioExcepcion("No existen activos físicos para registrar.");

        int usuarioId = SesionActual.Usuario?.Id ?? 1;

        foreach (var dto in activoFisico)
        {
            string numSerie = string.IsNullOrWhiteSpace(dto.NumSerie) ? "N/A" : dto.NumSerie.Trim();

            var activo = new ActivoFisico
            {
                CodEtiquetaQR = dto.CodEtiquetaQR,
                NumSerie = numSerie,
                ActivoId = dto.ActivoId,
                UbicacionId = dto.UbicacionId,
                EstadoId = (int)EstadoActivoFisico.Disponible,
                DetalleEntradaId = detalle.Id,
                FechaRegistro = DateTime.Now,
                UsuarioRegistroId = usuarioId
            };

            repoActivoFisico.Agregar(activo);
        }
    }

    /// <summary>
    /// Persiste el detalle cuantitativo de la entrada.
    /// </summary>
    private DetalleEntrada RegistrarDetalleEntrada(RepositorioGenerico<DetalleEntrada> repoDetalle, Entrada entrada, DetalleEntradaDTO iActivo)
    {
        var detalle = new DetalleEntrada
        {
            EntradaId = entrada.Id,
            ActivoId = iActivo.ActivoId,
            Cantidad = iActivo.Cantidad
        };
        repoDetalle.Agregar(detalle);
        return detalle;
    }

    /// <summary>
    /// Genera la lista de activos físicos temporales en memoria para ser revisados o etiquetados antes del guardado definitivo.
    /// </summary>
    /// <param name="detalle">Detalle del activo con la cantidad solicitada.</param>
    /// <param name="activoEnMemoria">Lista acumulada actual de activos físicos en memoria.</param>
    /// <returns>Lista de activos físicos generados con código correlativo AF-XXXXXXX.</returns>
    public List<ActivoFisicoDTO> GenerarActivosFisicosTemporales(DetalleEntradaDTO detalle, List<ActivoFisicoDTO>? activoEnMemoria)
    {
        if (detalle == null)
            throw new ValidacionNegocioExcepcion("El detalle de entrada es inválido.");

        Validador.ValidarRangoPositivo(detalle.Cantidad, 1, int.MaxValue, nameof(detalle.Cantidad));

        var estadoServicios = new EstadoServicios();
        var ubicacionServicios = new UbicacionServicios();

        var lista = new List<ActivoFisicoDTO>();
        var estadoDisponible = estadoServicios.ObtenerPorNombre("Disponible", TipoEstadoEnum.ActivoFisico);
        estadoServicios.ValidarEstado(estadoDisponible.IdEstado, TipoEstadoEnum.ActivoFisico);

        Ubicacion? almacenPrincipal = null;
        try
        {
            almacenPrincipal = ubicacionServicios.ObtenerPorNombreUbicacion("Almacen Principal");
        }
        catch
        {
            almacenPrincipal = ubicacionServicios.ObtenerTodo().FirstOrDefault();
        }

        if (almacenPrincipal == null)
        {
            throw new ReglaNegocioExcepcion("No se encontró una ubicación de destino válida en el centro educativo.");
        }

        ubicacionServicios.ValidarEstadoUbicacion(almacenPrincipal.Id);

        int consecutivoDB = ObtenerUltimoIdActivoFisico();
        int maxMemoria = 0;

        if (activoEnMemoria != null && activoEnMemoria.Any())
        {
            maxMemoria = activoEnMemoria.Max(a =>
            {
                int num = 0;
                int.TryParse(a.CodEtiquetaQR.Replace("AF-", string.Empty), out num);
                return num;
            });
        }

        int consecutivo = Math.Max(consecutivoDB, maxMemoria);

        for (int i = 1; i <= detalle.Cantidad; i++)
        {
            consecutivo++;

            lista.Add(new ActivoFisicoDTO
            {
                ActivoId = detalle.ActivoId,
                Activo = detalle.NombreActivo,
                CodEtiquetaQR = $"AF-{consecutivo:D7}",
                NumSerie = string.Empty,
                UbicacionId = almacenPrincipal.Id,
                Ubicacion = almacenPrincipal.Nombre,
                EstadoId = (int)EstadoActivoFisico.Disponible,
                Estado = "Disponible"
            });
        }

        return lista;
    }

    /// <summary>
    /// Consulta el último ID numérico de activo físico registrado en la base de datos.
    /// </summary>
    private int ObtenerUltimoIdActivoFisico()
    {
        using var ctx = new AppDbContext();
        var repoActivoFisico = new RepositorioGenerico<ActivoFisico>(ctx);
        var query = repoActivoFisico.Consultar();
        if (!query.Any())
        {
            return 0;
        }
        return query.Max(af => af.Id);
    }
}
