using LanguesApp.Data.Abstract;
using LanguesApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Concrete.EfCore.Repositories
{
    public class EFCoreGenericRepository<T> : IGenericRepository<T> where T : class
    {
        LanguesAppDbContext _context = new LanguesAppDbContext();

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public Task<List<T>> GetAllAsync()
        {
            return _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {

            _context.Set<T>().Update(entity);
            _context.SaveChanges();

        }
    }
}
