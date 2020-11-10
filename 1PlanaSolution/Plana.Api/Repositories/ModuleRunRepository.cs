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
        private readonly LecturerRepository lrep;
        private readonly SemesterRepository srep;

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

      

       

        public async Task<ModuleRun> GetModuleRun(int moduleRunId)
        {
            return await appDbContext.ModuleRuns
                .Include(m=>m.LecturersMR)
                .ThenInclude(lmr=>lmr.Lecturer)
                .Include(m=>m.Semester)
                .Include(m=>m.Module)
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



        public async Task<ModuleRun> UpdateModuleRun(ModuleRun moduleRun)
        {
            var result = await GetModuleRun(moduleRun.ModuleRunId);
            if (result != null)
            {
                result.Code = moduleRun.Code;
                result.LecturersMR = moduleRun.LecturersMR;
              
                result.Module = moduleRun.Module;
               
                result.ModuleId = moduleRun.ModuleId;
               
                result.Place = moduleRun.Place;
                result.Semester = moduleRun.Semester;
                
                result.SemesterId = moduleRun.SemesterId;
                result.ModuleGroup = moduleRun.ModuleGroup;
               
                await appDbContext.SaveChangesAsync();

                return result;
            
            }
            return null;
        
        }

       
        public async Task<Boolean> SoftDeleteModuleRun(int moduleRunId)
        {

            var result = await appDbContext.ModuleRuns
                  .FirstOrDefaultAsync(e => e.ModuleRunId == moduleRunId);
            if (result != null)
            {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now.Date;

                appDbContext.ModuleRuns.Update(result);
                await appDbContext.SaveChangesAsync();

                return true;
            }
            return false;

           }

        public async Task<bool> DeleteModuleRun(int moduleRunId)
        {
            var result = await appDbContext.ModuleRuns
                 .FirstOrDefaultAsync(e => e.ModuleRunId == moduleRunId);
            if (result != null)
            {
                appDbContext.ModuleRuns.Remove(result);
                await appDbContext.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<IEnumerable<ModuleRun>> Search(string name, string code)
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



    }
}
