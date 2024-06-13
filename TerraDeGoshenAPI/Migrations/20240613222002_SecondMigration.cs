using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TerraDeGoshenAPI.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_product_id",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_product_id",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "products",
                newName: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_category_id",
                table: "products",
                column: "category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_category_id",
                table: "products",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_category_id",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_category_id",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "products",
                newName: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_product_id",
                table: "products",
                column: "product_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_product_id",
                table: "products",
                column: "product_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
