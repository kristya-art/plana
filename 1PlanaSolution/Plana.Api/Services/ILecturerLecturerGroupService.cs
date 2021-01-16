using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface ILecturerLecturerGroupService
    {
       Task<IEnumerable<LecturerLecturerGroupDto>> GetLecturerLecturerGroups();

        Task<LecturerLecturerGroupDto> GetLectureLecturerGroup(int lecturerId, int lecturerGroupId );

        Task<ActionResultDto<LecturerLecturerGroupDto>> AddLecturerLecturerGroup(LecturerLecturerGroupDto LecturerLecturerGroupDto);

        Task<bool> DeleteLecturerLecturerGroup(int lecturerId, int lecturerGroupId);

        Task<LecturerLecturerGroupDto?> UpdateLecturerLecturerGroup(LecturerLecturerGroupDto LecturerLecturerGroupDto);

    }
}

