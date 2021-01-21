using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Shared;

namespace Plana.Web.Services
{
    public interface ILecturerModuleRunService 
    {
        Task<IEnumerable<LecturerModuleRunDto>> GetLecturerModuleRuns();

        Task<LecturerModuleRunDto> GetLecturerModuleRun(int id, int id2);

        Task UpdateLecturerModuleRun(LecturerModuleRunDto lecturerModuleRun);

        Task<ActionResultDto<LecturerModuleRunDto>> CreateLecturerModuleRun(LecturerModuleRunDto lecturerModuleRun);

        Task DeleteLecturerModuleRun(int id, int id2);
    }
}
