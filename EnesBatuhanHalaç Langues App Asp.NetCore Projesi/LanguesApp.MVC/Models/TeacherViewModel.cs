using LanguesApp.Entity.Concrete;

namespace LanguesApp.MVC.Models
{
    public class TeacherViewModel
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; } 
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
