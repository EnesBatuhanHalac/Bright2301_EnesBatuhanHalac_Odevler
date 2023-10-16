using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Data.Abstract
{
    public interface ICategoryRepository:IRepositoryBase<Category>
    {
        IQueryable<Category> GetAllCategory(bool TrackChanges);
        Category GetOneCategory(int id,bool TrackChanges);
        void CreateCategory(Category Category);
        void UpdateCategory(Category Category);
        void DeleteCategory(Category Category);
    }
}
