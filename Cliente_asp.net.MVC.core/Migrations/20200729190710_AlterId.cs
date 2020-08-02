using Microsoft.EntityFrameworkCore.Migrations;

namespace Cliente_asp.net.MVC.core.Migrations
{
    public partial class AlterId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Address_AddresId",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "AddresId",
                table: "Client",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Client_AddresId",
                table: "Client",
                newName: "IX_Client_AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Address_AddressId",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Client",
                newName: "AddresId");

            migrationBuilder.RenameIndex(
                name: "IX_Client_AddressId",
                table: "Client",
                newName: "IX_Client_AddresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Address_AddresId",
                table: "Client",
                column: "AddresId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
