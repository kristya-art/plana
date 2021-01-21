using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plana.Api.Models;
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
    public class LecturerController : ControllerBase
    {
        private readonly ILecturerService _lecturerService;
        private readonly ILogger<LecturerController> _logger;

        public LecturerController(ILecturerService lecturerService, ILogger<LecturerController> logger)
        {
            _lecturerService = lecturerService;
            _logger = logger;
        }

      

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LecturerDto>>> GetLecturers()
        {
            try
            {
                var lecturers = await _lecturerService.GetLecturers();
                return new ActionResult<IEnumerable<LecturerDto>>(lecturers);

            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<LecturerDto>> GetLecturer(int id)
        {
            try
            {
               var result = await _lecturerService.GetLecturer(id);
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
        public async Task<ActionResult<LecturerDto>> CreateLecturer(LecturerDto lecturer)
        {
            try
            {
                if (lecturer == null)
                {
                    return BadRequest();
                }

                return await _lecturerService.AddLecturer(lecturer);

             }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

        [HttpPut()]
        public async Task<ActionResult<LecturerDto?>> UpdateLecturer(LecturerDto lecturer)
        {
            try
            {
               
                var lecturerForUpdate = await _lecturerService.GetLecturer(lecturer.Id);

                if (lecturerForUpdate == null)
                {
                    return NotFound($"Lecturer with id = {lecturer.Id} was not found");
                }
                return await _lecturerService.UpdateLecturer(lecturer);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorUpdatingDatabase);
            }
        }

    
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Boolean>> DeleteLecturer(int id)
        {
            try
            {

                var LecturerForDelete = await _lecturerService.GetLecturer(id);
                if (LecturerForDelete == null)
                {
                    return NotFound($"Lecturer with this id = {id} is not found");
                }
                   return await _lecturerService.DeleteLecturer(id);
                }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<LecturerDto>>> Search(string name, Gender? gender)
        {
            try
            {
                var result = await _lecturerService.Search(name, gender);

                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

    }
}
