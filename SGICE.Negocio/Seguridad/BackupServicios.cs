using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Seguridad;

/// <summary>
/// Provee servicios de negocio para copias de seguridad de la base de datos SQL Server.
/// </summary>
public class BackupServicios
{
    public void CrearBackup(string rutaArchivo)
    {
        Validador.ValidarRequerido(rutaArchivo, "Ruta de Archivo de Backup");

        using var ctx = new AppDbContext();
        var repo = new RepositorioBackup(ctx);
        repo.CrearBackup(rutaArchivo);

        repo.Registrar(new Backup
        {
            Nombre = Path.GetFileName(rutaArchivo),
            RutaBackup = rutaArchivo,
            FechaRegistro = DateTime.Now,
            UsuarioRegistroId = SesionActual.Usuario.Id
        });
    }

    public void RestaurarBackup(string rutaArchivo)
    {
        Validador.ValidarRequerido(rutaArchivo, "Ruta de Archivo de Backup");

        using var ctx = new AppDbContext();
        var repo = new RepositorioBackup(ctx);
        repo.RestaurarBackup(rutaArchivo);
    }

    public IEnumerable<Backup> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioBackup(ctx);
        return repo.ObtenerTodos();
    }

    public Backup? ObtenerPorRuta(string ruta)
    {
        Validador.ValidarRequerido(ruta, "Ruta de Backup");

        using var ctx = new AppDbContext();
        var repo = new RepositorioBackup(ctx);
        return repo.ObtenerPorRuta(ruta);
    }

    public Backup? ObtenerPorId(int id)
    {
        Validador.ValidarRangoPositivo(id, "IdBackup");

        using var ctx = new AppDbContext();
        var repo = new RepositorioBackup(ctx);
        return repo.ObtenerPorId(id);
    }
}
