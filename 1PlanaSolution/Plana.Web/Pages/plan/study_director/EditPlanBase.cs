﻿using Microsoft.AspNetCore.Components;
using Plana.Models;
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
        public IPlanService PlanService { get; set; }
        [Inject]
        public ISemesterService SemesterService { get; set; }
        [Inject]
        public IModuleRunService ModuleRunService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public ILecturerService LecturerService { get; set; }

        public Plan Plan { get; set; } 
        public Semester Semester { get; set; } = new Semester();
        public List<Plan> Plans { get; set; }
        public List<Semester> Semesters{ get; set; }
        public ModuleRun ModuleRun { get; set; } = new ModuleRun();
        public Semester AutumnSemester { get; set; }
        public Semester SpringSemester { get; set; } 

        public List<ModuleRun> ModuleRuns { get; set; } 

        public Lecturer Lecturer { get; set; } 
        public List<Lecturer> Lecturers { get; set; }
        /// <summary>
        /// Id will be passed in the URL. This property will automatically receive it.
        /// </summary>
        [Parameter]
        public string Id { get; set; }
        /// <summary>
        /// inside this method we call the rest api and retrieve a data
        /// </summary>
        /// <returns></returns>
        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int planId);

            if (planId != 0)
            {
                Plan = await PlanService.GetPlan(int.Parse(Id));
                AutumnSemester = Plan.AutumnSemester;
                SpringSemester = Plan.SpringSemester;
                
                
            }

            else
            {
                Plan = new Plan { };
                Semester = new Semester { };
                ModuleRun = new ModuleRun { };
                AutumnSemester = new Semester { };
                SpringSemester = new Semester { };
                


            }
            Plans = (await PlanService.GetPlans()).ToList();
            //Semesters = (await SemesterService.GetSemesters()).ToList();
            ModuleRuns = (await ModuleRunService.GetModuleRuns()).ToList();

        }

        protected async Task HandleValidSubmit()
        {
            Plan result = null;
            if (Plan.Id != 0)
            {
                if (AutumnSemester.SemesterId != 0)
                {
                    await SemesterService.UpdateSemester(AutumnSemester);
                }
                if (SpringSemester.SemesterId != 0)
                {
                    await SemesterService.UpdateSemester(SpringSemester);
                }
                await PlanService.UpdatePlan(Plan);
                
            }
            else
            {
                result = await PlanService.CreatePlan(Plan);
            }

        }

        //protected async Task UpdateSemester()
        //{
        //    Semester result = null;

        //    if (Semester.SemesterId != 0)
        //    {

        //        result = await SemesterService.UpdateSemester(Semester);
        //    }
        //    else { result = await SemesterService.CreateSemester(Semester); }
        //}



    }
}