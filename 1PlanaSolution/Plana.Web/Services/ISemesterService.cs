using System.Collections.Generic;
using System.Threading.Tasks;
using Plana.Shared;

namespace Plana.Web.Services
{
    public interface ISemesterService
    {
        
        Task<IEnumerable<SemesterDto>> GetSemesters();

        Task<SemesterDto> GetSemester(int id);

        Task UpdateSemester(SemesterDto semester);

        Task<SemesterDto> CreateSemester(SemesterDto semester);
       
    }
}
