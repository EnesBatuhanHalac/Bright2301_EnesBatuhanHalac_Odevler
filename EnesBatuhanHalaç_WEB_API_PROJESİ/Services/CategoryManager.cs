using AutoMapper;
using BrightApp.Data.Abstract;
using BrightApp.Entity.Concrete;
using BrightApp.Entity.DataTransferObjects;
using BrightApp.Entity.Exceptions;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public CategoryManager(IRepositoryManager manager, ILoggerService logger, IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper = mapper;
        }

        public Category CreateOneCategory(Category category)
        {
            
            _manager.Category.CreateCategory(category);
            _manager.save();
            return category;
            
        }

        public void DeleteOneCategory(int id, bool trackchanges)
        {
            var entity = _manager.Category.GetOneCategory(id,trackchanges);
            if (entity is null)
            throw new CategoryNotFoundException(id);
               

            _manager.Category.DeleteCategory(entity);
            _manager.save();
        }

        public IEnumerable<Category> GetAllCategory(bool trackchanges)
        {
            return _manager.Category.GetAllCategory(trackchanges);
        }

        public Category GetOneCategoryById(int id, bool trackchanges)
        {
            var category= _manager.Category.GetOneCategory(id, trackchanges);
            if (category == null)
                throw new CategoryNotFoundException(id);
            return category;
        }

        public void UpdateOneCategory(int id,
            CategoryDtoForUpdate categoryDto,
            bool trackchanges)
        {
            var entity = _manager.Category.GetOneCategory(id, trackchanges);
            if (entity is null)
            throw new CategoryNotFoundException(id);

            //entity.KategorininAktiflikDurumu = category.KategorininAktiflikDurumu;
            //entity.KategoriAciklamasi = category.KategoriAciklamasi;
            //entity.KategoriAdi = category.KategoriAdi;
            entity = _mapper.Map<Category>(categoryDto);


            _manager.Category.Update(entity);
            _manager.save();
        }
    }
}
