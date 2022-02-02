using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class V13101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProtocoloReg_Reuniones_ReunionesId",
                table: "ProtocoloReg");

            migrationBuilder.DropForeignKey(
                name: "FK_TematicasReg_Reuniones_ReunionesId",
                table: "TematicasReg");

            migrationBuilder.DropIndex(
                name: "IX_TematicasReg_ReunionesId",
                table: "TematicasReg");

            migrationBuilder.DropIndex(
                name: "IX_ProtocoloReg_ReunionesId",
                table: "ProtocoloReg");

            migrationBuilder.DropColumn(
                name: "ReunionesId",
                table: "TematicasReg");

            migrationBuilder.DropColumn(
                name: "ReunionesId",
                table: "ProtocoloReg");

            migrationBuilder.CreateTable(
                name: "ParticipanteManual",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rut = table.Column<string>(nullable: true),
                    NombreParticipante = table.Column<string>(nullable: true),
                    Rbd = table.Column<string>(nullable: true),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    Asunto = table.Column<string>(nullable: true),
                    Activo = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    ReunionesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipanteManual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParticipanteManual_Reuniones_ReunionesId",
                        column: x => x.ReunionesId,
                        principalTable: "Reuniones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParticipanteManual_ReunionesId",
                table: "ParticipanteManual",
                column: "ReunionesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParticipanteManual");

            migrationBuilder.AddColumn<int>(
                name: "ReunionesId",
                table: "TematicasReg",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReunionesId",
                table: "ProtocoloReg",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TematicasReg_ReunionesId",
                table: "TematicasReg",
                column: "ReunionesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocoloReg_ReunionesId",
                table: "ProtocoloReg",
                column: "ReunionesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocoloReg_Reuniones_ReunionesId",
                table: "ProtocoloReg",
                column: "ReunionesId",
                principalTable: "Reuniones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TematicasReg_Reuniones_ReunionesId",
                table: "TematicasReg",
                column: "ReunionesId",
                principalTable: "Reuniones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
