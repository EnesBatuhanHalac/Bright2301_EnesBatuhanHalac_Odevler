using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Entities;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Controllers
{
    public class TeacherShop : Controller
    {
        private readonly ITeacherService _teacherManager;

        public TeacherShop(ITeacherService teacherManager)
        {
            _teacherManager = teacherManager;
        }

        public async Task<IActionResult> TeacherList(string langueurl=null, string teacherurl=null)
        {
            List<Teacher> teacherList = await _teacherManager.GetAllActiveTeachersAsync(langueurl, teacherurl);
            List<TeacherViewModel> teacherViewModelList=teacherList.Select(b=> new TeacherViewModel
            {
                About=b.About,
                Age=b.Age,
                Country=b.Country,
                Email=b.Email,
                FullName=b.FullName,
                Id=b.Id,
                ImageUrl = b.ImageUrl,
                Phone = b.Phone
            }).ToList();
            return View(teacherViewModelList);
        }
    }
}
