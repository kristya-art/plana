using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface ISemesterService
    {
        Task<IEnumerable<SemesterDto>> GetSemesters();

        Task<SemesterDto> GetSemester(int? semesterId);

        Task<SemesterDto> UpdateSemester(SemesterDto semesterDto);

        Task<SemesterDto> CreateSemester(SemesterDto semesterDto);

        Task<bool> DeleteSemester(int semesterId);

        Task<IEnumerable<Semester>> Search(string name);



    }
}
