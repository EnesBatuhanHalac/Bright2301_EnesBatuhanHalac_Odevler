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
    public class EfCoreGenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly LanguesAppDbContext _context;

        public EfCoreGenericRepository(LanguesAppDbContext context)
        {
            _context = context;
        }

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

        public async Task<List<T>> GetAllAsync()
        {
           return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int? id)
        {
           return await _context.Set<T>().FindAsync(id);

        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
