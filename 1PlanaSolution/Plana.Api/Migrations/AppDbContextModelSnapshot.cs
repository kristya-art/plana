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

            modelBuilder.Entity("Plana.Models.AdditionalAssignment", b =>
                {
                    b.Property<int>("AdditionalAssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AAHours")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("Plana.Models.LecturersModuleRuns", b =>
                {
                    b.Property<int>("ModuleRunId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<int>("Lessons")
                        .HasColumnType("int");

                    b.HasKey("ModuleRunId", "LecturerId");

                    b.HasIndex("LecturerId");

                    b.ToTable("LecturersModuleRuns");
                });

            modelBuilder.Entity("Plana.Models.LecturersModules", b =>
                {
                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.HasKey("ModuleId", "LecturerId");

                    b.HasIndex("LecturerId");

                    b.ToTable("LecturersModules");
                });

            modelBuilder.Entity("Plana.Models.LecturersSemesters", b =>
                {
                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.HasKey("SemesterId", "LecturerId");

                    b.HasIndex("LecturerId");

                    b.ToTable("LecturersSemesters");
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.HasKey("ModuleRunId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("SemesterId");

                    b.ToTable("ModuleRuns");
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

                    b.HasKey("SemesterId");

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

            modelBuilder.Entity("Plana.Models.AdditionalAssignment", b =>
                {
                    b.HasOne("Plana.Models.Lecturer", "Lecturer")
                        .WithMany("AdditionalAssignments")
                        .HasForeignKey("LecturerId");

                    b.HasOne("Plana.Models.Semester", "Semester")
                        .WithMany("AdditionalAssignments")
                        .HasForeignKey("SemesterId");
                });

            modelBuilder.Entity("Plana.Models.LecturersModuleRuns", b =>
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

            modelBuilder.Entity("Plana.Models.LecturersModules", b =>
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

            modelBuilder.Entity("Plana.Models.LecturersSemesters", b =>
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
                    b.HasOne("Plana.Models.StudyBranch", "StudyBranch")
                        .WithMany("Modules")
                        .HasForeignKey("StudyBranchId");
                });

            modelBuilder.Entity("Plana.Models.ModuleRun", b =>
                {
                    b.HasOne("Plana.Models.Module", "Module")
                        .WithMany("ModuleRuns")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plana.Models.Semester", "Semester")
                        .WithMany("ModuleRuns")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
