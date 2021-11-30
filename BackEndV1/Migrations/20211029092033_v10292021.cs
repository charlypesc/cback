using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v10292021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(50)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(100)", nullable: false),
                    Rut = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    CorreoElectronico = table.Column<string>(type: "varchar(50)", nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Establecimiento = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cargo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Rbd = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
