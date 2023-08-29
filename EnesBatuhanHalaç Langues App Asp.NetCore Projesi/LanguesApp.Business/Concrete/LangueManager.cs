using LanguesApp.Business.Abstract;
using LanguesApp.Data.Abstract;
using LanguesApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Business.Concrete
{
    public class LangueManager:ILangueService
    {
        private readonly ILangueRepository _LangueRepository;

        public LangueManager(ILangueRepository langueRepository)
        {
            _LangueRepository = langueRepository;
        }

        public async Task CreateAsync(Langue langue)
        {
           await  _LangueRepository.CreateAsync(langue);
        }

        public void Delete(Langue langue)
        {
            _LangueRepository.Delete(langue);
        }

        public async Task<List<Langue>> GetAllAsync()
        {
           var result= await _LangueRepository.GetAllAsync();
            return result;
        }

        public async Task<List<Langue>> GetAllLangues(bool IsDeleted,bool? IsActive=null)
        {
            var result = await _LangueRepository.GetAllLangues(IsDeleted,IsActive);
            return result;
        }

        public async Task<Langue> GetByIdAsync(int id)
        {
           var result= await _LangueRepository.GetByIdAsync(id);
            return result;
        }

        public void Update(Langue langue)
        {
             _LangueRepository.Update(langue);
        }
    }
}
