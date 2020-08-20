using Plana.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Models
{
    public interface IModuleRunRepository
    {
        Task<IEnumerable<ModuleRun>> Search(string title, string code);
        Task<ModuleRun> GetModuleRun(int moduleRunId);

    }
}
