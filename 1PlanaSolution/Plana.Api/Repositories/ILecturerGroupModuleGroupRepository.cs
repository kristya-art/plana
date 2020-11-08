using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public interface ILecturerGroupModuleGroupRepository
    {
        Task<IEnumerable<LecturerGroupModuleGroup>> GetLecturerGroupModuleGroups();
        Task<LecturerGroupModuleGroup> GetLecturerGroupModuleGroup(int lecturerGroupModuleGroupId);
        Task<LecturerGroupModuleGroup> AddLecturerGroupModuleGroup(LecturerGroupModuleGroup lecturerGroupModuleGroup);
        Task<LecturerGroupModuleGroup> UpdateLecturerGroupModuleGroup(LecturerGroupModuleGroup lecturerGroupModuleGroup);
    }
}
