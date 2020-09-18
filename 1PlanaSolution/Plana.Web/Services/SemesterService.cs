using Microsoft.AspNetCore.Components;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public class SemesterService : ISemesterService
    {
        private readonly HttpClient http;

        public SemesterService(HttpClient http)
        {
            this.http = http;
        }
        /// <summary>
        /// methods for semester
        /// </summary>
        /// <param name="semester"></param>
        /// <returns></returns>
        public async Task<Semester> CreateSemester(Semester semester)
        {
            return await http.PostJsonAsync<Semester>("api/semesters",semester);
        }

        public async Task<Semester> GetSemester(int id)
        {
            return await http.GetJsonAsync<Semester>($"api/semesters/{id}");
        }

        public async Task<IEnumerable<Semester>> GetSemesters()
        {
            return await http.GetJsonAsync<Semester[]>("api/semesters");
        }

        public  Task SoftDeleteSemester(int id)
        {
            throw new NotImplementedException();
            //await http.DeleteAsync($"api/semesters/{id}");
        }

        public async Task<Semester> UpdateSemester(Semester semester)
        {
            return await http.PutJsonAsync<Semester>("api/semesters",semester);
        }


    }
}
