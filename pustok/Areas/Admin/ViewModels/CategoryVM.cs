using pustok.Areas.Admin.ViewModels;

namespace pustok.Areas.Admin.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductVM> Products { get; set; } = new List<ProductVM>();

    }
}