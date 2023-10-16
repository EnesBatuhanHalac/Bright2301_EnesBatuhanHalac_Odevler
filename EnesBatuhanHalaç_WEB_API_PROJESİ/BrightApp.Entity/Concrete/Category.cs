using BrightApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.Concrete
{
    public class Category:BaseEntity
    {
        public string KategoriAdi { get; set; }
        public string KategoriAciklamasi { get; set; }
        public bool KategorininAktiflikDurumu { get; set; }
        public List<Course> Courses { get; set; }
    }
}
