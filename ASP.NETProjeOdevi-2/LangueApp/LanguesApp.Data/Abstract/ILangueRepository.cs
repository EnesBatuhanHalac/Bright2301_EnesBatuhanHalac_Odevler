using LanguesApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Data.Abstract
{
    public interface ILangueRepository:IGenericRepository<Langue>
    {
        Task<List<Langue>> GetAllLangues();

        Task<Langue> GetLangueById(int id);

    }
}
