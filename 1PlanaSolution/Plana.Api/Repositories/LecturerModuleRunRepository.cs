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

        public async Task<LecturerModuleRun> GetLecturerModuleRun(int lecturerId, int moduleRunId)
        {
           
            return  await context.LecturersModuleRuns.FindAsync(lecturerId, moduleRunId);
        }

        public async Task<IEnumerable<LecturerModuleRun>> GetLecturerModuleRuns()
        {
            return await context.LecturersModuleRuns.ToListAsync();
        }

        public async Task<LecturerModuleRun> UpdateLecturerModuleRun(LecturerModuleRun lecturerModuleRun)
        {
            var result = await GetLecturerModuleRun(lecturerModuleRun.LecturerId,lecturerModuleRun.ModuleRunId);
            if (result != null)
            {
                //result.Lecturer = lecturerModuleRun.Lecturer;
                //result.ModuleRun = lecturerModuleRun.ModuleRun;
                result.LecturerId = lecturerModuleRun.LecturerId;
                result.ModuleRunId = lecturerModuleRun.ModuleRunId;
                result.Lessons = lecturerModuleRun.Lessons;
                result.Hours = lecturerModuleRun.Hours;
                result.Notes = lecturerModuleRun.Notes;
                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async Task<LecturerModuleRun> GetById(params object[] keyValues) {
            return await context.LecturersModuleRuns.FindAsync(keyValues);
        }

       
    }
}
