using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalogAPI.Migrations
{
    public partial class Changesincatalogtypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictireUrl",
                table: "Catlog");

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Catlog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Catlog");

            migrationBuilder.AddColumn<string>(
                name: "PictireUrl",
                table: "Catlog",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
