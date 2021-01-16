using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plana.Api.Services;
using Plana.Models;
using Plana.Shared;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlanService _planService;
        private readonly ILogger<PlanController> _logger;
        public PlanController(IPlanService planService, ILogger<PlanController> logger) {

            _planService = planService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanDto>>> GetPlans()
        {
            try
            {
                var result = await _planService.GetAllPlans();
                return new ActionResult<IEnumerable<PlanDto>>(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<PlanDto>> GetPlan(int id)
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
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }
        [HttpPost]
        public async Task<ActionResult<PlanDto>> CreatePlan(PlanDto plan)
        {
            try
            {
                if (plan == null)
                {
                    return BadRequest();
                }
                return await _planService.AddPlan(plan);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }

        }
        [HttpPut()]
        public async Task<ActionResult<PlanDto?>> UpdatePlan(PlanDto plan)
        {
            try
            {
                var planForUpdate = await _planService.GetPlan(plan.Id);
                if (planForUpdate == null)
                {
                    return NotFound($"Plan with id = {plan.Id} not found");
                }

                return await _planService.UpdatePlan(planForUpdate);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorUpdatingDatabase);
            }

        }

        [HttpGet]
        [Route("lastYearPlan/{id}")]
        public async Task<ActionResult<PlanDto>> LastYearPlan(int id)
        {
            try
            {
                var result = await _planService.FindLastYearPlan(id);

                if (result == null)
                {
                    return NotFound($"Last year plan is not found");
                }
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeletePlan(int id)
        {
            try
            {

                var PlanForDelete = await _planService.GetPlan(id);
                if (PlanForDelete == null)
                {
                    return NotFound();

                }
                return await _planService.DeletePlan(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }
    }
}
