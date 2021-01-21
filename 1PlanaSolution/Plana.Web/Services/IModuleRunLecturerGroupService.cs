using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Shared;

namespace Plana.Web.Services
{
    public interface IModuleRunLecturerGroupService
    {
        Task<IEnumerable<ModuleRunLecturerGroupDto>> GetModuleRunLecturerGroups();

        Task<ModuleRunLecturerGroupDto> GetModuleRunLecturerGroup(int id, int id2);

        Task UpdateModuleRunLecturerGroup(ModuleRunLecturerGroupDto ModuleRunLecturerGroup);

        Task<ActionResultDto<ModuleRunLecturerGroupDto>> CreateModuleRunLecturerGroup(ModuleRunLecturerGroupDto ModuleRunLecturerGroup);

        Task DeleteModuleRunLecturerGroup(int id, int id2);
    }
}
