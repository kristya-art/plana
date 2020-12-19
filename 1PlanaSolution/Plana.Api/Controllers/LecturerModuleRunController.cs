using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Repositories;
using Plana.Models;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturerModuleRunController : ControllerBase
    {
        private readonly ILecturerModuleRunRepository _lecturerModuleRunRepository;


        public LecturerModuleRunController(ILecturerModuleRunRepository lecturerModuleRunRepository)
        {
            _lecturerModuleRunRepository = lecturerModuleRunRepository;
        }

        [HttpPut()]
        public async Task<ActionResult<LecturerModuleRun>> UpdateLecturerModuleRun(LecturerModuleRun lecturerModuleRun)
        {
            int id = lecturerModuleRun.LecturerId;
            int id2 = lecturerModuleRun.ModuleRunId;
            try
            {

                var updatedLecturerModuleRun = await _lecturerModuleRunRepository.GetLecturerModuleRun(id2, id);
                if (updatedLecturerModuleRun == null)
                {
                    return NotFound($"LecturerModuleRun with id = {lecturerModuleRun.LecturerId}and id = {lecturerModuleRun.ModuleRunId} not found!");
                }

                //return await moduleRunRep.UpdateModuleRun(moduleRun);
                return await _lecturerModuleRunRepository.UpdateLecturerModuleRun(lecturerModuleRun);



            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating database");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetLecturerModuleRuns()
        {
            try
            {
                return Ok(await _lecturerModuleRunRepository.GetLecturerModuleRuns());

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
         [HttpGet("{id}/{id2}")]    //https://localhost:44399/api/lecturerModuleRun/1/6
        public async Task<ActionResult<LecturerModuleRun>> GetLecturerModuleRun(int id, int id2)
        {
            try
            {
                var result = await _lecturerModuleRunRepository.GetLecturerModuleRun(id, id2);
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
        public async Task<ActionResult<LecturerModuleRun>> CreateLecturer(LecturerModuleRun lecturerModuleRun)
        {
            try
            {
                if (lecturerModuleRun == null)
                {
                    return BadRequest();
                }
                var createdLecturerModuleRun = await _lecturerModuleRunRepository.AddLecturerModuleRun(lecturerModuleRun);

                return CreatedAtAction(nameof(GetLecturerModuleRun), new { id = createdLecturerModuleRun.LecturerId}, createdLecturerModuleRun);


            }
            catch (Exception)

            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }
    }
}
