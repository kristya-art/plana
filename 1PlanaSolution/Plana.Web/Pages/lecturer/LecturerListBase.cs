using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Plana.Web.Services;
using Plana.Shared;

namespace Plana.Web.Pages
{
    public class LecturerListBase : ComponentBase
    {
        [Inject]
        public ILecturerService LecturerService { get; set; }
        public IEnumerable<LecturerDto> Lecturers { get; set; }

        public bool ShowFooter { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
           
            Lecturers = (await LecturerService.GetLecturers()).ToList();

        }

        protected async Task LecturersDeleted()
        {
            Lecturers = (await LecturerService.GetLecturers()).ToList();
        }

    }
}
