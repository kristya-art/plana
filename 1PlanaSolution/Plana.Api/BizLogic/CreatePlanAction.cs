using Plana.Api.Models;
using Plana.Api.Services;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.BizLogic
{
    public class CreatePlanAction : BizActionErrors
    {
        private readonly AppDbContext _context;
        private readonly SemesterRepository _semesterRepository;

        public CreatePlanAction(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Plan> Action(Plan plandto) {
            if (plandto == null) {
                AddError("You have to create plan before you save it");
                return null;
            }

            var createdPlan = new Plan
            {
               

                Year = plandto.Year,
                
            ExpiredDate = plandto.ExpiredDate,
            IsFixed = plandto.IsFixed,
            OfficialPublishDate = plandto.OfficialPublishDate,
           

        };
            //if (plandto.PlanLecturers != null)
            //{ createdPlan.PlanLecturers = plandto.PlanLecturers; }
            //if (plandto.AutumnSemester != null) {
            //    createdPlan.AutumnSemester = plandto.AutumnSemester;
            //}
            //if (plandto.SpringSemester != null) {
            //    createdPlan.SpringSemester = plandto.SpringSemester;
            //}

            if (!HasErrors)
                _context.Plans.Add(createdPlan);

            return HasErrors ? null : createdPlan;
               
        
        }
    }
}
