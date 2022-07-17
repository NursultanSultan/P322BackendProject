using Microsoft.EntityFrameworkCore.Migrations;

namespace PustokP322.Migrations
{
    public partial class BookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.AddColumn<decimal>(
                name: "CostPrice",
                table: "Books",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DiscountPercent",
                table: "Books",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Books",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "Books",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "SalePrice",
                table: "Books",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostPrice",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "DiscountPercent",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Books");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
