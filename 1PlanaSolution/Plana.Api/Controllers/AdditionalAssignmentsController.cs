using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Plana.Api.Repositories;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionalAssignmentsController : ControllerBase
    {
        private readonly IAdditionalAssignmentRepository aaRep;
        public AdditionalAssignmentsController(IAdditionalAssignmentRepository aaRep)
        {
            this.aaRep= aaRep;
        }
        [HttpGet]
        public async Task<ActionResult> GetAdditionalAssignments()
        {
            try
            {
                return Ok(await aaRep.GetAdditionalAssignments());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AdditionalAssignment>> GetAdditionalAssignment(int id)
        {
            try
            {
                var result = await aaRep.GetAdditionalAssignment(id);
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
        public async Task<ActionResult<AdditionalAssignment>> CreateAdditionalAssignment(AdditionalAssignment additionalAssignment)
        {
            try
            {
                if (additionalAssignment == null) { return BadRequest(); }
                var createdAAssignment = await aaRep.CreateAdditionalAssignment(additionalAssignment);
                return CreatedAtAction(nameof(GetAdditionalAssignment), new { id = createdAAssignment.AdditionalAssignmentId }, createdAAssignment);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }


        [HttpPut]
        public async Task<ActionResult<AdditionalAssignment>> UpdateAAssignemt(AdditionalAssignment additionalAssignment)
        {
            try
            {
                var updateAAssignment = await aaRep.GetAdditionalAssignment(additionalAssignment.AdditionalAssignmentId);

                if (updateAAssignment == null)
                {
                    return NotFound($"AditionalAssignment with id = {additionalAssignment.AdditionalAssignmentId} not found");
                }
                return await aaRep.UpdateAdditionalAssignment(additionalAssignment);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error udating database");
            }
        }
    }
}
