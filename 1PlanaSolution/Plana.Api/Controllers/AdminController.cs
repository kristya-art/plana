using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Models;
using Plana.Api.Services;
using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ILecturerService _lecturerService;
        private readonly ISemesterService _semesterRepository;
        private readonly IPlanService _planService;
        private readonly IModuleRunService _moduleRunRepository;
        private readonly IModuleRepository _moduleRepository;
        

        public AdminController(ILecturerService lecturerService,
                                ISemesterService semesterRepository,
                                IPlanService planService,
                                IModuleRunService moduleRunRepository,
                                IModuleRepository moduleRepository)
        {
            _lecturerService = lecturerService;
            _semesterRepository = semesterRepository;
            _planService = planService;
            _moduleRunRepository = moduleRunRepository;
            _moduleRepository = moduleRepository;



        }
        // ../api/admin/modules
        [HttpPost]
        [Route("{modules}")]
        public async Task<ActionResult<ModuleDto>> CreateModule(ModuleDto module)
        {
            try
            {
                if (module == null)
                {
                    return BadRequest();
                }
                var createdModule = await _moduleRepository.AddModule(module);
                return CreatedAtAction(nameof(_moduleRepository.GetModule), new { id = createdModule.ModuleId }, createdModule);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }

       // ../api/admin/modules
        [HttpGet]
        [Route("{modules}")]
        public async Task<ActionResult<IEnumerable<ModuleDto>>> GetModules()
        {
            try
            {
                return Ok(await _moduleRepository.GetModules());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
        //../api/admin/modules/4
        [HttpGet("modules/{id}")]
      
        public async Task<ActionResult<ModuleDto>> GetModule(int id)
        {
            try
            {
                var result = await _moduleRepository.GetModule(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPut()]
        [Route("{modules}")]
        public async Task<ActionResult<ModuleDto>> UpdateModule(ModuleDto module)
        {
            try
            {

                var updateModule = await _moduleRepository.GetModule(module.ModuleId);

                if (updateModule == null)
                {
                    return NotFound($"Lecturer with id = {module.ModuleId} not found");
                }
                return await _moduleRepository.UpdateModule(module);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating database");
            }
        }
        //[HttpPut()]
        //public async Task<ActionResult<Plan>> Update(Plan plandto)
        //{

        //    try
        //    {
        //        var updatedPlan = await _planService.GetPlan(plandto.Id);
        //        if (updatedPlan == null)
        //        {
        //            return NotFound($"Plan with id = {plandto.Id} not found");
        //        }
        //        return await 

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
