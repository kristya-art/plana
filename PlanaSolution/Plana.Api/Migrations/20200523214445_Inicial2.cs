using Microsoft.EntityFrameworkCore.Migrations;

namespace Plana.Api.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role",
                table: "Lecturers",
                newName: "Role");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Lecturers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Lecturers",
                newName: "role");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Lecturers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
