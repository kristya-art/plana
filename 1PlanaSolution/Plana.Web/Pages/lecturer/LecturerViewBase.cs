using Microsoft.AspNetCore.Components;
using Plana.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;

namespace Plana.Web.Pages.lecturer
{
    public class LecturerViewBase : ComponentBase
    {
        [Inject]
       public ILecturerService LecturerService { get; set; }

        [Inject]
      public ILecturersModulesService LMService { get; set; }

        public IEnumerable<Lecturer> Lecturers { get; set; }
        public IEnumerable<LecturersModules> LecturersModules { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Lecturers = (await LecturerService.GetLecturers()).ToList();
            LecturersModules = (await LMService.GetLecturersModules()).ToList();
        }

    }
}
