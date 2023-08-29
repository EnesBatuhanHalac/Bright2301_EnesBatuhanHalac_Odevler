using System.ComponentModel.DataAnnotations;

namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class CategoryEditViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Alanını Bos Bıraktiniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "About Alanini bos bıraktınız")]
        public string About { get; set; }
        public bool IsDeleted { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }
}
