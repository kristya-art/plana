﻿using Microsoft.AspNetCore.Components;
using Plana.Models;
using Plana.Shared;
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

        public async Task<PlanDto> CreatePlan(PlanDto plan)
        {
            return await http.PostJsonAsync<PlanDto>("api/plan", plan);
        }

        

        public async Task<PlanDto> GetPlan(int id)
        {
            return await http.GetJsonAsync<PlanDto>($"api/plan/{id}");
        }

        public async Task<IEnumerable<PlanDto>> GetPlans()
        {
            return await http.GetJsonAsync<PlanDto[]>("api/plan");
        }

        public Task SoftDeletePlan(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PlanDto> UpdatePlan(PlanDto plan)
        {
           return await http.PutJsonAsync<PlanDto>("api/plan", plan);
        }

        public async Task<PlanDto> LastYearPlan(int id)
        {
            return await http.GetJsonAsync<PlanDto>($"api/plan/lastYearPlan/{id}");

        }
        public async Task DeletePlan(int id)
        {
            await http.DeleteAsync($"api/plan/{id}");


        }
    }
}
