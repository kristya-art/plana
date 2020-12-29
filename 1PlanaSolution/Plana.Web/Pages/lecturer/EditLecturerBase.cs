using AutoMapper;
using Microsoft.AspNetCore.Components;
using Plana.Models;
using Plana.Shared;

using Plana.Web.Services;
using System;
using System.Threading.Tasks;

namespace Plana.Web.Pages
{
    public class EditLecturerBase : ComponentBase
    {
        [Inject]
        public ILecturerService LecturerService { get; set; }

        public string PageHeaderText { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public LecturerDto Lecturer { get; set; } = new LecturerDto();
        public LecturerDto LecturerDto { get; set; } = new LecturerDto();

        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }


       protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int lecturerId);

            if (lecturerId != 0)
            {
                PageHeaderText = "Edit Lecturer";
                Lecturer = await LecturerService.GetLecturer(int.Parse(Id));
            }
            else
            {
                PageHeaderText = "Create Lecturer";
                Lecturer = new LecturerDto
                {
                    // LecturerId = 1,
                   // BirthDate = DateTime.Now,
                    PhotoPath = "images/nopic.jpg",
                    ActiveTill = DateTime.Now
                    
                    
                    
                };
            }
            //Mapper.Map(Lecturer, EditLecturerModel);
        }
        protected async Task HandleValidSubmit()
        {
            //Mapper.Map(EditLecturerModel, Lecturer);

            LecturerDto result = null;

            if (Lecturer.Id != 0)
            {
                result = await LecturerService.UpdateLecturer(Lecturer);
            }
            else
            {
                result = await LecturerService.CreateLecturer(Lecturer);
            }
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }

        protected async Task Delete_Click()
        {
            await LecturerService.DeleteLecturer(Lecturer.Id);
            
            NavigationManager.NavigateTo("/");
        }

        protected async Task SetDeleteDate()
        {
            await LecturerService.UpdateLecturer(Lecturer);
        }
        [Parameter]
        public bool ShowDeleteForm { get; set; }
        
    }
}