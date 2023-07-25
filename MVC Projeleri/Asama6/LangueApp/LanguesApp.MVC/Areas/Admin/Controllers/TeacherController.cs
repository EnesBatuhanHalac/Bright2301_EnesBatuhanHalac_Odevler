using LanguesApp.Business.Abstract;
using LanguesApp.Core;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Areas.Admin.Models;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LanguesApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherManager;
        private readonly ILangueService _langueManager;

        public TeacherController(ITeacherService teacherManager, ILangueService langueManager)
        {
            _teacherManager = teacherManager;
            _langueManager = langueManager;
        }
        #region TeacherList
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Teacher> teachers = await _teacherManager.GetAllTeachersAsync(false);
            List<TeachersViewModel> teacherList = teachers.Select(t => new TeachersViewModel
            {
                Id = t.Id,
                About = t.About,
                Age = t.Age,
                Country = t.Country,
                CreatedDate = t.CreatedDate,
                Email = t.Email,
                FullName = t.FullName,
                IsActive = t.IsActive,
                IsDeleted = t.IsDeleted,
                ModifiedDate = t.ModifiedDate,
                Phone = t.Phone,
                Price = t.Price,
                ImageUrl = t.ImageUrl,
                Url = t.Url
            }).ToList();
            TeacherListViewModel model = new TeacherListViewModel
            {
                TeacherViewModelList = teacherList,
                SourceAction = "Index"
            };
            return View(model);
        }
        #endregion

        [HttpGet]
        public IActionResult Create()
        {
            List<int> ages = Jobs.GetAges(18, 82);
            TeacherAddViewModel teacherAddViewModel = new TeacherAddViewModel
            {
                Ages = ages.Select(t => new SelectListItem
                {
                    Text = t.ToString(),
                    Value = t.ToString()
                }).ToList()
            };
            return View(teacherAddViewModel);
        }

       [HttpPost]
       public async Task<IActionResult>Create(TeacherAddViewModel teacherAddViewModel)
       {
         if(ModelState.IsValid)
            {
                Teacher teacher=new Teacher
                {
                    FullName=teacherAddViewModel.FullName,
                    About=teacherAddViewModel.About,
                    Age=teacherAddViewModel.Age,
                    Country=teacherAddViewModel.Country,
                    Email=teacherAddViewModel.Email,
                    ImageUrl=teacherAddViewModel.ImageUrl,
                    Url=teacherAddViewModel.Url,
                    IsActive=teacherAddViewModel.IsActive,
                    Phone=teacherAddViewModel.Phone,
                    Price=teacherAddViewModel.Price,
                    
                }
            }
       }
    }
}
