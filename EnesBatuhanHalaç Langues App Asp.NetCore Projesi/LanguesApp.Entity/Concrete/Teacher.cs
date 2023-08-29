using LanguesApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Entity.Concrete
{
    public class Teacher:BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; } = "default.jpg";
        public string PhoneNumber { get; set; }
        public int Age { get; set; } = 18;
        public int Price { get; set; }
        public List<LangueTeacher> LangueTeacher { get; set; }

    }
}
