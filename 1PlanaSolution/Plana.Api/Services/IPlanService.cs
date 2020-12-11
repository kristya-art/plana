using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface IPlanService
    {
        Task<IEnumerable<Plan>> GetAllPlans();
        Task<Plan> AddPlan(Plan plan);
        Task<Plan> UpdatePlan(Plan plan);
        Task<Plan> GetPlan(int? planId);

    }
}
