﻿

using Microsoft.AspNetCore.Components;
using Plana.Models;
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
        public async Task<Lecturer> GetLecturer(int id)
        {
            return await httpClient.GetJsonAsync<Lecturer>($"api/lecturer/{id}");
        }


        public async Task<IEnumerable<Lecturer>> GetLecturers()
        {
            return await httpClient.GetJsonAsync<Lecturer[]>("api/lecturer");
        }

       
        public async Task<Lecturer> UpdateLecturer(Lecturer lecturer)
        {
          return await httpClient.PutJsonAsync<Lecturer>("api/lecturer", lecturer);
        }

        public async Task<Lecturer> CreateLecturer(Lecturer newLecturer)
        {
            return await httpClient.PostJsonAsync<Lecturer>("api/lecturer", newLecturer);
        }

        public async Task DeleteLecturer(int id)
        {
             await httpClient.DeleteAsync($"api/lecturer/{id}");
        }
       
    }
}
