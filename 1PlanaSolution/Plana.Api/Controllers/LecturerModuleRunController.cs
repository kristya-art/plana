using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plana.Api.Services;
using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturerModuleRunController : ControllerBase
    {
        private readonly ILecturerModuleRunService _lecturerModuleRunService;
        private readonly ILogger<LecturerModuleRunController> _logger;


        public LecturerModuleRunController(ILecturerModuleRunService lecturerModuleRunService, ILogger<LecturerModuleRunController> logger)
        {
            _lecturerModuleRunService = lecturerModuleRunService;
            _logger = logger;
        }

        [HttpPut()]
        public async Task<ActionResult<LecturerModuleRunDto>> UpdateLecturerModuleRun(LecturerModuleRunDto lecturerModuleRun)
        {
            int id = lecturerModuleRun.LecturerId;
            int id2 = lecturerModuleRun.ModuleRunId;
            try
            {

                var updatedLecturerModuleRun = await _lecturerModuleRunService.GetLecturerModuleRun(id2, id);
                if (updatedLecturerModuleRun == null)
                {
                    return NotFound($"LecturerModuleRun with id = {lecturerModuleRun.LecturerId}and id = {lecturerModuleRun.ModuleRunId} not found!");
                }

                //return await moduleRunRep.UpdateModuleRun(moduleRun);
                return await _lecturerModuleRunService.UpdateLecturerModuleRun(lecturerModuleRun);



            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating database");
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LecturerModuleRunDto>>> GetLecturerModuleRuns()
        {
            try
            {
                return Ok(await _lecturerModuleRunService.GetLecturerModuleRuns());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        /// Example of multiple parameters
        ///   [HttpGet("empId={empId}&startDate={startDate}&endDate={endDate}")]
        ///    public IEnumerable<Validate> Get(int empId, string startDate, string endDate) { }

        //[HttpGet("{id:int}/{id2:int}")]   

        //[HttpGet]
        //[HttpGet("id={id}&id2={id2}")] //  ==>{router}/empId=1&startDate=2020-20-20&endDate=2020-20-20 (postman)

        [HttpGet("{moduleRunId}/{lecturerId}")]    //https://localhost:44399/api/lecturerModuleRun/1/6
        public async Task<ActionResult<LecturerModuleRunDto>> GetLecturerModuleRun(int moduleRunId, int lecturerId)
        {
            try
            {
                var result = await _lecturerModuleRunService.GetLecturerModuleRun(moduleRunId, lecturerId);
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
        [HttpPost]
        public async Task<ActionResultDto<LecturerModuleRunDto>> CreateLecturer(LecturerModuleRunDto lecturerModuleRun)
        {
            return await _lecturerModuleRunService.AddLecturerModuleRun(lecturerModuleRun);
        }

        [HttpDelete("{moduleRunId}/{lecturerId}")]
        public async Task<ActionResult<bool>> DeleteLecturerModuleRun(int moduleRunId, int lecturerId)
        {
            try
            {

                var LecturerMRForDelete = await _lecturerModuleRunService.GetLecturerModuleRun(moduleRunId, lecturerId);
                if (LecturerMRForDelete == null)
                {
                    return NotFound();

                }
                return await _lecturerModuleRunService.DeleteLecturerModuleRun(moduleRunId, lecturerId);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }
    }
}
