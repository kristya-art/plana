using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;

namespace Plana.Web.Services
{
    public interface IModuleRunService
    {
        /// <summary>
        /// for module run
        /// </summary>
        Task<IEnumerable<ModuleRun>> GetModuleRuns();
        Task<ModuleRun> GetModuleRun(int id);
        Task<ModuleRun> UpdateModuleRun(ModuleRun moduleRun);
        Task<Semester> CreateModuleRun(ModuleRun moduleRun);
        Task SoftDeleteModuleRun(int id);
    }
}
