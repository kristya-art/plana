using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
     public interface IModuleRepository
    {
        //Task<IEnumerable<ModuleDto>> Search(string title, string code);
         Task<ModuleDto> GetModule(int moduleId);
        
        Task<ModuleDto> UpdateModule(ModuleDto moduleDto);
        Task<ModuleDto> AddModule(ModuleDto moduleDto);
        //Task<bool> DeleteModule(int moduleId);
        Task<IEnumerable<ModuleDto>> GetModules();
    }
}
