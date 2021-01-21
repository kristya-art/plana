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
    public class ModuleRunLecturerGroupController : ControllerBase
    {
        private readonly IModuleRunLecturerGroupService _ModuleRunLecturerGroupService;
        private readonly ILogger<ModuleRunLecturerGroupController> _logger;


        public ModuleRunLecturerGroupController(IModuleRunLecturerGroupService ModuleRunLecturerGroupService, ILogger<ModuleRunLecturerGroupController> logger)
        {
            _ModuleRunLecturerGroupService = ModuleRunLecturerGroupService;
            _logger = logger;
        }

        [HttpPut()]
        public async Task<ActionResult<ModuleRunLecturerGroupDto?>> UpdateModuleRunLecturerGroup(ModuleRunLecturerGroupDto ModuleRunLecturerGroup)
        {
            int id = ModuleRunLecturerGroup.LecturerGroupId;
            int id2 = ModuleRunLecturerGroup.ModuleRunId;
            try
            {

                var updatedModuleRunLecturerGroup = await _ModuleRunLecturerGroupService.GetModuleRunLecturerGroup(id2, id);
                if (updatedModuleRunLecturerGroup == null)
                {
                    return NotFound($"ModuleRunLecturerGroup with id = {ModuleRunLecturerGroup.LecturerGroupId}and id = {ModuleRunLecturerGroup.ModuleRunId} not found!");
                }

                
                return await _ModuleRunLecturerGroupService.UpdateModuleRunLecturerGroup(ModuleRunLecturerGroup);



            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating database");
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModuleRunLecturerGroupDto>>> GetModuleRunLecturerGroups()
        {
            try
            {
                return Ok(await _ModuleRunLecturerGroupService.GetModuleRunLecturerGroups());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        

        [HttpGet("{moduleRunId}/{lecturerId}")]    //https://localhost:44399/api/ModuleRunLecturerGroup/1/6
        public async Task<ActionResult<ModuleRunLecturerGroupDto>> GetModuleRunLecturerGroup(int moduleRunId, int lecturerId)
        {
            try
            {
                var result = await _ModuleRunLecturerGroupService.GetModuleRunLecturerGroup(moduleRunId, lecturerId);
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
        public async Task<ActionResultDto<ModuleRunLecturerGroupDto>> CreateLecturer(ModuleRunLecturerGroupDto ModuleRunLecturerGroup)
        {
            return await _ModuleRunLecturerGroupService.AddModuleRunLecturerGroup(ModuleRunLecturerGroup);
        }

        [HttpDelete("{moduleRunId}/{lecturerId}")]
        public async Task<ActionResult<bool>> DeleteModuleRunLecturerGroup(int moduleRunId, int lecturerId)
        {
            try
            {

                var LecturerMRForDelete = await _ModuleRunLecturerGroupService.GetModuleRunLecturerGroup(moduleRunId, lecturerId);
                if (LecturerMRForDelete == null)
                {
                    return NotFound();

                }
                return await _ModuleRunLecturerGroupService.DeleteModuleRunLecturerGroup(moduleRunId, lecturerId);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }
    }
}
