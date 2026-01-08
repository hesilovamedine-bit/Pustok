using pustok.Areas.Admin.ViewModels;
using pustok.Models.Base;

namespace pustok.Models
{
    public class Featured : BaseEntity
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal PriceOld { get; set; }
        public decimal PriceDiscount { get; set; }
        public int CategoryId { get; set; }

    }
}