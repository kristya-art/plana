using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Shared;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace Plana.Web.Services
{
    public class LecturerModuleRunService : ILecturerModuleRunService
    {
        private readonly HttpClient http;

        public LecturerModuleRunService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<LecturerModuleRunDto> CreateLecturerModuleRun(LecturerModuleRunDto lecturerModuleRun)
        {
            return await http.PostJsonAsync<LecturerModuleRunDto>("api/lecturerModuleRun", lecturerModuleRun );
        }

        public async Task DeleteLecturerModuleRun(int id, int id2)
        {
            await http.DeleteAsync($"api/lecturerModuleRun/{id}/{id2}");
        }

        public async Task<LecturerModuleRunDto> GetLecturerModuleRun(int id, int id2)
        {
            return await http.GetJsonAsync<LecturerModuleRunDto>($"api/lecturerModuleRun/{id}/{id2}");

        }

        public async Task<IEnumerable<LecturerModuleRunDto>> GetLecturerModuleRuns()
        {
            return await http.GetJsonAsync<LecturerModuleRunDto[]>("api/lecturerModuleRun");

        }

        public async Task UpdateLecturerModuleRun(LecturerModuleRunDto lecturerModuleRun)
        {
            await http.PutJsonAsync<LecturerModuleRunDto>("api/lecturerModuleRun", lecturerModuleRun);

        }
    }
}
