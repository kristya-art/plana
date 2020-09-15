using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;

namespace Plana.Api.Models
{
    public interface ILecturersModulesRepository
    {
       

        Task<IEnumerable<LecturersModules>> GetAll();
        Task<LecturersModules> UpdateLecturersModules(int lecturerId, int moduleId);
        Task<LecturersModules> CreateLecturersModules(Lecturer lectuer, Module module);
    }
}
