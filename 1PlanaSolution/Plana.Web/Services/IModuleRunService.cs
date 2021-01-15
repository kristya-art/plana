using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Plana.Shared;

namespace Plana.Web.Services
{
    public interface IModuleRunService
    {
        /// <summary>
        /// for module run
        /// </summary>
        Task<IEnumerable<ModuleRunDto>> GetModuleRuns();
        Task<ModuleRunDto> GetModuleRun(int id);
        Task<ModuleRunDto> UpdateModuleRun(ModuleRunDto moduleRun);
        Task<ActionResultDto<ModuleRunDto>> CreateModuleRun(ModuleRunDto newModuleRun);
        Task SoftDeleteModuleRun(int id);
    }
}
