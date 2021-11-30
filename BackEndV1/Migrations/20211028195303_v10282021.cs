using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v10282021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Curso = table.Column<string>(type: "varchar(100)", nullable: false),
                    Establecimiento = table.Column<string>(type: "varchar(100)", nullable: false),
                    Run = table.Column<string>(type: "varchar(20)", nullable: false),
                    Nacimiento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Comuna = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    ContactoEmergencia = table.Column<string>(nullable: true),
                    TelefonoEmergencia = table.Column<string>(nullable: true),
                    GrupoSanguineo = table.Column<string>(nullable: true),
                    Prevision = table.Column<string>(nullable: true),
                    Alergias = table.Column<string>(nullable: true),
                    MedicamentosContraindicados = table.Column<string>(nullable: true),
                    EnfermedadesCronicas = table.Column<string>(nullable: true),
                    Apoderado = table.Column<string>(type: "varchar(100)", nullable: false),
                    DireccionApoderado = table.Column<string>(type: "varchar(100)", nullable: false),
                    TelefonoApoderado = table.Column<string>(type: "varchar(50)", nullable: false),
                    CorreoApoderado = table.Column<string>(nullable: true),
                    ApoderadoSuplente = table.Column<string>(nullable: true),
                    DireccionApoderadoSuplente = table.Column<string>(nullable: true),
                    TelefonoApoderadoSuplente = table.Column<string>(nullable: true),
                    CorreoApoderadoSuplente = table.Column<string>(nullable: true),
                    Pie = table.Column<bool>(nullable: false),
                    Rbd = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
