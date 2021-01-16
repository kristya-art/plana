using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plana.Api.Models;
using Plana.Api.Repositories;
using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public class PlanService : IPlanService
    {
        private readonly AppDbContext _context;
        private readonly ISemesterService _semesterService;
        private readonly IMapper _mapper;
        
        
        public PlanService(AppDbContext context, 
                           ISemesterService semesterService ,
                           IMapper mapper)
        {
                _context = context;
                _semesterService = semesterService;
                _mapper = mapper;
               

        }
      

        public async Task<PlanDto> AddPlan(PlanDto planDto)
        {
            var plan = new Plan();
            
           _mapper.Map(planDto, plan);
            
            var result = await _context.Plans.AddAsync(plan);

            
            //plan.LastYear= plan.FindLastYearPlan();
            plan.FindLastYearPlan();
            foreach (var l in _context.Lecturers) {

                plan.PlanLecturers.Add(new PlanLecturer() { PlanId = plan.Id, LecturerId = l.Id });
            }
            await _context.SaveChangesAsync();
            
             return _mapper.Map<PlanDto>(result.Entity);
        }

        

        public async Task<IEnumerable<PlanDto>> GetAllPlans()
        {
           var plans = await _context.Plans
                   .Include(x => x.AutumnSemester)
                   //.Include(x=>x.Semesters)
                   .ThenInclude(xa => xa.ModuleRuns)
                   .Include(x => x.SpringSemester)
                  .ThenInclude(xs => xs.ModuleRuns)

                .ToListAsync();
            return _mapper.Map<IEnumerable<PlanDto>>(plans);
        }

        public async Task<PlanDto> GetPlan(int planId)
        {
             var result = await _context.Plans
                   .Include(e => e.AutumnSemester)
                       //.Include(e=>e.Semesters)
                       .ThenInclude(s => s.ModuleRuns)
                           .ThenInclude(mr => mr.LecturersMR)
                               .ThenInclude(l => l.Lecturer)
                  //.Include(e=>e.Semesters)
                  .Include(e => e.AutumnSemester)
                      .ThenInclude(s => s.ModuleRuns)
                          .ThenInclude(m => m.Module)
                  .Include(e => e.AutumnSemester)
                    //.Include(e=>e.Semesters)
                    .ThenInclude(a => a.AdditionalAssignments)

   .Include(e => e.SpringSemester)
                       //.Include(e=>e.Semesters)
                       .ThenInclude(s => s.ModuleRuns)
                           .ThenInclude(mr => mr.LecturersMR)
                               .ThenInclude(l => l.Lecturer)
                  //.Include(e=>e.Semesters)
                  .Include(e => e.SpringSemester)
                      .ThenInclude(s => s.ModuleRuns)
                          .ThenInclude(m => m.Module)
                  .Include(e => e.SpringSemester)
                    //.Include(e=>e.Semesters)
                    .ThenInclude(a => a.AdditionalAssignments)



                   .Include(e => e.PlanLecturers)
                   
               .FirstOrDefaultAsync(e => e.Id == planId);

            return _mapper.Map<PlanDto>(result);

           
        }

        private Plan NotFound()
        {
            throw new NotImplementedException();
        }


        public void AddSemester(Semester semester) {
            if (semester != null) { 
              
            
            }
        }

        public async Task<PlanDto?> UpdatePlan(PlanDto planDto)
        {
            var result = await GetPlan(planDto.Id);
            if (result != null)
            {
                result.Year = planDto.Year;
                if (planDto.SpringSemester != null)
                {
                    result.SpringSemester = planDto.SpringSemester;
                    await _semesterService.UpdateSemester(result.SpringSemester);
                }
                if (planDto.AutumnSemester != null)
                {
                    result.AutumnSemester = planDto.AutumnSemester;
                    await _semesterService.UpdateSemester(result.AutumnSemester);
                }
                if (planDto.PlanLecturers != null)
                {
                    result.PlanLecturers = planDto.PlanLecturers;
                }
                result.OfficialPublishDate = planDto.OfficialPublishDate;
                result.IsModifyable = planDto.IsModifyable;
                result.IsFixed = planDto.IsFixed;
                result.PublishDateForProfessors = planDto.PublishDateForProfessors;

               await _context.SaveChangesAsync();

                return _mapper.Map<PlanDto>(result);
            }
            return null;
        }

       
        public async Task<PlanDto> FindLastYearPlan(int planId)
        {
            var plan = await GetPlan(planId);
            var foundPlan = new Plan();
           
            foreach (Plan p in _context.Plans)
            {
                 if (p.Year == plan.LastYear)
                {
                    foundPlan = await _context.Plans.FindAsync(p.Id);
                   
                 }
                
                else { return null; }

            } 
            return _mapper.Map<PlanDto>(foundPlan);
            
        }
        public async Task<bool> DeletePlan(int planId)
        {
            var plan = await _context.Plans.FindAsync(planId);
            if (plan != null)
            {
                
                _context.Plans.Remove(plan);
                foreach (var pl in plan.PlanLecturers)
                {
                    _context.PlanLecturers.Remove(pl);
                }
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }


    }
}
