using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndV1.Migrations
{
    public partial class _2904Seguimiento_v3_test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeguimientoRbd",
                table: "SeguimientoProg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeguimientoRbd",
                table: "SeguimientoProg",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
