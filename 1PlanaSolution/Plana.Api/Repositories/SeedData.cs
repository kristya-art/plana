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
                context.Semesters.Count() == 0 && context.AdditionalAssignments.Count() ==0)
            {
                ICollection<ModuleRun> mrcol = new List<ModuleRun>();
                ICollection<AdditionalAssignment> aacol = new List<AdditionalAssignment>();
                ICollection<LecturersModuleRuns> lmrcol = new List<LecturersModuleRuns>();

                LecturersModuleRuns lmr = new LecturersModuleRuns();

     //seed data for module

                Module projectAndTraining1 = new Module
                {
                    Title = "Project and Training 1",
                Code = "BTI3001",
                   ECTS = 6,
                   LectPerWeek = 8,
                   TotalHours= 516
                   
               };
                Module projectAndTraining2 = new Module
               {
                    Title = "Project and Training 2",
                    Code = "BTI3011",
                    ECTS = 6,
                    LectPerWeek = 8,
                    TotalHours = 516


               };
               // Module
              

                Module project2 = new Module
                {
                    //  ModuleId = 2,
                    Title = "Projekt 2",
                    Code = "BTI7302",
                    ECTS = 6,
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
                Module databases =
                   new Module
                   {
                       // ModuleId = 11,
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
                Module studienBeratung =
                    new Module
                    {
                        // ModuleId = 14,
                        Title = "Studienberatung SG I",
                        Code = "",
                        ECTS = 0,
                        LectPerWeek = 4,
                        TotalHours = 200
                    };

                context.Modules.AddRange(project2, m2, m3, m4,
                    m5, m6, m7, m8, m9, databases, m12, studienBeratung,projectAndTraining1,projectAndTraining2);
                context.SaveChanges();

     //seed data for AdditionalAssignments

                AdditionalAssignment a1 = new AdditionalAssignment
                {
                    Title = "aF&E",
                    AAHours = 0,
                    
                };
                AdditionalAssignment a2 = new AdditionalAssignment
                {
                    Title = "FB-Pool Abteilung Informatik",
                    AAHours = 0
                };
                context.AdditionalAssignments.AddRange(a1, a2);
                context.SaveChanges();

                //seed data for lecturer
               

                Lecturer margo = new Lecturer
                {

                    FirstName = "Margo",
                    LastName = "White",
                    Email = "margowhite@gmx.ch",
                    BirthDate = new DateTime(1983, 04, 11),
                    Gender = Gender.Female,
                    PhotoPath = "images/margo.jpg",
                    IsDeleted = false,                  //better take it away 
                                                        // LecturersModules = iclm
                };
                Lecturer rosita = new Lecturer
                {

                    FirstName = "Rosita",
                    LastName = "Penni",
                    Email = "rp@gmx.ch",
                    BirthDate = new DateTime(1982, 02, 01),
                    Gender = Gender.Female,
                    PhotoPath = "images/rosita.png",
                    IsDeleted = false,
                    // LecturersModules = iclm
                };
                Lecturer masha = new Lecturer
                {

                    FirstName = "Masha",
                    LastName = "Glizina",
                    Email = "mg@gmx.ch",
                    BirthDate = new DateTime(1990, 01, 01),
                    Gender = Gender.Female,
                    PhotoPath = "images/masha.jpg",
                    IsDeleted = false,
                   
                };
                Lecturer lolita = new Lecturer
                {

                    FirstName = "Lolita",
                    LastName = "Baum",
                    Email = "lb@gmx.ch",
                    BirthDate = new DateTime(1975, 06, 07),
                    Gender = Gender.Female,
                    PhotoPath = "images/lolita.jpg",
                    IsDeleted = false,

                };
                Lecturer bob = new Lecturer
                {

                    FirstName = "Bob",
                    LastName = "Pelle",
                    Email = "bp@gmx.ch",
                    BirthDate = new DateTime(1989, 02, 01),
                    Gender = Gender.Male,
                    PhotoPath = "images/bob.png",
                    IsDeleted = false,

                };
                Lecturer bombo = new Lecturer
                {

                    FirstName = "Bombo",
                    LastName = "Park",
                    Email = "bp@gmx.ch",
                    BirthDate = new DateTime(1988, 08, 15),
                    Gender = Gender.Male,
                    PhotoPath = "images/bombo.jpg",
                    IsDeleted = false,

                };
                Lecturer chris = new Lecturer
                {

                    FirstName = "Christopher",
                    LastName = "Moser",
                    Email = "cm@gmx.ch",
                    BirthDate = new DateTime(1996, 09, 01),
                    Gender = Gender.Male,
                    PhotoPath = "images/christopher.png",
                    IsDeleted = false,

                };
                Lecturer alic = new Lecturer
                {

                    FirstName = "Alic",
                    LastName = "Boldwin",
                    Email = "ab@gmx.ch",
                    BirthDate = new DateTime(1956, 03, 14),
                    Gender = Gender.Male,
                    PhotoPath = "images/alic.jpg",
                    IsDeleted = false,

                };
                Lecturer misha = new Lecturer
                {

                    FirstName = "Mihail",
                    LastName = "Patapovic",
                    Email = "mp@gmx.ch",
                    BirthDate = new DateTime(1983, 06, 12),
                    Gender = Gender.Male,
                    PhotoPath = "images/mihail.jpg",
                    IsDeleted = false,
                   
                };
                Lecturer kai = new Lecturer
                {

                    FirstName = "Kai",
                    LastName = "Bublik",
                    Email = "kb@gmx.ch",
                    BirthDate = new DateTime(1965, 02, 01),
                    Gender = Gender.Male,
                    PhotoPath = "images/Kai.jpg",
                    IsDeleted = false,

                };

                context.Lecturers.AddRange(margo, misha, kai, rosita, alic, chris, bombo, bob, masha);
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
                l2.LecturersModules = new List<LecturersModules>
                {
                    new LecturersModules
                    {
                        Lecturer = l2,
                        Module = m12
                    },
                    new LecturersModules
                    {
                       Lecturer = l2,
                       Module = m6
                    }
                };

                // try to make seed data in other way => works!

                var michele = new Lecturer
                {
                    FirstName = "Michele",
                    LastName = "Orsi",
                    Email = "mo@gmx.ch",
                    BirthDate = new DateTime(1986, 05, 11),
                    Gender = Gender.Male,
                    PhotoPath = "images/michele.jpg",
                    IsDeleted = false,
                };
                var csbasics = new Module
                {
                    Title = "Computer Science Basics",
                    Code = "BTI1021",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 200
                };

                michele.LecturersModules = new List<LecturersModules>
                {
                    new LecturersModules
                    {
                        Lecturer = michele,
                        Module = csbasics
                    },
                    new LecturersModules
                    { 
                       Lecturer = michele,
                       Module = m6
                    }
                };
                aacol.Add(a1);
                michele.AdditionalAssignments = aacol;
               

                context.Lecturers.AddRange(michele, l2);
                context.SaveChanges();
              



   //seed data for semester 
                Semester s1 = new Semester
                {
                    Code = "2020-2021 - FS",
                    Date = new DateTime(2021, 02, 15),
                    AdditionalAssignments = aacol,
                    LecturersSemesters = new List<LecturersSemesters>
                    { 
                       new LecturersSemesters{Lecturer= masha},
                       new LecturersSemesters{Lecturer= misha}

                    }

                    

                };
                Semester s2 = new Semester
                {
                    Code = "2020-2021 - HS",
                    Date = new DateTime(2021, 08, 15),
                    AdditionalAssignments = new List<AdditionalAssignment> {
                        new AdditionalAssignment { Title = "newAdditionalAssigment1", AAHours = 0} ,
                        new AdditionalAssignment { Title = "newAddtitonalAssigment2", AAHours = 0} },
                     LecturersSemesters = new List<LecturersSemesters>
                    {
                       new LecturersSemesters{Lecturer= margo},
                       new LecturersSemesters{Lecturer= alic}

                    }

                };
                Semester s3 = new Semester
                {
                    Code = "2021-2022 - FS",
                    Date = new DateTime(2021, 02, 15),
                    LecturersSemesters = new List<LecturersSemesters>
                    {
                       new LecturersSemesters{Lecturer= rosita},
                       new LecturersSemesters{Lecturer= kai}

                    }

                };
                Semester s4 = new Semester
                {
                    Code = "2021-2022 - HS",
                    Date = new DateTime(2021, 08, 13),
                      LecturersSemesters = new List<LecturersSemesters>
                    {
                       new LecturersSemesters{Lecturer= margo},
                       new LecturersSemesters{Lecturer= alic}

                    }
                };
                s2.ModuleRuns = new HashSet<ModuleRun>
                {
                    new ModuleRun
                    { Code = "a",
                      Semester = s2,
                      Module = csbasics,
                      Place = "Biel",
                      LecturersMR = new List<LecturersModuleRuns>
                      { 
                       new LecturersModuleRuns{ Lecturer = michele},
                       new LecturersModuleRuns{ Lecturer = l2}
                      }
                      
                      
                    },
                    new ModuleRun
                    { 
                      Code = "q",
                      Semester = s3,
                      Place = "Bern",
                      Module = projectAndTraining1

                    },

                    new ModuleRun
                    { 
                      Code ="b",
                      Semester = s2,
                      Module = csbasics,
                      Place = "Biel",
                       LecturersMR = new List<LecturersModuleRuns>
                      {
                       new LecturersModuleRuns{ Lecturer = michele},
                       new LecturersModuleRuns{ Lecturer = l2}
                      }

                    }
                };
                lmr.Lecturer = michele;
                lmrcol.Add(lmr);

                
                      

                s2.LecturersSemesters = new List<LecturersSemesters>
                {
                 new LecturersSemesters
                 {
                   Semester =s2,
                   Lecturer = michele
                 },
                 new LecturersSemesters
                 {
                   Semester = s2,
                   Lecturer =l2
                 }

                };



                context.Semesters.AddRange(s1,s2,s3,s4);
                context.SaveChanges();



                //seed data for module run
                ModuleRun p_ucd = new ModuleRun
                {
                    Code = "p",
                    Module = m2,
                    Semester = s3
                };
                ModuleRun q_ucd = new ModuleRun
                {
                    Code = "q",
                    Module = m2,
                    Semester = s1
                };

                ModuleRun c = new ModuleRun
                { 
                    Code="a",
                   Module = m6,
                   Semester =s2,
                   LecturersMR = new List<LecturersModuleRuns> { 
                   
                   new LecturersModuleRuns{ Lecturer =misha}
                   }

                };


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

                ModuleRun project2MR = new ModuleRun
                {
                    Module = project2,
                    Semester = s4,
                    LecturersMR = lmrcol,
                    Place = "Biel",
                    Code = "b"


                };

                context.ModuleRuns.AddRange(project2MR, c,q_ucd,p_ucd);
                context.SaveChanges();

                //seed data for StudyBranch
                StudyBranch it = new StudyBranch
                {
                    Code = "TI",
                    Title = "Information Technology",
                    Modules = new List<Module> 
                    {
                      project2, m2, m3, m4,
                      m5, m6, m7, m8, m9, 
                      databases, m12,csbasics,
                      studienBeratung
                     }
                };

                context.StudyBranches.Add(it);
                context.SaveChanges();




            }


        }
    }
}
