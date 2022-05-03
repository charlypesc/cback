using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class _2904Seguimiento_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NotaPrograma",
                table: "SeguimientoProg",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeguimientoRbd",
                table: "SeguimientoProg",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotaPrograma",
                table: "SeguimientoProg");

            migrationBuilder.DropColumn(
                name: "SeguimientoRbd",
                table: "SeguimientoProg");
        }
    }
}
