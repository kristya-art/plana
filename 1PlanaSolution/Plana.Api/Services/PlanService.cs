using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plana.Api.BizLogic;
using Plana.Api.Models;
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
        private readonly CreatePlanAction _action;
        
        public PlanService(AppDbContext context, 
                           ISemesterRepository semesterRepository)
        {
            _context = context;
            _semesterRepository = semesterRepository;

        }
      

        public async Task<Plan> AddPlan(Plan plan)
        {
            
            var result = await _context.Plans.AddAsync(plan);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

      

        public async Task<IEnumerable<Plan>> GetAllPlans()
        {
           return await _context.Plans
                   .Include(x => x.AutumnSemester)
                   .ThenInclude(xa => xa.ModuleRuns)
                   .Include(x => x.SpringSemester)
                   .ThenInclude(xs => xs.ModuleRuns)

                .ToListAsync();
        }

        public async Task<Plan> GetPlan(int planId)
        {
            return await _context.Plans.FindAsync(planId);
        }




        public async Task<Plan> UpdatePlan(Plan plan)
        {
            var result = await GetPlan(plan.Id);
            if (result != null)
            {
                result.Year = plan.Year;
                result.ExpiredDate = plan.ExpiredDate;
                result.IsFixed = plan.IsFixed;
                result.OfficialPublishDate = plan.OfficialPublishDate;
                result.PlanLecturers = plan.PlanLecturers;

                result.AutumnSemester = plan.AutumnSemester;
                result.SpringSemester = plan.SpringSemester;
                if (plan.SpringSemester != null)
                {
                    await _semesterRepository.UpdateSemester(plan.SpringSemester);
                }
                if (plan.AutumnSemester != null)
                {
                    await _semesterRepository.UpdateSemester(plan.AutumnSemester);
                }
                //result.SpringSemester.LecturersSemesters = plan.SpringSemester.LecturersSemesters;
                //result.AutumnSemester.LecturersSemesters = plan.AutumnSemester.LecturersSemesters;


                

                await _context.SaveChangesAsync();

                return result;
            }
            return null;

        }


        public void AddSemester(Semester semester) {
            if (semester != null) { 
              
            
            }
        }
    }
}
