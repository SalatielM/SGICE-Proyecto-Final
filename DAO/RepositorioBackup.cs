using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using MODELOS;

namespace DAO
{
    public class RepositorioBackup
    {

        public void CrearBackup(string rutaArchivo)
        {
            using var context = new AppDbContext();

            string nombreBD = context.Database.GetDbConnection().Database;
            string sql = $@"BACKUP DATABASE [{nombreBD}]TO DISK = N'{rutaArchivo}'WITH INIT,NAME='Copia de Seguridad';";
            context.Database.ExecuteSqlRaw(sql);
        }

        public void RestaurarBackup(string rutaArchivo)
        {
            using var context = new AppDbContext();

            string nombreDB = context.Database.GetDbConnection().Database;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(context.Database.GetConnectionString());
            builder.InitialCatalog = "master";

            context.Dispose();

            using SqlConnection conexion = new SqlConnection(builder.ConnectionString);
            conexion.Open();
            string sql = $@"ALTER DATABASE [{nombreDB}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE [{nombreDB}] FROM DISK = @Ruta WITH REPLACE; ALTER DATABASE [{nombreDB}] SET MULTI_USER;";

            using SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Ruta", rutaArchivo);
            comando.CommandTimeout = 0;
            comando.ExecuteNonQuery();
        }

        public void Registrar(Backup backup)
        {
            using var context = new AppDbContext();
            context.backup.Add(backup);
            context.SaveChanges();
        }

        public List<Backup> ObtenerTodos()
        {
            using var context = new AppDbContext();
            return context.backup.OrderByDescending(x => x.FechaCreacion).ToList();
        }

        public Backup ObtenerPorRuta(string ruta)
        {
            using var context = new AppDbContext();
            return context.backup .FirstOrDefault(x => x.RutaBackup == ruta);
        }

        public Backup ObtenerPorId(int id)
        {
            using var context = new AppDbContext();
            return context.backup.FirstOrDefault(x => x.IdBackup == id);
        }
     }
}


