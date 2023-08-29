using LanguesApp.Business.Abstract;
using LanguesApp.Core;
using LanguesApp.Data.Abstract;
using LanguesApp.Entity.Concrete;
using LanguesApp.MVC.Areas.Admin.Models;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ILangueService _langueService;

        public CategoryController(ILangueService langueService)
        {
            _langueService = langueService;
        }

        #region CategoryList
        public async Task<IActionResult> Index()
        {
            List<Langue> languelist = await _langueService.GetAllLangues(false);
            List<LangueViewModel> languesList = languelist.Select(t => new LangueViewModel
            {
                Name = t.Name,
                About = t.About,
                Id = t.Id,
                Url = t.Url,
                CreatedDate = t.CreatedDate,
                IsActive = t.IsActive,
                ModifiedDate = t.ModifiedDate
            }).ToList();

            CategoryListViewModel model = new CategoryListViewModel
            {
                CategoryViewModelList = languesList,
                SourceAction = "Index"
            };
            return View(model);
        }
        #endregion
        #region CategoryCreate

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddViewModel categoryAddViewModel)
        {
            if(ModelState.IsValid)
            {
                Langue langue = new Langue
                {
                    Name = categoryAddViewModel.Name,
                    About = categoryAddViewModel.About,
                    IsActive = categoryAddViewModel.IsActive,
                    Url = Jobs.GetUrl(categoryAddViewModel.Name)
                };
                await _langueService.CreateAsync(langue);
                return RedirectToAction("Index");
            }

            return View(categoryAddViewModel);
        }
        #endregion
        #region Kategory Güncelleme

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Langue langue = await _langueService.GetByIdAsync(id);
            if (langue == null)
            {
                return NotFound();
            }
            CategoryEditViewModel categoryEditViewModel = new CategoryEditViewModel //buraya tekrar bak
            {
                Name = langue.Name,
                About = langue.About,
                Id = langue.Id,
                IsActive = langue.IsActive,
                IsDeleted=langue.IsDeleted,
                Url=langue.Url
            };
            return View(categoryEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryEditViewModel categoryEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Langue category = await _langueService.GetByIdAsync(categoryEditViewModel.Id);
                category.Name = categoryEditViewModel.Name;
                category.About = categoryEditViewModel.About;
                category.IsActive = categoryEditViewModel.IsActive;
                category.IsDeleted = categoryEditViewModel.IsDeleted;
                categoryEditViewModel.Url=Jobs.GetUrl(categoryEditViewModel.Url);
                category.Url = categoryEditViewModel.Url;
                category.ModifiedDate = DateTime.Now;
                _langueService.Update(category);
                //notfy yaz
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            Langue langue = await _langueService.GetByIdAsync(id);
            if(langue == null)
            {
                return NotFound();
            }
            langue.IsActive = !langue.IsActive;
            langue.ModifiedDate = DateTime.Now;
            _langueService.Update(langue);
            return RedirectToAction("Index");
        }
        #endregion
        #region Kalici silme Categoryler

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Langue langue = await _langueService.GetByIdAsync(id);
            if (langue == null) return NotFound();
            CategoryDeleteViewModel categoryDeleteViewModel = new CategoryDeleteViewModel
            {
                Name = langue.Name,
                Url = langue.Url,
                IsDeleted = langue.IsDeleted,
                ModifiedDate = langue.ModifiedDate,
                CreatedDate = langue.CreatedDate,
                Abouth = langue.About,
                IsActive = langue.IsActive,
                Id = langue.Id
            };

            return View(categoryDeleteViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            Langue langue = await _langueService.GetByIdAsync(id);
            if (langue == null) return NotFound();
            _langueService.Delete(langue);
            return RedirectToAction("Index");
        }


        #endregion
        #region Soft Silme Butonu
        public async Task<IActionResult> SoftDelete(int id)
        {
            Langue langue = await _langueService.GetByIdAsync(id);
            if (langue == null) return NotFound();
            langue.IsDeleted = true;
            langue.ModifiedDate=DateTime.Now;
            _langueService.Update(langue);
            return RedirectToAction("Index");
        }
        #endregion
        #region Çöp Kutusu
        [HttpGet]
        public async Task<IActionResult> DeletedIndex()
        {
            List<Langue> langues = await _langueService.GetAllLangues(true);
            List<LangueViewModel> langueViewModelList = langues.Select(t => new LangueViewModel
            {
                Id = t.Id,
                Name = t.Name,
                About = t.About,
                CreatedDate = t.CreatedDate,
                IsActive = t.IsActive,
                ModifiedDate = t.ModifiedDate,
                Url = t.Url

            }).ToList();
            CategoryListViewModel model = new CategoryListViewModel
            {
                CategoryViewModelList = langueViewModelList,
                SourceAction = "DeletedIndex"
            };
            return View("Index", model);


        }
        #endregion

    }
}
