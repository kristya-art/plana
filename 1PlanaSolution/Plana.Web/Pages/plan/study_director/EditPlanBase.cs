using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Plana.Models;
using Plana.Shared;
using Plana.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Plana.Web.Pages.plan.study_director
{
    public class EditPlanBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavManager { get; set; }
        [CascadingParameter]
        public Task<AuthenticationState> authenticationStateTask { get; set; }
        [Inject]
        public IPlanService PlanService { get; set; }
        [Inject]
        public ISemesterService SemesterService { get; set; }
        [Inject]
        public IModuleRunService ModuleRunService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ILecturerService LecturerService { get; set; }

        [Inject]
        public IModuleService ModuleService { get; set; }
        [Inject]
        public ILecturerModuleRunService LecturerModuleRunService { get; set; }

        public PlanDto Plan { get; set; }
        public SemesterDto Semester { get; set; } = new SemesterDto();
        public List<PlanDto> Plans { get; set; }
        public List<SemesterDto> Semesters { get; set; } = new List<SemesterDto>();
        public ModuleRunDto ModuleRun { get; set; } = new ModuleRunDto();
        public SemesterDto AutumnSemester { get; set; }
        public SemesterDto SpringSemester { get; set; }
        public ModuleDto Module { get; set; } = new ModuleDto();
        public ModuleRunDto MR { get; set; } = new ModuleRunDto();
        public List<ModuleRunDto> ModuleRuns { get; set; } = new List<ModuleRunDto>();
        // public ModuleRunDto SelectedModuleRun { get; set; } = new ModuleRunDto();
        public List<ModuleDto> Modules { get; set; } = new List<ModuleDto>();

         
        /// <summary>
        /// data for lecturers
        /// </summary>
        public LecturerDto Lecturer { get; set; }
        public LecturerDto SelectedLecturer { get; set; } = new LecturerDto();
        public List<LecturerDto> Lecturers { get; set; } = new List<LecturerDto>();

        public LecturerModuleRunDto Lmr { get; set; } = new LecturerModuleRunDto();
        public List<LecturerModuleRunDto> ListLmr { get; set; } = new List<LecturerModuleRunDto>();
        
        /// <summary>
        /// Id will be passed in the URL. This property will automatically receive it.
        /// </summary>
        [Parameter]
        public string Id { get; set; }
       public string SemesterId { get; set; }
        public string ModuleId { get; set;}

        public int? SelectedPlanId { get; set; }
        public PlanDto lastYearPlan { get; set; }
       
        /// <summary>
        /// inside this method we call the rest api and retrieve a data
        /// </summary>
        /// <returns></returns>
        protected async override Task OnInitializedAsync()
        {
            //var authenticationState = await authenticationStateTask;
            //if (!authenticationState.User.Identity.IsAuthenticated) {
            //    string returnUrl = System.Net.WebUtility.UrlEncode($"/editPlan/{Id}");
            //    NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");

            //}
            int.TryParse(Id, out int planId);

            if (planId != 0)
            {
                Plan = await PlanService.GetPlan(int.Parse(Id));
                AutumnSemester = Plan.AutumnSemester;
                SpringSemester = Plan.SpringSemester;

                Semesters = new List<SemesterDto> { AutumnSemester, SpringSemester };

                SemesterId = Semester.SemesterId.ToString();
                ModuleId = Module.ModuleId.ToString();
                Lmr = new LecturerModuleRunDto();
                SelectedPlanId = Plan.Id;
                ListLmr = (await LecturerModuleRunService.GetLecturerModuleRuns()).ToList();
                
               
               }

            else
            {
                Plan = new PlanDto { };
                Semester = new SemesterDto { };
                Module = new ModuleDto { };
               ListLmr = new List<LecturerModuleRunDto> { };
                

            }
            Plans = (await PlanService.GetPlans()).ToList();
            ModuleRuns = (await ModuleRunService.GetModuleRuns()).ToList();
            Modules = (await ModuleService.GetModules()).ToList();
            Lecturers = (await LecturerService.GetLecturers()).ToList();


        }

       

        protected async Task UpdateSemester()
        {
            if (Semesters != null) {

                foreach (var Sem in Semesters) {

                  await  SemesterService.UpdateSemester(Sem);
                
                }
            }
        }

        protected async Task HandleValidSubmit()
        {
            PlanDto result = null;
            if (Semester.SemesterId != 0)
            {
                //await UpdateSemester();
                //await UpdateMR();

                //await PlanService.UpdatePlan(Plan);
                await SemesterService.UpdateSemester(AutumnSemester);
                await SemesterService.UpdateSemester(SpringSemester);
                await LecturerModuleRunService.UpdateLecturerModuleRun(Lmr);
                await ModuleRunService.UpdateModuleRun(MR);
            }

            if (Plan.Id != 0)
            {
                await PlanService.UpdatePlan(Plan);
            }
            else
            {
                result = await PlanService.CreatePlan(Plan);
            }

        }


        //protected async Task AddLecturer(int ModuleRunId, int LecturerId) {
        //    LecturerModuleRunDto lecturerModuleRunDto = new LecturerModuleRunDto
        //    {
        //        LecturerId = LecturerId,
        //        ModuleRunId = ModuleRunId
        //    };

        //    await LecturerModuleRunService.CreateLecturerModuleRun(lecturerModuleRunDto);

        //}
        public void NavigateToModulesPlanPage()
        {

            NavManager.NavigateTo($"/editplan/{SelectedPlanId}", true);

        }



    }
}
