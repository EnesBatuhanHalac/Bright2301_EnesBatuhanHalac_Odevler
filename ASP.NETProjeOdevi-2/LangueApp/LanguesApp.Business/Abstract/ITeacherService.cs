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
        Task CreateAsync(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(Teacher teacher);
        Task<List<Teacher>> GetAllAsync();
        Task<Teacher> GetByIdAsync(int id);

        #endregion

        #region Teacher

        Task<List<Teacher>> GetAllActiveOrPassiveTeacherAsync(bool IsDeleted);
        Task<Teacher> GetTeacherByIdAsync(int TeacherId);
        Task<List<Teacher>> GetAllTeacher();
        Task<List<Teacher>> GetHomePageTeacherAsync();
        #endregion

    }
}
