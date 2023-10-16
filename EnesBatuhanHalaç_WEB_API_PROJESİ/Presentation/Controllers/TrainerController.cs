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
    [Route("api/Trainer")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public TrainerController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllTrainers()
        {
            try
            {
                var trainer = _manager.TrainerService.GetAllTrainer(false);
                return Ok(trainer);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetTrainer([FromRoute] int id)
        {
                var trainer = _manager.TrainerService.GetOneTrainer(id, false);

                return Ok(trainer);
        }

        [HttpPost]
        public IActionResult PostTrainer([FromBody] Trainer trainer)
        {
                if (trainer == null)
                    return BadRequest();

                _manager.TrainerService.CreateOneTrainer(trainer);
                return StatusCode(201, trainer);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneTrainer([FromRoute] int id,
            [FromBody] TrainerDtoForUpdate trainerDtoForUpdate)
        {
                if (trainerDtoForUpdate == null)
                    return BadRequest();

                _manager.TrainerService.UpdateOneTrainer(id, trainerDtoForUpdate, false);
                return NoContent();
        }

        [HttpDelete("{id:int}")]

        public IActionResult DeleteTrainer([FromRoute] int id)
        {
                _manager.TrainerService.DeleteOneTrainer(id, false);
                return NoContent();
            
        }

        [HttpPatch("{id:int}")]
        public IActionResult PartiallyUpdateTrainer([FromRoute(Name = "id")] int id,
            [FromBody] JsonPatchDocument<Trainer> trainer)
        {
                var entity = _manager.TrainerService.GetOneTrainer(id, true);

                if (entity is null)
                    return NotFound();


                trainer.ApplyTo(entity);
                _manager.TrainerService.UpdateOneTrainer(id, new TrainerDtoForUpdate(), true);
                return NoContent();

        }
    }
}
