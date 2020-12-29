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
    public class ModuleService : IModuleService
    {
        private readonly HttpClient httpClient;
        public ModuleService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ModuleDto> CreateModule(ModuleDto newModule)
        {
            return await httpClient.PostJsonAsync<ModuleDto>("api/admin/modules", newModule);
        }

        public async Task<ModuleDto> GetModule(int id)
        {
            return await httpClient.GetJsonAsync<ModuleDto>($"api/admin/modules/{id}");
        }

        public async Task<IEnumerable<ModuleDto>> GetModules()
        {
            return await httpClient.GetJsonAsync<ModuleDto[]>("api/admin/modules");
        }

        public  Task SoftDeleteModule(int id)
        {
            throw new NotImplementedException();
            //await httpClient.DeleteAsync($"api/admin/modules/{id}");
        }

        public async Task<ModuleDto> UpdateModule(ModuleDto module)
        {
            return await httpClient.PutJsonAsync<ModuleDto>("api/admin/modules", module);

        }
    }
}
