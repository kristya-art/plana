using Microsoft.AspNetCore.Components;
using Plana.Models;
using Plana.Web.Services;
using System.Threading.Tasks;

namespace Plana.Web.Pages
{
    public class DisplayLecturerBase : ComponentBase
    {
        [Parameter]
        public Lecturer Lecturer { get; set; }
        [Parameter]
        public bool ShowFooter { get; set; }
        [Parameter]
        public EventCallback<int> OnLecturerDeleted { get; set; }
        [Inject]
        public ILecturerService LecturerService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async Task Soft_delete() {
            await LecturerService.DeleteLecturer(Lecturer.Id);
            await OnLecturerDeleted.InvokeAsync(Lecturer.Id);
            //NavigationManager.NavigateTo("/",true);
        }

    }
}
