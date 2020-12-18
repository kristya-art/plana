using Plana.Api.Models;
using Plana.Api.Repositories;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public class ModuleRunService : IModuleRunService
{

        private readonly AppDbContext _context;
        private readonly IModuleRunRepository _moduleRunRepository;
        private readonly IModuleRepository _moduleRepository;
        private readonly ISemesterRepository _semesterRepository;
        private readonly IModuleGroupRepository _moduleGroupRepository;
        private readonly ILecturerModuleRunRepository _lecturerModuleRunRepository;
        //private readonly IModuleRunLecturerGroup _moduleRunLecturerGroup;


        public ModuleRunService(AppDbContext context,
                            IModuleRunRepository moduleRunRepository,
                            IModuleRepository moduleRepository,
                            ISemesterRepository semesterRepository,
                            IModuleGroupRepository moduleGroupRepository,
                            ILecturerModuleRunRepository lecturerModuleRunRepository
                            //IModuleRunLecturerGroup moduleRunLecturerGroup


                           )
        {
            _context = context;
            _moduleRunRepository = moduleRunRepository;
            _moduleRepository = moduleRepository;
            _semesterRepository = semesterRepository;
            _moduleGroupRepository = moduleGroupRepository;
            _lecturerModuleRunRepository = lecturerModuleRunRepository;
            //_moduleRunLecturerGroup = moduleRunLecturerGroup;
            

    }
    public async Task<ModuleRun> SaveModuleRun(ModuleRun moduleRun)
        {
            var result = await _moduleRunRepository.GetModuleRun(moduleRun.ModuleRunId);
            if (result != null)

            {
                //    await _moduleRepository.UpdateModule(moduleRun.Module);

              

               //    await _moduleGroupRepository.UpdateModuleGroup(moduleRun.ModuleGroup);

            return  await _moduleRunRepository.UpdateModuleRun(moduleRun);
                

                
            }
            return null;
        }
    }
}
