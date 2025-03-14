using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bai3.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productImages_Products_ProductId",
                table: "productImages");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "productImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_productImages_Products_ProductId",
                table: "productImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productImages_Products_ProductId",
                table: "productImages");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "productImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_productImages_Products_ProductId",
                table: "productImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
