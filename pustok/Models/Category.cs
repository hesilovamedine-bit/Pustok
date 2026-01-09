using Microsoft.AspNetCore.Http;
using pustok.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace pustok.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Image { get; set; }

        public bool IsDeleted { get; set; }

        [NotMapped]
        public IFormFile? Photo { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}
