using LanguesApp.Data.Abstract;
using LanguesApp.Data.Concrete.EfCore.Context;
using LanguesApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Concrete.EfCore.Repositories
{
    public class EFCoreLangueRepository : EFCoreGenericRepository<Langue>, ILangueRepository
    {
        LanguesAppDbContext languesAppDbContext = new();
        public async Task<List<Langue>> GetAllLangues(bool IsDeleted,bool? IsActive = null)
        {
            var result = languesAppDbContext.Langues.Where(t => t.IsDeleted == IsDeleted).AsQueryable();
            if(IsActive != null)
            {
                result=result.Where(t=> t.IsActive == IsActive).AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
