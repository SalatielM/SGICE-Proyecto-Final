using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SGICE.Datos.Excepciones;
using SGICE.Entidades;
using SGICE.Entidades.Enums;

namespace SGICE.Datos.Repositorios;

/// <summary>
/// Implementación del repositorio especializado de activos físicos.
/// Ejecuta operaciones críticas con soporte obligatorio de transacciones explícitas (BeginTransaction / IDbContextTransaction)
/// y bloques try-catch-finally jerárquicos.
/// </summary>
public class RepositorioActivos : RepositorioGenerico<ActivoFisico>, IRepositorioActivos
{
    public RepositorioActivos(AppDbContext context) : base(context)
    {
    }

    /// <summary>
    /// Asigna o reubica un activo físico de manera transaccional.
    /// Actualiza la ubicación del activo físico, el responsable y registra la auditoría.
    /// </summary>
    public bool AsignarActivoConTransaccion(int activoFisicoId, int nuevaUbicacionId, int nuevoEncargadoId, int usuarioRegistroId, string observaciones)
    {
        IDbContextTransaction? transaccion = null;

        try
        {
            transaccion = _context.Database.BeginTransaction();

            var activoFisico = _context.ActivoFisico
                .Include(af => af.Activo)
                .FirstOrDefault(af => af.Id == activoFisicoId);

            if (activoFisico == null)
            {
                throw new RegistroNoEncontradoExcepcion(nameof(ActivoFisico), activoFisicoId);
            }

            int ubicacionAnterior = activoFisico.UbicacionId;
            activoFisico.UbicacionId = nuevaUbicacionId;
            activoFisico.EstadoId = (int)EstadoActivoFisico.Disponible;

            if (activoFisico.Activo != null && nuevoEncargadoId > 0)
            {
                activoFisico.Activo.PersonalEncargadoId = nuevoEncargadoId;
                activoFisico.Activo.UsuarioActualizacionId = usuarioRegistroId;
                activoFisico.Activo.FechaActualizacion = DateTime.Now;
            }

            // Registro en Auditoría
            var auditoria = new Auditoria
            {
                NombreTabla = "ActivoFisico",
                RegistroId = activoFisicoId,
                Accion = TipoAccionAuditoria.Actualizar,
                ValoresAntiguos = $"UbicacionId:{ubicacionAnterior}",
                ValoresNuevos = $"UbicacionId:{nuevaUbicacionId}; EncargadoId:{nuevoEncargadoId}; Obs:{observaciones}",
                FechaRegistro = DateTime.Now,
                UsuarioAuditoriaId = usuarioRegistroId,
                DirectorId = 1
            };

            _context.Auditoria.Add(auditoria);
            _context.SaveChanges();

            transaccion.Commit();
            return true;
        }
        catch (DbUpdateConcurrencyException ex)
        {
            transaccion?.Rollback();
            throw new ConcurrenciaDatosExcepcion($"Conflicto al asignar el activo físico {activoFisicoId}.", ex);
        }
        catch (DbUpdateException ex)
        {
            transaccion?.Rollback();
            throw new TransaccionDatosExcepcion($"Asignación de Activo {activoFisicoId}", ex);
        }
        catch (SqlException ex)
        {
            transaccion?.Rollback();
            throw new DatosExcepcion($"Error de SQL Server al asignar el activo físico {activoFisicoId}.", ex);
        }
        catch (Exception ex)
        {
            transaccion?.Rollback();
            throw new TransaccionDatosExcepcion($"Asignación de Activo {activoFisicoId}", ex);
        }
        finally
        {
            transaccion?.Dispose();
        }
    }

