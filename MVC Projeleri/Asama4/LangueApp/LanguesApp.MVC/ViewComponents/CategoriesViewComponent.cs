using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly ILangueService _langueManager;

        public CategoriesViewComponent(ILangueService langueManager)
        {
            _langueManager = langueManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            List<Langue> langueList= await _langueManager.GetAllLanguesAsync();
            List<LangueViewModel> CategoryList = langueList.Select(t => new LangueViewModel
            {
                About=t.About,
                Name=t.Name,
                Url=t.Url
            }).ToList();
            return View(CategoryList);
        }
    }
}
