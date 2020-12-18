using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface IModuleRunService
    {
        Task<ModuleRun> SaveModuleRun(ModuleRun moduleRun);



    }
}
