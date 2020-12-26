using Plana.Models;
using Plana.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface IPlanLecturerService
    {
        Task<IEnumerable<PlanLecturerDto>> GetPlanLecturers();

        Task<IEnumerable<PlanLecturerDto>> Search(string name);
        
        Task<PlanLecturerDto> GetPlanLecturer(int planId, int lecturerId);

        Task<PlanLecturerDto> AddPlanLecturer(PlanLecturerDto planLecturer);
        
        Task<PlanLecturerDto> UpdatePlanLecturer(PlanLecturerDto planLecturer);

        Task<bool> DeletePlanLecturer(int planId, int lecturerId);

        // TODO: Put in correct interface
        Task<IEnumerable<ModuleRun>> GetLecturerModuleRuns(int planId, int lecturerId);
    }
}
