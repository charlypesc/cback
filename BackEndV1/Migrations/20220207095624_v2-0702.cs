using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v20702 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Denuncia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Profesional = table.Column<string>(nullable: true),
                    Organismo = table.Column<string>(nullable: true),
                    RutAsociado = table.Column<string>(nullable: true),
                    FolioRit = table.Column<string>(nullable: true),
                    FolioInterno = table.Column<int>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    FechaAsignada = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Denuncia", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Denuncia");
        }
    }
}
