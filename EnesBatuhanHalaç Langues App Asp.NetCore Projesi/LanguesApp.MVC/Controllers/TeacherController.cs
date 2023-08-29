using LanguesApp.Business.Abstract;
using LanguesApp.Entity.Concrete;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguesApp.MVC.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            List<Teacher> teacherlist = await _service.GetAllTeacherAsync(false,true);
            List<TeacherViewModel> TeacherViewModel = teacherlist.Select(t => new TeacherViewModel
            {
                Price = t.Price,
                About = t.About,
                Age = t.Age,
                Country = t.Country,
                Email = t.Email,
                Id = t.Id,
                ImageUrl = t.ImageUrl,
                IsActive = t.IsActive,
                LastName = t.LastName,
                Name = t.Name,
                PhoneNumber = t.PhoneNumber,
                Url = t.Url
            }).ToList();
            return View(TeacherViewModel);
        }

        public async Task<IActionResult> TeacherDetails(string url)
        {
            Teacher TeacherDetail= await _service.GetTeacherByUrlAsync(url);
            TeacherViewModel teacher = new TeacherViewModel
            {
                Id = TeacherDetail.Id,
                About = TeacherDetail.About,
                Age = TeacherDetail.Age,
                Country = TeacherDetail.Country,
                Price = TeacherDetail.Price,
                Email = TeacherDetail.Email,
                ImageUrl = TeacherDetail.ImageUrl,
                IsActive = TeacherDetail.IsActive,
                LastName = TeacherDetail.LastName,
                Name = TeacherDetail.Name,
                PhoneNumber = TeacherDetail.PhoneNumber,
                Url = TeacherDetail.Url
            };
            return View(teacher);
        }
        
      
    }
}
