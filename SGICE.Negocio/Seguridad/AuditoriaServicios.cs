using Microsoft.EntityFrameworkCore;
using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Entidades.Enums;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Seguridad;

/// <summary>
/// Registra y consulta las bitácoras de auditoría de acciones sobre la base de datos.
/// </summary>
public class AuditoriaServicios
{
    public void Registrar(string tabla, int registroId, TipoAccionAuditoria accion, string? valorAnterior, string? valorNuevo)
    {
        Validador.ValidarRequerido(tabla, "Nombre de Tabla");
        Validador.ValidarRangoPositivo(registroId, "RegistroId");

        using var ctx = new AppDbContext();
        int directorId = ObtenerDirectorVigenteId(ctx);
        if (directorId <= 0)
        {
            directorId = 1; // Respaldo por omisión
        }

        var auditoria = new Auditoria
        {
            NombreTabla = tabla,
            RegistroId = registroId,
            Accion = accion,
            ValoresAntiguos = valorAnterior,
            ValoresNuevos = valorNuevo,
            FechaRegistro = DateTime.Now,
            UsuarioAuditoriaId = SesionActual.Usuario.Id,
            DirectorId = directorId
        };

        var repo = new RepositorioGenerico<Auditoria>(ctx);
        repo.Agregar(auditoria);
    }

    public int ObtenerDirectorVigenteId()
    {
        using var ctx = new AppDbContext();
        return ObtenerDirectorVigenteId(ctx);
    }

    private static int ObtenerDirectorVigenteId(AppDbContext ctx)
    {
        var director = ctx.Director
            .Include(d => d.Estado)
            .FirstOrDefault(d => d.Estado != null && d.Estado.Nombre == "Activo");

        return director?.Id ?? 1;
    }

    public IEnumerable<Auditoria> ConsultarHistorial(string tabla, int registroId)
    {
        Validador.ValidarRequerido(tabla, "Nombre de Tabla");

        using var ctx = new AppDbContext();
        return ctx.Auditoria
            .AsNoTracking()
            .Where(a => a.NombreTabla == tabla && a.RegistroId == registroId)
            .OrderByDescending(a => a.FechaRegistro)
            .ToList();
    }
}
