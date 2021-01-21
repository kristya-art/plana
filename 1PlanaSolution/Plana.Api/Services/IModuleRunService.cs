using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface IModuleRunService
    {
        Task<IEnumerable<ModuleRun>> Search(string name,string code);

        Task<ModuleRunDto> GetModuleRun(int moduleRunId);

        Task<IEnumerable<ModuleRunDto>> GetModuleRuns();

        Task<ActionResultDto<ModuleRunDto>> CreateModuleRun(ModuleRunDto moduleRunDto);

        Task<ModuleRunDto?> UpdateModuleRun(ModuleRunDto moduleRunDto);
     
        Task<bool> DeleteModuleRun(int moduleRunId);
        



    }
}
