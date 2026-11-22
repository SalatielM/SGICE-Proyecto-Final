using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class RepositorioGenerico<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositorioGenerico(AppDbContext ctx)
        {
            _context = ctx;
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> ObtenerTodos()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public T ObtenerPorId(int id)
        {
            return _dbSet.Find(id);
        }

        public void Agregar(T entidad)
        {
            _dbSet.Add(entidad);
            _context.SaveChanges();
        }

        public void Actualizar(T entidad)
        {
            if (entidad == null) return;

            var keyProps = _context.Model.FindEntityType(typeof(T))?
                .FindPrimaryKey()?
                .Properties;

            if (keyProps == null || !keyProps.Any())
            {
                throw new InvalidOperationException($"No se encontraron las claves primarias para la entidad '{typeof(T).Name}'.");
            }

            object[] keyValues = keyProps
                .Select(p => entidad.GetType().GetProperty(p.Name)?
                .GetValue(entidad) ?? throw new InvalidOperationException($"La Propiedad '{p.Name}' no puede ser nula"))
                .ToArray();

            var trackedEntity = _dbSet.Local.FirstOrDefault(e =>
                keyProps.Zip(keyValues, (p, v) => Equals(e.GetType().GetProperty(p.Name)?.GetValue(e), v)).All(match => match)
            );

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

        public void Eliminar(T entidad)
        {
            if (entidad != null)
            {
                _dbSet.Remove(entidad);
                _context.SaveChanges();
            }
        }

        public IQueryable<T> Consultar()
        {
            return _dbSet;
        }
    }
}