using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Repositories
{
    public interface ILecturerModuleRunRepository
    {
        Task<IEnumerable<LecturerModuleRun>> GetLecturerModuleRuns();
        Task<LecturerModuleRun> GetLecturerModuleRun(int lecturerModuleRunId);
        Task<LecturerModuleRun> AddLecturerModuleRun(LecturerModuleRun lecturerModuleRun);
        Task<LecturerModuleRun> UpdateLecturerModuleRun(LecturerModuleRun lecturerModuleRun);

        //Task<IEnumerable<LecturerModuleRun>> Search(string name);

        //   Task<LecturerModuleRun> DeleteLecturerModuleRun(int LecturerModuleRunId);
        //Task<Boolean> DeleteLecturerModuleRun(int lecturerModuleRunId);

        //Task<Boolean> SoftDeleteLecturerModuleRun(int lecturerModuleRunId);

    }
}
