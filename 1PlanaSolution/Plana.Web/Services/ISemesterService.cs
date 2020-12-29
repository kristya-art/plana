using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Plana.Shared;

namespace Plana.Web.Services
{
    public interface ISemesterService
    {
        /// <summary>
        /// for semester
        /// </summary>
        Task<IEnumerable<SemesterDto>> GetSemesters();
        Task<SemesterDto> GetSemester(int id);
        Task UpdateSemester(SemesterDto semester);
        Task<SemesterDto> CreateSemester(SemesterDto semester);
        Task SoftDeleteSemester(int id);
       


    }
}
