﻿using LanguesApp.Entity.Entities;

namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string About { get; set; }
        public string? Url { get; set; }
        public decimal Price { get; set; }
        public string? Country { get; set; }
        public bool IsActive { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
      
    }
}
