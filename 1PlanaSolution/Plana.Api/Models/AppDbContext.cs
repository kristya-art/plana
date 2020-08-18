using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Plana.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
             base(options)
        { }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleRun> ModuleRuns { get; set; }
        public DbSet<AdditionalAssignment> AdditionalAssignments { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<StudyBranch> StudyBranches { get; set; }
      //  public DbSet<LecturersModules> lecturersModules { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecturer>().HasQueryFilter(p => !p.IsDeleted);

            base.OnModelCreating(modelBuilder);
            //seeed module table
            modelBuilder.Entity<Module>().HasData(
                new Module { ModuleId = 1,Title= "Wahrscheinlichkeitsrechnung und Statistik", Code = "BZG1154",
                ECTS=6, LectPerWeek=4, TotalHours=100}
            );
            base.OnModelCreating(modelBuilder);
            //seeed module table
            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    ModuleId = 2,
                    Title = "Projekt 2",
                    Code = "BTI7302",
                    ECTS = 4,
                    LectPerWeek = 1,
                    TotalHours = 25
                }
            );
            base.OnModelCreating(modelBuilder);
            //seeed module table
            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    ModuleId = 3,
                    Title = "User-Centered Design",
                    Code = "BTI7083",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 100
                }
            );
            base.OnModelCreating(modelBuilder);
            //seeed module table
            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    ModuleId = 4,
                    Title = "E-Business and Web",
                    Code = "BTI7272",
                    ECTS = 8,
                    LectPerWeek = 8,
                    TotalHours = 408
                }
            );
            base.OnModelCreating(modelBuilder);
            //seeed module table
            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    ModuleId = 5,
                    Title = "Bachelor-Thesis",
                    Code = "BTI7321",
                    ECTS = 12,
                    LectPerWeek = 0,
                    TotalHours = 0
                }
            );
            base.OnModelCreating(modelBuilder);
            //seeed module table
            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    ModuleId = 6,
                    Title = "Smart Data-Driven Application",
                    Code = "BTI7293",
                    ECTS = 8,
                    LectPerWeek = 8,
                    TotalHours = 516
                }
            );
            base.OnModelCreating(modelBuilder);
            //seeed module table
            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    ModuleId = 7,
                    Title = "Einführung in C#",
                    Code = "BTI7512",
                    ECTS = 2,
                    LectPerWeek = 2,
                    TotalHours = 109
                }
            );
           
                 base.OnModelCreating(modelBuilder);
            //seeed module table
            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    ModuleId = 8,
                    Title = "Grundlagen Geoinformationssysteme",
                    Code = "BTI7538",
                    ECTS = 2,
                    LectPerWeek = 2,
                    TotalHours = 100
                }
            );
            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    ModuleId = 9,
                    Title = "Software Engineering and Design",
                    Code = "BTX8081",
                    ECTS = 8,
                    LectPerWeek = 6,
                    TotalHours = 300
                }
            );
            modelBuilder.Entity<Module>().HasData(
               new Module
               {
                   ModuleId = 10,
                   Title = "Software Engineering and Design",
                   Code = "BTX8082",
                   ECTS = 4,
                   LectPerWeek = 4,
                   TotalHours = 200
               }
           );
            modelBuilder.Entity<Module>().HasData(
              new Module
              {
                  ModuleId = 11,
                  Title = "Databases (F)",
                  Code = "BTI1311",
                  ECTS = 4,
                  LectPerWeek = 4,
                  TotalHours = 208
              }
          );
            modelBuilder.Entity<Module>().HasData(
              new Module
              {
                  ModuleId = 12,
                  Title = "Databases (F)",
                  Code = "BTI1311",
                  ECTS = 4,
                  LectPerWeek = 4,
                  TotalHours = 208
              }
          );
            modelBuilder.Entity<Module>().HasData(
              new Module
              {
                  ModuleId = 13,
                  Title = "Datenbanken",
                  Code = "BTW2201",
                  ECTS = 4,
                  LectPerWeek = 4,
                  TotalHours = 200
              }
          );
            modelBuilder.Entity<Module>().HasData(
              new Module
              {
                  ModuleId = 14,
                  Title = "Studienberatung SG I",
                  Code = "",
                  ECTS = 0,
                  LectPerWeek = 4,
                  TotalHours = 200
              }
          );

            //seed aditional assignments
            modelBuilder.Entity<AdditionalAssignment>().HasData(
             new AdditionalAssignment
             {
                 AdditionalAssignmentId = 1,
                 Title = "aF&E geplant",
                 AAHours = 0

             }
         );
            modelBuilder.Entity<AdditionalAssignment>().HasData(
            new AdditionalAssignment
            {
                AdditionalAssignmentId = 2,
                Title = "FB-Pool Abteilung Informatik",
                AAHours = 0

            }
        );




            //seed lecturer table
            modelBuilder.Entity<Lecturer>().HasData(new Lecturer
            {
                LecturerId = 1,
                FirstName = "John",
                LastName = "Black",
                Token = "JOBL",
                Email = "johnblack@gmx.ch",
                BirthDate = new DateTime(1982, 04, 11),
                Gender = Gender.Male,
                PhotoPath = "images/john.jpg",
                IsDeleted = false



            })  ;
        modelBuilder.Entity<Lecturer>().HasData(new Lecturer
        {
            LecturerId = 2,
            FirstName = "Mana",
            LastName = "Rodriges",
            Email = "manarodriges@gmx.ch",
            BirthDate = new DateTime(1976, 04, 11),
            Gender = Gender.Male,
            PhotoPath = "images/mana.jpg",
            IsDeleted = false

        });
            modelBuilder.Entity<Lecturer>().HasData(new Lecturer
            {
                LecturerId = 22,
                FirstName = "Manuela",
                LastName = "Rodriges",
                Email = "manarodriges@gmx.ch",
                BirthDate = new DateTime(1976, 04, 11),
                Gender = Gender.Male,
                PhotoPath = "images/mana.jpg",
                IsDeleted = false

            }) ;

            

            // data for Module Run

            modelBuilder.Entity<ModuleRun>().HasData(
              new ModuleRun { ModuleRunId=2, Code = "p" , SemesterId=1, ModuleId =12, Place ="Bern"}
               );

            base.OnModelCreating(modelBuilder);






            //modelBuilder.Entity<Lecturer>().OwnsOne(e => e.Modules).HasData(new Lecturer
            //{
            //    LecturerId = 3,
            //    FirstName = "Margo",
            //    LastName = "White",
            //    Email = "margowhite@gmx.ch",
            //    BirthDate = new DateTime(1983, 04, 11),
            //    Gender = Gender.Female,
            //    PhotoPath = "images/margo.jpg",
            //    Modules = new HashSet<LecturersModules>() {
            //            new LecturersModules(){ ModuleId =2},
            //            new LecturersModules(){ ModuleId =3}
            //        }


            //});
            modelBuilder.Entity<Lecturer>().HasData(new Lecturer
            {
                LecturerId = 3,
                FirstName = "Margo",
                LastName = "White",
                Email = "margowhite@gmx.ch",
                BirthDate = new DateTime(1983, 04, 11),
                Gender = Gender.Female,
                PhotoPath = "images/margo.jpg",
                IsDeleted = false



            });

            //seed data for Semester
            modelBuilder.Entity<Semester>().HasData(new Semester
            {
                SemesterId = 1,
                Code = "2020-2021 - FS",
                Date = new DateTime(2021, 02,15),

            }) ;
            modelBuilder.Entity<Semester>().HasData(new Semester
            {
                SemesterId = 2,
                Code = "2021-2022 - HS",
                Date = new DateTime(2021, 08, 15),

            });
            //many to many relationship , added aditional intermediate table "LecturersModules"
            /** lecturer* - * module */
            modelBuilder.Entity<Lecturer>()
                .HasKey(x => x.LecturerId);

            modelBuilder.Entity<Module>()
                .HasKey(x => x.ModuleId);

            modelBuilder.Entity<LecturersModules>()
                .HasKey(x => new { x.ModuleId, x.LecturerId });
            modelBuilder.Entity<LecturersModules>()
                .HasOne(x => x.Lecturer)
                .WithMany(m => m.LecturersModules)
                .HasForeignKey(x => x.LecturerId);
            modelBuilder.Entity<LecturersModules>()
               .HasOne(x => x.Module)
               .WithMany(e => e.Lecturers)
               .HasForeignKey(x => x.ModuleId);

            /** LecturersModuleRuns */
           
            modelBuilder.Entity<ModuleRun>()
                .HasKey(x => x.ModuleRunId);

            modelBuilder.Entity<LecturersModuleRuns>()
                .HasKey(x => new { x.ModuleRunId, x.LecturerId });
            modelBuilder.Entity<LecturersModuleRuns>()
                .HasOne(x => x.Lecturer)
                .WithMany(m => m.LecturersModuleRuns)
                .HasForeignKey(x => x.LecturerId);
            modelBuilder.Entity<LecturersModuleRuns>()
                .HasOne(x => x.ModuleRun)
        .WithMany(e => e.LecturersMR)
        .HasForeignKey(x => x.ModuleRunId);

            /** Lecturer* - * Semesters  */

            modelBuilder.Entity<Semester>()
                .HasKey(x => x.SemesterId);

            modelBuilder.Entity<LecturersSemesters>()
                .HasKey(x => new { x.SemesterId, x.LecturerId });
            modelBuilder.Entity<LecturersSemesters>()
                .HasOne(x => x.Lecturer)
                .WithMany(m => m.LecturersSemesters)
                .HasForeignKey(x => x.LecturerId);
            modelBuilder.Entity<LecturersSemesters>()
                .HasOne(x => x.Semester)
                .WithMany(e => e.LecturersSemesters)
                .HasForeignKey(x => x.SemesterId);


            /** module * - * module run*/

           }

    }
}
