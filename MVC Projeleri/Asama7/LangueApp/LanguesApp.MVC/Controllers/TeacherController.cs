using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public async Task<IActionResult> Index()
        {
            List<Teacher> teacherList = await _teacherService.GetTeachersInHome(true);
            List<TeacherCategoryViewModel> teacherViewModelList = teacherList.Select(t => new TeacherCategoryViewModel
            {
                Id = t.Id,
                FullName = t.FullName,
                Price = t.Price,
                Url = t.Url,
                ImageUrl = t.ImageUrl,
                About = t.About,
                Age = t.Age,
                Country = t.Country,
                Email=t.Email,
                Phone=t.Phone
            }).ToList();

            return View(teacherViewModelList);
        }


        public async Task<IActionResult> TeacherDetails(string url)
        {
            Teacher teacher=await _teacherService.GetTeacherByUrlAsync(url);
            TeacherCategoryViewModel teacherDetailsViewModel = new TeacherCategoryViewModel
            {
                Id = teacher.Id,
                FullName = teacher.FullName,
                About = teacher.About,
                Age = teacher.Age,
                Country = teacher.Country,
                Url = teacher.Url,
                ImageUrl = teacher.ImageUrl,
                Price = teacher.Price,
                Email=teacher.Email,
                Phone=teacher.Phone
            };

            return View(teacherDetailsViewModel);
        }

      


        

       
    }
}
