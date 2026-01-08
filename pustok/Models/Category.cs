using pustok.Models;
using pustok.Areas.Admin.ViewModels;
using pustok.Models.Base;

namespace pustok.Models
{
    namespace pustok.Models
    {
        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<Featured> Featureds { get; set; } = new List<Featured>();
            public object Photo { get; internal  set; }
            public string Image { get; internal set; }
            public bool IsDeleted { get; internal set; }
        }
    }
}