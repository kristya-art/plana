using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface ILecturerGroupService
    {
        Task<IEnumerable<LecturerGroupDto>> Search(string name);
        Task<IEnumerable<LecturerGroupDto>> GetLecturerGroups();
        Task<LecturerGroupDto> GetLectureGroup(int lecturerGroupId);
        Task<ActionResultDto<LecturerGroupDto>> AddLecturerGroup(LecturerGroupDto lecturerGroup);
        Task<bool> DeleteLecturerGroup(int lecturerGroupId);
        Task<LecturerGroupDto?> UpdateLecturerGroup(LecturerGroupDto lecturerGroup);
        
    }
}
