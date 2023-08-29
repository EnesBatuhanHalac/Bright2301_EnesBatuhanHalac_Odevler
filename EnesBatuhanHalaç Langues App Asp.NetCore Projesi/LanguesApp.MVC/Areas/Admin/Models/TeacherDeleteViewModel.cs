namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class TeacherDeleteViewModel
    {
        public int Id { get; set; }
        public string first_Name { get; set; }
        public string last_Name { get; set; }
        public string phoneNumber { get; set; }
        public double Price { get; set; }
        public string Url { get; set; }
        public string Country { get; set; }
        public string About { get; set; }
        public bool IsActive { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
