using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class v12152021v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RbdRbd",
                table: "Registro");

            migrationBuilder.AddColumn<string>(
                name: "Rbd",
                table: "Registro",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rbd",
                table: "Registro");

            migrationBuilder.AddColumn<string>(
                name: "RbdRbd",
                table: "Registro",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
