using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public interface ILecturerRepository
    {
        Task<IEnumerable<Lecturer>> Search(string name, Gender? gender);
        Task<IEnumerable<Lecturer>> GetLecturers();
        Task<Lecturer> GetLecturer(int lecturerId);
        Task<Lecturer> AddLecturer(Lecturer lecturer);
        //   Task<Lecturer> DeleteLecturer(int lecturerId);
        Task<Boolean> DeleteLecturer(int lecturerId);
        Task<Lecturer> UpdateLecturer(Lecturer lecturer);
       Task<Boolean> SoftDeleteLecturer(int lecturerId);
        Task<IEnumerable<Lecturer>> GetLecturersModules();

    }
}
