using LanguesApp.MVC.Models;

namespace LanguesApp.MVC.Areas.Admin.Models
{
    public class CategoryListViewModel
    {
        public List<LangueViewModel> CategoryViewModelList { get; set; }
        public string SourceAction { get; set; }
    }
}
