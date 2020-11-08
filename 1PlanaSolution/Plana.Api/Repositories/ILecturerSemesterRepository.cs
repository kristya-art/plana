using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public interface ILecturerSemesterRepository
    {
        Task<IEnumerable<LecturerSemester>> Search(string name);
        Task<IEnumerable<LecturerSemester>> GetLecturerSemesters();
        Task<LecturerSemester> GetLecturerSemester(int lecturerSId);
        Task<LecturerSemester> AddLecturerSemester(LecturerSemester lecturerS);
        
        Task<Boolean> DeleteLecturerSemester(int lecturerSId);
        Task<LecturerSemester> UpdateLecturerSemester(LecturerSemester lecturerS);
        Task<Boolean> SoftDeleteLecturer(int lecturerSId);
       
    }
}
