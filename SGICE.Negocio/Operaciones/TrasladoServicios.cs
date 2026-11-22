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
/// Gestiona la lógica de traslados físicos de bienes institucionales entre diferentes ubicaciones del centro educativo.
/// </summary>
public class TrasladoServicios
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="TrasladoServicios"/>.
    /// </summary>
    public TrasladoServicios()
    {
    }

    /// <summary>
    /// Valida un detalle individual de traslado verificando identificadores positivos y que origen y destino difieran.
    /// </summary>
    /// <param name="detalle">Detalle del traslado a validar.</param>
    public void ValidarDetalle(DetalleTrasladoDTO detalle)
    {
        if (detalle == null)
            throw new ArgumentNullException(nameof(detalle));

        Validador.ValidarIdPositivo(detalle.ActivoFisicoId, nameof(detalle.ActivoFisicoId));
        Validador.ValidarIdPositivo(detalle.UbicacionActualId, nameof(detalle.UbicacionActualId));

        if (detalle.UbicacionActualId == detalle.UbicacionFinalId)
        {
            throw new ReglaNegocioExcepcion("La ubicación de origen y destino no pueden ser iguales.");
        }
    }

    /// <summary>
    /// Verifica si un activo físico ya fue agregado a la lista de traslados en memoria.
    /// </summary>
    private bool ExisteActivo(List<DetalleTrasladoDTO> detalle, int activoFisicoId)
    {
        return detalle.Any(d => d.ActivoFisicoId == activoFisicoId);
    }

    /// <summary>
    /// Obtiene un detalle de la lista en memoria según el activo físico.
    /// </summary>
    private DetalleTrasladoDTO ObtenerDetalle(List<DetalleTrasladoDTO> detalle, int activoFisicoId)
    {
        var activo = detalle.FirstOrDefault(d => d.ActivoFisicoId == activoFisicoId);
        if (activo == null)
        {
            throw new ReglaNegocioExcepcion("El activo no existe dentro del traslado.");
        }
        return activo;
    }

    /// <summary>
    /// Agrega un activo físico a la lista de detalles de traslado previa validación de estado.
    /// </summary>
    /// <param name="detalle">Lista de detalles de traslado.</param>
    /// <param name="activo">Detalle a incorporar.</param>
    public void AgregarDetalle(List<DetalleTrasladoDTO> detalle, DetalleTrasladoDTO activo)
    {
        if (detalle == null)
            throw new ValidacionNegocioExcepcion("No existe un detalle para procesar.");

        ValidarDetalle(activo);

        using var ctx = new AppDbContext();
        var repoActivoFisico = new RepositorioGenerico<ActivoFisico>(ctx);
        var activoDB = repoActivoFisico.ObtenerPorId(activo.ActivoFisicoId);

        if (activoDB == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(ActivoFisico), activo.ActivoFisicoId);
        }

        var estadoServicios = new EstadoServicios();
        estadoServicios.ValidarEstado(activoDB.EstadoId.GetValueOrDefault(), TipoEstadoEnum.ActivoFisico);

        if (activoDB.EstadoId != (int)EstadoActivoFisico.Disponible)
        {
            throw new ReglaNegocioExcepcion("El activo no se encuentra disponible para ser trasladado.");
        }

        if (ExisteActivo(detalle, activo.ActivoFisicoId))
        {
            throw new ReglaNegocioExcepcion("Este activo ya fue agregado al traslado.");
        }

        detalle.Add(activo);
    }

    /// <summary>
    /// Edita la ubicación de destino para un ítem de la lista de traslados.
    /// </summary>
    /// <param name="detalle">Lista de detalles.</param>
    /// <param name="activoFisicoId">Identificador del activo.</param>
    /// <param name="nuevaUbicacion">Nueva ubicación asignada.</param>
    public void EditarDestino(List<DetalleTrasladoDTO> detalle, int activoFisicoId, int nuevaUbicacion)
    {
        if (detalle == null)
            throw new ValidacionNegocioExcepcion("No existe un detalle para procesar.");

        var activo = ObtenerDetalle(detalle, activoFisicoId);
        var ubicacionServicios = new UbicacionServicios();
        ubicacionServicios.ValidarEstadoUbicacion(nuevaUbicacion);

        if (activo.UbicacionActualId == nuevaUbicacion)
        {
            throw new ReglaNegocioExcepcion("La ubicación destino debe ser distinta a la ubicación actual.");
        }

        activo.UbicacionFinalId = nuevaUbicacion;
    }

    /// <summary>
    /// Valida los datos obligatorios del documento maestro de traslado.
    /// </summary>
    private void ValidarTraslado(Traslado traslado, List<DetalleTrasladoDTO> detalle)
    {
        if (traslado == null)
            throw new ValidacionNegocioExcepcion("La información del traslado es inválida.");

        if (detalle == null || detalle.Count == 0)
            throw new ReglaNegocioExcepcion("Debe agregar al menos un activo al traslado.");

        Validador.ValidarRequerido(traslado.RazonTraslado, nameof(traslado.RazonTraslado));
        traslado.RazonTraslado = traslado.RazonTraslado.Trim();
        Validador.ValidarLongitudMaxima(traslado.RazonTraslado, 300, nameof(traslado.RazonTraslado));

        Validador.ValidarIdPositivo(traslado.AutorizadoPorId, nameof(traslado.AutorizadoPorId));

        if (!Enum.IsDefined(typeof(TipoDocAutorizacion), traslado.DocAutorizacion))
        {
            throw new ValidacionNegocioExcepcion("Debe seleccionar un tipo de documento de autorización válido.");
        }

        Validador.ValidarRequerido(traslado.NoDocAutorizacion, nameof(traslado.NoDocAutorizacion));
        traslado.NoDocAutorizacion = traslado.NoDocAutorizacion.Trim();
    }

    /// <summary>
    /// Registra formalmente el traslado atómico de activos físicos entre ubicaciones mediante transacción explícita.
    /// </summary>
    /// <param name="traslado">Entidad maestra <see cref="Traslado"/>.</param>
    /// <param name="detalle">Lista de detalles con activos y sus ubicaciones finales.</param>
    public void RegistrarTraslado(Traslado traslado, List<DetalleTrasladoDTO> detalle)
    {
        if (detalle == null || detalle.Count == 0)
        {
            throw new ReglaNegocioExcepcion("Debe seleccionar al menos un activo para trasladar.");
        }

        using var ctx = new AppDbContext();
        using var transaccion = ctx.Database.BeginTransaction();
        try
        {
            ValidarTraslado(traslado, detalle);
            traslado.FechaTraslado = DateTime.Now;
            traslado.UsuarioRegistroId = SesionActual.Usuario?.Id ?? 1;

            var repoTraslado = new RepositorioGenerico<Traslado>(ctx);
            var repoDetalle = new RepositorioGenerico<DetalleTraslado>(ctx);
            var repoActivoFisico = new RepositorioGenerico<ActivoFisico>(ctx);
            var ubicacionServicios = new UbicacionServicios();

            repoTraslado.Agregar(traslado);
            ctx.SaveChanges();

            foreach (var item in detalle)
            {
                ubicacionServicios.ValidarEstadoUbicacion(item.UbicacionFinalId);

                if (item.UbicacionActualId == item.UbicacionFinalId)
                {
                    throw new ReglaNegocioExcepcion($"El activo '{item.CodigoEtiqueta}' ya se encuentra en esa ubicación.");
                }

                var activo = repoActivoFisico.ObtenerPorId(item.ActivoFisicoId);
                if (activo == null)
                {
                    throw new EntidadNoEncontradaNegocioExcepcion(nameof(ActivoFisico), item.ActivoFisicoId);
                }

                if (activo.EstadoId != (int)EstadoActivoFisico.Disponible)
                {
                    throw new ReglaNegocioExcepcion($"El activo '{activo.CodEtiquetaQR}' ya no está disponible para traslado.");
                }

                var detObj = new DetalleTraslado
                {
                    TrasladoId = traslado.Id,
                    ActivoFisicoId = item.ActivoFisicoId,
                    UbicacionActualId = item.UbicacionActualId,
                    UbicacionFinalId = item.UbicacionFinalId
                };
                repoDetalle.Agregar(detObj);

                activo.UbicacionId = item.UbicacionFinalId;
                repoActivoFisico.Actualizar(activo);
            }

            ctx.SaveChanges();

            string valoresNuevos = $"FechaTraslado: {traslado.FechaTraslado}, AutorizadoPor: {traslado.AutorizadoPorId}, DocAutorizacion: {traslado.DocAutorizacion}, NoDoc: {traslado.NoDocAutorizacion}";

            var auditoriaServicios = new AuditoriaServicios();
            auditoriaServicios.Registrar("Traslado", traslado.Id, TipoAccionAuditoria.Crear, string.Empty, valoresNuevos);

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
            throw new ReglaNegocioExcepcion("Error al registrar el traslado de activos.", ex);
        }
    }

    /// <summary>
    /// Crea un objeto de detalle de traslado a partir de una etiqueta QR de activo físico.
    /// </summary>
    /// <param name="codigo">Código de etiqueta QR.</param>
    /// <returns>Detalle listo para agregarse al traslado.</returns>
    public DetalleTrasladoDTO CrearDetalleDesdeActivo(string codigo)
    {
        var activoServicios = new ActivoFisicoServicios();
        var activo = activoServicios.ObtenerDtoPorEtiqueta(codigo);

        if (activo.EstadoId != (int)EstadoActivoFisico.Disponible)
        {
            throw new ReglaNegocioExcepcion("El activo no se encuentra disponible para traslado.");
        }

        return new DetalleTrasladoDTO
        {
            ActivoFisicoId = activo.IdActivoFisico,
            CodigoEtiqueta = activo.CodEtiquetaQR,
            NombreActivo = activo.Activo,
            CategoriaId = activo.SubCategoriaId,
            Categoria = activo.SubCategoria,
            MarcaId = activo.MarcaId,
            Marca = activo.Marca,
            NumSerie = activo.NumSerie,
            UbicacionActualId = activo.UbicacionId,
            UbicacionActual = activo.Ubicacion
        };
    }

    /// <summary>
    /// Obtiene las posibles ubicaciones activas disponibles como destino del traslado.
    /// </summary>
    /// <returns>Lista de <see cref="Ubicacion"/>.</returns>
    public List<Ubicacion> ObtenerUbicacionesDestino()
    {
        var ubicacionServicios = new UbicacionServicios();
        return ubicacionServicios.ObtenerTodo()
            .Where(u => u.EstadoId == (int)EstadoGenerico.Activo)
            .OrderBy(u => u.Nombre)
            .ToList();
    }

    /// <summary>
    /// Remueve un activo físico de la lista de detalles de traslado en memoria.
    /// </summary>
    /// <param name="detalle">Lista de detalles.</param>
    /// <param name="activoFisicoId">Identificador del activo a retirar.</param>
    public void EliminarDetalle(List<DetalleTrasladoDTO> detalle, int activoFisicoId)
    {
        if (detalle == null)
            throw new ValidacionNegocioExcepcion("No existen activos para eliminar.");

        var activo = detalle.FirstOrDefault(a => a.ActivoFisicoId == activoFisicoId);
        if (activo == null)
        {
            throw new ReglaNegocioExcepcion("El activo no existe en el detalle.");
        }
        detalle.Remove(activo);
    }
}
