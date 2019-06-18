using Microsoft.EntityFrameworkCore.Migrations;

namespace BlabberCoCRM.Migrations
{
    public partial class ProductSubClassIDChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "TangibleProductId",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceProductId",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TangibleProductId",
                table: "Product",
                nullable: true);
        }
    }
}
