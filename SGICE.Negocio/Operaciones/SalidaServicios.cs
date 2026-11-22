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
/// Provee los servicios y validaciones de negocio para procesar salidas o descargos de activos institucionales.
/// </summary>
public class SalidaServicios
{
    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="SalidaServicios"/>.
    /// </summary>
    public SalidaServicios()
    {
    }

    /// <summary>
    /// Valida individualmente un renglón del detalle de salida.
    /// </summary>
    private void ValidarDetalle(DetalleSalidaDTO detalle)
    {
        if (detalle == null)
            throw new ArgumentNullException(nameof(detalle));

        Validador.ValidarIdPositivo(detalle.ActivoFisicoId, nameof(detalle.ActivoFisicoId));

        if ((int)detalle.MotivoSalida <= 0)
        {
            throw new ValidacionNegocioExcepcion("Debe especificar un motivo de salida válido para cada activo.");
        }
    }

    /// <summary>
    /// Verifica si un activo físico ya fue agregado a la lista en memoria de detalles de salida.
    /// </summary>
    private bool ExisteActivo(List<DetalleSalidaDTO> listaDetalles, int activoFisicoId)
    {
        return listaDetalles.Any(d => d.ActivoFisicoId == activoFisicoId);
    }

    /// <summary>
    /// Agrega un nuevo activo físico a la lista de detalles verificando su disponibilidad en base de datos.
    /// </summary>
    /// <param name="listaDetalles">Lista de detalles actual.</param>
    /// <param name="nuevoDetalle">Detalle a incorporar.</param>
    public void AgregarDetalle(List<DetalleSalidaDTO> listaDetalles, DetalleSalidaDTO nuevoDetalle)
    {
        if (listaDetalles == null)
            throw new ValidacionNegocioExcepcion("No existe una lista de detalles para procesar.");

        ValidarDetalle(nuevoDetalle);

        using var ctx = new AppDbContext();
        var repoActivoFisico = new RepositorioGenerico<ActivoFisico>(ctx);
        var activoFisico = repoActivoFisico.Consultar().FirstOrDefault(a => a.Id == nuevoDetalle.ActivoFisicoId);

        if (activoFisico == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(ActivoFisico), nuevoDetalle.ActivoFisicoId);
        }

        if (activoFisico.EstadoId != (int)EstadoActivoFisico.Disponible)
        {
            throw new ReglaNegocioExcepcion("No se puede dar salida al activo porque no se encuentra en estado 'Disponible'.");
        }

        if (ExisteActivo(listaDetalles, nuevoDetalle.ActivoFisicoId))
        {
            throw new ReglaNegocioExcepcion("Este activo ya fue agregado al detalle de la salida.");
        }

