using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Web.Services;
using Plana.Shared;
using Microsoft.Extensions.Logging;

namespace Plana.Web.Pages.lecturer_groups
{
    public class EditLecturerGroupBase : ComponentBase
    {
        [Inject]
        ILogger<EditLecturerGroupBase> Logger { get; set; }

        [Inject]
        public ILecturerGroupService LecturerGroupService { get; set; }

        [Inject]
        public ILecturerService LecturerService { get; set; }

        [Inject]
        public ILecturerLecturerGroupService LecturerLecturerGroupService { get; set; }

        public string PageHeaderText { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        bool loadFailed;

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
          //  LecturerLecturerGroups = (await LecturerLecturerGroupService.GetLecturerLecturerGroups()).ToList();

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

        public async Task SaveToLecturerGroup()
        {
            LecturerGroupDto  LeGr= new LecturerGroupDto();
            LeGr = LecturerGroup;
          //  Lecturers = new List<LecturerDto>();
            List<LecturerLecturerGroupDto> lecturersToAdd = new List<LecturerLecturerGroupDto>();
            LecturerDto selectedLecturer = new LecturerDto();

            try
            {
                foreach (var l in Lecturers)
                {
                   
                    if (l.isSelected == true)
                    {
                        selectedLecturer = l;


                     LecturerLecturerGroup = new LecturerLecturerGroupDto() {LecturerGroupId=LeGr.LecturerGroupId,LecturerId=selectedLecturer.Id };

                        if (!LecturerGroup.LecturerLecturerGroup.Contains(LecturerLecturerGroup))
                        {
                            lecturersToAdd.Add(LecturerLecturerGroup);
                         // await  LecturerLecturerGroupService.CreateLecturerLecturerGroup(LecturerLecturerGroup);
                        
                        }
                    }
                }

                if (lecturersToAdd != null) {
                    foreach (var llg in lecturersToAdd)
                    {
                        //LecturerLecturerGroupDto newLecturerLecturerGroup = new LecturerLecturerGroupDto()
                        //{
                        //    LecturerGroupId = LecturerGroup.LecturerGroupId,
                        //    LecturerId = llg.LecturerId

                        //};

                        await LecturerLecturerGroupService.CreateLecturerLecturerGroup(llg);
                        okClick();
                    }
                }
            }
            catch (Exception ex)
            {

                loadFailed = true;
                Logger.LogWarning(ex, "The selected Lecturers are already belong to this LecturerGroup");
            }

        
        }

        // dialog 

       public bool dialogIsOpenLecturers = false;

        public void okClick()
        {
            dialogIsOpenLecturers = false;

        }

        public void OpenDialogLecturers(bool isEdit)
        {
            dialogIsOpenLecturers = true;
        }
    }
}
