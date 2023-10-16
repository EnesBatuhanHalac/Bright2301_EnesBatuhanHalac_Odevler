using BrightApp.Entity.Concrete;
using BrightApp.Entity.DataTransferObjects;
using BrightApp.Entity.Exceptions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace BrightAcademieWebApp.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var category = _manager.CategoryService.GetAllCategory(false);
            return Ok(category);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetCategory([FromRoute] int id)
        {
          var category = _manager.CategoryService.GetOneCategoryById(id, false);

           if(category is null)
           
                throw new CategoryNotFoundException(id);
                return Ok(category);
        }

        [HttpPost]
        public IActionResult PostCategory([FromBody] Category category)
        {
            
            
                if (category == null)
                    return BadRequest();

                _manager.CategoryService.CreateOneCategory(category);
                return StatusCode(201, category);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBook([FromRoute] int id,
            [FromBody] CategoryDtoForUpdate Category)
        {
            
            
                if (Category == null)
                    return BadRequest();

                _manager.CategoryService.UpdateOneCategory(id, Category, false);
                return NoContent();

        }

        [HttpDelete("{id:int}")]

        public IActionResult DeleteOneBook([FromRoute] int id)
        {
            
                _manager.CategoryService.DeleteOneCategory(id, false);
                return NoContent();
        }

        [HttpPatch("{id:int}")]
        public IActionResult PartiallyUpdateOneCategory([FromRoute(Name = "id")] int id,
            [FromBody] JsonPatchDocument<Category> category)
        {
                var entity = _manager.CategoryService.GetOneCategoryById(id, true);
                category.ApplyTo(entity);
                _manager.CategoryService.UpdateOneCategory(id, new CategoryDtoForUpdate(), true);

                return NoContent();

        }


    }
}
