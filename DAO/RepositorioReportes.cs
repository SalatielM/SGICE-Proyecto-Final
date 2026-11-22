using MODELOS;
using System.Data;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class RepositorioReportes
    {

        private readonly AppDbContext _context;
        public RepositorioReportes()
        {
            _context = new AppDbContext();
        }

        public DataTable ObtenerReporte(TipoReporte tipoReporte, ReporteFiltroDTO filtros) 
        {

            switch (tipoReporte)
            {
                case TipoReporte.ActivosFisicos:
                    return ReporteActivosFisicos(filtros);

                case TipoReporte.Auditoria:
                    return ReporteAuditoria(filtros);

                case TipoReporte.Devoluciones:
                    return ReporteDevoluciones(filtros);

                case TipoReporte.Entradas:
                    return ReporteEntradas(filtros);

                case TipoReporte.Mantenimientos:
                    return ReporteMantenimientos(filtros);

                case TipoReporte.Personal:
                    return ReportePersonal(filtros);

                case TipoReporte.Prestamos:
                    return ReportePrestamos(filtros);

                case TipoReporte.Salidas:
                    return ReporteSalidas(filtros);

                case TipoReporte.SolicitudMantenimiento:
                    return ReporteSolicitudMantenimiento(filtros);

                case TipoReporte.Traslados:
                    return ReporteTraslados(filtros);

                case TipoReporte.Usuarios:
                    return ReporteUsuarios(filtros);

                default:
                    return new DataTable();
            }
        }

        private DataTable ReporteActivosFisicos(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<ActivoFisico>().AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where(af => af.FechaRegistro >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(e => e.FechaRegistro < fechaHasta);
            }
            if (filtros.ActivoId.HasValue) consulta = consulta.Where(af => af.ActivoId == filtros.ActivoId.Value);
            if (filtros.MarcaId.HasValue) consulta = consulta.Where(af => af.Activo.MarcaId == filtros.MarcaId.Value);
            if (filtros.CategoriaId.HasValue) consulta = consulta.Where(af => af.Activo.SubCategoriaId == filtros.CategoriaId.Value);
            if (filtros.UbicacionId.HasValue) consulta = consulta.Where(af => af.UbicacionId == filtros.UbicacionId.Value);
            if (filtros.EstadoActivoFisicoId.HasValue) consulta = consulta.Where(af => af.EstadoId == filtros.EstadoActivoFisicoId.Value);
            if (filtros.PersonalId.HasValue) consulta = consulta.Where(af => af.Activo.PersonalEncargadoId == filtros.PersonalId.Value);

            var datos = consulta
                .AsNoTracking()
                .Select(af => new
                {
                    No = af.IdActivoFisico,
                    Activo = af.Activo.Nombre,
                    Etiqueta = af.CodEtiquetaQR,
                    Categoria = af.Activo.SubCategoria.Nombre,
                    Marca = af.Activo.Marca.Nombre,
                    Ubicacion = af.Ubicacion.Nombre,
                    Encargado = af.Activo.PersonalEncargado.Nombre + " " + af.Activo.PersonalEncargado.Apellido,
                    Estado = af.Estado.Nombre
                }).OrderBy(x => x.No).ToList();

            return ConvertirDataTable(datos);
        }

        private DataTable ReporteAuditoria(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<Auditoria>().AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where(d => d.FechaRegistro >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(a => a.FechaRegistro < fechaHasta);
            }
            if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(a => a.UsuarioAuditoria.IdUsuario == filtros.UsuarioRegistraId.Value);
            if (filtros.AccionAuditoria.HasValue) consulta = consulta.Where(a => a.Accion == filtros.AccionAuditoria.Value);
            if (!string.IsNullOrWhiteSpace(filtros.NombreTabla)) consulta = consulta.Where(a => a.NombreTabla == filtros.NombreTabla);

            var datos = consulta
                .Select(a => new
                {
                    No = a.IdAuditoria,
                    Fecha = a.FechaRegistro,
                    Usuario = a.UsuarioAuditoria.NombreUsuario,
                    Tabla = a.NombreTabla,
                    Registro = a.RegistroId,
                    Accion = a.Accion.ToString(),
                    Detalle = a.NombreTabla  + " #" + a.RegistroId
                }).OrderByDescending(x => x.No).ToList();

            return ConvertirDataTable(datos);
        }

        private DataTable ReporteDevoluciones(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<Devolucion>().AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where(d => d.FechaDevolucion >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(d => d.FechaDevolucion < fechaHasta);
            }
            if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(d => d.UsuarioResgistro.IdUsuario == filtros.UsuarioRegistraId.Value);
            if (filtros.EstadoDevolucionId.HasValue) consulta = consulta.Where(d => d.Detalledevoluciones.Any( dd => dd.EstadoDevolucionId == filtros.EstadoDevolucionId.Value));

            var datos = consulta
                .AsNoTracking()
                .Select(d => new
                {
                    d.IdDevolucion,
                    d.FechaDevolucion,
                    Usuario = d.UsuarioResgistro.Nombre + " " + d.UsuarioResgistro.Apellido,

                    Detalles = d.Detalledevoluciones.Select(dd => new
                    {
                        Activo = dd.ActivoFisico.Activo.Nombre,
                        Etiqueta = dd.ActivoFisico.CodEtiquetaQR,
                        Categoria = dd.ActivoFisico.Activo.SubCategoria.Nombre,
                        Estado = dd.EstadoDevolucion.Nombre
                    })
                })
                .AsEnumerable()
                .SelectMany(d => d.Detalles.Select(dd => new
                {
                    No = d.IdDevolucion,
                    Fecha = d.FechaDevolucion,
                    Usuario_Registro = d.Usuario,
                    Activo = dd.Activo,
                    Etiqueta = dd.Etiqueta,
                    Categoria = dd.Categoria,
                    Estado = dd.Estado
                }))
                .OrderByDescending(x => x.No)
                .Take(500)
                .ToList();

            return ConvertirDataTable(datos);
        }

        private DataTable ReporteEntradas(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<Entrada>() .AsQueryable();

            if (filtros.FechaDesde.HasValue)  consulta = consulta.Where(e => e.FechaEntrada >= filtros.FechaDesde.Value.Date);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(e => e.FechaEntrada < fechaHasta);
            }
            if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(e => e.UsuarioRegistro.IdUsuario == filtros.UsuarioRegistraId.Value);

            var datos = consulta
                .AsNoTracking()
                .SelectMany(e => e.DetalleEntradas,(e, de) => new { e, de })
                .SelectMany(x => x.de.ActivosFisicos, (x, af) => new {
                    No = x.e.NumEntrada,
                    Activo = x.de.Activo.Nombre,
                    Etiqueta = af.CodEtiquetaQR,
                    NumeroSerie = af.NumSerie,
                    Marca = x.de.Activo.Marca.Nombre,
                    Categoria = x.de.Activo.SubCategoria.Nombre,
                    QuienRegistro = x.e.UsuarioRegistro.Nombre + " " + x.e.UsuarioRegistro.Apellido
                }).OrderBy(x => x.No).ToList();

            return ConvertirDataTable(datos);
        }

        private DataTable ReporteMantenimientos(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<Mantenimiento>().AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where(m => m.FechaInicioAtencion >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(e => e.FechaInicioAtencion < fechaHasta);
            }
            if (filtros.PersonalId.HasValue) consulta = consulta.Where(m => m.PersonalTecnico.IdPersonal == filtros.PersonalId.Value);
            if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(m => m.UsuarioRegistro.IdUsuario == filtros.UsuarioRegistraId.Value);
            if (filtros.EstadoMantenimientoId.HasValue) consulta = consulta.Where(m => m.Estado.IdEstado == filtros.EstadoMantenimientoId.Value);
            if (filtros.ActivoId.HasValue) consulta = consulta.Where(m => m.DetalleMantenimientos.Any(dm => dm.ActivoFisico.ActivoId == filtros.ActivoId.Value));
            if (filtros.MarcaId.HasValue) consulta = consulta.Where(m => m.DetalleMantenimientos.Any(dm => dm.ActivoFisico.Activo.MarcaId == filtros.MarcaId.Value));
            if (!string.IsNullOrWhiteSpace(filtros.CodEtiquetaQR)) consulta = consulta.Where(m => m.DetalleMantenimientos.Any(dm => dm.ActivoFisico.CodEtiquetaQR == filtros.CodEtiquetaQR));

            var datos = consulta
                .AsNoTracking()
                .SelectMany(m => m.DetalleMantenimientos.Select(dm => new {
                    No = m.IdMantenimiento,
                    Inicio = m.FechaInicioAtencion,
                    Fin = m.FechaCierre,
                    Tecnico = m.PersonalTecnico.Nombre + " " + m.PersonalTecnico.Apellido,
                    Activo = dm.ActivoFisico.Activo.Nombre,
                    Etiqueta = dm.ActivoFisico.CodEtiquetaQR,
                    Marca = dm.ActivoFisico.Activo.Marca.Nombre,
                    Estado = dm.Estado.Nombre

                })).OrderByDescending(m => m.No).ToList();

            return ConvertirDataTable(datos);
        }

        private DataTable ReportePersonal(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<Personal>().AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where(p => p.FechaCreacion >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(e => e.FechaCreacion < fechaHasta);
            }

            if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(p => p.UsuarioRegistro.IdUsuario == filtros.UsuarioRegistraId.Value);
            if (filtros.EstadoGenerico.HasValue) consulta = consulta.Where(p => p.Estado.IdEstado == filtros.EstadoGenerico.Value);
            if (filtros.PuestoId.HasValue) consulta = consulta.Where(p => p.Puesto.IdPuesto == filtros.PuestoId.Value);

            var datos = consulta
                .AsNoTracking()
                .Select(p => new
                {
                    No = p.IdPersonal,
                    Nombre_Completo = p.Nombre + " " + p.Apellido,
                    Cedula = p.Cedula,
                    Codigo = p.CodPersonal,
                    Puesto = p.Puesto,
                    Correo = p.Correo,
                    Telefono = p.Telefono,
                    Estado = p.Estado.Nombre

                }).OrderBy(x => x.No).ToList();

            return ConvertirDataTable(datos);
        }

        private DataTable ReportePrestamos(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<Prestamo>() .AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where( p => p.FechaPrestamo >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(e => e.FechaPrestamo < fechaHasta);
            }
            if (filtros.PersonalId.HasValue) consulta = consulta.Where( p => p.PersonalSolicitante.IdPersonal == filtros.PersonalId.Value);
            if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where( p => p.UsuarioRegistro.IdUsuario == filtros.UsuarioRegistraId.Value);
            if (filtros.EstadoPrestamoId.HasValue) consulta = consulta.Where( p => p.Estado.IdEstado == filtros.EstadoPrestamoId.Value);
            if (filtros.ActivoId.HasValue) consulta = consulta.Where(p => p.DetallePrestamos.Any(dp => dp.ActivoFisico.ActivoId == filtros.ActivoId.Value));
            if (filtros.MarcaId.HasValue) consulta = consulta.Where(p => p.DetallePrestamos.Any(dp => dp.ActivoFisico.Activo.MarcaId == filtros.MarcaId.Value));
            if (!string.IsNullOrWhiteSpace(filtros.CodEtiquetaQR)) consulta = consulta.Where(p => p.DetallePrestamos.Any(dp => dp.ActivoFisico.CodEtiquetaQR == filtros.CodEtiquetaQR));

            var datos = consulta
                .AsNoTracking()
                .SelectMany(p => p.DetallePrestamos.Select( dp => new
                {
                    p.IdPrestamo,
                    p.FechaPrestamo,
                    p.FechaLimite,
                    Estado = p.Estado.Nombre,
                    Solicitante = p.PersonalSolicitante.Nombre + " " + p.PersonalSolicitante.Apellido,
                    RegistradoPor = p.UsuarioRegistro.Nombre + " " + p.UsuarioRegistro.Apellido,
                    Activo = dp.ActivoFisico.Activo.Nombre,
                    Etiqueta = dp.ActivoFisico.CodEtiquetaQR,
                    NumSerie = dp.ActivoFisico.NumSerie
                })).OrderByDescending(x => x.IdPrestamo).ToList(); 
                
            return ConvertirDataTable(datos);
        }

        private DataTable ReporteSalidas(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<Salida>() .AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where(p => p.FechaSalida >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(e => e.FechaSalida < fechaHasta);
            }
            if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(p => p.UsuarioRegistro.IdUsuario == filtros.UsuarioRegistraId.Value);

            var datos = consulta
                .AsNoTracking()
                .SelectMany(s => s.DetalleSalidas.Select(ds => new
                {
                    No = s.IdSalida,
                    Fecha = s.FechaSalida,
                    Razon = s.RazonSalida,
                    Activo = ds.ActivoFisico.Activo.Nombre,
                    Etiqueta = ds.ActivoFisico.CodEtiquetaQR,
                    Marca = ds.ActivoFisico.Activo.Marca.Nombre,
                    Categoria = ds.ActivoFisico.Activo.SubCategoria.Nombre,
                    Usuaro = s.UsuarioRegistro.Nombre + " " + s.UsuarioRegistro.Apellido
                })).OrderByDescending(x => x.No).ToList();

            return ConvertirDataTable(datos);
        }

        private DataTable ReporteSolicitudMantenimiento(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<SolicitudMantenimiento>().AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where(sm => sm.FechaSolicitud >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(e => e.FechaSolicitud < fechaHasta);
            }
            if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(sm => sm.UsuarioRegistro.IdUsuario == filtros.UsuarioRegistraId.Value);
            if (filtros.ActivoId.HasValue) consulta = consulta.Where(m => m.DetalleSolicitudMantenimientos.Any(dm => dm.ActivoFisico.ActivoId == filtros.ActivoId.Value));

            var datos = consulta
                .AsNoTracking()
                .SelectMany(sm => sm.DetalleSolicitudMantenimientos.Select(dsm => new
                {
                    No = sm.IdSolicitudMantenimiento,
                    Fecha = sm.FechaSolicitud,
                    Activo = dsm.ActivoFisico.Activo.Nombre,
                    Marca = dsm.ActivoFisico.Activo.Marca.Nombre,
                    Categoria = dsm.ActivoFisico.Activo.SubCategoria.Nombre,
                    Estado_Solicitud = sm.Estado.Nombre

                })).OrderByDescending(x => x.No).ToList();

            return ConvertirDataTable(datos);
        }

        private DataTable ReporteTraslados(ReporteFiltroDTO filtros)
        {

            var consulta = _context.Set<Traslado>().AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where(sm => sm.FechaTraslado >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(e => e.FechaTraslado < fechaHasta);
            }
            if (filtros.UbicacionDestinoId.HasValue) consulta = consulta.Where(t => t.UsuarioRegistro.IdUsuario == filtros.UsuarioRegistraId.Value);
            if (filtros.UbicacionOrigenId.HasValue) consulta = consulta.Where(t => t.DetalleTraslados.Any(dt => dt.UbicacionActualId == filtros.UbicacionOrigenId));
            if (filtros.UbicacionDestinoId.HasValue) consulta = consulta.Where(t => t.DetalleTraslados.Any(dt => dt.UbicacionFinalId == filtros.UbicacionDestinoId));

            var datos = consulta
                .AsNoTracking()
                .SelectMany(t => t.DetalleTraslados.Select(dt => new
                {
                    No = t.IdTraslado,
                    Fecha = t.FechaTraslado,
                    Razon = t.RazonTraslado,
                    Activo = dt.ActivoFisico.Activo.Nombre,
                    Marca = dt.ActivoFisico.Activo.Marca.Nombre,
                    Categoira = dt.ActivoFisico.Activo.SubCategoria.Nombre,
                    Ubicacion_Origen = dt.UbicacionActual.Nombre,
                    Ubicacion_Destino = dt.UbicacionFinal.Nombre
                })).OrderByDescending(x => x.No).ToList();

            return ConvertirDataTable(datos);
        }

        private DataTable ReporteUsuarios(ReporteFiltroDTO filtros)
        {
            var consulta = _context.Set<Usuario>().AsQueryable();

            if (filtros.FechaDesde.HasValue) consulta = consulta.Where(p => p.FechaCreacion >= filtros.FechaDesde.Value);
            if (filtros.FechaHasta.HasValue)
            {
                var fechaHasta = filtros.FechaHasta.Value.Date.AddDays(1);
                consulta = consulta.Where(e => e.FechaCreacion < fechaHasta);
            }

            if (filtros.UsuarioRegistraId.HasValue) consulta = consulta.Where(p => p.UsuarioRegistro.IdUsuario == filtros.UsuarioRegistraId.Value);
            if (filtros.EstadoGenerico.HasValue) consulta = consulta.Where(p => p.Estado.IdEstado == filtros.EstadoGenerico.Value);
            if (filtros.RolId.HasValue) consulta = consulta.Where(p => p.Rol.IdRol == filtros.RolId.Value);

            var datos = consulta
                .AsNoTracking()
                .Select(u => new
                {
                    No = u.IdUsuario,
                    Nombre_Completo = u.Nombre + " " + u.Apellido,
                    Cedula = u.Cedula,
                    Usuario = u.NombreUsuario,
                    Rol = u.Rol.Nombre,
                    Correo = u.Correo,
                    Telefono = u.Telefono,
                    Estado = u.Estado.Nombre
                }).OrderBy(x => x.No).ToList();

            return ConvertirDataTable(datos);

        }

        private DataTable ConvertirDataTable<T>(List<T> lista)
        {
            DataTable dt = new DataTable();

            PropertyInfo[] propiedades = typeof(T).GetProperties();

            foreach (PropertyInfo propiedad in propiedades)
            {
                Type tipo = Nullable.GetUnderlyingType(propiedad.PropertyType) ?? propiedad.PropertyType;
                dt.Columns.Add(propiedad.Name, tipo);
            }

            foreach (T item in lista)
            {
                DataRow fila = dt.NewRow();

                foreach (PropertyInfo propiedad in propiedades)
                {
                    fila[propiedad.Name] = propiedad.GetValue(item) ?? DBNull.Value;
                }

                dt.Rows.Add(fila);
            }

            return dt;
        }
    }
}
