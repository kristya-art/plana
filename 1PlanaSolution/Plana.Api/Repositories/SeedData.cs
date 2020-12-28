using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Plana.Api.Models
{
    public class SeedData
    {
        private static Module AddModule(AppDbContext context, string title, string code, int ects, int lectPerWeek, int totalHours)
        {
            Module module = new Module
            {
                Title = title,
                Code = code,
                ECTS = ects,
                LectPerWeek = lectPerWeek,
                TotalHours = totalHours
            };

            context.Modules.Add(module);

            return module;
        }

        public static void SeedDatabase(AppDbContext context)
        {
            context.Database.Migrate();
            if (context.Lecturers.Count() == 0 && context.Modules.Count() == 0 && context.ModuleRuns.Count() == 0 &&
                context.Semesters.Count() == 0 && context.AdditionalAssignments.Count() == 0)
            {
                ICollection<ModuleRun> mrcol = new List<ModuleRun>();
                ICollection<AdditionalAssignment> aacol = new List<AdditionalAssignment>();
                ICollection<LecturerModuleRun> lmrcol = new List<LecturerModuleRun>();

                LecturerModuleRun lmr = new LecturerModuleRun();

                // Seed data for module

                Module m2 = AddModule(context, "Project and Training 2", "BTI3011", 6, 8, 516);
                Module project2 = AddModule(context, "Projekt 2", "BTI7302", 6, 1, 25);
                AddModule(context, "User-Centered Design", "BTI7083", 4, 4, 100);

                Module projectAndTraining1 = new Module
                {
                    Title = "Project and Training 1",
                    Code = "BTI3001",
                    ECTS = 6,
                    LectPerWeek = 8,
                    TotalHours = 516
                };


                Module m3 = new Module
                {
                    Title = "E-Business and Web",
                    Code = "BTI7272",
                    ECTS = 8,
                    LectPerWeek = 8,
                    TotalHours = 408
                };

                Module m4 = new Module
                {
                    Title = "Bachelor-Thesis",
                    Code = "BTI7321",
                    ECTS = 12,
                    LectPerWeek = 0,
                    TotalHours = 0
                };

                Module m5 = new Module
                {

                    Title = "Smart Data-Driven Application",
                    Code = "BTI7293",
                    ECTS = 8,
                    LectPerWeek = 8,
                    TotalHours = 516
                };

                Module m6 = new Module
                {

                    Title = "Einführung in C#",
                    Code = "BTI7512",
                    ECTS = 2,
                    LectPerWeek = 2,
                    TotalHours = 109
                };

                Module m7 = new Module
                {

                    Title = "Grundlagen Geoinformationssysteme",
                    Code = "BTI7538",
                    ECTS = 2,
                    LectPerWeek = 2,
                    TotalHours = 100
                };

                Module m8 = new Module
                {

                    Title = "Software Engineering and Design",
                    Code = "BTX8081",
                    ECTS = 8,
                    LectPerWeek = 6,
                    TotalHours = 300
                };

                Module m9 = new Module
                {

                    Title = "Software Engineering and Design",
                    Code = "BTX8082",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 200
                };

                Module databases = new Module
                {
                    Title = "Databases (F)",
                    Code = "BTI1311",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 208
                };

                Module m12 = new Module
                {
                    Title = "Datenbanken",
                    Code = "BTW2201",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 200
                };

                Module studienBeratung = new Module
                {

                    Title = "Studienberatung SG I",
                    Code = "",
                    ECTS = 0,
                    LectPerWeek = 4,
                    TotalHours = 200
                };

                Module computing_project = new Module
                {

                    Title = "Computing Project",
                    Code = "BTI6453",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 200
                };

                Module intro_multim = new Module
                {
                    Title = "Introduction to Multimedia",
                    Code = "BTI6454",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 200
                };

                Module prof_skills = new Module
                {
                    Title = "Professional Skills",
                    Code = "BTI6456",
                    ECTS = 4,
                    LectPerWeek = 4,
                    TotalHours = 200
                };


                context.Modules.AddRange(m3, m4,
                               m5, m6, m7, m8, m9, databases, m12, studienBeratung, projectAndTraining1, computing_project, intro_multim, prof_skills);

                context.SaveChanges();

                // Seed data for AdditionalAssignments

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
                l2.LecturersModules = new List<LecturerModule>
                {
                    new LecturerModule
                    {
                        Lecturer = l2,
                        Module = m12
                    },
                    new LecturerModule
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

                michele.LecturersModules = new List<LecturerModule>
                {
                    new LecturerModule
                    {
                        Lecturer = michele,
                        Module = csbasics
                    },
                    new LecturerModule
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
                    LecturersSemesters = new List<LecturerSemester>
                    {
                       new LecturerSemester{Lecturer= masha},
                       new LecturerSemester{Lecturer= misha}

                    }



                };
                Semester s2 = new Semester
                {
                    Code = "2020-2021 - HS",
                    Date = new DateTime(2021, 08, 15),
                    AdditionalAssignments = new List<AdditionalAssignment> {
                        new AdditionalAssignment { Title = "newAdditionalAssigment1", AAHours = 0} ,
                        new AdditionalAssignment { Title = "newAddtitonalAssigment2", AAHours = 0} },
                    LecturersSemesters = new List<LecturerSemester>
                    {
                       new LecturerSemester{Lecturer= margo},
                       new LecturerSemester{Lecturer= alic}

                    }

                };
                Semester s3 = new Semester
                {
                    Code = "2021-2022 - FS",
                    Date = new DateTime(2021, 02, 15),
                    LecturersSemesters = new List<LecturerSemester>
                    {
                       new LecturerSemester{Lecturer= rosita},
                       new LecturerSemester{Lecturer= kai}

                    }

                };
                Semester s4 = new Semester
                {
                    Code = "2021-2022 - HS",
                    Date = new DateTime(2021, 08, 13),
                    LecturersSemesters = new List<LecturerSemester>
                    {
                       new LecturerSemester{Lecturer= margo},
                       new LecturerSemester{Lecturer= alic}

                    }
                };
                Semester as_23_24 = new Semester()
                {
                    Code = "2023-2024 - HS",
                    Date = new DateTime(2021, 08, 13),
                    LecturersSemesters = new List<LecturerSemester>
                        {
                            new LecturerSemester { Lecturer = margo },
                            new LecturerSemester { Lecturer = alic }

                        }
                };
                Semester ss_24 = new Semester()
                {
                    Code = "2025 - FS",
                    Date = new DateTime(2024, 08, 13),
                    LecturersSemesters = new List<LecturerSemester>
                    {
                       new LecturerSemester{Lecturer= margo},
                       new LecturerSemester{Lecturer= alic}

                    }

                };
                Semester as_24_25 = new Semester()
                {
                    Code = "2024-2025 - HS",
                    Date = new DateTime(2024, 08, 13),
                    LecturersSemesters = new List<LecturerSemester>
                        {
                            new LecturerSemester { Lecturer = margo },
                            new LecturerSemester { Lecturer = michele}

                        }
                };
                Semester ss_25 = new Semester()
                {
                    Code = "2025 - FS",
                    Date = new DateTime(2025, 08, 13),
                    LecturersSemesters = new List<LecturerSemester>
                    {
                       new LecturerSemester{Lecturer= michele},
                       new LecturerSemester{Lecturer= alic}

                    }

                };
                s2.ModuleRuns = new HashSet<ModuleRun>
                {
                    new ModuleRun
                    { Code = "a",
                      SemesterId = s2.SemesterId,
                      Module = csbasics,
                      Place = "Biel",
                      LecturersMR = new List<LecturerModuleRun>
                      {
                       new LecturerModuleRun{ Lecturer = michele},
                       new LecturerModuleRun{ Lecturer = l2}

                      }


                    },
                    new ModuleRun
                    {
                      Code = "q",
                      SemesterId = s3.SemesterId,
                      Place = "Bern",
                      Module = projectAndTraining1

                    },

                    new ModuleRun
                    {
                      Code ="b",
                      SemesterId = s2.SemesterId,
                      Module = csbasics,
                      Place = "Biel",
                       LecturersMR = new List<LecturerModuleRun>
                      {
                       new LecturerModuleRun{ Lecturer = michele},
                       new LecturerModuleRun{ Lecturer = l2}
                      }

                    }
                };
                lmr.Lecturer = michele;
                lmrcol.Add(lmr);




                s2.LecturersSemesters = new List<LecturerSemester>
                {
                 new LecturerSemester
                 {
                   Semester =s2,
                   Lecturer = michele
                 },
                 new LecturerSemester
                 {
                   Semester = s2,
                   Lecturer =l2
                 }

                };



                context.Semesters.AddRange(s1, s2, s3, s4, as_23_24, ss_24, as_24_25, ss_25);
                context.SaveChanges();



                //seed data for module run
                ModuleRun p_ucd = new ModuleRun
                {
                    Code = "p",
                    Module = m2,
                    SemesterId = s3.SemesterId
                };
                ModuleRun q_ucd = new ModuleRun
                {
                    Code = "q",
                    Module = m2,
                    SemesterId = s1.SemesterId
                };

                ModuleRun c = new ModuleRun
                {
                    Code = "a",
                    Module = m6,
                    SemesterId = s2.SemesterId,
                    LecturersMR = new List<LecturerModuleRun> {

                   new LecturerModuleRun{ Lecturer =misha}
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
                    SemesterId = s4.SemesterId,
                    LecturersMR = lmrcol,
                    Place = "Biel",
                    Code = "b"


                };



                ModuleRun computing_project_bi24 = new ModuleRun
                {
                    Module = computing_project,
                    SemesterId = as_24_25.SemesterId,
                    LecturersMR = new List<LecturerModuleRun>
                    {
                        new LecturerModuleRun { Lecturer = margo },
                        new LecturerModuleRun { Lecturer = masha }

                    },
                    Place = "Biel",
                    Code = "a/b"



                };
                ModuleRun intro_multim_bi23 = new ModuleRun
                {
                    Module = intro_multim,
                    SemesterId = as_23_24.SemesterId,
                    LecturersMR = new List<LecturerModuleRun>
                    {
                        new LecturerModuleRun { Lecturer = kai },
                        new LecturerModuleRun { Lecturer = misha }

                    },
                    Place = "Biel",
                    Code = "a/b"


                };
                ModuleRun prof_skills_bi24 = new ModuleRun
                {
                    Module = prof_skills,
                    SemesterId = ss_24.SemesterId,
                    LecturersMR = new List<LecturerModuleRun>
                    {
                        new LecturerModuleRun { Lecturer = lolita},
                        new LecturerModuleRun { Lecturer = rosita }

                    },
                    Place = "Biel",
                    Code = "a/b"


                };
                ModuleRun prof_skills_bi25 = new ModuleRun
                {
                    Module = prof_skills,
                    SemesterId = ss_25.SemesterId,
                    LecturersMR = new List<LecturerModuleRun>
                    {
                        new LecturerModuleRun { Lecturer = lolita},
                        new LecturerModuleRun { Lecturer = rosita }

                    },
                    Place = "Biel",
                    Code = "a/b"


                };
                ModuleRun computing_project_be24 = new ModuleRun
                {
                    Module = computing_project,
                    SemesterId = as_24_25.SemesterId,
                    LecturersMR = new List<LecturerModuleRun>
                    {
                        new LecturerModuleRun { Lecturer = margo },
                        new LecturerModuleRun { Lecturer = masha }

                    },
                    Place = "Bern",
                    Code = "p/q"



                };
                ModuleRun intro_multim_be23 = new ModuleRun
                {
                    Module = intro_multim,
                    SemesterId = as_23_24.SemesterId,
                    LecturersMR = new List<LecturerModuleRun>
                    {
                        new LecturerModuleRun { Lecturer = kai },
                        new LecturerModuleRun { Lecturer = misha }

                    },
                    Place = "Bern",
                    Code = "p/q"


                };
                ModuleRun prof_skills_be24 = new ModuleRun
                {
                    Module = prof_skills,
                    SemesterId = ss_24.SemesterId,
                    LecturersMR = new List<LecturerModuleRun>
                    {
                        new LecturerModuleRun { Lecturer = lolita},
                        new LecturerModuleRun { Lecturer = rosita }

                    },
                    Place = "Bern",
                    Code = "p/q"


                };
                ModuleRun prof_skills_be25 = new ModuleRun
                {
                    Module = prof_skills,
                    SemesterId = ss_25.SemesterId,
                    LecturersMR = new List<LecturerModuleRun>
                    {
                        new LecturerModuleRun { Lecturer = lolita},
                        new LecturerModuleRun { Lecturer = rosita }

                    },
                    Place = "Bern",
                    Code = "p/q"


                };

                context.ModuleRuns.AddRange(project2MR, c, q_ucd, p_ucd, prof_skills_bi24, prof_skills_bi25, intro_multim_bi23, computing_project_bi24,
                    prof_skills_be24, prof_skills_be25, intro_multim_be23, computing_project_be24);
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

                //seed data for plan





                Plan plan23_24 = new Plan
                {
                    Year = "2023-2024",
                    AutumnSemester = as_23_24,
                    SpringSemester = ss_24
                    //Semesters=   new List<Semester> { as_23_24,ss_24}

                };

                Plan plan24_25 = new Plan
                {
                    Year = "2024-2025",
                    AutumnSemester = as_24_25,
                    SpringSemester = ss_25



                };
                Plan plan20_21 = new Plan
                {
                    Year = "2020-2021",

                };


                context.Plans.Add(plan23_24);
                context.Plans.Add(plan24_25);
                context.Plans.Add(plan20_21);
                context.SaveChanges();


                // seed plan-->planlecturers


                PlanLecturer planLecturer1 = new PlanLecturer { LecturerId = 1, PlanId = 1 };
                PlanLecturer planLecturer2 = new PlanLecturer { LecturerId = 2, PlanId = 1 };


                PlanLecturer planLecturer3 = new PlanLecturer { LecturerId = 3, PlanId = 2 };
                PlanLecturer planLecturer4 = new PlanLecturer { LecturerId = 4, PlanId = 2 };


                context.PlanLecturers.AddRange(planLecturer1, planLecturer2, planLecturer3, planLecturer4);
                context.SaveChanges();


            }



        }
    }
}
