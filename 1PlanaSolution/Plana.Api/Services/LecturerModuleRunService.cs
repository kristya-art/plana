using AutoMapper;
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
    public class LecturerModuleRunService : ILecturerModuleRunService
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;


        public LecturerModuleRunService(AppDbContext context, IMapper mapper)
        {
            this.context = context;

            this.mapper = mapper;
        }
        public async Task<LecturerModuleRunDto> AddLecturerModuleRun(LecturerModuleRunDto lecturerModuleRunDto)
        {
            var lecturerModuleRun = new LecturerModuleRun();
            mapper.Map(lecturerModuleRunDto,lecturerModuleRun);
            
            var result = await context.LecturersModuleRuns.AddAsync(lecturerModuleRun);


            await context.SaveChangesAsync();
            return mapper.Map<LecturerModuleRunDto>(result.Entity);
        }

        public async Task<bool> DeleteLecturerModuleRun(int moduleRunId, int lecturerId)
        {
            var lecturerModuleRun = await context.LecturersModuleRuns.FindAsync(moduleRunId,lecturerId);
            if (lecturerModuleRun != null)
            {
                lecturerModuleRun.IsDeleted = true;
                lecturerModuleRun.DeletedAt = DateTime.Now;

                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<LecturerModuleRunDto> GetLecturerModuleRun(int moduleRunId, int lecturerId)
        {
           
            var lecturerModuelRun = await context.LecturersModuleRuns.FindAsync(moduleRunId,  lecturerId);
            return mapper.Map<LecturerModuleRunDto>(lecturerModuelRun);
        }

        public async Task<IEnumerable<LecturerModuleRunDto>> GetLecturerModuleRuns()
        {
           var lecturerModuleRuns=  await context.LecturersModuleRuns.ToListAsync();
            return mapper.Map<IEnumerable<LecturerModuleRunDto>>(lecturerModuleRuns);
        }

        public async Task<LecturerModuleRunDto> UpdateLecturerModuleRun(LecturerModuleRunDto lecturerModuleRunDto)
        {
            var result = await context.LecturersModuleRuns.FindAsync(lecturerModuleRunDto.ModuleRunId, lecturerModuleRunDto.LecturerId);
            if (result != null)
            {
                //result.Lecturer = lecturerModuleRun.Lecturer;
                //result.ModuleRun = lecturerModuleRun.ModuleRun;
                result.LecturerId = lecturerModuleRunDto.LecturerId;
                result.ModuleRunId = lecturerModuleRunDto.ModuleRunId;
                result.Lessons = lecturerModuleRunDto.Lessons;
                result.Hours = lecturerModuleRunDto.Hours;
                result.DesiredHours = lecturerModuleRunDto.DesiredHours;
                result.Notes = lecturerModuleRunDto.Notes;
                await context.SaveChangesAsync();

                return mapper.Map<LecturerModuleRunDto>(result);
            }

            return null;
        }

       

       
    }
}
