using BrightApp.Data.Abstract;
using BrightApp.Data.Concrete.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Concrete.EFCore.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly BrightAcademieContext _context;

        public RepositoryBase(BrightAcademieContext context)
        {
            _context = context;
        }

        public void Create(T entity)=> _context.Set<T>().Add(entity);

        public void Delete(T entity)=> _context.Set<T>().Remove(entity);

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
            bool trackChanges) => !trackChanges ? _context.Set<T>().Where(expression).AsNoTracking()
            : _context.Set<T>().Where(expression);

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? _context.Set<T>().AsNoTracking()
            : _context.Set<T>();

        public void Update(T entity)=> _context.Set<T>().Update(entity);
    }
}
