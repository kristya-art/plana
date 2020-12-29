using Microsoft.AspNetCore.Components;
using Plana.Models;
using Plana.Shared;
using Plana.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Plana.Web.Pages
{
    public class LecturerDetailsBase : ComponentBase
    {
       
        public LecturerDto Lecturer { get; set; } = new LecturerDto();
        
        [Inject]
        public ILecturerService LecturerService { get; set; }
        [Inject]
        public ILecturersModulesService LMService { get; set; }
        

        [Parameter]
        public string Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Lecturer = await LecturerService.GetLecturer(int.Parse(Id));
            Lecturers = (await LecturerService.GetLecturers()).ToList();
            LecturersModules = (await LMService.GetLecturersModules()).ToList();
        }

        public IEnumerable<LecturerDto> Lecturers { get; set; }
        public IEnumerable<LecturerModuleDto> LecturersModules { get; set; }
        public bool ShowFooter { get; set; } = true;

        //protected override async Task OnInitializedAsync()
        //{
        //    // await Task.Run(LoadLecturer);
        //    Lecturers = (await LecturerService.GetLecturers()).ToList();

        //}
    }
}
