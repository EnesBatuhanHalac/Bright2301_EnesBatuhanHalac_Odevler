namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class LangueViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string? Url { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
