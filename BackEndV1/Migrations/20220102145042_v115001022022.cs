using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v115001022022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReunionesId",
                table: "TematicasReg",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReunionesId",
                table: "ProtocoloReg",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReunionesId",
                table: "ParticipanteReg",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reuniones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Profesional = table.Column<string>(type: "varchar(50)", nullable: false),
                    Asunto = table.Column<string>(type: "varchar(100)", nullable: false),
                    Fecha = table.Column<string>(type: "varchar(50)", nullable: false),
                    Rbd = table.Column<string>(type: "varchar(50)", nullable: false),
                    TipoReunion = table.Column<string>(nullable: true),
                    RutAsociado = table.Column<string>(nullable: true),
                    Antecedentes = table.Column<string>(nullable: true),
                    Acuerdos = table.Column<string>(nullable: true),
                    Activo = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reuniones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reuniones_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TematicasReg_ReunionesId",
                table: "TematicasReg",
                column: "ReunionesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtocoloReg_ReunionesId",
                table: "ProtocoloReg",
                column: "ReunionesId");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipanteReg_ReunionesId",
                table: "ParticipanteReg",
                column: "ReunionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Reuniones_UsuarioId",
                table: "Reuniones",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParticipanteReg_Reuniones_ReunionesId",
                table: "ParticipanteReg",
                column: "ReunionesId",
                principalTable: "Reuniones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParticipanteReg_Reuniones_ReunionesId",
                table: "ParticipanteReg");

            migrationBuilder.DropForeignKey(
                name: "FK_ProtocoloReg_Reuniones_ReunionesId",
                table: "ProtocoloReg");

            migrationBuilder.DropForeignKey(
                name: "FK_TematicasReg_Reuniones_ReunionesId",
                table: "TematicasReg");

            migrationBuilder.DropTable(
                name: "Reuniones");

            migrationBuilder.DropIndex(
                name: "IX_TematicasReg_ReunionesId",
                table: "TematicasReg");

            migrationBuilder.DropIndex(
                name: "IX_ProtocoloReg_ReunionesId",
                table: "ProtocoloReg");

            migrationBuilder.DropIndex(
                name: "IX_ParticipanteReg_ReunionesId",
                table: "ParticipanteReg");

            migrationBuilder.DropColumn(
                name: "ReunionesId",
                table: "TematicasReg");

            migrationBuilder.DropColumn(
                name: "ReunionesId",
                table: "ProtocoloReg");

            migrationBuilder.DropColumn(
                name: "ReunionesId",
                table: "ParticipanteReg");
        }
    }
}
