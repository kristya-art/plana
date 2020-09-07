using Microsoft.AspNetCore.Mvc.Filters;
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
      //  public IQueryable<ModuleRun> ModuleRuns => appDbContext.ModuleRuns;


        public async Task<ModuleRun> CreateModuleRun(ModuleRun moduleRun )
        {
           
            var result = await appDbContext.ModuleRuns.AddAsync(moduleRun);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public Task<bool> DeleteModuleRun(int moduleRunId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ModuleRun>> GetCustomated()
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<ModuleRun>> GetCustomated()
        //{
        //    var result = ModuleRuns
        //         .Include(i => i.Code)
        //         .Include(i => i.Module.Code)
        //         .Include(i => i.Module.Title)
        //         .Include(i => i.Semester.Code)
        //         .Include(i => i.Semester.Date)
        //         .ToListAsync();

        //    return await result;

        //}

        public async Task<ModuleRun> GetModuleRun(int moduleRunId)
        {
            return await appDbContext.ModuleRuns
           .FirstOrDefaultAsync(e => e.ModuleRunId == moduleRunId);






        }

        public async Task<IEnumerable<ModuleRun>> GetModuleRuns()
        {
            return await appDbContext.ModuleRuns
                .Include(m => m.Module)
                .Include(m => m.LecturersMR)
                .ThenInclude(lmr => lmr.Lecturer)
                .Include(m => m.Semester)
                .OrderBy(m => m.Module.Title)
                .ToListAsync();
        }

        public async Task<IEnumerable<ModuleRun>> Search(string name,string code)
        {
            IQueryable<ModuleRun> query = appDbContext.ModuleRuns;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Module.Title.Contains(name));
            }
           
            if (!string.IsNullOrEmpty(code))
            {
                query = query.Where(e => e.Code.Contains(code));
            }
            return await query.ToListAsync();
        }
        //public async Task<IEnumerable<ModuleRun>> SearchFromModule(string moduleCode)
        //{

        //    IQueryable<ModuleRun> query = appDbContext.ModuleRuns;
        //    // IQueryable<Module> help = appDbContext.Modules;
        //    query.Include(c => c.Module);
        //    if (!string.IsNullOrEmpty(moduleCode))
        //    {



        //        query = query.Where(e => e.Module.Code == moduleCode);
        //    }

        //    return await query.ToListAsync();
        //}


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
