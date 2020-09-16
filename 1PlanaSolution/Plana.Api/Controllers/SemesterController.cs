using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {

        private readonly ISemesterRepository semesterRepository;

        public SemesterController(ISemesterRepository semesterRepository)
        {
            this.semesterRepository = semesterRepository;
        }



        /// <summary>
        /// crud for Semester
        /// </summary>

        //[HttpGet("{search}")]
        //public async Task<ActionResult<IEnumerable<Semester>>> Search(string name)
        //{
        //    try
        //    {
        //        var result = await semesterRepository.Search(name);

        //        if (result.Any())
        //        {
        //            return Ok(result);
        //        }
        //        return NotFound();
        //    }
        //    catch (Exception)
        //    {

        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error retrieving data from database");
        //    }
        //}


        [HttpGet]
        public async Task<ActionResult> GetSemesters()
        {
            try
            {
                return Ok(await semesterRepository.GetSemesters());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Semester>> GetSemester(int id)
        {
            try
            {
                var result = await semesterRepository.GetSemester(id);
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
        public async Task<ActionResult<Semester>> CreateSemester(Semester semester)
        {
            try
            {
                if (semester == null)
                {
                    return BadRequest();
                }
                var createdSemester = await semesterRepository.CreateSemester(semester);

                return CreatedAtAction(nameof(GetSemester), new { id = createdSemester.SemesterId }, createdSemester);


            }
            catch (Exception)

            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }
        [HttpPut()]
        public async Task<ActionResult<Semester>> UpdateSemester(Semester semester)
        {
            try
            {

                var updateSemester = await semesterRepository.GetSemester(semester.SemesterId);

                if (updateSemester == null)
                {
                    return NotFound($"Semester with id = {semester.SemesterId} not found");
                }
                return await semesterRepository.UpdateSemester(semester);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error udating database");
            }
        }

        /** soft deletion */
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Boolean>> SoftDeleteSemester(int id)
        {
            try
            {

                var deleteSemester = await semesterRepository.GetSemester(id);
                if (deleteSemester == null)
                {
                    return NotFound($"Semester with this id = {id} is not found");
                }
                return await semesterRepository.SoftDeleteSemester(id);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}