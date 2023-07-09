using LanguesApp.Business.Abstract;
using LanguesApp.Data.Abstract;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanguesApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITeacherService _teacherService;

        public HomeController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public async Task<IActionResult> Index()
        {
            List<Teacher> teacherList = await _teacherService.GetHomePageTeacherAsync();
            List<TeacherViewModel> teacherViewModelList = teacherList.Select(t => new TeacherViewModel
            {
                Id = t.Id,
                FullName=t.FullName,
                Price = t.Price,
                Url = t.Url,
                ImageUrl = t.ImageUrl,
                About=t.About,
                Age=t.Age,
                Country=t.Country
            }).ToList();

            return View(teacherViewModelList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}