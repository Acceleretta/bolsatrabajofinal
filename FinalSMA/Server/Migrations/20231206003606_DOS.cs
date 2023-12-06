using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BolsaTrabajoSMA.Server.Migrations
{
    /// <inheritdoc />
    public partial class DOS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "beneficios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beneficio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beneficios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ap_Paterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ap_Materno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colonia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resumen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "escolaridades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_escolaridades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "experienciaRequeridas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Experiencia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experienciaRequeridas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuncionesPuesto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Funcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionesPuesto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Habilidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "listaPaises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listaPaises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "moda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    moda = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nombrePuestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePuest = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nombrePuestos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "responsabilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Respon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responsabilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sueldo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sueldos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sueldo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipoContrataciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoContrataciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "formaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Escuela = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_formaciones_empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historialLaboral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puesto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tareas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historialLaboral", x => x.Id);
                    table.ForeignKey(
                        name: "FK_historialLaboral_empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vacantees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePuest = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sueldo = table.Column<float>(type: "real", nullable: false),
                    Lugar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Coordenadas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModalidadId = table.Column<int>(type: "int", nullable: false),
                    NivelEscolaridadId = table.Column<int>(type: "int", nullable: false),
                    TipoContratacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacantees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vacantees_escolaridades_NivelEscolaridadId",
                        column: x => x.NivelEscolaridadId,
                        principalTable: "escolaridades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vacantees_moda_ModalidadId",
                        column: x => x.ModalidadId,
                        principalTable: "moda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vacantees_tipoContrataciones_TipoContratacionId",
                        column: x => x.TipoContratacionId,
                        principalTable: "tipoContrataciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "beneficiosVacantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacanteId = table.Column<int>(type: "int", nullable: false),
                    BeneficioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beneficiosVacantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_beneficiosVacantes_beneficios_BeneficioId",
                        column: x => x.BeneficioId,
                        principalTable: "beneficios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_beneficiosVacantes_vacantees_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "vacantees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "experienciaVacantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacanteId = table.Column<int>(type: "int", nullable: false),
                    ExperienciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experienciaVacantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_experienciaVacantes_experienciaRequeridas_ExperienciaId",
                        column: x => x.ExperienciaId,
                        principalTable: "experienciaRequeridas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_experienciaVacantes_vacantees_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "vacantees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "funcionesVacantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacanteId = table.Column<int>(type: "int", nullable: false),
                    FuncionesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionesVacantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_funcionesVacantes_FuncionesPuesto_FuncionesId",
                        column: x => x.FuncionesId,
                        principalTable: "FuncionesPuesto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_funcionesVacantes_vacantees_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "vacantees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "habilidadesVacantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacanteId = table.Column<int>(type: "int", nullable: false),
                    HabilidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_habilidadesVacantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_habilidadesVacantes_habilidades_HabilidadId",
                        column: x => x.HabilidadId,
                        principalTable: "habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_habilidadesVacantes_vacantees_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "vacantees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nombrePuestoVacantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacanteId = table.Column<int>(type: "int", nullable: false),
                    NombrePuestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nombrePuestoVacantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nombrePuestoVacantes_nombrePuestos_NombrePuestId",
                        column: x => x.NombrePuestId,
                        principalTable: "nombrePuestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nombrePuestoVacantes_vacantees_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "vacantees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "responsabilidadesVacantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacanteId = table.Column<int>(type: "int", nullable: false),
                    ResponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responsabilidadesVacantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_responsabilidadesVacantes_responsabilidades_ResponId",
                        column: x => x.ResponId,
                        principalTable: "responsabilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_responsabilidadesVacantes_vacantees_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "vacantees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sueldoVacantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacanteId = table.Column<int>(type: "int", nullable: false),
                    SueldoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sueldoVacantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sueldoVacantes_Sueldo_SueldoId",
                        column: x => x.SueldoId,
                        principalTable: "Sueldo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sueldoVacantes_vacantees_VacanteId",
                        column: x => x.VacanteId,
                        principalTable: "vacantees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_beneficiosVacantes_BeneficioId",
                table: "beneficiosVacantes",
                column: "BeneficioId");

            migrationBuilder.CreateIndex(
                name: "IX_beneficiosVacantes_VacanteId",
                table: "beneficiosVacantes",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_experienciaVacantes_ExperienciaId",
                table: "experienciaVacantes",
                column: "ExperienciaId");

            migrationBuilder.CreateIndex(
                name: "IX_experienciaVacantes_VacanteId",
                table: "experienciaVacantes",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_formaciones_EmpleadoId",
                table: "formaciones",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_funcionesVacantes_FuncionesId",
                table: "funcionesVacantes",
                column: "FuncionesId");

            migrationBuilder.CreateIndex(
                name: "IX_funcionesVacantes_VacanteId",
                table: "funcionesVacantes",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_habilidadesVacantes_HabilidadId",
                table: "habilidadesVacantes",
                column: "HabilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_habilidadesVacantes_VacanteId",
                table: "habilidadesVacantes",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_historialLaboral_EmpleadoId",
                table: "historialLaboral",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_nombrePuestoVacantes_NombrePuestId",
                table: "nombrePuestoVacantes",
                column: "NombrePuestId");

            migrationBuilder.CreateIndex(
                name: "IX_nombrePuestoVacantes_VacanteId",
                table: "nombrePuestoVacantes",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_responsabilidadesVacantes_ResponId",
                table: "responsabilidadesVacantes",
                column: "ResponId");

            migrationBuilder.CreateIndex(
                name: "IX_responsabilidadesVacantes_VacanteId",
                table: "responsabilidadesVacantes",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_sueldoVacantes_SueldoId",
                table: "sueldoVacantes",
                column: "SueldoId");

            migrationBuilder.CreateIndex(
                name: "IX_sueldoVacantes_VacanteId",
                table: "sueldoVacantes",
                column: "VacanteId");

            migrationBuilder.CreateIndex(
                name: "IX_vacantees_ModalidadId",
                table: "vacantees",
                column: "ModalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_vacantees_NivelEscolaridadId",
                table: "vacantees",
                column: "NivelEscolaridadId");

            migrationBuilder.CreateIndex(
                name: "IX_vacantees_TipoContratacionId",
                table: "vacantees",
                column: "TipoContratacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "beneficiosVacantes");

            migrationBuilder.DropTable(
                name: "experienciaVacantes");

            migrationBuilder.DropTable(
                name: "formaciones");

            migrationBuilder.DropTable(
                name: "funcionesVacantes");

            migrationBuilder.DropTable(
                name: "habilidadesVacantes");

            migrationBuilder.DropTable(
                name: "historialLaboral");

            migrationBuilder.DropTable(
                name: "listaPaises");

            migrationBuilder.DropTable(
                name: "nombrePuestoVacantes");

            migrationBuilder.DropTable(
                name: "responsabilidadesVacantes");

            migrationBuilder.DropTable(
                name: "sueldoVacantes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "beneficios");

            migrationBuilder.DropTable(
                name: "experienciaRequeridas");

            migrationBuilder.DropTable(
                name: "FuncionesPuesto");

            migrationBuilder.DropTable(
                name: "habilidades");

            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "nombrePuestos");

            migrationBuilder.DropTable(
                name: "responsabilidades");

            migrationBuilder.DropTable(
                name: "Sueldo");

            migrationBuilder.DropTable(
                name: "vacantees");

            migrationBuilder.DropTable(
                name: "escolaridades");

            migrationBuilder.DropTable(
                name: "moda");

            migrationBuilder.DropTable(
                name: "tipoContrataciones");
        }
    }
}
