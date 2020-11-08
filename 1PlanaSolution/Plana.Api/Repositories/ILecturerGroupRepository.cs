using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public interface ILecturerGroupRepository
    {
        Task<IEnumerable<LecturerGroup>> Search(string name);
        Task<IEnumerable<LecturerGroup>> GetLecturerGroups();
        Task<LecturerGroup> GetLectureGroup(int lecturerGroupId);
        Task<LecturerGroup> AddLecturerGroup(LecturerGroup lecturerGroup);
        Task<Boolean> DeleteLecturerGroup(int lecturerGroupId);
        Task<LecturerGroup> UpdateLecturerGroup(LecturerGroup lecturerGroup);
        Task<Boolean> SoftDeleteLecturerGroup(int lecturerId);
      
    }
}
