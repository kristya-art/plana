using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plana.Api.Models;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleRunsController : ControllerBase
    {
        private readonly IModuleRunRepository moduleRunRepository;

        public ModuleRunsController(IModuleRunRepository moduleRunRepository)
        {
            this.moduleRunRepository = moduleRunRepository;

        }
        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<ModuleRun>>> Search(Semester semester, string code)
        {
            try
            {
                var result = await moduleRunRepository.Search(semester, code);

                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetModuleRuns()
        {
            try
            {
                return Ok(await moduleRunRepository.GetModuleRuns());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ModuleRun>> GetModuleRun(int id)
        {
            try
            {
                var result = await moduleRunRepository.GetModuleRun(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }

        }

        [HttpPost]
        public async Task<ActionResult<ModuleRun>> CreateModuleRun(ModuleRun mr)
        {

            try
            {
                if (mr == null)
                {
                    return BadRequest();
                }
                var createdModuleRun = await moduleRunRepository.CreateModuleRun(mr);

                return CreatedAtAction(nameof(GetModuleRun), new { id = createdModuleRun.ModuleRunId }, createdModuleRun);


            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }

        [HttpPut()]
        public async Task<ActionResult<ModuleRun>> UpdateModuleRun(ModuleRun moduleRun)
        {
            try
            {
                
                var updatedModuleRun = await moduleRunRepository.GetModuleRun(moduleRun.ModuleRunId);
                if (updatedModuleRun == null)
                {
                    return NotFound($"Module run with id = {moduleRun.ModuleRunId } not found!");
                }
                return await moduleRunRepository.UpdateModuleRun(moduleRun);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error udating database");
            }
        }
        

    }
}