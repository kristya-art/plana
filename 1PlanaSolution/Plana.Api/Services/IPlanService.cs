using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface IPlanService
    {
        Task<IEnumerable<PlanDto>> GetAllPlans();
        Task<PlanDto> AddPlan(PlanDto planDto);
        Task<PlanDto?> UpdatePlan(PlanDto planDto);
        Task<PlanDto> GetPlan(int planId);
        Task<PlanDto> FindLastYearPlan(int planId);
        Task<bool> DeletePlan(int planId);
    }
}
