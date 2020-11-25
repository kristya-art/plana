using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Services;
using Plana.Models;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlanService _planService;
        public PlanController(IPlanService planService) {

            _planService = planService;
        }

        [HttpGet]
        public async Task<ActionResult> GetPlans()
        {
            try
            {
                return Ok(await _planService.GetAllPlans());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Plan>> GetPlan(int id)
        {
            try
            {
                var result = await _planService.GetPlan(id);
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
        public async Task<ActionResult<Plan>> CreatePlan(Plan plan)
        {
            try
            {
                if (plan == null)
                {
                    return BadRequest();
                }
                var createdPlan = await _planService.AddPlan(plan);
                return CreatedAtAction(nameof(GetPlan), new { id = createdPlan.Id }, createdPlan);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        
        }
        [HttpPut()]
        public async Task<ActionResult<Plan>> UpdatePlan(Plan plan)
        {
            try
            {
                var updatedPlan = await _planService.GetPlan(plan.Id);
                if (updatedPlan == null)
                {
                    return NotFound($"Plan with id = {plan.Id} not found");
                }

                return await _planService.UpdatePlan(plan);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating database");
            }
        
        }
    }
}
