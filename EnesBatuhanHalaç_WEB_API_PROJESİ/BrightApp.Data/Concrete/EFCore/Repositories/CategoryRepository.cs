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
    internal class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(BrightAcademieContext context) : base(context)
        {
        }

        public void CreateCategory(Category Category) => Create(Category);

        public void DeleteCategory(Category Category)=> Delete(Category);

        public IQueryable<Category> GetAllCategory(bool TrackChanges) => FindAll(TrackChanges);

        public Category GetOneCategory(int id, bool TrackChanges) =>
            FindByCondition(c => c.Id.Equals(id), TrackChanges)
            .SingleOrDefault();

        public void UpdateCategory(Category Category)=>Update(Category);
    }
}
