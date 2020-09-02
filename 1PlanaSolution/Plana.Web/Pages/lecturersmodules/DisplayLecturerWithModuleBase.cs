using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Web.Services;
using Plana.Models;

namespace Plana.Web.Pages.lecturersmodules
{
    public class DisplayLecturerWithModuleBase : ComponentBase

    {
        [Inject]
        public ILecturersModulesService LecturersModulesService { get; set; }
        public IEnumerable<LecturersModules> LM { get; set; }


        protected override async Task OnInitializedAsync()
        {
            LM = (await LecturersModulesService.GetLecturersModules()).ToList();

        }
        
    }
}
