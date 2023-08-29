using LanguesApp.Data.Concrete.EfCore.Repositories;
using LanguesApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Abstract
{
    public interface ITeacherRepository:IGenericRepository<Teacher>
    {
        Task<List<Teacher>> GetAllTeacherAsync(bool IsDeleted,bool? IsActive=null);
        Task<Teacher> GetTeacherByIdAsync(int id);
        Task<Teacher> GetTeacherByUrlAsync(string url);
        Task CreateWithUrl(Teacher teacher);

    }
}
