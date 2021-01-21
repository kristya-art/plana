using Microsoft.AspNetCore.Components;
using Plana.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public class LecturerModuleRunService : ILecturerModuleRunService
    {
        private readonly HttpClient http;

        public LecturerModuleRunService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<ActionResultDto<LecturerModuleRunDto>> CreateLecturerModuleRun(LecturerModuleRunDto lecturerModuleRun)
        {
            return await http.PostJsonAsync<ActionResultDto<LecturerModuleRunDto>>("api/lecturerModuleRun", lecturerModuleRun );
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
