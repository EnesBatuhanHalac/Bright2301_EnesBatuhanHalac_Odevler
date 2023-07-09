using LanguesApp.Data.Abstract;
using LanguesApp.Data.Context;
using LanguesApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Concrete.EfCore.Repositories
{
    public class EFCoreTeacherRepository : EFCoreGenericRepository<Teacher>, ITeacherRepository
    {
        LanguesAppDbContext _context= new LanguesAppDbContext();

        public async Task<List<Teacher>> GetAllActiveOrPassiveTeacherAsync(bool IsDeleted)
        {
            var result = _context
            .Teachers
            .Where(t => t.IsDeleted == IsDeleted)
            .ToListAsync();


            return await result;
        }

        public async Task<List<Teacher>> GetAllTeacher()
        {
            var result = await _context.Teachers.ToListAsync();

            return result;
        }

        public async Task<List<Teacher>> GetHomePageTeacherAsync()
        {
            var result = await _context
                   .Teachers
                   .Where(t => !t.IsDeleted)
                   .Include(b => b.LangueTeachers)
                   .ThenInclude(b => b.Langue)
                   .ToListAsync();
            return result;
        }

        public async Task<Teacher> GetTeacherByIdAsync(int TeacherId)
        {
          var result=  _context.Teachers
           .Where(t=> t.Id==TeacherId)
           .FirstOrDefault();

            return result;
        }
    }
}
