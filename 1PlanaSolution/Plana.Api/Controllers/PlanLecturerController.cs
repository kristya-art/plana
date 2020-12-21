
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Services;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanLecturerController : ControllerBase
    {
        private readonly IPlanLecturerService _planLecturerService;
    

    public PlanLecturerController(IPlanLecturerService planLecturerService)
    {
        _planLecturerService = planLecturerService;
    }

        [HttpPut()]
        public async Task<ActionResult<PlanLecturer>> UpdateLecturerModuleRun(PlanLecturer planLecturer)
        {
            int id = planLecturer.LecturerId;
            int id2 = planLecturer.PlanId;
            try
            {

                var updatedPlanLecturer = await _planLecturerService.GetPlanLecturer(id2, id);
                if (updatedPlanLecturer == null)
                {
                    return NotFound($"PlanLecturer with id = {planLecturer.LecturerId}and id = {planLecturer.PlanId} not found!");
                }

               
                return await _planLecturerService.UpdatePlanLecturer(planLecturer);



            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating database");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetPlanLecturers()
        {
            try
            {
                return Ok(await _planLecturerService.GetPlanLecturers());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

       
        [HttpGet("{id}/{id2}")]    //https://localhost:44399/api/planLecturer/1/6
        public async Task<ActionResult<PlanLecturer>> GetPlanLecturer(int id, int id2)
        {
            try
            {
                var result = await _planLecturerService.GetPlanLecturer(id, id2);
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
        public async Task<ActionResult<PlanLecturer>> CreatePlanLecturer(PlanLecturer planLecturer)
        {
            try
            {
                if (planLecturer == null)
                {
                    return BadRequest();
                }
                var createdPlanLecturer = await _planLecturerService.AddPlanLecturer(planLecturer);

                return CreatedAtAction(nameof(GetPlanLecturer), new { id = createdPlanLecturer.LecturerId }, createdPlanLecturer);


            }
            catch (Exception)

            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }
    }
}


