using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public interface IModuleGroupRepository
    {
        Task<IEnumerable<ModuleGroup>> Search(string name);
        Task<IEnumerable<ModuleGroup>> GetModuleGroups();
        Task<ModuleGroup> GetModuleGroup(int moduleGroupId);
        Task<ModuleGroup> AddModuleGroup(ModuleGroup moduleGroup);
        Task<Boolean> DeleteModuleGroup(int moduleGroupId);
        Task<ModuleGroup> UpdateModuleGroup(ModuleGroup moduleGroup);
        Task<Boolean> SoftDeleteModuleGroup(int moduleId);
    }
}