    /// <summary>
    /// Versión asíncrona de asignación de activo físico con transacción explícita.
    /// </summary>
    public async Task<bool> AsignarActivoConTransaccionAsync(int activoFisicoId, int nuevaUbicacionId, int nuevoEncargadoId, int usuarioRegistroId, string observaciones)
    {
        IDbContextTransaction? transaccion = null;

        try
        {
            transaccion = await _context.Database.BeginTransactionAsync();

            var activoFisico = await _context.ActivoFisico
                .Include(af => af.Activo)
                .FirstOrDefaultAsync(af => af.Id == activoFisicoId);

            if (activoFisico == null)
            {
                throw new RegistroNoEncontradoExcepcion(nameof(ActivoFisico), activoFisicoId);
            }

            int ubicacionAnterior = activoFisico.UbicacionId;
            activoFisico.UbicacionId = nuevaUbicacionId;
            activoFisico.EstadoId = (int)EstadoActivoFisico.Disponible;

            if (activoFisico.Activo != null && nuevoEncargadoId > 0)
            {
                activoFisico.Activo.PersonalEncargadoId = nuevoEncargadoId;
                activoFisico.Activo.UsuarioActualizacionId = usuarioRegistroId;
                activoFisico.Activo.FechaActualizacion = DateTime.Now;
            }

            var auditoria = new Auditoria
            {
                NombreTabla = "ActivoFisico",
                RegistroId = activoFisicoId,
                Accion = TipoAccionAuditoria.Actualizar,
                ValoresAntiguos = $"UbicacionId:{ubicacionAnterior}",
                ValoresNuevos = $"UbicacionId:{nuevaUbicacionId}; EncargadoId:{nuevoEncargadoId}; Obs:{observaciones}",
                FechaRegistro = DateTime.Now,
                UsuarioAuditoriaId = usuarioRegistroId,
                DirectorId = 1
            };

            await _context.Auditoria.AddAsync(auditoria);
            await _context.SaveChangesAsync();

            await transaccion.CommitAsync();
            return true;
        }
        catch (DbUpdateConcurrencyException ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new ConcurrenciaDatosExcepcion($"Conflicto al asignar el activo físico {activoFisicoId}.", ex);
        }
        catch (DbUpdateException ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new TransaccionDatosExcepcion($"Asignación de Activo {activoFisicoId}", ex);
        }
        catch (SqlException ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new DatosExcepcion($"Error de SQL Server al asignar el activo físico {activoFisicoId}.", ex);
        }
        catch (Exception ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new TransaccionDatosExcepcion($"Asignación de Activo {activoFisicoId}", ex);
        }
        finally
        {
            if (transaccion != null) await transaccion.DisposeAsync();
        }
    }

    /// <summary>
    /// Ejecuta el traslado formal de una lista de activos entre ubicaciones bajo una transacción explícita.
    /// Si cualquier actualización o inserción falla, la transacción realiza Rollback garantizando atomicidad.
    /// </summary>
    public bool TrasladarActivosConTransaccion(Traslado traslado, IEnumerable<DetalleTraslado> detalles)
    {
        if (traslado == null) throw new ArgumentNullException(nameof(traslado));
        if (detalles == null || !detalles.Any()) throw new ArgumentException("Debe incluir al menos un detalle para el traslado.", nameof(detalles));

        IDbContextTransaction? transaccion = null;

        try
        {
            transaccion = _context.Database.BeginTransaction();

            // 1. Insertar cabecera de Traslado
            _context.Traslado.Add(traslado);
            _context.SaveChanges();

            // 2. Procesar cada detalle y actualizar la ubicación actual de cada activo físico
            foreach (var detalle in detalles)
            {
                detalle.TrasladoId = traslado.Id;

                var activo = _context.ActivoFisico.Find(detalle.ActivoFisicoId);
                if (activo == null)
                {
                    throw new RegistroNoEncontradoExcepcion(nameof(ActivoFisico), detalle.ActivoFisicoId);
                }

                detalle.UbicacionActualId = activo.UbicacionId;
                activo.UbicacionId = detalle.UbicacionFinalId;

                _context.DetalleTraslado.Add(detalle);

                // Auditoría individual
                _context.Auditoria.Add(new Auditoria
                {
                    NombreTabla = "ActivoFisico",
                    RegistroId = activo.Id,
                    Accion = TipoAccionAuditoria.Actualizar,
                    ValoresAntiguos = $"UbicacionId:{detalle.UbicacionActualId}",
                    ValoresNuevos = $"UbicacionId:{detalle.UbicacionFinalId}; TrasladoId:{traslado.Id}",
                    FechaRegistro = DateTime.Now,
                    UsuarioAuditoriaId = traslado.UsuarioRegistroId,
                    DirectorId = traslado.AutorizadoPorId
                });
            }

            _context.SaveChanges();
            transaccion.Commit();
            return true;
        }
        catch (DbUpdateConcurrencyException ex)
        {
            transaccion?.Rollback();
            throw new ConcurrenciaDatosExcepcion("Conflicto de concurrencia al realizar el traslado de activos.", ex);
        }
        catch (DbUpdateException ex)
        {
            transaccion?.Rollback();
            throw new TransaccionDatosExcepcion("Traslado de Activos", ex);
        }
        catch (SqlException ex)
        {
            transaccion?.Rollback();
            throw new DatosExcepcion("Error de SQL Server al procesar la transacción de traslado.", ex);
        }
        catch (Exception ex)
        {
            transaccion?.Rollback();
            throw new TransaccionDatosExcepcion("Traslado de Activos", ex);
        }
        finally
        {
            transaccion?.Dispose();
        }
    }

