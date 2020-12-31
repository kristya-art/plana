using AutoMapper;
using Castle.Core.Internal;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly IMapper mapper;


        public ModuleRepository(AppDbContext appDbContext, IMapper mapper)
        {
            this.appDbContext = appDbContext;
            this.mapper = mapper;
        }

        public async Task<ModuleDto> AddModule(ModuleDto moduleDto)
        {
            var module = new Module();
            mapper.Map(moduleDto, module);

            var result = await appDbContext.Modules.AddAsync(module);
            
            await appDbContext.SaveChangesAsync();
            return mapper.Map<ModuleDto>(result.Entity);
        }

       

        public async Task<ModuleDto> GetModule(int moduleId)
        {
        var module =  await appDbContext.Modules.FindAsync(moduleId);
        
        return mapper.Map<ModuleDto>(module);
                 // .Include(e => e.Modules)

                
        }

       
        //public async Task<IEnumerable<Module>> Search(string title, string code)
        //{
        //    IQueryable<Module> query = appDbContext.Modules;
        //    if (!string.IsNullOrEmpty(title))
        //    {
        //        query = query.Where(e => e.Title.Contains(title)
        //                );
        //    }
        //    if (code != null)
        //    {
        //        query = query.Where(e => e.Code.Contains(code));
        //    }
        //    return await query.ToListAsync();
        //}

        public async Task<ModuleDto> UpdateModule(ModuleDto moduleDto)
        {
            var result = await appDbContext.Modules
                .FirstOrDefaultAsync(e => e.ModuleId == moduleDto.ModuleId);
            if (result != null)
            {
                
                result.Code = moduleDto.Code;
                result.ECTS = moduleDto.ECTS;
                result.LectPerWeek = moduleDto.LectPerWeek;
                result.TotalHours = moduleDto.TotalHours;
                //result.Lecturers = moduleDto.Lecturers;
                

        
                

                await appDbContext.SaveChangesAsync();

                return mapper.Map<ModuleDto>(result);
            }

            return null;

        }
        public async Task<IEnumerable<ModuleDto>> GetModules()
        {
            ICollection<Module> modules = new List<Module>();
            //  return await appDbContext.Modules.ToListAsync();
            var result= await appDbContext.Modules
                  .Include(m => m.Lecturers)
                  .ThenInclude(l => l.Lecturer)
                  .OrderBy(m => m.Title)
                  .ToListAsync();
            return mapper.Map<IEnumerable<ModuleDto>>(result);
        }

        //public async Task<Boolean> SoftDeleteModule(int moduleId)
        //{

        //    var result = await appDbContext.Modules
        //          .FirstOrDefaultAsync(e => e.ModuleId == moduleId);
        //    if (result != null)
        //    {
        //        result.IsDeleted = true;
        //        result.DeletedAt = DateTime.Now.Date;

        //        appDbContext.Modules.Update(result);
        //        await appDbContext.SaveChangesAsync();

        //        return true;
        //    }
        //    return false;

        //}

    }
}
