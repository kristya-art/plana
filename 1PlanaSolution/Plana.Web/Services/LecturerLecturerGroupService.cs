using Microsoft.AspNetCore.Components;
using Plana.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public class LecturerLecturerGroupService : ILecturerLecturerGroupService
    {
        private readonly HttpClient http;

        public LecturerLecturerGroupService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<ActionResultDto<LecturerLecturerGroupDto>> CreateLecturerLecturerGroup(LecturerLecturerGroupDto lecturerLecturerGroup)
        {
            return await http.PostJsonAsync<ActionResultDto<LecturerLecturerGroupDto>>("api/lecturerLecturerGroup", lecturerLecturerGroup);
        }

        public async Task DeleteLecturerLecturerGroup(int id, int id2)
        {
            await http.DeleteAsync($"api/lecturerLecturerGroup/{id}/{id2}");
        }

        public async Task<LecturerLecturerGroupDto> GetLecturerLecturerGroup(int id, int id2)
        {
            return await http.GetJsonAsync<LecturerLecturerGroupDto>($"api/lecturerLecturerGroup/{id}/{id2}");

        }

        public async Task<IEnumerable<LecturerLecturerGroupDto>> GetLecturerLecturerGroups()
        {
            return await http.GetJsonAsync<LecturerLecturerGroupDto[]>("api/lecturerLecturerGroup");

        }

        public async Task UpdateLecturerLecturerGroup(LecturerLecturerGroupDto lecturerLecturerGroup)
        {
            await http.PutJsonAsync<LecturerLecturerGroupDto>("api/lecturerLecturerGroup", lecturerLecturerGroup);

        }
    }
}
