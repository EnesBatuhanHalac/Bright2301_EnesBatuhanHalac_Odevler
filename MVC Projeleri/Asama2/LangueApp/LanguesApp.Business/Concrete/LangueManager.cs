using LanguesApp.Business.Abstract;
using LanguesApp.Data.Abstract;
using LanguesApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Business.Concrete
{
    public class LangueManager:ILangueService
    {
        private readonly ILangueRepository _repository;

        public LangueManager(ILangueRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(Langue langue)
        {
            await _repository.CreateAsync(langue);
        }

        public void Delete(Langue langue)
        {
            _repository.Delete(langue);
        }

        public async Task<List<Langue>> GetAllAsync()
        {
           var result= await _repository.GetAllAsync();
            return result;

        }

        public async Task<List<Langue>> GetAllLangues()
        {
            var result= await _repository.GetAllLangues();
            return result;
        }

        public async Task<Langue> GetByIdAsync(int id)
        {
           var result= await _repository.GetByIdAsync(id);
            return result;
        }

        public async Task<Langue> GetLangueById(int id)
        {
            var result= await _repository.GetLangueById(id);
            return result;
        }

        public void Update(Langue langue)
        {
              _repository.Update(langue);
            
        }
    }
}
