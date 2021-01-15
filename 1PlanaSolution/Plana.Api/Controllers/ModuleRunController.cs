using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plana.Api.Models;
using Plana.Api.Repositories;
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
    public class ModuleRunController : ControllerBase
    {
        private readonly IModuleRunService _moduleRunService;
        private readonly ILogger<ModuleRunController> _logger;

        //private readonly IModuleRepository moduleRep;
        //private readonly ISemesterRepository semesterRep;
        //private readonly ILecturerService lecturerService;
        //private readonly IModuleRunService moduleRunService;
        //private readonly ILecturerModuleRunRepository lecturerModuleRunRepository;

        public ModuleRunController(IModuleRunService moduleRunService,
                                   ILogger<ModuleRunController> logger)
        //IModuleRepository moduleRepository,
        //ISemesterRepository semesterRepository,
        //ILecturerService lecturerService,
        //IModuleRunService moduleRunService,
        //ILecturerModuleRunRepository lecturerModuleRunRepository)
        {
            _moduleRunService = moduleRunService;
            _logger = logger;
            //this.moduleRep = moduleRepository;
            //this.semesterRep = semesterRepository;
            //this.lecturerService=lecturerService;
            //this.moduleRunService = moduleRunService;
            //this.lecturerModuleRunRepository = lecturerModuleRunRepository;


        }
        //[HttpGet("{search}")]
        //public async Task<ActionResult<IEnumerable<ModuleRun>>> Search( string name,string code)
        //{
        //    try
        //    {
        //        var result = await moduleRunRepository.Search(name,code);

        //        if (result.Any())
        //        {
        //            return Ok(result);
        //        }
        //        return NotFound();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error retrieving data from database");
        //    }
        //}
        //[HttpGet("{searchfrom}")]
        //public async Task<ActionResult<IEnumerable<ModuleRun>>> SearchFromModule(string moduleCode)
        //{
        //    try
        //    {
        //        var result = await moduleRunRepository.SearchFromModule(moduleCode);

        //        if (result.Any())
        //        {
        //            return Ok(result);
        //        }
        //        return NotFound();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error retrieving data from database");
        //    }
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModuleRunDto>>> GetModuleRuns()
        {
            try
            {
                var result = await _moduleRunService.GetModuleRuns();
                return new ActionResult<IEnumerable<ModuleRunDto>>(result);
            }
            catch (Exception ex)
            {

                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        
        }
        
        //[HttpGet]
        //public async Task<ActionResult> GetCustomMRs()
        //{
        //    try
        //    {
        //        return Ok(await moduleRunRepository.GetCustomated());


        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //               "Error retrieving data from database");
        //    }


        //}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ModuleRunDto>> GetModuleRun(int id)
        {
            try
            {
                var result = await _moduleRunService.GetModuleRun(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }

        }

        [HttpPost]
        public async Task<ActionResultDto<ModuleRunDto>> CreateModuleRun(ModuleRunDto mr)
        {

            //try
            //{
            //    if (mr == null)
            //    {
            //        return BadRequest();
            //    }
            //    return await _moduleRunService.CreateModuleRun(mr);
            // }

            //catch (Exception)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError,
            //         "Error retrieving data from the database");
            //}
            return await _moduleRunService.CreateModuleRun(mr);
        }

       [HttpPut()]
        public async Task<ActionResult<ModuleRunDto>> UpdateModuleRun(ModuleRunDto moduleRun)
        {
            try
            {

                var updatedModuleRun = await _moduleRunService.GetModuleRun(moduleRun.ModuleRunId);
                if (updatedModuleRun == null)
                {
                    return NotFound($"Module run with id = {moduleRun.ModuleRunId } was not found!");
                }

                return await _moduleRunService.UpdateModuleRun(moduleRun);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorUpdatingDatabase);
            }

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeleteModuleRun(int id)
        {
            try
            {

                var MRForDelete = await _moduleRunService.GetModuleRun(id);
                if (MRForDelete == null)
                {
                    return NotFound();

                }
                return await _moduleRunService.DeleteModuleRun(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

    }
}