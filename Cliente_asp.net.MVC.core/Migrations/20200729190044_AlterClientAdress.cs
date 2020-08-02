using Microsoft.EntityFrameworkCore.Migrations;

namespace Cliente_asp.net.MVC.core.Migrations
{
    public partial class AlterClientAdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StateRegistration",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "MunicipalRegistration",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "Client",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "Client");

            migrationBuilder.AlterColumn<string>(
                name: "StateRegistration",
                table: "Client",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MunicipalRegistration",
                table: "Client",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "Client",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
