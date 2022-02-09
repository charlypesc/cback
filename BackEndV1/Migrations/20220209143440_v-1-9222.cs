using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v19222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListaDoctosDenuncia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Profesional = table.Column<string>(nullable: true),
                    Asunto = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Rbd = table.Column<string>(nullable: true),
                    TipoReunion = table.Column<string>(nullable: true),
                    TipoDoc = table.Column<string>(nullable: true),
                    MyProperty = table.Column<string>(nullable: true),
                    IdPropioDoc = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    DenunciaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaDoctosDenuncia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaDoctosDenuncia_Denuncia_DenunciaId",
                        column: x => x.DenunciaId,
                        principalTable: "Denuncia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaDoctosDenuncia_DenunciaId",
                table: "ListaDoctosDenuncia",
                column: "DenunciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListaDoctosDenuncia");
        }
    }
}
