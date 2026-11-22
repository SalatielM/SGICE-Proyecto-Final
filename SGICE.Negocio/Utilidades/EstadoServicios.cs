using Microsoft.EntityFrameworkCore;
using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Utilidades;

/// <summary>
/// Servicios de consulta y validación de estados configurados en el sistema.
/// </summary>
public class EstadoServicios
{
    public IEnumerable<Estado> ObtenerTodos()
    {
        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Estado>(ctx);
        return repo.ObtenerTodos();
    }

    public Estado ObtenerPorId(int idEstado)
    {
        Validador.ValidarRangoPositivo(idEstado, "IdEstado");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<Estado>(ctx);
        var estado = repo.ObtenerPorId(idEstado);

        if (estado == null)
        {
            throw new EntidadNoEncontradaNegocioExcepcion(nameof(Estado), idEstado);
        }

        return estado;
    }

    public Estado ObtenerPorNombre(string nombre, TipoEstadoEnum tipoEstado)
    {
        Validador.ValidarRequerido(nombre, "Nombre del Estado");

        string limpio = nombre.Trim().ToLower();
        int tipoId = (int)tipoEstado;

        using var ctx = new AppDbContext();
        var estado = ctx.Estado
            .AsNoTracking()
            .FirstOrDefault(e => e.Nombre.ToLower() == limpio && e.TipoEstadoId == tipoId);

        if (estado == null)
        {
            throw new ReglaNegocioExcepcion($"No se encontró el estado '{nombre}' para el tipo especificado.");
        }

        return estado;
    }

    public IEnumerable<Estado> ObtenerPorTipo(TipoEstadoEnum tipoEstado)
    {
        int tipoId = (int)tipoEstado;
        using var ctx = new AppDbContext();
        return ctx.Estado.AsNoTracking().Where(e => e.TipoEstadoId == tipoId).ToList();
    }

    public void ValidarEstado(int estadoId, TipoEstadoEnum tipoEsperado)
    {
        Validador.ValidarRangoPositivo(estadoId, "EstadoId");

        var estado = ObtenerPorId(estadoId);
        if (estado.TipoEstadoId != (int)tipoEsperado)
        {
            throw new ReglaNegocioExcepcion($"El estado seleccionado ('{estado.Nombre}') no corresponde al tipo requerido ({tipoEsperado}).");
        }
    }
}
