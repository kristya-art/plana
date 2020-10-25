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
        public DbSet<LecturersModules> LecturersModules { get; set; }
        public DbSet<LecturersModuleRuns> LecturersModuleRuns { get; set; }
        
        public DbSet<LecturerGroup> LecturerGroups { get; set; }
        public DbSet<LecturerSubGroup> LecturerSubGroups { get; set; }
        public DbSet<ModuleRunLecturerSubGroup> ModuleRunLSG { get; set; }
        public DbSet<LecturerLecturerGroup> LecturerLG { get; set; }
        public DbSet<LecturerLecturerSubGroup> LecturerLSG { get; set; }
        public DbSet<LecturerModuleGroup> LecturerMG { get; set; }


        public DbSet<ModuleGroup> ModuleGroups { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecturer>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Module>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<ModuleRun>().HasQueryFilter(p => !p.IsDeleted);


            modelBuilder.Entity<LecturersModules>()
                .HasKey(x => new { x.ModuleId, x.LecturerId });

            modelBuilder.Entity<Module>()
                .HasKey(x => x.ModuleId);

            modelBuilder.Entity<StudyBranch>()
                .HasKey(x => x.StudyBranchId);

            modelBuilder.Entity<LecturerGroup>()
                .HasKey(x=> x.LecturerGroupId);

            modelBuilder.Entity<LecturerSubGroup>()
                .HasKey(x => x.LecturerSubGroupId);

            modelBuilder.Entity<ModuleGroup>()
                .HasKey(x => x.ModuleGroupId);



            /** LecturersModuleRuns */

            modelBuilder.Entity<ModuleRun>()
                .HasKey(x => x.ModuleRunId);

            modelBuilder.Entity<LecturersModuleRuns>()
                .HasKey(x => new { x.ModuleRunId, x.LecturerId });


            /** Lecturer* - * Semesters  */

            modelBuilder.Entity<Semester>()
                .HasKey(x => x.SemesterId);

            modelBuilder.Entity<LecturersSemesters>()
                .HasKey(x => new { x.SemesterId, x.LecturerId });

            /** ModuleRun - LecturerSubGroup*/

            modelBuilder.Entity<ModuleRunLecturerSubGroup>()
                .HasKey(x => new { x.ModuleRunId, x.LecturerSubGroupId });

            /** Lecturer - LecturerGroup*/

            modelBuilder.Entity<LecturerLecturerGroup>()
                 .HasKey(x => new { x.LecturerId, x.LecturerGroupId });


            /** Lecturer - LecturerSubGroup**/
            modelBuilder.Entity<LecturerLecturerSubGroup>()
                  .HasKey(x => new { x.LecturerId, x.LecturerSubGroupId });

            /** LecturerModuleGroup **/
            modelBuilder.Entity<LecturerModuleGroup>()
                 .HasKey(x => new { x.LecturerId, x.ModuleGroupId });





    }

    }
}
