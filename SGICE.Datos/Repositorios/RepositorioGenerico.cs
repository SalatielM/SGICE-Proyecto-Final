using System.Linq.Expressions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SGICE.Datos.Excepciones;
using SGICE.Entidades;

namespace SGICE.Datos.Repositorios;

/// <summary>
/// Implementación de repositorio genérico con Entity Framework Core.
/// Maneja bloques try-catch-finally jerárquicos y consultas LINQ optimizadas.
/// </summary>
/// <typeparam name="T">Entidad de dominio derivada de EntidadBase</typeparam>
public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : EntidadBase
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public RepositorioGenerico(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<T>();
    }

    public virtual IEnumerable<T> ObtenerTodos()
    {
        try
        {
            return _dbSet.AsNoTracking().ToList();
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de SQL al obtener todos los registros de {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error inesperado al consultar {typeof(T).Name}.", ex);
        }
        finally
        {
            // Bloque finally para trazabilidad y limpieza si procede
        }
    }

    public virtual async Task<IEnumerable<T>> ObtenerTodosAsync()
    {
        try
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de SQL al obtener todos los registros de {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error inesperado al consultar {typeof(T).Name}.", ex);
        }
        finally
        {
        }
    }

    public virtual T? ObtenerPorId(int id)
    {
        try
        {
            return _dbSet.Find(id) ?? _dbSet.FirstOrDefault(e => e.Id == id);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de SQL al obtener {typeof(T).Name} con Id {id}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error inesperado al buscar {typeof(T).Name} con Id {id}.", ex);
        }
        finally
        {
        }
    }

    public virtual async Task<T?> ObtenerPorIdAsync(int id)
    {
        try
        {
            var entity = await _dbSet.FindAsync(id);
            return entity ?? await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de SQL al obtener {typeof(T).Name} con Id {id}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error inesperado al buscar {typeof(T).Name} con Id {id}.", ex);
        }
        finally
        {
        }
    }

    public virtual IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
    {
        try
        {
            return _dbSet.AsNoTracking().Where(predicado).ToList();
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de SQL al filtrar registros de {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error inesperado al filtrar {typeof(T).Name}.", ex);
        }
        finally
        {
        }
    }

    public virtual async Task<IEnumerable<T>> BuscarAsync(Expression<Func<T, bool>> predicado)
    {
        try
        {
            return await _dbSet.AsNoTracking().Where(predicado).ToListAsync();
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de SQL al filtrar registros de {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error inesperado al filtrar {typeof(T).Name}.", ex);
        }
        finally
        {
        }
    }

    public virtual void Agregar(T entidad)
    {
        if (entidad == null) throw new ArgumentNullException(nameof(entidad));

        try
        {
            _dbSet.Add(entidad);
            _context.SaveChanges();
        }
        catch (DbUpdateException ex)
        {
            throw new DatosExcepcion($"Error al insertar registro en {typeof(T).Name}. Verifique restricciones de integridad.", ex);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de base de datos al agregar {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error general al agregar {typeof(T).Name}.", ex);
        }
        finally
        {
        }
    }

    public virtual async Task AgregarAsync(T entidad)
    {
        if (entidad == null) throw new ArgumentNullException(nameof(entidad));

        try
        {
            await _dbSet.AddAsync(entidad);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            throw new DatosExcepcion($"Error al insertar registro en {typeof(T).Name}. Verifique restricciones de integridad.", ex);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de base de datos al agregar {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error general al agregar {typeof(T).Name}.", ex);
        }
        finally
        {
        }
    }

    public virtual void Actualizar(T entidad)
    {
        if (entidad == null) throw new ArgumentNullException(nameof(entidad));

        try
        {
            var trackedEntity = _dbSet.Local.FirstOrDefault(e => e.Id == entidad.Id);
            if (trackedEntity != null)
            {
                _context.Entry(trackedEntity).CurrentValues.SetValues(entidad);
            }
            else
            {
                _dbSet.Update(entidad);
            }

            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new ConcurrenciaDatosExcepcion($"Conflicto de concurrencia al actualizar {typeof(T).Name} con Id {entidad.Id}.", ex);
        }
        catch (DbUpdateException ex)
        {
            throw new DatosExcepcion($"Error al actualizar {typeof(T).Name} con Id {entidad.Id}. Verifique datos relacionados.", ex);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de SQL al actualizar {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error inesperado al actualizar {typeof(T).Name}.", ex);
        }
        finally
        {
        }
    }

    public virtual async Task ActualizarAsync(T entidad)
    {
        if (entidad == null) throw new ArgumentNullException(nameof(entidad));

        try
        {
            var trackedEntity = _dbSet.Local.FirstOrDefault(e => e.Id == entidad.Id);
            if (trackedEntity != null)
            {
                _context.Entry(trackedEntity).CurrentValues.SetValues(entidad);
            }
            else
            {
                _dbSet.Update(entidad);
            }

            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new ConcurrenciaDatosExcepcion($"Conflicto de concurrencia al actualizar {typeof(T).Name} con Id {entidad.Id}.", ex);
        }
        catch (DbUpdateException ex)
        {
            throw new DatosExcepcion($"Error al actualizar {typeof(T).Name} con Id {entidad.Id}.", ex);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de SQL al actualizar {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error inesperado al actualizar {typeof(T).Name}.", ex);
        }
        finally
        {
        }
    }

    public virtual void Eliminar(T entidad)
    {
        if (entidad == null) throw new ArgumentNullException(nameof(entidad));

        try
        {
            _dbSet.Remove(entidad);
            _context.SaveChanges();
        }
        catch (DbUpdateException ex)
        {
            throw new DatosExcepcion($"No se puede eliminar {typeof(T).Name} porque tiene registros dependientes.", ex);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de base de datos al eliminar {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error general al eliminar {typeof(T).Name}.", ex);
        }
        finally
        {
        }
    }

    public virtual async Task EliminarAsync(T entidad)
    {
        if (entidad == null) throw new ArgumentNullException(nameof(entidad));

        try
        {
            _dbSet.Remove(entidad);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            throw new DatosExcepcion($"No se puede eliminar {typeof(T).Name} porque tiene registros dependientes.", ex);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de base de datos al eliminar {typeof(T).Name}.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error general al eliminar {typeof(T).Name}.", ex);
        }
        finally
        {
        }
    }

    public virtual void EliminarPorId(int id)
    {
        var entidad = ObtenerPorId(id);
        if (entidad == null)
        {
            throw new RegistroNoEncontradoExcepcion(typeof(T).Name, id);
        }
        Eliminar(entidad);
    }

    public virtual async Task EliminarPorIdAsync(int id)
    {
        var entidad = await ObtenerPorIdAsync(id);
        if (entidad == null)
        {
            throw new RegistroNoEncontradoExcepcion(typeof(T).Name, id);
        }
        await EliminarAsync(entidad);
    }

    public virtual IQueryable<T> Consultar()
    {
        return _dbSet;
    }

    public virtual int GuardarCambios()
    {
        try
        {
            return _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new ConcurrenciaDatosExcepcion("Error de concurrencia al guardar los cambios en la base de datos.", ex);
        }
        catch (DbUpdateException ex)
        {
            throw new DatosExcepcion("Error de actualización en la base de datos.", ex);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion("Error de SQL Server al confirmar los cambios.", ex);
        }
        finally
        {
        }
    }

    public virtual async Task<int> GuardarCambiosAsync()
    {
        try
        {
            return await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new ConcurrenciaDatosExcepcion("Error de concurrencia al guardar los cambios en la base de datos.", ex);
        }
        catch (DbUpdateException ex)
        {
            throw new DatosExcepcion("Error de actualización en la base de datos.", ex);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion("Error de SQL Server al confirmar los cambios.", ex);
        }
        finally
        {
        }
    }
}
