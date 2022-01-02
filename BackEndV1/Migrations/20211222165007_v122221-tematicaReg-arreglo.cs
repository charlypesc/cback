using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v122221tematicaRegarreglo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegistroId",
                table: "TematicasReg",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TematicasReg_RegistroId",
                table: "TematicasReg",
                column: "RegistroId");

            migrationBuilder.AddForeignKey(
                name: "FK_TematicasReg_Registro_RegistroId",
                table: "TematicasReg",
                column: "RegistroId",
                principalTable: "Registro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TematicasReg_Registro_RegistroId",
                table: "TematicasReg");

            migrationBuilder.DropIndex(
                name: "IX_TematicasReg_RegistroId",
                table: "TematicasReg");

            migrationBuilder.DropColumn(
                name: "RegistroId",
                table: "TematicasReg");
        }
    }
}
