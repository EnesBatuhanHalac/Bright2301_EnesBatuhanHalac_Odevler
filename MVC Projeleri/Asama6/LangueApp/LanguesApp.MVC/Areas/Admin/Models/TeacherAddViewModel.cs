using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class TeacherAddViewModel
    {
        [DisplayName("NameAndLastName")]
        [Required(ErrorMessage="{0} Alanı Boş Bırakılmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı en az {1} karakter uzunluğunda olmalıdır.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en az {1} karakter uzunluğunda olmalıdır.")]

        public string FullName { get; set; }

        [DisplayName("Hakkında")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı en az {1} karakter uzunluğunda olmalıdır.")]
        [MaxLength(1000, ErrorMessage = "{0} alanı en fazla {1} karakter uzunluğunda olmalıdır.")]
        public string About { get; set; }
 
        public decimal Price { get; set; }
        public string? Country { get; set; }
        public string Url { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }= "default-profile.jpg";
        public List<SelectListItem> Ages { get; set; }
    }
}
