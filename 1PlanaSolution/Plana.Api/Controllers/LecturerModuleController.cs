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
    public class LecturerModuleController : ControllerBase
    {
        private readonly ILecturersModulesRepository lmRepository;

        public LecturerModuleController(ILecturersModulesRepository lmRepository)
        {

            this.lmRepository = lmRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll() 
        {
            try
            {
                return Ok(await lmRepository.GetAll());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        
        }
    }
}
