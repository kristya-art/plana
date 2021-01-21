using Microsoft.AspNetCore.Components;
using Plana.Models;
using Plana.Shared;
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
        public async Task<PlanLecturerDto> CreatePlanLecturer(PlanLecturerDto planLecturer)
        {
            return await http.PostJsonAsync<PlanLecturerDto>("api/planLecturer", planLecturer);
        }

        public async Task<IEnumerable<ModuleRunDto>> GetModuleRunsForPlan(int id, int id2)
        {
            return await http.GetJsonAsync<ModuleRunDto[]>($"api/planLecturer/moduleRuns/{id}/{id2}");
        }

        public async Task<PlanLecturerDto> GetPlanLecturer(int id, int id2)
        {
            return await http.GetJsonAsync<PlanLecturerDto>($"api/planLecturer/{id}/{id2}");
        }

        public async Task<IEnumerable<PlanLecturerDto>> GetPlanLecturers()
        {
            return await http.GetJsonAsync<PlanLecturerDto[]>("api/planLecturer");
        }

        public async Task SoftDeletePlanLecturer(int id, int id2)
        {
            await http.DeleteAsync($"api/planLecturer/{id}/{id2}");
        }

        public async Task UpdatePlanLecturer(PlanLecturerDto planLecturer)
        {
            await http.PutJsonAsync<PlanLecturerDto>("api/planLecturer", planLecturer); 
        }

        //public async Task<IEnumerable<PlanLecturerDto>> AddLecturersToPlan(PlanDto plan, List<LecturerDto> lecturers)
        //{
        //    await http.GetJsonAsync<PlanLecturerDto[]>($"api/planLecturer/addLecturersToPlan");
        //}
    }
}
