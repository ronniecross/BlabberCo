using Microsoft.EntityFrameworkCore.Migrations;

namespace BlabberCoCRM.Migrations
{
    public partial class RemovedRequirementForPrimaryClientEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrimaryClientEmployeeId",
                table: "Client",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryClientEmployeeId",
                table: "Client");
        }
    }
}
