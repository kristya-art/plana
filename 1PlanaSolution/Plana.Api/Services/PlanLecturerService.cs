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

        public async Task<PlanLecturerDto?> UpdatePlanLecturer(PlanLecturerDto planLecturerDto)
        {
            var planLecturer = await context.PlanLecturers.FindAsync(planLecturerDto.LecturerId, planLecturerDto.PlanId);
            if (planLecturer != null)
            {
                planLecturer.LecturerId = planLecturerDto.LecturerId;
                planLecturer.PlanId = planLecturerDto.PlanId;
                planLecturer.AnnualTarget = planLecturerDto.AnnualTarget;
                planLecturer.BalanceAccumulated = planLecturerDto.BalanceAccumulated;
                planLecturer.BalanceActual = planLecturerDto.BalanceActual;
                planLecturer.BalanceLastYear = planLecturerDto.BalanceLastYear;
                planLecturer.AAtotal = planLecturerDto.AAtotal;
                planLecturer.HStotal = planLecturerDto.HStotal;
                planLecturer.YearTotal = planLecturerDto.HStotal;

                await context.SaveChangesAsync();

                return mapper.Map<PlanLecturerDto>(planLecturer);
            }
            return null;
        }
        /** dosn't work*/
        public async Task<IEnumerable<ModuleRunDto>> GetLecturerModuleRuns(int planId,int lectId)
        {

            ICollection<ModuleRunDto> moduleRuns = new List<ModuleRunDto>();
            var result = await GetPlanLecturer(planId,lectId);
            ICollection<SemesterDto> semesters = new List<SemesterDto>();

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
                //return moduleRuns;

            }
            return mapper.Map<IEnumerable<ModuleRunDto>>(moduleRuns);
        }

        public async Task<IEnumerable<PlanLecturerDto>> AddLecturersToPlan(PlanDto plan, List<LecturerDto> lecturers)
        {
            var lecturersList = lecturers;
            

            foreach (var l in lecturers)
            {
                if (GetPlanLecturer(plan.Id, l.Id) == null)
                {
                    var PlanLecturer = new PlanLecturer()
                    {
                        PlanId = plan.Id,
                        LecturerId = l.Id
                    };
                    
                    context.PlanLecturers.Add(PlanLecturer);
                    await context.SaveChangesAsync();


                }

                
            }
            var planLecturers = await context.PlanLecturers.ToListAsync();
            return mapper.Map<IEnumerable<PlanLecturerDto>>(planLecturers);
        }

    }
}
