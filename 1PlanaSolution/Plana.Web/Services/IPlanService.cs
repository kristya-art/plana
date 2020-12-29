using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Shared;

namespace Plana.Web.Services
{
    public interface IPlanService
    {
        Task<IEnumerable<PlanDto>> GetPlans();
        Task<PlanDto> GetPlan(int id);
        Task UpdatePlan(PlanDto plan);
        Task<PlanDto> CreatePlan(PlanDto plan);
        Task SoftDeletePlan(int id);
    }
}
