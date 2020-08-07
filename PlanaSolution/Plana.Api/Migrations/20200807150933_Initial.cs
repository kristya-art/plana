using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plana.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Role = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    WorkingRate = table.Column<double>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ActiveTill = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.LecturerId);
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
                name: "LecturersSemesters",
                columns: table => new
                {
                    LecturerId = table.Column<int>(nullable: false),
                    SemesterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturersSemesters", x => new { x.SemesterId, x.LecturerId });
                    table.ForeignKey(
                        name: "FK_LecturersSemesters_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "LecturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturersSemesters_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    LectPerWeek = table.Column<int>(nullable: false),
                    TotalHours = table.Column<double>(nullable: false),
                    StudyBranchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                    table.ForeignKey(
                        name: "FK_Modules_StudyBranches_StudyBranchId",
                        column: x => x.StudyBranchId,
                        principalTable: "StudyBranches",
                        principalColumn: "StudyBranchId",
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

            migrationBuilder.CreateTable(
                name: "ModuleRuns",
                columns: table => new
                {
                    ModuleRunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    SemesterId = table.Column<int>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    ModuleRunRate = table.Column<double>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleRuns", x => x.ModuleRunId);
                    table.ForeignKey(
                        name: "FK_ModuleRuns_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuleRuns_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LecturersModuleRuns",
                columns: table => new
                {
                    LecturerId = table.Column<int>(nullable: false),
                    ModuleRunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturersModuleRuns", x => new { x.ModuleRunId, x.LecturerId });
                    table.ForeignKey(
                        name: "FK_LecturersModuleRuns_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "LecturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturersModuleRuns_ModuleRuns_ModuleRunId",
                        column: x => x.ModuleRunId,
                        principalTable: "ModuleRuns",
                        principalColumn: "ModuleRunId",
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
                columns: new[] { "LecturerId", "ActiveTill", "BirthDate", "Email", "FirstName", "Gender", "IsActive", "IsDeleted", "LastName", "Password", "PhotoPath", "Role", "Token", "WorkingRate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "johnblack@gmx.ch", "John", 0, false, false, "Black", null, "images/john.jpg", 0, null, 0.0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "manarodriges@gmx.ch", "Mana", 0, false, false, "Rodriges", null, "images/mana.jpg", 0, null, 0.0 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "manarodriges@gmx.ch", "Manuela", 0, false, true, "Rodriges", null, "images/mana.jpg", 0, null, 0.0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "margowhite@gmx.ch", "Margo", 1, false, false, "White", null, "images/margo.jpg", 0, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "ModuleId", "Code", "LectPerWeek", "StudyBranchId", "Title", "TotalHours" },
                values: new object[,]
                {
                    { 14, "", 4, null, "Studienberatung SG I", 200.0 },
                    { 13, "BTW2201", 4, null, "Datenbanken", 200.0 },
                    { 12, "BTI1311", 4, null, "Databases (F)", 208.0 },
                    { 11, "BTI1311", 4, null, "Databases (F)", 208.0 },
                    { 10, "BTX8082", 4, null, "Software Engineering and Design", 200.0 },
                    { 9, "BTX8081", 6, null, "Software Engineering and Design", 300.0 },
                    { 8, "BTI7538", 2, null, "Grundlagen Geoinformationssysteme", 100.0 },
                    { 5, "BTI7321", 0, null, "Bachelor-Thesis", 0.0 },
                    { 6, "BTI7293", 8, null, "Smart Data-Driven Application", 516.0 },
                    { 4, "BTI7272", 8, null, "E-Business and Web", 408.0 },
                    { 3, "BTI7083", 4, null, "User-Centered Design", 100.0 },
                    { 2, "BTI7302", 1, null, "Projekt 2", 25.0 },
                    { 1, "BZG1154", 4, null, "Wahrscheinlichkeitsrechnung und Statistik", 100.0 },
                    { 7, "BTI7512", 2, null, "Einführung in C#", 109.0 }
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
                name: "IX_LecturersModuleRuns_LecturerId",
                table: "LecturersModuleRuns",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturersModules_LecturerId",
                table: "LecturersModules",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturersSemesters_LecturerId",
                table: "LecturersSemesters",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRuns_ModuleId",
                table: "ModuleRuns",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRuns_SemesterId",
                table: "ModuleRuns",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_StudyBranchId",
                table: "Modules",
                column: "StudyBranchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalAssignments");

            migrationBuilder.DropTable(
                name: "LecturersModuleRuns");

            migrationBuilder.DropTable(
                name: "LecturersModules");

            migrationBuilder.DropTable(
                name: "LecturersSemesters");

            migrationBuilder.DropTable(
                name: "ModuleRuns");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "StudyBranches");
        }
    }
}