    /// <summary>
    /// Versión asíncrona de traslado de activos con transacción explícita.
    /// </summary>
    public async Task<bool> TrasladarActivosConTransaccionAsync(Traslado traslado, IEnumerable<DetalleTraslado> detalles)
    {
        if (traslado == null) throw new ArgumentNullException(nameof(traslado));
        if (detalles == null || !detalles.Any()) throw new ArgumentException("Debe incluir al menos un detalle para el traslado.", nameof(detalles));

        IDbContextTransaction? transaccion = null;

        try
        {
            transaccion = await _context.Database.BeginTransactionAsync();

            await _context.Traslado.AddAsync(traslado);
            await _context.SaveChangesAsync();

            foreach (var detalle in detalles)
            {
                detalle.TrasladoId = traslado.Id;

                var activo = await _context.ActivoFisico.FindAsync(detalle.ActivoFisicoId);
                if (activo == null)
                {
                    throw new RegistroNoEncontradoExcepcion(nameof(ActivoFisico), detalle.ActivoFisicoId);
                }

                detalle.UbicacionActualId = activo.UbicacionId;
                activo.UbicacionId = detalle.UbicacionFinalId;

                await _context.DetalleTraslado.AddAsync(detalle);

                await _context.Auditoria.AddAsync(new Auditoria
                {
                    NombreTabla = "ActivoFisico",
                    RegistroId = activo.Id,
                    Accion = TipoAccionAuditoria.Actualizar,
                    ValoresAntiguos = $"UbicacionId:{detalle.UbicacionActualId}",
                    ValoresNuevos = $"UbicacionId:{detalle.UbicacionFinalId}; TrasladoId:{traslado.Id}",
                    FechaRegistro = DateTime.Now,
                    UsuarioAuditoriaId = traslado.UsuarioRegistroId,
                    DirectorId = traslado.AutorizadoPorId
                });
            }

            await _context.SaveChangesAsync();
            await transaccion.CommitAsync();
            return true;
        }
        catch (DbUpdateConcurrencyException ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new ConcurrenciaDatosExcepcion("Conflicto de concurrencia al realizar el traslado de activos.", ex);
        }
        catch (DbUpdateException ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new TransaccionDatosExcepcion("Traslado de Activos", ex);
        }
        catch (SqlException ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new DatosExcepcion("Error de SQL Server al procesar la transacción de traslado.", ex);
        }
        catch (Exception ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new TransaccionDatosExcepcion("Traslado de Activos", ex);
        }
        finally
        {
            if (transaccion != null) await transaccion.DisposeAsync();
        }
    }

