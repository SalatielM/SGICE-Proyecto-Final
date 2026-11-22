using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class SistemaVersion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    IdPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.IdPermiso);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "TipoEstado",
                columns: table => new
                {
                    IdTipoEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEstado", x => x.IdTipoEstado);
                });

            migrationBuilder.CreateTable(
                name: "RolPermiso",
                columns: table => new
                {
                    IdRolPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    PermisoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolPermiso", x => x.IdRolPermiso);
                    table.ForeignKey(
                        name: "FK_RolPermiso_Permiso_PermisoId",
                        column: x => x.PermisoId,
                        principalTable: "Permiso",
                        principalColumn: "IdPermiso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolPermiso_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoEstadoId = table.Column<int>(type: "int", nullable: false),
                    EstadoIdEstado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.IdEstado);
                    table.ForeignKey(
                        name: "FK_Estado_Estado_EstadoIdEstado",
                        column: x => x.EstadoIdEstado,
                        principalTable: "Estado",
                        principalColumn: "IdEstado");
                    table.ForeignKey(
                        name: "FK_Estado_TipoEstado_TipoEstadoId",
                        column: x => x.TipoEstadoId,
                        principalTable: "TipoEstado",
                        principalColumn: "IdTipoEstado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NombreUsuario = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ClaveHash = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "backup",
                columns: table => new
                {
                    IdBackup = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RutaBackup = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_backup", x => x.IdBackup);
                    table.ForeignKey(
                        name: "FK_backup_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VidaUtil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.IdCategoria);
                    table.ForeignKey(
                        name: "FK_Categoria_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categoria_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categoria_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    IdDirector = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    FechaInicia = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.IdDirector);
                    table.ForeignKey(
                        name: "FK_Director_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Director_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Director_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Edificio",
                columns: table => new
                {
                    IdEdificio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodEdificio = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CantidadPisos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    FechaConstruccion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edificio", x => x.IdEdificio);
                    table.ForeignKey(
                        name: "FK_Edificio_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Edificio_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Edificio_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entrada",
                columns: table => new
                {
                    IdEntrada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumEntrada = table.Column<int>(type: "int", nullable: false),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DocReferencia = table.Column<int>(type: "int", nullable: false),
                    NoDocReferencia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ObservacionEntrada = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrada", x => x.IdEntrada);
                    table.ForeignKey(
                        name: "FK_Entrada_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistorialAcceso",
                columns: table => new
                {
                    IdHistorialAcceso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    FechaIngraso = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DireccionIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SistemaOperatico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Exitoso = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialAcceso", x => x.IdHistorialAcceso);
                    table.ForeignKey(
                        name: "FK_HistorialAcceso_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.IdMarca);
                    table.ForeignKey(
                        name: "FK_Marca_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marca_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marca_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RNC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PersonalContacto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TelefonoContacto = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.IdProveedor);
                    table.ForeignKey(
                        name: "FK_Proveedor_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedor_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedor_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puesto",
                columns: table => new
                {
                    IdPuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puesto", x => x.IdPuesto);
                    table.ForeignKey(
                        name: "FK_Puesto_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Puesto_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Puesto_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salida",
                columns: table => new
                {
                    IdSalida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumSalida = table.Column<int>(type: "int", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    RazonSalida = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salida", x => x.IdSalida);
                    table.ForeignKey(
                        name: "FK_Salida_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudMantenimiento",
                columns: table => new
                {
                    IdSolicitudMantenimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservacionGeneral = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudMantenimiento", x => x.IdSolicitudMantenimiento);
                    table.ForeignKey(
                        name: "FK_SolicitudMantenimiento_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudMantenimiento_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoria",
                columns: table => new
                {
                    IdSubCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    VidaUtil = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoria", x => x.IdSubCategoria);
                    table.ForeignKey(
                        name: "FK_SubCategoria_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubCategoria_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubCategoria_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubCategoria_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Auditoria",
                columns: table => new
                {
                    IdAuditoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTabla = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RegistroId = table.Column<int>(type: "int", nullable: false),
                    Accion = table.Column<int>(type: "int", nullable: false),
                    ValoresAntiguos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValoresNuevos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UsuarioAuditoriaId = table.Column<int>(type: "int", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    UsuarioIdUsuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoria", x => x.IdAuditoria);
                    table.ForeignKey(
                        name: "FK_Auditoria_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "IdDirector",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auditoria_Usuario_UsuarioAuditoriaId",
                        column: x => x.UsuarioAuditoriaId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auditoria_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Escuela",
                columns: table => new
                {
                    IdCentroEducativo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CodCentro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Longitud = table.Column<double>(type: "float", nullable: false),
                    Latitud = table.Column<double>(type: "float", nullable: false),
                    Modalidad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Jornada = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DistritoEducativo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    RegionalEducativo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escuela", x => x.IdCentroEducativo);
                    table.ForeignKey(
                        name: "FK_Escuela_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "IdDirector",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escuela_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Escuela_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Traslado",
                columns: table => new
                {
                    IdTraslado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaTraslado = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    RazonTraslado = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    AutorizadoPorId = table.Column<int>(type: "int", nullable: false),
                    DocAutorizacion = table.Column<int>(type: "int", nullable: false),
                    NoDocAutorizacion = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traslado", x => x.IdTraslado);
                    table.ForeignKey(
                        name: "FK_Traslado_Director_AutorizadoPorId",
                        column: x => x.AutorizadoPorId,
                        principalTable: "Director",
                        principalColumn: "IdDirector",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Traslado_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    IdUbicacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dimencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Piso = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EdificioId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.IdUbicacion);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Edificio_EdificioId",
                        column: x => x.EdificioId,
                        principalTable: "Edificio",
                        principalColumn: "IdEdificio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ubicacion_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    IdPersonal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CodPersonal = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PuestoId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.IdPersonal);
                    table.ForeignKey(
                        name: "FK_Personal_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personal_Puesto_PuestoId",
                        column: x => x.PuestoId,
                        principalTable: "Puesto",
                        principalColumn: "IdPuesto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personal_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personal_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Activo",
                columns: table => new
                {
                    IdActivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    SubCategoriaId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonalEncargadoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false),
                    UsuarioActualizacionId = table.Column<int>(type: "int", nullable: true),
                    CategoriaIdCategoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activo", x => x.IdActivo);
                    table.ForeignKey(
                        name: "FK_Activo_Categoria_CategoriaIdCategoria",
                        column: x => x.CategoriaIdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria");
                    table.ForeignKey(
                        name: "FK_Activo_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activo_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "IdMarca",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activo_Personal_PersonalEncargadoId",
                        column: x => x.PersonalEncargadoId,
                        principalTable: "Personal",
                        principalColumn: "IdPersonal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activo_Proveedor_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedor",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activo_SubCategoria_SubCategoriaId",
                        column: x => x.SubCategoriaId,
                        principalTable: "SubCategoria",
                        principalColumn: "IdSubCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activo_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activo_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mantenimiento",
                columns: table => new
                {
                    IdMantenimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitudMantenimientoId = table.Column<int>(type: "int", nullable: false),
                    FechaInicioAtencion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaCierre = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    PersonalTecnicoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mantenimiento", x => x.IdMantenimiento);
                    table.ForeignKey(
                        name: "FK_Mantenimiento_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mantenimiento_Personal_PersonalTecnicoId",
                        column: x => x.PersonalTecnicoId,
                        principalTable: "Personal",
                        principalColumn: "IdPersonal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mantenimiento_SolicitudMantenimiento_SolicitudMantenimientoId",
                        column: x => x.SolicitudMantenimientoId,
                        principalTable: "SolicitudMantenimiento",
                        principalColumn: "IdSolicitudMantenimiento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mantenimiento_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    IdPrestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPrestamo = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    FechaLimite = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    PersonalSolicitanteId = table.Column<int>(type: "int", nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.IdPrestamo);
                    table.ForeignKey(
                        name: "FK_Prestamo_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestamo_Personal_PersonalSolicitanteId",
                        column: x => x.PersonalSolicitanteId,
                        principalTable: "Personal",
                        principalColumn: "IdPersonal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestamo_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleEntrada",
                columns: table => new
                {
                    IdDetalleEntrada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntradaId = table.Column<int>(type: "int", nullable: false),
                    ActivoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleEntrada", x => x.IdDetalleEntrada);
                    table.ForeignKey(
                        name: "FK_DetalleEntrada_Activo_ActivoId",
                        column: x => x.ActivoId,
                        principalTable: "Activo",
                        principalColumn: "IdActivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleEntrada_Entrada_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entrada",
                        principalColumn: "IdEntrada",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Devolucion",
                columns: table => new
                {
                    IdDevolucion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrestamoId = table.Column<int>(type: "int", nullable: false),
                    ObervacioneGeneral = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devolucion", x => x.IdDevolucion);
                    table.ForeignKey(
                        name: "FK_Devolucion_Prestamo_PrestamoId",
                        column: x => x.PrestamoId,
                        principalTable: "Prestamo",
                        principalColumn: "IdPrestamo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Devolucion_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivoFisico",
                columns: table => new
                {
                    IdActivoFisico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodEtiquetaQR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NumSerie = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActivoId = table.Column<int>(type: "int", nullable: false),
                    UbicacionId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    DetalleEntradaId = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UsuarioRegistroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivoFisico", x => x.IdActivoFisico);
                    table.ForeignKey(
                        name: "FK_ActivoFisico_Activo_ActivoId",
                        column: x => x.ActivoId,
                        principalTable: "Activo",
                        principalColumn: "IdActivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivoFisico_DetalleEntrada_DetalleEntradaId",
                        column: x => x.DetalleEntradaId,
                        principalTable: "DetalleEntrada",
                        principalColumn: "IdDetalleEntrada",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivoFisico_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivoFisico_Ubicacion_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicacion",
                        principalColumn: "IdUbicacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivoFisico_Usuario_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleDevolucion",
                columns: table => new
                {
                    IdDetalleDevolucion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevolucionId = table.Column<int>(type: "int", nullable: false),
                    ActivoFisicoId = table.Column<int>(type: "int", nullable: false),
                    EstadoDevolucionId = table.Column<int>(type: "int", nullable: false),
                    Obervacion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleDevolucion", x => x.IdDetalleDevolucion);
                    table.ForeignKey(
                        name: "FK_DetalleDevolucion_ActivoFisico_ActivoFisicoId",
                        column: x => x.ActivoFisicoId,
                        principalTable: "ActivoFisico",
                        principalColumn: "IdActivoFisico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleDevolucion_Devolucion_DevolucionId",
                        column: x => x.DevolucionId,
                        principalTable: "Devolucion",
                        principalColumn: "IdDevolucion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleDevolucion_Estado_EstadoDevolucionId",
                        column: x => x.EstadoDevolucionId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleMantenimiento",
                columns: table => new
                {
                    IdDetalleMantenimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MantenimientoId = table.Column<int>(type: "int", nullable: false),
                    ActivoFisicoId = table.Column<int>(type: "int", nullable: false),
                    Solucion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleMantenimiento", x => x.IdDetalleMantenimiento);
                    table.ForeignKey(
                        name: "FK_DetalleMantenimiento_ActivoFisico_ActivoFisicoId",
                        column: x => x.ActivoFisicoId,
                        principalTable: "ActivoFisico",
                        principalColumn: "IdActivoFisico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleMantenimiento_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleMantenimiento_Mantenimiento_MantenimientoId",
                        column: x => x.MantenimientoId,
                        principalTable: "Mantenimiento",
                        principalColumn: "IdMantenimiento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallePrestamo",
                columns: table => new
                {
                    IdDetallePrestamo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrestamoId = table.Column<int>(type: "int", nullable: false),
                    ActivoFisicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePrestamo", x => x.IdDetallePrestamo);
                    table.ForeignKey(
                        name: "FK_DetallePrestamo_ActivoFisico_ActivoFisicoId",
                        column: x => x.ActivoFisicoId,
                        principalTable: "ActivoFisico",
                        principalColumn: "IdActivoFisico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallePrestamo_Prestamo_PrestamoId",
                        column: x => x.PrestamoId,
                        principalTable: "Prestamo",
                        principalColumn: "IdPrestamo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleSalida",
                columns: table => new
                {
                    IdDetalleSalida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalidaId = table.Column<int>(type: "int", nullable: false),
                    ActivoFisicoId = table.Column<int>(type: "int", nullable: false),
                    MotivoSalida = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleSalida", x => x.IdDetalleSalida);
                    table.ForeignKey(
                        name: "FK_DetalleSalida_ActivoFisico_ActivoFisicoId",
                        column: x => x.ActivoFisicoId,
                        principalTable: "ActivoFisico",
                        principalColumn: "IdActivoFisico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleSalida_Salida_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salida",
                        principalColumn: "IdSalida",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleSolicitudMantenimiento",
                columns: table => new
                {
                    IdDetalleSolicitudMantenimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolicitudMantenimientoId = table.Column<int>(type: "int", nullable: false),
                    ActivoFisicoId = table.Column<int>(type: "int", nullable: false),
                    DescripcionProblema = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleSolicitudMantenimiento", x => x.IdDetalleSolicitudMantenimiento);
                    table.ForeignKey(
                        name: "FK_DetalleSolicitudMantenimiento_ActivoFisico_ActivoFisicoId",
                        column: x => x.ActivoFisicoId,
                        principalTable: "ActivoFisico",
                        principalColumn: "IdActivoFisico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleSolicitudMantenimiento_SolicitudMantenimiento_SolicitudMantenimientoId",
                        column: x => x.SolicitudMantenimientoId,
                        principalTable: "SolicitudMantenimiento",
                        principalColumn: "IdSolicitudMantenimiento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleTraslado",
                columns: table => new
                {
                    IdDetalleMovimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrasladoId = table.Column<int>(type: "int", nullable: false),
                    ActivoFisicoId = table.Column<int>(type: "int", nullable: false),
                    UbicacionActualId = table.Column<int>(type: "int", nullable: false),
                    UbicacionFinalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleTraslado", x => x.IdDetalleMovimiento);
                    table.ForeignKey(
                        name: "FK_DetalleTraslado_ActivoFisico_ActivoFisicoId",
                        column: x => x.ActivoFisicoId,
                        principalTable: "ActivoFisico",
                        principalColumn: "IdActivoFisico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleTraslado_Traslado_TrasladoId",
                        column: x => x.TrasladoId,
                        principalTable: "Traslado",
                        principalColumn: "IdTraslado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleTraslado_Ubicacion_UbicacionActualId",
                        column: x => x.UbicacionActualId,
                        principalTable: "Ubicacion",
                        principalColumn: "IdUbicacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleTraslado_Ubicacion_UbicacionFinalId",
                        column: x => x.UbicacionFinalId,
                        principalTable: "Ubicacion",
                        principalColumn: "IdUbicacion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Permiso",
                columns: new[] { "IdPermiso", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Crear, guardar, actualizar, eliminar usuarios", "Gestionar Usuarios" },
                    { 2, "Asiganar roles a susuarios", "Gestionar Roles" },
                    { 3, "Crear, guardar, actualizar, eliminar activos", "Gestionar Activos" },
                    { 4, "Crear, guardar, actualizar, eliminar categorias", "Gestionar Catgorias" },
                    { 5, "Crear, guardar, actualizar, eliminar marcas", "Gestionar Marcas" },
                    { 6, "Crear, guardar, actualizar elimiar ubicaciones", "Gestionar Ubicaciones" },
                    { 7, "Registrar entrada de activos", "Registrar Entradas" },
                    { 8, "Registrar Salida de Activos", "Registrar Salidad" },
                    { 9, "Resgistrar prestamoss y devoluciones", "Gestionar Prestamos" },
                    { 10, "Registar y gestionar traslado de activos", "Gestionar Traslados" },
                    { 11, "Registrar solicitudes de mantenimiento", "Gestionar Solicitud de Mantenimiento" },
                    { 12, "Registrar procesos de mantenimientos", "Gestionar Mantenimientos" },
                    { 13, "Ver, generar, consultar reportes", "Ver Reportes" },
                    { 14, "Realizar ajustes dentro del sistema", "Gestionar Configuraciones" }
                });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "IdRol", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Puede realizar cualquier accion dentro del sistema", "Administrador" },
                    { 2, "Puede realizar todas la acciones relaciondas a la gestion y control de activos", "Encargado General de Activos" },
                    { 3, "Puede gestrionar los traslados de activos", "Encargado de Traslados" },
                    { 4, "Puede destionar solicitudes y mantenimientos ", "Encargado de Mantenimiento" },
                    { 5, "Solo puede consultar informacion y reportes", "Encargado de Consultas y reportes" }
                });

            migrationBuilder.InsertData(
                table: "TipoEstado",
                columns: new[] { "IdTipoEstado", "Nombre" },
                values: new object[,]
                {
                    { 1, "Estado Generico" },
                    { 2, "Activo Fisico" },
                    { 3, "Detalle Devolucion" },
                    { 4, "Detalle Mantenimiento" },
                    { 5, "Mantenimiento" },
                    { 6, "Prestamo" },
                    { 7, "Solicitud Mantenimiento" }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "IdEstado", "EstadoIdEstado", "Nombre", "TipoEstadoId" },
                values: new object[,]
                {
                    { 1, null, "Activo", 1 },
                    { 2, null, "Inactivo", 1 },
                    { 3, null, "Disponible", 2 },
                    { 4, null, "Prestado", 2 },
                    { 5, null, "Pendiente de Mantenimiento", 2 },
                    { 6, null, "Dañado", 2 },
                    { 7, null, "Extraviado", 2 },
                    { 8, null, "Dado de Baja", 2 },
                    { 9, null, "No Disponible", 2 },
                    { 10, null, "Bueno", 3 },
                    { 11, null, "Regular", 3 },
                    { 12, null, "Averiado", 3 },
                    { 13, null, "Incompleto", 3 },
                    { 14, null, "No Devuelto", 3 },
                    { 15, null, "En Proceso", 4 },
                    { 16, null, "Reparado", 4 },
                    { 17, null, "No Reparado", 4 },
                    { 18, null, "En Proceco", 5 },
                    { 19, null, "Finalizado", 5 },
                    { 20, null, "Cancelado", 5 },
                    { 21, null, "Vigente", 6 },
                    { 22, null, "Devuelto", 6 },
                    { 23, null, "Devuelto Parcial", 6 },
                    { 24, null, "Vencido", 6 },
                    { 25, null, "Pendiente", 7 },
                    { 26, null, "Aprovada", 7 },
                    { 27, null, "Rechazada", 7 },
                    { 28, null, "Atendida", 7 }
                });

            migrationBuilder.InsertData(
                table: "RolPermiso",
                columns: new[] { "IdRolPermiso", "PermisoId", "RolId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 8, 1 },
                    { 9, 9, 1 },
                    { 10, 10, 1 },
                    { 11, 11, 1 },
                    { 12, 12, 1 },
                    { 13, 13, 1 },
                    { 14, 14, 1 },
                    { 15, 3, 2 },
                    { 16, 4, 2 },
                    { 17, 5, 2 },
                    { 18, 6, 2 },
                    { 19, 7, 2 },
                    { 20, 8, 2 },
                    { 21, 9, 2 },
                    { 22, 10, 2 },
                    { 23, 11, 2 },
                    { 24, 12, 2 },
                    { 25, 13, 2 },
                    { 26, 10, 3 },
                    { 27, 11, 4 },
                    { 28, 12, 4 },
                    { 29, 13, 5 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "IdUsuario", "Apellido", "Cedula", "ClaveHash", "Correo", "EstadoId", "FechaActualizacion", "FechaCreacion", "Foto", "Nombre", "NombreUsuario", "RolId", "Telefono", "UsuarioActualizacionId", "UsuarioRegistroId" },
                values: new object[] { 1, "Herne", "402-0000000-0", "8D55C34FBBDDDA456D134D51514CC75B7EEE6C09D09079BFA8C2E7846F54C738", "hernedev@gmail.com", 1, null, new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rutchy", "AdminDEV", 1, "(809) 0000-000", null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Activo_CategoriaIdCategoria",
                table: "Activo",
                column: "CategoriaIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_EstadoId",
                table: "Activo",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_MarcaId",
                table: "Activo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_PersonalEncargadoId",
                table: "Activo",
                column: "PersonalEncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_ProveedorId",
                table: "Activo",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_SubCategoriaId",
                table: "Activo",
                column: "SubCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_UsuarioActualizacionId",
                table: "Activo",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Activo_UsuarioRegistroId",
                table: "Activo",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivoFisico_ActivoId",
                table: "ActivoFisico",
                column: "ActivoId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivoFisico_CodEtiquetaQR",
                table: "ActivoFisico",
                column: "CodEtiquetaQR",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActivoFisico_DetalleEntradaId",
                table: "ActivoFisico",
                column: "DetalleEntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivoFisico_EstadoId",
                table: "ActivoFisico",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivoFisico_UbicacionId",
                table: "ActivoFisico",
                column: "UbicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivoFisico_UsuarioRegistroId",
                table: "ActivoFisico",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Auditoria_DirectorId",
                table: "Auditoria",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Auditoria_UsuarioAuditoriaId",
                table: "Auditoria",
                column: "UsuarioAuditoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Auditoria_UsuarioIdUsuario",
                table: "Auditoria",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_backup_Nombre",
                table: "backup",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_backup_UsuarioRegistroId",
                table: "backup",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_EstadoId",
                table: "Categoria",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_Nombre",
                table: "Categoria",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_UsuarioActualizacionId",
                table: "Categoria",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_UsuarioRegistroId",
                table: "Categoria",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleDevolucion_ActivoFisicoId",
                table: "DetalleDevolucion",
                column: "ActivoFisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleDevolucion_DevolucionId",
                table: "DetalleDevolucion",
                column: "DevolucionId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleDevolucion_EstadoDevolucionId",
                table: "DetalleDevolucion",
                column: "EstadoDevolucionId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleEntrada_ActivoId",
                table: "DetalleEntrada",
                column: "ActivoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleEntrada_EntradaId",
                table: "DetalleEntrada",
                column: "EntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMantenimiento_ActivoFisicoId",
                table: "DetalleMantenimiento",
                column: "ActivoFisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMantenimiento_EstadoId",
                table: "DetalleMantenimiento",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMantenimiento_MantenimientoId",
                table: "DetalleMantenimiento",
                column: "MantenimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePrestamo_ActivoFisicoId",
                table: "DetallePrestamo",
                column: "ActivoFisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePrestamo_PrestamoId",
                table: "DetallePrestamo",
                column: "PrestamoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSalida_ActivoFisicoId",
                table: "DetalleSalida",
                column: "ActivoFisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSalida_SalidaId",
                table: "DetalleSalida",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSolicitudMantenimiento_ActivoFisicoId",
                table: "DetalleSolicitudMantenimiento",
                column: "ActivoFisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleSolicitudMantenimiento_SolicitudMantenimientoId",
                table: "DetalleSolicitudMantenimiento",
                column: "SolicitudMantenimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTraslado_ActivoFisicoId",
                table: "DetalleTraslado",
                column: "ActivoFisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTraslado_TrasladoId",
                table: "DetalleTraslado",
                column: "TrasladoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTraslado_UbicacionActualId",
                table: "DetalleTraslado",
                column: "UbicacionActualId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleTraslado_UbicacionFinalId",
                table: "DetalleTraslado",
                column: "UbicacionFinalId");

            migrationBuilder.CreateIndex(
                name: "IX_Devolucion_PrestamoId",
                table: "Devolucion",
                column: "PrestamoId");

            migrationBuilder.CreateIndex(
                name: "IX_Devolucion_UsuarioRegistroId",
                table: "Devolucion",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_EstadoId",
                table: "Director",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_UsuarioActualizacionId",
                table: "Director",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_UsuarioRegistroId",
                table: "Director",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Edificio_CodEdificio",
                table: "Edificio",
                column: "CodEdificio",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Edificio_EstadoId",
                table: "Edificio",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Edificio_UsuarioActualizacionId",
                table: "Edificio",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Edificio_UsuarioRegistroId",
                table: "Edificio",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_NoDocReferencia",
                table: "Entrada",
                column: "NoDocReferencia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_NumEntrada",
                table: "Entrada",
                column: "NumEntrada",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_UsuarioRegistroId",
                table: "Entrada",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_CodCentro",
                table: "Escuela",
                column: "CodCentro",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_Correo",
                table: "Escuela",
                column: "Correo",
                unique: true,
                filter: "[Correo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_Direccion",
                table: "Escuela",
                column: "Direccion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_DirectorId",
                table: "Escuela",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_Nombre",
                table: "Escuela",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_Telefono",
                table: "Escuela",
                column: "Telefono",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_UsuarioActualizacionId",
                table: "Escuela",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Escuela_UsuarioRegistroId",
                table: "Escuela",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_EstadoIdEstado",
                table: "Estado",
                column: "EstadoIdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_Nombre_TipoEstadoId",
                table: "Estado",
                columns: new[] { "Nombre", "TipoEstadoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estado_TipoEstadoId",
                table: "Estado",
                column: "TipoEstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialAcceso_UsuarioId",
                table: "HistorialAcceso",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimiento_EstadoId",
                table: "Mantenimiento",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimiento_PersonalTecnicoId",
                table: "Mantenimiento",
                column: "PersonalTecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimiento_SolicitudMantenimientoId",
                table: "Mantenimiento",
                column: "SolicitudMantenimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimiento_UsuarioRegistroId",
                table: "Mantenimiento",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Marca_EstadoId",
                table: "Marca",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Marca_Nombre",
                table: "Marca",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marca_UsuarioActualizacionId",
                table: "Marca",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Marca_UsuarioRegistroId",
                table: "Marca",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_Nombre",
                table: "Permiso",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Cedula",
                table: "Personal",
                column: "Cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personal_CodPersonal",
                table: "Personal",
                column: "CodPersonal",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Correo",
                table: "Personal",
                column: "Correo",
                unique: true,
                filter: "[Correo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_EstadoId",
                table: "Personal",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_PuestoId",
                table: "Personal",
                column: "PuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Telefono",
                table: "Personal",
                column: "Telefono",
                unique: true,
                filter: "[Telefono] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_UsuarioActualizacionId",
                table: "Personal",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_UsuarioRegistroId",
                table: "Personal",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_EstadoId",
                table: "Prestamo",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_PersonalSolicitanteId",
                table: "Prestamo",
                column: "PersonalSolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_UsuarioRegistroId",
                table: "Prestamo",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_EstadoId",
                table: "Proveedor",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_Nombre",
                table: "Proveedor",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_RNC",
                table: "Proveedor",
                column: "RNC",
                unique: true,
                filter: "[RNC] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_UsuarioActualizacionId",
                table: "Proveedor",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_UsuarioRegistroId",
                table: "Proveedor",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_EstadoId",
                table: "Puesto",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_Nombre",
                table: "Puesto",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_UsuarioActualizacionId",
                table: "Puesto",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Puesto_UsuarioRegistroId",
                table: "Puesto",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_Nombre",
                table: "Rol",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolPermiso_PermisoId",
                table: "RolPermiso",
                column: "PermisoId");

            migrationBuilder.CreateIndex(
                name: "IX_RolPermiso_RolId_PermisoId",
                table: "RolPermiso",
                columns: new[] { "RolId", "PermisoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salida_NumSalida",
                table: "Salida",
                column: "NumSalida",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salida_UsuarioRegistroId",
                table: "Salida",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudMantenimiento_EstadoId",
                table: "SolicitudMantenimiento",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudMantenimiento_UsuarioRegistroId",
                table: "SolicitudMantenimiento",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_CategoriaId",
                table: "SubCategoria",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_EstadoId",
                table: "SubCategoria",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_Nombre",
                table: "SubCategoria",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_UsuarioActualizacionId",
                table: "SubCategoria",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_UsuarioRegistroId",
                table: "SubCategoria",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoEstado_Nombre",
                table: "TipoEstado",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Traslado_AutorizadoPorId",
                table: "Traslado",
                column: "AutorizadoPorId");

            migrationBuilder.CreateIndex(
                name: "IX_Traslado_NoDocAutorizacion",
                table: "Traslado",
                column: "NoDocAutorizacion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Traslado_UsuarioRegistroId",
                table: "Traslado",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_EdificioId",
                table: "Ubicacion",
                column: "EdificioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_EstadoId",
                table: "Ubicacion",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_Nombre",
                table: "Ubicacion",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_UsuarioActualizacionId",
                table: "Ubicacion",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacion_UsuarioRegistroId",
                table: "Ubicacion",
                column: "UsuarioRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Cedula",
                table: "Usuario",
                column: "Cedula",
                unique: true,
                filter: "[Cedula] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ClaveHash",
                table: "Usuario",
                column: "ClaveHash",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Correo",
                table: "Usuario",
                column: "Correo",
                unique: true,
                filter: "[Correo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EstadoId",
                table: "Usuario",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_NombreUsuario",
                table: "Usuario",
                column: "NombreUsuario",
                unique: true,
                filter: "[NombreUsuario] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_RolId",
                table: "Usuario",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Telefono",
                table: "Usuario",
                column: "Telefono",
                unique: true,
                filter: "[Telefono] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UsuarioActualizacionId",
                table: "Usuario",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UsuarioRegistroId",
                table: "Usuario",
                column: "UsuarioRegistroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auditoria");

            migrationBuilder.DropTable(
                name: "backup");

            migrationBuilder.DropTable(
                name: "DetalleDevolucion");

            migrationBuilder.DropTable(
                name: "DetalleMantenimiento");

            migrationBuilder.DropTable(
                name: "DetallePrestamo");

            migrationBuilder.DropTable(
                name: "DetalleSalida");

            migrationBuilder.DropTable(
                name: "DetalleSolicitudMantenimiento");

            migrationBuilder.DropTable(
                name: "DetalleTraslado");

            migrationBuilder.DropTable(
                name: "Escuela");

            migrationBuilder.DropTable(
                name: "HistorialAcceso");

            migrationBuilder.DropTable(
                name: "RolPermiso");

            migrationBuilder.DropTable(
                name: "Devolucion");

            migrationBuilder.DropTable(
                name: "Mantenimiento");

            migrationBuilder.DropTable(
                name: "Salida");

            migrationBuilder.DropTable(
                name: "ActivoFisico");

            migrationBuilder.DropTable(
                name: "Traslado");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "SolicitudMantenimiento");

            migrationBuilder.DropTable(
                name: "DetalleEntrada");

            migrationBuilder.DropTable(
                name: "Ubicacion");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Activo");

            migrationBuilder.DropTable(
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Edificio");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "SubCategoria");

            migrationBuilder.DropTable(
                name: "Puesto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "TipoEstado");
        }
    }
}
