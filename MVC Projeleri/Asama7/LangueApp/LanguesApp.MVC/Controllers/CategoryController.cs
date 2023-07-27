using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILangueService _langueService;

        public CategoryController(ILangueService langueService)
        {
            _langueService = langueService;
        }

        public async Task<IActionResult> Index()
        {
            List<Langue> langueList= await _langueService.GetAllLanguesAsync();
            List<LangueViewModel> languesList = langueList.Select(l => new LangueViewModel
            {
                Url = l.Url,
                About = l.About,
                Name = l.Name
            }).ToList();
           
            return View(languesList);
        }
    }
}