        listaDetalles.Add(nuevoDetalle);
    }

    /// <summary>
    /// Remueve un activo físico de la lista de detalles de salida.
    /// </summary>
    /// <param name="listaDetalles">Lista de detalles actual.</param>
    /// <param name="activoFisicoId">Identificador del activo físico.</param>
    public void EliminarDetalle(List<DetalleSalidaDTO> listaDetalles, int activoFisicoId)
    {
        if (listaDetalles == null)
            throw new ValidacionNegocioExcepcion("No existe una lista de detalles para procesar.");

        var activoEliminar = listaDetalles.FirstOrDefault(d => d.ActivoFisicoId == activoFisicoId);
        if (activoEliminar == null)
        {
            throw new ReglaNegocioExcepcion("El activo no existe en el detalle de la salida.");
        }

        listaDetalles.Remove(activoEliminar);
    }

    /// <summary>
    /// Valida las reglas de la salida y su colección de detalles.
    /// </summary>
    private void ValidarSalida(Salida salida, List<DetalleSalidaDTO> listaDetalles)
    {
        if (salida == null)
            throw new ValidacionNegocioExcepcion("La información de la salida es inválida.");

        if (listaDetalles == null || listaDetalles.Count == 0)
            throw new ReglaNegocioExcepcion("Debe agregar al menos un activo físico a la salida.");

        Validador.ValidarLongitudMaxima(salida.Observaciones, 300, nameof(salida.Observaciones));
    }

    /// <summary>
    /// Genera el siguiente número correlativo de salida.
    /// </summary>
    /// <param name="ctx">Contexto de base de datos actual.</param>
    /// <returns>Próximo número de salida.</returns>
    public int GeneranNumeroSalida(AppDbContext ctx)
    {
        var repoSalida = new RepositorioGenerico<Salida>(ctx);
        var ultimoNumero = repoSalida.Consultar()
            .OrderByDescending(s => s.NumSalida)
            .Select(s => s.NumSalida)
            .FirstOrDefault();

        return ultimoNumero + 1;
    }

    /// <summary>
    /// Registra formalmente una salida de activos bajo una transacción explícita de base de datos,
    /// cambiando el estado de los activos a Dado de Baja y registrando la auditoría.
    /// </summary>
    /// <param name="salida">Cabecera de salida.</param>
    /// <param name="listaDetalles">Lista de ítems con motivos de salida.</param>
    public void RegistrarSalida(Salida salida, List<DetalleSalidaDTO> listaDetalles)
    {
        if (listaDetalles == null || listaDetalles.Count == 0)
        {
            throw new ReglaNegocioExcepcion("Debe agregar al menos un activo físico a la salida.");
        }

        using var ctx = new AppDbContext();
        using var transaccion = ctx.Database.BeginTransaction();
        try
        {
            ValidarSalida(salida, listaDetalles);

            salida.NumSalida = GeneranNumeroSalida(ctx);
            salida.FechaSalida = DateTime.Now;
            salida.UsuarioRegistroId = SesionActual.Usuario?.Id ?? 1;

            var repoSalida = new RepositorioGenerico<Salida>(ctx);
            var repoDetalleSalida = new RepositorioGenerico<DetalleSalida>(ctx);
            var repoActivoFisico = new RepositorioGenerico<ActivoFisico>(ctx);

            repoSalida.Agregar(salida);
            ctx.SaveChanges();

            foreach (var activo in listaDetalles)
            {
                var detalle = new DetalleSalida
                {
                    SalidaId = salida.Id,
                    ActivoFisicoId = activo.ActivoFisicoId,
                    MotivoSalida = activo.MotivoSalida
                };
                repoDetalleSalida.Agregar(detalle);

                var estadoDestino = ObtenerEstadoDesdeMotivo(activo.MotivoSalida);
                var activoFisico = repoActivoFisico.Consultar().FirstOrDefault(a => a.Id == activo.ActivoFisicoId);

                if (activoFisico == null)
                {
                    throw new EntidadNoEncontradaNegocioExcepcion($"No se encontró el activo físico con Id {activo.ActivoFisicoId} para actualizar su estado.");
                }

                activoFisico.EstadoId = (int)estadoDestino;
                repoActivoFisico.Actualizar(activoFisico);
            }

            ctx.SaveChanges();

            string valoresNuevos = $"Fecha Salida: {salida.FechaSalida}, No Salida: {salida.NumSalida}, Razón: {salida.RazonSalida}, Obs: {salida.Observaciones}";

            var auditoriaServicios = new AuditoriaServicios();
            auditoriaServicios.Registrar("Salida", salida.Id, TipoAccionAuditoria.Crear, string.Empty, valoresNuevos);

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
            throw new ReglaNegocioExcepcion("Error al registrar la transacción de salida de activos.", ex);
        }
    }

    /// <summary>
    /// Determina el estado resultante de un activo físico en base al motivo de la salida.
    /// </summary>
    private EstadoActivoFisico ObtenerEstadoDesdeMotivo(MotivoSalida motivo)
    {
        return motivo switch
        {
            MotivoSalida.DanioIrreparable or
            MotivoSalida.Venta or
            MotivoSalida.Donacion or
            MotivoSalida.Robo or
            MotivoSalida.Extravio or
            MotivoSalida.Transferencia or
            MotivoSalida.OtroMotivo => EstadoActivoFisico.DadoDeBaja,
            _ => EstadoActivoFisico.Disponible
        };
    }
}
