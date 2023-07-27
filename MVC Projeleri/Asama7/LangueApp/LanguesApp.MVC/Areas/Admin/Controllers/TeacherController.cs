using LanguesApp.Business.Abstract;
using LanguesApp.Core;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetCoreHero.ToastNotification.Notyf;

namespace LanguesApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherManager;
        private readonly NotyfService _notyf;
        

        public TeacherController(ITeacherService teacherManager)
        {
            _teacherManager = teacherManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Teacher> teachers =await _teacherManager.GetAllTeachersAsync(false);
            List<TeachersViewModel> teacherList = teachers.Select(t => new TeachersViewModel
            {
                Id = t.Id,
                About=t.About,
                Age=t.Age,
                Country=t.Country,
                CreatedDate = t.CreatedDate,
                Email = t.Email,
                FullName = t.FullName,
                IsActive = t.IsActive,
                IsDeleted = t.IsDeleted,
                ModifiedDate=t.ModifiedDate,
                Phone = t.Phone,
                Price=t.Price,
                ImageUrl=t.ImageUrl,
                Url= t.Url
            }).ToList();
            return View(teacherList);
        }
        #region  NewTeacher

        [HttpGet]
        public IActionResult Create()
        {
            List<int> ages = Jobs.GetAge(18, 85);
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
        public async Task<IActionResult> Create(TeacherAddViewModel teacherAddViewModel)
        {
          if (ModelState.IsValid)
            {
                string name = teacherAddViewModel.FullName;
                Teacher teacher = new Teacher
                {
                    FullName = teacherAddViewModel.FullName,
                    About = teacherAddViewModel.About,
                    Country = teacherAddViewModel.Country,
                    IsActive = teacherAddViewModel.IsActive,
                    Email = teacherAddViewModel.Email,
                    Phone = teacherAddViewModel.Phone,
                    Age = teacherAddViewModel.Age,
                    Url = Jobs.GetUrl(name),
                    ImageUrl = "default-profile.jpg"
                };
                await _teacherManager.CreateWithUrl(teacher);
                _notyf.Success("Ögretmen Kaydı Başari ile tamamlanmistir");
                return RedirectToAction("Index");
            }
            List<int> age = Jobs.GetAge(18, 85);
            teacherAddViewModel.Ages = age.Select(y => new SelectListItem
            {
                Text = y.ToString(),
                Value = y.ToString()
            }).ToList();
            return View(teacherAddViewModel);
            
        }


    }

    #endregion

}
