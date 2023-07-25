namespace LanguesApp.MVC.Models
{
    public class LangueViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public string? About { get; set; }
        public string? Url { get; set; }
        public bool IsActive { get; set; }
    }
}
