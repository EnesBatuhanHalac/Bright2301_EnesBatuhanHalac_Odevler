using Microsoft.AspNetCore.Mvc;

namespace StoreApp.controller
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}