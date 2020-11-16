using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Plana.Api.Models;
using Plana.Models;
using System.Threading.Tasks;

namespace Plana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanaCotroller : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlanaCotroller(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Plan>> GetPlan(int id)
        {
            var plan = await _context.Plans.FindAsync(id);
            if (plan == null)
            {
                return NotFound();
            }
            return plan;
        }
        [HttpGet]
        public async Task<ActionResult> GetPlans()
        {
            //try
            //{
            //    return Ok(await _context.Plans);
            //}
            //catch (Exception)
            //{

            //    return StatusCode(StatusCodes.Status500InternalServerError,
            //        "Error retrieving data from database");
            //}
            var result = await _context.Plans.ToListAsync();

            return Ok(result);
            
        }

    }
}
