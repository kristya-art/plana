using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plana.Api.Services;
using Plana.Models;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanLecturerController : ControllerBase
    {
        private readonly IPlanLecturerService _planLecturerService;
        private readonly ILogger<PlanLecturerController> _logger;

        public PlanLecturerController(IPlanLecturerService planLecturerService, ILogger<PlanLecturerController> logger)
        {
            _planLecturerService = planLecturerService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanLecturerDto>>> GetPlanLecturers()
        {
            try
            {
                var result = await _planLecturerService.GetPlanLecturers();
                return new ActionResult<IEnumerable<PlanLecturerDto>>(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

        [HttpGet("{planId}/{lecturerId}")]    //https://localhost:44399/api/planLecturer/1/6
        public async Task<ActionResult<PlanLecturerDto>> GetPlanLecturer(int planId, int lecturerId)
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
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

        [HttpPost]
        public async Task<ActionResult<PlanLecturerDto>> CreatePlanLecturer(PlanLecturerDto planLecturer)
        {
            try
            {
                if (planLecturer == null)
                {
                    return BadRequest();
                }

                return await _planLecturerService.AddPlanLecturer(planLecturer);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPut]
        public async Task<ActionResult<PlanLecturerDto?>> UpdatePlanLecturer(PlanLecturerDto planLecturer)
        {
            try
            {
                var planLecturerForUpdate = await _planLecturerService.GetPlanLecturer(planLecturer.PlanId, planLecturer.LecturerId);
                if (planLecturerForUpdate == null)
                {
                    return NotFound($"PlanLecturer with planId={planLecturer.PlanId} and lecturerId={planLecturer.LecturerId} was not found!");
                }

                return await _planLecturerService.UpdatePlanLecturer(planLecturerForUpdate);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
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
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }
    }
}


