using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SGICE.Datos.Excepciones;
using SGICE.Entidades;

namespace SGICE.Datos.Repositorios;

/// <summary>
/// Repositorio para la creación, registro y restauración de copias de seguridad de la base de datos.
/// </summary>
public class RepositorioBackup
{
    private readonly AppDbContext _context;

    public RepositorioBackup(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void CrearBackup(string rutaArchivo)
    {
        try
        {
            string nombreBD = _context.Database.GetDbConnection().Database;
            if (string.IsNullOrEmpty(nombreBD)) nombreBD = "PSGestionActivosDB";

            var parametroRuta = new SqlParameter("@Ruta", rutaArchivo);
            string sql = $"BACKUP DATABASE [{nombreBD}] TO DISK = @Ruta WITH INIT, NAME = 'Copia de Seguridad SGICE';";

            _context.Database.ExecuteSqlRaw(sql, parametroRuta);
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error al crear la copia de seguridad en '{rutaArchivo}'.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion("Error inesperado durante la operación de Backup.", ex);
        }
    }

    public void RestaurarBackup(string rutaArchivo)
    {
        try
        {
            string nombreBD = _context.Database.GetDbConnection().Database;
            if (string.IsNullOrEmpty(nombreBD)) nombreBD = "PSGestionActivosDB";

            var builder = new SqlConnectionStringBuilder(_context.Database.GetConnectionString())
            {
                InitialCatalog = "master"
            };

            using var conexion = new SqlConnection(builder.ConnectionString);
            conexion.Open();

            string sql = $@"
                ALTER DATABASE [{nombreBD}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [{nombreBD}] FROM DISK = @Ruta WITH REPLACE;
                ALTER DATABASE [{nombreBD}] SET MULTI_USER;";

            using var comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Ruta", rutaArchivo);
            comando.CommandTimeout = 0;
            comando.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw new DatosExcepcion($"Error de SQL Server al restaurar la base de datos desde '{rutaArchivo}'.", ex);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion("Error inesperado al restaurar la copia de seguridad.", ex);
        }
    }

    public void Registrar(Backup backup)
    {
        try
        {
            _context.backup.Add(backup);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion("Error al registrar el historial de Backup.", ex);
        }
    }

    public List<Backup> ObtenerTodos()
    {
        try
        {
            return _context.backup.AsNoTracking().OrderByDescending(x => x.FechaRegistro).ToList();
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion("Error al consultar el historial de copias de seguridad.", ex);
        }
    }

    public Backup? ObtenerPorRuta(string ruta)
    {
        try
        {
            return _context.backup.AsNoTracking().FirstOrDefault(x => x.RutaBackup == ruta);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error al buscar la copia de seguridad en la ruta '{ruta}'.", ex);
        }
    }

    public Backup? ObtenerPorId(int id)
    {
        try
        {
            return _context.backup.Find(id);
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error al buscar la copia de seguridad con Id {id}.", ex);
        }
    }
}
