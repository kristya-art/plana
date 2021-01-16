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
    public class LecturerGroupController : ControllerBase
    {
        private readonly ILecturerGroupService _lecturerGroupService;
        private readonly ILogger<LecturerGroupController> _logger;


        public LecturerGroupController(ILecturerGroupService lecturerGroupService,
                                   ILogger<LecturerGroupController> logger)

        {
            _lecturerGroupService = lecturerGroupService;
            _logger = logger;
        }
        

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LecturerGroupDto>>> GetLecturerGroups()
        {
            try
            {
                var result = await _lecturerGroupService.GetLecturerGroups();
                return new ActionResult<IEnumerable<LecturerGroupDto>>(result);
            }
            catch (Exception ex)
            {

                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<LecturerGroupDto>> GetLecturerGroup(int id)
        {
            try
            {
                var result = await _lecturerGroupService.GetLectureGroup(id);
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
        public async Task<ActionResultDto<LecturerGroupDto>> CreateLecturerGroup(LecturerGroupDto lg)
        {

           
            return await _lecturerGroupService.AddLecturerGroup(lg);
        }

        [HttpPut()]
        public async Task<ActionResult<LecturerGroupDto>> UpdateLecturerGroupDto(LecturerGroupDto lecturerGroup)
        {
            try
            {

                var updatedLecturerGroup = await _lecturerGroupService.GetLectureGroup(lecturerGroup.LecturerGroupId);
                if (updatedLecturerGroup == null)
                {
                    return NotFound($"Module run with id = {lecturerGroup.LecturerGroupId } was not found!");
                }

                return await _lecturerGroupService.UpdateLecturerGroup(updatedLecturerGroup);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorUpdatingDatabase);
            }

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeleteLecturerGroup(int id)
        {
            try
            {

                var LGforDelete = await _lecturerGroupService.GetLectureGroup(id);
                if (LGforDelete == null)
                {
                    return NotFound();

                }
                return await _lecturerGroupService.DeleteLecturerGroup(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

    }
}