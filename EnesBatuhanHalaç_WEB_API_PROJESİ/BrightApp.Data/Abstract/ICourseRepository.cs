using BrightApp.Data.Concrete.EFCore.Repositories;
using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Abstract
{
    public interface ICourseRepository:IRepositoryBase<Course>
    {
        IQueryable<Course> GetAllCourse(bool trackChanges);
        Course GetOneCourse(int id,bool trackChanges);
        void CreateOneCourse(Course Course);
        void UpdateOneCourse(Course Course);
        void DeleteOneCourse(Course Course);
    }
}
