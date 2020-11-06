using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;

namespace Plana.Api.Models
{
    public interface ILecturersModulesRepository
    {
       

        Task<IEnumerable<LecturerModule>> GetAll();
        Task<LecturerModule> UpdateLecturersModules(int lecturerId, int moduleId);
        Task<LecturerModule> CreateLecturersModules(Lecturer lectuer, Module module);
    }
}
