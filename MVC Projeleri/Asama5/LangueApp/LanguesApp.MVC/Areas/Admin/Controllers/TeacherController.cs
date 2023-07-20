using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherManager;

        public TeacherController(ITeacherService teacherManager)
        {
            _teacherManager = teacherManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Teacher> teacherList = await _teacherManager.GetAllTeachersAsync(false);
            List<TeacherViewModel> teacherViewModelList = teacherList.Select(t => new TeacherViewModel
            {
             Id=t.Id,
             Phone=t.Phone,
             Email=t.Email,
             Url=t.Url,
             About = t.About,
             Age=t.Age,
             Country = t.Country,
             FullName=t.FullName,
             ImageUrl=t.ImageUrl,
             Price = t.Price,
             IsDeleted=t.IsDeleted,
             IsActive=t.IsActive
            }).ToList();
            return View();
        }
    }
}
