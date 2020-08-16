using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Plana.Web.Services;

namespace Plana.Web.Pages
{
    public class LecturerListBase : ComponentBase
    {
        [Inject]
        public ILecturerService LecturerService { get; set; }
        public IEnumerable<Lecturer> Lecturers { get; set; }

        public bool ShowFooter { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            // await Task.Run(LoadLecturer);
            Lecturers = (await LecturerService.GetLecturers()).ToList();

        }

        protected async Task LecturersDeleted()
        {
            Lecturers = (await LecturerService.GetLecturers()).ToList();
        }

        //private void LoadLecturer()
        //{
        //    System.Threading.Thread.Sleep(3000);
        //    Lecturer l1 = new Lecturer() 
        //    { 
        //        LecturerId = 1 ,
        //        FirstName = "John",
        //        LastName = "Black",
        //        Email = "johnblack@gmx.ch",
        //        DateOfBirth = new DateTime(1982, 04, 11 ),
        //        Gender = Gender.Male,
        //        PhotoPath = "images/john.jpg"

        //    };
        //    Lecturer l2 = new Lecturer()
        //    {
        //        LecturerId = 2,
        //        FirstName = "Mana",
        //        LastName = "Rodriges",
        //        Email = "manarodriges@gmx.ch",
        //        DateOfBirth = new DateTime(1976, 04, 11),
        //        Gender = Gender.Male,
        //        PhotoPath = "images/mana.jpg"

        //    };
        //    Lecturer l3 = new Lecturer()
        //    {
        //        LecturerId = 3,
        //        FirstName = "Margo",
        //        LastName = "White",
        //        Email = "margowhite@gmx.ch",
        //        DateOfBirth = new DateTime(1983, 04, 11),
        //        Gender = Gender.Female,
        //        PhotoPath = "images/margo.jpg"

        //    };

        //    Lecturers = new List<Lecturer> { l1,l2,l3 };

        //}
    }
}
