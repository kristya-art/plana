using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plana.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LecturerGroups",
                columns: table => new
                {
                    LecturerGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LecturerGroupId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturerGroups", x => x.LecturerGroupId);
                    table.ForeignKey(
                        name: "FK_LecturerGroups_LecturerGroups_LecturerGroupId1",
                        column: x => x.LecturerGroupId1,
                        principalTable: "LecturerGroups",
                        principalColumn: "LecturerGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    PhotoPath = table.Column<string>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModuleGroups",
                columns: table => new
                {
                    ModuleGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleGroups", x => x.ModuleGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    SemesterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
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
                    Title = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyBranches", x => x.StudyBranchId);
                });

            migrationBuilder.CreateTable(
                name: "LecturerLecturerGroups",
                columns: table => new
                {
                    LecturerId = table.Column<int>(nullable: false),
                    LecturerGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturerLecturerGroups", x => new { x.LecturerId, x.LecturerGroupId });
                    table.ForeignKey(
                        name: "FK_LecturerLecturerGroups_LecturerGroups_LecturerGroupId",
                        column: x => x.LecturerGroupId,
                        principalTable: "LecturerGroups",
                        principalColumn: "LecturerGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturerLecturerGroups_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LecturerGroupModuleGroups",
                columns: table => new
                {
                    LecturerGroupId = table.Column<int>(nullable: false),
                    ModuleGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturerGroupModuleGroups", x => new { x.LecturerGroupId, x.ModuleGroupId });
                    table.ForeignKey(
                        name: "FK_LecturerGroupModuleGroups_LecturerGroups_LecturerGroupId",
                        column: x => x.LecturerGroupId,
                        principalTable: "LecturerGroups",
                        principalColumn: "LecturerGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturerGroupModuleGroups_ModuleGroups_ModuleGroupId",
                        column: x => x.ModuleGroupId,
                        principalTable: "ModuleGroups",
                        principalColumn: "ModuleGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LecturerModuleGroups",
                columns: table => new
                {
                    LecturerId = table.Column<int>(nullable: false),
                    ModuleGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturerModuleGroups", x => new { x.LecturerId, x.ModuleGroupId });
                    table.ForeignKey(
                        name: "FK_LecturerModuleGroups_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturerModuleGroups_ModuleGroups_ModuleGroupId",
                        column: x => x.ModuleGroupId,
                        principalTable: "ModuleGroups",
                        principalColumn: "ModuleGroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalAssignments",
                columns: table => new
                {
                    AdditionalAssignmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AAHours = table.Column<double>(nullable: false),
                    LecturerId = table.Column<int>(nullable: true),
                    SemesterId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    AACategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalAssignments", x => x.AdditionalAssignmentId);
                    table.ForeignKey(
                        name: "FK_AdditionalAssignments_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdditionalAssignments_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LecturerSemesters",
                columns: table => new
                {
                    LecturerId = table.Column<int>(nullable: false),
                    SemesterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturerSemesters", x => new { x.SemesterId, x.LecturerId });
                    table.ForeignKey(
                        name: "FK_LecturerSemesters_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturerSemesters_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsFixed = table.Column<bool>(nullable: false),
                    IsModifyable = table.Column<bool>(nullable: false),
                    Year = table.Column<string>(nullable: true),
                    ExpiredDate = table.Column<string>(nullable: true),
                    OfficialPublishDate = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    AutumnSemesterId = table.Column<int>(nullable: true),
                    SpringSemesterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plans_Semesters_AutumnSemesterId",
                        column: x => x.AutumnSemesterId,
                        principalTable: "Semesters",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plans_Semesters_SpringSemesterId",
                        column: x => x.SpringSemesterId,
                        principalTable: "Semesters",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Restrict);
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
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
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
                name: "PlanLecturers",
                columns: table => new
                {
                    LecturerId = table.Column<int>(nullable: false),
                    PlanId = table.Column<int>(nullable: false),
                    AnnualTarget = table.Column<int>(nullable: false),
                    BalanceActual = table.Column<int>(nullable: false),
                    BalanceLastYear = table.Column<int>(nullable: false),
                    BalanceAccumulated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanLecturers", x => new { x.PlanId, x.LecturerId });
                    table.ForeignKey(
                        name: "FK_PlanLecturers_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanLecturers_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
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
                    Place = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Editable = table.Column<bool>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    SemesterId = table.Column<int>(nullable: false),
                    ModuleGroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleRuns", x => x.ModuleRunId);
                    table.ForeignKey(
                        name: "FK_ModuleRuns_ModuleGroups_ModuleGroupId",
                        column: x => x.ModuleGroupId,
                        principalTable: "ModuleGroups",
                        principalColumn: "ModuleGroupId",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LecturersModuleRuns",
                columns: table => new
                {
                    LecturerId = table.Column<int>(nullable: false),
                    ModuleRunId = table.Column<int>(nullable: false),
                    Lessons = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturersModuleRuns", x => new { x.ModuleRunId, x.LecturerId });
                    table.ForeignKey(
                        name: "FK_LecturersModuleRuns_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturersModuleRuns_ModuleRuns_ModuleRunId",
                        column: x => x.ModuleRunId,
                        principalTable: "ModuleRuns",
                        principalColumn: "ModuleRunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalAssignments_LecturerId",
                table: "AdditionalAssignments",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalAssignments_SemesterId",
                table: "AdditionalAssignments",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturerGroupModuleGroups_ModuleGroupId",
                table: "LecturerGroupModuleGroups",
                column: "ModuleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturerGroups_LecturerGroupId1",
                table: "LecturerGroups",
                column: "LecturerGroupId1");

            migrationBuilder.CreateIndex(
                name: "IX_LecturerLecturerGroups_LecturerGroupId",
                table: "LecturerLecturerGroups",
                column: "LecturerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturerModuleGroups_ModuleGroupId",
                table: "LecturerModuleGroups",
                column: "ModuleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturerSemesters_LecturerId",
                table: "LecturerSemesters",
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
                name: "IX_ModuleRuns_ModuleGroupId",
                table: "ModuleRuns",
                column: "ModuleGroupId");

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

            migrationBuilder.CreateIndex(
                name: "IX_PlanLecturers_LecturerId",
                table: "PlanLecturers",
                column: "LecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_AutumnSemesterId",
                table: "Plans",
                column: "AutumnSemesterId",
                unique: true,
                filter: "[AutumnSemesterId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_SpringSemesterId",
                table: "Plans",
                column: "SpringSemesterId",
                unique: true,
                filter: "[SpringSemesterId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalAssignments");

            migrationBuilder.DropTable(
                name: "LecturerGroupModuleGroups");

            migrationBuilder.DropTable(
                name: "LecturerLecturerGroups");

            migrationBuilder.DropTable(
                name: "LecturerModuleGroups");

            migrationBuilder.DropTable(
                name: "LecturerSemesters");

            migrationBuilder.DropTable(
                name: "LecturersModuleRuns");

            migrationBuilder.DropTable(
                name: "LecturersModules");

            migrationBuilder.DropTable(
                name: "PlanLecturers");

            migrationBuilder.DropTable(
                name: "LecturerGroups");

            migrationBuilder.DropTable(
                name: "ModuleRuns");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "ModuleGroups");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "StudyBranches");
        }
    }
}
