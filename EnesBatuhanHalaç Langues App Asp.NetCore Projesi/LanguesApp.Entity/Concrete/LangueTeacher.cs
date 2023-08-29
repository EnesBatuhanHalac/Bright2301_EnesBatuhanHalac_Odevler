using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Entity.Concrete
{
    public class LangueTeacher
    {
        public int LangueId { get; set; }
        public Langue Langue { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
