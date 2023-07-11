using LanguesApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Abstract
{
    public interface ITeacherRepository:IGenericRepository<Teacher>
    {

        Task<List<Teacher>> GetAllTeachers();
         Task<Teacher> GetTeacherById(int id);
        Task<List<Teacher>> GetActiveOrPassiveTeachers(bool IsActive);
        Task<List<Teacher>> GetTeachersInHome(bool IsActive);
        Task<List<Teacher>> GetDeletedOrNotDeletedTeachers(bool IsDeleted);


    }
}
