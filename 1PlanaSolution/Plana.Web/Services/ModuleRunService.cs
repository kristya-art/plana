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
        public async Task<Semester> CreateModuleRun(ModuleRun moduleRun)
        {
            throw new NotImplementedException();
        }

        public async Task<ModuleRun> GetModuleRun(int id)
        {
            return await httpClient.GetJsonAsync<ModuleRun>($"api/moduleruns/{id}");
        }

        public async  Task<IEnumerable<ModuleRun>> GetModuleRuns()
        {
            return await httpClient.GetJsonAsync<ModuleRun[]>("api/moduleruns");
        }

        public  Task SoftDeleteModuleRun(int id)
        {
            throw new NotImplementedException();
           // await httpClient.DeleteAsync($"api/moduleruns/{id}");

        }

        public async Task<ModuleRun> UpdateModuleRun(ModuleRun moduleRun)
        {
            return await httpClient.PutJsonAsync<ModuleRun>("api/moduleruns", moduleRun);

        }
    }
}
