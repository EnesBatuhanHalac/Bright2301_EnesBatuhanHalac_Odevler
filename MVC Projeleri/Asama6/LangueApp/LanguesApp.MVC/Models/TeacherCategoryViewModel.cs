using LanguesApp.Entity.Entities;

namespace LanguesApp.MVC.Models
{
    public class TeacherCategoryViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string About { get; set; }
        public string? Url { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string? Country { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }

    }
}
