using LanguesApp.Entity.Concrete;
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

        Task CreateAsync(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(Teacher teacher);
        Task<List<Teacher>> GetAllAsync();
        Task<Teacher> GetByIdAsync(int id);
        #endregion


        #region Teacher

        Task<List<Teacher>> GetAllTeacherAsync(bool IsDeleted,bool? IsActive=null);
        Task<Teacher> GetTeacherById(int id);
        Task<Teacher> GetTeacherByUrlAsync(string url);
        Task CreateWithUrl(Teacher teacher);

        #endregion
    }
}
