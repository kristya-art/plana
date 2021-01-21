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
                return new ActionResultDto<ModuleRunLecturerGroupDto>("This group has already been added.");
            }

            
            var result = await context.ModuleRunLecturerGroups.AddAsync(moduleRunLecturerGroup);
            await context.SaveChangesAsync();

                LecturerGroup lg = new LecturerGroup();
                lg = await context.LecturerGroups.FindAsync(moduleRunLecturerGroup.LecturerGroupId);
                

                LecturerLecturerGroup llg = new LecturerLecturerGroup();
                

                var moduleRunId = moduleRunLecturerGroup.ModuleRunId;

                foreach (var l in lg.LecturerLecturerGroup)
                {
                    
                    var moduleRunLecturer = new LecturerModuleRun()
                    {
                        LecturerId = l.Lecturer.Id,
                        ModuleRunId = moduleRunId

                    };
                bool containsModuleRunLecturer = await context.LecturersModuleRuns.ContainsAsync(moduleRunLecturer);
                if (!containsModuleRunLecturer) {
                    context.LecturersModuleRuns.Add(moduleRunLecturer);
                    await context.SaveChangesAsync();
                }
                   
          }
                 return mapper.Map<ModuleRunLecturerGroupDto>(result.Entity);
        }

       

       


        public async Task<bool> DeleteModuleRunLecturerGroup(int moduleRunId, int lecturerId)
        {
            var moduleRunLecturerGroup = await context.ModuleRunLecturerGroups.FindAsync(moduleRunId, lecturerId);

            LecturerGroup lg = new LecturerGroup();
            lg = await context.LecturerGroups.FindAsync(moduleRunLecturerGroup.LecturerGroupId);

            if (moduleRunLecturerGroup != null)
            {
              
                context.ModuleRunLecturerGroups.Remove(moduleRunLecturerGroup);
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

        public async Task<ModuleRunLecturerGroupDto?> UpdateModuleRunLecturerGroup(ModuleRunLecturerGroupDto ModuleRunLecturerGroupDto)
        {
            var result = await context.ModuleRunLecturerGroups.FindAsync(ModuleRunLecturerGroupDto.ModuleRunId, ModuleRunLecturerGroupDto.LecturerGroupId);
            if (result != null)
            {
                result.ModuleRunId = ModuleRunLecturerGroupDto.ModuleRunId;
                result.LecturerGroupId = ModuleRunLecturerGroupDto.LecturerGroupId;
              
                await context.SaveChangesAsync();

                return mapper.Map<ModuleRunLecturerGroupDto>(result);
            }

            return null;
        }
    }
}
