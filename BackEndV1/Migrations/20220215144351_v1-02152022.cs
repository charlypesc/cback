using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v102152022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Activo",
                table: "Estudiante",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Estudiante");
        }
    }
}
