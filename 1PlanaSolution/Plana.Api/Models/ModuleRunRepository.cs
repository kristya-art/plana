using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{

    public class ModuleRunRepository : IModuleRunRepository
    {
        private readonly AppDbContext appDbContext;

        public ModuleRunRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IQueryable<ModuleRun> ModuleRuns => appDbContext.ModuleRuns;

        

        public async Task<ModuleRun> CreateModuleRun(ModuleRun moduleRun)
        {
            var result = await appDbContext.ModuleRuns.AddAsync(moduleRun);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public Task<bool> DeleteModuleRun(int moduleRunId)
        {
            throw new NotImplementedException();
        }


        public async Task<ModuleRun> GetModuleRun(int moduleRunId)
        {
            return await appDbContext.ModuleRuns
                .FirstOrDefaultAsync(e => e.ModuleRunId == moduleRunId);


        }

        public async Task<IEnumerable<ModuleRun>> GetModuleRuns()
        {
            return  ModuleRuns;
        }

        public async Task<IEnumerable<ModuleRun>> Search(Semester semester, string code)
        {
            IQueryable<ModuleRun> mr = appDbContext.ModuleRuns;
            if (semester != null)
            {
               mr = mr.Where(e => e.Semester == semester);
            }
            if (!string.IsNullOrEmpty(code))
            {
                mr = mr.Where(e => e.Code.Contains(code));
            }
            return await mr.ToListAsync();
        }

       

        public Task<bool> SoftDeleteModuleRun(int moduleRunId)
        {
            throw new NotImplementedException();
        }

        public async Task<ModuleRun> UpdateModuleRun(ModuleRun moduleRun)
        {
            var result = await appDbContext.ModuleRuns
                .FirstOrDefaultAsync(e => e.ModuleRunId == moduleRun.ModuleRunId);
            if (result != null)
            {
                result.Code = moduleRun.Code;
                result.Semester = moduleRun.Semester;
                result.Module = moduleRun.Module;
                result.LecturersMR = moduleRun.LecturersMR;

                //todo: need to complete with other attributes

                await appDbContext.SaveChangesAsync();

                return result;
            
            }
            return null;
        }
    }
}
