using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class TeacherAddViewModel
    {
        [DisplayName("FirstName And LastName")]
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılmamalıdır")]
        [MinLength(5,ErrorMessage ="{0} Alanı En az {1} karakter uzunlugunda olmalıdır.")]
        [MaxLength(40,ErrorMessage ="{0} Alanı En Fazla {1} Karakter Uzunlugunda Olmalıdır...")]
        public string FullName { get; set; }

        [Display(Name ="About The Teacher")]
        [Required(ErrorMessage ="{0} Alanı Bos Birakilmamalidir.")]
        [MaxLength(1000,ErrorMessage ="{0} Alanı En fazla 1000 karakterden olusmalidir.")]
        public string About { get; set; }

        public bool IsActive { get; set; }

        public string ImageUrl { get; set; } = "default-profile.jpg";

        [Required(ErrorMessage ="Ülke Bilgisi Girmek Zorunludur.")]
        public string Country { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; } = 18;

        [Required(ErrorMessage = "Email Bilgisi Zorunludur")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon Bilgisi Zorunludur")]
        public string Phone { get; set; }

        public List<SelectListItem> Ages { get; set; }



    }
}
