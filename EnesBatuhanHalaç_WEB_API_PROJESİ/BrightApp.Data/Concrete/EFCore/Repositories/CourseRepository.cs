using BrightApp.Data.Abstract;
using BrightApp.Data.Concrete.EFCore.Context;
using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Concrete.EFCore.Repositories
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(BrightAcademieContext context) : base(context)
        {

        }

        public void CreateOneCourse(Course Course) => Create(Course);

        public void DeleteOneCourse(Course Course)=> Delete(Course);

        public IQueryable<Course> GetAllCourse(bool trackChanges)=> FindAll(trackChanges);

        public Course GetOneCourse(int id, bool trackChanges) =>
            FindByCondition(b => b.Id.Equals(id), trackChanges)
            .SingleOrDefault();

        public void UpdateOneCourse(Course Course)=>Update(Course);
    }
}
