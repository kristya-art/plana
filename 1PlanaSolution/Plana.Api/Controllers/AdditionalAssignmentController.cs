using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plana.Models;
using Plana.Api.Services;
using Microsoft.Extensions.Logging;
using Plana.Shared;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionalAssignmentController : ControllerBase
    {
        private readonly IAdditionalAssignmentService additionalAssignmentService;
        private readonly ILogger<AdditionalAssignmentController> logger;

        public AdditionalAssignmentController(IAdditionalAssignmentService additionalAssignmentService, ILogger<AdditionalAssignmentController> logger)
        {
            this.additionalAssignmentService = additionalAssignmentService;
            this.logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdditionalAssignmentDto>>> GetAdditionalAssignments()
        {
            try
            {
                return Ok(await additionalAssignmentService.GetAdditionalAssignments());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AdditionalAssignmentDto>> GetAdditionalAssignment(int id)
        {
            try
            {
                var result = await additionalAssignmentService.GetAdditionalAssignment(id);
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
        public async Task<ActionResult<AdditionalAssignmentDto>> CreateAdditionalAssignment(AdditionalAssignmentDto additionalAssignment)
        {
            try
            {
                if (additionalAssignment == null) { return BadRequest(); }
                var createdAAssignment = await additionalAssignmentService.CreateAdditionalAssignment(additionalAssignment);
                return CreatedAtAction(nameof(GetAdditionalAssignment), new { id = createdAAssignment.Id }, createdAAssignment);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }


        [HttpPut]
        public async Task<ActionResult<AdditionalAssignmentDto>> UpdateAAssignemt(AdditionalAssignmentDto additionalAssignment)
        {
            try
            {
                var updateAAssignment = await additionalAssignmentService.GetAdditionalAssignment(additionalAssignment.Id);

                if (updateAAssignment == null)
                {
                    return NotFound($"AditionalAssignment with id = {additionalAssignment.Id} not found");
                }
                return await additionalAssignmentService.UpdateAdditionalAssignment(additionalAssignment);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error udating database");
            }
        }
    }
}
