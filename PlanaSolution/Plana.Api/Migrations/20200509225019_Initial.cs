using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plana.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    LectPerWeek = table.Column<int>(nullable: false),
                    TotalHours = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    SemesterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.SemesterId);
                });

            migrationBuilder.CreateTable(
                name: "StudyBranches",
                columns: table => new
                {
                    StudyBranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyBranches", x => x.StudyBranchId);
                });

            migrationBuilder.CreateTable(
                name: "ModuleRuns",
                columns: table => new
                {
                    ModuleRunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemesterId = table.Column<int>(nullable: true),
                    ModuleId = table.Column<int>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    ModuleRunRate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleRuns", x => x.ModuleRunId);
                    table.ForeignKey(
                        name: "FK_ModuleRuns_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModuleRuns_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    LecturerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    role = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    WorkingRate = table.Column<double>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: false),
                    ModuleRunId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.LecturerId);
                    table.ForeignKey(
                        name: "FK_Lecturers_ModuleRuns_ModuleRunId",
                        column: x => x.ModuleRunId,
                        principalTable: "ModuleRuns",
                        principalColumn: "ModuleRunId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalAssignments",
                columns: table => new
                {
                    AdditionalAssignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    AAHours = table.Column<double>(nullable: false),
                    LecturerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalAssignments", x => x.AdditionalAssignmentId);
                    table.ForeignKey(
                        name: "FK_AdditionalAssignments_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "LecturerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LecturersModules",
                columns: table => new
                {
                    LecturerId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturersModules", x => new { x.ModuleId, x.LecturerId });
                    table.ForeignKey(
                        name: "FK_LecturersModules_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "LecturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturersModules_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdditionalAssignments",
                columns: new[] { "AdditionalAssignmentId", "AAHours", "LecturerId", "Title" },
                values: new object[,]
                {
                    { 1, 0.0, null, "aF&E geplant" },
                    { 2, 0.0, null, "FB-Pool Abteilung Informatik" }
                });

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "LecturerId", "BirthDate", "Email", "FirstName", "Gender", "IsActive", "LastName", "ModuleRunId", "Password", "PhotoPath", "Token", "WorkingRate", "role" },
                values: new object[,]
                {
                    { 1, new DateTime(1982, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "johnblack@gmx.ch", "John", 0, false, "Black", null, null, "images/john.jpg", null, 0.0, 0 },
                    { 2, new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "manarodriges@gmx.ch", "Mana", 0, false, "Rodriges", null, null, "images/mana.jpg", null, 0.0, 0 },
                    { 3, new DateTime(1983, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "margowhite@gmx.ch", "Margo", 1, false, "White", null, null, "images/margo.jpg", null, 0.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "ModuleId", "Code", "LectPerWeek", "Title", "TotalHours" },
                values: new object[,]
                {
                    { 14, "", 4, "Studienberatung SG I", 200.0 },
                    { 13, "BTW2201", 4, "Datenbanken", 200.0 },
                    { 12, "BTI1311", 4, "Databases (F)", 208.0 },
                    { 11, "BTI1311", 4, "Databases (F)", 208.0 },
                    { 10, "BTX8082", 4, "Software Engineering and Design", 200.0 },
                    { 9, "BTX8081", 6, "Software Engineering and Design", 300.0 },
                    { 8, "BTI7538", 2, "Grundlagen Geoinformationssysteme", 100.0 },
                    { 6, "BTI7293", 8, "Smart Data-Driven Application", 516.0 },
                    { 5, "BTI7321", 0, "Bachelor-Thesis", 0.0 },
                    { 4, "BTI7272", 8, "E-Business and Web", 408.0 },
                    { 3, "BTI7083", 4, "User-Centered Design", 100.0 },
                    { 2, "BTI7302", 1, "Projekt 2", 25.0 },
                    { 1, "BZG1154", 4, "Wahrscheinlichkeitsrechnung und Statistik", 100.0 },
                    { 7, "BTI7512", 2, "Einführung in C#", 109.0 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "SemesterId", "Code", "Date" },
                values: new object[,]
                {
                    { 1, "2020-2021 - FS", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "2021-2022 - HS", new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalAssignments_LecturerId",
                table: "AdditionalAssignments",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturers_ModuleRunId",
                table: "Lecturers",
                column: "ModuleRunId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturersModules_LecturerId",
                table: "LecturersModules",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRuns_ModuleId",
                table: "ModuleRuns",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRuns_SemesterId",
                table: "ModuleRuns",
                column: "SemesterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalAssignments");

            migrationBuilder.DropTable(
                name: "LecturersModules");

            migrationBuilder.DropTable(
                name: "StudyBranches");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "ModuleRuns");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Semesters");
        }
    }
}
