using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public interface IPlanService
    {
        Task<IEnumerable<Plan>> GetPlans();
        Task<Plan> GetPlan(int id);
        Task UpdatePlan(Plan plan);
        Task<Plan> CreatePlan(Plan plan);
        Task SoftDeletePlan(int id);
    }
}
