using LanguesApp.Core.Abstract;
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
        public string? Url { get; set; }
        public bool IsActive { get; set; }
        public List<LangueTeacher> LangueTeachers { get; set; }

    }
}
