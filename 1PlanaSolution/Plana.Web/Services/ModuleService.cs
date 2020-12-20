using Microsoft.AspNetCore.Components;
using Plana.Models;
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
        public async Task<Module> CreateModule(Module newModule)
        {
            return await httpClient.PostJsonAsync<Module>("api/admin/modules", newModule);
        }

        public async Task<Module> GetModule(int id)
        {
            return await httpClient.GetJsonAsync<Module>($"api/admin/modules/{id}");
        }

        public async Task<IEnumerable<Module>> GetModules()
        {
            return await httpClient.GetJsonAsync<Module[]>("api/admin/modules");
        }

        public  Task SoftDeleteModule(int id)
        {
            throw new NotImplementedException();
            //await httpClient.DeleteAsync($"api/admin/modules/{id}");
        }

        public async Task<Module> UpdateModule(Module module)
        {
            return await httpClient.PutJsonAsync<Module>("api/admin/modules", module);

        }
    }
}
