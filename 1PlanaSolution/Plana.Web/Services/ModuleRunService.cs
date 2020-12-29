using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Plana.Shared;

namespace Plana.Web.Services
{
    public class ModuleRunService : IModuleRunService
    {
        private readonly HttpClient httpClient;
        public ModuleRunService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ModuleRunDto> CreateModuleRun(ModuleRunDto newModuleRun)
        {
            return await httpClient.PostJsonAsync<ModuleRunDto>("api/modulerun",newModuleRun);
        }

        public async Task<ModuleRunDto> GetModuleRun(int id)
        {
            return await httpClient.GetJsonAsync<ModuleRunDto>($"api/modulerun/{id}");
        }

        public async  Task<IEnumerable<ModuleRunDto>> GetModuleRuns()
        {
            return await httpClient.GetJsonAsync<ModuleRunDto[]>("api/modulerun");
        }

        public  Task SoftDeleteModuleRun(int id)
        {
            throw new NotImplementedException();
           // await httpClient.DeleteAsync($"api/modulerun/{id}");

        }

        public async Task<ModuleRunDto> UpdateModuleRun(ModuleRunDto moduleRun)
        {
            return await httpClient.PutJsonAsync<ModuleRunDto>("api/modulerun", moduleRun);

        }
    }
}
