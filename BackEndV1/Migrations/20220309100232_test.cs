using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Prueba",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Activo",
                table: "Funcionario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Activo",
                table: "Estudiante",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumeroLista",
                table: "Estudiante",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Activo",
                table: "Establecimiento",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prueba",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "NumeroLista",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Establecimiento");
        }
    }
}
