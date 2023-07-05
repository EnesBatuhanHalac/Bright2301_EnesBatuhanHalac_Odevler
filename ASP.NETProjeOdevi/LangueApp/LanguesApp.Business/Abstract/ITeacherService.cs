using LanguesApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Business.Abstract
{
    public interface ITeacherService
    {
        #region Generic
        Task<Teacher> GetByIdAsync(int? id);
        Task<List<Teacher>> GetAllAsync();
        Task CreateAsync(Teacher entity);
        void Update(Teacher entity);
        void Delete(Teacher entity);
        #endregion

        #region Abstract
        Task<List<Teacher>> GetAllTeachersAsync(Teacher Teacher);

        #endregion
    }
}
