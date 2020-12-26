using Plana.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface IPlanLecturerService
    {
        Task<IEnumerable<PlanLecturer>> GetPlanLecturers();

        Task<IEnumerable<PlanLecturer>> Search(string name);
        
        Task<PlanLecturer> GetPlanLecturer(int planId, int lecturerId);

        Task<PlanLecturer> AddPlanLecturer(PlanLecturer planLecturer);
        
        Task<PlanLecturer> UpdatePlanLecturer(PlanLecturer planLecturer);

        Task<bool> DeletePlanLecturer(int planId, int lecturerId);

        // TODO: Put in correct interface
        Task<IEnumerable<ModuleRun>> GetLecturerModuleRuns(int planId, int lecturerId);
    }
}
