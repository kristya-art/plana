using Microsoft.AspNetCore.Components;
using Plana.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public class ModuleRunLecturerGroupService : IModuleRunLecturerGroupService
    {
        private readonly HttpClient http;

        public ModuleRunLecturerGroupService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<ActionResultDto<ModuleRunLecturerGroupDto>> CreateModuleRunLecturerGroup(ModuleRunLecturerGroupDto ModuleRunLecturerGroup)
        {
            return await http.PostJsonAsync<ActionResultDto<ModuleRunLecturerGroupDto>>("api/ModuleRunLecturerGroup", ModuleRunLecturerGroup);
        }

        public async Task DeleteModuleRunLecturerGroup(int id, int id2)
        {
            await http.DeleteAsync($"api/ModuleRunLecturerGroup/{id}/{id2}");
        }

        public async Task<ModuleRunLecturerGroupDto> GetModuleRunLecturerGroup(int id, int id2)
        {
            return await http.GetJsonAsync<ModuleRunLecturerGroupDto>($"api/ModuleRunLecturerGroup/{id}/{id2}");

        }

        public async Task<IEnumerable<ModuleRunLecturerGroupDto>> GetModuleRunLecturerGroups()
        {
            return await http.GetJsonAsync<ModuleRunLecturerGroupDto[]>("api/ModuleRunLecturerGroup");

        }

        public async Task UpdateModuleRunLecturerGroup(ModuleRunLecturerGroupDto ModuleRunLecturerGroup)
        {
            await http.PutJsonAsync<ModuleRunLecturerGroupDto>("api/ModuleRunLecturerGroup", ModuleRunLecturerGroup);

        }
    }
}
