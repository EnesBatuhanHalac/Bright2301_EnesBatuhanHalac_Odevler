using BrightApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightApp.Entity.DataTransferObjects
{
    public  record  CategoryDtoForUpdate
    {
        public string KategoriAdi { get; init; }
        public string KategoriAciklamasi { get; init; }
        public bool KategorininAktiflikDurumu { get; init; }
        public List<Course> Courses { get; init; }
    }
}
