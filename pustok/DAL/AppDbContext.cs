using Microsoft.EntityFrameworkCore;
using pustok.Models;
using pustok.Models.pustok.Models;

namespace pustok.DAL
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        //internal void SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
