using Microsoft.EntityFrameworkCore;
using WishList.WishList.Models;

namespace WishList.WishList.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Item> Items { get; set; }
        
        public ApplicationDbContext(DbContextOptions options): base()
        {
            
        }
    }
}
