using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v179484171129211509 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProtocoloReg_Registro_registroId",
                table: "ProtocoloReg");

            migrationBuilder.RenameColumn(
                name: "registroId",
                table: "ProtocoloReg",
                newName: "RegistroId");

            migrationBuilder.RenameColumn(
                name: "protocoloId",
                table: "ProtocoloReg",
                newName: "ProtocoloId");

            migrationBuilder.RenameColumn(
                name: "nombreProtocolo",
                table: "ProtocoloReg",
                newName: "NombreProtocolo");

            migrationBuilder.RenameColumn(
                name: "descripcionProtocolo",
                table: "ProtocoloReg",
                newName: "DescripcionProtocolo");

            migrationBuilder.RenameIndex(
                name: "IX_ProtocoloReg_registroId",
                table: "ProtocoloReg",
                newName: "IX_ProtocoloReg_RegistroId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocoloReg_Registro_RegistroId",
                table: "ProtocoloReg",
                column: "RegistroId",
                principalTable: "Registro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProtocoloReg_Registro_RegistroId",
                table: "ProtocoloReg");

            migrationBuilder.RenameColumn(
                name: "RegistroId",
                table: "ProtocoloReg",
                newName: "registroId");

            migrationBuilder.RenameColumn(
                name: "ProtocoloId",
                table: "ProtocoloReg",
                newName: "protocoloId");

            migrationBuilder.RenameColumn(
                name: "NombreProtocolo",
                table: "ProtocoloReg",
                newName: "nombreProtocolo");

            migrationBuilder.RenameColumn(
                name: "DescripcionProtocolo",
                table: "ProtocoloReg",
                newName: "descripcionProtocolo");

            migrationBuilder.RenameIndex(
                name: "IX_ProtocoloReg_RegistroId",
                table: "ProtocoloReg",
                newName: "IX_ProtocoloReg_registroId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProtocoloReg_Registro_registroId",
                table: "ProtocoloReg",
                column: "registroId",
                principalTable: "Registro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
