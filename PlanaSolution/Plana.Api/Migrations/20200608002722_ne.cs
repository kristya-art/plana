using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plana.Api.Migrations
{
    public partial class ne : Migration
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Lecturers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "LecturerId", "BirthDate", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "LastName", "ModuleRunId", "Password", "PhotoPath", "Role", "Token", "WorkingRate" },
                values: new object[] { 22, new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "manarodriges@gmx.ch", "Manuela", 0, false, true, "Rodriges", null, null, "images/mana.jpg", 0, null, 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "LecturerId",
                keyValue: 22);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Lecturers");

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
