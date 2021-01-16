using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Shared;

namespace Plana.Web.Services
{
    public interface ILecturerLecturerGroupService
    {
        Task<IEnumerable<LecturerLecturerGroupDto>> GetLecturerLecturerGroups();

        Task<LecturerLecturerGroupDto> GetLecturerLecturerGroup(int id, int id2);

        Task UpdateLecturerLecturerGroup(LecturerLecturerGroupDto lecturerLecturerGroup);

        Task<ActionResultDto<LecturerLecturerGroupDto>> CreateLecturerLecturerGroup(LecturerLecturerGroupDto lecturerLecturerGroup);

        Task DeleteLecturerLecturerGroup(int id, int id2);
    }
}
