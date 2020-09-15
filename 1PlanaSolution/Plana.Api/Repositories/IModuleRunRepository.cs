using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public interface IModuleRunRepository
    {
        Task<IEnumerable<ModuleRun>> Search(string name,string code);
        Task<ModuleRun> GetModuleRun(int moduleRunId);
        Task<IEnumerable<ModuleRun>> GetModuleRuns();
        Task<ModuleRun> CreateModuleRun(ModuleRun moduleRun);
        Task<ModuleRun> UpdateModuleRun(ModuleRun moduleRun);
        Task<Boolean> SoftDeleteModuleRun(int moduleRunId);
        Task<Boolean> DeleteModuleRun(int moduleRunId);
        



    }
}
