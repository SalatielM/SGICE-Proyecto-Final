using Microsoft.EntityFrameworkCore;
using SGICE.Datos;
using SGICE.Datos.Repositorios;
using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Negocio.Excepciones;
using SGICE.Negocio.Seguridad;
using SGICE.Negocio.Validaciones;

namespace SGICE.Negocio.Catalogos;

/// <summary>
/// Gestiona la información institucional y sede del centro educativo.
/// </summary>
public class CentroEducativoServicios
{
    private readonly AuditoriaServicios _auditoria = new();

    public CentroEducativoDTO ObtenerInfoCentro()
    {
        using var ctx = new AppDbContext();
        var centro = ctx.Escuela
            .AsNoTracking()
            .FirstOrDefault();

        if (centro == null)
        {
            return new CentroEducativoDTO
            {
                Nombre = "Centro Educativo Modelo",
                CodCentro = "ESC-001",
                Telefono = "809-555-0101",
                Correo = "contacto@escuela.edu.do",
                Direccion = "Av. Principal No. 1",
                DistritoEducativo = "10-01",
                RegionalEducativo = "10"
            };
        }

        return new CentroEducativoDTO
        {
            IdCentroEducativo = centro.Id,
            Foto = centro.Foto,
            Nombre = centro.Nombre,
            CodCentro = centro.CodCentro,
            Telefono = centro.Telefono,
            Correo = centro.Correo,
            Direccion = centro.Direccion,
            Longitud = centro.Longitud,
            Latitud = centro.Latitud,
            DistritoEducativo = centro.DistritoEducativo,
            RegionalEducativo = centro.RegionalEducativo
        };
    }

    public void GuardarCentro(CentroEducativo centro)
    {
        if (centro == null) throw new ArgumentNullException(nameof(centro));

        Validador.ValidarRequerido(centro.Nombre, "Nombre del Centro");
        Validador.ValidarRequerido(centro.CodCentro, "Código del Centro");
        Validador.ValidarTelefono(centro.Telefono, "Teléfono del Centro");
        Validador.ValidarCorreo(centro.Correo, "Correo del Centro", obligatorio: false);
        Validador.ValidarRequerido(centro.Direccion, "Dirección");
        Validador.ValidarRequerido(centro.DistritoEducativo, "Distrito Educativo");
        Validador.ValidarRequerido(centro.RegionalEducativo, "Regional Educativo");
        Validador.ValidarRangoPositivo(centro.DirectorId, "Director");

        using var ctx = new AppDbContext();
        var repo = new RepositorioGenerico<CentroEducativo>(ctx);
        var existente = ctx.Escuela.FirstOrDefault();

        if (existente == null)
        {
            centro.UsuarioRegistroId = SesionActual.Usuario.Id;
            centro.FechaRegistro = DateTime.Now;
            repo.Agregar(centro);
            _auditoria.Registrar("Escuela", centro.Id, SGICE.Entidades.Enums.TipoAccionAuditoria.Crear, string.Empty, centro.Nombre);
        }
        else
        {
            existente.Nombre = centro.Nombre;
            existente.CodCentro = centro.CodCentro;
            existente.Telefono = centro.Telefono;
            existente.Correo = centro.Correo;
            existente.Direccion = centro.Direccion;
            existente.Foto = centro.Foto ?? existente.Foto;
            existente.Latitud = centro.Latitud;
            existente.Longitud = centro.Longitud;
            existente.Modalidad = centro.Modalidad;
            existente.Jornada = centro.Jornada;
            existente.DistritoEducativo = centro.DistritoEducativo;
            existente.RegionalEducativo = centro.RegionalEducativo;
            existente.DirectorId = centro.DirectorId;
            existente.UsuarioActualizacionId = SesionActual.Usuario.Id;
            existente.FechaActualizacion = DateTime.Now;

            repo.Actualizar(existente);
            _auditoria.Registrar("Escuela", existente.Id, SGICE.Entidades.Enums.TipoAccionAuditoria.Actualizar, "Actualizado", existente.Nombre);
        }
    }
}
