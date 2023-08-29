using LanguesApp.Data.Abstract;
using LanguesApp.Data.Concrete.EfCore.Context;
using LanguesApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Concrete.EfCore.Repositories
{
    public class EFCoreTeacherRepository : EFCoreGenericRepository<Teacher>, ITeacherRepository
    {
        LanguesAppDbContext _LanguesAppDbContext = new();

        public async Task CreateWithUrl(Teacher teacher)
        {
           await _LanguesAppDbContext.Teachers.AddAsync(teacher);
            await _LanguesAppDbContext.SaveChangesAsync();
            teacher.Url=teacher.Url + "-" + teacher.Id;
            await _LanguesAppDbContext.SaveChangesAsync();
        }

        public async Task<List<Teacher>> GetAllTeacherAsync(bool IsDeleted,bool? IsActive=null)
        {
           var result = _LanguesAppDbContext.Teachers.Where(t=> t.IsDeleted == IsDeleted).AsQueryable();
            if(IsActive != null)
            {
                result = result.Where(result => result.IsActive == IsActive).AsQueryable();
            }
            return await result.ToListAsync();

        }

        public  async Task<Teacher> GetTeacherByIdAsync(int id)
        {
          var result=  _LanguesAppDbContext.Teachers.Where(t=> t.Id == id).FirstOrDefault();
            return result;
        }

        public async Task<Teacher> GetTeacherByUrlAsync(string url)
        {
            var result= _LanguesAppDbContext.Teachers.Where(t=> t.Url==url).FirstOrDefault();
            return result;
        }
    }
}
