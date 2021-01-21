using AutoMapper;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{


    public class ModuleRunService : IModuleRunService
    {
        private readonly AppDbContext _context;
        private readonly IMapper mapper;
        

        public ModuleRunService(AppDbContext context, IMapper mapper)
        {
            _context = context;

            this.mapper = mapper;
        }
      

        public async Task<ActionResultDto<ModuleRunDto>> CreateModuleRun(ModuleRunDto moduleRunDto )
        {
            var moduleRun = new ModuleRun();
            mapper.Map(moduleRunDto, moduleRun);
            if (moduleRun == null) { return new ActionResultDto<ModuleRunDto>("You can not add an empty module run "); }

            foreach (var mr in _context.ModuleRuns)
            {
                if ((mr.ModuleId == moduleRun.ModuleId) && (mr.Code == moduleRun.Code) && (mr.Place == moduleRun.Place) && (mr.SemesterId == moduleRun.SemesterId))
                {
                    return new ActionResultDto<ModuleRunDto>("This Module run is already" +
                        "exist in this semester.");
                }
            }
            
            var result = await _context.ModuleRuns.AddAsync(moduleRun);
            await _context.SaveChangesAsync();

            return mapper.Map<ModuleRunDto>(result.Entity);
           
        }

        public async Task<ModuleRunDto> GetModuleRun(int moduleRunId)
        {
            var moduleRun = await _context.ModuleRuns.FindAsync(moduleRunId);
            return mapper.Map<ModuleRunDto>(moduleRun);
          

        }

        public async Task<IEnumerable<ModuleRunDto>> GetModuleRuns()
        {
            var moduleRuns = await _context.ModuleRuns.ToListAsync();
            return mapper.Map<IEnumerable<ModuleRunDto>>(moduleRuns);

          
        }



        public async Task<ModuleRunDto?> UpdateModuleRun(ModuleRunDto moduleRunDto)
        {
            var moduleRun = await _context.ModuleRuns.FindAsync(moduleRunDto.ModuleRunId);

            if (moduleRun != null)
            {
                moduleRun.ModuleRunId = moduleRunDto.ModuleRunId;
                moduleRun.Code = moduleRunDto.Code;
              
                moduleRun.ModuleId = moduleRunDto.ModuleId;
                moduleRun.Place = moduleRunDto.Place;
                moduleRun.SemesterId = moduleRunDto.SemesterId;
                moduleRun.isSelected = moduleRunDto.isSelected;
              

                await _context.SaveChangesAsync();

                return mapper.Map<ModuleRunDto>(moduleRun);
            }
            return null;
           

        }
        
        public async Task<bool> DeleteModuleRun(int moduleRunId)
        {
            var moduleRun = await _context.ModuleRuns.FindAsync(moduleRunId);
            if (moduleRun != null)
            {
                //moduleRun.IsDeleted = true;
                //moduleRun.DeletedAt = DateTime.Now;
                _context.ModuleRuns.Remove(moduleRun);
                foreach (var lm in moduleRun.LecturersMR) {
                    _context.LecturersModuleRuns.Remove(lm);
                }
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<IEnumerable<ModuleRun>> Search(string name, string code)
        {
            IQueryable<ModuleRun> query = _context.ModuleRuns;
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


    }
}
