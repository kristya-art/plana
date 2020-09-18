using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Models;
using Plana.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;

namespace Plana.Api.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly ILecturerRepository lecturerRepository;
        private readonly IModuleRepository moduleRepository;
        private readonly IModuleRunRepository moduleRunRepository;
        private readonly IAdditionalAssignmentRepository additionalAssignmentRepository;
        private readonly ISemesterRepository semesterRepository;
        private readonly IStudyBranchRepository studyBranchRepository;


        public PlanController(ILecturerRepository lecturerRepository,
                                IModuleRepository moduleRepository,
                                IModuleRunRepository moduleRunRepository,
                                IAdditionalAssignmentRepository additionalAssignmentRepository,
                                ISemesterRepository semesterRepository,
                                IStudyBranchRepository studyBranchRepository)
        {

            this.lecturerRepository = lecturerRepository;
            this.moduleRepository = moduleRepository;
            this.moduleRunRepository = moduleRunRepository;
            this.semesterRepository = semesterRepository;
            this.studyBranchRepository = studyBranchRepository;
            this.additionalAssignmentRepository = additionalAssignmentRepository;
        }

        
       
        }







    
}
