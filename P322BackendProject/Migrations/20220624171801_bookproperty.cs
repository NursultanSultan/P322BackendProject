using Microsoft.EntityFrameworkCore.Migrations;

namespace PustokP322.Migrations
{
    public partial class bookproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SalePrice",
                table: "Books",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "CostPrice",
                table: "Books",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SalePrice",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<decimal>(
                name: "CostPrice",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
