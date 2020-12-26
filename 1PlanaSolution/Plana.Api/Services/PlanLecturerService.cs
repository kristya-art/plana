using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public class PlanLecturerService : IPlanLecturerService
    {
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        public PlanLecturerService(AppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<PlanLecturerDto> AddPlanLecturer(PlanLecturerDto planLecturerDto)
        {
            var planLecturer = new PlanLecturer();
            mapper.Map(planLecturerDto, planLecturer);

            var result = await context.PlanLecturers.AddAsync(planLecturer);
            await context.SaveChangesAsync();
            
            return mapper.Map<PlanLecturerDto>(result.Entity);
        }

        public async Task<bool> DeletePlanLecturer(int planId, int lecturerId)
        {
            var planLecturer = await context.PlanLecturers.FindAsync(planId, lecturerId);
            if (planLecturer != null)
            {
                planLecturer.IsDeleted = true;
                planLecturer.DeletedAt = DateTime.Now;

                await context.SaveChangesAsync();
                
                return true; 
            }
            
            return false;
        }

        public async Task<PlanLecturerDto> GetPlanLecturer(int planId, int lecturerId)
        {
            var planLecturer = await context.PlanLecturers.FindAsync(planId, lecturerId);
            return mapper.Map<PlanLecturerDto>(planLecturer);
        }

        public async Task<IEnumerable<PlanLecturerDto>> GetPlanLecturers()
        {
            var planLecturers = await context.PlanLecturers.ToListAsync();
            return mapper.Map<IEnumerable<PlanLecturerDto>>(planLecturers);
        }

        public Task<IEnumerable<PlanLecturerDto>> Search(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SoftDeletePlanLecturer(int id, int id2)
        {
            var result = await GetPlanLecturer(id, id2);
            if (result != null)
            {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now.Date;

                context.PlanLecturers.Update(result);
                await context.SaveChangesAsync();

                return true;
            }
            return false;
        }

        public async Task<PlanLecturerDto> UpdatePlanLecturer(PlanLecturerDto planLecturer)
        {
            var result = await context.PlanLecturers.FindAsync(planLecturer.LecturerId, planLecturer.PlanId);
            if (result != null)
            {
                result.LecturerId = planLecturer.LecturerId;
                result.PlanId = planLecturer.PlanId;
                result.AnnualTarget = planLecturer.AnnualTarget;
                result.BalanceAccumulated = planLecturer.BalanceAccumulated;
                result.BalanceActual = planLecturer.BalanceActual;
                result.BalanceLastYear = planLecturer.BalanceLastYear;

                await context.SaveChangesAsync();

                return result;
            }
            return null;
        }
        /** dosn't work*/
        public async Task<IEnumerable<ModuleRun>> GetLecturerModuleRuns(int planId,int lectId)
        {

            //planLecturer.LecturerId = lecturer.Id;
            //planLecturer.PlanId = plan.Id;
          
            ICollection<ModuleRun> moduleRuns = new List<ModuleRun>();
            var result = await GetPlanLecturer(planId,lectId);
            ICollection<Semester> semesters = new List<Semester>();

            if (result != null)
            {
                semesters.Add(result.Plan.AutumnSemester);
                semesters.Add(result.Plan.SpringSemester);
                foreach (var sem in semesters) 
                { 
                    foreach (var mr in sem.ModuleRuns)
                    {
                        
                            foreach (var mrl in mr.LecturersMR)
                            {
                                if (mrl.LecturerId == lectId)
                                {
                                    moduleRuns.Add(mr);
                                }
                            }
                        }

                    }
                return moduleRuns;

            }
            return moduleRuns;
        }
    }
}
