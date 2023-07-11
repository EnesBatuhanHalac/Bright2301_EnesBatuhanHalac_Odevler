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

        Task<List<Teacher>> GetAllTeachers();
        Task<Teacher> GetTeacherById(int id);
        Task<List<Teacher>> GetTeacherByIdList(int id);
        Task<List<Teacher>> GetActiveOrPassiveTeachers(bool IsActive);
        Task<List<Teacher>> GetTeachersInHome(bool IsActive);
        Task<List<Teacher>> GetDeletedOrNotDeletedTeachers(bool IsDeleted);
        Task<Teacher> GetTeacherByUrlAsync(string url);

        #endregion

    }
}
