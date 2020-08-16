using Castle.Core.Internal;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly AppDbContext appDbContext;


        public ModuleRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Module> AddModule(Module module)
        {
            var result = await appDbContext.Modules.AddAsync(module);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Module> DeleteModule(int moduleId)
        {
            var result = await appDbContext.Modules
                 .FirstOrDefaultAsync(e => e.ModuleId == moduleId);
            if (result != null)
            {
                appDbContext.Modules.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;

        }

        public async Task<Module> GetModule(int moduleId)
        {
            return await appDbContext.Modules
                 // .Include(e => e.Modules)

                 .FirstOrDefaultAsync(e => e.ModuleId == moduleId);
        }

        public async Task<IEnumerable<Module>> GetModules()
        {
            return await appDbContext.Modules.ToListAsync();

        }

        public async Task<IEnumerable<Module>> Search(string title, string code)
        {
            IQueryable<Module> query = appDbContext.Modules;
            if (!string.IsNullOrEmpty(title))
            {
                query = query.Where(e => e.Title.Contains(title)
                        );
            }
            if (code != null)
            {
                query = query.Where(e => e.Code == code);
            }
            return await query.ToListAsync();
        }

        public async Task<Module> UpdateModule(Module module)
        {
            var result = await appDbContext.Modules
                .FirstOrDefaultAsync(e => e.ModuleId == module.ModuleId);
            if (result != null)
            {
                
                result.Code = module.Code;
                result.ECTS = module.ECTS;
                result.LectPerWeek = module.LectPerWeek;
                result.TotalHours = module.TotalHours;
                result.Lecturers = module.Lecturers;
                result.ModuleRuns = module.ModuleRuns;

        
                

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;

        }
    }
}
