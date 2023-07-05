using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Abstract
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> GetByIdAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);





    }
}
