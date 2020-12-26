
using Castle.Core.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Services;
using Plana.Models;
using System;
using System.Threading.Tasks;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanLecturerController : ControllerBase
    {
        private readonly IPlanLecturerService _planLecturerService;
        private readonly ILogger _logger;

        public PlanLecturerController(IPlanLecturerService planLecturerService, ILogger logger)
        {
            _planLecturerService = planLecturerService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> GetPlanLecturers()
        {
            try
            {
                return Ok(await _planLecturerService.GetPlanLecturers());
            }
            catch (Exception ex)
            {
                _logger.Error(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

        [HttpGet("{planId}/{lecturerId}")]    //https://localhost:44399/api/planLecturer/1/6
        public async Task<ActionResult<PlanLecturer>> GetPlanLecturer(int planId, int lecturerId)
        {
            try
            {
                var result = await _planLecturerService.GetPlanLecturer(planId, lecturerId);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.Error(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
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

        [HttpPut]
        public async Task<ActionResult<PlanLecturer>> UpdatePlanLecturer(PlanLecturer planLecturer)
        {
            try
            {
                var planLecturerForUpdate = await _planLecturerService.GetPlanLecturer(planLecturer.PlanId, planLecturer.LecturerId);
                if (planLecturerForUpdate == null)
                {
                    return NotFound($"PlanLecturer with planId={planLecturer.LecturerId} and lecturerId={planLecturer.PlanId} was not found!");
                }

                return await _planLecturerService.UpdatePlanLecturer(planLecturerForUpdate);
            }
            catch (Exception ex)
            {
                _logger.Error(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorUpdatingDatabase);
            }
        }

        /// <summary>
        /// Get lecturer's module runs  in concrete plan.
        /// </summary>
        [HttpGet]
        [Route("ModuleRuns/{planId}/{lecturerId}")]
        public async Task<ActionResult> GetModuleRunsForConcretePlan(int planId, int lecturerId)
        {
            try
            {
                return Ok(await _planLecturerService.GetLecturerModuleRuns(planId, lecturerId));
            }
            catch (Exception ex)
            {
                _logger.Error(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }
    }
}


