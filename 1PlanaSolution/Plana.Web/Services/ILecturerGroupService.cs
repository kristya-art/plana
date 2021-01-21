using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public interface ILecturerGroupService
    {
        Task<IEnumerable<LecturerGroupDto>> GetLecturerGroups();
        Task<LecturerGroupDto> GetLecturerGroup(int id);
        Task<LecturerGroupDto> UpdateLecturerGroup(LecturerGroupDto LecturerGroup);
        Task<LecturerGroupDto> CreateLecturerGroup(LecturerGroupDto newLecturerGroup);
        Task DeleteLecturerGroup(int id);
    }
}
