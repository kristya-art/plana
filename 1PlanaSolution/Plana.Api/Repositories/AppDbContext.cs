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
        public DbSet<LecturerModule> LecturersModules { get; set; }
        public DbSet<LecturerModuleRun> LecturersModuleRuns { get; set; }
        
        public DbSet<LecturerGroup> LecturerGroups { get; set; }
        public DbSet<LecturerLecturerGroup> LecturerLecturerGroups { get; set; }
        public DbSet<LecturerModuleGroup> LecturerModuleGroups { get; set; }
        public DbSet<LecturerGroupModuleGroup> LecturerGroupModuleGroups { get; set; }


        public DbSet<ModuleGroup> ModuleGroups { get; set; }
        public DbSet<LecturerSemester> LecturerSemesters { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecturer>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Module>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<ModuleRun>().HasQueryFilter(p => !p.IsDeleted);


            modelBuilder.Entity<LecturerModule>()
                .HasKey(x => new { x.ModuleId, x.LecturerId });

            modelBuilder.Entity<Module>()
                .HasKey(x => x.ModuleId);

            modelBuilder.Entity<StudyBranch>()
                .HasKey(x => x.StudyBranchId);

            modelBuilder.Entity<LecturerGroup>()
                .HasKey(x=> x.LecturerGroupId);

            modelBuilder.Entity<ModuleGroup>()
                .HasKey(x => x.ModuleGroupId);



            /** LecturersModuleRuns */

            modelBuilder.Entity<ModuleRun>()
                .HasKey(x => x.ModuleRunId);

            modelBuilder.Entity<LecturerModuleRun>()
                .HasKey(x => new { x.ModuleRunId, x.LecturerId });


            /** Lecturer* - * Semesters  */

            modelBuilder.Entity<Semester>()
                .HasKey(x => x.SemesterId);

            modelBuilder.Entity<LecturerSemester>()
                .HasKey(x => new { x.SemesterId, x.LecturerId });


              /** Lecturer - LecturerGroup*/

            modelBuilder.Entity<LecturerLecturerGroup>()
                 .HasKey(x => new { x.LecturerId, x.LecturerGroupId });


             /** LecturerModuleGroup **/
            modelBuilder.Entity<LecturerModuleGroup>()
                 .HasKey(x => new { x.LecturerId, x.ModuleGroupId });

            /** LecturerGroupModuleGroup */
            modelBuilder.Entity<LecturerGroupModuleGroup>()
                .HasKey(x => new { x.LecturerGroupId, x.ModuleGroupId });

         }

    }
}
