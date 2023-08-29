using LanguesApp.Business.Abstract;
using LanguesApp.Data.Abstract;
using LanguesApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly ITeacherRepository _TeacherRepository;

        public TeacherManager(ITeacherRepository teacherRepository)
        {
            _TeacherRepository = teacherRepository;
        }

        public async Task CreateAsync(Teacher teacher)
        {
            await _TeacherRepository.CreateAsync(teacher);
        }

        public async Task CreateWithUrl(Teacher teacher)
        {
            await _TeacherRepository.CreateWithUrl(teacher);
        }

        public void Delete(Teacher teacher)
        {
            _TeacherRepository.Delete(teacher);
        }

        public Task<List<Teacher>> GetAllAsync()
        {
           return _TeacherRepository.GetAllAsync();
        }

        public Task<List<Teacher>> GetAllTeacherAsync(bool IsDeleted,bool? IsActive=null)
        {
          return _TeacherRepository.GetAllTeacherAsync(IsDeleted,IsActive);
        }

        public Task<Teacher> GetByIdAsync(int id)
        {
            return _TeacherRepository.GetByIdAsync(id);
        }

        public Task<Teacher> GetTeacherById(int id)
        {
            return _TeacherRepository.GetTeacherByIdAsync(id);
        }

        public Task<Teacher> GetTeacherByUrlAsync(string url)
        {
            return _TeacherRepository.GetTeacherByUrlAsync(url);
        }

        public void Update(Teacher teacher)
        {
            _TeacherRepository.Update(teacher);
        }
    }
}
