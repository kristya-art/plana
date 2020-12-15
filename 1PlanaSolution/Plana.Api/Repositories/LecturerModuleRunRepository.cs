using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public class LecturerModuleRunRepository : ILecturerModuleRunRepository
    {
        private readonly AppDbContext context;


        public LecturerModuleRunRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<LecturerModuleRun> AddLecturerModuleRun(LecturerModuleRun lecturerModuleRun)
        {
            
            var result = await context.LecturersModuleRuns.AddAsync(lecturerModuleRun);


            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<LecturerModuleRun> GetLecturerModuleRun(int lecturerModuleRunId)
        {
            return await context.LecturersModuleRuns.FindAsync(lecturerModuleRunId);
        }

        public async Task<IEnumerable<LecturerModuleRun>> GetLecturerModuleRuns()
        {
            return await context.LecturersModuleRuns.ToListAsync();
        }

        public async Task<LecturerModuleRun> UpdateLecturerModuleRun(LecturerModuleRun lecturerModuleRun)
        {
            var result = await GetLecturerModuleRun(lecturerModuleRun.LecturerId);
            if (result != null)
            { 
                result.Lecturer = lecturerModuleRun.Lecturer;
                result.ModuleRun = lecturerModuleRun.ModuleRun;
                result.Lessons = lecturerModuleRun.Lessons;
                result.Hours = lecturerModuleRun.Hours;
                result.Notes = lecturerModuleRun.Notes;
                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
