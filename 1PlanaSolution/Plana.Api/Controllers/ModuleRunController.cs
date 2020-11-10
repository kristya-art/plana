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
    public class ModuleRunController : ControllerBase
    {
        private readonly IModuleRunRepository moduleRunRep;
        private readonly IModuleRepository moduleRep;
        private readonly ISemesterRepository semesterRep;
        private readonly ILecturerRepository lecturerRep;

        public ModuleRunController(IModuleRunRepository moduleRunRepository,
                                IModuleRepository moduleRepository,
                                ISemesterRepository semesterRepository,
                                ILecturerRepository lecturerRepository)
        {
            this.moduleRunRep = moduleRunRepository;
            this.moduleRep = moduleRepository;
            this.semesterRep = semesterRepository;
            this.lecturerRep = lecturerRepository;


        }
        //[HttpGet("{search}")]
        //public async Task<ActionResult<IEnumerable<ModuleRun>>> Search( string name,string code)
        //{
        //    try
        //    {
        //        var result = await moduleRunRepository.Search(name,code);

        //        if (result.Any())
        //        {
        //            return Ok(result);
        //        }
        //        return NotFound();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error retrieving data from database");
        //    }
        //}
        //[HttpGet("{searchfrom}")]
        //public async Task<ActionResult<IEnumerable<ModuleRun>>> SearchFromModule(string moduleCode)
        //{
        //    try
        //    {
        //        var result = await moduleRunRepository.SearchFromModule(moduleCode);

        //        if (result.Any())
        //        {
        //            return Ok(result);
        //        }
        //        return NotFound();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error retrieving data from database");
        //    }
        //}

        [HttpGet]
        public async Task<ActionResult> GetModuleRuns()
        {
            try
            {
                return Ok(await moduleRunRep.GetModuleRuns());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
        //[HttpGet]
        //public async Task<ActionResult> GetCustomMRs()
        //{
        //    try
        //    {
        //        return Ok(await moduleRunRepository.GetCustomated());


        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //               "Error retrieving data from database");
        //    }


        //}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ModuleRun>> GetModuleRun(int id)
        {
            try
            {
                var result = await moduleRunRep.GetModuleRun(id);
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
                var createdModuleRun = await moduleRunRep.CreateModuleRun(mr);
                //await moduleRep.UpdateModule(mr.Module);
                //await semesterRep.UpdateSemester(mr.Semester);

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
                
                var updatedModuleRun = await moduleRunRep.GetModuleRun(moduleRun.ModuleRunId);
                if (updatedModuleRun == null)
                {
                    return NotFound($"Module run with id = {moduleRun.ModuleRunId } not found!");
                }
                return await moduleRunRep.UpdateModuleRun(moduleRun);
                //await moduleRep.UpdateModule(moduleRun.Module);
                //await semesterRep.UpdateSemester(moduleRun.Semester);
                //return StatusCode(StatusCodes.Status200OK, "Is ok");

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating database");
            }
        }
        

    }
}