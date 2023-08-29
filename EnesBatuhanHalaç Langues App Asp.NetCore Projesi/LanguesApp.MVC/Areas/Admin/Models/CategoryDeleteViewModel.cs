namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class CategoryDeleteViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abouth { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
