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

        public IActionResult Index()
        {
         
            return View();
        }

        


       

        
    }
}