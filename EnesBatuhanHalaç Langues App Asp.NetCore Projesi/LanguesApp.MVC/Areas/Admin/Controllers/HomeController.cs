﻿using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
