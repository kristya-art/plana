//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Plana.Api.Models;
//using Plana.Api.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Plana.Models;
//using Microsoft.AspNetCore.Mvc.Formatters.Xml;

//namespace Plana.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PlanController : ControllerBase
//    {
//        private readonly ILecturerRepository lecturerRepository;
//        private readonly IModuleRepository moduleRepository;
//        private readonly IModuleRunRepository moduleRunRepository;
//        private readonly IAdditionalAssignmentRepository additionalAssignmentRepository;
//        private readonly ISemesterRepository semesterRepository;
//        private readonly IStudyBranchRepository studyBranchRepository;
//        private readonly ILecturerGroupRepository lecturerGroupRep;
//        private readonly ILecturerLecturerGroupRepository lecturerLecturerGroupRep;
//        private readonly ILecturerGroupModuleGroupRepository lecturerGroupModuleGroupRep;
//        private readonly ILecturerModuleGroupRepository lecturerModuleGroupRep;
//        private readonly  ILecturerModuleRunRepository lecturerModuleRunRepository;
//        private readonly  IModuleGroupRepository moduleGroupRepository;
//        private readonly ILecturerSemesterRepository lecturerSemesterRep;

//        public PlanController(ILecturerRepository lecturerRepository,
//                              ILecturerGroupRepository lecturerGroupRep,
//                              ILecturerLecturerGroupRepository lecturerLecturerGroupRep,
//                              ILecturerGroupModuleGroupRepository lecturerGroupModuleGroupRep,
//                              ILecturerModuleGroupRepository lecturerModuleGroupRep,
//                              ILecturerModuleRunRepository lecturerModuleRunRepository,
//                              IModuleGroupRepository moduleGroupRepository,
                              
                                
//                               IModuleRunRepository moduleRunRepository,
//                                IAdditionalAssignmentRepository additionalAssignmentRepository,
//                                ISemesterRepository semesterRepository,
//                                ILecturerSemesterRepository lecturerSemesterRep,
//                                IStudyBranchRepository studyBranchRepository)
//        {


//            this.lecturerSemesterRep = lecturerSemesterRep;
//           this.lecturerGroupRep = lecturerGroupRep;
//           this.lecturerLecturerGroupRep= lecturerLecturerGroupRep;
//           this.lecturerGroupModuleGroupRep= lecturerGroupModuleGroupRep;
//           this.lecturerModuleGroupRep=lecturerModuleGroupRep;
//           this.lecturerModuleRunRepository= lecturerModuleRunRepository;
//           this.moduleGroupRepository= moduleGroupRepository;



//            this.lecturerRepository = lecturerRepository;
            
//            this.moduleRunRepository = moduleRunRepository;
//            this.semesterRepository = semesterRepository;
//            this.studyBranchRepository = studyBranchRepository;
//            this.additionalAssignmentRepository = additionalAssignmentRepository;
//        }
//        // get methods for all necessary data

//        [HttpGet("{id:int}")]
//        public async Task<ActionResult<Semester>> GetSemesterPlan(int id)
//        {
//            try
//            {
//                var result = await semesterRepository.GetSemester(id);
//                if (result == null)
//                {
//                    return NotFound();
//                }
//                return result;
//            }
//            catch (Exception)
//            {

//                return StatusCode(StatusCodes.Status500InternalServerError,
//                    "Error retrieving data from the database");
//            }
//        }

//        [HttpPut()]
//        public async Task<ActionResult<Semester>> UpdatePlan(Semester semester)
//        {
//            try
//            {

//                var updateSemester = await semesterRepository.GetSemester(semester.SemesterId);

//                if (updateSemester == null)
//                {
//                    return NotFound($"Semester with id = {semester.SemesterId} not found");
//                }
//                foreach (var ls in semester.LecturersSemesters)
//                {

//                    await lecturerSemesterRep.UpdateLecturerSemester(ls);
//                }

//                foreach (var aa in semester.AdditionalAssignments)
//                {
//                    await additionalAssignmentRepository.UpdateAdditionalAssignment(aa);
//                }

//                foreach (var mr in semester.ModuleRuns)
//                {
//                    await moduleRunRepository.UpdateModuleRun(mr);
//                }

               
//                return await semesterRepository.UpdateSemester(semester);
                
//            }
//            catch (Exception)
//            {

//                return StatusCode(StatusCodes.Status500InternalServerError,
//                "Error updating database");
//            }
//        }
//        [HttpGet]
//        public async Task<ActionResult> GetSemesterPlans()
//        {
//            try
//            {
//                return Ok(await semesterRepository.GetSemesters());

//            }
//            catch (Exception)
//            {

//                return StatusCode(StatusCodes.Status500InternalServerError,
//                    "Error retrieving data from database");
//            }
//        }

//    }







    
//}
