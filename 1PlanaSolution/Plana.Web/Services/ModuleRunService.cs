using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace Plana.Web.Services
{
    public class ModuleRunService : IModuleRunService
    {
        private readonly HttpClient httpClient;
        public ModuleRunService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ModuleRun> CreateModuleRun(ModuleRun newModuleRun)
        {
            return await httpClient.PostJsonAsync<ModuleRun>("api/modulerun",newModuleRun);
        }

        public async Task<ModuleRun> GetModuleRun(int id)
        {
            return await httpClient.GetJsonAsync<ModuleRun>($"api/modulerun/{id}");
        }

        public async  Task<IEnumerable<ModuleRun>> GetModuleRuns()
        {
            return await httpClient.GetJsonAsync<ModuleRun[]>("api/modulerun");
        }

        public  Task SoftDeleteModuleRun(int id)
        {
            throw new NotImplementedException();
           // await httpClient.DeleteAsync($"api/modulerun/{id}");

        }

        public async Task<ModuleRun> UpdateModuleRun(ModuleRun moduleRun)
        {
            return await httpClient.PutJsonAsync<ModuleRun>("api/modulerun", moduleRun);

        }
    }
}
