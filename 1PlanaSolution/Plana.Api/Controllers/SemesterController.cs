using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Plana.Api.Repositories;

using Plana.Api.Services;
using Microsoft.Extensions.Logging;
using Plana.Shared;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly ISemesterService _semesterService;
        private readonly ILogger<SemesterController> _logger;
       

        public SemesterController(ISemesterService semesterService, ILogger<SemesterController> logger)
        {
            _semesterService = semesterService;
            _logger = logger;
        
        }
      

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SemesterDto>>> GetSemesters()
        {
            try
            {
                var result = await _semesterService.GetSemesters();
                return new ActionResult<IEnumerable<SemesterDto>>(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SemesterDto>> GetSemester(int id)
        {
            try
            {
                var result = await _semesterService.GetSemester(id);
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
        public async Task<ActionResult<SemesterDto>> CreateSemester(SemesterDto semester)
        {
            try
            {
                if (semester == null)
                {
                    return BadRequest();
                }


                return await _semesterService.CreateSemester(semester);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPut]
        public async Task<ActionResult<SemesterDto>> UpdateSemester(SemesterDto semester)
        {
            try
            {
                var semesterForUpdate = await _semesterService.GetSemester(semester.SemesterId);
                if (semesterForUpdate == null)
                {
                    return NotFound($"Semester with Id={semester.SemesterId} was not found!");
                }

                return await _semesterService.UpdateSemester(semesterForUpdate);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorUpdatingDatabase);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeleteSemester(int id)
        {
            try
            {

                var deleteSemester = await _semesterService.GetSemester(id);
                if (deleteSemester == null)
                {
                    return NotFound($"Semester with this id = {id} is not found");
                }
                return await _semesterService.DeleteSemester(id);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

     }
}
