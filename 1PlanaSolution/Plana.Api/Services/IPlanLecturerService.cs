using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface IPlanLecturerService
    {
        Task<IEnumerable<PlanLecturer>> GetPlanLecturers();

        Task<PlanLecturer> AddPlanLecturer(PlanLecturer planLecturer);
        Task<PlanLecturer> UpdatePlanLecturer(PlanLecturer planLecturer);
        
        Task<PlanLecturer> GetPlanLecturer(int id, int id2);


        Task<IEnumerable<PlanLecturer>> Search(string name);

        Task<Boolean> DeletePlanLecturer(int id,int id2);


        Task<Boolean> SoftDeletePlanLecturer(int id, int id2);
    }
}
