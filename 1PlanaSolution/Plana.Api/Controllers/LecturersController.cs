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
    public class LecturersController : ControllerBase
    {
        private readonly ILecturerRepository lecturerRepository;
        public LecturersController(ILecturerRepository lecturerRepository)
        {
            this.lecturerRepository = lecturerRepository;
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Lecturer>>> Search(string name, Gender? gender)
        {
            try
            {
              var result = await  lecturerRepository.Search(name, gender);

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
        public async Task<ActionResult> GetLecturers()
        {
            try
            {
                return Ok(await lecturerRepository.GetLecturersWithTasks());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Lecturer>> GetLecturer(int id)
        {
            try
            {
               var result = await lecturerRepository.GetLecturer(id);
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
        public async Task<ActionResult<Lecturer>> CreateLecturer(Lecturer lecturer)
        {
            try
            {
                if (lecturer == null)
                {
                    return BadRequest();
                }
               var createdLecturer= await lecturerRepository.AddLecturer(lecturer);

                return CreatedAtAction(nameof(GetLecturer),new { id= createdLecturer.Id},createdLecturer);
                

            }
            catch (Exception)

            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Error retrieving data from the database");
            }
        }
        [HttpPut()]
        public async Task<ActionResult<Lecturer>> UpdateLecturer(Lecturer lecturer)
        {
            try
            {
               
                var updateLecturer = await lecturerRepository.GetLecturer(lecturer.Id);

                if (updateLecturer == null)
                {
                    return NotFound($"Lecturer with id = {lecturer.Id} not found");
                }
                return await lecturerRepository.UpdateLecturer(lecturer);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error udating database");
            }
        }

        /** soft deletion */
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Boolean>> SoftDeleteLecturer(int id)
        {
            try
            {

                var deleteLecturer = await lecturerRepository.GetLecturer(id);
                if (deleteLecturer == null)
                {
                    return NotFound($"Lecturer with this id = {id} is not found");
                }
                   return await lecturerRepository.SoftDeleteLecturer(id);
                }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }


        /** normal deletion**/

    //    [HttpDelete("{id:int}")]
    //  //  public async Task<ActionResult<Lecturer>> DeleteLecturer(int id)
    //  public async Task<ActionResult<Boolean>> DeleteLecturer(int id)
    //    {
    //        try
    //        {
    //            var deleteLecturer = await lecturerRepository.GetLecturer(id);
    //            if (deleteLecturer == null)
    //            { return NotFound($"Lecturer with this id = {id} is not found"); 
    //            }
    //              return await lecturerRepository.DeleteLecturer(id);

    //        }
    //        catch (Exception)
    //        {

    //            return StatusCode(StatusCodes.Status500InternalServerError,
    //                "Error deleting data");
    //        }
    //    }

    }
}
