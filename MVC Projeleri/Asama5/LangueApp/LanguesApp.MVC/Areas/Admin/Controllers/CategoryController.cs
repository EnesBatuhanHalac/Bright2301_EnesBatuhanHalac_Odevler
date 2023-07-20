using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ILangueService _langueManager;

        public CategoryController(ILangueService langueManager)
        {
            _langueManager = langueManager;
        }

        public async Task<IActionResult> Index()
        {

            List<Langue> categoryList = await _langueManager.GetLangueDeletedOrNot(false);
            List<CategoryViewModel> CategoriesList = categoryList.Select(t => new CategoryViewModel
            {
                Id = t.Id,
                Url = t.Url,
                Name = t.Name,
                About=t.About,
                CreatedDate=t.CreatedDate,
                IsActive = t.IsActive,
                IsDeleted = t.IsDeleted
            }).ToList();
            return View(CategoriesList);

        }
    }
}
