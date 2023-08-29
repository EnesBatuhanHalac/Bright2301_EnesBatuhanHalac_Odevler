using LanguesApp.Data.Abstract;
using LanguesApp.Data.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Concrete.EfCore.Repositories
{
    public class EFCoreGenericRepository<T> : IGenericRepository<T> where T :class
    {

        LanguesAppDbContext _LanguesAppDbContext = new LanguesAppDbContext();
        public async Task CreateAsync(T entity)
        {
            await _LanguesAppDbContext.Set<T>().AddAsync(entity);
            await _LanguesAppDbContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _LanguesAppDbContext.Set<T>().Remove(entity);
            _LanguesAppDbContext.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await _LanguesAppDbContext.Set<T>().ToListAsync(); 
        }

        public async Task<T> GetByIdAsync(int id)
        {
          return await _LanguesAppDbContext.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            _LanguesAppDbContext.Set<T>().Update(entity);
            _LanguesAppDbContext.SaveChanges();
        }
    }
}
