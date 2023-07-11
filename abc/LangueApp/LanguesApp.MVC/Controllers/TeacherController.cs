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
            List<TeacherViewModel> teacherViewModelList = teacherList.Select(t => new TeacherViewModel
            {
                Id = t.Id,
                FullName = t.FullName,
                Price = t.Price,
                Url = t.Url,
                ImageUrl = t.ImageUrl,
                About = t.About,
                Age = t.Age,
                Country = t.Country
            }).ToList();

            return View(teacherViewModelList);
        }
    }
}
