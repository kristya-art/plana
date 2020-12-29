using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Plana.Shared;

namespace Plana.Web.Services
{
    public interface ILecturersModulesService
    {
        Task<IEnumerable<LecturerModuleDto>> GetLecturersModules();
    }

}
