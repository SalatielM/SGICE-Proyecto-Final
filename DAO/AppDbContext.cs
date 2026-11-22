using Microsoft.EntityFrameworkCore;
using MODELOS;

namespace DAO
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Activo> Activo { get; set; }
        public DbSet<ActivoFisico> ActivoFisico { get; set; }
        public DbSet<Auditoria> Auditoria { get; set; }
        public DbSet<Backup> backup { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Devolucion> Devolucion { get; set; }
        public DbSet<DetalleDevolucion> DetalleDevolucion { get; set; }
        public DbSet<DetalleEntrada> DetalleEntrada { get; set; }
        public DbSet<DetalleMantenimiento> DetalleMantenimiento { get; set; }
        public DbSet<DetalleTraslado> DetalleTraslado { get; set; }
        public DbSet<DetallePrestamo> DetallePrestamo { get; set; }
        public DbSet<DetalleSalida> DetalleSalida { get; set; }
        public DbSet<DetalleSolicitudMantenimiento> DetalleSolicitudMantenimiento { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Edificio> Edificio { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<CentroEducativo> Escuela { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Mantenimiento> Mantenimiento { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Traslado> Traslado { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Puesto> Puesto { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolPermiso> RolPermiso { get; set; }
        public DbSet<Salida> Salida { get; set; }
        public DbSet<SolicitudMantenimiento> SolicitudMantenimiento { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<TipoEstado> TipoEstado { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            if (!optionsbuilder.IsConfigured)
            {
                optionsbuilder.UseSqlServer
                    (
                        "Server=RUTCHY_HERNE\\SQLEXPRESS;Database=PSIGestiondeActivosyMobiliariosDB;Integrated Security=True;TrustServerCertificate=True;",
                        sqlOptions => sqlOptions.CommandTimeout(60)
                    );
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
            //_____________________________________________________________________________________________________________________________________________

            var activo = modelBuilder.Entity<Activo>();
            activo.HasKey(a => a.IdActivo);
            
            activo.HasOne(a => a.SubCategoria)
                .WithMany(c => c.Activos)
                .HasForeignKey(a => a.SubCategoriaId)
                .OnDelete(DeleteBehavior.Restrict);
            activo.Property(a => a.SubCategoriaId)
                .IsRequired();
            activo.Property(a => a.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            activo.Property(a => a.Descripcion)
                .HasMaxLength(350);          
            activo.HasOne(a => a.Marca)
                .WithMany(mc => mc.Activos)
                .HasForeignKey(a => a.MarcaId)
                .OnDelete(DeleteBehavior.Restrict);
            activo.Property(a => a.MarcaId)
                .IsRequired();
            activo.HasOne(a => a.Estado)
                .WithMany(est => est.Activos)
                .HasForeignKey(a => a.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            activo.Property(a => a.EstadoId)
                .IsRequired();
            activo.HasOne(a => a.PersonalEncargado)
                .WithMany(us => us.PersonalEncargados)
                .HasForeignKey(a => a.PersonalEncargadoId)
                .OnDelete(DeleteBehavior.Restrict);
            activo.Property(a => a.PersonalEncargadoId)
                .IsRequired();
            activo.HasOne(a => a.Proveedor)
                .WithMany(us => us.Activos)
                .HasForeignKey(a => a.ProveedorId)
                .OnDelete(DeleteBehavior.Restrict);
            activo.Property(a => a.ProveedorId)
                .IsRequired();
            activo.HasOne(a => a.UsuarioRegistro)
                .WithMany(us => us.ActivoRegistros)
                .HasForeignKey(a => a.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            activo.Property(a => a.UsuarioRegistroId)
                .IsRequired();
            activo.HasOne(a => a.UsuarioActualizacion)
                .WithMany(us => us.ActivoActualizacion)
                .HasForeignKey(a => a.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);                   
            activo.Property(a => a.FechaRegistro)
              .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var activoFisico = modelBuilder.Entity<ActivoFisico>();           
            activoFisico.HasKey(af => af.IdActivoFisico);
           
            activoFisico.HasOne(af => af.Activo)
                .WithMany(a => a.ActivosFisicos)
                .HasForeignKey(af => af.ActivoId)
                .OnDelete(DeleteBehavior.Restrict);
            activoFisico.Property(af => af.ActivoId)
                .IsRequired();
            activoFisico.HasOne(af => af.Ubicacion)
                .WithMany(ub => ub.ActivosFisicos)
                .HasForeignKey(af => af.UbicacionId)
                .OnDelete(DeleteBehavior.Restrict);
            activoFisico.Property(af => af.UbicacionId)
                .IsRequired();       
            activoFisico.HasOne(af => af.Estado)
                .WithMany(est => est.ActivosFisicos)
                .HasForeignKey(af => af.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            activoFisico.Property(af => af.EstadoId)
                .IsRequired();
            activoFisico.HasOne(af => af.DetalleEntrada)
                .WithMany(de => de.ActivosFisicos)
                .HasForeignKey(af => af.DetalleEntradaId)
                .OnDelete(DeleteBehavior.Restrict);
            activoFisico.Property(af => af.DetalleEntradaId)
                .IsRequired();
            activoFisico.HasOne(af => af.UsuarioRegistro)
                .WithMany(us => us.ActivoFisicoRegistros)
                .HasForeignKey(af => af.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            activoFisico.Property(af => af.UsuarioRegistroId)
                .IsRequired();
            activoFisico.Property(af => af.CodEtiquetaQR)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired();
            activoFisico.HasIndex(af => af.CodEtiquetaQR)
                .IsUnique();
            activoFisico.Property(af => af.NumSerie)
                .HasMaxLength(100);
            activoFisico.Property(af => af.FechaRegistro)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var auditoria = modelBuilder.Entity<Auditoria>();
            auditoria.HasKey(au => au.IdAuditoria);

            auditoria.Property(au => au.NombreTabla)
                .IsRequired()
                .HasMaxLength(100);
            auditoria.Property(au => au.RegistroId)
                .IsRequired();
            auditoria.Property(au => au.Accion)
                .IsRequired();
            auditoria.Property(au => au.ValoresAntiguos)
                .IsRequired(false);
            auditoria.Property(au => au.ValoresNuevos)
                .IsRequired(false);
            auditoria.HasOne(au => au.UsuarioAuditoria)
                .WithMany() 
                .HasForeignKey(au => au.UsuarioAuditoriaId)
                .OnDelete(DeleteBehavior.Restrict);
            auditoria.HasOne(au => au.Director)
                .WithMany(au => au.Auditorias)
                .HasForeignKey(au => au.DirectorId)
                .OnDelete(DeleteBehavior.Restrict);
            auditoria.Property(au => au.FechaRegistro)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________       
            var backup = modelBuilder.Entity<Backup>();        
            backup.HasKey(b => b.IdBackup);

            backup.HasOne(b => b.UsuarioRegistro)
                .WithMany(us => us.BackupRegistros)
                .HasForeignKey(b => b.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            backup.Property(b => b.UsuarioRegistroId)
                .IsRequired();
            backup.Property(b => b.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            backup.HasIndex(b => b.Nombre)
                .IsUnique();
            backup.Property(b => b.RutaBackup)
                .HasMaxLength(300)
                .IsRequired();
            backup.Property(b => b.FechaCreacion)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________            
            var categoria = modelBuilder.Entity<Categoria>();
            categoria.HasKey(c => c.IdCategoria);
            
            categoria.HasOne(c => c.UsuarioRegistro)
                .WithMany(us => us.CategoriaRegistros)
                .HasForeignKey(c => c.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);          
            categoria.Property(b => b.UsuarioRegistroId)
                .IsRequired();
            categoria.HasOne(c => c.UsuarioActualizacion)
                .WithMany(us => us.CategoriaActualizacions)
                .HasForeignKey(c => c.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);
            categoria.HasOne(c => c.Estado)
                   .WithMany(est => est.Categorias)
                   .HasForeignKey(a => a.EstadoId)
                   .OnDelete(DeleteBehavior.Restrict);
            categoria.Property(c => c.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            categoria.Property(c => c.VidaUtil)
                .IsRequired();
            categoria.HasIndex(c => c.Nombre)
                .IsUnique();
            categoria.Property(c => c.Descripcion)
                .HasMaxLength(300);                 
            categoria.Property(c => c.FechaRegistro)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________          
            var centroeducativo = modelBuilder.Entity<CentroEducativo>();
            centroeducativo.HasKey(es => es.IdCentroEducativo);

            centroeducativo.HasOne(ce => ce.UsuarioRegistro)
                .WithMany(us => us.EscuelaRegistro)
                .HasForeignKey(ce => ce.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            centroeducativo.Property(ce => ce.UsuarioRegistroId)
                .IsRequired();
            centroeducativo.HasOne(ce => ce.Director)
               .WithMany(us => us.CentrosEducativos)
               .HasForeignKey(ce => ce.DirectorId)
               .OnDelete(DeleteBehavior.Restrict);
            centroeducativo.Property(ce => ce.DirectorId)
                .IsRequired();
            centroeducativo.HasOne(ce => ce.UsuarioActualizacion)
                .WithMany(us => us.EscuelaActualizacion)
                .HasForeignKey(ce => ce.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);
            centroeducativo.Property(ce => ce.Nombre)
                .HasMaxLength(100)
                .IsRequired();
            centroeducativo.HasIndex(es => es.Nombre)
                .IsUnique();
            centroeducativo.Property(ce => ce.CodCentro)
                .HasMaxLength(50)
                .IsRequired();
            centroeducativo.HasIndex(es => es.CodCentro)
                .IsUnique();
            centroeducativo.Property(ce => ce.Telefono)
                .HasMaxLength(20)
                .IsRequired();
            centroeducativo.HasIndex(es => es.Telefono)
                .IsUnique();
            centroeducativo.Property(ce => ce.Correo)
                .HasMaxLength(100);
            centroeducativo.HasIndex(es => es.Correo)
                .IsUnique();
            centroeducativo.Property(ce => ce.Direccion)
                .HasMaxLength(200)
                .IsRequired();
            centroeducativo.Property(ce => ce.Jornada)
               .HasMaxLength(50);
            centroeducativo.Property(ce => ce.Modalidad)
               .HasMaxLength(50);
            centroeducativo.HasIndex(es => es.Direccion)
                .IsUnique();
            centroeducativo.Property(ce => ce.DistritoEducativo)
                .HasMaxLength(25)
                .IsRequired();
            centroeducativo.Property(ce => ce.RegionalEducativo)
                .HasMaxLength(25)
                .IsRequired();
            centroeducativo.Property(es => es.FechaCreacion)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var detalledevolucion = modelBuilder.Entity<DetalleDevolucion>();
            detalledevolucion.HasKey(dd => dd.IdDetalleDevolucion);

            detalledevolucion.HasOne(dd => dd.Devolucion)
                .WithMany(dv => dv.Detalledevoluciones)
                .HasForeignKey(dd => dd.DevolucionId)
                .OnDelete(DeleteBehavior.Restrict);
            detalledevolucion.HasOne(dd => dd.ActivoFisico)
                .WithMany(af => af.DetalleDevoluciones)
                .HasForeignKey(dd => dd.ActivoFisicoId)
                .OnDelete(DeleteBehavior.Restrict);
            detalledevolucion.HasOne(dd => dd.EstadoDevolucion)
                .WithMany(est => est.DetalleDevoluciones)
                .HasForeignKey(dd => dd.EstadoDevolucionId)
                .OnDelete(DeleteBehavior.Restrict);
            detalledevolucion.Property(dd => dd.Obervacion)
                .HasMaxLength(300);

            //_____________________________________________________________________________________________________________________________________________
            var detalleentrada = modelBuilder.Entity<DetalleEntrada>();
            detalleentrada.HasKey(de => de.IdDetalleEntrada);
        
            detalleentrada.HasOne(de => de.Entrada)
                .WithMany(et => et.DetalleEntradas)
                .HasForeignKey(de => de.EntradaId)
                .OnDelete(DeleteBehavior.Restrict);
            detalleentrada.Property(de => de.EntradaId)
                .IsRequired();          
            detalleentrada.HasOne(de => de.Activo)
                .WithMany(a => a.DetalleEntradas)
                .HasForeignKey(de => de.ActivoId)
                .OnDelete(DeleteBehavior.Restrict);
            detalleentrada.Property(de => de.ActivoId)
                .IsRequired();
            detalleentrada.Property(de => de.Cantidad)
                .IsRequired();

            //_____________________________________________________________________________________________________________________________________________
            var detallemantenimiento = modelBuilder.Entity<DetalleMantenimiento>();
            detallemantenimiento.HasKey(dma => dma.IdDetalleMantenimiento);
            
            detallemantenimiento.HasOne(dma => dma.Mantenimiento)
                .WithMany(ma => ma.DetalleMantenimientos)
                .HasForeignKey(dma => dma.MantenimientoId)
                .OnDelete(DeleteBehavior.Restrict);
            detallemantenimiento.Property(dma => dma.MantenimientoId)
                .IsRequired();          
             detallemantenimiento.HasOne(dma => dma.ActivoFisico)
                .WithMany(af => af.DetalleMantenimientos)
                .HasForeignKey(dma => dma.ActivoFisicoId)
                .OnDelete(DeleteBehavior.Restrict);
            detallemantenimiento.Property(dma => dma.ActivoFisicoId)
                .IsRequired();           
             detallemantenimiento.HasOne(dma => dma.Estado)
                .WithMany(af => af.DetalleMantenimientos)
                .HasForeignKey(dma => dma.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            detallemantenimiento.Property(dma => dma.EstadoId)
                .IsRequired();
            detallemantenimiento.Property(dma => dma.Solucion)
                .HasMaxLength(300);

            //_____________________________________________________________________________________________________________________________________________
            var detallemovimiento = modelBuilder.Entity<DetalleTraslado>();         
            detallemovimiento.HasKey(dmo =>dmo.IdDetalleMovimiento);
             
            detallemovimiento.HasOne(dmo => dmo.Traslado)
                .WithMany(mo => mo.DetalleTraslados)
                .HasForeignKey(dmo => dmo.TrasladoId)
                .OnDelete(DeleteBehavior.Restrict);           
            detallemovimiento.Property(dmo => dmo.TrasladoId)
                .IsRequired();
            detallemovimiento.HasOne(dmo => dmo.ActivoFisico)
                .WithMany(af => af.DetalleMovimientos)
                .HasForeignKey(dmo => dmo.ActivoFisicoId)
                .OnDelete(DeleteBehavior.Restrict);
            detallemovimiento.Property(dmo => dmo.ActivoFisicoId)
                .IsRequired();
            detallemovimiento.HasOne(mo => mo.UbicacionActual)
                .WithMany(ub => ub.DetalleUbicacionActual)
                .HasForeignKey(mo => mo.UbicacionActualId)
                .OnDelete(DeleteBehavior.Restrict);
            detallemovimiento.Property(mo => mo.UbicacionActualId)
                .IsRequired();
            detallemovimiento.HasOne(mo => mo.UbicacionFinal)
                .WithMany(ub => ub.DetalleUbicacionFinal)
                .HasForeignKey(mo => mo.UbicacionFinalId)
                .OnDelete(DeleteBehavior.Restrict);
            detallemovimiento.Property(mo => mo.UbicacionFinalId)
                .IsRequired();

            //_____________________________________________________________________________________________________________________________________________
            var devolucion = modelBuilder.Entity<Devolucion>();
            devolucion.HasKey(dv => dv.IdDevolucion);

            devolucion.HasOne(dv => dv.Prestamo)
                .WithMany(pt => pt.Devoluciones)
                .HasForeignKey(dv => dv.PrestamoId)
                .OnDelete(DeleteBehavior.Restrict);
            devolucion.HasOne(dv => dv.UsuarioResgistro)
                 .WithMany(us => us.DevolucionRegistros)
                 .HasForeignKey(dv => dv.UsuarioRegistroId)
                 .OnDelete(DeleteBehavior.Restrict);
            devolucion.Property(dv => dv.ObervacioneGeneral)
                .HasMaxLength(300);

            //_____________________________________________________________________________________________________________________________________________
            var detalleprestamo = modelBuilder.Entity<DetallePrestamo>();

            detalleprestamo.HasKey(dp => dp.IdDetallePrestamo);          
            detalleprestamo.HasOne(dp => dp.Prestamo)
                .WithMany(pr => pr.DetallePrestamos)
                .HasForeignKey(dp => dp.PrestamoId)
                .OnDelete(DeleteBehavior.Restrict);           
            detalleprestamo.Property(dp => dp.PrestamoId)
                .IsRequired();           
            detalleprestamo.HasOne(dp => dp.ActivoFisico)
                .WithMany(af => af.DetallePrestamos)
                .HasForeignKey(dp => dp.ActivoFisicoId)
                .OnDelete(DeleteBehavior.Restrict);
            detalleprestamo.Property(dp => dp.ActivoFisicoId)
                .IsRequired();

            //_____________________________________________________________________________________________________________________________________________
            var detallesalida = modelBuilder.Entity<DetalleSalida>();               
            detallesalida.HasKey(ds => ds.IdDetalleSalida);
            
            detallesalida.HasOne(ds => ds.Salida)
                .WithMany(sa => sa.DetalleSalidas)
                .HasForeignKey(ds => ds.SalidaId)
                .OnDelete(DeleteBehavior.Restrict);           
            detallesalida.Property(ds => ds.SalidaId)
                .IsRequired();           
           detallesalida.HasOne(ds => ds.ActivoFisico)
                .WithMany(af => af.DetalleSalidas)
                .HasForeignKey(ds => ds.ActivoFisicoId)
                .OnDelete(DeleteBehavior.Restrict);
            detallesalida.Property(ds => ds.ActivoFisicoId)
                .IsRequired();

            //_____________________________________________________________________________________________________________________________________________
            var detallesolicitudmantenimiento = modelBuilder.Entity<DetalleSolicitudMantenimiento>();           
            detallesolicitudmantenimiento.HasKey(dsm => dsm.IdDetalleSolicitudMantenimiento);

            detallesolicitudmantenimiento.HasOne(dsm => dsm.SolicitudMantenimiento)
                .WithMany(sm => sm.DetalleSolicitudMantenimientos)
                .HasForeignKey(dsm => dsm.SolicitudMantenimientoId)
                .OnDelete(DeleteBehavior.Restrict);           
            detallesolicitudmantenimiento.Property(dsm => dsm.SolicitudMantenimientoId)
                .IsRequired();
            detallesolicitudmantenimiento.HasOne(dsm => dsm.ActivoFisico)
                .WithMany(af => af.DetalleSolicitudMantenimientos)
                .HasForeignKey(dsm => dsm.ActivoFisicoId)
                .OnDelete(DeleteBehavior.Restrict);
            detallesolicitudmantenimiento.Property(dsm => dsm.ActivoFisicoId)
                .IsRequired();
            detallesolicitudmantenimiento.Property(dsm => dsm.DescripcionProblema)
                .HasMaxLength(300);

            //_____________________________________________________________________________________________________________________________________________
            var director = modelBuilder.Entity<Director>();
            director.HasKey(di => di.IdDirector);

            director.HasOne(d => d.UsuarioRegistro)
                .WithMany(d => d.DirectorRegistros)
                .HasForeignKey(d => d.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            director.Property(d => d.UsuarioRegistroId)
                .IsRequired();
            director.HasOne(d => d.UsuarioActualizacion)
                .WithMany(d => d.DirectorActualizacions)
                .HasForeignKey(d => d.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);
            director.Property(d => d.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            director.Property(d => d.Apellido)
                .HasMaxLength(50)
                .IsRequired();
            director.Property(d => d.Cedula)
                .HasMaxLength(20)
                .IsRequired();
            director.Property(d => d.Telefono)
                .HasMaxLength(20)
                .IsRequired();
            director.Property(d => d.Correo)
                .HasMaxLength(100)
                .IsRequired();
            director.Property(d => d.EstadoId)
                .IsRequired();
            director.Property(d => d.FechaInicia)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var edificio = modelBuilder.Entity<Edificio>();
            edificio.HasKey(e => e.IdEdificio);

            edificio.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsRequired();
            edificio.Property(e => e.CodEdificio)
                .HasMaxLength(15)
                .IsRequired();
            edificio.HasIndex(e => e.CodEdificio)
                .IsUnique();
            edificio.Property(e => e.Descripcion)
                .HasMaxLength(300);
            edificio.HasOne(e => e.Estado)
                .WithMany(c => c.Edificios)
                .HasForeignKey(e => e.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            edificio.Property(e => e.EstadoId)
                .IsRequired();
            edificio.HasOne(e => e.UsuarioRegistro)
                .WithMany(c => c.EdificioRegistros)
                .HasForeignKey(e => e.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            edificio.Property(e => e.UsuarioRegistroId)
                .IsRequired();
            edificio.HasOne(e => e.UsuarioActualizacion)
                .WithMany(c => c.EdificioActualizacions)
                .HasForeignKey(e => e.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);
            edificio.Property(ad => ad.FechaConstruccion)
                .HasDefaultValueSql("GETDATE()");
            edificio.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var entrada = modelBuilder.Entity<Entrada>();
            entrada.HasKey(et => et.IdEntrada);

            entrada.HasOne(et => et.UsuarioRegistro)
                .WithMany(us => us.EntradaRegistros)
                .HasForeignKey(et => et.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            entrada.Property(et => et.UsuarioRegistroId)
                .IsRequired();
            entrada.HasIndex(et => et.NumEntrada)
                .IsUnique();
            entrada.Property(et => et.NumEntrada)
                .IsRequired();
            entrada.Property(et => et.DocReferencia)
                .IsRequired();
            entrada.Property(et => et.NoDocReferencia)
                .IsRequired();
            entrada.HasIndex(et => et.NoDocReferencia)
                .IsUnique();
            entrada.Property(et => et.ObservacionEntrada)
                .HasMaxLength(300);
            entrada.Property(et => et.FechaEntrada)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var estado = modelBuilder.Entity<Estado>();               
            estado.HasKey(est => est.IdEstado);
            
            estado.HasOne(est => est.TipoEstado)
                .WithMany(te => te.Estados)
                .HasForeignKey(est => est.TipoEstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            estado.Property(est => est.TipoEstadoId)
                .IsRequired();
            estado.Property(est => est.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            estado.HasIndex(est => new
            {
                est.Nombre,
                est.TipoEstadoId
            }).IsUnique();

            estado.HasData(
        
                new Estado { IdEstado = (int)EstadoGenerico.Activo, Nombre = "Activo", TipoEstadoId = (int)TipoEstadoEnum.EstadoGenerico },
                new Estado { IdEstado = (int)EstadoGenerico.Inactivo, Nombre = "Inactivo", TipoEstadoId = (int)TipoEstadoEnum.EstadoGenerico },

                new Estado { IdEstado = (int)EstadoActivoFisico.Disponible, Nombre = "Disponible", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
                new Estado { IdEstado = (int)EstadoActivoFisico.Prestado, Nombre = "Prestado", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
                new Estado { IdEstado = (int)EstadoActivoFisico.PendienteDeMantenimiento, Nombre = "Pendiente de Mantenimiento", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico},
                new Estado { IdEstado = (int)EstadoActivoFisico.Dañado, Nombre = "Dañado", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
                new Estado { IdEstado = (int)EstadoActivoFisico.Extraviado, Nombre = "Extraviado", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
                new Estado { IdEstado = (int)EstadoActivoFisico.DadoDeBaja, Nombre = "Dado de Baja", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
                new Estado { IdEstado = (int)EstadoActivoFisico.NoDisponible, Nombre = "No Disponible", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },

                new Estado { IdEstado = (int)EstadoDetalleDevolucion.Bueno, Nombre = "Bueno", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },
                new Estado { IdEstado = (int)EstadoDetalleDevolucion.Regular, Nombre = "Regular", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },
                new Estado { IdEstado = (int)EstadoDetalleDevolucion.Averiado, Nombre = "Averiado", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },
                new Estado { IdEstado = (int)EstadoDetalleDevolucion.Incompleto, Nombre = "Incompleto", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },
                new Estado { IdEstado = (int)EstadoDetalleDevolucion.NoDevuelto, Nombre = "No Devuelto", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },

                new Estado { IdEstado = (int)EstadoDetalleMantenimiento.EnProceso, Nombre = "En Proceso", TipoEstadoId = (int)TipoEstadoEnum.DetalleMantenimiento },
                new Estado { IdEstado = (int)EstadoDetalleMantenimiento.Reparado, Nombre = "Reparado", TipoEstadoId = (int)TipoEstadoEnum.DetalleMantenimiento },
                new Estado { IdEstado = (int)EstadoDetalleMantenimiento.NoReparado, Nombre = "No Reparado", TipoEstadoId = (int)TipoEstadoEnum.DetalleMantenimiento },

                new Estado { IdEstado = (int)EstadoMantenimiento.EnProceso, Nombre = "En Proceco", TipoEstadoId = (int)TipoEstadoEnum.Mantenimiento },
                new Estado { IdEstado = (int)EstadoMantenimiento.Finalizado, Nombre = "Finalizado", TipoEstadoId = (int)TipoEstadoEnum.Mantenimiento },
                new Estado { IdEstado = (int)EstadoMantenimiento.Cancelado, Nombre = "Cancelado", TipoEstadoId = (int)TipoEstadoEnum.Mantenimiento },

                new Estado { IdEstado = (int)EstadoPrestamo.Vigente, Nombre = "Vigente", TipoEstadoId = (int)TipoEstadoEnum.Prestamo },
                new Estado { IdEstado = (int)EstadoPrestamo.Devuelto, Nombre = "Devuelto", TipoEstadoId = (int)TipoEstadoEnum.Prestamo },
                new Estado { IdEstado = (int)EstadoPrestamo.DevueltoParcial, Nombre = "Devuelto Parcial", TipoEstadoId = (int)TipoEstadoEnum.Prestamo },
                new Estado { IdEstado = (int)EstadoPrestamo.Vencido, Nombre = "Vencido", TipoEstadoId = (int)TipoEstadoEnum.Prestamo },

                new Estado { IdEstado = (int)EstadoSolicitudMantenimiento.Pendiente, Nombre = "Pendiente", TipoEstadoId = (int)TipoEstadoEnum.SolicitudMantenimiento },
                new Estado { IdEstado = (int)EstadoSolicitudMantenimiento.Aprovada, Nombre = "Aprovada", TipoEstadoId = (int)TipoEstadoEnum.SolicitudMantenimiento },
                new Estado { IdEstado = (int)EstadoSolicitudMantenimiento.Rechazada, Nombre = "Rechazada", TipoEstadoId = (int)TipoEstadoEnum.SolicitudMantenimiento },
                new Estado { IdEstado = (int)EstadoSolicitudMantenimiento.Atendida, Nombre = "Atendida", TipoEstadoId = (int)TipoEstadoEnum.SolicitudMantenimiento }
            );

            //_____________________________________________________________________________________________________________________________________________
            var historialAcceso = modelBuilder.Entity<HistorialAcceso>();
            historialAcceso.HasKey(h => h.IdHistorialAcceso);

            historialAcceso.HasOne(h => h.Usuario)
                .WithMany(u => u.HistorialAccesos)
                .HasForeignKey(h => h.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);
            historialAcceso.Property(h => h.UsuarioId)
                .IsRequired();
            historialAcceso.Property(h => h.FechaIngraso)
                .HasDefaultValueSql("GETDATE()");
            historialAcceso.Property(h => h.DireccionIp)
                .HasMaxLength(50)
                .IsRequired();
            historialAcceso.Property(h => h.SistemaOperatico)
                .HasMaxLength(100);

            //_____________________________________________________________________________________________________________________________________________
            var mantenimiento = modelBuilder.Entity<Mantenimiento>();           
            mantenimiento.HasKey(ma => ma.IdMantenimiento);
            
            mantenimiento.HasOne(ma => ma.SolicitudMantenimiento)
                .WithMany(sm => sm.Mantenimientos)
                .HasForeignKey(ma => ma.SolicitudMantenimientoId)
                .OnDelete(DeleteBehavior.Restrict);
            mantenimiento.Property(ma => ma.SolicitudMantenimientoId)
                .IsRequired();           
            mantenimiento.HasOne(ma => ma.PersonalTecnico)
                .WithMany(us => us.MantenimientoTecnicos)
                .HasForeignKey(ma => ma.PersonalTecnicoId)
                .OnDelete(DeleteBehavior.Restrict);
            mantenimiento.Property(ma => ma.PersonalTecnicoId)
                .IsRequired();
            mantenimiento.HasOne(ma => ma.UsuarioRegistro)
                .WithMany(us => us.MantenimientoRegistros)
                .HasForeignKey(ma => ma.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            mantenimiento.Property(ma => ma.UsuarioRegistroId)
                .IsRequired();
            mantenimiento.HasOne(ma => ma.Estado)
                .WithMany(est => est.Mantenimientos)
                .HasForeignKey(ma => ma.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            mantenimiento.Property(ma => ma.EstadoId)
                .IsRequired();
            mantenimiento.Property(ma => ma.FechaInicioAtencion)
                .HasDefaultValueSql("GETDATE()");
            mantenimiento.Property(ma => ma.FechaCierre)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var marca = modelBuilder.Entity<Marca>();
            marca.HasKey(mc => mc.IdMarca);
            
            marca.HasOne(mc => mc.UsuarioRegistro)
                .WithMany(us => us.MarcaRegistros)
                .HasForeignKey(mc => mc.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            marca.Property(mc => mc.UsuarioRegistroId)
                .IsRequired();
            marca.HasOne(mc => mc.UsuarioActualizacion)
                .WithMany(us => us.MarcaActualizacion)
                .HasForeignKey(mc => mc.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);
            marca.HasOne(mc => mc.Estado)
                .WithMany(est => est.Marcas)
                .HasForeignKey(mc => mc.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            marca.Property(mc => mc.EstadoId)
                .IsRequired();
            marca.Property(mc => mc.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            marca.HasIndex(mc => mc.Nombre)
                .IsUnique();
            marca.Property(mc => mc.Descripcion)
                .HasMaxLength(300);           
            marca.Property(mc => mc.FechaCreacion)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var movimiento = modelBuilder.Entity<Traslado>();
            movimiento.HasKey(mo => mo.IdTraslado);
            
            movimiento.HasOne(mo => mo.UsuarioRegistro)
                .WithMany(us => us.MovimientoRegistros)
                .HasForeignKey(mo => mo.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            movimiento.Property(mo => mo.UsuarioRegistroId)
                .IsRequired();           
            movimiento.Property(mo => mo.RazonTraslado)
                .HasMaxLength(300)
                .IsRequired();
            movimiento.Property(mo => mo.DocAutorizacion)
               .IsRequired();
            movimiento.HasOne(mo => mo.AutorizadoPor)
                .WithMany(mo => mo.Traslaados)
                .HasForeignKey(mo => mo.AutorizadoPorId)
                .OnDelete(DeleteBehavior.Restrict);
            movimiento.Property(mo => mo.AutorizadoPorId)
                .IsRequired();
            movimiento.Property(mo => mo.NoDocAutorizacion)
                .IsRequired();
            movimiento.HasIndex(mo => mo.NoDocAutorizacion)
                .IsUnique();
            movimiento.Property(mo => mo.FechaTraslado)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________           
            var permiso = modelBuilder.Entity<Permiso>();           
            permiso.HasKey(pr => pr.IdPermiso);

            permiso.Property(pr => pr.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            permiso.HasIndex(pr => pr.Nombre)
                .IsUnique();
            permiso.Property(pr => pr.Descripcion)
                .HasMaxLength(50);

            permiso.HasData(
                new Permiso { IdPermiso = 1, Nombre = "Gestionar Usuarios", Descripcion = "Crear, guardar, actualizar, eliminar usuarios" },
                new Permiso { IdPermiso = 2, Nombre = "Gestionar Roles", Descripcion = "Asiganar roles a susuarios"},
                new Permiso { IdPermiso = 3, Nombre ="Gestionar Activos", Descripcion = "Crear, guardar, actualizar, eliminar activos" },
                new Permiso { IdPermiso = 4, Nombre = "Gestionar Catgorias", Descripcion = "Crear, guardar, actualizar, eliminar categorias" },
                new Permiso { IdPermiso = 5, Nombre = "Gestionar Marcas", Descripcion = "Crear, guardar, actualizar, eliminar marcas" },
                new Permiso { IdPermiso = 6, Nombre = "Gestionar Ubicaciones", Descripcion = "Crear, guardar, actualizar elimiar ubicaciones" },
                new Permiso { IdPermiso = 7, Nombre = "Registrar Entradas", Descripcion = "Registrar entrada de activos"},
                new Permiso { IdPermiso = 8, Nombre = "Registrar Salidad", Descripcion = "Registrar Salida de Activos"},
                new Permiso { IdPermiso = 9, Nombre = "Gestionar Prestamos", Descripcion = "Resgistrar prestamoss y devoluciones"},
                new Permiso { IdPermiso = 10, Nombre = "Gestionar Traslados", Descripcion = "Registar y gestionar traslado de activos"},
                new Permiso { IdPermiso = 11, Nombre = "Gestionar Solicitud de Mantenimiento", Descripcion = "Registrar solicitudes de mantenimiento" },
                new Permiso { IdPermiso = 12, Nombre ="Gestionar Mantenimientos", Descripcion = "Registrar procesos de mantenimientos"},
                new Permiso { IdPermiso = 13, Nombre = "Ver Reportes", Descripcion = "Ver, generar, consultar reportes"},
                new Permiso { IdPermiso = 14, Nombre = "Gestionar Configuraciones", Descripcion = "Realizar ajustes dentro del sistema"}
                );

            //_____________________________________________________________________________________________________________________________________________
            var personal = modelBuilder.Entity<Personal>();           
            personal.HasKey (ps => ps.IdPersonal);
            
            personal.HasOne(ps => ps.Puesto)
                .WithMany(pu => pu.Personales)
                .HasForeignKey(ps => ps.PuestoId)
                .OnDelete(DeleteBehavior.Restrict);
            personal.Property(ps => ps.PuestoId)
                .IsRequired();            
            personal.HasOne(ps => ps.Estado)
                .WithMany(est => est.Personales)
                .HasForeignKey(ps => ps.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            personal.Property(ps => ps.EstadoId)
                .IsRequired();           
            personal.HasOne(ps => ps.UsuarioRegistro)
                .WithMany(us => us.PersonalRegistros)
                .HasForeignKey(ps => ps.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            personal.Property(ps => ps.UsuarioRegistroId)
                .IsRequired();            
            personal.HasOne(ps => ps.UsuarioActualizacion)
                .WithMany(us => us.PersonalActualizacion)
                .HasForeignKey(ps => ps.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);
            personal.Property(ps => ps.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            personal.Property(ps => ps.Apellido)
                .HasMaxLength(50)
                .IsRequired();
            personal.Property(ps => ps.Cedula)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(false);
            personal.HasIndex(ps => ps.Cedula)
                .IsUnique();
            personal.Property(ps => ps.CodPersonal)
                .HasMaxLength(10)
                .IsRequired()
                .IsUnicode(false);
            personal.HasIndex(ps => ps.CodPersonal)
                .IsUnique();
            personal.Property(ps => ps.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            personal.HasIndex(ps => ps.Telefono)
                .IsUnique();
            personal.Property(ps => ps.Correo)
                .HasMaxLength(100);
            personal.HasIndex(ps => ps.Correo)
                .IsUnique();
            personal.Property(ps => ps.FechaCreacion)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var prestamo = modelBuilder.Entity<Prestamo>();           
            prestamo.HasKey(pt => pt.IdPrestamo);
            
            prestamo.HasOne(pt => pt.Estado)
                .WithMany(est => est.Prestamos)
                .HasForeignKey(pt => pt.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            prestamo.Property(pt => pt.EstadoId)
                .IsRequired();            
            prestamo.HasOne(pt => pt.PersonalSolicitante)
                .WithMany(us => us.Prestamos)
                .HasForeignKey(pt => pt.PersonalSolicitanteId)
                .OnDelete(DeleteBehavior.Restrict);
            prestamo.Property(pt => pt.PersonalSolicitanteId)
                .IsRequired();
            prestamo.HasOne(pt => pt.UsuarioRegistro)
                .WithMany(us => us.PrestamoRegistros)
                .HasForeignKey(pt => pt.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            prestamo.Property(pt => pt.UsuarioRegistroId)
                .IsRequired();
            prestamo.Property(pt => pt.FechaPrestamo)
                .HasDefaultValueSql("GETDATE()");          
            prestamo.Property(pt => pt.FechaLimite)
                .HasDefaultValueSql("GETDATE()");
            //_____________________________________________________________________________________________________________________________________________
            var proveedor = modelBuilder.Entity<Proveedor>();
            proveedor.HasKey(p => p.IdProveedor);

            proveedor.Property(p => p.RNC)
                .HasMaxLength(20);
            proveedor.HasIndex(p => p.RNC)
                .IsUnique();
            proveedor.Property(p => p.Nombre)
                .HasMaxLength(100)
                .IsRequired();
            proveedor.HasIndex(p => p.Nombre)
                .IsUnique();
            proveedor.Property(p => p.Telefono)
                .HasMaxLength(20)
                .IsRequired();
            proveedor.Property(p => p.Correo)
                .HasMaxLength(100);
            proveedor.Property(p => p.Direccion)
                .HasMaxLength(200);
            proveedor.Property(p => p.PersonalContacto)
                .HasMaxLength(100);
            proveedor.Property(p => p.TelefonoContacto)
                .HasMaxLength(20);
            proveedor.Property(p => p.FechaRegistro)
                .HasDefaultValueSql("GETDATE()");
            proveedor.HasOne(m => m.Estado)
                .WithMany(a => a.Proveedores)
                .HasForeignKey(m => m.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            proveedor.Property(m => m.EstadoId)
                .IsRequired();
            proveedor.HasOne(m => m.UsuarioRegistro)
                .WithMany(a => a.ProveedorRegistros)
                .HasForeignKey(m => m.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            proveedor.Property(m => m.UsuarioRegistroId)
                .IsRequired();
            proveedor.HasOne(m => m.UsuarioActualizacion)
                .WithMany(a => a.ProveedorActualizacions)
                .HasForeignKey(m => m.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);

            //_____________________________________________________________________________________________________________________________________________
            var puesto = modelBuilder.Entity<Puesto>();
           puesto.HasKey(pu => pu.IdPuesto);
          
            puesto.HasOne(pu => pu.UsuarioRegistro)
                .WithMany(us => us.PuestoRegistros)
                .HasForeignKey(pu => pu.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            puesto.Property(pu => pu.UsuarioRegistroId)
                .IsRequired();           
            puesto.HasOne(pu => pu.UsuarioActualizacion)
                .WithMany(us => us.PuestoActualizacion)
                .HasForeignKey(pu => pu.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);
            puesto.HasOne(pu => pu.Estado)
                .WithMany(us => us.Puestos)
                .HasForeignKey(pu => pu.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            puesto.Property(pu => pu.EstadoId)
                .IsRequired();
            puesto.Property(pu => pu.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            puesto.HasIndex(pu => pu.Nombre)
                .IsUnique();
            puesto.Property(pu => pu.Descripcion)
                .HasMaxLength(300);
            puesto.Property(pu => pu.FechaCreacion)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var rol = modelBuilder.Entity<Rol>();
            rol.HasKey(r => r.IdRol);

            rol.Property(r => r.Nombre)
               .HasMaxLength(50)
               .IsRequired();
            rol.HasIndex(r => r.Nombre)
                .IsUnique();
            rol.Property(r => r.Descripcion)
                .HasMaxLength(300);

            rol.HasData(
                new Rol { IdRol = (int)EnumRol.Administrador, Nombre = "Administrador", Descripcion = "Puede realizar cualquier accion dentro del sistema" },
                new Rol { IdRol = (int)EnumRol.EncargadoGeneralActivos, Nombre = "Encargado General de Activos", Descripcion = "Puede realizar todas la acciones relaciondas a la gestion y control de activos" },
                new Rol { IdRol = (int)EnumRol.EncargadoTraslados, Nombre = "Encargado de Traslados", Descripcion = "Puede gestrionar los traslados de activos" },
                new Rol { IdRol = (int)EnumRol.EncargadoMantenimiento, Nombre = "Encargado de Mantenimiento", Descripcion = "Puede destionar solicitudes y mantenimientos " },
                new Rol { IdRol = (int)EnumRol.EncargadoConsulta, Nombre = "Encargado de Consultas y reportes", Descripcion = "Solo puede consultar informacion y reportes" }
            );

            //_____________________________________________________________________________________________________________________________________________
            var rolpermiso = modelBuilder.Entity<RolPermiso>();            
            rolpermiso.HasKey(rp => rp.IdRolPermiso);
            
            rolpermiso.HasOne(rp => rp.Permiso)
                .WithMany(pr => pr.RolPermisos)
                .HasForeignKey(rp => rp.PermisoId)
                .OnDelete(DeleteBehavior.Restrict);
            rolpermiso.Property(rp => rp.PermisoId)
                .IsRequired();            
            rolpermiso.HasOne(rp => rp.Rol)
                .WithMany(r => r.RolPermisos)
                .HasForeignKey(rp => rp.RolId)
                .OnDelete(DeleteBehavior.Restrict);
            rolpermiso.Property(rp => rp.RolId)
                .IsRequired();
            rolpermiso.HasIndex(rp => new { rp.RolId, rp.PermisoId })
                .IsUnique();

            rolpermiso.HasData(
                new RolPermiso { IdRolPermiso = 1, RolId = 1, PermisoId = 1 },
                new RolPermiso { IdRolPermiso = 2, RolId = 1, PermisoId = 2 },
                new RolPermiso { IdRolPermiso = 3, RolId = 1, PermisoId = 3 },
                new RolPermiso { IdRolPermiso = 4, RolId = 1, PermisoId = 4 },
                new RolPermiso { IdRolPermiso = 5, RolId = 1, PermisoId = 5 },
                new RolPermiso { IdRolPermiso = 6, RolId = 1, PermisoId = 6 },
                new RolPermiso { IdRolPermiso = 7, RolId = 1, PermisoId = 7 },
                new RolPermiso { IdRolPermiso = 8, RolId = 1, PermisoId = 8 },
                new RolPermiso { IdRolPermiso = 9, RolId = 1, PermisoId = 9 },
                new RolPermiso { IdRolPermiso = 10, RolId = 1, PermisoId = 10 },
                new RolPermiso { IdRolPermiso = 11, RolId = 1, PermisoId = 11 },
                new RolPermiso { IdRolPermiso = 12, RolId = 1, PermisoId = 12 },
                new RolPermiso { IdRolPermiso = 13, RolId = 1, PermisoId = 13 },
                new RolPermiso { IdRolPermiso = 14, RolId = 1, PermisoId = 14 },

                new RolPermiso { IdRolPermiso = 15, RolId = 2, PermisoId = 3 },
                new RolPermiso { IdRolPermiso = 16, RolId = 2, PermisoId = 4 },
                new RolPermiso { IdRolPermiso = 17, RolId = 2, PermisoId = 5 },
                new RolPermiso { IdRolPermiso = 18, RolId = 2, PermisoId = 6 },
                new RolPermiso { IdRolPermiso = 19, RolId = 2, PermisoId = 7 },
                new RolPermiso { IdRolPermiso = 20, RolId = 2, PermisoId = 8 },
                new RolPermiso { IdRolPermiso = 21, RolId = 2, PermisoId = 9 },
                new RolPermiso { IdRolPermiso = 22, RolId = 2, PermisoId = 10 },
                new RolPermiso { IdRolPermiso = 23, RolId = 2, PermisoId = 11 },
                new RolPermiso { IdRolPermiso = 24, RolId = 2, PermisoId = 12 },
                new RolPermiso { IdRolPermiso = 25, RolId = 2, PermisoId = 13 },

                new RolPermiso { IdRolPermiso = 26, RolId = 3, PermisoId = 10 },

                new RolPermiso { IdRolPermiso = 27, RolId = 4, PermisoId = 11 },
                new RolPermiso { IdRolPermiso = 28, RolId = 4, PermisoId = 12 },

                new RolPermiso { IdRolPermiso = 29, RolId = 5, PermisoId = 13 }
                );
            
            //_____________________________________________________________________________________________________________________________________________
            var salida = modelBuilder.Entity<Salida>();            
            salida.HasKey(sa => sa.IdSalida);

            salida.HasOne(sa => sa.UsuarioRegistro)
                .WithMany(us => us.SalidaRegistros)
                .HasForeignKey(sa => sa.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            salida.Property(sa => sa.UsuarioRegistroId)
                .IsRequired();
            salida.Property(sa => sa.NumSalida)
                .IsRequired();
            salida.HasIndex(sa => sa.NumSalida)
                .IsUnique();           
            salida.Property(sa => sa.FechaSalida)
                .HasDefaultValueSql("GETDATE()");
             salida.Property(sa => sa.RazonSalida)
                .HasMaxLength(300);

            //_____________________________________________________________________________________________________________________________________________
            var solicitudmantenimiento = modelBuilder.Entity<SolicitudMantenimiento>();            
            solicitudmantenimiento.HasKey(sm => sm.IdSolicitudMantenimiento);
            
            solicitudmantenimiento.HasOne(sm => sm.UsuarioRegistro)
                .WithMany(us => us.SolicitudMantenimientoRegistros)
                .HasForeignKey(sm => sm.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            solicitudmantenimiento.Property(sm => sm.UsuarioRegistroId)
                .IsRequired();           
            solicitudmantenimiento.HasOne(sm => sm.Estado)
                .WithMany(est => est.SolicitudMantenimientos)
                .HasForeignKey(sm => sm.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            solicitudmantenimiento.Property(sm => sm.EstadoId)
                .IsRequired();
            solicitudmantenimiento.Property(sm => sm.ObservacionGeneral)
                .HasMaxLength(300);
            solicitudmantenimiento.Property(sm => sm.FechaSolicitud)
                 .HasDefaultValueSql("GETDATE()");

            //__________________________________________________________________________________________________________________________________________
            var subCategoria = modelBuilder.Entity<SubCategoria>();
            subCategoria.HasKey(s => s.IdSubCategoria);

            subCategoria.HasOne(s => s.Categoria)
                .WithMany(c => c.SubCategorias)
                .HasForeignKey(s => s.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);
            subCategoria.Property(s => s.CategoriaId)
                .IsRequired();
            subCategoria.Property(s => s.Nombre)
                .HasMaxLength(80)
                .IsRequired();
            subCategoria.HasIndex(s => s.Nombre)
                .IsUnique();
            subCategoria.Property(s => s.Descripcion)
                .HasMaxLength(300);
            subCategoria.Property(s => s.VidaUtil)
                .IsRequired();
            subCategoria.Property(s => s.FechaCreacion)
                .HasDefaultValueSql("GETDATE()");
            subCategoria.HasOne(m => m.Estado)
                .WithMany(a => a.SubCategorias)
                .HasForeignKey(m => m.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            subCategoria.Property(m => m.EstadoId)
                .IsRequired();
            subCategoria.HasOne(m => m.UsuarioRegistro)
                .WithMany(a => a.SubCategoriaRegistros)
                .HasForeignKey(m => m.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            subCategoria.Property(m => m.UsuarioRegistroId)
                .IsRequired();
            subCategoria.HasOne(m => m.UsuarioActualizacion)
                .WithMany(a => a.SubCategoriaActualizacions)
                .HasForeignKey(m => m.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);

            //_____________________________________________________________________________________________________________________________________________
            var tipoestado = modelBuilder.Entity<TipoEstado>();           
            tipoestado.HasKey(te => te.IdTipoEstado);

            tipoestado.Property(te => te.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            tipoestado.HasIndex(te => te.Nombre)
                .IsUnique();
            tipoestado.HasData(
                new TipoEstado { IdTipoEstado = (int)TipoEstadoEnum.EstadoGenerico, Nombre = "Estado Generico" },
                new TipoEstado { IdTipoEstado = (int)TipoEstadoEnum.ActivoFisico, Nombre = "Activo Fisico" },
                new TipoEstado { IdTipoEstado = (int)TipoEstadoEnum.DetalleDevolucion, Nombre = "Detalle Devolucion" },
                new TipoEstado { IdTipoEstado = (int)TipoEstadoEnum.DetalleMantenimiento, Nombre = "Detalle Mantenimiento" },
                new TipoEstado { IdTipoEstado = (int)TipoEstadoEnum.Mantenimiento, Nombre = "Mantenimiento" },
                new TipoEstado { IdTipoEstado = (int)TipoEstadoEnum.Prestamo, Nombre = "Prestamo" },
                new TipoEstado { IdTipoEstado = (int)TipoEstadoEnum.SolicitudMantenimiento, Nombre = "Solicitud Mantenimiento" }
            );

            //_____________________________________________________________________________________________________________________________________________
            var ubicacion = modelBuilder.Entity<Ubicacion>();           
            ubicacion.HasKey(ub => ub.IdUbicacion);      
            
            ubicacion.HasOne(ub => ub.UsuarioRegistro)
                .WithMany(us => us.UbicacionRegistros)
                .HasForeignKey(ub => ub.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            ubicacion.Property(ub => ub.UsuarioRegistroId)
                .IsRequired();
            ubicacion.HasOne(ub => ub.Estado)
                .WithMany(us => us.Ubicaciones)
                .HasForeignKey(ub => ub.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            ubicacion.Property(ub => ub.EstadoId)
                .IsRequired();
            ubicacion.HasOne(ub => ub.Edificio)
                .WithMany(us => us.Ubicaciones)
                .HasForeignKey(ub => ub.EdificioId)
                .OnDelete(DeleteBehavior.Restrict);
            ubicacion.Property(ub => ub.EdificioId)
                .IsRequired();
            ubicacion.HasOne(ub => ub.UsuarioActualizacion)
                .WithMany(us => us.UbicacionActualizacion)
                .HasForeignKey(ub => ub.UsuarioActualizacionId)
                .OnDelete(DeleteBehavior.Restrict);           
            ubicacion.Property(ub => ub.Nombre)
                .HasMaxLength(50) 
                .IsRequired();
            ubicacion.Property(u => u.Piso)
                .IsRequired();
            ubicacion.HasIndex(ub => ub.Nombre)
                .IsUnique();
            ubicacion.Property(ub => ub.Descripcion)
                .HasMaxLength(300);           
            ubicacion.Property(ub => ub.FechaCreacion)
                .HasDefaultValueSql("GETDATE()");

            //_____________________________________________________________________________________________________________________________________________
            var usuario = modelBuilder.Entity<Usuario>();
            usuario.HasKey(us => us.IdUsuario);

            usuario.HasOne(us => us.Rol)
                .WithMany(r => r.Usuarios)
                .HasForeignKey(us => us.RolId)
                .OnDelete(DeleteBehavior.Restrict);
            usuario.Property(us => us.RolId)
                .IsRequired();
            usuario.HasOne(us => us.Estado)
                .WithMany(est => est.Usuarios)
                .HasForeignKey(us => us.EstadoId)
                .OnDelete(DeleteBehavior.Restrict);
            usuario.Property(us => us.EstadoId)
                .IsRequired();
            usuario.HasOne(us => us.UsuarioRegistro)
                .WithMany(us => us.UsuarioRegistros)
                .HasForeignKey(us => us.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.Restrict);
            usuario.Property(us => us.UsuarioRegistroId)
                .IsRequired();
            usuario.HasOne(us => us.UsuarioActualizacion)
               .WithMany(us => us.UsuarioActualizacions)
               .HasForeignKey(us => us.UsuarioActualizacionId)
               .OnDelete(DeleteBehavior.Restrict);
            usuario.Property(us => us.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            usuario.Property(us => us.Apellido)
                .HasMaxLength(50)
                .IsRequired();
            usuario.Property(us => us.Cedula)
                .HasMaxLength(20)
                .IsUnicode(false);
            usuario.HasIndex( us => us.Cedula)
               .IsUnique();
            usuario.Property(us => us.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            usuario.HasIndex(us => us.Telefono)
               .IsUnique();
            usuario.Property(us => us.Correo)
                .HasMaxLength(100);
            usuario.HasIndex(us => us.Correo)
               .IsUnique();
            usuario.Property(us => us.NombreUsuario)
                .HasMaxLength(10)
                .IsUnicode(false);
            usuario.HasIndex(us => us.NombreUsuario)
               .IsUnique();
            usuario.Property(us => us.ClaveHash)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsRequired();
            usuario.HasIndex(us => us.ClaveHash)
               .IsUnique(); 
            usuario.Property(us => us.FechaCreacion)
                .HasDefaultValueSql("GETDATE()");

            usuario.HasData(
                new Usuario
                {
                    IdUsuario = 1,
                    NombreUsuario = "AdminDEV",
                    ClaveHash = "8D55C34FBBDDDA456D134D51514CC75B7EEE6C09D09079BFA8C2E7846F54C738",
                    Nombre = "Rutchy",
                    Apellido ="Herne",
                    Cedula = "402-0000000-0",
                    Telefono = "(809) 0000-000",
                    Correo = "hernedev@gmail.com",
                    RolId = (int)EnumRol.Administrador,
                    EstadoId = (int)EstadoGenerico.Activo,
                    UsuarioRegistroId = 1,
                    FechaCreacion = new DateTime(2026, 7, 2)
                }

                );
        }
    }
}