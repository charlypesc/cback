using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v10102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProtocolosReu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreProtocolo = table.Column<string>(nullable: true),
                    DescripcionProtocolo = table.Column<string>(nullable: true),
                    ProtocoloId = table.Column<int>(nullable: false),
                    ReunionesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocolosReu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProtocolosReu_Reuniones_ReunionesId",
                        column: x => x.ReunionesId,
                        principalTable: "Reuniones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TematicasReu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tematica = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Rbd = table.Column<string>(nullable: true),
                    TipoFormulario = table.Column<string>(nullable: true),
                    NumeroId = table.Column<int>(nullable: false),
                    ReunionesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TematicasReu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TematicasReu_Reuniones_ReunionesId",
                        column: x => x.ReunionesId,
                        principalTable: "Reuniones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProtocolosReu_ReunionesId",
                table: "ProtocolosReu",
                column: "ReunionesId");

            migrationBuilder.CreateIndex(
                name: "IX_TematicasReu_ReunionesId",
                table: "TematicasReu",
                column: "ReunionesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProtocolosReu");

            migrationBuilder.DropTable(
                name: "TematicasReu");
        }
    }
}
