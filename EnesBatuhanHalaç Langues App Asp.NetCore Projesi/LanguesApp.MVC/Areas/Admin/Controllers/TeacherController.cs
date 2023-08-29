using LanguesApp.Business.Abstract;
using LanguesApp.Core;
using LanguesApp.Entity.Concrete;
using LanguesApp.MVC.Areas.Admin.Models;
using LanguesApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LanguesApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _TeacherManager;

        public TeacherController(ITeacherService teacherManager)
        {
            _TeacherManager = teacherManager;
        }

        #region Teacher Listeleme
        public async Task<IActionResult> Index()
        {
            List<Teacher> teacherlist = await _TeacherManager.GetAllTeacherAsync(false);
            List<TeachersViewModel> TeacherList = teacherlist.Select(t => new TeachersViewModel
            {
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
                Price = t.Price,
                Url = t.Url,
                CreatedDate = t.CreatedDate,
                ModifiedDate = t.ModifiedDate
            }).ToList();
            TeacherListViewModel model = new TeacherListViewModel
            {
                TeacherViewModelList = TeacherList,
                SourceAction = "Index"
            };
            return View(model);
        }
        #endregion

        #region Yeni Teacher


        [HttpGet]
        public  IActionResult Create()
        {
            List<int> age = Jobs.GetAge(18, 80);
            TeacherAddViewModel teacher = new TeacherAddViewModel
            {
                Ages = age.Select(t => new SelectListItem
                {
                    Text = t.ToString(),
                    Value = t.ToString()
                }).ToList()
            };

            return View(teacher);

        }



        [HttpPost]
        public async Task<IActionResult> Create(TeacherAddViewModel teacherAddViewModel)
        {
            if (ModelState.IsValid)
            {
                string name = teacherAddViewModel.FirstName + " " + teacherAddViewModel.LastName;
                Teacher teacher = new Teacher
                {
                    About = teacherAddViewModel.About,
                    IsActive = teacherAddViewModel.IsActive,
                    Age = teacherAddViewModel.Age,
                    Country = teacherAddViewModel.Country,
                    Email = teacherAddViewModel.Email,
                    ImageUrl = teacherAddViewModel.ImageUrl,
                    Name = teacherAddViewModel.FirstName,
                    LastName = teacherAddViewModel.LastName,
                    Price = teacherAddViewModel.Price,
                    PhoneNumber = teacherAddViewModel.PhoneNumber,
                    Url = Jobs.GetUrl(name)
                };
                await _TeacherManager.CreateWithUrl(teacher);
                return RedirectToAction("Index");
            }
            //List<int> ages = Jobs.GetAge(18, 80);
            //teacherAddViewModel.Ages = ages.Select(t => new SelectListItem
            //{
            //    Text = t.ToString(),
            //    Value = t.ToString()
            //}).ToList();
            return View(teacherAddViewModel);
        }
        #endregion

        #region TeacherEdit

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Teacher teacher= await _TeacherManager.GetByIdAsync(id);
            if (teacher == null)  return NotFound();
            var ages = Jobs.GetAge(18, 80);
            TeacherEditViewModel teacherEditViewModel = new TeacherEditViewModel
            {
                About = teacher.About,
                Age = teacher.Age,
                Country = teacher.Country,
                Email = teacher.Email,
                Url=teacher.Url,
                Name = teacher.Name,
                LastName = teacher.LastName,
                ImageUrl = teacher.ImageUrl,
                IsActive = teacher.IsActive,
                PhoneNumber = teacher.PhoneNumber,
                Price = teacher.Price,
                Ages = ages.Select(t => new SelectListItem
                {
                    Text = t.ToString(),
                    Value = t.ToString(),
                    Selected = teacher.Age == t ? true : false

                }).ToList()

            };
            return View(teacherEditViewModel);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(TeacherEditViewModel teacherEditViewModel)
        {
            if(ModelState.IsValid)
            {
                Teacher teacher = await _TeacherManager.GetByIdAsync(teacherEditViewModel.Id);
                if (teacher == null) return NotFound();
                string photoUrl = "";
                string url=Jobs.GetUrl(teacherEditViewModel.Name + "-" + teacherEditViewModel.LastName);
                if(teacherEditViewModel.PhotoFile == null)
                {
                    photoUrl = teacher.ImageUrl;
                }
                else
                {
                    photoUrl = Jobs.UploadImage(teacherEditViewModel.PhotoFile, url, "teachers");
                }
                teacher.Name=teacherEditViewModel.Name;
                teacher.About = teacherEditViewModel.About;
                teacher.PhoneNumber = teacherEditViewModel.PhoneNumber;
                teacher.Age = teacherEditViewModel.Age;
                teacher.Price = teacherEditViewModel.Price;
                teacher.IsDeleted = teacherEditViewModel.IsDeleted;
                teacher.Country = teacherEditViewModel.Country;
                teacher.ModifiedDate = DateTime.Now;
                teacher.Email = teacherEditViewModel.Email;
                teacher.IsActive = teacherEditViewModel.IsActive;
                teacher.LastName = teacherEditViewModel.LastName;
                teacher.Url=teacherEditViewModel.Url;
                _TeacherManager.Update(teacher);
                return RedirectToAction("Index");
            }
            List<int> years = Jobs.GetAge(18,80 );
            teacherEditViewModel.Ages = years.Select(y => new SelectListItem
            {
                Text = y.ToString(),
                Value = y.ToString(),
                Selected = teacherEditViewModel.Age == y ? true : false
            }).ToList();
            return View(teacherEditViewModel);


        }

        public async Task<IActionResult> UpdateIsActive(int id)
        {
            Teacher teacher = await _TeacherManager.GetByIdAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            teacher.IsActive = !teacher.IsActive;
            teacher.ModifiedDate = DateTime.Now;
            _TeacherManager.Update(teacher);
            string isActive = teacher.IsActive ? "Aktif" : "Pasif";
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete Teacher

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Teacher teacher = await _TeacherManager.GetByIdAsync(id);
            if (teacher == null) { return NotFound();}
            TeacherDeleteViewModel teacherDeleteViewModel = new TeacherDeleteViewModel
            {
                About = teacher.About,
                Country = teacher.Country,
                CreatedDate = teacher.CreatedDate,
                first_Name = teacher.Name,
                last_Name = teacher.LastName,
                Id = teacher.Id,
                Url=teacher.Url,
                Age=teacher.Age,
                IsActive = teacher.IsActive,
                ModifiedDate = teacher.ModifiedDate,
                phoneNumber = teacher.PhoneNumber,
                Email=teacher.Email,
                Price = teacher.Price
            };
            return View(teacherDeleteViewModel);

        }


        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            Teacher teacher=await _TeacherManager.GetByIdAsync(id);
            if (teacher == null) {return NotFound();}
            _TeacherManager.Delete(teacher);
            return RedirectToAction("Index");
        }
        #endregion

        #region SoftDelete

        public async Task<IActionResult> SoftDelete(int id)
        {
            Teacher teacher = await _TeacherManager.GetByIdAsync(id);
            if (teacher == null) { return NotFound();}
            teacher.IsDeleted=true;
            teacher.ModifiedDate = DateTime.Now;
            _TeacherManager.Update(teacher);
            return RedirectToAction("Index");
        }

        #endregion

        #region Çöp Kutusu

        public async Task<IActionResult> DeletedIndex()
        {
            List<Teacher> teachers=await _TeacherManager.GetAllTeacherAsync(true);
            List<TeachersViewModel> teacherViewModelList = teachers.Select(c => new TeachersViewModel
            {
                Id = c.Id,
                Name = c.Name,
                CreatedDate = c.CreatedDate,
                ModifiedDate = c.ModifiedDate,
                About = c.About,
                IsActive = c.IsActive,
                Url = c.Url
            }).ToList();
            TeacherListViewModel model = new TeacherListViewModel
            {
                TeacherViewModelList = teacherViewModelList,
                SourceAction = "DeletedIndex"
            };
            return View("Index", model);
        }
        #endregion
    }
}
