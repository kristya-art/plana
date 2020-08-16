using Plana.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public interface ILecturerService
    {
       Task<IEnumerable<Lecturer>> GetLecturers();
       Task<Lecturer> GetLecturer(int id);
       Task<Lecturer> UpdateLecturer(Lecturer lecturer);
        Task<Lecturer> CreateLecturer(Lecturer newLecturer);
        Task DeleteLecturer(int id);
     }
}
