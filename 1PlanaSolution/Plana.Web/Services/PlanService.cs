using Microsoft.AspNetCore.Components;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public class PlanService : IPlanService
    {
        private readonly HttpClient http;

        public PlanService(HttpClient http) {
            this.http = http;
        }
        public async Task<Plan> CreatePlan(Plan plan)
        {
            return await http.PostJsonAsync<Plan>("api/plan", plan);
        }

        public async Task<Plan> GetPlan(int id)
        {
            return await http.GetJsonAsync<Plan>($"api/plan/{id}");
        }

        public async Task<IEnumerable<Plan>> GetPlans()
        {
            return await http.GetJsonAsync<Plan[]>("api/plan");
        }

        public Task SoftDeletePlan(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePlan(Plan plan)
        {
           await http.PutJsonAsync<Plan>("api/plan", plan);
        }
    }
}
