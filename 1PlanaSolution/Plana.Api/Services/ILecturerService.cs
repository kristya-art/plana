using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Shared;

namespace Plana.Api.Models
{
    public interface ILecturerService
    {
        Task<IEnumerable<LecturerDto>> Search(string name, Gender? gender);

        Task<IEnumerable<LecturerDto>> GetLecturers();

        Task<LecturerDto> GetLecturer(int lecturerId);

        Task<LecturerDto> AddLecturer(LecturerDto lecturerDto);
       
        Task<Boolean> DeleteLecturer(int lecturerId);

        Task<LecturerDto?> UpdateLecturer(LecturerDto lecturerDto);
    }
}
