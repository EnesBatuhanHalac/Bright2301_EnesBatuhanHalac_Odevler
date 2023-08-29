using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Abstract
{
    public interface IGenericRepository<T> where T : class 
    {
        //update delete create get all

        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
    }
}
