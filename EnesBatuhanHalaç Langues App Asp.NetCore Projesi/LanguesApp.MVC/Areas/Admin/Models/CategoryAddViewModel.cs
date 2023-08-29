using System.ComponentModel.DataAnnotations;

namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class CategoryAddViewModel
    {
        [Required(ErrorMessage ="Ad Alanını Bos Bıraktiniz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="About Alanini bos bıraktınız")]
        public string About { get; set; }
        public bool IsActive { get; set; }
    }
}
