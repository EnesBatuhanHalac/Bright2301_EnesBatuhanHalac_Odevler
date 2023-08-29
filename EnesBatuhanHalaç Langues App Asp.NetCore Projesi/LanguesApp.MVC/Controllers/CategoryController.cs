using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Concrete;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILangueService _langueManager;

        public CategoryController(ILangueService langueManager)
        {
            _langueManager = langueManager;
        }

        public async Task<IActionResult> Index()
        {

            List<Langue> languelist = await _langueManager.GetAllLangues(false, true);
            List<CategoryViewModel> categoryList = languelist.Select(t => new CategoryViewModel
            {
                Name = t.Name,
                About = t.About
            }).ToList();
            return View(categoryList);

        }
    }
}
