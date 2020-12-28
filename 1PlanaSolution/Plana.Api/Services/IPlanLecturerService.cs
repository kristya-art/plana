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

        Task<PlanLecturerDto> AddPlanLecturer(PlanLecturerDto planLecturerDto);
        
        Task<PlanLecturerDto?> UpdatePlanLecturer(PlanLecturerDto planLecturerDto);

        Task<bool> DeletePlanLecturer(int planId, int lecturerId);

        // TODO: Put in correct interface
        Task<IEnumerable<ModuleRunDto>> GetLecturerModuleRuns(int planId, int lecturerId);
    }
}
