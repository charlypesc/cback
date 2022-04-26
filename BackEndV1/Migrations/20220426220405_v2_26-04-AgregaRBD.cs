using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v2_2604AgregaRBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rbd",
                table: "SeguimientoProg",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rbd",
                table: "Seguimiento",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rbd",
                table: "Programa",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rbd",
                table: "SeguimientoProg");

            migrationBuilder.DropColumn(
                name: "Rbd",
                table: "Seguimiento");

            migrationBuilder.DropColumn(
                name: "Rbd",
                table: "Programa");
        }
    }
}
