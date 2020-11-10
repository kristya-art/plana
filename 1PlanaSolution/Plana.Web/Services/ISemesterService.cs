using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;


namespace Plana.Web.Services
{
    public interface ISemesterService
    {
        /// <summary>
        /// for semester
        /// </summary>
        Task<IEnumerable<Semester>> GetSemesters();
        Task<Semester> GetSemester(int id);
        Task UpdateSemester(Semester semester);
        Task<Semester> CreateSemester(Semester semester);
        Task SoftDeleteSemester(int id);
       


    }
}
