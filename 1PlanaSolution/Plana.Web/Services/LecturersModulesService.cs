using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Components;
using Plana.Shared;

namespace Plana.Web.Services
{
    public class LecturersModulesService : ILecturersModulesService
    {
        private readonly HttpClient httpClient;
        public LecturersModulesService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<LecturerModuleDto>> GetLecturersModules()
        {
            return await httpClient.GetJsonAsync<LecturerModuleDto[]>("api/lecturermodule");
        }
    }
}
