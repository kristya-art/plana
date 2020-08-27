using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using System.ComponentModel.Design.Serialization;

namespace Plana.Api.Models
{
    public class SeedData
    {
        public static void SeedDatabase(AppDbContext context) 
        {
            context.Database.Migrate();
            if (context.Lecturers.Count() == 0 && context.Modules.Count() == 0 && context.ModuleRuns.Count() == 0 &&
                context.Semesters.Count() == 0)
            {
                ICollection<ModuleRun> mrcol = new List<ModuleRun>();

            //seed data for muldule
                Module m1 = new Module
                {
                    //  ModuleId = 2,
                    Title = "Projekt 2",
                    Code = "BTI7302",
                    ECTS = 4,
                    LectPerWeek = 1,
                    TotalHours = 25,
                    ModuleRuns = mrcol

                };
                Module m2 = new Module
                {

                    //   ModuleId = 3,
                    Title = "User-Centered Design",
                    Code = "BTI7083",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 100
                };
                Module m3 = new Module
                {
                    //  ModuleId = 4,
                    Title = "E-Business and Web",
                    Code = "BTI7272",
                    ECTS = 8,
                    LectPerWeek = 8,
                    TotalHours = 408
                };
                Module m4 = new Module
                {
                    // ModuleId = 5,
                    Title = "Bachelor-Thesis",
                    Code = "BTI7321",
                    ECTS = 12,
                    LectPerWeek = 0,
                    TotalHours = 0
                };
                Module m5 = new Module
                {
                    //  ModuleId = 6,
                    Title = "Smart Data-Driven Application",
                    Code = "BTI7293",
                    ECTS = 8,
                    LectPerWeek = 8,
                    TotalHours = 516
                };

                Module m6 = new Module
                {
                    //  ModuleId = 7,
                    Title = "Einführung in C#",
                    Code = "BTI7512",
                    ECTS = 2,
                    LectPerWeek = 2,
                    TotalHours = 109
                };
                Module m7 =
                new Module
                {
                    // ModuleId = 8,
                    Title = "Grundlagen Geoinformationssysteme",
                    Code = "BTI7538",
                    ECTS = 2,
                    LectPerWeek = 2,
                    TotalHours = 100
                };

                Module m8 =
                    new Module
                    {
                        //  ModuleId = 9,
                        Title = "Software Engineering and Design",
                        Code = "BTX8081",
                        ECTS = 8,
                        LectPerWeek = 6,
                        TotalHours = 300
                    };

                Module m9 =
                    new Module
                    {
                        // ModuleId = 10,
                        Title = "Software Engineering and Design",
                        Code = "BTX8082",
                        ECTS = 4,
                        LectPerWeek = 4,
                        TotalHours = 200
                    };
                Module m10 =
                   new Module
                   {
                       // ModuleId = 11,
                       Title = "Databases (F)",
                       Code = "BTI1311",
                       ECTS = 4,
                       LectPerWeek = 4,
                       TotalHours = 208
                   };
                Module m11 =
                     new Module
                     {
                         //   ModuleId = 12,
                         Title = "Databases (F)",
                         Code = "BTI1311",
                         ECTS = 4,
                         LectPerWeek = 4,
                         TotalHours = 208
                     };
                Module m12 =
                     new Module
                     {
                         //  ModuleId = 13,
                         Title = "Datenbanken",
                         Code = "BTW2201",
                         ECTS = 4,
                         LectPerWeek = 4,
                         TotalHours = 200
                     };
                Module m13 =
                    new Module
                    {
                        // ModuleId = 14,
                        Title = "Studienberatung SG I",
                        Code = "",
                        ECTS = 0,
                        LectPerWeek = 4,
                        TotalHours = 200
                    };

                context.Modules.AddRange(m1, m2, m3, m4,
                    m5, m6, m7, m8, m9, m10, m11, m12, m13);
                context.SaveChanges();


                /**
                 * seed data for lecturersmodules
                 */
                //LecturersModules lm1 = new LecturersModules
                //{
                //    Module = m1
                //};
                //context.SaveChanges();



              

                //ICollection<LecturersModules> iclm = new List<LecturersModules>();

                //iclm.Add(lm1);
                //context.SaveChanges();

                context.Lecturers.AddRange(

                    new Lecturer
                    {
                        //  LecturerId = 3,
                        FirstName = "Margo",
                        LastName = "White",
                        Email = "margowhite@gmx.ch",
                        BirthDate = new DateTime(1983, 04, 11),
                        Gender = Gender.Female,
                        PhotoPath = "images/margo.jpg",
                        IsDeleted = false,
                        // LecturersModules = iclm
                    },
                     new Lecturer
                     {
                         //  LecturerId = 3,
                         FirstName = "Rosita",
                         LastName = "Penni",
                         Email = "rp@gmx.ch",
                         BirthDate = new DateTime(1982, 02, 01),
                         Gender = Gender.Female,
                         PhotoPath = "images/rosita.png",
                         IsDeleted = false,
                         // LecturersModules = iclm
                     },
                     new Lecturer
                     {
                         //  LecturerId = 3,
                         FirstName = "Masha",
                         LastName = "Glizina",
                         Email = "mg@gmx.ch",
                         BirthDate = new DateTime(1990, 01, 01),
                         Gender = Gender.Female,
                         PhotoPath = "images/masha.jpg",
                         IsDeleted = false,
                         // LecturersModules = iclm
                     },
                     new Lecturer
                     {
                         //  LecturerId = 3,
                         FirstName = "Lolita",
                         LastName = "Baum",
                         Email = "lb@gmx.ch",
                         BirthDate = new DateTime(1975, 06, 07),
                         Gender = Gender.Female,
                         PhotoPath = "images/lolita.jpg",
                         IsDeleted = false,
                         // LecturersModules = iclm
                     },
                     new Lecturer
                     {
                         
                         FirstName = "Bob",
                         LastName = "Pelle",
                         Email = "bp@gmx.ch",
                         BirthDate = new DateTime(1989, 02, 01),
                         Gender = Gender.Male,
                         PhotoPath = "images/bob.png",
                         IsDeleted = false,
                         
                     },
                       new Lecturer
                       {

                           FirstName = "Bombo",
                           LastName = "Park",
                           Email = "bp@gmx.ch",
                           BirthDate = new DateTime(1988, 08, 15),
                           Gender = Gender.Male,
                           PhotoPath = "images/bombo.jpg",
                           IsDeleted = false,

                       },
                         new Lecturer
                         {

                             FirstName = "Christopher",
                             LastName = "Moser",
                             Email = "cm@gmx.ch",
                             BirthDate = new DateTime(1996, 09, 01),
                             Gender = Gender.Male,
                             PhotoPath = "images/christopher.png",
                             IsDeleted = false,

                         },
                           new Lecturer
                           {

                               FirstName = "Alic",
                               LastName = "Boldwin",
                               Email = "ab@gmx.ch",
                               BirthDate = new DateTime(1956, 03, 14),
                               Gender = Gender.Male,
                               PhotoPath = "images/alic.jpg",
                               IsDeleted = false,

                           },
                     new Lecturer
                     {
                        
                         FirstName = "Mihail",
                         LastName = "Patapovic",
                         Email = "mp@gmx.ch",
                         BirthDate = new DateTime(1983, 06, 12),
                         Gender = Gender.Male,
                         PhotoPath = "images/mihail.jpg",
                         IsDeleted = false,
                         // LecturersModules = iclm
                     },
                       new Lecturer
                       {

                           FirstName = "Kai",
                           LastName = "Bublik",
                           Email = "kb@gmx.ch",
                           BirthDate = new DateTime(1965, 02, 01),
                           Gender = Gender.Male,
                           PhotoPath = "images/Kai.jpg",
                           IsDeleted = false,

                       }

                    );
                context.SaveChanges();





                Lecturer l2 = new Lecturer
                {
                    FirstName = "Mike",
                    LastName = "White",
                    Email = "mikewhite@gmx.ch",
                    BirthDate = new DateTime(1983, 04, 11),
                    Gender = Gender.Female,
                    PhotoPath = "images/mike.jpg",
                    IsDeleted = false,
                   // LecturersModules = iclm
                };

                // try to make seed data in other way

                var lecturer = new Lecturer
                {
                    FirstName = "Michele",
                    LastName = "Orsi",
                    Email = "mo@gmx.ch",
                    BirthDate = new DateTime(1986, 05, 11),
                    Gender = Gender.Male,
                    PhotoPath = "images/michele.jpg",
                    IsDeleted = false,
                };
                var module = new Module
                {
                    Title = "Computer Science Basics",
                    Code = "BTI1021",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 200
                };

                lecturer.LecturersModules = new List<LecturersModules>
                {
                    new LecturersModules
                    {
                        Lecturer = lecturer,
                        Module = module
                    }
                };
                //now add this lecturer, with all its relationships, to the database
                //  context.Lecturers.Add(lecturer);
                //   context.SaveChanges();

                context.Lecturers.AddRange(lecturer, l2);
                context.SaveChanges();
                //   context.Lecturers.Add(l2);
                //   context.SaveChanges();



                //seed data for semester 
                Semester s1 = new Semester
                {
                    Code = "2020-2021 - FS",
                    Date = new DateTime(2021, 02, 15),

                };
                Semester s2 = new Semester
                {
                    Code = "2021-2022 - HS",
                    Date = new DateTime(2021, 08, 15)

                };

                context.Semesters.AddRange(s1,s2);
                context.SaveChanges();

            


                ModuleRun mr2 = new ModuleRun
                {
                    Code = "a",
                    ModuleId = context.Modules.Single(s => s.Code == "BTI7302").ModuleId,
                    SemesterId = context.Semesters.Single(b => b.Code == "2021-2022 - HS").SemesterId

                };
                context.ModuleRuns.AddRange(mr2);
                context.SaveChanges();

                mrcol.Add(mr2);
                context.SaveChanges();

               
            }
        
        
        }
    }
}
