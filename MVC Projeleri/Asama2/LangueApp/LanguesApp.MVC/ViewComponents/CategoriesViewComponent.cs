using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Components
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly ILangueService _langueManager;

        public CategoriesViewComponent(ILangueService langueManager)
        {
            _langueManager = langueManager;
        }

        public async Task<IViewComponentResult>InvokeAsync()
        {
            CategoryListViewModel langueListViewModel = new CategoryListViewModel();
            if (RouteData.Values["langueurl"]!= null)
            {
                langueListViewModel.SelectedCategoryUrl = RouteData.Values["langueurl"].ToString();
            }
            else
            {
                langueListViewModel.SelectedCategoryUrl = "";
            }

            List<Langue>langues=await _langueManager.GetAllAsync();
            List<LangueViewModel> langueViewModelList = langues.Select(t => new LangueViewModel
            {
                About=t.About,
                Name=t.Name,
                Url=t.Url
            }).ToList();

            langueListViewModel.LangueViewModelList = langueViewModelList;

            return View(langueListViewModel);
        }
    }
}
