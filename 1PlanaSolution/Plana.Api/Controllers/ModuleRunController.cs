using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plana.Api.Services;
using Plana.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleRunController : ControllerBase
    {
        private readonly IModuleRunService _moduleRunService;
        private readonly ILogger<ModuleRunController> _logger;
        public ModuleRunController(IModuleRunService moduleRunService,
                                   ILogger<ModuleRunController> logger)
        
        {
            _moduleRunService = moduleRunService;
            _logger = logger;
         }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModuleRunDto>>> GetModuleRuns()
        {
            try
            {
                var result = await _moduleRunService.GetModuleRuns();
                return new ActionResult<IEnumerable<ModuleRunDto>>(result);
            }
            catch (Exception ex)
            {

                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ModuleRunDto>> GetModuleRun(int id)
        {
            try
            {
                var result = await _moduleRunService.GetModuleRun(id);
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
        public async Task<ActionResultDto<ModuleRunDto>> CreateModuleRun(ModuleRunDto mr)
        {

            
            return await _moduleRunService.CreateModuleRun(mr);
        }

       [HttpPut()]
        public async Task<ActionResult<ModuleRunDto?>> UpdateModuleRun(ModuleRunDto moduleRun)
        {
            try
            {

                var updatedModuleRun = await _moduleRunService.GetModuleRun(moduleRun.ModuleRunId);
                if (updatedModuleRun == null)
                {
                    return NotFound($"Module run with id = {moduleRun.ModuleRunId } was not found!");
                }

                return await _moduleRunService.UpdateModuleRun(moduleRun);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorUpdatingDatabase);
            }

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeleteModuleRun(int id)
        {
            try
            {

                var MRForDelete = await _moduleRunService.GetModuleRun(id);
                if (MRForDelete == null)
                {
                    return NotFound();

                }
                return await _moduleRunService.DeleteModuleRun(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(SR.ErrorRetrievingDataFromDataBase, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, SR.ErrorRetrievingDataFromDataBase);
            }
        }

    }
}