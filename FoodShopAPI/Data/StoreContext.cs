using FoodShopAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace FoodShopAPI.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}