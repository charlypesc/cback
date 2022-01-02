using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v122221tematicaReg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroId",
                table: "Tematicas");

            migrationBuilder.DropColumn(
                name: "TipoFormulario",
                table: "Tematicas");

            migrationBuilder.CreateTable(
                name: "TematicasReg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tematica = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Rbd = table.Column<string>(nullable: true),
                    TipoFormulario = table.Column<string>(nullable: true),
                    NumeroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TematicasReg", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TematicasReg");

            migrationBuilder.AddColumn<int>(
                name: "NumeroId",
                table: "Tematicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TipoFormulario",
                table: "Tematicas",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
