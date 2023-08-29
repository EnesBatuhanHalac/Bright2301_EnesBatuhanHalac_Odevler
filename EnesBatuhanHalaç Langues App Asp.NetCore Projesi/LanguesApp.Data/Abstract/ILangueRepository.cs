using LanguesApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Abstract
{
    public interface ILangueRepository:IGenericRepository<Langue>
    {
        Task<List<Langue>> GetAllLangues(bool IsDeleted,bool? IsActive = null);
    }
}
