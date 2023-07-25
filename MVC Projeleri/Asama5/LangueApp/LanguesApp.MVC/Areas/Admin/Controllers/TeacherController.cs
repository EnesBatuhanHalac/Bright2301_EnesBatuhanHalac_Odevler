using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Areas.Admin.Models;
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
    }
}
