using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v2604seguimientosprogramas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreadoPor = table.Column<string>(nullable: true),
                    fechaCreacionPrograma = table.Column<DateTime>(nullable: false),
                    NombrePrograma = table.Column<string>(nullable: true),
                    DescripcionPrograma = table.Column<string>(nullable: true),
                    Activo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seguimiento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rutEstudiante = table.Column<string>(nullable: true),
                    FechaInicioSeguimiento = table.Column<DateTime>(nullable: false),
                    FechaFinSeguimiento = table.Column<DateTime>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    Activo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeguimientoProg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePrograma = table.Column<string>(nullable: true),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    FechaEgreso = table.Column<DateTime>(nullable: false),
                    Activo = table.Column<int>(nullable: false),
                    SeguimientoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguimientoProg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeguimientoProg_Seguimiento_SeguimientoId",
                        column: x => x.SeguimientoId,
                        principalTable: "Seguimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeguimientoProg_SeguimientoId",
                table: "SeguimientoProg",
                column: "SeguimientoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programa");

            migrationBuilder.DropTable(
                name: "SeguimientoProg");

            migrationBuilder.DropTable(
                name: "Seguimiento");
        }
    }
}
