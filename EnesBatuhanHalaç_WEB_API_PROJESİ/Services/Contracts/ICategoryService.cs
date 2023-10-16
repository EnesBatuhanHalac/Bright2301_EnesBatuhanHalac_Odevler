using BrightApp.Entity.Concrete;
using BrightApp.Entity.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategory(bool trackchanges);
        Category GetOneCategoryById(int id,bool trackchanges);
        Category CreateOneCategory(Category category);
        void UpdateOneCategory(int  id,CategoryDtoForUpdate categoryDto,bool trackchanges);
        void DeleteOneCategory(int id, bool trackchanges);
    }
}
