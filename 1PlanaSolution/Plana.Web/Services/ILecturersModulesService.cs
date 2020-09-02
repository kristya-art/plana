using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;

namespace Plana.Web.Services
{
    public interface ILecturersModulesService
    {
        Task<IEnumerable<LecturersModules>> GetLecturersModules();
    }

}
