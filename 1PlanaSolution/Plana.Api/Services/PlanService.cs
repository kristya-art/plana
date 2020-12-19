using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plana.Api.BizLogic;
using Plana.Api.Models;
using Plana.Api.Repositories;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public class PlanService : BizActionErrors, IPlanService
    {
        private readonly AppDbContext _context;
        private readonly ISemesterRepository _semesterRepository;
        
        
        public PlanService(AppDbContext context, 
                           ISemesterRepository semesterRepository )
        {
                _context = context;
                _semesterRepository = semesterRepository;
               

        }
      

        public async Task<Plan> AddPlan(Plan plan)
        {
            //Semester Ssemester = new Semester();
            //Semester Fsemester = new Semester();
            var result = await _context.Plans.AddAsync(plan);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

      

        public async Task<IEnumerable<Plan>> GetAllPlans()
        {
           return await _context.Plans
                   .Include(x => x.AutumnSemester)
                   //.Include(x=>x.Semesters)
                   .ThenInclude(xa => xa.ModuleRuns)
                   .Include(x => x.SpringSemester)
                  .ThenInclude(xs => xs.ModuleRuns)

                .ToListAsync();
        }

        public async Task<Plan> GetPlan(int? planId)
        {
            if (planId == null)
            {
                return NotFound();
            }
             
          var result = await _context.Plans
                 .Include(e => e.AutumnSemester)
                 //.Include(e=>e.Semesters)
                     .ThenInclude(s => s.ModuleRuns)
                         .ThenInclude(mr => mr.LecturersMR)
                             .ThenInclude(l => l.Lecturer)
                //.Include(e=>e.Semesters)
                .Include(e=>e.AutumnSemester)
                    .ThenInclude(s=>s.ModuleRuns)
                        .ThenInclude(m=>m.Module)
                .Include(e=>e.AutumnSemester)
                //.Include(e=>e.Semesters)
                  .ThenInclude(a=>a.AdditionalAssignments)

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
            return result;

            // return await _context.Plans.FindAsync(planId);
        }

        private Plan NotFound()
        {
            throw new NotImplementedException();
        }






        public void AddSemester(Semester semester) {
            if (semester != null) { 
              
            
            }
        }

        public async Task<Plan> UpdatePlan(Plan plan)
        {
            var result = await GetPlan(plan.Id);
            if (result != null)
            {
                result.Year = plan.Year;
                if (plan.SpringSemester != null)
                {
                    result.SpringSemester = plan.SpringSemester;
                    await _semesterRepository.UpdateSemester(result.SpringSemester);
                }
                if (plan.AutumnSemester != null)
                {
                    result.AutumnSemester = plan.AutumnSemester;
                    await _semesterRepository.UpdateSemester(result.AutumnSemester);
                }
                if (plan.PlanLecturers != null)
                {
                    result.PlanLecturers = plan.PlanLecturers;
                }
                result.OfficialPublishDate = plan.OfficialPublishDate;
                result.IsModifyable = plan.IsModifyable;
                result.IsFixed = plan.IsFixed;



                await _context.SaveChangesAsync();

                return result;
            }
            return null;
        }


    }
}
