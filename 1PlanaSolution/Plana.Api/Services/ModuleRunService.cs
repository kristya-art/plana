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
        //private readonly ILecturerService lecturerService;
        //private readonly SemesterRepository srep;

        public ModuleRunService(AppDbContext context, IMapper mapper)
        {
            _context = context;

            this.mapper = mapper;
        }
      

        public async Task<ModuleRunDto> CreateModuleRun(ModuleRunDto moduleRunDto )
        {
            var moduleRun = new ModuleRun();
            mapper.Map(moduleRunDto, moduleRun);

            var result = await _context.ModuleRuns.AddAsync(moduleRun);
            await _context.SaveChangesAsync();

            return mapper.Map<ModuleRunDto>(result.Entity);
           
        }

        public async Task<ModuleRunDto> GetModuleRun(int moduleRunId)
        {
            var moduleRun = await _context.ModuleRuns.FindAsync(moduleRunId);
            return mapper.Map<ModuleRunDto>(moduleRun);
           //     .Include(m=>m.LecturersMR)
           //     .ThenInclude(lmr=>lmr.Lecturer)
           //  //   .Include(m=>m.Semester)
           //  //   .Include(m=>m.Module)
           //.FirstOrDefaultAsync(e => e.ModuleRunId == moduleRunId);

        }

        public async Task<IEnumerable<ModuleRunDto>> GetModuleRuns()
        {
            var moduleRuns = await _context.ModuleRuns.ToListAsync();
            return mapper.Map<IEnumerable<ModuleRunDto>>(moduleRuns);

            //return await appDbContext.ModuleRuns
            //    .Include(m => m.Module)
            //    .Include(m => m.LecturersMR)
            //    .ThenInclude(lmr => lmr.Lecturer)
            //    .OrderBy(m => m.Module.Title)
            //    .ToListAsync();
        }



        public async Task<ModuleRunDto> UpdateModuleRun(ModuleRunDto moduleRunDto)
        {
            var moduleRun = await _context.ModuleRuns.FindAsync(moduleRunDto.ModuleRunId);

            if (moduleRun != null)
            {
                moduleRun.ModuleRunId = moduleRunDto.ModuleRunId;
                moduleRun.Code = moduleRunDto.Code;
              
                moduleRun.ModuleId = moduleRunDto.ModuleId;
                moduleRun.Place = moduleRunDto.Place;
                moduleRun.SemesterId = moduleRunDto.SemesterId;
              //  moduleRun.ModuleGroup.ModuleGroupId = moduleRunDto.ModuleGroup.ModuleGroupId;
                
                //  moduleRun.LecturersMR = moduleRunDto.LecturersMR;
                //  moduleRun.ModuleRunLecturerGroups = moduleRunDto.ModuleRunLecturerGroups;

                await _context.SaveChangesAsync();

                return mapper.Map<ModuleRunDto>(moduleRun);
            }
            return null;
            //var result = await GetModuleRun(moduleRun.ModuleRunId);
            //if (result != null)
            //{
            //    result.Code = moduleRun.Code;

            //    //result.LecturersMR = moduleRun.LecturersMR;


            //    result.Module = moduleRun.Module;

            // //   result.ModuleId = moduleRun.ModuleId;

            //    result.Place = moduleRun.Place;

            //    foreach (var LMR in moduleRun.LecturersMR) {
            //        if (!result.LecturersMR.Contains(LMR))
            //        {
            //            result.LecturersMR.Add(new LecturerModuleRun { LecturerId = LMR.LecturerId, ModuleRunId = LMR.ModuleRunId });
            //        }

            //    }

            //   

            //    //result.ModuleRunLecturerGroups = moduleRun.ModuleRunLecturerGroups;
            //    result.SemesterId = moduleRun.SemesterId;

            //    result.ModuleGroup = moduleRun.ModuleGroup;

            //    await appDbContext.SaveChangesAsync();

            //    return result;

            //}
            //return null;

        }
        //public async Task<LecturerModuleRunDto> AddLecturerToModuleRun(ModuleRunDto moduleRun,LecturerDto lecturer)
        //{
        //    LecturerModuleRunDto result = new LecturerModuleRunDto { LecturerId = lecturer.Id, ModuleRunId = moduleRun.Id }
        //    if (CheckLecturer(moduleRun, lecturer))
        //    {
        //        moduleRun.LecturersMR.Add(result);

        //    }
            
        //    mapper.Map<LecturerModuleRunDto>(result);
        //}
        
        //public bool CheckLecturer(ModuleRunDto moduleRun, LecturerDto lecturer) {

        //    foreach (var LMR in moduleRun.LecturersMR)
        //    {
        //        if (moduleRun.LecturersMR.Contains(LMR))
        //        {
        //            return false;
        //        }
        //        return true;
        //    }
        //    return true;
        //}
        public async Task<bool> DeleteModuleRun(int moduleRunId)
        {
            var moduleRun = await _context.ModuleRuns.FindAsync(moduleRunId);
            if (moduleRun != null)
            {
                moduleRun.IsDeleted = true;
                moduleRun.DeletedAt = DateTime.Now;

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
