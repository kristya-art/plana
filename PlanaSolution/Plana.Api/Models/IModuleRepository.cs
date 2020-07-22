using Plana.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
     public interface IModuleRepository
    {
        Task<IEnumerable<Module>> Search(string title, string code);
         Task<Module> GetModule(int moduleId);
        Task<Module> DeleteModule(int moduleId);
        Task<Module> UpdateModule(Module module);
        Task<Module> AddModule(Module module);
    }
}
