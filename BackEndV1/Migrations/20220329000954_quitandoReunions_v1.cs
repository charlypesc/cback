using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class quitandoReunions_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParticipanteReg_Reuniones_ReunionesId",
                table: "ParticipanteReg");

            migrationBuilder.DropIndex(
                name: "IX_ParticipanteReg_ReunionesId",
                table: "ParticipanteReg");

            migrationBuilder.DropColumn(
                name: "ReunionesId",
                table: "ParticipanteReg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReunionesId",
                table: "ParticipanteReg",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ParticipanteReg_ReunionesId",
                table: "ParticipanteReg",
                column: "ReunionesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParticipanteReg_Reuniones_ReunionesId",
                table: "ParticipanteReg",
                column: "ReunionesId",
                principalTable: "Reuniones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
