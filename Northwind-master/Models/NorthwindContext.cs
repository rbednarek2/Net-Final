using Microsoft.EntityFrameworkCore;

namespace Northwind.Models
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            builder.Entity<OrderDetail>().HasKey(table => new
            {
                table.OrderID,
                table.ProductID
            });
        }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CategoryRevenue> CategoryRevenues { get; set; }
        public DbSet <Order> Orders { get; set; }
    }
}
