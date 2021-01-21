using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Web.Services;
using Plana.Shared;


namespace Plana.Web.Pages.lecturer_groups
{
    public class EditLecturerGroupBase : ComponentBase
    {


        [Inject]
        public ILecturerGroupService LecturerGroupService { get; set; }

        [Inject]
        public ILecturerService LecturerService { get; set; }

        [Inject]
        public ILecturerLecturerGroupService LecturerLecturerGroupService { get; set; }

        public string PageHeaderText { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }



        public LecturerGroupDto LecturerGroup { get; set; } = new LecturerGroupDto();

        public LecturerLecturerGroupDto LecturerLecturerGroup { get; set; } = new LecturerLecturerGroupDto();
        public List<LecturerLecturerGroupDto> LecturerLecturerGroups { get; set; }

        public LecturerDto Lecturer { get; set; } = new LecturerDto();

        public List<LecturerDto> Lecturers { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string Id2 { get; set; }


        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int lecturerGroupId);

            if (lecturerGroupId != 0)
            {
                PageHeaderText = "Edit LecturerGroup";
                LecturerGroup = await LecturerGroupService.GetLecturerGroup(int.Parse(Id));

            }
            else
            {
                PageHeaderText = "Create LecturerGroup";
                LecturerGroup = new LecturerGroupDto
                {

                };

            }
            Lecturers = (await LecturerService.GetLecturers()).ToList();

        }

        protected async Task HandleValidSubmit()
        {


            LecturerGroupDto result = null;

            if (LecturerGroup.LecturerGroupId != 0)
            {
                result = await LecturerGroupService.UpdateLecturerGroup(LecturerGroup);
            }
            else
            {
                result = await LecturerGroupService.CreateLecturerGroup(LecturerGroup);
            }
            NavigationManager.NavigateTo($"/lecturergroupsview");
        }

        protected async Task Delete_Click()
        {
            await LecturerGroupService.DeleteLecturerGroup(LecturerGroup.LecturerGroupId);

            NavigationManager.NavigateTo("/");
        }



    }  
  
}
