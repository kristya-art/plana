using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public interface ILecturerModuleGroupRepository
    {
        Task<IEnumerable<LecturerModuleGroup>> GetLecturerModuleGroups();
        Task<LecturerModuleGroup> GetLecturerModuleGroup(int lecturerModuleGroupId);
        Task<LecturerModuleGroup> AddLecturerModuleGroup(LecturerModuleGroup lecturerModuleGroup);
        Task<LecturerModuleGroup> UpdateLecturerModuleGroup(LecturerModuleGroup lecturerModuleGroup);
    }
}
