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
       // [Inject]
        [Inject]
        public IModuleService ModuleService { get; set; }

        public PlanDto Plan { get; set; } 
        public SemesterDto Semester { get; set; } = new SemesterDto();
        public List<PlanDto> Plans { get; set; }
        public List<SemesterDto> Semesters { get; set; } = new List<SemesterDto>();
        public ModuleRunDto ModuleRun { get; set; } = new ModuleRunDto();
        public SemesterDto AutumnSemester { get; set; }
        public SemesterDto SpringSemester { get; set; }
        public ModuleDto Module { get; set; } = new ModuleDto();

        public List<ModuleRunDto> ModuleRuns { get; set; } = new List<ModuleRunDto>();
        public List<ModuleDto> Modules { get; set; } = new List<ModuleDto>();
       
       
        public LecturerDto Lecturer { get; set; } 
        public List<LecturerDto> Lecturers { get; set; }
        /// <summary>
        /// Id will be passed in the URL. This property will automatically receive it.
        /// </summary>
        [Parameter]
        public string Id { get; set; }
       public string SemesterId { get; set; }
        public string ModuleId { get; set;}
       

        
       
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

                SemesterId = Semester.Id.ToString();
                ModuleId = Module.Id.ToString();

            }

            else
            {
                Plan = new Plan { };
                Semester = new Semester { };
                Module = new Module { };
                ModuleRun = new ModuleRun { };

                //AutumnSemester = new Semester { };
                //SpringSemester = new Semester { };
                
                

            }
            Plans = (await PlanService.GetPlans()).ToList();
            //Semesters = (await SemesterService.GetSemesters()).ToList();
            ModuleRuns = (await ModuleRunService.GetModuleRuns()).ToList();
            Modules = (await ModuleService.GetModules()).ToList();

        }

       

        protected async Task UpdateSemester()
        {
            if (Semesters != null) {

                foreach (var Sem in Semesters) {

                  await  SemesterService.UpdateSemester(Sem);
                
                }
            }
        }


        //protected async Task UpdateMR()
        //{
        //    ModuleRun result = null;

        //    if (ModuleRun.ModuleRunId != 0)
        //    {

        //        result = await ModuleRunService.UpdateModuleRun(ModuleRun);
        //    }
        //    else { result = await ModuleRunService.CreateModuleRun(ModuleRun); }
        //}

        protected async Task HandleValidSubmit()
        {
            Plan result = null;
            if (Semester.SemesterId != 0)
            {
                //await UpdateSemester();
                //await UpdateMR();

                //await PlanService.UpdatePlan(Plan);
                await SemesterService.UpdateSemester(AutumnSemester);
                await SemesterService.UpdateSemester(SpringSemester);
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

        protected async Task AddNewModule() {
            
            await ModuleRunService.CreateModuleRun(ModuleRun);
        }


    }
}
