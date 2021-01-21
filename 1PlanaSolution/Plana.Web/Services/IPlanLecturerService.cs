using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public interface IPlanLecturerService
    {
        Task<IEnumerable<PlanLecturerDto>> GetPlanLecturers();
        Task<PlanLecturerDto> GetPlanLecturer(int id,int id2);
        Task UpdatePlanLecturer(PlanLecturerDto planLecturer);
        Task<PlanLecturerDto> CreatePlanLecturer(PlanLecturerDto planLecturer);
        Task SoftDeletePlanLecturer(int id, int id2);
        Task<IEnumerable<ModuleRunDto>> GetModuleRunsForPlan(int id, int id2);

        //Task<IEnumerable<PlanLecturerDto>> AddLecturersToPlan(PlanDto plan, List<LecturerDto> lecturers);
    }
}
