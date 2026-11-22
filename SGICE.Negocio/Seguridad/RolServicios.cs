using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Seguridad;

/// <summary>
/// Provee servicios de consulta y validación de roles en el sistema.
/// </summary>
public class RolServicios
{
    public IEnumerable<Rol> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Rol>(ctx);
        return repo.ObtenerTodos();
    }

    public Rol ObtenerPorId(int idRol)
    {
        Validador.ValidarRangoPositivo(idRol, "IdRol");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Rol>(ctx);
        var rol = repo.ObtenerPorId(idRol);

        if (rol == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Rol), idRol);
        }

        return rol;
    }

    public Rol ObtenerPorNombre(string nombre)
    {
        Validador.ValidarRequerido(nombre, "Nombre de Rol");

        string limpio = nombre.Trim().ToLower();
        using var ctx = new AppDbContext();
        var rol = ctx.Rol.FirstOrDefault(r => r.Nombre.ToLower() == limpio);

        if (rol == null)
        {
            throw new ReglaNegocioExcepcion($"El rol '{nombre}' no existe en el sistema.");
        }

        return rol;
    }

    public IEnumerable<RolDTO> Listar()
    {
        using var ctx = new AppDbContext();
        return ctx.Rol
            .Select(r => new RolDTO
            {
                IdRol = r.Id,
                Nombre = r.Nombre
            }).ToList();
    }

    public void ValidarRol(int idRol)
    {
        ObtenerPorId(idRol);
    }
}
