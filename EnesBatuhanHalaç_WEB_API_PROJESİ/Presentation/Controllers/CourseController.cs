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
    [Route("api/Course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CourseController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllCourses()
        {
                var courses = _manager.CourseService.GetAllCourse(false);
                return Ok(courses);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCourse([FromRoute] int id)
        {
                var course = _manager.CourseService.GetOneCourse(id, false);
            if(course is null)
              throw new CourseNotFoundException(id);
                return Ok(course);
        }

        [HttpPost]
        public IActionResult CreateCourse([FromBody] Course course)
        {
                if (course == null)
                    return BadRequest();

                _manager.CourseService.CreateOneCourse(course);
                return StatusCode(201, course);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneCourse([FromRoute] int id,
            [FromBody] CourseDtoForUpdate courseDto)
        {
                 if (courseDto == null)
                    return BadRequest();

                _manager.CourseService.UpdateOneCourse(id, courseDto, false);
                return NoContent();

        }

        [HttpDelete("{id:int}")]

        public IActionResult DeleteOneCourse([FromRoute] int id)
        {
          _manager.CourseService.DeleteOneCourse(id, false);
            return NoContent();
            
        }

        [HttpPatch("{id:int}")]
        public IActionResult PartiallyUpdateOneCourse([FromRoute(Name = "id")] int id,
            [FromBody] JsonPatchDocument<Course> course)
        {
                var entity = _manager.CourseService.GetOneCourse(id, true);

                if (entity is null)
                    return NotFound();

                course.ApplyTo(entity);
                _manager.CourseService.UpdateOneCourse(id, new CourseDtoForUpdate(), true);
                return NoContent();

        }
    }
}
