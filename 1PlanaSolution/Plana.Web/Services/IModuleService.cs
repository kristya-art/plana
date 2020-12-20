using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Web.Services
{
    public interface IModuleService
    {
        Task<IEnumerable<Module>> GetModules();
        Task<Module> GetModule(int id);
        Task<Module> UpdateModule(Module module);
        Task<Module> CreateModule(Module newModule);
        Task SoftDeleteModule(int id);
    }
}