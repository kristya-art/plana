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

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ISemesterRepository semesterRepository;

        public SemesterController( AppDbContext _context, ISemesterRepository semesterRepository)
        {
            this.semesterRepository = semesterRepository;
            this._context = _context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Semester>>> Get()
        {
            return await _context.Semesters.ToListAsync();
        }
        [HttpGet("{id}", Name = "GetPerson")]
        public async Task<ActionResult<Semester>> Get(int id)
        {
            return await _context.Semesters.FirstOrDefaultAsync(x => x.SemesterId == id);
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
        //[HttpPost]
        //public async Task<ActionResult<Semester>> CreateSemester(Semester semester)
        //{
        //    try
        //    {
        //        if (semester == null)
        //        {
        //            return BadRequest();
        //        }
        //        var createdSemester = await semesterRepository.CreateSemester(semester);

        //        return CreatedAtAction(nameof(GetSemester), new { id = createdSemester.SemesterId }, createdSemester);


        //    }
        //    catch (Exception)

        //    {

        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //             "Error retrieving data from the database");
        //    }
        //}
        [HttpPost]
        public async Task<ActionResult<Semester>> PostSemester(Semester semester)
        {
            _context.Semesters.Add(semester);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSemester), new { id = semester.SemesterId }, semester);
        }
        //example-pseudo-code
        //[HttpPut]
        //public async Task<IActionResult> UpdateSemester(SemesterDto semesterDto)
        //{
        //    var semester = _context.Semesters.FindAsync(semesterDto.Id);
        //    if(semester == null)
        //    {
        //        throw NotFound("...")
        //    }

        //    // Map dto to model
        //    semester.Name = semesterDto.Name;
        //    // ...

        //    await _context.SaveChangesAsync(semester);
        //}
        [HttpPut]
        public async Task<IActionResult> UpdateSemester(Semester semester) {
            var result =  await _context.Semesters.FindAsync(semester.SemesterId);
            if (semester == null)
            {
                return NotFound("...");
            }
            result.Code = semester.Code;
            result.Date = semester.Date;
            result.AdditionalAssignments = semester.AdditionalAssignments;
            result.LecturersSemesters = semester.LecturersSemesters;
            result.ModuleRuns = semester.ModuleRuns;

            await _context.SaveChangesAsync();
            return Ok(result);

            
        
        }

        //[HttpPut()]
        //public async Task<ActionResult<Semester>> UpdateSemester(Semester semester)
        //{
        //    try
        //    {

        //        var updateSemester = await semesterRepository.GetSemester(semester.SemesterId);

        //        if (updateSemester == null)
        //        {
        //            return NotFound($"Semester with id = {semester.SemesterId} not found");
        //        }
        //        return await semesterRepository.UpdateSemester(semester);
        //    }
        //    catch (Exception)
        //    {

        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //        "Error udating database");
        //    }
        //}

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

/**  System.InvalidOperationException: A second operation started on this context before a previous operation completed. 
 * This is usually caused by different threads using the same instance of DbContext. For more information
 * on how to avoid threading issues with DbContext, see https://go.microsoft.com/fwlink/?linkid=2097913.*/