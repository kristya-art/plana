using Microsoft.AspNetCore.Components;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public class PlanLecturerService : IPlanLecturerService
    {
        private readonly HttpClient http;

        public PlanLecturerService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<PlanLecturer> CreatePlanLecturer(PlanLecturer planLecturer)
        {
            return await http.PostJsonAsync<PlanLecturer>("api/planLecturer", planLecturer);
        }
        
        public async Task<PlanLecturer> GetPlanLecturer(int id, int id2)
        {
            return await http.GetJsonAsync<PlanLecturer>($"api/planLecturer/{id}/{id2}");
        }

        public async Task<IEnumerable<PlanLecturer>> GetPlanLecturers()
        {
            return await http.GetJsonAsync<PlanLecturer[]>("api/planLecturer");
        }

        public async Task SoftDeletePlanLecturer(int id, int id2)
        {
            await http.DeleteAsync($"api/planLecturer/{id}/{id2}");
        }

        public async Task UpdatePlanLecturer(PlanLecturer planLecturer)
        {
            await http.PutJsonAsync<PlanLecturer>("api/planLecturer", planLecturer); 
        }
    }
}
