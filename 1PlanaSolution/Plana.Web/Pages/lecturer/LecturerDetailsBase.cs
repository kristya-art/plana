using Microsoft.AspNetCore.Components;
using Plana.Models;
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
       
        public Lecturer Lecturer { get; set; } = new Lecturer();
        
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

        public IEnumerable<Lecturer> Lecturers { get; set; }
        public IEnumerable<LecturersModules> LecturersModules { get; set; }
        public bool ShowFooter { get; set; } = true;

        //protected override async Task OnInitializedAsync()
        //{
        //    // await Task.Run(LoadLecturer);
        //    Lecturers = (await LecturerService.GetLecturers()).ToList();

        //}
    }
}
