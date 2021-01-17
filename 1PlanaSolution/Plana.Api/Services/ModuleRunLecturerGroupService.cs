using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using Plana.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public class ModuleRunLecturerGroupService : IModuleRunLecturerGroupService
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public ModuleRunLecturerGroupService(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<ActionResultDto<ModuleRunLecturerGroupDto>> AddModuleRunLecturerGroup(ModuleRunLecturerGroupDto moduleRunLecturerGroupDto)
        {
            var moduleRunLecturerGroup = new ModuleRunLecturerGroup();
            mapper.Map(moduleRunLecturerGroupDto, moduleRunLecturerGroup);
           

            bool containsModelRun = await context.ModuleRunLecturerGroups.ContainsAsync(moduleRunLecturerGroup);
            if (containsModelRun)
            {
                return new ActionResultDto<ModuleRunLecturerGroupDto>("Lecturer has already been added.");
            }

            
            var result = await context.ModuleRunLecturerGroups.AddAsync(moduleRunLecturerGroup);
            await context.SaveChangesAsync();

            // 2nd try
            
            //if (moduleRunLecturerGroup.LecturerGroup != null)
            //{
                LecturerGroup lg = new LecturerGroup();
                lg = await context.LecturerGroups.FindAsync(moduleRunLecturerGroup.LecturerGroupId);
                //lg = moduleRunLecturerGroup.LecturerGroup;

                //List<LecturerLecturerGroup> llg = new List<LecturerLecturerGroup>();

                //llg = (List<LecturerLecturerGroup>)lg.LecturerLecturerGroup;

                LecturerLecturerGroup llg = new LecturerLecturerGroup();
                

                var moduleRunId = moduleRunLecturerGroup.ModuleRunId;

                foreach (var l in lg.LecturerLecturerGroup)
                {

                    var moduleRunLecturer = new LecturerModuleRun()
                    {
                        LecturerId = l.Lecturer.Id,
                        ModuleRunId = moduleRunId

                    };
                    context.LecturersModuleRuns.Add(moduleRunLecturer);
                    await context.SaveChangesAsync();
               // }
            }

            //
            return mapper.Map<ModuleRunLecturerGroupDto>(result.Entity);
        }

        //public async Task<ModuleRunLecturerGroupDto> AddModuleRunLecturerGroup(ModuleRunLecturerGroupDto moduleRunLecturerGroupDto) {
        //    var moduleRunLecturerGroup = new ModuleRunLecturerGroup();
        //    mapper.Map(moduleRunLecturerGroupDto, moduleRunLecturerGroup);

        //    var result = await context.ModuleRunLecturerGroups.AddAsync(moduleRunLecturerGroup);

        //    LecturerGroup lg = new LecturerGroup();
        //    List<LecturerLecturerGroup> llg = (List<LecturerLecturerGroup>)lg.LecturerLecturerGroup;
        //    lg = moduleRunLecturerGroup.LecturerGroup;

        //    var moduleRun = moduleRunLecturerGroup.ModuleRun;

        //    foreach (var l in llg) {

        //        var moduleRunLecturer = new LecturerModuleRun()
        //       {
        //           LecturerId = l.LecturerId,
        //          ModuleRunId = moduleRun.ModuleRunId

        //         };
        //        context.LecturersModuleRuns.Add(moduleRunLecturer);
        //        await context.SaveChangesAsync();
        //    }

        //}

       


        public async Task<bool> DeleteModuleRunLecturerGroup(int moduleRunId, int lecturerId)
        {
            var ModuleRunLecturerGroup = await context.ModuleRunLecturerGroups.FindAsync(moduleRunId, lecturerId);
            if (ModuleRunLecturerGroup != null)
            {
                context.ModuleRunLecturerGroups.Remove(ModuleRunLecturerGroup);
                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<ModuleRunLecturerGroupDto> GetModuleRunLecturerGroup(int moduleRunId, int lecturerId)
        {
            var lecturerModuelRun = await context.ModuleRunLecturerGroups.FindAsync(moduleRunId, lecturerId);
            return mapper.Map<ModuleRunLecturerGroupDto>(lecturerModuelRun);
        }

        public async Task<IEnumerable<ModuleRunLecturerGroupDto>> GetModuleRunLecturerGroups()
        {
            var ModuleRunLecturerGroups = await context.ModuleRunLecturerGroups.ToListAsync();
            return mapper.Map<IEnumerable<ModuleRunLecturerGroupDto>>(ModuleRunLecturerGroups);
        }

        public async Task<ModuleRunLecturerGroupDto> UpdateModuleRunLecturerGroup(ModuleRunLecturerGroupDto ModuleRunLecturerGroupDto)
        {
            var result = await context.ModuleRunLecturerGroups.FindAsync(ModuleRunLecturerGroupDto.ModuleRunId, ModuleRunLecturerGroupDto.LecturerGroupId);
            if (result != null)
            {
                result.ModuleRunId = ModuleRunLecturerGroupDto.ModuleRunId;
                result.LecturerGroupId = ModuleRunLecturerGroupDto.LecturerGroupId;
               
               // result.Hours = ModuleRunLecturerGroupDto.Hours;
               // result.DesiredHours = ModuleRunLecturerGroupDto.DesiredHours;
              
               // result.IsRequested = ModuleRunLecturerGroupDto.IsRequested;
                await context.SaveChangesAsync();

                return mapper.Map<ModuleRunLecturerGroupDto>(result);
            }

            return null;
        }
    }
}
