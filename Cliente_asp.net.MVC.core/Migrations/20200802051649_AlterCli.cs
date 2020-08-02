using Microsoft.EntityFrameworkCore.Migrations;

namespace Cliente_asp.net.MVC.core.Migrations
{
    public partial class AlterCli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "Client",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
