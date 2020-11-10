using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Microsoft.EntityFrameworkCore;

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
        [HttpPut]
        public async Task<IActionResult> UpdateSemester( Semester semester)
        {
            //if (id != semester.SemesterId)
            //{
            //    return BadRequest();
            //}
            if (semester.ModuleRuns != null)
            {
                foreach (var mr in semester.ModuleRuns)
                {

                    _context.Entry(mr).State = EntityState.Modified;
                }
            }
            if (semester.AdditionalAssignments != null)
            {
                foreach (var aa in semester.AdditionalAssignments)
                {
                    _context.Entry(aa).State = EntityState.Modified;
                }
            }

            if (semester.LecturersSemesters != null) {
                
                foreach (var ls in semester.LecturersSemesters)
                {

                    _context.Entry(ls).State = EntityState.Modified;
                    if (ls.Lecturer != null)
                    {
                        _context.Entry(ls.Lecturer).State = EntityState.Modified;
                    }
                    if (ls.Semester != null)
                    {
                        _context.Entry(ls.Semester).State = EntityState.Modified;
                    }
                   
                }
            }
            _context.Entry(semester).State = EntityState.Modified;
           
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (semester == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                
                }
            }

            return NoContent();
        
        }
       



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