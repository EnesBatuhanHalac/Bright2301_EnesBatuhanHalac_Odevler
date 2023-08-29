using LanguesApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Entity.Concrete
{
    public class Langue:BaseEntity
    {
        public string Name { get; set; }
        public string About { get; set; }
        public string Url { get; set; }
        public List<LangueTeacher> LangueTeachers { get; set; }

    }
}