    /// <summary>
    /// Ejecuta el descargo o salida de activos con transacción explícita.
    /// Cambia el estado del activo físico a 'Dado de Baja' y crea la salida correspondiente.
    /// </summary>
    public bool DescargarActivosConTransaccion(Salida salida, IEnumerable<DetalleSalida> detalles)
    {
        if (salida == null) throw new ArgumentNullException(nameof(salida));
        if (detalles == null || !detalles.Any()) throw new ArgumentException("Debe especificar los activos a descargar.", nameof(detalles));

        IDbContextTransaction? transaccion = null;

        try
        {
            transaccion = _context.Database.BeginTransaction();

            _context.Salida.Add(salida);
            _context.SaveChanges();

            foreach (var detalle in detalles)
            {
                detalle.SalidaId = salida.Id;

                var activo = _context.ActivoFisico.Find(detalle.ActivoFisicoId);
                if (activo == null)
                {
                    throw new RegistroNoEncontradoExcepcion(nameof(ActivoFisico), detalle.ActivoFisicoId);
                }

                int estadoAnterior = activo.EstadoId ?? 0;
                activo.EstadoId = (int)EstadoActivoFisico.DadoDeBaja;

                _context.DetalleSalida.Add(detalle);

                _context.Auditoria.Add(new Auditoria
                {
                    NombreTabla = "ActivoFisico",
                    RegistroId = activo.Id,
                    Accion = TipoAccionAuditoria.Actualizar,
                    ValoresAntiguos = $"EstadoId:{estadoAnterior}",
                    ValoresNuevos = $"EstadoId:{(int)EstadoActivoFisico.DadoDeBaja}; SalidaId:{salida.Id}; Motivo:{detalle.MotivoSalida}",
                    FechaRegistro = DateTime.Now,
                    UsuarioAuditoriaId = salida.UsuarioRegistroId,
                    DirectorId = 1
                });
            }

            _context.SaveChanges();
            transaccion.Commit();
            return true;
        }
        catch (DbUpdateException ex)
        {
            transaccion?.Rollback();
            throw new TransaccionDatosExcepcion("Descargo de Activos", ex);
        }
        catch (SqlException ex)
        {
            transaccion?.Rollback();
            throw new DatosExcepcion("Error de base de datos durante el descargo de activos.", ex);
        }
        catch (Exception ex)
        {
            transaccion?.Rollback();
            throw new TransaccionDatosExcepcion("Descargo de Activos", ex);
        }
        finally
        {
            transaccion?.Dispose();
        }
    }

    /// <summary>
    /// Versión asíncrona de descargo de activos con transacción explícita.
    /// </summary>
    public async Task<bool> DescargarActivosConTransaccionAsync(Salida salida, IEnumerable<DetalleSalida> detalles)
    {
        if (salida == null) throw new ArgumentNullException(nameof(salida));
        if (detalles == null || !detalles.Any()) throw new ArgumentException("Debe especificar los activos a descargar.", nameof(detalles));

        IDbContextTransaction? transaccion = null;

        try
        {
            transaccion = await _context.Database.BeginTransactionAsync();

            await _context.Salida.AddAsync(salida);
            await _context.SaveChangesAsync();

            foreach (var detalle in detalles)
            {
                detalle.SalidaId = salida.Id;

                var activo = await _context.ActivoFisico.FindAsync(detalle.ActivoFisicoId);
                if (activo == null)
                {
                    throw new RegistroNoEncontradoExcepcion(nameof(ActivoFisico), detalle.ActivoFisicoId);
                }

                int estadoAnterior = activo.EstadoId ?? 0;
                activo.EstadoId = (int)EstadoActivoFisico.DadoDeBaja;

                await _context.DetalleSalida.AddAsync(detalle);

                await _context.Auditoria.AddAsync(new Auditoria
                {
                    NombreTabla = "ActivoFisico",
                    RegistroId = activo.Id,
                    Accion = TipoAccionAuditoria.Actualizar,
                    ValoresAntiguos = $"EstadoId:{estadoAnterior}",
                    ValoresNuevos = $"EstadoId:{(int)EstadoActivoFisico.DadoDeBaja}; SalidaId:{salida.Id}; Motivo:{detalle.MotivoSalida}",
                    FechaRegistro = DateTime.Now,
                    UsuarioAuditoriaId = salida.UsuarioRegistroId,
                    DirectorId = 1
                });
            }

            await _context.SaveChangesAsync();
            await transaccion.CommitAsync();
            return true;
        }
        catch (DbUpdateException ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new TransaccionDatosExcepcion("Descargo de Activos", ex);
        }
        catch (SqlException ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new DatosExcepcion("Error de base de datos durante el descargo de activos.", ex);
        }
        catch (Exception ex)
        {
            if (transaccion != null) await transaccion.RollbackAsync();
            throw new TransaccionDatosExcepcion("Descargo de Activos", ex);
        }
        finally
        {
            if (transaccion != null) await transaccion.DisposeAsync();
        }
    }
}
