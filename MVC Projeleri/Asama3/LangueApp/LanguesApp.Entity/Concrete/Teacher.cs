using LanguesApp.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguesApp.Entity.Entities
{
    public class Teacher:BaseEntity
    {
        
        public string FullName { get; set; }
        public int Age { get; set; }
        public string About { get; set; }
        public List<LangueTeacher> LangueTeachers { get; set; }
        //public List LangueId { get; set; } 
        public string? Url { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string? Country { get; set; }
        public bool IsActive { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

    }
}
