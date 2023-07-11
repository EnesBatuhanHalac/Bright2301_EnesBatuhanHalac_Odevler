﻿using LanguesApp.Business.Abstract;
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

        public async Task<List<Teacher>> GetActiveOrPassiveTeachers(bool IsActive)
        {
           return await _repository.GetActiveOrPassiveTeachers(IsActive);
        }

        public Task<List<Teacher>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<List<Teacher>> GetAllTeachers()
        {
            return _repository.GetAllTeachers();
        }

        public Task<Teacher> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public async Task<List<Teacher>> GetDeletedOrNotDeletedTeachers(bool IsDeleted)
        {
            return await _repository.GetDeletedOrNotDeletedTeachers(IsDeleted);
        }

        public async Task<Teacher> GetTeacherById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public Task<List<Teacher>> GetTeachersInHome(bool IsActive)
        {
            return _repository.GetTeachersInHome(IsActive);
        }

        public void Update(Teacher teacher)
        {
            _repository.Update(teacher);
        }
    }
}