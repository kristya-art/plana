using Microsoft.AspNetCore.Mvc;
using Plana.Api.Models;
using Plana.Api.Services;
using Plana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ILecturerRepository _lecturerRepository;
        private readonly ISemesterRepository _semesterRepository;
        private readonly IPlanService _planService;
        private readonly IModuleRunRepository _moduleRunRepository;

        public AdminController(ILecturerRepository lecturerRepository,
                                ISemesterRepository semesterRepository,
                                IPlanService planService,
                                IModuleRunRepository moduleRunRepository)
        {
            _lecturerRepository = lecturerRepository;
            _semesterRepository = semesterRepository;
            _planService = planService;
            _moduleRunRepository = moduleRunRepository;

        
        
        }

        //[HttpPut()]
        //public async Task<ActionResult<Plan>> Update(Plan plandto)
        //{

        //    try
        //    {
        //        var updatedPlan = await _planService.GetPlan(plandto.Id);
        //        if (updatedPlan == null)
        //        {
        //            return NotFound($"Plan with id = {plandto.Id} not found");
        //        }
        //        return await 
                
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
