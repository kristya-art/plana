using Plana.Models;
using Plana.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public interface ILecturerService
    {
       Task<IEnumerable<LecturerDto>> GetLecturers();
       Task<LecturerDto> GetLecturer(int id);
       Task<LecturerDto> UpdateLecturer(LecturerDto lecturer);
        Task<LecturerDto> CreateLecturer(LecturerDto newLecturer);
        Task DeleteLecturer(int id);
     }
}
