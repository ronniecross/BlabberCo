using Microsoft.EntityFrameworkCore.Migrations;

namespace BlabberCoCRM.Migrations
{
    public partial class ServiceProductSummaryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "ServiceProduct",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summary",
                table: "ServiceProduct");
        }
    }
}
