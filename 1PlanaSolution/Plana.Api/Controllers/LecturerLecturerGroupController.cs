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
    public class LecturerLecturerGroupController : ControllerBase
    {
        private readonly ILecturerLecturerGroupService _lecturerLecturerGroupService;
        private readonly ILogger<LecturerLecturerGroupController> _logger;


        public LecturerLecturerGroupController(ILecturerLecturerGroupService lecturerLecturerGroupService, ILogger<LecturerLecturerGroupController> logger)
        {
            _lecturerLecturerGroupService = lecturerLecturerGroupService;
            _logger = logger;
        }

        [HttpPut()]
        public async Task<ActionResult<LecturerLecturerGroupDto>> UpdateLecturerLecturerGroup(LecturerLecturerGroupDto lecturerLecturerGroup)
        {
            int id = lecturerLecturerGroup.LecturerId;
            int id2 = lecturerLecturerGroup.LecturerGroupId;
            try
            {

                var updatedLecturerLecturerGroup = await _lecturerLecturerGroupService.GetLectureLecturerGroup(id2, id);
                if (updatedLecturerLecturerGroup == null)
                {
                    return NotFound($"LecturerLecturerGroup with id = {lecturerLecturerGroup.LecturerId}and id = {lecturerLecturerGroup.LecturerGroupId} not found!");
                }

                //return await LecturerGroupRep.UpdateLecturerGroup(LecturerGroup);
                return await _lecturerLecturerGroupService.UpdateLecturerLecturerGroup(lecturerLecturerGroup);



            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating database");
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LecturerLecturerGroupDto>>> GetLecturerLecturerGroups()
        {
            try
            {
                return Ok(await _lecturerLecturerGroupService.GetLecturerLecturerGroups());

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

        [HttpGet("{lecturerId}/{lecturerGroupId}")]    //https://localhost:44399/api/lecturerLecturerGroup/1/6
        public async Task<ActionResult<LecturerLecturerGroupDto>> GetLecturerLecturerGroup( int lecturerId, int lecturerGroupId)
        {
            try
            {
                var result = await _lecturerLecturerGroupService.GetLectureLecturerGroup(lecturerId, lecturerGroupId);
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
        public async Task<ActionResultDto<LecturerLecturerGroupDto>> CreateLecturer(LecturerLecturerGroupDto lecturerLecturerGroup)
        {
            return await _lecturerLecturerGroupService.AddLecturerLecturerGroup(lecturerLecturerGroup);
        }

        [HttpDelete("{lecturerId}/{lecturerGroupId}")]
        public async Task<ActionResult<bool>> DeleteLecturerLecturerGroup(int lecturerId, int lecturerGroupId)
        {
            try
            {

                var LecturerMRForDelete = await _lecturerLecturerGroupService.GetLectureLecturerGroup(lecturerGroupId, lecturerId);
                if (LecturerMRForDelete == null)
                {
                    return NotFound();

                }
                return await _lecturerLecturerGroupService.DeleteLecturerLecturerGroup(lecturerId, lecturerGroupId);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }
    }
}
