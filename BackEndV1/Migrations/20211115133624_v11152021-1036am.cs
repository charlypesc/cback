using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v111520211036am : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Registro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Registro_UsuarioId",
                table: "Registro",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registro_Usuario_UsuarioId",
                table: "Registro",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registro_Usuario_UsuarioId",
                table: "Registro");

            migrationBuilder.DropIndex(
                name: "IX_Registro_UsuarioId",
                table: "Registro");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Registro");
        }
    }
}
