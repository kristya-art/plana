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
        public async Task<SemesterDto> CreateSemester(SemesterDto semester)
        {
            return await http.PostJsonAsync<SemesterDto>("api/semester",semester);
        }

        public async Task<SemesterDto> GetSemester(int id)
        {
            return await http.GetJsonAsync<SemesterDto>($"api/semester/{id}");
        }

        public async Task<IEnumerable<SemesterDto>> GetSemesters()
        {
            return await http.GetJsonAsync<SemesterDto[]>("api/semester");
        }

       

        public async Task UpdateSemester(SemesterDto semester)
        {
            await http.PutJsonAsync("api/semester", semester);
        }


    }
}
