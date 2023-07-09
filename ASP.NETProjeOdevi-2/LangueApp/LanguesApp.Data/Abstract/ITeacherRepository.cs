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
        //Task<List<Teacher>> GetHomePageTeacherAsync();
        Task<List<Teacher>> GetAllActiveOrPassiveTeacherAsync(bool IsDeleted);
       Task<Teacher> GetTeacherByIdAsync(int TeacherId);
        Task<List<Teacher>> GetAllTeacher();
        Task<List<Teacher>> GetHomePageTeacherAsync();
   
        //Task<List<Teacher>> GetAllTeacherWithLangue(bool isDeleted);


    }
}
