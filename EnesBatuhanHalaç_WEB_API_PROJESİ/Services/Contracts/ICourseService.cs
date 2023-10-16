using BrightApp.Entity.Concrete;
using BrightApp.Entity.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourse(bool trackchanges);
        Course GetOneCourse(int id,bool trackchanges);
        Course CreateOneCourse(Course course);
        void UpdateOneCourse(int id,CourseDtoForUpdate courseDto,bool trackchanges);
        void DeleteOneCourse(int id,bool trackchanges);
    }
}
