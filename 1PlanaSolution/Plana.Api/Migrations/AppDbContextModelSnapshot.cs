﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plana.Api.Models;

namespace Plana.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Plana.Api.Models.ModuleRunLecturerGroup", b =>
                {
                    b.Property<int>("ModuleRunId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerGroupId")
                        .HasColumnType("int");

                    b.HasKey("ModuleRunId", "LecturerGroupId");

                    b.HasIndex("LecturerGroupId");

                    b.ToTable("ModuleRunLecturerGroups");
                });

            modelBuilder.Entity("Plana.Models.AdditionalAssignment", b =>
                {
                    b.Property<int>("AdditionalAssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AACategory")
                        .HasColumnType("int");

                    b.Property<double>("AAHours")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int?>("SemesterId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdditionalAssignmentId");

                    b.HasIndex("LecturerId");

                    b.HasIndex("SemesterId");

                    b.ToTable("AdditionalAssignments");
                });

            modelBuilder.Entity("Plana.Models.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActiveTill")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WorkingRate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("Plana.Models.LecturerGroup", b =>
                {
                    b.Property<int>("LecturerGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LecturerGroupId1")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LecturerGroupId");

                    b.HasIndex("LecturerGroupId1");

                    b.ToTable("LecturerGroups");
                });

            modelBuilder.Entity("Plana.Models.LecturerGroupModuleGroup", b =>
                {
                    b.Property<int>("LecturerGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ModuleGroupId")
                        .HasColumnType("int");

                    b.HasKey("LecturerGroupId", "ModuleGroupId");

                    b.HasIndex("ModuleGroupId");

                    b.ToTable("LecturerGroupModuleGroups");
                });

            modelBuilder.Entity("Plana.Models.LecturerLecturerGroup", b =>
                {
                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerGroupId")
                        .HasColumnType("int");

                    b.HasKey("LecturerId", "LecturerGroupId");

                    b.HasIndex("LecturerGroupId");

                    b.ToTable("LecturerLecturerGroups");
                });

            modelBuilder.Entity("Plana.Models.LecturerModule", b =>
                {
                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.HasKey("ModuleId", "LecturerId");

                    b.HasIndex("LecturerId");

                    b.ToTable("LecturersModules");
                });

            modelBuilder.Entity("Plana.Models.LecturerModuleGroup", b =>
                {
                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int>("ModuleGroupId")
                        .HasColumnType("int");

                    b.HasKey("LecturerId", "ModuleGroupId");

                    b.HasIndex("ModuleGroupId");

                    b.ToTable("LecturerModuleGroups");
                });

            modelBuilder.Entity("Plana.Models.LecturerModuleRun", b =>
                {
                    b.Property<int>("ModuleRunId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<int>("Lessons")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleRunId", "LecturerId");

                    b.HasIndex("LecturerId");

                    b.ToTable("LecturersModuleRuns");
                });

            modelBuilder.Entity("Plana.Models.LecturerSemester", b =>
                {
                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.HasKey("SemesterId", "LecturerId");

                    b.HasIndex("LecturerId");

                    b.ToTable("LecturerSemesters");
                });

            modelBuilder.Entity("Plana.Models.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LectPerWeek")
                        .HasColumnType("int");

                    b.Property<int?>("StudyBranchId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalHours")
                        .HasColumnType("float");

                    b.HasKey("ModuleId");

                    b.HasIndex("StudyBranchId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("Plana.Models.ModuleGroup", b =>
                {
                    b.Property<int>("ModuleGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleGroupId");

                    b.ToTable("ModuleGroups");
                });

            modelBuilder.Entity("Plana.Models.ModuleRun", b =>
                {
                    b.Property<int>("ModuleRunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Editable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModuleGroupId")
                        .HasColumnType("int");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.HasKey("ModuleRunId");

                    b.HasIndex("ModuleGroupId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("SemesterId");

                    b.ToTable("ModuleRuns");
                });

            modelBuilder.Entity("Plana.Models.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExpiredDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFixed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsModifyable")
                        .HasColumnType("bit");

                    b.Property<string>("OfficialPublishDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("Plana.Models.PlanLecturer", b =>
                {
                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int>("AnnualTarget")
                        .HasColumnType("int");

                    b.Property<int>("BalanceAccumulated")
                        .HasColumnType("int");

                    b.Property<int>("BalanceActual")
                        .HasColumnType("int");

                    b.Property<int>("BalanceLastYear")
                        .HasColumnType("int");

                    b.HasKey("PlanId", "LecturerId");

                    b.HasIndex("LecturerId");

                    b.ToTable("PlanLecturers");
                });

            modelBuilder.Entity("Plana.Models.Semester", b =>
                {
                    b.Property<int>("SemesterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("PlanId")
                        .HasColumnType("int");

                    b.HasKey("SemesterId");

                    b.HasIndex("PlanId");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("Plana.Models.StudyBranch", b =>
                {
                    b.Property<int>("StudyBranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudyBranchId");

                    b.ToTable("StudyBranches");
                });

            modelBuilder.Entity("Plana.Api.Models.ModuleRunLecturerGroup", b =>
                {
                    b.HasOne("Plana.Models.LecturerGroup", "LecturerGroup")
                        .WithMany("ModuleRunLecturerGroups")
                        .HasForeignKey("LecturerGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.ModuleRun", "ModuleRun")
                        .WithMany("ModuleRunLecturerGroups")
                        .HasForeignKey("ModuleRunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plana.Models.AdditionalAssignment", b =>
                {
                    b.HasOne("Plana.Models.Lecturer", null)
                        .WithMany("AdditionalAssignments")
                        .HasForeignKey("LecturerId");

                    b.HasOne("Plana.Models.Semester", null)
                        .WithMany("AdditionalAssignments")
                        .HasForeignKey("SemesterId");
                });

            modelBuilder.Entity("Plana.Models.LecturerGroup", b =>
                {
                    b.HasOne("Plana.Models.LecturerGroup", null)
                        .WithMany("LecturerSubGroups")
                        .HasForeignKey("LecturerGroupId1");
                });

            modelBuilder.Entity("Plana.Models.LecturerGroupModuleGroup", b =>
                {
                    b.HasOne("Plana.Models.LecturerGroup", "LecturerGroup")
                        .WithMany("LecturerGroupModuleGroup")
                        .HasForeignKey("LecturerGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.ModuleGroup", "ModuleGroup")
                        .WithMany("LecturerGroupModuleGroup")
                        .HasForeignKey("ModuleGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plana.Models.LecturerLecturerGroup", b =>
                {
                    b.HasOne("Plana.Models.LecturerGroup", "LecturerGroup")
                        .WithMany("LecturerLecturerGroup")
                        .HasForeignKey("LecturerGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.Lecturer", "Lecturer")
                        .WithMany("LecturerLecturerGroup")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plana.Models.LecturerModule", b =>
                {
                    b.HasOne("Plana.Models.Lecturer", "Lecturer")
                        .WithMany("LecturersModules")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.Module", "Module")
                        .WithMany("Lecturers")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plana.Models.LecturerModuleGroup", b =>
                {
                    b.HasOne("Plana.Models.Lecturer", "Lecturer")
                        .WithMany("LecturerModuleGroup")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.ModuleGroup", "ModuleGroup")
                        .WithMany("LecturerModuleGroup")
                        .HasForeignKey("ModuleGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plana.Models.LecturerModuleRun", b =>
                {
                    b.HasOne("Plana.Models.Lecturer", "Lecturer")
                        .WithMany("LecturersModuleRuns")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.ModuleRun", "ModuleRun")
                        .WithMany("LecturersMR")
                        .HasForeignKey("ModuleRunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plana.Models.LecturerSemester", b =>
                {
                    b.HasOne("Plana.Models.Lecturer", "Lecturer")
                        .WithMany("LecturersSemesters")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.Semester", "Semester")
                        .WithMany("LecturersSemesters")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plana.Models.Module", b =>
                {
                    b.HasOne("Plana.Models.StudyBranch", null)
                        .WithMany("Modules")
                        .HasForeignKey("StudyBranchId");
                });

            modelBuilder.Entity("Plana.Models.ModuleRun", b =>
                {
                    b.HasOne("Plana.Models.ModuleGroup", "ModuleGroup")
                        .WithMany("ModuleRuns")
                        .HasForeignKey("ModuleGroupId");

                    b.HasOne("Plana.Models.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.Semester", null)
                        .WithMany("ModuleRuns")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plana.Models.PlanLecturer", b =>
                {
                    b.HasOne("Plana.Models.Lecturer", "Lecturer")
                        .WithMany("PlanLecturers")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.Plan", "Plan")
                        .WithMany("PlanLecturers")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Plana.Models.Semester", b =>
                {
                    b.HasOne("Plana.Models.Plan", null)
                        .WithMany("Semesters")
                        .HasForeignKey("PlanId");
                });
#pragma warning restore 612, 618
        }
    }
}
