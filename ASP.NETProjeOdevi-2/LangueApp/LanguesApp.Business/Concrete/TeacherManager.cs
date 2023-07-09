using LanguesApp.Business.Abstract;
using LanguesApp.Data.Abstract;
using LanguesApp.Data.Concrete.EfCore.Repositories;
using LanguesApp.Data.Context;
using LanguesApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Business.Concrete
{
    public class TeacherManager:ITeacherService
    {
        private readonly ITeacherRepository _repository;

        public TeacherManager(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(Teacher teacher)
        {
            _repository.CreateAsync(teacher);
           
        }

        public void Delete(Teacher teacher)
        {
            _repository.Delete(teacher);
        }

        public async Task<List<Teacher>> GetAllActiveOrPassiveTeacherAsync(bool IsDeleted)
        {
          return await _repository.GetAllActiveOrPassiveTeacherAsync(IsDeleted);
        }

        public async Task<List<Teacher>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<List<Teacher>> GetAllTeacher()
        {
            return await _repository.GetAllTeacher();
        }

        public async Task<Teacher> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<Teacher>> GetHomePageTeacherAsync()
        {
            var result = await _repository.GetHomePageTeacherAsync();
            return result;
        }

        public async Task<Teacher> GetTeacherByIdAsync(int TeacherId)
        {
            return await _repository.GetTeacherByIdAsync(TeacherId);
        }

        public void Update(Teacher teacher)
        {
            _repository.Update(teacher);
        }
    }
}
