using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface IModuleRunLecturerGroupService
    {
        Task<IEnumerable<ModuleRunLecturerGroupDto>> GetModuleRunLecturerGroups();

        Task<ActionResultDto<ModuleRunLecturerGroupDto>> AddModuleRunLecturerGroup(ModuleRunLecturerGroupDto ModuleRunLecturerGroupDto);

        Task<ModuleRunLecturerGroupDto?> UpdateModuleRunLecturerGroup(ModuleRunLecturerGroupDto ModuleRunLecturerGroupDto);

        Task<ModuleRunLecturerGroupDto> GetModuleRunLecturerGroup(int moduleRunId, int lecturerId);

        Task<bool> DeleteModuleRunLecturerGroup(int moduleRunId, int lecturerId);
    }
}
