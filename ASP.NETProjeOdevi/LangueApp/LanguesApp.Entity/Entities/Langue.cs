using LanguesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Entity.Entities
{
    public class Langue:BaseEntity
    {
        public string Name { get; set; }
        public string? About { get; set; }
        public List<LangueTeacher> LangueTeachers { get; set; }

    }
}
