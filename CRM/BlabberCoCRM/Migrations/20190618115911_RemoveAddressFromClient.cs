using Microsoft.EntityFrameworkCore.Migrations;

namespace BlabberCoCRM.Migrations
{
    public partial class RemoveAddressFromClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Address_AddressID",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_AddressID",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Client");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "Client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Client_AddressID",
                table: "Client",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Address_AddressID",
                table: "Client",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
