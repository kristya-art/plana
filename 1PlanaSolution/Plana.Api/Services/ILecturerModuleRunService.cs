using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public interface ILecturerModuleRunService
    {
        Task<IEnumerable<LecturerModuleRunDto>> GetLecturerModuleRuns();

        Task<ActionResultDto<LecturerModuleRunDto>> AddLecturerModuleRun(LecturerModuleRunDto lecturerModuleRunDto);
        
        Task<LecturerModuleRunDto> UpdateLecturerModuleRun(LecturerModuleRunDto lecturerModuleRunDto);
       
        Task<LecturerModuleRunDto> GetLecturerModuleRun(int moduleRunId, int lecturerId);

        Task<bool> DeleteLecturerModuleRun(int moduleRunId, int lecturerId);
    }
}
