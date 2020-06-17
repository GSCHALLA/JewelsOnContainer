using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalogAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "catalog_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "catalog_type_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "catlog_brand_hilo",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "CatalogBrands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catlog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PictireUrl = table.Column<string>(nullable: true),
                    CatalogTypeId = table.Column<int>(nullable: false),
                    CatalogBrandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catlog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Catlog_CatalogBrands_CatalogBrandId",
                        column: x => x.CatalogBrandId,
                        principalTable: "CatalogBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Catlog_CatalogTypes_CatalogTypeId",
                        column: x => x.CatalogTypeId,
                        principalTable: "CatalogTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catlog_CatalogBrandId",
                table: "Catlog",
                column: "CatalogBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Catlog_CatalogTypeId",
                table: "Catlog",
                column: "CatalogTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catlog");

            migrationBuilder.DropTable(
                name: "CatalogBrands");

            migrationBuilder.DropTable(
                name: "CatalogTypes");

            migrationBuilder.DropSequence(
                name: "catalog_hilo");

            migrationBuilder.DropSequence(
                name: "catalog_type_hilo");

            migrationBuilder.DropSequence(
                name: "catlog_brand_hilo");
        }
    }
}
