using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public interface IModuleService
    {
        Task<IEnumerable<ModuleDto>> GetModules();
        Task<ModuleDto> GetModule(int id);
        Task<ModuleDto> UpdateModule(ModuleDto module);
        Task<ModuleDto> CreateModule(ModuleDto newModule);
        Task SoftDeleteModule(int id);
    }
}