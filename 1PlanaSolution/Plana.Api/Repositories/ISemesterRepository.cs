using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public interface ISemesterRepository
    {
        Task<IEnumerable<Semester>> GetSemesters();
        Task<Semester> GetSemester(int? semesterId);

        Task<Semester> UpdateSemester(Semester semester);
        Task<Semester> CreateSemester(Semester semester);

        Task<Boolean> SoftDeleteSemester(int semesterId);
        Task<Boolean> DeleteSemester(int semesterId);
        Task<IEnumerable<Semester>> Search(string name);



    }
}
