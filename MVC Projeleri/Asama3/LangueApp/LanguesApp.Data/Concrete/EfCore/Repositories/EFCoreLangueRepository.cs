using LanguesApp.Data.Abstract;
using LanguesApp.Data.Context;
using LanguesApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Concrete.EfCore.Repositories
{
    public class EFCoreLangueRepository : EFCoreGenericRepository<Langue>, ILangueRepository
    {
        LanguesAppDbContext _context = new LanguesAppDbContext();
        public async Task<List<Langue>> GetAllLangues()
        {
          
            var categories = _context.Langues.ToList();
            return categories;

        }

        public  async Task <Langue> GetLangueById(int id)
        {
            
            Langue result = _context.Langues.Where(l => l.Id == id).FirstOrDefault();

            return result;
            
            
        }
    }
}
