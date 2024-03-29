﻿using LanguesApp.Entity.Concrete;
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

        Task CreateAsync(Langue langue);
        void Update(Langue langue);
        void Delete(Langue langue);
        Task<List<Langue>> GetAllAsync();
        Task<Langue> GetByIdAsync(int id);
        #endregion


       #region Langue

        Task<List<Langue>> GetAllLangues(bool IsDeleted, bool? IsActive=null);
        #endregion
    }   
}
