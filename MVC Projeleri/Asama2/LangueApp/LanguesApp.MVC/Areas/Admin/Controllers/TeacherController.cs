using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Areas.Admin.Controllers
{
    public class TeacherController : Controller
    {
        [Area("Admin")]
        public IActionResult Index([FromRoute(Name ="id")]int id)
        {
            return View();
        }
    }
}
