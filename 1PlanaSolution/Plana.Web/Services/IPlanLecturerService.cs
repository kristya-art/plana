using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public interface IPlanLecturerService
    {
        Task<IEnumerable<PlanLecturer>> GetPlanLecturers();
        Task<PlanLecturer> GetPlanLecturer(int id,int id2);
        Task UpdatePlanLecturer(PlanLecturer planLecturer);
        Task<PlanLecturer> CreatePlanLecturer(PlanLecturer planLecturer);
        Task SoftDeletePlanLecturer(int id, int id2);
    }
}
