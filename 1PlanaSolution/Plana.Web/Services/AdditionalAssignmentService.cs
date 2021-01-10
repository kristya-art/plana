using Microsoft.AspNetCore.Components;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public class AdditionalAssignmentService : IAdditionalAssignmentService
    {
        private readonly HttpClient httpClient;
        public AdditionalAssignmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<AdditionalAssignmentDto> CreateAdditionalAssignment(AdditionalAssignmentDto newAdditionalAssignment)
        {
            return await httpClient.PostJsonAsync<AdditionalAssignmentDto>("api/additionalAssignment", newAdditionalAssignment);

        }

        public async Task<AdditionalAssignmentDto> GetAdditionalAssignment(int id)
        {
            return await httpClient.GetJsonAsync<AdditionalAssignmentDto>($"api/additionalAssignment/{id}");
        }

        public async Task<IEnumerable<AdditionalAssignmentDto>> GetAdditionalAssignments()
        {
            return await httpClient.GetJsonAsync<AdditionalAssignmentDto[]>("api/additionalAssignment");
        }

        public async Task SoftDeleteAdditionalAssignment(int id)
        {
            await httpClient.DeleteAsync($"api/additionalAssignment/{id}");
        }

        public async Task<AdditionalAssignmentDto> UpdateAdditionalAssignment(AdditionalAssignmentDto additionalAssignment)
        {
            return await httpClient.PutJsonAsync<AdditionalAssignmentDto>("api/additionalAssignment", additionalAssignment);
        }
    }
}