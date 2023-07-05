using LanguesApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Business.Abstract
{
    public interface ILangueService
    {
        #region Generic
        Task<Langue> GetByIdAsync(int? id);
        Task<List<Langue>> GetAllAsync();
        Task CreateAsync(Langue entity);
        void Update(Langue entity);
        void Delete(Langue entity);
        #endregion

        #region Abstract

        #endregion


    }
}
