using Microsoft.EntityFrameworkCore;
using SGICE.Entidades;
using SGICE.Entidades.Enums;

namespace SGICE.Datos;

/// <summary>
/// Contexto de Entity Framework Core para el sistema SGICE.
/// Conecta con la base de datos SQL Server Express (PSGestionActivosDB).
/// </summary>
public class AppDbContext : DbContext
{
    public const string CadenaConexionPredeterminada = 
        "Server=localhost;Database=PSGestionActivosDB;Integrated Security=True;TrustServerCertificate=True;";

    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Activo> Activo { get; set; } = null!;
    public DbSet<ActivoFisico> ActivoFisico { get; set; } = null!;
    public DbSet<Auditoria> Auditoria { get; set; } = null!;
    public DbSet<Backup> backup { get; set; } = null!;
    public DbSet<Categoria> Categoria { get; set; } = null!;
    public DbSet<Devolucion> Devolucion { get; set; } = null!;
    public DbSet<DetalleDevolucion> DetalleDevolucion { get; set; } = null!;
    public DbSet<DetalleEntrada> DetalleEntrada { get; set; } = null!;
    public DbSet<DetalleMantenimiento> DetalleMantenimiento { get; set; } = null!;
    public DbSet<DetalleTraslado> DetalleTraslado { get; set; } = null!;
    public DbSet<DetallePrestamo> DetallePrestamo { get; set; } = null!;
    public DbSet<DetalleSalida> DetalleSalida { get; set; } = null!;
    public DbSet<DetalleSolicitudMantenimiento> DetalleSolicitudMantenimiento { get; set; } = null!;
    public DbSet<Director> Director { get; set; } = null!;
    public DbSet<Edificio> Edificio { get; set; } = null!;
    public DbSet<Entrada> Entrada { get; set; } = null!;
    public DbSet<CentroEducativo> Escuela { get; set; } = null!;
    public DbSet<Estado> Estado { get; set; } = null!;
    public DbSet<HistorialAcceso> HistorialAcceso { get; set; } = null!;
    public DbSet<Mantenimiento> Mantenimiento { get; set; } = null!;
    public DbSet<Marca> Marca { get; set; } = null!;
    public DbSet<Traslado> Traslado { get; set; } = null!;
    public DbSet<Permiso> Permiso { get; set; } = null!;
    public DbSet<Personal> Personal { get; set; } = null!;
    public DbSet<Prestamo> Prestamo { get; set; } = null!;
    public DbSet<Proveedor> Proveedor { get; set; } = null!;
    public DbSet<Puesto> Puesto { get; set; } = null!;
    public DbSet<Rol> Rol { get; set; } = null!;
    public DbSet<RolPermiso> RolPermiso { get; set; } = null!;
    public DbSet<Salida> Salida { get; set; } = null!;
    public DbSet<SolicitudMantenimiento> SolicitudMantenimiento { get; set; } = null!;
    public DbSet<SubCategoria> SubCategoria { get; set; } = null!;
    public DbSet<TipoEstado> TipoEstado { get; set; } = null!;
    public DbSet<Ubicacion> Ubicacion { get; set; } = null!;
    public DbSet<Usuario> Usuario { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(CadenaConexionPredeterminada, sqlOptions =>
            {
                sqlOptions.CommandTimeout(60);
                sqlOptions.EnableRetryOnFailure(3);
            });
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 1. Activo
        var activo = modelBuilder.Entity<Activo>();
        activo.ToTable("Activo");
        activo.HasKey(a => a.Id);
        activo.Property(a => a.Id).HasColumnName("IdActivo");
        activo.Property(a => a.Nombre).HasMaxLength(50).IsRequired();
        activo.Property(a => a.Descripcion).HasMaxLength(350);
        activo.Property(a => a.SubCategoriaId).IsRequired();
        activo.Property(a => a.MarcaId).IsRequired();
        activo.Property(a => a.ProveedorId).IsRequired();
        activo.Property(a => a.EstadoId).IsRequired();
        activo.Property(a => a.PersonalEncargadoId).IsRequired();
        activo.Property(a => a.UsuarioRegistroId).IsRequired();
        activo.Property(a => a.FechaRegistro).HasDefaultValueSql("GETDATE()");

        activo.HasOne(a => a.SubCategoria)
            .WithMany(c => c.Activos)
            .HasForeignKey(a => a.SubCategoriaId)
            .OnDelete(DeleteBehavior.Restrict);

        activo.HasOne(a => a.Marca)
            .WithMany(mc => mc.Activos)
            .HasForeignKey(a => a.MarcaId)
            .OnDelete(DeleteBehavior.Restrict);

        activo.HasOne(a => a.Estado)
            .WithMany(est => est.Activos)
            .HasForeignKey(a => a.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        activo.HasOne(a => a.PersonalEncargado)
            .WithMany(us => us.PersonalEncargados)
            .HasForeignKey(a => a.PersonalEncargadoId)
            .OnDelete(DeleteBehavior.Restrict);

        activo.HasOne(a => a.Proveedor)
            .WithMany(us => us.Activos)
            .HasForeignKey(a => a.ProveedorId)
            .OnDelete(DeleteBehavior.Restrict);

        activo.HasOne(a => a.UsuarioRegistro)
            .WithMany(us => us.ActivoRegistros)
            .HasForeignKey(a => a.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        activo.HasOne(a => a.UsuarioActualizacion)
            .WithMany(us => us.ActivoActualizacion)
            .HasForeignKey(a => a.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        // 2. ActivoFisico
        var activoFisico = modelBuilder.Entity<ActivoFisico>();
        activoFisico.ToTable("ActivoFisico");
        activoFisico.HasKey(af => af.Id);
        activoFisico.Property(af => af.Id).HasColumnName("IdActivoFisico");
        activoFisico.Property(af => af.CodEtiquetaQR).HasMaxLength(10).IsUnicode(false).IsRequired();
        activoFisico.HasIndex(af => af.CodEtiquetaQR).IsUnique();
        activoFisico.Property(af => af.NumSerie).HasMaxLength(100);
        activoFisico.Property(af => af.ActivoId).IsRequired();
        activoFisico.Property(af => af.UbicacionId).IsRequired();
        activoFisico.Property(af => af.EstadoId).IsRequired();
        activoFisico.Property(af => af.DetalleEntradaId).IsRequired();
        activoFisico.Property(af => af.UsuarioRegistroId).IsRequired();
        activoFisico.Property(af => af.FechaRegistro).HasDefaultValueSql("GETDATE()");

        activoFisico.HasOne(af => af.Activo)
            .WithMany(a => a.ActivosFisicos)
            .HasForeignKey(af => af.ActivoId)
            .OnDelete(DeleteBehavior.Restrict);

        activoFisico.HasOne(af => af.Ubicacion)
            .WithMany(ub => ub.ActivosFisicos)
            .HasForeignKey(af => af.UbicacionId)
            .OnDelete(DeleteBehavior.Restrict);

        activoFisico.HasOne(af => af.Estado)
            .WithMany(est => est.ActivosFisicos)
            .HasForeignKey(af => af.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        activoFisico.HasOne(af => af.DetalleEntrada)
            .WithMany(de => de.ActivosFisicos)
            .HasForeignKey(af => af.DetalleEntradaId)
            .OnDelete(DeleteBehavior.Restrict);

        activoFisico.HasOne(af => af.UsuarioRegistro)
            .WithMany(us => us.ActivoFisicoRegistros)
            .HasForeignKey(af => af.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        // 3. Auditoria
        var auditoria = modelBuilder.Entity<Auditoria>();
        auditoria.ToTable("Auditoria");
        auditoria.HasKey(au => au.Id);
        auditoria.Property(au => au.Id).HasColumnName("IdAuditoria");
        auditoria.Ignore(au => au.EstadoId);
        auditoria.Ignore(au => au.Estado);
        auditoria.Property(au => au.NombreTabla).IsRequired().HasMaxLength(100);
        auditoria.Property(au => au.RegistroId).IsRequired();
        auditoria.Property(au => au.Accion).IsRequired();
        auditoria.Property(au => au.ValoresAntiguos).IsRequired(false);
        auditoria.Property(au => au.ValoresNuevos).IsRequired(false);
        auditoria.Property(au => au.FechaRegistro).HasDefaultValueSql("GETDATE()");

        auditoria.HasOne(au => au.UsuarioAuditoria)
            .WithMany(u => u.Auditorias)
            .HasForeignKey(au => au.UsuarioAuditoriaId)
            .OnDelete(DeleteBehavior.Restrict);

        auditoria.HasOne(au => au.Director)
            .WithMany(di => di.Auditorias)
            .HasForeignKey(au => au.DirectorId)
            .OnDelete(DeleteBehavior.Restrict);

        // 4. Backup
        var backup = modelBuilder.Entity<Backup>();
        backup.ToTable("backup");
        backup.HasKey(b => b.Id);
        backup.Property(b => b.Id).HasColumnName("IdBackup");
        backup.Property(b => b.FechaRegistro).HasColumnName("FechaCreacion").HasDefaultValueSql("GETDATE()");
        backup.Ignore(b => b.EstadoId);
        backup.Ignore(b => b.Estado);
        backup.Property(b => b.Nombre).HasMaxLength(50).IsRequired();
        backup.HasIndex(b => b.Nombre).IsUnique();
        backup.Property(b => b.RutaBackup).HasMaxLength(300).IsRequired();
        backup.Property(b => b.UsuarioRegistroId).IsRequired();

        backup.HasOne(b => b.UsuarioRegistro)
            .WithMany(us => us.BackupRegistros)
            .HasForeignKey(b => b.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        // 5. Categoria
        var categoria = modelBuilder.Entity<Categoria>();
        categoria.ToTable("Categoria");
        categoria.HasKey(c => c.Id);
        categoria.Property(c => c.Id).HasColumnName("IdCategoria");
        categoria.Property(c => c.Nombre).HasMaxLength(50).IsRequired();
        categoria.HasIndex(c => c.Nombre).IsUnique();
        categoria.Property(c => c.VidaUtil).IsRequired();
        categoria.Property(c => c.Descripcion).HasMaxLength(300);
        categoria.Property(c => c.EstadoId).IsRequired();
        categoria.Property(c => c.UsuarioRegistroId).IsRequired();
        categoria.Property(c => c.FechaRegistro).HasDefaultValueSql("GETDATE()");

        categoria.HasOne(c => c.UsuarioRegistro)
            .WithMany(us => us.CategoriaRegistros)
            .HasForeignKey(c => c.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        categoria.HasOne(c => c.UsuarioActualizacion)
            .WithMany(us => us.CategoriaActualizacions)
            .HasForeignKey(c => c.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        categoria.HasOne(c => c.Estado)
            .WithMany(est => est.Categorias)
            .HasForeignKey(c => c.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 6. CentroEducativo (Escuela)
        var centroeducativo = modelBuilder.Entity<CentroEducativo>();
        centroeducativo.ToTable("Escuela");
        centroeducativo.HasKey(es => es.Id);
        centroeducativo.Property(es => es.Id).HasColumnName("IdCentroEducativo");
        centroeducativo.Property(es => es.FechaRegistro).HasColumnName("FechaCreacion").HasDefaultValueSql("GETDATE()");
        centroeducativo.Ignore(es => es.EstadoId);
        centroeducativo.Ignore(es => es.Estado);
        centroeducativo.Property(ce => ce.Nombre).HasMaxLength(100).IsRequired();
        centroeducativo.HasIndex(es => es.Nombre).IsUnique();
        centroeducativo.Property(ce => ce.CodCentro).HasMaxLength(50).IsRequired();
        centroeducativo.HasIndex(es => es.CodCentro).IsUnique();
        centroeducativo.Property(ce => ce.Telefono).HasMaxLength(20).IsRequired();
        centroeducativo.HasIndex(es => es.Telefono).IsUnique();
        centroeducativo.Property(ce => ce.Correo).HasMaxLength(100);
        centroeducativo.HasIndex(es => es.Correo).IsUnique();
        centroeducativo.Property(ce => ce.Direccion).HasMaxLength(200).IsRequired();
        centroeducativo.HasIndex(es => es.Direccion).IsUnique();
        centroeducativo.Property(ce => ce.Jornada).HasMaxLength(50);
        centroeducativo.Property(ce => ce.Modalidad).HasMaxLength(50);
        centroeducativo.Property(ce => ce.DistritoEducativo).HasMaxLength(25).IsRequired();
        centroeducativo.Property(ce => ce.RegionalEducativo).HasMaxLength(25).IsRequired();
        centroeducativo.Property(ce => ce.DirectorId).IsRequired();
        centroeducativo.Property(ce => ce.UsuarioRegistroId).IsRequired();

        centroeducativo.HasOne(ce => ce.UsuarioRegistro)
            .WithMany(us => us.EscuelaRegistro)
            .HasForeignKey(ce => ce.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        centroeducativo.HasOne(ce => ce.Director)
            .WithMany(di => di.CentrosEducativos)
            .HasForeignKey(ce => ce.DirectorId)
            .OnDelete(DeleteBehavior.Restrict);

        centroeducativo.HasOne(ce => ce.UsuarioActualizacion)
            .WithMany(us => us.EscuelaActualizacion)
            .HasForeignKey(ce => ce.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        // 7. DetalleDevolucion
        var detalledevolucion = modelBuilder.Entity<DetalleDevolucion>();
        detalledevolucion.ToTable("DetalleDevolucion");
        detalledevolucion.HasKey(dd => dd.Id);
        detalledevolucion.Property(dd => dd.Id).HasColumnName("IdDetalleDevolucion");
        detalledevolucion.Ignore(dd => dd.EstadoId);
        detalledevolucion.Ignore(dd => dd.Estado);
        detalledevolucion.Ignore(dd => dd.FechaRegistro);
        detalledevolucion.Property(dd => dd.Obervacion).HasMaxLength(300);

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

        // 8. DetalleEntrada
        var detalleentrada = modelBuilder.Entity<DetalleEntrada>();
        detalleentrada.ToTable("DetalleEntrada");
        detalleentrada.HasKey(de => de.Id);
        detalleentrada.Property(de => de.Id).HasColumnName("IdDetalleEntrada");
        detalleentrada.Ignore(de => de.EstadoId);
        detalleentrada.Ignore(de => de.Estado);
        detalleentrada.Ignore(de => de.FechaRegistro);
        detalleentrada.Property(de => de.EntradaId).IsRequired();
        detalleentrada.Property(de => de.ActivoId).IsRequired();
        detalleentrada.Property(de => de.Cantidad).IsRequired();

        detalleentrada.HasOne(de => de.Entrada)
            .WithMany(et => et.DetalleEntradas)
            .HasForeignKey(de => de.EntradaId)
            .OnDelete(DeleteBehavior.Restrict);

        detalleentrada.HasOne(de => de.Activo)
            .WithMany(a => a.DetalleEntradas)
            .HasForeignKey(de => de.ActivoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 9. DetalleMantenimiento
        var detallemantenimiento = modelBuilder.Entity<DetalleMantenimiento>();
        detallemantenimiento.ToTable("DetalleMantenimiento");
        detallemantenimiento.HasKey(dma => dma.Id);
        detallemantenimiento.Property(dma => dma.Id).HasColumnName("IdDetalleMantenimiento");
        detallemantenimiento.Ignore(dma => dma.FechaRegistro);
        detallemantenimiento.Property(dma => dma.MantenimientoId).IsRequired();
        detallemantenimiento.Property(dma => dma.ActivoFisicoId).IsRequired();
        detallemantenimiento.Property(dma => dma.EstadoId).IsRequired();
        detallemantenimiento.Property(dma => dma.Solucion).HasMaxLength(300);

        detallemantenimiento.HasOne(dma => dma.Mantenimiento)
            .WithMany(ma => ma.DetalleMantenimientos)
            .HasForeignKey(dma => dma.MantenimientoId)
            .OnDelete(DeleteBehavior.Restrict);

        detallemantenimiento.HasOne(dma => dma.ActivoFisico)
            .WithMany(af => af.DetalleMantenimientos)
            .HasForeignKey(dma => dma.ActivoFisicoId)
            .OnDelete(DeleteBehavior.Restrict);

        detallemantenimiento.HasOne(dma => dma.Estado)
            .WithMany(est => est.DetalleMantenimientos)
            .HasForeignKey(dma => dma.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 10. DetalleTraslado (DetalleMovimiento)
        var detallemovimiento = modelBuilder.Entity<DetalleTraslado>();
        detallemovimiento.ToTable("DetalleTraslado");
        detallemovimiento.HasKey(dmo => dmo.Id);
        detallemovimiento.Property(dmo => dmo.Id).HasColumnName("IdDetalleMovimiento");
        detallemovimiento.Ignore(dmo => dmo.EstadoId);
        detallemovimiento.Ignore(dmo => dmo.Estado);
        detallemovimiento.Ignore(dmo => dmo.FechaRegistro);
        detallemovimiento.Property(dmo => dmo.TrasladoId).IsRequired();
        detallemovimiento.Property(dmo => dmo.ActivoFisicoId).IsRequired();
        detallemovimiento.Property(dmo => dmo.UbicacionActualId).IsRequired();
        detallemovimiento.Property(dmo => dmo.UbicacionFinalId).IsRequired();

        detallemovimiento.HasOne(dmo => dmo.Traslado)
            .WithMany(mo => mo.DetalleTraslados)
            .HasForeignKey(dmo => dmo.TrasladoId)
            .OnDelete(DeleteBehavior.Restrict);

        detallemovimiento.HasOne(dmo => dmo.ActivoFisico)
            .WithMany(af => af.DetalleMovimientos)
            .HasForeignKey(dmo => dmo.ActivoFisicoId)
            .OnDelete(DeleteBehavior.Restrict);

        detallemovimiento.HasOne(mo => mo.UbicacionActual)
            .WithMany(ub => ub.DetalleUbicacionActual)
            .HasForeignKey(mo => mo.UbicacionActualId)
            .OnDelete(DeleteBehavior.Restrict);

        detallemovimiento.HasOne(mo => mo.UbicacionFinal)
            .WithMany(ub => ub.DetalleUbicacionFinal)
            .HasForeignKey(mo => mo.UbicacionFinalId)
            .OnDelete(DeleteBehavior.Restrict);

        // 11. Devolucion
        var devolucion = modelBuilder.Entity<Devolucion>();
        devolucion.ToTable("Devolucion");
        devolucion.HasKey(dv => dv.Id);
        devolucion.Property(dv => dv.Id).HasColumnName("IdDevolucion");
        devolucion.Property(dv => dv.FechaRegistro).HasColumnName("FechaDevolucion").HasDefaultValueSql("GETDATE()");
        devolucion.Ignore(dv => dv.EstadoId);
        devolucion.Ignore(dv => dv.Estado);
        devolucion.Property(dv => dv.ObervacioneGeneral).HasMaxLength(300);

        devolucion.HasOne(dv => dv.Prestamo)
            .WithMany(pt => pt.Devoluciones)
            .HasForeignKey(dv => dv.PrestamoId)
            .OnDelete(DeleteBehavior.Restrict);

        devolucion.HasOne(dv => dv.UsuarioResgistro)
            .WithMany(us => us.DevolucionRegistros)
            .HasForeignKey(dv => dv.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        // 12. DetallePrestamo
        var detalleprestamo = modelBuilder.Entity<DetallePrestamo>();
        detalleprestamo.ToTable("DetallePrestamo");
        detalleprestamo.HasKey(dp => dp.Id);
        detalleprestamo.Property(dp => dp.Id).HasColumnName("IdDetallePrestamo");
        detalleprestamo.Ignore(dp => dp.EstadoId);
        detalleprestamo.Ignore(dp => dp.Estado);
        detalleprestamo.Ignore(dp => dp.FechaRegistro);
        detalleprestamo.Property(dp => dp.PrestamoId).IsRequired();
        detalleprestamo.Property(dp => dp.ActivoFisicoId).IsRequired();

        detalleprestamo.HasOne(dp => dp.Prestamo)
            .WithMany(pr => pr.DetallePrestamos)
            .HasForeignKey(dp => dp.PrestamoId)
            .OnDelete(DeleteBehavior.Restrict);

        detalleprestamo.HasOne(dp => dp.ActivoFisico)
            .WithMany(af => af.DetallePrestamos)
            .HasForeignKey(dp => dp.ActivoFisicoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 13. DetalleSalida
        var detallesalida = modelBuilder.Entity<DetalleSalida>();
        detallesalida.ToTable("DetalleSalida");
        detallesalida.HasKey(ds => ds.Id);
        detallesalida.Property(ds => ds.Id).HasColumnName("IdDetalleSalida");
        detallesalida.Ignore(ds => ds.EstadoId);
        detallesalida.Ignore(ds => ds.Estado);
        detallesalida.Ignore(ds => ds.FechaRegistro);
        detallesalida.Property(ds => ds.SalidaId).IsRequired();
        detallesalida.Property(ds => ds.ActivoFisicoId).IsRequired();

        detallesalida.HasOne(ds => ds.Salida)
            .WithMany(sa => sa.DetalleSalidas)
            .HasForeignKey(ds => ds.SalidaId)
            .OnDelete(DeleteBehavior.Restrict);

        detallesalida.HasOne(ds => ds.ActivoFisico)
            .WithMany(af => af.DetalleSalidas)
            .HasForeignKey(ds => ds.ActivoFisicoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 14. DetalleSolicitudMantenimiento
        var detallesolicitudmantenimiento = modelBuilder.Entity<DetalleSolicitudMantenimiento>();
        detallesolicitudmantenimiento.ToTable("DetalleSolicitudMantenimiento");
        detallesolicitudmantenimiento.HasKey(dsm => dsm.Id);
        detallesolicitudmantenimiento.Property(dsm => dsm.Id).HasColumnName("IdDetalleSolicitudMantenimiento");
        detallesolicitudmantenimiento.Ignore(dsm => dsm.EstadoId);
        detallesolicitudmantenimiento.Ignore(dsm => dsm.Estado);
        detallesolicitudmantenimiento.Ignore(dsm => dsm.FechaRegistro);
        detallesolicitudmantenimiento.Property(dsm => dsm.SolicitudMantenimientoId).IsRequired();
        detallesolicitudmantenimiento.Property(dsm => dsm.ActivoFisicoId).IsRequired();
        detallesolicitudmantenimiento.Property(dsm => dsm.DescripcionProblema).HasMaxLength(300);

        detallesolicitudmantenimiento.HasOne(dsm => dsm.SolicitudMantenimiento)
            .WithMany(sm => sm.DetalleSolicitudMantenimientos)
            .HasForeignKey(dsm => dsm.SolicitudMantenimientoId)
            .OnDelete(DeleteBehavior.Restrict);

        detallesolicitudmantenimiento.HasOne(dsm => dsm.ActivoFisico)
            .WithMany(af => af.DetalleSolicitudMantenimientos)
            .HasForeignKey(dsm => dsm.ActivoFisicoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 15. Director
        var director = modelBuilder.Entity<Director>();
        director.ToTable("Director");
        director.HasKey(di => di.Id);
        director.Property(di => di.Id).HasColumnName("IdDirector");
        director.Property(d => d.Nombre).HasMaxLength(50).IsRequired();
        director.Property(d => d.Apellido).HasMaxLength(50).IsRequired();
        director.Property(d => d.Cedula).HasMaxLength(20).IsRequired();
        director.Property(d => d.Telefono).HasMaxLength(20).IsRequired();
        director.Property(d => d.Correo).HasMaxLength(100).IsRequired();
        director.Property(d => d.EstadoId).IsRequired();
        director.Property(d => d.FechaInicia).HasDefaultValueSql("GETDATE()");
        director.Property(d => d.UsuarioRegistroId).IsRequired();

        director.HasOne(d => d.UsuarioRegistro)
            .WithMany(us => us.DirectorRegistros)
            .HasForeignKey(d => d.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        director.HasOne(d => d.UsuarioActualizacion)
            .WithMany(us => us.DirectorActualizacions)
            .HasForeignKey(d => d.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        director.HasOne(d => d.Estado)
            .WithMany(est => est.Directores)
            .HasForeignKey(d => d.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 16. Edificio
        var edificio = modelBuilder.Entity<Edificio>();
        edificio.ToTable("Edificio");
        edificio.HasKey(e => e.Id);
        edificio.Property(e => e.Id).HasColumnName("IdEdificio");
        edificio.Property(e => e.Nombre).HasMaxLength(100).IsRequired();
        edificio.Property(e => e.CodEdificio).HasMaxLength(15).IsRequired();
        edificio.HasIndex(e => e.CodEdificio).IsUnique();
        edificio.Property(e => e.Descripcion).HasMaxLength(300);
        edificio.Property(e => e.EstadoId).IsRequired();
        edificio.Property(e => e.UsuarioRegistroId).IsRequired();
        edificio.Property(ad => ad.FechaConstruccion).HasDefaultValueSql("GETDATE()");
        edificio.Property(e => e.FechaRegistro).HasDefaultValueSql("GETDATE()");

        edificio.HasOne(e => e.Estado)
            .WithMany(c => c.Edificios)
            .HasForeignKey(e => e.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        edificio.HasOne(e => e.UsuarioRegistro)
            .WithMany(c => c.EdificioRegistros)
            .HasForeignKey(e => e.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        edificio.HasOne(e => e.UsuarioActualizacion)
            .WithMany(c => c.EdificioActualizacions)
            .HasForeignKey(e => e.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        // 17. Entrada
        var entrada = modelBuilder.Entity<Entrada>();
        entrada.ToTable("Entrada");
        entrada.HasKey(et => et.Id);
        entrada.Property(et => et.Id).HasColumnName("IdEntrada");
        entrada.Property(et => et.FechaRegistro).HasColumnName("FechaEntrada").HasDefaultValueSql("GETDATE()");
        entrada.Ignore(et => et.EstadoId);
        entrada.Ignore(et => et.Estado);
        entrada.Property(et => et.NumEntrada).IsRequired();
        entrada.HasIndex(et => et.NumEntrada).IsUnique();
        entrada.Property(et => et.DocReferencia).IsRequired();
        entrada.Property(et => et.NoDocReferencia).IsRequired();
        entrada.HasIndex(et => et.NoDocReferencia).IsUnique();
        entrada.Property(et => et.ObservacionEntrada).HasMaxLength(300);
        entrada.Property(et => et.UsuarioRegistroId).IsRequired();

        entrada.HasOne(et => et.UsuarioRegistro)
            .WithMany(us => us.EntradaRegistros)
            .HasForeignKey(et => et.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        // 18. Estado
        var estado = modelBuilder.Entity<Estado>();
        estado.ToTable("Estado");
        estado.HasKey(est => est.Id);
        estado.Property(est => est.Id).HasColumnName("IdEstado");
        estado.Ignore(est => est.EstadoId);
        estado.Ignore(est => est.Estado);
        estado.Ignore(est => est.FechaRegistro);
        estado.Property(est => est.TipoEstadoId).IsRequired();
        estado.Property(est => est.Nombre).HasMaxLength(50).IsRequired();
        estado.HasIndex(est => new { est.Nombre, est.TipoEstadoId }).IsUnique();

        estado.HasOne(est => est.TipoEstado)
            .WithMany(te => te.Estados)
            .HasForeignKey(est => est.TipoEstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        estado.HasData(
            new Estado { Id = (int)EstadoGenerico.Activo, Nombre = "Activo", TipoEstadoId = (int)TipoEstadoEnum.EstadoGenerico },
            new Estado { Id = (int)EstadoGenerico.Inactivo, Nombre = "Inactivo", TipoEstadoId = (int)TipoEstadoEnum.EstadoGenerico },

            new Estado { Id = (int)EstadoActivoFisico.Disponible, Nombre = "Disponible", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
            new Estado { Id = (int)EstadoActivoFisico.Prestado, Nombre = "Prestado", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
            new Estado { Id = (int)EstadoActivoFisico.PendienteDeMantenimiento, Nombre = "Pendiente de Mantenimiento", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
            new Estado { Id = (int)EstadoActivoFisico.Dañado, Nombre = "Dañado", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
            new Estado { Id = (int)EstadoActivoFisico.Extraviado, Nombre = "Extraviado", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
            new Estado { Id = (int)EstadoActivoFisico.DadoDeBaja, Nombre = "Dado de Baja", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },
            new Estado { Id = (int)EstadoActivoFisico.NoDisponible, Nombre = "No Disponible", TipoEstadoId = (int)TipoEstadoEnum.ActivoFisico },

            new Estado { Id = (int)EstadoDetalleDevolucion.Bueno, Nombre = "Bueno", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },
            new Estado { Id = (int)EstadoDetalleDevolucion.Regular, Nombre = "Regular", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },
            new Estado { Id = (int)EstadoDetalleDevolucion.Averiado, Nombre = "Averiado", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },
            new Estado { Id = (int)EstadoDetalleDevolucion.Incompleto, Nombre = "Incompleto", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },
            new Estado { Id = (int)EstadoDetalleDevolucion.NoDevuelto, Nombre = "No Devuelto", TipoEstadoId = (int)TipoEstadoEnum.DetalleDevolucion },

            new Estado { Id = (int)EstadoDetalleMantenimiento.EnProceso, Nombre = "En Proceso", TipoEstadoId = (int)TipoEstadoEnum.DetalleMantenimiento },
            new Estado { Id = (int)EstadoDetalleMantenimiento.Reparado, Nombre = "Reparado", TipoEstadoId = (int)TipoEstadoEnum.DetalleMantenimiento },
            new Estado { Id = (int)EstadoDetalleMantenimiento.NoReparado, Nombre = "No Reparado", TipoEstadoId = (int)TipoEstadoEnum.DetalleMantenimiento },

            new Estado { Id = (int)EstadoMantenimiento.EnProceso, Nombre = "En Proceco", TipoEstadoId = (int)TipoEstadoEnum.Mantenimiento },
            new Estado { Id = (int)EstadoMantenimiento.Finalizado, Nombre = "Finalizado", TipoEstadoId = (int)TipoEstadoEnum.Mantenimiento },
            new Estado { Id = (int)EstadoMantenimiento.Cancelado, Nombre = "Cancelado", TipoEstadoId = (int)TipoEstadoEnum.Mantenimiento },

            new Estado { Id = (int)EstadoPrestamo.Vigente, Nombre = "Vigente", TipoEstadoId = (int)TipoEstadoEnum.Prestamo },
            new Estado { Id = (int)EstadoPrestamo.Devuelto, Nombre = "Devuelto", TipoEstadoId = (int)TipoEstadoEnum.Prestamo },
            new Estado { Id = (int)EstadoPrestamo.DevueltoParcial, Nombre = "Devuelto Parcial", TipoEstadoId = (int)TipoEstadoEnum.Prestamo },
            new Estado { Id = (int)EstadoPrestamo.Vencido, Nombre = "Vencido", TipoEstadoId = (int)TipoEstadoEnum.Prestamo },

            new Estado { Id = (int)EstadoSolicitudMantenimiento.Pendiente, Nombre = "Pendiente", TipoEstadoId = (int)TipoEstadoEnum.SolicitudMantenimiento },
            new Estado { Id = (int)EstadoSolicitudMantenimiento.Aprovada, Nombre = "Aprovada", TipoEstadoId = (int)TipoEstadoEnum.SolicitudMantenimiento },
            new Estado { Id = (int)EstadoSolicitudMantenimiento.Rechazada, Nombre = "Rechazada", TipoEstadoId = (int)TipoEstadoEnum.SolicitudMantenimiento },
            new Estado { Id = (int)EstadoSolicitudMantenimiento.Atendida, Nombre = "Atendida", TipoEstadoId = (int)TipoEstadoEnum.SolicitudMantenimiento }
        );

        // 19. HistorialAcceso
        var historialAcceso = modelBuilder.Entity<HistorialAcceso>();
        historialAcceso.ToTable("HistorialAcceso");
        historialAcceso.HasKey(h => h.Id);
        historialAcceso.Property(h => h.Id).HasColumnName("IdHistorialAcceso");
        historialAcceso.Ignore(h => h.EstadoId);
        historialAcceso.Ignore(h => h.Estado);
        historialAcceso.Ignore(h => h.FechaRegistro);
        historialAcceso.Property(h => h.UsuarioId).IsRequired();
        historialAcceso.Property(h => h.FechaIngraso).HasDefaultValueSql("GETDATE()");
        historialAcceso.Property(h => h.DireccionIp).HasMaxLength(50).IsRequired();
        historialAcceso.Property(h => h.SistemaOperatico).HasMaxLength(100);

        historialAcceso.HasOne(h => h.Usuario)
            .WithMany(u => u.HistorialAccesos)
            .HasForeignKey(h => h.UsuarioId)
            .OnDelete(DeleteBehavior.Restrict);

        // 20. Mantenimiento
        var mantenimiento = modelBuilder.Entity<Mantenimiento>();
        mantenimiento.ToTable("Mantenimiento");
        mantenimiento.HasKey(ma => ma.Id);
        mantenimiento.Property(ma => ma.Id).HasColumnName("IdMantenimiento");
        mantenimiento.Property(ma => ma.SolicitudMantenimientoId).IsRequired();
        mantenimiento.Property(ma => ma.PersonalTecnicoId).IsRequired();
        mantenimiento.Property(ma => ma.UsuarioRegistroId).IsRequired();
        mantenimiento.Property(ma => ma.EstadoId).IsRequired();
        mantenimiento.Property(ma => ma.FechaInicioAtencion).HasDefaultValueSql("GETDATE()");
        mantenimiento.Property(ma => ma.FechaCierre).HasDefaultValueSql("GETDATE()");

        mantenimiento.HasOne(ma => ma.SolicitudMantenimiento)
            .WithMany(sm => sm.Mantenimientos)
            .HasForeignKey(ma => ma.SolicitudMantenimientoId)
            .OnDelete(DeleteBehavior.Restrict);

        mantenimiento.HasOne(ma => ma.PersonalTecnico)
            .WithMany(us => us.MantenimientoTecnicos)
            .HasForeignKey(ma => ma.PersonalTecnicoId)
            .OnDelete(DeleteBehavior.Restrict);

        mantenimiento.HasOne(ma => ma.UsuarioRegistro)
            .WithMany(us => us.MantenimientoRegistros)
            .HasForeignKey(ma => ma.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        mantenimiento.HasOne(ma => ma.Estado)
            .WithMany(est => est.Mantenimientos)
            .HasForeignKey(ma => ma.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 21. Marca
        var marca = modelBuilder.Entity<Marca>();
        marca.ToTable("Marca");
        marca.HasKey(mc => mc.Id);
        marca.Property(mc => mc.Id).HasColumnName("IdMarca");
        marca.Property(mc => mc.FechaRegistro).HasColumnName("FechaCreacion").HasDefaultValueSql("GETDATE()");
        marca.Property(mc => mc.UsuarioRegistroId).IsRequired();
        marca.Property(mc => mc.EstadoId).IsRequired();
        marca.Property(mc => mc.Nombre).HasMaxLength(50).IsRequired();
        marca.HasIndex(mc => mc.Nombre).IsUnique();
        marca.Property(mc => mc.Descripcion).HasMaxLength(300);

        marca.HasOne(mc => mc.UsuarioRegistro)
            .WithMany(us => us.MarcaRegistros)
            .HasForeignKey(mc => mc.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        marca.HasOne(mc => mc.UsuarioActualizacion)
            .WithMany(us => us.MarcaActualizacion)
            .HasForeignKey(mc => mc.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        marca.HasOne(mc => mc.Estado)
            .WithMany(est => est.Marcas)
            .HasForeignKey(mc => mc.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 22. Traslado (Movimiento)
        var movimiento = modelBuilder.Entity<Traslado>();
        movimiento.ToTable("Traslado");
        movimiento.HasKey(mo => mo.Id);
        movimiento.Property(mo => mo.Id).HasColumnName("IdTraslado");
        movimiento.Property(mo => mo.FechaRegistro).HasColumnName("FechaTraslado").HasDefaultValueSql("GETDATE()");
        movimiento.Ignore(mo => mo.EstadoId);
        movimiento.Ignore(mo => mo.Estado);
        movimiento.Property(mo => mo.UsuarioRegistroId).IsRequired();
        movimiento.Property(mo => mo.RazonTraslado).HasMaxLength(300).IsRequired();
        movimiento.Property(mo => mo.DocAutorizacion).IsRequired();
        movimiento.Property(mo => mo.AutorizadoPorId).IsRequired();
        movimiento.Property(mo => mo.NoDocAutorizacion).IsRequired();
        movimiento.HasIndex(mo => mo.NoDocAutorizacion).IsUnique();

        movimiento.HasOne(mo => mo.UsuarioRegistro)
            .WithMany(us => us.MovimientoRegistros)
            .HasForeignKey(mo => mo.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        movimiento.HasOne(mo => mo.AutorizadoPor)
            .WithMany(mo => mo.Traslaados)
            .HasForeignKey(mo => mo.AutorizadoPorId)
            .OnDelete(DeleteBehavior.Restrict);

        // 23. Permiso
        var permiso = modelBuilder.Entity<Permiso>();
        permiso.ToTable("Permiso");
        permiso.HasKey(pr => pr.Id);
        permiso.Property(pr => pr.Id).HasColumnName("IdPermiso");
        permiso.Ignore(pr => pr.EstadoId);
        permiso.Ignore(pr => pr.Estado);
        permiso.Ignore(pr => pr.FechaRegistro);
        permiso.Property(pr => pr.Nombre).HasMaxLength(50).IsRequired();
        permiso.HasIndex(pr => pr.Nombre).IsUnique();
        permiso.Property(pr => pr.Descripcion).HasMaxLength(50);

        permiso.HasData(
            new Permiso { Id = 1, Nombre = "Gestionar Usuarios", Descripcion = "Crear, guardar, actualizar, eliminar usuarios" },
            new Permiso { Id = 2, Nombre = "Gestionar Roles", Descripcion = "Asiganar roles a susuarios" },
            new Permiso { Id = 3, Nombre = "Gestionar Activos", Descripcion = "Crear, guardar, actualizar, eliminar activos" },
            new Permiso { Id = 4, Nombre = "Gestionar Catgorias", Descripcion = "Crear, guardar, actualizar, eliminar categorias" },
            new Permiso { Id = 5, Nombre = "Gestionar Marcas", Descripcion = "Crear, guardar, actualizar, eliminar marcas" },
            new Permiso { Id = 6, Nombre = "Gestionar Ubicaciones", Descripcion = "Crear, guardar, actualizar elimiar ubicaciones" },
            new Permiso { Id = 7, Nombre = "Registrar Entradas", Descripcion = "Registrar entrada de activos" },
            new Permiso { Id = 8, Nombre = "Registrar Salidad", Descripcion = "Registrar Salida de Activos" },
            new Permiso { Id = 9, Nombre = "Gestionar Prestamos", Descripcion = "Resgistrar prestamoss y devoluciones" },
            new Permiso { Id = 10, Nombre = "Gestionar Traslados", Descripcion = "Registar y gestionar traslado de activos" },
            new Permiso { Id = 11, Nombre = "Gestionar Solicitud de Mantenimiento", Descripcion = "Registrar solicitudes de mantenimiento" },
            new Permiso { Id = 12, Nombre = "Gestionar Mantenimientos", Descripcion = "Registrar procesos de mantenimientos" },
            new Permiso { Id = 13, Nombre = "Ver Reportes", Descripcion = "Ver, generar, consultar reportes" },
            new Permiso { Id = 14, Nombre = "Gestionar Configuraciones", Descripcion = "Realizar ajustes dentro del sistema" }
        );

        // 24. Personal
        var personal = modelBuilder.Entity<Personal>();
        personal.ToTable("Personal");
        personal.HasKey(ps => ps.Id);
        personal.Property(ps => ps.Id).HasColumnName("IdPersonal");
        personal.Property(ps => ps.FechaRegistro).HasColumnName("FechaCreacion").HasDefaultValueSql("GETDATE()");
        personal.Property(ps => ps.PuestoId).IsRequired();
        personal.Property(ps => ps.EstadoId).IsRequired();
        personal.Property(ps => ps.UsuarioRegistroId).IsRequired();
        personal.Property(ps => ps.Nombre).HasMaxLength(50).IsRequired();
        personal.Property(ps => ps.Apellido).HasMaxLength(50).IsRequired();
        personal.Property(ps => ps.Cedula).HasMaxLength(50).IsRequired().IsUnicode(false);
        personal.HasIndex(ps => ps.Cedula).IsUnique();
        personal.Property(ps => ps.CodPersonal).HasMaxLength(10).IsRequired().IsUnicode(false);
        personal.HasIndex(ps => ps.CodPersonal).IsUnique();
        personal.Property(ps => ps.Telefono).HasMaxLength(20).IsUnicode(false);
        personal.HasIndex(ps => ps.Telefono).IsUnique();
        personal.Property(ps => ps.Correo).HasMaxLength(100);
        personal.HasIndex(ps => ps.Correo).IsUnique();

        personal.HasOne(ps => ps.Puesto)
            .WithMany(pu => pu.Personales)
            .HasForeignKey(ps => ps.PuestoId)
            .OnDelete(DeleteBehavior.Restrict);

        personal.HasOne(ps => ps.Estado)
            .WithMany(est => est.Personales)
            .HasForeignKey(ps => ps.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        personal.HasOne(ps => ps.UsuarioRegistro)
            .WithMany(us => us.PersonalRegistros)
            .HasForeignKey(ps => ps.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        personal.HasOne(ps => ps.UsuarioActualizacion)
            .WithMany(us => us.PersonalActualizacion)
            .HasForeignKey(ps => ps.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        // 25. Prestamo
        var prestamo = modelBuilder.Entity<Prestamo>();
        prestamo.ToTable("Prestamo");
        prestamo.HasKey(pt => pt.Id);
        prestamo.Property(pt => pt.Id).HasColumnName("IdPrestamo");
        prestamo.Property(pt => pt.FechaRegistro).HasColumnName("FechaPrestamo").HasDefaultValueSql("GETDATE()");
        prestamo.Property(pt => pt.EstadoId).IsRequired();
        prestamo.Property(pt => pt.PersonalSolicitanteId).IsRequired();
        prestamo.Property(pt => pt.UsuarioRegistroId).IsRequired();
        prestamo.Property(pt => pt.FechaLimite).HasDefaultValueSql("GETDATE()");

        prestamo.HasOne(pt => pt.Estado)
            .WithMany(est => est.Prestamos)
            .HasForeignKey(pt => pt.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        prestamo.HasOne(pt => pt.PersonalSolicitante)
            .WithMany(us => us.Prestamos)
            .HasForeignKey(pt => pt.PersonalSolicitanteId)
            .OnDelete(DeleteBehavior.Restrict);

        prestamo.HasOne(pt => pt.UsuarioRegistro)
            .WithMany(us => us.PrestamoRegistros)
            .HasForeignKey(pt => pt.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        // 26. Proveedor
        var proveedor = modelBuilder.Entity<Proveedor>();
        proveedor.ToTable("Proveedor");
        proveedor.HasKey(p => p.Id);
        proveedor.Property(p => p.Id).HasColumnName("IdProveedor");
        proveedor.Property(p => p.RNC).HasMaxLength(20);
        proveedor.HasIndex(p => p.RNC).IsUnique();
        proveedor.Property(p => p.Nombre).HasMaxLength(100).IsRequired();
        proveedor.HasIndex(p => p.Nombre).IsUnique();
        proveedor.Property(p => p.Telefono).HasMaxLength(20).IsRequired();
        proveedor.Property(p => p.Correo).HasMaxLength(100);
        proveedor.Property(p => p.Direccion).HasMaxLength(200);
        proveedor.Property(p => p.PersonalContacto).HasMaxLength(100);
        proveedor.Property(p => p.TelefonoContacto).HasMaxLength(20);
        proveedor.Property(p => p.FechaRegistro).HasDefaultValueSql("GETDATE()");
        proveedor.Property(p => p.EstadoId).IsRequired();
        proveedor.Property(p => p.UsuarioRegistroId).IsRequired();

        proveedor.HasOne(m => m.Estado)
            .WithMany(a => a.Proveedores)
            .HasForeignKey(m => m.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        proveedor.HasOne(m => m.UsuarioRegistro)
            .WithMany(a => a.ProveedorRegistros)
            .HasForeignKey(m => m.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        proveedor.HasOne(m => m.UsuarioActualizacion)
            .WithMany(a => a.ProveedorActualizacions)
            .HasForeignKey(m => m.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        // 27. Puesto
        var puesto = modelBuilder.Entity<Puesto>();
        puesto.ToTable("Puesto");
        puesto.HasKey(pu => pu.Id);
        puesto.Property(pu => pu.Id).HasColumnName("IdPuesto");
        puesto.Property(pu => pu.FechaRegistro).HasColumnName("FechaCreacion").HasDefaultValueSql("GETDATE()");
        puesto.Property(pu => pu.UsuarioRegistroId).IsRequired();
        puesto.Property(pu => pu.EstadoId).IsRequired();
        puesto.Property(pu => pu.Nombre).HasMaxLength(50).IsRequired();
        puesto.HasIndex(pu => pu.Nombre).IsUnique();
        puesto.Property(pu => pu.Descripcion).HasMaxLength(300);

        puesto.HasOne(pu => pu.UsuarioRegistro)
            .WithMany(us => us.PuestoRegistros)
            .HasForeignKey(pu => pu.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        puesto.HasOne(pu => pu.UsuarioActualizacion)
            .WithMany(us => us.PuestoActualizacion)
            .HasForeignKey(pu => pu.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        puesto.HasOne(pu => pu.Estado)
            .WithMany(us => us.Puestos)
            .HasForeignKey(pu => pu.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 28. Rol
        var rol = modelBuilder.Entity<Rol>();
        rol.ToTable("Rol");
        rol.HasKey(r => r.Id);
        rol.Property(r => r.Id).HasColumnName("IdRol");
        rol.Ignore(r => r.EstadoId);
        rol.Ignore(r => r.Estado);
        rol.Ignore(r => r.FechaRegistro);
        rol.Property(r => r.Nombre).HasMaxLength(50).IsRequired();
        rol.HasIndex(r => r.Nombre).IsUnique();
        rol.Property(r => r.Descripcion).HasMaxLength(300);

        rol.HasData(
            new Rol { Id = (int)EnumRol.Administrador, Nombre = "Administrador", Descripcion = "Puede realizar cualquier accion dentro del sistema" },
            new Rol { Id = (int)EnumRol.EncargadoGeneralActivos, Nombre = "Encargado General de Activos", Descripcion = "Puede realizar todas la acciones relaciondas a la gestion y control de activos" },
            new Rol { Id = (int)EnumRol.EncargadoTraslados, Nombre = "Encargado de Traslados", Descripcion = "Puede gestrionar los traslados de activos" },
            new Rol { Id = (int)EnumRol.EncargadoMantenimiento, Nombre = "Encargado de Mantenimiento", Descripcion = "Puede destionar solicitudes y mantenimientos" },
            new Rol { Id = (int)EnumRol.EncargadoConsulta, Nombre = "Encargado de Consultas y reportes", Descripcion = "Solo puede consultar informacion y reportes" }
        );

        // 29. RolPermiso
        var rolpermiso = modelBuilder.Entity<RolPermiso>();
        rolpermiso.ToTable("RolPermiso");
        rolpermiso.HasKey(rp => rp.Id);
        rolpermiso.Property(rp => rp.Id).HasColumnName("IdRolPermiso");
        rolpermiso.Ignore(rp => rp.EstadoId);
        rolpermiso.Ignore(rp => rp.Estado);
        rolpermiso.Ignore(rp => rp.FechaRegistro);
        rolpermiso.Property(rp => rp.PermisoId).IsRequired();
        rolpermiso.Property(rp => rp.RolId).IsRequired();
        rolpermiso.HasIndex(rp => new { rp.RolId, rp.PermisoId }).IsUnique();

        rolpermiso.HasOne(rp => rp.Permiso)
            .WithMany(pr => pr.RolPermisos)
            .HasForeignKey(rp => rp.PermisoId)
            .OnDelete(DeleteBehavior.Restrict);

        rolpermiso.HasOne(rp => rp.Rol)
            .WithMany(r => r.RolPermisos)
            .HasForeignKey(rp => rp.RolId)
            .OnDelete(DeleteBehavior.Restrict);

        rolpermiso.HasData(
            new RolPermiso { Id = 1, RolId = 1, PermisoId = 1 },
            new RolPermiso { Id = 2, RolId = 1, PermisoId = 2 },
            new RolPermiso { Id = 3, RolId = 1, PermisoId = 3 },
            new RolPermiso { Id = 4, RolId = 1, PermisoId = 4 },
            new RolPermiso { Id = 5, RolId = 1, PermisoId = 5 },
            new RolPermiso { Id = 6, RolId = 1, PermisoId = 6 },
            new RolPermiso { Id = 7, RolId = 1, PermisoId = 7 },
            new RolPermiso { Id = 8, RolId = 1, PermisoId = 8 },
            new RolPermiso { Id = 9, RolId = 1, PermisoId = 9 },
            new RolPermiso { Id = 10, RolId = 1, PermisoId = 10 },
            new RolPermiso { Id = 11, RolId = 1, PermisoId = 11 },
            new RolPermiso { Id = 12, RolId = 1, PermisoId = 12 },
            new RolPermiso { Id = 13, RolId = 1, PermisoId = 13 },
            new RolPermiso { Id = 14, RolId = 1, PermisoId = 14 },
            new RolPermiso { Id = 15, RolId = 2, PermisoId = 3 },
            new RolPermiso { Id = 16, RolId = 2, PermisoId = 4 },
            new RolPermiso { Id = 17, RolId = 2, PermisoId = 5 },
            new RolPermiso { Id = 18, RolId = 2, PermisoId = 6 },
            new RolPermiso { Id = 19, RolId = 2, PermisoId = 7 },
            new RolPermiso { Id = 20, RolId = 2, PermisoId = 8 },
            new RolPermiso { Id = 21, RolId = 2, PermisoId = 9 },
            new RolPermiso { Id = 22, RolId = 2, PermisoId = 10 },
            new RolPermiso { Id = 23, RolId = 2, PermisoId = 11 },
            new RolPermiso { Id = 24, RolId = 2, PermisoId = 12 },
            new RolPermiso { Id = 25, RolId = 2, PermisoId = 13 },
            new RolPermiso { Id = 26, RolId = 3, PermisoId = 10 },
            new RolPermiso { Id = 27, RolId = 4, PermisoId = 11 },
            new RolPermiso { Id = 28, RolId = 4, PermisoId = 12 },
            new RolPermiso { Id = 29, RolId = 5, PermisoId = 13 }
        );

        // 30. Salida
        var salida = modelBuilder.Entity<Salida>();
        salida.ToTable("Salida");
        salida.HasKey(sa => sa.Id);
        salida.Property(sa => sa.Id).HasColumnName("IdSalida");
        salida.Property(sa => sa.FechaRegistro).HasColumnName("FechaSalida").HasDefaultValueSql("GETDATE()");
        salida.Ignore(sa => sa.EstadoId);
        salida.Ignore(sa => sa.Estado);
        salida.Property(sa => sa.UsuarioRegistroId).IsRequired();
        salida.Property(sa => sa.NumSalida).IsRequired();
        salida.HasIndex(sa => sa.NumSalida).IsUnique();
        salida.Property(sa => sa.RazonSalida).HasMaxLength(300);

        salida.HasOne(sa => sa.UsuarioRegistro)
            .WithMany(us => us.SalidaRegistros)
            .HasForeignKey(sa => sa.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        // 31. SolicitudMantenimiento
        var solicitudmantenimiento = modelBuilder.Entity<SolicitudMantenimiento>();
        solicitudmantenimiento.ToTable("SolicitudMantenimiento");
        solicitudmantenimiento.HasKey(sm => sm.Id);
        solicitudmantenimiento.Property(sm => sm.Id).HasColumnName("IdSolicitudMantenimiento");
        solicitudmantenimiento.Property(sm => sm.FechaRegistro).HasColumnName("FechaSolicitud").HasDefaultValueSql("GETDATE()");
        solicitudmantenimiento.Property(sm => sm.UsuarioRegistroId).IsRequired();
        solicitudmantenimiento.Property(sm => sm.EstadoId).IsRequired();
        solicitudmantenimiento.Property(sm => sm.ObservacionGeneral).HasMaxLength(300);

        solicitudmantenimiento.HasOne(sm => sm.UsuarioRegistro)
            .WithMany(us => us.SolicitudMantenimientoRegistros)
            .HasForeignKey(sm => sm.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        solicitudmantenimiento.HasOne(sm => sm.Estado)
            .WithMany(est => est.SolicitudMantenimientos)
            .HasForeignKey(sm => sm.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        // 32. SubCategoria
        var subCategoria = modelBuilder.Entity<SubCategoria>();
        subCategoria.ToTable("SubCategoria");
        subCategoria.HasKey(s => s.Id);
        subCategoria.Property(s => s.Id).HasColumnName("IdSubCategoria");
        subCategoria.Property(s => s.FechaRegistro).HasColumnName("FechaCreacion").HasDefaultValueSql("GETDATE()");
        subCategoria.Property(s => s.CategoriaId).IsRequired();
        subCategoria.Property(s => s.Nombre).HasMaxLength(80).IsRequired();
        subCategoria.HasIndex(s => s.Nombre).IsUnique();
        subCategoria.Property(s => s.Descripcion).HasMaxLength(300);
        subCategoria.Property(s => s.VidaUtil).IsRequired();
        subCategoria.Property(s => s.EstadoId).IsRequired();
        subCategoria.Property(s => s.UsuarioRegistroId).IsRequired();

        subCategoria.HasOne(s => s.Categoria)
            .WithMany(c => c.SubCategorias)
            .HasForeignKey(s => s.CategoriaId)
            .OnDelete(DeleteBehavior.Restrict);

        subCategoria.HasOne(m => m.Estado)
            .WithMany(a => a.SubCategorias)
            .HasForeignKey(m => m.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        subCategoria.HasOne(m => m.UsuarioRegistro)
            .WithMany(a => a.SubCategoriaRegistros)
            .HasForeignKey(m => m.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        subCategoria.HasOne(m => m.UsuarioActualizacion)
            .WithMany(a => a.SubCategoriaActualizacions)
            .HasForeignKey(m => m.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        // 33. TipoEstado
        var tipoestado = modelBuilder.Entity<TipoEstado>();
        tipoestado.ToTable("TipoEstado");
        tipoestado.HasKey(te => te.Id);
        tipoestado.Property(te => te.Id).HasColumnName("IdTipoEstado");
        tipoestado.Ignore(te => te.EstadoId);
        tipoestado.Ignore(te => te.Estado);
        tipoestado.Ignore(te => te.FechaRegistro);
        tipoestado.Property(te => te.Nombre).HasMaxLength(50).IsRequired();
        tipoestado.HasIndex(te => te.Nombre).IsUnique();

        tipoestado.HasData(
            new TipoEstado { Id = (int)TipoEstadoEnum.EstadoGenerico, Nombre = "Estado Generico" },
            new TipoEstado { Id = (int)TipoEstadoEnum.ActivoFisico, Nombre = "Activo Fisico" },
            new TipoEstado { Id = (int)TipoEstadoEnum.DetalleDevolucion, Nombre = "Detalle Devolucion" },
            new TipoEstado { Id = (int)TipoEstadoEnum.DetalleMantenimiento, Nombre = "Detalle Mantenimiento" },
            new TipoEstado { Id = (int)TipoEstadoEnum.Mantenimiento, Nombre = "Mantenimiento" },
            new TipoEstado { Id = (int)TipoEstadoEnum.Prestamo, Nombre = "Prestamo" },
            new TipoEstado { Id = (int)TipoEstadoEnum.SolicitudMantenimiento, Nombre = "Solicitud Mantenimiento" }
        );

        // 34. Ubicacion
        var ubicacion = modelBuilder.Entity<Ubicacion>();
        ubicacion.ToTable("Ubicacion");
        ubicacion.HasKey(ub => ub.Id);
        ubicacion.Property(ub => ub.Id).HasColumnName("IdUbicacion");
        ubicacion.Property(ub => ub.FechaRegistro).HasColumnName("FechaCreacion").HasDefaultValueSql("GETDATE()");
        ubicacion.Property(ub => ub.UsuarioRegistroId).IsRequired();
        ubicacion.Property(ub => ub.EstadoId).IsRequired();
        ubicacion.Property(ub => ub.EdificioId).IsRequired();
        ubicacion.Property(ub => ub.Nombre).HasMaxLength(50).IsRequired();
        ubicacion.Property(u => u.Piso).IsRequired();
        ubicacion.HasIndex(ub => ub.Nombre).IsUnique();
        ubicacion.Property(ub => ub.Descripcion).HasMaxLength(300);

        ubicacion.HasOne(ub => ub.UsuarioRegistro)
            .WithMany(us => us.UbicacionRegistros)
            .HasForeignKey(ub => ub.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        ubicacion.HasOne(ub => ub.Estado)
            .WithMany(us => us.Ubicaciones)
            .HasForeignKey(ub => ub.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        ubicacion.HasOne(ub => ub.Edificio)
            .WithMany(us => us.Ubicaciones)
            .HasForeignKey(ub => ub.EdificioId)
            .OnDelete(DeleteBehavior.Restrict);

        ubicacion.HasOne(ub => ub.UsuarioActualizacion)
            .WithMany(us => us.UbicacionActualizacion)
            .HasForeignKey(ub => ub.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        // 35. Usuario
        var usuario = modelBuilder.Entity<Usuario>();
        usuario.ToTable("Usuario");
        usuario.HasKey(us => us.Id);
        usuario.Property(us => us.Id).HasColumnName("IdUsuario");
        usuario.Property(us => us.FechaRegistro).HasColumnName("FechaCreacion").HasDefaultValueSql("GETDATE()");
        usuario.Property(us => us.RolId).IsRequired();
        usuario.Property(us => us.EstadoId).IsRequired();
        usuario.Property(us => us.UsuarioRegistroId).IsRequired();
        usuario.Property(us => us.Nombre).HasMaxLength(50).IsRequired();
        usuario.Property(us => us.Apellido).HasMaxLength(50).IsRequired();
        usuario.Property(us => us.Cedula).HasMaxLength(20).IsUnicode(false);
        usuario.HasIndex(us => us.Cedula).IsUnique();
        usuario.Property(us => us.Telefono).HasMaxLength(20).IsUnicode(false);
        usuario.HasIndex(us => us.Telefono).IsUnique();
        usuario.Property(us => us.Correo).HasMaxLength(100);
        usuario.HasIndex(us => us.Correo).IsUnique();
        usuario.Property(us => us.NombreUsuario).HasMaxLength(10).IsUnicode(false);
        usuario.HasIndex(us => us.NombreUsuario).IsUnique();
        usuario.Property(us => us.ClaveHash).HasMaxLength(64).IsUnicode(false).IsRequired();
        usuario.HasIndex(us => us.ClaveHash).IsUnique();

        usuario.HasOne(us => us.Rol)
            .WithMany(r => r.Usuarios)
            .HasForeignKey(us => us.RolId)
            .OnDelete(DeleteBehavior.Restrict);

        usuario.HasOne(us => us.Estado)
            .WithMany(est => est.Usuarios)
            .HasForeignKey(us => us.EstadoId)
            .OnDelete(DeleteBehavior.Restrict);

        usuario.HasOne(us => us.UsuarioRegistro)
            .WithMany(us => us.UsuarioRegistros)
            .HasForeignKey(us => us.UsuarioRegistroId)
            .OnDelete(DeleteBehavior.Restrict);

        usuario.HasOne(us => us.UsuarioActualizacion)
            .WithMany(us => us.UsuarioActualizacions)
            .HasForeignKey(us => us.UsuarioActualizacionId)
            .OnDelete(DeleteBehavior.Restrict);

        usuario.HasData(
            new Usuario
            {
                Id = 1,
                NombreUsuario = "AdminDEV",
                ClaveHash = "8D55C34FBBDDDA456D134D51514CC75B7EEE6C09D09079BFA8C2E7846F54C738",
                Nombre = "Rutchy",
                Apellido = "Herne",
                Cedula = "402-0000000-0",
                Telefono = "(809) 0000-000",
                Correo = "hernedev@gmail.com",
                RolId = (int)EnumRol.Administrador,
                EstadoId = (int)EstadoGenerico.Activo,
                UsuarioRegistroId = 1,
                FechaRegistro = new DateTime(2026, 7, 2)
            }
        );
    }
}
