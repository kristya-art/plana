

using Microsoft.AspNetCore.Components;
using Plana.Models;
using Plana.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public class LecturerService : ILecturerService
    {
        private readonly HttpClient httpClient;
        public LecturerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public HttpClient HttpClient { get; }



        //public async  Task<Lecturer> GetLecturer(int id)
        //{
        //    return await httpClient.GetJsonAsync<Lecturer>($"api/lecturer/{id}");

        //}
        public async Task<LecturerDto> GetLecturer(int id)
        {
            return await httpClient.GetJsonAsync<LecturerDto>($"api/lecturer/{id}");
        }


        public async Task<IEnumerable<LecturerDto>> GetLecturers()
        {
            return await httpClient.GetJsonAsync<LecturerDto[]>("api/lecturer");
        }

       
        public async Task<LecturerDto> UpdateLecturer(LecturerDto lecturer)
        {
          return await httpClient.PutJsonAsync<LecturerDto>("api/lecturer", lecturer);
        }

        public async Task<LecturerDto> CreateLecturer(LecturerDto newLecturer)
        {
            return await httpClient.PostJsonAsync<LecturerDto>("api/lecturer", newLecturer);
        }

        public async Task DeleteLecturer(int id)
        {
             await httpClient.DeleteAsync($"api/lecturer/{id}");
        }
       
    }
}
