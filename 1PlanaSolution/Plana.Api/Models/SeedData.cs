using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using System.Collections;

namespace Plana.Api.Models
{
    public class SeedData
    {
        public static void SeedDatabase(AppDbContext context) 
        {
            context.Database.Migrate();
            if (context.Lecturers.Count() == 0 && context.Modules.Count() == 0 && context.ModuleRuns.Count() == 0) 
            {
                Module m1 = new Module
                {
                  //  ModuleId = 2,
                    Title = "Projekt 2",
                    Code = "BTI7302",
                    ECTS = 4,
                    LectPerWeek = 1,
                    TotalHours = 25
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
                LecturersModules lm1 = new LecturersModules
                {
                    Module = m1
                };
                context.SaveChanges();

           //     context.LecturersModules.AddRange(lm1);
                context.SaveChanges();

            ICollection<LecturersModules> ic = new List<LecturersModules>();
            ic.Add(lm1);
            context.SaveChanges();

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
                    LecturersModules = ic




                }

                ) ;
                context.SaveChanges();



               


            }
        
        
        }
    }
}
