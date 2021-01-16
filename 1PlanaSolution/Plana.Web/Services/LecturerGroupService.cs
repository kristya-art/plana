using Plana.Models;
using Plana.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
namespace Plana.Web.Services

{
    public class LecturerGroupService : ILecturerGroupService
    {
        private readonly HttpClient httpClient;

        public LecturerGroupService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        



        public async Task<LecturerGroupDto> GetLecturerGroup(int id)
        {
            return await httpClient.GetJsonAsync<LecturerGroupDto>($"api/lecturerGroup/{id}");
        }


        public async Task<IEnumerable<LecturerGroupDto>> GetLecturerGroups()
        {
            return await httpClient.GetJsonAsync<LecturerGroupDto[]>("api/lecturerGroup");
        }


        public async Task<LecturerGroupDto> UpdateLecturerGroup(LecturerGroupDto LecturerGroup)
        {
            return await httpClient.PutJsonAsync<LecturerGroupDto>("api/LecturerGroup", LecturerGroup);
        }

        public async Task<LecturerGroupDto> CreateLecturerGroup(LecturerGroupDto newLecturerGroup)
        {
            return await httpClient.PostJsonAsync<LecturerGroupDto>("api/LecturerGroup", newLecturerGroup);
        }

        public async Task DeleteLecturerGroup(int id)
        {
            await httpClient.DeleteAsync($"api/LecturerGroup/{id}");
        }

        

    }
}
