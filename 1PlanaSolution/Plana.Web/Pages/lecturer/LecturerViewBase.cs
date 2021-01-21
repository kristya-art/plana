using Microsoft.AspNetCore.Components;
using Plana.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Plana.Shared;

namespace Plana.Web.Pages.lecturer
{
    public class LecturerViewBase : ComponentBase
    {
        [Inject]
       public ILecturerService LecturerService { get; set; }

        [Inject]
      public ILecturersModulesService LMService { get; set; }

        public IEnumerable<LecturerDto> Lecturers { get; set; }
        public IEnumerable<LecturerModuleDto> LecturersModules { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Lecturers = (await LecturerService.GetLecturers()).ToList();
            LecturersModules = (await LMService.GetLecturersModules()).ToList();
        }

    }
}
