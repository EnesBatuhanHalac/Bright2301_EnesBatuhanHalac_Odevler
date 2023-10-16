using BrightApp.Data.Abstract;
using BrightApp.Entity.Concrete;
using BrightApp.Entity.DataTransferObjects;
using BrightApp.Entity.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace BrightAcademieWebApp.Controllers
{
    [Route("api/Trainee")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public TraineeController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllTrainees()
        {
                var trainee = _manager.TraineeService.GetAllTrainee(false);
                return Ok(trainee);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetTrainee([FromRoute] int id)
        {
            var trainee = _manager.TraineeService.GetTrainee(id, false);
            if (trainee == null)
                throw new TraineeNotFoundException(id);
                return Ok(trainee);
        }

        [HttpPost]
        public IActionResult PostTrainee([FromBody] Trainee trainee)
        {
                if (trainee == null)
                    return BadRequest();

                _manager.TraineeService.CreateTrainee(trainee);
                return StatusCode(201, trainee);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneTrainee([FromRoute] int id,
            [FromBody] TraineeDtoForUpdate TraineeDto)
        {
                if (TraineeDto == null)
                    return BadRequest();

                _manager.TraineeService.UpdateTrainee(id, TraineeDto, false);
                return NoContent();

        }

        [HttpDelete("{id:int}")]

        public IActionResult DeleteOneTrainee([FromRoute] int id)
        {
            _manager.TraineeService.DeleteTrainee(id, false);
                return NoContent();
        }

        [HttpPatch("{id:int}")]
        public IActionResult PartiallyUpdateOneTrainee([FromRoute(Name = "id")] int id,
            [FromBody] JsonPatchDocument<Trainee> trainee)
        {
           var entity = _manager.TraineeService.GetTrainee(id, true);

           if (entity is null)
             return NotFound();


           trainee.ApplyTo(entity);
           _manager.TraineeService.UpdateTrainee(id, new TraineeDtoForUpdate(), true);
             return NoContent();

        }
    }
}
