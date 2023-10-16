using BrightApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.Concrete
{
    public class Setting:BaseEntity
    {
        public string FirmaAdi { get; set; }
        public string FirmaAdresi { get; set; }
        public string Hakkimizda { get; set; }
        public string IletisimBilgileri { get; set; }
        public string SıkSorularSorular { get; set; }
    }
}
