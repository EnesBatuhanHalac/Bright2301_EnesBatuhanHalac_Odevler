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

        public async Task<List<Teacher>> GetActiveOrPassiveTeachers(bool IsActive)
        {
            
            var result = _context.Teachers.Where(t => t.IsActive == IsActive).ToList();
        
                return result;
          
        }

        public async Task<List<Teacher>> GetAllTeachers()
        {
            var result= _context.Teachers.ToList();
            return result;
        }

        public async Task<List<Teacher>> GetDeletedOrNotDeletedTeachers(bool IsDeleted)
        {
            var result = _context.Teachers.Where(t => t.IsDeleted == IsDeleted)
                .ToList();
            return result;
        }

        public async Task<Teacher> GetTeacherById(int id)
        {
            var result= _context.Teachers.Where(t=> t.Id == id)
                .FirstOrDefault();
            return result;

        }

        public async Task<List<Teacher>> GetTeacherByIdList(int id)
        {
            var result = _context.Teachers.Where(t => t.Id == id)
                .ToList();
            return result;
        }

        public async Task<Teacher> GetTeacherByUrlAsync(string url)
        {
            var result = await _context
                .Teachers
                .Where(b => b.IsActive && !b.IsDeleted && b.Url == url)
                .Include(b => b.LangueTeachers)
                .ThenInclude(bc => bc.Langue)
                .FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<Teacher>> GetTeachersInHome(bool IsActive)
        {
            var result = _context.Teachers.Where(t=> t.IsActive==IsActive).ToList();
            return result;
        }
    }
}
