using Plana.Web.Pages.employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Plana.Web.Services;
using Plana.Models;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Plana.Web.Pages.semester
{
    public class EditSemesterBase : ComponentBase
    {

        [Inject]
        public ISemesterService SemesterService { get; set; }
        [Inject]
        public IModuleRunService ModuleRunService { get; set; }
        [Inject]
        public ILecturerService LecturerService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string PageHeaderText { get; set; }



        public Semester Semester { get; set; }
        public List<Semester> Semesters { get; set; }
        public ModuleRun ModuleRun { get; set; }
        
        public List<ModuleRun> ModuleRuns { get; set; }

        public Lecturer Lecturer { get; set; }
        public List<Lecturer> Lecturers { get; set; }
         

        /// <summary>
        /// 
        /// Id will be pass in the URL. This property will automatically receive 
        /// </summary>
        [Parameter]
        public string Id { get; set; }
        /// <summary>
        /// inside this method we call the rest api and retrieve a data
        /// </summary>
       
        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int semesterId);
            if (semesterId != 0)
            {
                PageHeaderText = "Edit Semester";
                Semester = await SemesterService.GetSemester(int.Parse(Id));

            }
            else
            {
                PageHeaderText = "Create Semester";
                Semester = new Semester { };
               
            
            }
            Semesters =( await SemesterService.GetSemesters()).ToList();
            //Lecturers = (await LecturerService.GetLecturers()).ToList();
            //ModuleRuns = ( await ModuleRunService.GetModuleRuns()).ToList(); 
            

            
        }

        protected async Task HandleValidSubmit()
        {
            Semester result = null;
            if (Semester.SemesterId != 0)
            {
                result = await SemesterService.UpdateSemester(Semester);
            }
            else
            {
                result = await SemesterService.CreateSemester(Semester);
            }
            //if (result != null)
            //{
            //    NavigationManager.NavigateTo("/home");
            //}

        
        }



    }
}
