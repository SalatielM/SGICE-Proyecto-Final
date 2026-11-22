using System.Data;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SGICE.Datos.Excepciones;
using SGICE.Entidades;
using SGICE.Entidades.DTOs;
using SGICE.Entidades.Enums;

namespace SGICE.Datos.Repositorios;

/// <summary>
/// Repositorio de consulta para generación y exportación de reportes tabulares (DataTable).
/// </summary>
public class RepositorioReportes
{
    private readonly AppDbContext _context;

    public RepositorioReportes(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public DataTable ObtenerReporte(TipoReporte tipoReporte, ReporteFiltroDTO filtros)
    {
        try
        {
            return tipoReporte switch
            {
                TipoReporte.ActivosFisicos => ReporteActivosFisicos(filtros),
                TipoReporte.Auditoria => ReporteAuditoria(filtros),
                TipoReporte.Devoluciones => ReporteDevoluciones(filtros),
                TipoReporte.Entradas => ReporteEntradas(filtros),
                TipoReporte.Mantenimientos => ReporteMantenimientos(filtros),
                TipoReporte.Personal => ReportePersonal(filtros),
                TipoReporte.Prestamos => ReportePrestamos(filtros),
                TipoReporte.Salidas => ReporteSalidas(filtros),
                TipoReporte.SolicitudMantenimiento => ReporteSolicitudMantenimiento(filtros),
                TipoReporte.Traslados => ReporteTraslados(filtros),
                TipoReporte.Usuarios => ReporteUsuarios(filtros),
                _ => new DataTable()
            };
        }
        catch (Exception ex)
        {
            throw new DatosExcepcion($"Error al generar el reporte de tipo '{tipoReporte}'.", ex);
        }
    }

    private DataTable ReporteActivosFisicos(ReporteFiltroDTO filtros)
    {
        var consulta = _context.ActivoFisico.AsNoTracking().AsQueryable();

        if (filtros.FechaDesde.HasValue) consulta = consulta.Where(af => af.FechaRegistro >= filtros.FechaDesde.Value);
        if (filtros.FechaHasta.HasValue)
        {
            var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
            consulta = consulta.Where(e => e.FechaRegistro < fechaHasta);
        }
        if (filtros.ActivoId.HasValue) consulta = consulta.Where(af => af.ActivoId == filtros.ActivoId.Value);
        if (filtros.MarcaId.HasValue) consulta = consulta.Where(af => af.Activo != null && af.Activo.MarcaId == filtros.MarcaId.Value);
        if (filtros.CategoriaId.HasValue) consulta = consulta.Where(af => af.Activo != null && af.Activo.SubCategoriaId == filtros.CategoriaId.Value);
        if (filtros.UbicacionId.HasValue) consulta = consulta.Where(af => af.UbicacionId == filtros.UbicacionId.Value);
        if (filtros.EstadoActivoFisicoId.HasValue) consulta = consulta.Where(af => af.EstadoId == filtros.EstadoActivoFisicoId.Value);
        if (filtros.PersonalId.HasValue) consulta = consulta.Where(af => af.Activo != null && af.Activo.PersonalEncargadoId == filtros.PersonalId.Value);

        var datos = consulta
            .Select(af => new
            {
                No = af.Id,
                Activo = af.Activo != null ? af.Activo.Nombre : string.Empty,
                Etiqueta = af.CodEtiquetaQR,
                Categoria = af.Activo != null && af.Activo.SubCategoria != null ? af.Activo.SubCategoria.Nombre : string.Empty,
                Marca = af.Activo != null && af.Activo.Marca != null ? af.Activo.Marca.Nombre : string.Empty,
                Ubicacion = af.Ubicacion != null ? af.Ubicacion.Nombre : string.Empty,
                Encargado = af.Activo != null && af.Activo.PersonalEncargado != null ? af.Activo.PersonalEncargado.Nombre + " " + af.Activo.PersonalEncargado.Apellido : string.Empty,
                Estado = af.Estado != null ? af.Estado.Nombre : string.Empty
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReporteAuditoria(ReporteFiltroDTO filtros)
    {
        var consulta = _context.Auditoria.AsNoTracking().AsQueryable();

        if (filtros.FechaDesde.HasValue) consulta = consulta.Where(d => d.FechaRegistro >= filtros.FechaDesde.Value);
        if (filtros.FechaHasta.HasValue)
        {
            var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
            consulta = consulta.Where(d => d.FechaRegistro < fechaHasta);
        }
        if (filtros.UsuarioAuditoriaId.HasValue) consulta = consulta.Where(d => d.UsuarioAuditoriaId == filtros.UsuarioAuditoriaId.Value);
        if (!string.IsNullOrEmpty(filtros.NombreTabla)) consulta = consulta.Where(d => d.NombreTabla == filtros.NombreTabla);
        if (filtros.RegistroId.HasValue) consulta = consulta.Where(d => d.RegistroId == filtros.RegistroId.Value);
        if (filtros.AccionAuditoria.HasValue) consulta = consulta.Where(d => d.Accion == filtros.AccionAuditoria.Value);

        var datos = consulta
            .Select(d => new
            {
                No = d.Id,
                Tabla = d.NombreTabla,
                Accion = d.Accion.ToString(),
                ValoresAntiguos = d.ValoresAntiguos,
                ValoresNuevos = d.ValoresNuevos,
                Usuario = d.UsuarioAuditoria != null ? d.UsuarioAuditoria.NombreUsuario : string.Empty,
                Fecha = d.FechaRegistro
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReporteDevoluciones(ReporteFiltroDTO filtros)
    {
        var consulta = _context.Devolucion.AsNoTracking().AsQueryable();

        if (filtros.FechaDesde.HasValue) consulta = consulta.Where(d => d.FechaRegistro >= filtros.FechaDesde.Value);
        if (filtros.FechaHasta.HasValue)
        {
            var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
            consulta = consulta.Where(d => d.FechaRegistro < fechaHasta);
        }
        if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(d => d.UsuarioRegistroId == filtros.UsuarioRegistraId.Value);

        var datos = consulta
            .Select(d => new
            {
                No = d.Id,
                PrestamoId = d.PrestamoId,
                Fecha = d.FechaRegistro,
                Usuario = d.UsuarioResgistro != null ? d.UsuarioResgistro.NombreUsuario : string.Empty,
                Observacion = d.ObervacioneGeneral
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReporteEntradas(ReporteFiltroDTO filtros)
    {
        var consulta = _context.Entrada.AsNoTracking().AsQueryable();

        if (filtros.FechaDesde.HasValue) consulta = consulta.Where(e => e.FechaRegistro >= filtros.FechaDesde.Value);
        if (filtros.FechaHasta.HasValue)
        {
            var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
            consulta = consulta.Where(e => e.FechaRegistro < fechaHasta);
        }
        if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(e => e.UsuarioRegistroId == filtros.UsuarioRegistraId.Value);

        var datos = consulta
            .Select(e => new
            {
                No = e.Id,
                NumeroEntrada = e.NumEntrada,
                Fecha = e.FechaRegistro,
                Documento = e.DocReferencia.ToString(),
                NoDocumento = e.NoDocReferencia,
                Observacion = e.ObservacionEntrada
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReporteMantenimientos(ReporteFiltroDTO filtros)
    {
        var consulta = _context.Mantenimiento.AsNoTracking().AsQueryable();

        if (filtros.FechaDesde.HasValue) consulta = consulta.Where(m => m.FechaInicioAtencion >= filtros.FechaDesde.Value);
        if (filtros.FechaHasta.HasValue)
        {
            var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
            consulta = consulta.Where(m => m.FechaInicioAtencion < fechaHasta);
        }
        if (filtros.EstadoMantenimientoId.HasValue) consulta = consulta.Where(m => m.EstadoId == filtros.EstadoMantenimientoId.Value);

        var datos = consulta
            .Select(m => new
            {
                No = m.Id,
                SolicitudId = m.SolicitudMantenimientoId,
                Tecnico = m.PersonalTecnico != null ? m.PersonalTecnico.Nombre + " " + m.PersonalTecnico.Apellido : string.Empty,
                FechaInicio = m.FechaInicioAtencion,
                FechaCierre = m.FechaCierre,
                Estado = m.Estado != null ? m.Estado.Nombre : string.Empty
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReportePersonal(ReporteFiltroDTO filtros)
    {
        var consulta = _context.Personal.AsNoTracking().AsQueryable();

        if (filtros.PuestoId.HasValue) consulta = consulta.Where(p => p.PuestoId == filtros.PuestoId.Value);
        if (filtros.EstadoGenerico.HasValue) consulta = consulta.Where(p => p.EstadoId == filtros.EstadoGenerico.Value);

        var datos = consulta
            .Select(p => new
            {
                No = p.Id,
                Codigo = p.CodPersonal,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Cedula = p.Cedula,
                Telefono = p.Telefono,
                Correo = p.Correo,
                Puesto = p.Puesto != null ? p.Puesto.Nombre : string.Empty,
                Estado = p.Estado != null ? p.Estado.Nombre : string.Empty
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReportePrestamos(ReporteFiltroDTO filtros)
    {
        var consulta = _context.Prestamo.AsNoTracking().AsQueryable();

        if (filtros.FechaDesde.HasValue) consulta = consulta.Where(p => p.FechaRegistro >= filtros.FechaDesde.Value);
        if (filtros.FechaHasta.HasValue)
        {
            var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
            consulta = consulta.Where(p => p.FechaRegistro < fechaHasta);
        }
        if (filtros.PersonalId.HasValue) consulta = consulta.Where(p => p.PersonalSolicitanteId == filtros.PersonalId.Value);
        if (filtros.EstadoPrestamoId.HasValue) consulta = consulta.Where(p => p.EstadoId == filtros.EstadoPrestamoId.Value);

        var datos = consulta
            .Select(p => new
            {
                No = p.Id,
                Solicitante = p.PersonalSolicitante != null ? p.PersonalSolicitante.Nombre + " " + p.PersonalSolicitante.Apellido : string.Empty,
                FechaPrestamo = p.FechaRegistro,
                FechaLimite = p.FechaLimite,
                Estado = p.Estado != null ? p.Estado.Nombre : string.Empty
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReporteSalidas(ReporteFiltroDTO filtros)
    {
        var consulta = _context.Salida.AsNoTracking().AsQueryable();

        if (filtros.FechaDesde.HasValue) consulta = consulta.Where(s => s.FechaRegistro >= filtros.FechaDesde.Value);
        if (filtros.FechaHasta.HasValue)
        {
            var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
            consulta = consulta.Where(s => s.FechaRegistro < fechaHasta);
        }

        var datos = consulta
            .Select(s => new
            {
                No = s.Id,
                NumeroSalida = s.NumSalida,
                Fecha = s.FechaRegistro,
                Razon = s.RazonSalida,
                Observaciones = s.Observaciones
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReporteSolicitudMantenimiento(ReporteFiltroDTO filtros)
    {
        var consulta = _context.SolicitudMantenimiento.AsNoTracking().AsQueryable();

        if (filtros.FechaDesde.HasValue) consulta = consulta.Where(sm => sm.FechaRegistro >= filtros.FechaDesde.Value);
        if (filtros.FechaHasta.HasValue)
        {
            var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
            consulta = consulta.Where(sm => sm.FechaRegistro < fechaHasta);
        }
        if (filtros.EstadoMantenimientoId.HasValue) consulta = consulta.Where(sm => sm.EstadoId == filtros.EstadoMantenimientoId.Value);

        var datos = consulta
            .Select(sm => new
            {
                No = sm.Id,
                Fecha = sm.FechaRegistro,
                Observacion = sm.ObservacionGeneral,
                Estado = sm.Estado != null ? sm.Estado.Nombre : string.Empty
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReporteTraslados(ReporteFiltroDTO filtros)
    {
        var consulta = _context.Traslado.AsNoTracking().AsQueryable();

        if (filtros.FechaDesde.HasValue) consulta = consulta.Where(t => t.FechaRegistro >= filtros.FechaDesde.Value);
        if (filtros.FechaHasta.HasValue)
        {
            var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
            consulta = consulta.Where(t => t.FechaRegistro < fechaHasta);
        }

        var datos = consulta
            .Select(t => new
            {
                No = t.Id,
                Fecha = t.FechaRegistro,
                Razon = t.RazonTraslado,
                AutorizadoPor = t.AutorizadoPor != null ? t.AutorizadoPor.Nombre + " " + t.AutorizadoPor.Apellido : string.Empty,
                Documento = t.DocAutorizacion.ToString(),
                NoDocumento = t.NoDocAutorizacion
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private DataTable ReporteUsuarios(ReporteFiltroDTO filtros)
    {
        var consulta = _context.Usuario.AsNoTracking().AsQueryable();

        if (filtros.RolId.HasValue) consulta = consulta.Where(u => u.RolId == filtros.RolId.Value);
        if (filtros.EstadoGenerico.HasValue) consulta = consulta.Where(u => u.EstadoId == filtros.EstadoGenerico.Value);

        var datos = consulta
            .Select(u => new
            {
                No = u.Id,
                Usuario = u.NombreUsuario,
                Nombre = u.Nombre,
                Apellido = u.Apellido,
                Cedula = u.Cedula,
                Telefono = u.Telefono,
                Correo = u.Correo,
                Rol = u.Rol != null ? u.Rol.Nombre : string.Empty,
                Estado = u.Estado != null ? u.Estado.Nombre : string.Empty
            }).OrderBy(x => x.No).ToList();

        return ConvertirDataTable(datos);
    }

    private static DataTable ConvertirDataTable<T>(IEnumerable<T> lista)
    {
        var tabla = new DataTable(typeof(T).Name);
        var propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var prop in propiedades)
        {
            var tipo = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
            tabla.Columns.Add(prop.Name, tipo);
        }

        foreach (var item in lista)
        {
            var valores = new object?[propiedades.Length];
            for (int i = 0; i < propiedades.Length; i++)
            {
                valores[i] = propiedades[i].GetValue(item, null);
            }
            tabla.Rows.Add(valores);
        }

        return tabla;
    }
}
