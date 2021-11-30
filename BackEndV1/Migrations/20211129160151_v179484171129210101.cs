using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v179484171129210101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProtocoloReg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombreProtocolo = table.Column<string>(nullable: true),
                    descripcionProtocolo = table.Column<string>(nullable: true),
                    protocoloId = table.Column<int>(nullable: false),
                    registroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtocoloReg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProtocoloReg_Registro_registroId",
                        column: x => x.registroId,
                        principalTable: "Registro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProtocoloReg_registroId",
                table: "ProtocoloReg",
                column: "registroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProtocoloReg");
        }
    }
}
