using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class TeacherAddViewModel
    {
   

        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı en az {1} karakter uzunluğunda olmalıdır.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter uzunluğunda olmalıdır.")]
        public string FirstName { get; set; }

        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı en az {1} karakter uzunluğunda olmalıdır.")]
        [MaxLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter uzunluğunda olmalıdır.")]
        public string LastName { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Yaş alanı zorunlu boş bırakilmamali")]
        public int Age { get; set; } = 18;

        [DisplayName("Hakkında")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı en az {1} karakter uzunluğunda olmalıdır.")]
        [MaxLength(1000, ErrorMessage = "{0} alanı en fazla {1} karakter uzunluğunda olmalıdır.")]
        public string About { get; set; }

        public bool IsActive { get; set; }

        public string ImageUrl { get; set; } = "default-profile.jpg";
        public string Country { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [DisplayName("Price")]
        public int Price { get; set; }

        [Required(ErrorMessage ="Phone number is required")]
        [DisplayName("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DisplayName("Email")]
        public string Email { get; set; }

        public List<SelectListItem>? Ages { get; set; } //burası null geliyor bu nedenle model isvalid olmuyor


    }
}
